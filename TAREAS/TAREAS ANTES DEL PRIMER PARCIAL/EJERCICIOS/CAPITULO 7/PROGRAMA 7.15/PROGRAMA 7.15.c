#include <stdio.h>
#include <ctype.h>

/* Decodifica.
El programa decodifica una cadena de caracteres compuesta por números y letras. */

void interpreta(char *);

void main(void)
{
    char cad[50];

    printf("\nIngrese la cadena de caracteres: ");
    fgets(cad, sizeof(cad), stdin);
    cad[strcspn(cad, "\n")] = '\0';  // Eliminar el salto de linea al final

    interpreta(cad);
}

void interpreta(char *cadena)
{
    int i = 0, j, k;

    while (cadena[i] != '\0')
    {
        if (isalpha(cadena[i]))  // Se utiliza isalpha para observar si el caracter es una letra
        {
            k = cadena[i - 1] - '0';
            /* En la variable entera k se almacena el valor numérico del número que nos interesa,
            convirtiendo el caracter a su valor numérico restando el valor ASCII de '0'. */

            for (j = 0; j < k; j++)
                putchar(cadena[i]);
        }

        i++;
    }
}
