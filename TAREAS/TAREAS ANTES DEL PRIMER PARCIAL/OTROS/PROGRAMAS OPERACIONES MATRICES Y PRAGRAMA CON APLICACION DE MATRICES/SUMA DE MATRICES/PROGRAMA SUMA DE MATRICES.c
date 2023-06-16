#include <stdio.h>

int main() {
    int matriz1[3][3] = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
    int matriz2[3][3] = {{9, 8, 7}, {6, 5, 4}, {3, 2, 1}};
    int suma[3][3];

    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
            suma[i][j] = matriz1[i][j] + matriz2[i][j];  // Suma los elementos correspondientes
        }
    }

    printf("Matriz resultante de la suma:\n");
    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
            printf("%d ", suma[i][j]);  // Imprime la matriz resultante
        }
        printf("\n");
    }

    return 0;
}
