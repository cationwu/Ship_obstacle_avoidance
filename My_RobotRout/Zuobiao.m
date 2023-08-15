%% 中间坐标函数
function [x,y] = Zuobiao(Path,px,py)
L = length(Path);
for i=1:L
    x(i) = mod(Path(i),px) - 0.5;
    if x(i) < 0
        x(i) = py - 0.5;
    end
    y(i) = px - ceil(Path(i)/py) + 0.5;
end
end

