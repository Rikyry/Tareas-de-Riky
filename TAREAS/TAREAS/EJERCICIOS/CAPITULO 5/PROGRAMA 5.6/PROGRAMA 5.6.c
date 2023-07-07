#include <stdio.h>
#include <math.h>

/* Suma-cuadrados.
El programa calcula la suma del cuadrado de los elementos de un arreglo unidimensional
de 100 elementos de tipo real. */

const int MAX = 100;

void Lectura(float *, int);
double Suma(float *, int);

int main(void) {
    float VEC[MAX];
    double RES;

    Lectura(VEC, MAX);
    RES = Suma(VEC, MAX);

    printf("\n\nSuma del arreglo: %.2lf", RES);

    return 0;
}

void Lectura(float A[], int T) {
    int I;
    for (I = 0; I < T; I++) {
        printf("Ingrese el elemento %d: ", I + 1);
        scanf("%f", &A[I]);
    }
}

double Suma(float A[], int T) {
    int I;
    double AUX = 0.0;
    for (I = 0; I < T; I++) {
        AUX += pow(A[I], 2);
    }
    return AUX;
}
