#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main()
{
    int i, j, v[10], min;

    for(i=0;i<10;i++){
        v[i] = rand()%100;
    }
    clock_t tempo;
    tempo = clock();

    printf("Vetor original: ");
    for(i=0;i<10;i++)
            printf("%d - ",v[i]);

    printf("\n");

    //Ordenação Seleção
    for(i=0; i<9; i++)
    {
        min=i;
        for(j=(i+1); j<10; j++)
        {
            if(v[j]<v[min])
                min=j;
        }
        if(i !=min)
        {
            int temp=v[i];
            v[i]=v[min];
            v[min]=temp;
        }
    }

    printf("Novo vetor: ");
    for(i=0;i<10;i++)
        printf("%d - ",v[i]);

    printf("Tempo: \n",(clock()-tempo)/ (double)CLOCKS_PER_SEC);
    return 0;
}
