#include<stdio.h>

int main() {
    int monedas_1, monedas_5, monedas_10, monedas_25;
    
    printf("Ingrese la cantidad de monedas de 1 centavo: ");
    scanf("%d", &monedas_1);
    
    printf("Ingrese la cantidad de monedas de 5 centavos: ");
    scanf("%d", &monedas_5);
    
    printf("Ingrese la cantidad de monedas de 10 centavos: ");
    scanf("%d", &monedas_10);
    
    printf("Ingrese la cantidad de monedas de 25 centavos: ");
    scanf("%d", &monedas_25);
    
    int total_monedas = monedas_1 + (monedas_5 * 5) + (monedas_10 * 10) + (monedas_25 * 25);
    
    printf("\nLa cantidad total de monedas es: %d\n", total_monedas);
    
    return 0;
}
