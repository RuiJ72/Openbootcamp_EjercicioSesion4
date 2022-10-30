// Tabla de multiplicar con WHILE

int numero, I, resultado;
string linea;

Console.WriteLine("Indroduce un número: ");
linea = Console.ReadLine();
numero = int.Parse(linea);
I = 1;

while((I <= 12))
{
    resultado = numero * I;
    Console.WriteLine("{0} x {1} = {2}", numero, I, resultado);
    I = I + 1;
}


