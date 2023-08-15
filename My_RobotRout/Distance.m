%% æ‡¿Îæÿ’Û
function [ Dis ] = Distance(N,D)
Dis = zeros(N,N);
[px,py] = size(D);
for i=1:N
    x1 = ceil(i/px);
    y1 = mod(i,py);
    if y1 == 0
        y1 = py;
    end
    for j=1:N        
        x2 = ceil(j/px);
        y2 = mod(j,py);
        if y2 == 0
            y2 = py;
        end
        Dis(i,j) = sqrt((x2-x1)^2 + (y1-y2)^2);
    end
end
end
