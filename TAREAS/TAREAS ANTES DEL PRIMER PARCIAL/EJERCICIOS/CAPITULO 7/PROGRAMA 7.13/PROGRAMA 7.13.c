#include <stdio.h>

/* Calcula longitud.
El programa calcula la longitud de la cadena sin utilizar la función strlen. */

int cuenta(char *); /* Prototipo de función. */

void main(void)
{
    int i;
    char cad[51];

    printf("\nIngrese la cadena de caracteres: ");
    fgets(cad, sizeof(cad), stdin);
    cad[strcspn(cad, "\n")] = '\0';  // Eliminar el salto de linea al final

    i = cuenta(cad);

    printf("\nLongitud de la cadena: %d", i);
}

int cuenta(char *cadena)
/* La función calcula la longitud de la cadena. */
{
    int c = 0;

    while (cadena[c] != '\0')
        c++;

    return c;
}
