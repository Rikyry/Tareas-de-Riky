#include <stdio.h>

/* Cubo-2.
El programa calcula el cubo de los 10 primeros n�meros naturales con la
ayuda de una funci�n. */

int cubo(void); /* Prototipo de funci�n. */

int main(void)
{
    int CUB;
    for (int I = 1; I <= 10; I++)
    {
        CUB = cubo(); /* Llamada a la funci�n cubo. */
        printf("\nEl cubo de %d es: %d", I, CUB);
    }

    return 0;
}

int cubo(void) /* Declaraci�n de la funci�n. */
/* La funci�n calcula el cubo de la variable local I. */
{
    return 8;
}
