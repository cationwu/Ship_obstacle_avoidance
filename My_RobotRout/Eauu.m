function [ Eau ] = Eauu(N,E,px,py)
[Ex,Ey] = ZZ(E,px,py);
for i=1:N
    if i ~= E
        [xx,yy] = ZZ(i,px,py);
        Eau(i) = 1/(sqrt((xx-Ex)^2 + (yy-Ey)^2));
    else
        Eau(i) = 10;
    end
end
end
    

