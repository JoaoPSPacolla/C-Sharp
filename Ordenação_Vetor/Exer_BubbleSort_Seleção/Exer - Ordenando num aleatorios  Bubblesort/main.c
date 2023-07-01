#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main()
{
    int i, temp,v[10],trocou;

    //Gerador de enumeros aleatorios
    srand(time(NULL));
    for (i=0;i<10;i++)
    {
        v[i] = rand()%100;
    }
    clock_t tempo;
    tempo = clock();

    printf("\n Vetor original: ");
    for (i=0;i<10;i++)
        printf("%d\t",v[i]);

    //Ordenção
    do{
        trocou=0;
        for(i=0;i<10;i++){
            if (v[i]>v[i+1])
            {
                temp = v[i];
                v[i] = v[i+1];
                v[i+1] = temp;
                trocou = 1;
            }
          }
    }while(trocou);

    printf("Tempo: \n",(clock()-tempo)/ (double)CLOCKS_PER_SEC);
    printf("\nVetor ordenado: ");
    for (i=0;i<10;i++)
        printf("%d\t",v[i]);
    return 0;
}
