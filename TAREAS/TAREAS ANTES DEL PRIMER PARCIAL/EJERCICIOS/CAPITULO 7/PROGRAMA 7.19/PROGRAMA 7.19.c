#include <stdio.h>
#include <string.h>
#include <ctype.h>

/* Cuenta palabras.
El programa calcula el n�mero de palabras que hay en la cadena de caracteres. */

int cuentap(char *); /* Prototipo de funci�n. */

void main(void)
{
    int i;
    char fra[50];

    printf("\nIngrese la linea de texto: ");
    fgets(fra, sizeof(fra), stdin);
    fra[strcspn(fra, "\n")] = '\0';  // Eliminar el salto de linea al final

    strcat(fra, " "); /* Se agrega un espacio en blanco al final de la cadena. */

    i = cuentap(fra);
    printf("La linea de texto tiene %d palabras\n", i);
}

int cuentap(char *cad)
{
    /* La funci�n cuenta el n�mero de palabras que hay en la cadena de caracteres. */
    char *cad0 = "";
    int i = 0;

    cad0 = strstr(cad, " "); /* Se localiza el primer espacio en blanco en la cadena. */

    while (strcmp(cad, " "))
    {
        strcpy(cad, cad0 + 1);
        i++;
        cad0 = strstr(cad, " ");
        /* Se busca un espacio en blanco a partir de la siguiente posici�n. */
    }

    return i;
}
