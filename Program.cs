Console.Clear();
string entradaT, entradaP, entradaR;
bool sensorT, sensorP, sensorR, luzAdvertenciaW;

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("*** Simulador de Luz de Advertência ***");
Console.WriteLine();
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("[A]tivado, [D]esativado");
Console.WriteLine();
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write("Sensor de temperatura: ");
entradaT = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();
Console.ResetColor();

if (entradaT != "A" && entradaT != "D")
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Valor inválido.");
    Console.ResetColor();
    return;
}
sensorT = entradaT == "A";

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.Write("Sensor de pressão: ");
entradaP = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();
Console.ResetColor();

if (entradaP != "A" && entradaP != "D")
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Valor inválido.");
    Console.ResetColor();
    return;
}
sensorP = entradaP == "A";

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write("Sensor de Rotação: ");
entradaR = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();
Console.ResetColor();

if (entradaR != "A" && entradaR != "D")
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Valor inválido.");
    Console.ResetColor();
    return;
}
sensorR = entradaR == "A";

luzAdvertenciaW = sensorT && (sensorP || !sensorR);

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"\nA luz de advertência estará {(luzAdvertenciaW ? "ATIVADA" : "DESATIVADA")}.");
Console.ResetColor();