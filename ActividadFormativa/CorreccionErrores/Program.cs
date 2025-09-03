internal class Program
{
    private static void Main(string[] args)
    {
        ////////////////////////Ejemplo 1//////////////////
int i = 0;
while (i < 5)
{
    Console.WriteLine(i);
    i++;
}
//El error era que el valor nunca se sumaba,
//asi que era infinito el ciclo

//Solución: añadir el operador ++ para que el valor de i incremente con cada vez que el while
//repita el ciclo.

/////////////////////////Ejemplo 2//////////////////
int edad = 20;
if (edad > 18 && edad < 65)
{
    Console.WriteLine("Edad valida para trabajar.");

}
//El error era que el operador logico era || (or)
//y debia ser && (and), al ser || no funcionaba como rango de valores ya que solo necesitaba una de las
//condiciones se cumpliera perdiendo la lógica del ejercicio.
//Correccion: Añadir && para aplicar el rango correctamente.

/////////////////////////Ejemplo 3//////////////////
for (int j = 0; j < 10; j++)
{
    Console.WriteLine(j);
}
//El error era que no tenia punto y coma en las instrucciones del for
//Corrección: Añadir el ; luego de j < 10 para solucionar el error de sintaxis.


/////////////////////////Ejemplo 4//////////////////
int numero = 10;
bool esMayor;
esMayor = (numero > 5) ? true : false;
Console.WriteLine("¿Es mayor que 5? " + esMayor);
//Error: El valor booleano no se declaraba en ningun momento.
//Solución: Utilizar un operador ternario para definir el valor booleano
//de la variable esMayor.

/////////////////////////Ejemplo 5//////////////////
int resultado = 5;
resultado = resultado + 10;
Console.WriteLine(resultado);
//El error era que faltaba definir la variable resultado para que se pudiera
//efectuar la suma


//////////////////////////Ejemplo 6//////////////////
int edad2 = 17;
if (edad2 >= 18)
{
    Console.WriteLine("Es mayor de edad.");
    Console.WriteLine("Puede votar.");
}
else
{
    Console.WriteLine("Es menor de edad.");
}
//Error: La ausencia de {}(llaves) en if y else
//Solución: Añadir las llaves :o

    }
}