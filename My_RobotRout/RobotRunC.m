function [Min]=RobotRunC(originPoint,finalPoint)
%% 蚁群算法
%% 参数初始化

close all;
clc;
%生成路径矩阵


D=[0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0; 
   0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0; 
   0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0; 
   0 0 0 0 0 0 0 1 1 0 0 0 0 0 0 0 0 0 0 0; 
   0 0 0 0 1 1 0 1 1 0 1 1 0 1 1 0 0 0 0 0; 
   0 0 0 0 1 1 0 0 0 0 1 1 0 1 1 0 0 0 0 0; 
   0 0 0 0 1 1 0 0 0 0 0 0 0 0 0 0 0 0 0 0; 
   0 0 0 0 0 0 0 0 0 1 0 0 0 1 1 0 0 0 0 0; 
   0 0 0 0 0 0 0 0 1 1 0 0 0 0 1 0 0 0 0 0; 
   0 0 0 0 0 0 0 0 0 0 0 0 1 0 0 0 0 0 0 0; 
   0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0; 
   0 0 0 0 0 1 1 1 0 0 0 0 0 0 0 0 0 0 0 0; 
   0 0 0 0 0 0 1 1 0 0 0 1 0 0 0 1 1 0 0 0; 
   0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0; 
   0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0; 
   0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0; 
   0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0; 
   0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0; 
   0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0; 
   0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0;];

[px,py] = size(D);
%画出路径图
figure(1)
axis([0,px,0,py]);
for i=1:px
    for j=1:py
        if D(i,j) == 1
            x1 = j-1;   y1 = px-i+1;
            x2 = j;     y2 = px-i+1;
            x3 = j;     y3 = px-i;
            x4 = j-1;   y4 = px-i;
            fill([x1,x2,x3,x4],[y1,y2,y3,y4],[0.2,0.2,0.2]);
            hold on
        else
            x1 = j-1;   y1 = px-i+1;
            x2 = j;     y2 = px-i+1;
            x3 = j;     y3 = px-i;
            x4 = j-1;   y4 = px-i;
            fill([x1,x2,x3,x4],[y1,y2,y3,y4],[1,1,1]);
            hold on
        end
    end
end

hold on

N = px*py;
S = originPoint;  %初始化位置
E = finalPoint;  %终点位置

Path = 1:N;
[xx,yy] = Zuobiao(Path,px,py);
for i=1:N
    a = num2str(i);
    text(xx(i)+0.1,yy(i)+0.1,a);
end

Jie = Linjie(D);%生成临接矩阵
Dis = Distance(N,D); %生成N*N的距离矩阵
Gen =80;   %迭代次数
M = 50;        %遗传种群大小
BestPath = cell(Gen,M);%路径存储
TheDis = zeros(Gen,M);%路程距离存储
Tau = ones(N,N);
Tau = Tau.*4; %信息素
a = 1;%信息素因子
b = 6;%启发因子
Q = 1;
p = 0.3;
Eau = 10*Eauu(N,E,px,py);%启发函数（为距离的倒数）
%% 迭代
for gen=1:Gen
    for ant=1:M
        Path = []; %存储路径矩阵
        Start = S;  %初始化路径        
        while Start ~= 0 
            Path = [Path,Start];
            Ban = 1:N;  %路径禁忌表
            for k=1:N   %求出下一步可行之路
                if Jie(Start,k) == 0
                    Ban(k) = 0;
                end
            end  
            for k=1:length(Path)%%不走回头路
                Ban(Path(k)) = 0;
            end 
            
            Index = find(Ban);
            for t=1:(length(Index))
                [xx1,yy1] = ZZ(Start,px,py);
                [xx2,yy2] = ZZ(Ban(Index(t)),px,py);
                if yy2 < yy1
                    Ban(Index(t)) = 0;
                end                
            end
                

            if Path(end) == E
                break;
            end
            %进入死胡同中断
            Index = find(Ban);
            if (length(Index)) == 0 %%判断是否结束
                break;
            end

            Can = Ban(Index);
            fitn = zeros(1,length(Can));
            for k=1:length(Can)
                fitn(k) = ((Tau(Start,Can(k)))^a) * ((Eau(Can(k)))^b) ;%启发函数诱导路径寻找
            end
            fitness = cumsum(fitn./(sum(fitn)));        
            Pot = find(rand < fitness);
            Pot = Pot(1);
            Start = Can(Pot);    
        end
        BestPath{gen,ant} = Path;
        if Path(end) == E
            for k = 1:length(Path)-1
                TheDis(gen,ant) = TheDis(gen,ant) + Dis(k,k+1);
            end
        else
            TheDis(gen,ant) = TheDis(gen,ant) + Inf;
        end 
    end
    %% 更新信息素
    Lin_Tau = zeros(N,N);
    for m=1:M
        if TheDis(gen,m) < N*N
            Lin_Path = BestPath{gen,m}; 
            Len = length(Lin_Path);
            for k=1:Len-1
                Lin_Tau(Lin_Path(k),Lin_Path(k+1)) = Lin_Tau(Lin_Path(k),Lin_Path(k+1)) + ...
                    Q/(TheDis(gen,m));
                Lin_Tau(Lin_Path(k+1),Lin_Path(k)) = Lin_Tau(Lin_Path(k+1),Lin_Path(k)) + ...
                    Q/(TheDis(gen,m));
            end
        end
    end
    
    Tau = Tau.*(1-p) + Lin_Tau;
            
    
    
end

%% 画出路径图
Min = Inf;
for i=1:Gen
    for j=1:M
        if Min > TheDis(i,j)
            Min = TheDis(i,j);
            Index = [];
            Index = [i,j];
        end       
    end
end
Path = BestPath{Index(1),Index(2)};
[x,y] = Zuobiao(Path,px,py);           
plot(x,y,'r-');  
% disp(num2str(Min));



            






