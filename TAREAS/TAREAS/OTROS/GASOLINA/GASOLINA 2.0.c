#include <stdio.h>
#include <stdlib.h>

#define PRECIO_GALON 192.00
#define MAX_CLIENTES 10

typedef struct {
    char nombre[50];
    int galones;
} Cliente;

typedef struct {
    Cliente clientes[MAX_CLIENTES];
    int cantidad;
} RegistroClientes;

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
    printf("Galones hechodos: %d\n", cliente.galones);
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

void guardarDatos(RegistroClientes* registro) {
    FILE* archivo = fopen("clientes.dat", "wb");
    if (archivo == NULL) {
        printf("Error al abrir el archivo para escritura.\n");
        return;
    }

    fwrite(registro, sizeof(RegistroClientes), 1, archivo);
    fclose(archivo);
    printf("Datos guardados exitosamente.\n");
}

void cargarDatos(RegistroClientes* registro) {
    FILE* archivo = fopen("clientes.dat", "rb");
    if (archivo == NULL) {
        printf("No se encontro un archivo de datos existente.\n");
        return;
    }

    fread(registro, sizeof(RegistroClientes), 1, archivo);
    fclose(archivo);
    printf("Datos cargados exitosamente.\n");
}

void mostrarClientes(RegistroClientes registro) {
    printf("==============================================\n");
    printf("         Lista de Clientes Registrados\n");
    printf("----------------------------------------------\n");
    printf("Cantidad de clientes: %d\n", registro.cantidad);
    printf("----------------------------------------------\n");
    printf("No.  Nombre\n");
    printf("----------------------------------------------\n");
    for (int i = 0; i < registro.cantidad; i++) {
        printf("%-4d %s\n", i + 1, registro.clientes[i].nombre);
    }
    printf("==============================================\n");
}

int main() {
    RegistroClientes registro;
    registro.cantidad = 0;

    int opcion, distancia;
    float eficienciaMaxima, eficienciaMinima;
    int velocidadOptima;

    while (1) {
        printf("==============================================\n");
        printf("              Menu de Opciones\n");
        printf("----------------------------------------------\n");
        printf("1. Ingresar datos de un cliente\n");
        printf("2. Calcular eficiencia y mostrar tabla\n");
        printf("3. Mostrar lista de clientes\n");
        printf("4. Guardar datos\n");
        printf("5. Cargar datos\n");
        printf("0. Salir\n");
        printf("==============================================\n");
        printf("Ingrese una opcion: ");
        scanf("%d", &opcion);

        switch (opcion) {
            case 1:
                if (registro.cantidad == MAX_CLIENTES) {
                    printf("El registro de clientes esta lleno. No se pueden agregar mas clientes.\n");
                } else {
                    printf("Ingrese el nombre del cliente: ");
                    scanf("%s", registro.clientes[registro.cantidad].nombre);
                    printf("Ingrese la cantidad de galones que hecho: ");
                    scanf("%d", &registro.clientes[registro.cantidad].galones);
                    registro.cantidad++;
                    printf("Cliente registrado exitosamente.\n");
                }
                break;
            case 2:
                if (registro.cantidad == 0) {
                    printf("No hay clientes registrados. Registre al menos un cliente primero.\n");
                } else {
                    mostrarClientes(registro);
                    int numeroCliente;
                    printf("Ingrese el numero de cliente para el calculo de eficiencia: ");
                    scanf("%d", &numeroCliente);
                    if (numeroCliente < 1 || numeroCliente > registro.cantidad) {
                        printf("Numero de cliente inválido.\n");
                    } else {
                        printf("Ingrese la distancia recorrida (en km): ");
                        scanf("%d", &distancia);
                        calcularEficiencia(distancia, registro.clientes[numeroCliente - 1].galones, &eficienciaMaxima, &eficienciaMinima, &velocidadOptima);
                        mostrarTabla(registro.clientes[numeroCliente - 1], distancia, eficienciaMaxima, eficienciaMinima, velocidadOptima);
                    }
                }
                break;
            case 3:
                if (registro.cantidad == 0) {
                    printf("No hay clientes registrados.\n");
                } else {
                    mostrarClientes(registro);
                }
                break;
            case 4:
                guardarDatos(&registro);
                break;
            case 5:
                cargarDatos(&registro);
                break;
            case 0:
                printf("Gracias por utilizar el programa. ¡Hasta luego!\n");
                exit(0);
            default:
                printf("Opcion invalida. Por favor, ingrese una opcion valida.\n");
                break;
        }
    }

    return 0;
}
