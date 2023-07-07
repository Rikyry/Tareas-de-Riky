#include <stdio.h>
#include <string.h>

int longitud(char *); /* Prototipo de funci�n. */

void main(void)
{
    int i, n, l = -1, p, t;
    char cad[50], FRA[20][50];

    printf("Ingrese el n�mero de filas del arreglo: ");
    scanf("%d", &n);

    for (i = 0; i < n; i++)
    {
        printf("Ingrese la l�nea %d de texto. M�ximo 50 caracteres: ", i + 1);
        fflush(stdin);
        fgets(FRA[i], sizeof(FRA[i]), stdin);
        FRA[i][strcspn(FRA[i], "\n")] = '\0';  // Eliminar el salto de linea al final
    }

    printf("\n");

    for (i = 0; i < n; i++)
    {
        strcpy(cad, FRA[i]);
        t = longitud(cad);

        if (t > l)
        {
            l = t;
            p = i;
        }
    }

    printf("\nLa cadena con mayor longitud es: %s\n", FRA[p]);
    printf("Longitud: %d\n", l);
}

int longitud(char *cadena)
{
    /* Esta funci�n calcula la longitud de la cadena. Es id�ntica a la funci�n cuenta del programa 7.13. */
    int cue = 0;

    while (cadena[cue] != '\0')
        cue++;

    return cue;
}
