#include <stdio.h>

#define PRECIO_GALON 192.00

typedef struct {
    char nombre[50];
    int galones;
} Cliente;

void calcularEficiencia(int distancia, int galones, float* eficienciaMaxima, float* eficienciaMinima, int* velocidadOptima) {
    *eficienciaMaxima = (float)distancia / galones;
    *eficienciaMinima = (float)distancia / (galones + 1);
    *velocidadOptima = distancia / (*eficienciaMinima + 1);
}

void mostrarTabla(Cliente cliente, int distancia, float eficienciaMaxima, float eficienciaMinima, int velocidadOptima) {
    printf("==============================================\n");
    printf("                Informacion\n");
    printf("----------------------------------------------\n");
    printf("Cliente: %s\n", cliente.nombre);
    printf("Galones hechados: %d\n", cliente.galones);
    printf("Distancia recorrida: %d km\n", distancia);
    printf("----------------------------------------------\n");
    printf("Resultados\n");
    printf("----------------------------------------------\n");
    printf("Eficiencia maxima: %.2f km/L\n", eficienciaMaxima);
    printf("Eficiencia minima: %.2f km/L\n", eficienciaMinima);
    printf("Velocidad optima: %d km/h\n", velocidadOptima);
    printf("----------------------------------------------\n");
    printf("Consumo total: %.2f L\n", (float)distancia / eficienciaMinima);
    printf("Costo total: %.2f RD\n", (float)distancia / eficienciaMinima * PRECIO_GALON);
    printf("==============================================\n");
}

int main() {
    Cliente cliente;
    int distancia;
    float eficienciaMaxima, eficienciaMinima;
    int velocidadOptima;

    printf("Ingrese el nombre del cliente: ");
    scanf("%s", cliente.nombre);
    printf("Ingrese la cantidad de galones hechos: ");
    scanf("%d", &cliente.galones);
    printf("Ingrese la distancia recorrida (en km): ");
    scanf("%d", &distancia);

    calcularEficiencia(distancia, cliente.galones, &eficienciaMaxima, &eficienciaMinima, &velocidadOptima);
    mostrarTabla(cliente, distancia, eficienciaMaxima, eficienciaMinima, velocidadOptima);

    return 0;
}
