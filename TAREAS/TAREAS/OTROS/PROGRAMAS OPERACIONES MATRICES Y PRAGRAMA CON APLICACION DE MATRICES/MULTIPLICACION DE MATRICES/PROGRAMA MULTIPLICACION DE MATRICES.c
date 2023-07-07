#include <stdio.h>

int main() {
    int matriz1[2][3] = {{1, 2, 3}, {4, 5, 6}};
    int matriz2[3][2] = {{7, 8}, {9, 10}, {11, 12}};
    int multiplicacion[2][2] = {{0, 0}, {0, 0}};

    for (int i = 0; i < 2; i++) {
        for (int j = 0; j < 2; j++) {
            for (int k = 0; k < 3; k++) {
                multiplicacion[i][j] += matriz1[i][k] * matriz2[k][j];  // Realiza la multiplicación de los elementos correspondientes
            }
        }
    }

    printf("Matriz resultante de la multiplicacion:\n");
    for (int i = 0; i < 2; i++) {
        for (int j = 0; j < 2; j++) {
            printf("%d ", multiplicacion[i][j]);  // Imprime la matriz resultante
        }
        printf("\n");
    }

    return 0;
}
