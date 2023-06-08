#include <stdio.h>

/* Conflicto de variables con el mismo nombre. */

void f1(void); /* Prototipo de función. */

int K = 5; /* Variable global. */

int main(void)
{
    int I;
    for (I = 1; I <= 3; I++)
    {
        f1();
    }

    return 0;
}

void f1(void) /* La función utiliza tanto la variable local I como la variable global I. */
{
    int K_local = 2; /* Variable local. */
    K_local += K_local;
    printf("\n\nEl valor de la variable local es: %d", K_local);
    K = K + K_local; /* Uso de ambas variables. */
    printf("\nEl valor de la variable global es: %d", K);
}
