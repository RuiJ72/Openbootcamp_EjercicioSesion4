// Generar un rectángulo

int CAN, F, C, T, FI, FF, CI, CF;
string linea;

Console.WriteLine("Gigita un número máximo: ");
linea = Console.ReadLine();

CAN = byte.Parse(linea);
FI = 2;
FF = 22;
CI = 2;
CF = 77;

for (T = 1; T <= CAN; T++)
{

    for(F = CI; F <= CF; F++)
    {
        Console.SetCursorPosition(F, FF); Console.Write("*");
        Console.SetCursorPosition(F, FI); Console.Write("*");
    }
    for (C = FI; C <= FF; C++)
    {
        Console.SetCursorPosition(CI, C); Console.Write("*");
        Console.SetCursorPosition(CF, C); Console.Write("*");
    }

    FI = FI + 1; FF = FF - 1;
    CI = CI + 1; CF = CF - 1;

}
Console.WriteLine();

Console.SetCursorPosition(25, 24);
Console.Write("Pulse una tecla");

