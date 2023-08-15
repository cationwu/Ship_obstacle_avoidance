%% Çó×ø±êº¯Êý
function [ x, y ] = ZZ(Num,px,py)
x = ceil(Num/px);
y = mod(Num,py);
if y == 0
    y = py;
end         
end

