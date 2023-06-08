#include <stdio.h>

/* Temperaturas.
El programa recibe como datos 24 números reales que representan las
temperaturas en el exterior en un período de 24 horas. Calcula el
promedio del día y las temperaturas máxima y mínima con la hora en la
que se registraron. */

void AcumTem(float);
void Maxima(float, int); /* Prototipos de funciones. */
void Minima(float, int);

float ACT = 0.0;
float MAX = -50.0; /* Variables globales. */
float MIN = 60.0;
int HMAX;
int HMIN;

void main(void)
{
    float TEM;
    int I;

    for (I = 1; I <= 24; I++)
    {
        printf("Ingresa la temperatura de la hora %d: ", I);
        scanf("%f", &TEM);
        AcumTem(TEM);
        Maxima(TEM, I); /* Llamada a las funciones. Paso de parámetros por valor. */
        Minima(TEM, I);
    }

    printf("\nPromedio del día: %5.2f", (ACT / 24));
    printf("\nMáxima del día: %5.2f \tHora: %d", MAX, HMAX);
    printf("\nMínima del día: %5.2f \tHora: %d", MIN, HMIN);
}

void AcumTem(float T)
{
    ACT += T;
}

void Maxima(float T, int H)
{
    if (MAX < T)
    {
        MAX = T;
        HMAX = H;
    }
}

void Minima(float T, int H)
{
    if (MIN > T)
    {
        MIN = T;
        HMIN = H;
    }
}
