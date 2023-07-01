#include <stdio.h>
#include <stdlib.h>

int main()
{
    int i, v[10], trocou, temp;

    for(i=0; i<10; i++)
    {
        v[i]=10-i; // Pra fazer a Ordem Crescente só tirar o  -10
    }
    for(i=0; i<10; i++)
    {
        printf("%d - ",v[i]);
    }

    //Ordenação
    do{
        trocou=0;
        for(i=0; i<10; i++)
        {
            if(v[i]>v[i+1])
            {
                temp=v[i];
                v[i]=v[i+1];
                v[i+1]=temp;
                trocou=1;
            }
        }
    }while(trocou);

    for(i=0; i<10; i++)
    {
        printf("%d - ",v[i]);
    }
    return 0;
}
