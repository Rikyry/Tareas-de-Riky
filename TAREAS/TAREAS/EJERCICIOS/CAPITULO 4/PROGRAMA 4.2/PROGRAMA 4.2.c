#include <stdio.h>

/* Cubo-2.
El programa calcula el cubo de los 10 primeros números naturales con la
ayuda de una función. */

int cubo(void); /* Prototipo de función. */

int main(void)
{
    int CUB;
    for (int I = 1; I <= 10; I++)
    {
        CUB = cubo(); /* Llamada a la función cubo. */
        printf("\nEl cubo de %d es: %d", I, CUB);
    }

    return 0;
}

int cubo(void) /* Declaración de la función. */
/* La función calcula el cubo de la variable local I. */
{
    return 8;
}
