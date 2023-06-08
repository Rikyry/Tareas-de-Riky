#include <stdio.h>

void main(void)
{
    int X = 3, Y = 7, Z[5] = {2, 4, 6, 8, 10};
    printf("\nX = %d \t Y = %d \t Z[0] = %d \t Z[1] = %d \t Z[2] = %d \t Z[3] = %d \t Z[4] = %d",
           X, Y, Z[0], Z[1], Z[2], Z[3], Z[4]);

    int *IX;
    IX = &X;
    Y = *IX;
    *IX = 1;
    printf("\nX = %d \t Y = %d \t Z[0] = %d \t Z[1] = %d \t Z[2] = %d \t Z[3] = %d \t Z[4] = %d",
           X, Y, Z[0], Z[1], Z[2], Z[3], Z[4]);

    IX = &Z[2];
    Y = *IX;
    *IX = 15;
    printf("\nX = %d \t Y = %d \t Z[0] = %d \t Z[1] = %d \t Z[2] = %d \t Z[3] = %d \t Z[4] = %d",
           X, Y, Z[0], Z[1], Z[2], Z[3], Z[4]);

    X = *IX + 5;
    *IX = *IX - 5;
    printf("\nX = %d \t Y = %d \t Z[0] = %d \t Z[1] = %d \t Z[2] = %d \t Z[3] = %d \t Z[4] = %d",
           X, Y, Z[0], Z[1], Z[2], Z[3], Z[4]);

    ++*IX;
    *IX += 1;
    printf("\nX = %d \t Y = %d \t Z[0] = %d \t Z[1] = %d \t Z[2] = %d \t Z[3] = %d \t Z[4] = %d",
           X, Y, Z[0], Z[1], Z[2], Z[3], Z[4]);

    X = *(IX + 1);
    Y = *IX;
    printf("\nX = %d \t Y = %d \t Z[0] = %d \t Z[1] = %d \t Z[2] = %d \t Z[3] = %d \t Z[4] = %d",
           X, Y, Z[0], Z[1], Z[2], Z[3], Z[4]);

    IX = IX + 1;
    Y = *IX;
    printf("\nX = %d \t Y = %d \t Z[0] = %d \t Z[1] = %d \t Z[2] = %d \t Z[3] = %d \t Z[4] = %d",
           X, Y, Z[0], Z[1], Z[2], Z[3], Z[4]);

    IX = IX + 4;
    Y = *IX;
    printf("\nX = %d \t Y = %d \t Z[0] = %d \t Z[1] = %d \t Z[2] = %d \t Z[3] = %d \t Z[4] = %d",
           X, Y, Z[0], Z[1], Z[2], Z[3], Z[4]);

    IX = &X;
    IX = IX + 1;
    X = *IX;
    printf("\nX = %d \t Y = %d \t Z[0] = %d \t Z[1] = %d \t Z[2] = %d \t Z[3] = %d \t Z[4] = %d",
           X, Y, Z[0], Z[1], Z[2], Z[3], Z[4]);
}
