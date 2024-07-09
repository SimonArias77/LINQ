// ARRY DE FRUTAS

using System.Runtime.CompilerServices;

var fruticas = new string[]{
    "banano",
    "pera",
    "sandia"
};

// Console.WriteLine(frutas.GetType().Name);

// Lista de numeros del 1 al 10 en desorden:
var numerosLista = new List<byte> { 3, 7, 8, 9, 6, 5, 4, 10, 2, 1 };

//  Array con numeros del 1 al 10 en desorden
var numerosArray = new byte[] { 5, 1, 8, 7, 6, 10, 4, 3, 2, 9 };

// Recorre la lista (ciclos: for, for each, while, do - while)
// foreach (var numero in numerosLista)
// {
//     Console.WriteLine(numero);
// }

// Lista vacía donde solo se guardarán solo los números pares
var numerosPares = new List<byte>();


// Recorre el Array
// foreach (var numero in numerosArray)
// {
//     if (numero % 2 == 0)
//     {
//         //si el numero es par, lo agrega a la lista
//         numerosPares.Add(numero);
//     }
// }

// muestra los numeros pares  con LINQ
var numerosPares1 = numerosArray.Where(numero => numero % 2 == 0).ToList();  ///esto reemplaza el anteror for each para recorrer

// Duplicar los numeros
var numerosDuplicados = numerosArray.Select(numero=>  numero  * 2).ToArray();

// mostrar en orden ascendente
var numerosOrdenados = numerosArray.OrderBy(numero => numero).ToArray();

// mostrar en orden descendente
var numerosOrdenadosDescendente = numerosArray.OrderByDescending(numero => numero).ToArray();


//MOSTRAR NUMEROS PARES
Console.WriteLine("números pares:");

foreach (var numero in  numerosPares1)
{
    Console.WriteLine(numero);
}

// MOSTRAR NÚMEROS DUPLICADOS
Console.WriteLine("números duplicados:");

foreach (var numero in numerosDuplicados)
{
    Console.WriteLine(numero);   
}
// ORDENAMOS LOS NÚMEROS DEL ARRAY DE MANERA ASCENDENTE
Console.WriteLine("números ordenados ascendentemente:");

foreach (var numero in numerosOrdenados)
{
    Console.WriteLine(numero);
}

// ORDENAMOS LOS NÚMEROS DEL ARRAY DE MANERA DESCENDENTE
Console.WriteLine("números ordenados descendentemente:");

foreach (var numero in numerosOrdenadosDescendente)
{
    Console.WriteLine(numero);
}

// EXTRAEMOS UN NUMERO DE UNA POSICIÓN DETERMINADA DEL ARRAY.
Console.WriteLine("extraer el número en la posición 2 del Array, numerosArray");

int posicion = 2; //definimos la posición deseada del número a extraer

if (posicion >= 0 && posicion < numerosArray.Length) // verificamos si la posición está dentro de los limites del array.
{
    int numeroDeseado = numerosArray[2];
    Console.WriteLine($"El número en la posición {posicion} es: {numeroDeseado}");
}



