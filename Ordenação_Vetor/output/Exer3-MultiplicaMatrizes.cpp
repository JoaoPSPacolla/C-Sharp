#include <stdio.h>
#include <stdlib.h>

int main()
{
    int m1[3][3], m2[3][3], i, j, k;
    int  result[3][3] = {0};

    // Matriz 1 - entrada 
    for (i=0;i<3;i++)
        for(j=0;j<3;j++){
            printf("Digite um numero para a posicao [%d][%d] da primeira matriz: ", i,j);
            scanf("%d",&m1[i][j]);
        }

    printf("\n\n");

    // Matriz 2 - entrada
    for (i=0;i<3;i++)
        for ( j = 0; j < 3; j++)
        {
            printf("Digite um numero para a posicao [%d][%d] da segunda matriz: ", i,j);
            scanf("%d",&m2[i][j]);
        }
        
    // Multiplicando matrizes 
    for (i=0;i<3;i++)
        for(j=0;j<3;j++)
           for(k=0;k<3;k++)
                result[i][j] += m1[k][j] * m2[i][k]; 
        
    //Printando
    for (i=0;i<3;i++)
        for(j=0;j<3;j++)
            printf ("%d - ", result[i][j]);
        
    printf("\n");

    return 0;
}
