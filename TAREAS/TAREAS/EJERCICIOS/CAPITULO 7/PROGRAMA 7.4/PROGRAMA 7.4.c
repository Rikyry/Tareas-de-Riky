#include <stdio.h>
/* Declaracion de cadenas de caracteres y asignacion de valores. */
int main(void)
{
    char *cad0;
    cad0 = "Argentina"; /* La declaracion y la asignacion son correctas. */
    puts(cad0);

    cad0 = "Brasil";
    /* Correcto. Se modifica el contenido de la posicion en memoria a la que apunta
    la variable cad0 - apuntador de tipo cadena de caracteres. */
    puts(cad0);

    char cad1[100] = ""; /* Inicializamos la cadena con un valor vacio */
    gets(cad1);
    /* Correcto. Primero se le asigna un valor a la posicion de memoria a la que
    apunta cad1. Luego podemos modificar el contenido de esta posicion de memoria
    utilizando la funcion gets. */

    char cad2[20] = "Mexico"; /* Correcto. */
    puts(cad2);

    gets(cad2);
    /* El valor de una cadena (declarada como cadena[longitud]) se puede modificar
    por medio de lecturas o utilizando funciones de la biblioteca string.h. */

    puts(cad2);

    // cad2[10] = "Guatemala"; /* Esta linea está comentada ya que es incorrecta. */
    /* Incorrecto. Observa cuidadosamente el caso anterior y analiza la diferencia
    que existe con éste. Aquí se produce un error en la compilación del programa,
    al tratar de asignar la cadena de caracteres "Guatemala" al caracter 11 de la cadena. */

    return 0;
}
