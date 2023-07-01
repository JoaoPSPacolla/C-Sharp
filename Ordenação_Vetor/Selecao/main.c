#include <stdio.h>
#include <stdlib.h>

int main()
{
    int i, j, min, v[5];
    for(i=0; i<5; i++)
    {
        printf("Digite o %do. numero do vetor: ",i+1);
        scanf("%d",&v[i]);
    }
    printf("\nO vetor original: ");
    for(i=0; i<5; i++)printf("%d\t",v[i]);

    //Ordenção
    for(i=0; i<4; i++)
    {
        min=i;  //Essa variavél minima armazena a atual posição do i e ela vai dizer que o menor valor atual está nessa posição i
        for(j=(i+1); j<5; j++) //Aqui é feita a comparação da posição atual (i) com as demais
        {
            if(v[j]<v[min])
                min=j;
        }
        if(i != min)  //Se o valor que está na posição i NÂO for o mínimo. Aqui só é feita a troca, pois ele já sabe que está diferente por conta da comparação feita acima
        {
            int temp=v[i];
            v[i]=v[min];
            v[min]=temp;
        }
    }

    printf("\nO vetor ordenado: ");
    for(i=0; i<5; i++)printf("%d\t",v[i]);
    printf("\n\n");
    return 0;
}
