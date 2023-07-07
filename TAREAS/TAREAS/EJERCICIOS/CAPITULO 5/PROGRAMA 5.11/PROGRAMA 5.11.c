#include <stdio.h>

/* B�squeda binaria. */
const int MAX = 100;

void Lectura(int *, int); /* Prototipos de funciones. */
int Binaria(int *, int, int);

int main(void)
{
    int RES, ELE, TAM, VEC[MAX];

    do
    {
        printf("Ingrese el tamano del arreglo: ");
        scanf("%d", &TAM);
    }
    while (TAM > MAX || TAM < 1); /* Se verifica que el tama�o del arreglo sea correcto. */

    Lectura(VEC, TAM);

    printf("Ingrese el elemento a buscar: ");
    scanf("%d", &ELE);

    RES = Binaria(VEC, TAM, ELE); /* Se llama a la funci�n que busca en el arreglo. */

    if (RES != -1)
    {
        printf("El elemento se encuentra en la posicion: %d\n", RES);
    }
    else
    {
        printf("El elemento no se encuentra en el arreglo\n");
    }

    return 0;
}

void Lectura(int A[], int T)
/* La funci�n Lectura se utiliza para leer un arreglo unidimensional de T elementos de tipo entero. */
{
    int I;
    for (I = 0; I < T; I++)
    {
        printf("Ingrese el elemento %d: ", I + 1);
        scanf("%d", &A[I]);
    }
}

int Binaria(int A[], int T, int E)
/* Esta funci�n se utiliza para realizar una b�squeda binaria del elemento E en el arreglo unidimensional A de T elementos.
   Si se encuentra el elemento, la funci�n regresa la posici�n correspondiente.
   En caso contrario, regresa -1. */
{
    int IZQ = 0, CEN, DER = T - 1, BAN = 0;

    while (IZQ <= DER && !BAN)
    {
        CEN = (IZQ + DER) / 2;

        if (E == A[CEN])
        {
            BAN = CEN + 1; /* Se asigna CEN+1 dado que las posiciones en el arreglo comienzan desde cero. */
        }
        else if (E > A[CEN])
        {
            IZQ = CEN + 1;
        }
        else
        {
            DER = CEN - 1;
        }
    }

    return BAN;
}
