#include <stdio.h>
#include <stdlib.h>

int main()
{
    int i,j,m[4][4],maior=0,menor;

    for(i=0;i<4;i++)
    {
        for(j=0;j<4;j++)
        {
            printf("Digite os numeros da matriz: ");
            scanf("%d",&m[i][j]);
        }
    }

    for(i=0;i<4;i++){
        for(j=0;j<4;j++){
            if(maior<m[i][j])
                maior=m[i][j];
            if(menor>m[i][j])
                menor=m[i][j];
        }
    }

    printf("O maior valor: %d. O menor: %d", maior, menor);
    return 0;
}
