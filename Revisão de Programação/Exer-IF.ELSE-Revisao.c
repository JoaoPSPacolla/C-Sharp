#include <stdio.h>
#include <stdlib.h>

int main()
{
    int num;

    printf("Escreva um numero entre 1 e 12: ");
    scanf("%d", &num);

    if (num==1)
        printf("Janeiro");
    else if (num==2)
        printf("Fevereiro"); //esse else if vai fazer com que o programa n�o teste os outros comandos caso a resposta j� esteja certa
    if (num==3)
        printf("mar�o");
    if (num==4)
        printf("abril");
    if (num==5)
        printf("maio");
    if (num==6)
        printf("junho");
    if (num==7)
        printf("julho");
    if (num==8)
        printf("agosto");
    if (num==9)
        printf("setembro");
    if (num==10)
        printf("outubro");
    if (num==11)
        printf("novembro");
    if (num==12)
        printf("dezembro");
    else
        printf("N�o corresponde");


    return 0;
}
