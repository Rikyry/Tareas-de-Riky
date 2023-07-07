#include <stdio.h>
#include <ctype.h>
#include <string.h>

/* Cuenta letras minusculas y mayusculas.
El programa, al recibir como dato una frase, determina el numero de letras
minusculas y mayusculas que existen en la frase. */

void main(void)
{
    char cad[51];
    int i = 0, mi = 0, ma = 0;

    printf("\nIngrese la cadena de caracteres (maximo 50 caracteres): ");
    fgets(cad, sizeof(cad), stdin);
    cad[strcspn(cad, "\n")] = '\0';  // Eliminar el salto de linea al final

    while (cad[i] != '\0')
    {
        if (islower(cad[i]))
            mi++;
        else if (isupper(cad[i]))
            ma++;

        i++;
    }

    printf("\n\nNumero de letras minusculas: %d", mi);
    printf("\nNumero de letras mayusculas: %d", ma);
}
