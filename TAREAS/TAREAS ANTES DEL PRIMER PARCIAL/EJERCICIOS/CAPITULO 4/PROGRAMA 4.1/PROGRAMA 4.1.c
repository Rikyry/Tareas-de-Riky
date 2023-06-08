#include <stdio.h>

int cubo(int); // Function prototype.

int main(void) {
    int CUB;

    for (int I = 1; I <= 10; I++) {
        CUB = cubo(I); // Call the cubo function.
        printf("El cubo de %d es: %d\n", I, CUB);
    }

    return 0;
}

int cubo(int num) {
    return (num * num * num); // Calculate the cube of the given number.
}
