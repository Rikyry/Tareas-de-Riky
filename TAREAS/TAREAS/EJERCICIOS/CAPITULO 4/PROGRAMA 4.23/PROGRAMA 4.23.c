#include <stdio.h>

void trueque(int *x, int *y)
{
    int tem;
    tem = *x;
    *x = *y;
    *y = tem;
}

int suma(int x)
{
    return (x + x);
}

int main()
{
    int a = 10;
    int b = 20;

    printf("Before swap: a = %d, b = %d\n", a, b);
    trueque(&a, &b);
    printf("After swap: a = %d, b = %d\n", a, b);

    int result = suma(a);
    printf("Sum of a: %d\n", result);

    return 0;
}
