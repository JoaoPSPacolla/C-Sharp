#include <stdio.h>
#include <stdlib.h>

void main()
{
    int primo, cont=0, i=1;
    printf("Digite um numero: ");
    scanf("%d", &n);

    do{
        if(n%i==0)
            cont++;
        i++;
    }while(i <= n);

    if(cont==2)
        printf("O numero e %d primo",n);
    else
        printf("O numero %d nao e primo",n);

}
