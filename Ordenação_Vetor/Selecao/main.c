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

    //Orden��o
    for(i=0; i<4; i++)
    {
        min=i;  //Essa variav�l minima armazena a atual posi��o do i e ela vai dizer que o menor valor atual est� nessa posi��o i
        for(j=(i+1); j<5; j++) //Aqui � feita a compara��o da posi��o atual (i) com as demais
        {
            if(v[j]<v[min])
                min=j;
        }
        if(i != min)  //Se o valor que est� na posi��o i N�O for o m�nimo. Aqui s� � feita a troca, pois ele j� sabe que est� diferente por conta da compara��o feita acima
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
