function [Min]=RobotRunC(originPoint,finalPoint)
%% ��Ⱥ�㷨
%% ������ʼ��

close all;
clc;
%����·������


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
%����·��ͼ
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
S = originPoint;  %��ʼ��λ��
E = finalPoint;  %�յ�λ��

Path = 1:N;
[xx,yy] = Zuobiao(Path,px,py);
for i=1:N
    a = num2str(i);
    text(xx(i)+0.1,yy(i)+0.1,a);
end

Jie = Linjie(D);%�����ٽӾ���
Dis = Distance(N,D); %����N*N�ľ������
Gen =80;   %��������
M = 50;        %�Ŵ���Ⱥ��С
BestPath = cell(Gen,M);%·���洢
TheDis = zeros(Gen,M);%·�̾���洢
Tau = ones(N,N);
Tau = Tau.*4; %��Ϣ��
a = 1;%��Ϣ������
b = 6;%��������
Q = 1;
p = 0.3;
Eau = 10*Eauu(N,E,px,py);%����������Ϊ����ĵ�����
%% ����
for gen=1:Gen
    for ant=1:M
        Path = []; %�洢·������
        Start = S;  %��ʼ��·��        
        while Start ~= 0 
            Path = [Path,Start];
            Ban = 1:N;  %·�����ɱ�
            for k=1:N   %�����һ������֮·
                if Jie(Start,k) == 0
                    Ban(k) = 0;
                end
            end  
            for k=1:length(Path)%%���߻�ͷ·
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
            %��������ͬ�ж�
            Index = find(Ban);
            if (length(Index)) == 0 %%�ж��Ƿ����
                break;
            end

            Can = Ban(Index);
            fitn = zeros(1,length(Can));
            for k=1:length(Can)
                fitn(k) = ((Tau(Start,Can(k)))^a) * ((Eau(Can(k)))^b) ;%���������յ�·��Ѱ��
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
    %% ������Ϣ��
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

%% ����·��ͼ
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



            






