//Tabla de multiplicar con FOR

int numero, resultado;
Console.WriteLine("Introduce el numero de la tabla de multiplicar que deseas: ");

numero = Convert.ToInt32(Console.ReadLine());
Console.Clear();

for(int i = 1; i <= 10; i++)
{
    resultado = numero * i;
    Console.WriteLine($"{numero} x {i} = {resultado}");
}



