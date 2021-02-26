% Opcion 1
clear all
% Datos experimento
datos=[0*ones(1,4),50*ones(1,7),100*ones(1,8),150*ones(1,4),200*ones(1,8),250*ones(1,11),300*ones(1,4),350*ones(1,5),400*ones(1,8),450*ones(1,3),500*ones(1,4),550*ones(1,4),600*ones(1,5),650*ones(1,4),700*ones(1,6),750*ones(1,4),800*ones(1,0),850*ones(1,3),900*ones(1,3),950*ones(1,0),1000*ones(1,3),1050*ones(1,0),1100*ones(1,1),1150*ones(1,1),1200*ones(1,0),1300*ones(1,0),1500*ones(1,0)];
% a->Los datos b->Cantidad de veces
[a,b]=hist(datos,[0,50,100,150,200,250,300,350,400,450,500,550,600,650,700,750,800,850,900,950,1000,1050,1100,1150,1200,1300,1500]);
% N ->Cantidad de datos
N=length(datos);
% Probabilidad de cada dato
pro=a/N;
% F -> Probabilidad Acumulada
F=cumsum(pro);
% Media de los datos
media=0;
varianza=0;
for i=1:length(b)
    media= media + b(i)*pro(i);
    varianza= varianza + (b(i).^2)*pro(i);
end
% Varianza de los datos
varianza=varianza-media.^2;
% Generador 
for i=1:10000
    r=rand;
    if r<F(1)
        gen(i)=b(1);
    elseif r<F(2)
        gen(i)=b(2);
    elseif r<F(3)
        gen(i)=b(3);
    elseif r<F(4)
        gen(i)=b(4);
    elseif r<F(5)
        gen(i)=b(5);
    elseif r<F(6)
        gen(i)=b(6);
    elseif r<F(7)
        gen(i)=b(7);
    elseif r<F(8)
        gen(i)=b(8);
    elseif r<F(9)
        gen(i)=b(9);
    elseif r<F(10)
        gen(i)=b(10);
    elseif r<F(11)
        gen(i)=b(11);
    elseif r<F(12)
        gen(i)=b(12);
    elseif r<F(13)
        gen(i)=b(13);
    elseif r<F(14)
        gen(i)=b(14);
    elseif r<F(15)
        gen(i)=b(15);
    elseif r<F(16)
        gen(i)=b(16);
    elseif r<F(17)
        gen(i)=b(17);
    elseif r<F(18)
        gen(i)=b(18);
    elseif r<F(19)
        gen(i)=b(19);
    elseif r<F(20)
        gen(i)=b(20);
    elseif r<F(21)
        gen(i)=b(21);
    elseif r<F(22)
        gen(i)=b(22);
    elseif r<F(23)
        gen(i)=b(23);
    elseif r<F(24)
        gen(i)=b(24);
    elseif r<F(25)
        gen(i)=b(25);
    elseif r<F(26)
        gen(i)=b(26);
    else
        gen(i)=b(27);
    end
end
figure
% Grafica de distribucion de probabilidad experimental
bar(b,pro)
figure
% Grafica de distribucion acumulada de probabilidad experimental
bar(b,F)
figure
% Histograma generador
hist(gen,[0,50,100,150,200,250,300,350,400,450,500,550,600,650,700,750,800,850,900,950,1000,1050,1100,1150,1200,1300,1500])
figure
% Histograma experimental
hist(datos,[0,50,100,150,200,250,300,350,400,450,500,550,600,650,700,750,800,850,900,950,1000,1050,1100,1150,1200,1300,1500])

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

%Opcion 2
clear all
% Datos experimento
datos2=[0*ones(1,56),50*ones(1,47),150*ones(1,41),200*ones(1,71),300*ones(1,39),500*ones(1,46)];
% a2->Los datos b2->Cantidad de veces
[a2,b2]=hist(datos2,[0,50,150,200,300,500]);
% N2->Cantidad de datos
N2=length(datos2);
% Probabilidad de cada dato
pro2=a2/N2;
% F -> Probabilidad Acumulada
F2=cumsum(pro2);
% Media de los datos
media2=0;
varianza2=0;
for i=1:length(b2)
    media2= media2 + b2(i)*pro2(i);
    varianza2= varianza2 + (b2(i).^2)*pro2(i);
end
% Varianza de los datos
varianza2=varianza2-media2.^2;
% Generador 
for i=1:10000
    r2=rand;
    if r2<F2(1)
        gen2(i)=b2(1);
    elseif r2<F2(2)
        gen2(i)=b2(2);
    elseif r2<F2(3)
        gen2(i)=b2(3);
    elseif r2<F2(4)
        gen2(i)=b2(4);
    elseif r2<F2(5)
        gen2(i)=b2(5);
    else
        gen2(i)=b2(6);
    end
end
figure
% Grafica de distribucion de probabilidad experimental
bar(b2,pro2);
figure
% Grafica de distribucion acumulada de probabilidad experimental
bar(b2,F2);
figure
% Histograma generador
hist(gen2,[0,50,150,200,300,500])
figure
% Histograma experimental
hist(datos2,[0,50,150,200,300,500])