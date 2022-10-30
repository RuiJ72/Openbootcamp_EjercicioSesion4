int x = 0;
int positivos = 0;
int negativos = 0;


do
{
    Console.WriteLine("Ingresa numeros e por final el 0 para teneres el resultado: ");
    x = Convert.ToInt32(Console.ReadLine());

    if(x > 0) { positivos = positivos + 1; }
    if(x < 0) { negativos = negativos + 1; }
    
} while (x != 0);
Console.WriteLine("Numeros positivos " + positivos);
Console.WriteLine("Numeros negativos " + negativos);




