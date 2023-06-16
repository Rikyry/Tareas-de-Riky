#include <stdio.h>
#include <ctype.h>
#include <string.h>

/* Verifica.
El programa, al recibir como datos una cadena de caracteres y una posición específica en la cadena,
determina si el caracter correspondiente es una letra minuscula. */

void main(void)
{
    char p, cad[51];
    int n;

    printf("\nIngrese la cadena de caracteres (maximo 50): ");
    fgets(cad, sizeof(cad), stdin);
    cad[strcspn(cad, "\n")] = '\0';  // Eliminar el salto de linea al final

    printf("\nIngrese la posicion en la cadena que desea verificar: ");
    scanf("%d", &n);

    if ((n >= 1) && (n <= strlen(cad)))
    {
        p = cad[n-1];

        if (tolower(p) == p && isalpha(p))
            printf("\n%c es una letra minuscula", p);
        else
            printf("\n%c no es una letra minuscula", p);
    }
    else
    {
        printf("\nEl valor ingresado de n es incorrecto");
    }
}
