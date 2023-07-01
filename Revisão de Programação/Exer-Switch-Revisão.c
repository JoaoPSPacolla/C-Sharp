#include <stdio.h>
#include <stdlib.h>

int main()
{
    int num;

    printf("Escreva um numero entre 1 e 12: ");
    scanf("%d", &num);

    switch (num){
        case 12:
                printf("dezembro");
                break;
        case 11:
                printf("novembro");
                break;
        case 10:
                printf("outubro");
                break;
        case 9:
                printf("setembro");
                break;
        case 8:
                printf("agosto");
                break;
        case 7:
                printf("julho");
                break;
        case 6:
                printf("junho");
                break;
        case 5:
                printf("maio");
                break;
        case 4:
                printf("abril");
                break;
        case 3:
                printf("março");
                break;
        case 2:
                printf("Fevereiro");
                break;
        case 1:
                printf("Janeiro");
                break;
        default:
                printf("Não correspondente");
    }


    return 0;
}
