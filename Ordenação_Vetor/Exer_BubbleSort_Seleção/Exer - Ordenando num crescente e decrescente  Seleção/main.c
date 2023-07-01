#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main()
{
    int i, j, min, v[10];

    for(i=0;i<10;i++)
        v[i] = 10-i;

    printf("Vetor original: ");
    for(i=0;i<10;i++)
        printf("%d ",v[i]);

    for(i=0;i<9;i++){
        min = i;
        for(j=(i+1);j<10;j++){
        if(v[j]<v[min])
            min = j;
        }
        if(i != min){
            int temp = v[i];
            v[i] = v[min];
            v[min] = temp;
        }
    }

    printf("Valor ordenado: ");
    for(i=0;i<10;i++)
        printf("%d ",v[i]);

    return 0;
}
