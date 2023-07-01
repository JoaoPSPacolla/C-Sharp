#include <stdio.h>
#include <stdlib.h>

int main()
{
    int i,j,m[3][4],linha,coluna,posicao=0, ponto;

    for(i=0;i<3;i++){
        for(j=0;j<4;j++){
            printf("Digite um valor para a matriz: ");
            scanf("%d",&m[i][j]);
        }
    }

    for (i=0;i<3;i++){
        for(j=0;j<4;j++){
            printf("%d - ", m[i][j]);
        }
    }

    for(i=0;i<3;i++){
            linha = m[i][0];
            posicao = 0;
        for(j=0;j<4;j++){
            if (linha > m[i][j])
                linha=m[i][j];
                posicao=j;

        }

    coluna = m[0][posicao];
    for(i=0;i<3;i++){
        if(coluna < m[i][posicao])
            coluna = m[i] [posicao];
        }
        if(linha==coluna){
            printf("\nPonto de sela: Matriz[%d][%d] = %d",i,posicao,m[i][posicao]);
            ponto=1;
        }
        if(ponto==0)
            printf("Não existe ponto sela\n");

}

    return 0;
}
