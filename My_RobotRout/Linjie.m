%% ¡ŸΩ”æÿ’Û
 function [Jie] = Linjie(D)
 [px,py] = size(D);
 N = px*py;
 Jie = zeros(N,N);
 for i=1:px
     for j=1:py
         if D(i,j) == 0
             for m=1:px
                 for n=1:py
                     if D(m,n) == 0 && ((i-m)^2 + (j-n)^2) <= 2
                         Jie((i-1)*px+j,(m-1)*py+n) = sqrt(((i-m)^2 + (j-n)^2));
                     end
                 end
             end
         end
     end
 end
 end
