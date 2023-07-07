#include <stdio.h>

#define N 3

void imprimirMatriz(float matriz[N][N]) {
    for (int i = 0; i < N; i++) {
        for (int j = 0; j < N; j++) {
            printf("%.2f ", matriz[i][j]);
        }
        printf("\n");
    }
}

void intercambiarFilas(float matriz[N][N], int fila1, int fila2) {
    for (int j = 0; j < N; j++) {
        float temp = matriz[fila1][j];
        matriz[fila1][j] = matriz[fila2][j];
        matriz[fila2][j] = temp;
    }
}

void dividirFila(float matriz[N][N], int fila, float divisor) {
    for (int j = 0; j < N; j++) {
        matriz[fila][j] /= divisor;
    }
}

void restarFilas(float matriz[N][N], int fila1, int fila2, float factor) {
    for (int j = 0; j < N; j++) {
        matriz[fila1][j] -= factor * matriz[fila2][j];
    }
}

void inversaMatriz(float matriz[N][N], float inversa[N][N]) {
    for (int i = 0; i < N; i++) {
        for (int j = 0; j < N; j++) {
            inversa[i][j] = (i == j) ? 1.0 : 0.0;
        }
    }

    for (int j = 0; j < N; j++) {
        int pivot = -1;

        for (int i = j; i < N; i++) {
            if (matriz[i][j] != 0.0) {
                pivot = i;
                break;
            }
        }

        if (pivot == -1) {
            printf("La matriz no es invertible.\n");
            return;
        }

        intercambiarFilas(matriz, j, pivot);
        intercambiarFilas(inversa, j, pivot);

        float divisor = matriz[j][j];
        dividirFila(matriz, j, divisor);
        dividirFila(inversa, j, divisor);

        for (int i = 0; i < N; i++) {
            if (i != j) {
                float factor = matriz[i][j];
                restarFilas(matriz, i, j, factor);
                restarFilas(inversa, i, j, factor);
            }
        }
    }
}

int main() {
    float matriz[N][N] = {{2, 1, -1}, {-3, -1, 2}, {-2, 1, 2}};
    float inversa[N][N];

    printf("Matriz original:\n");
    imprimirMatriz(matriz);

    inversaMatriz(matriz, inversa);

    printf("\nInversa de la matriz:\n");
    imprimirMatriz(inversa);

    return 0;
}
