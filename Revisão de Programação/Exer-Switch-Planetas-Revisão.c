#include <stdio.h>
#include <stdlib.h>

int main()
{
    int n;
    float p, c;
    printf("Digite o peso do objeto na Terra (em Kg) e um numero para um planeta:\n");
    scanf("%f %d",&p,&n);

    switch (n){
        case 1:
            c = (p * 0.37);
            printf("O planeta e Mercurio e o peso e %.2f", c);
            break;
        case 2:
            c = (p * 0.88);
            printf("O planeta e Venus e o peso e %.2f", c);
            break;
        case 3:
            c = (p * 0.38);
            printf("O planeta e Marte e o peso e %.2f", c);
            break;
        case 4:
            c = (p * 2.64);
            printf("O planeta e Jupiter e o peso e %.2f", c);
            break;
        case 5:
            c = (p * 1.15);
            printf("O planeta e Saturno e o peso e %.2f", c);
            break;
        case 6:
            c = (p * 1.17);
            printf("O planeta e Urano e o peso e %.2f", c);
            break;
    }
    return 0;
}
