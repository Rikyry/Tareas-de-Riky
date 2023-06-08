#include <stdio.h>

/* Rango de calificaciones
El programa, al recibir como dato una serie de calificaciones, obtiene el rango en el que se encuentran. */

void Rango(float); /* Prototipo de función. */
unsigned int RA1 = 0;
unsigned int RA2 = 0;
unsigned int RA3 = 0; /* Variables globales de tipo entero sin signo. */
unsigned int RA4 = 0;
unsigned int RA5 = 0;
/* El uso de variables globales no es muy recomendable. En estos problemas se utilizan únicamente con el objetivo de que el lector pueda observar la forma en que se aplican. */

void main(void)
{
    float CAL;
    printf("Ingresa la primera calificacion del alumno (ingresa 0 para finalizar): ");
    scanf("%f", &CAL);
    while (CAL != 0)
    {
        Rango(CAL); /* Llamada a la función Rango. Se pasa un parámetro por valor. */
        printf("Ingresa la siguiente calificacion del alumno (ingresa 0 para finalizar): ");
        scanf("%f", &CAL);
    }
    printf("\n0..3.99 = %u", RA1);
    printf("\n4..5.99 = %u", RA2);
    printf("\n6..7.99 = %u", RA3);
    printf("\n8..8.99 = %u", RA4);
    printf("\n9..10 = %u", RA5);
}

void Rango(float VAL)
/* La función incrementa una variable dependiendo del valor del parámetro VAL. */
{
    if (VAL < 4)
        RA1++;
    else if (VAL < 6)
        RA2++;
    else if (VAL < 8)
        RA3++;
    else if (VAL < 9)
        RA4++;
    else
        RA5++;
}

