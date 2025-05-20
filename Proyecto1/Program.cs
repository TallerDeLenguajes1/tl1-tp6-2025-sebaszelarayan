// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un Numero:");
string? s = Console.ReadLine();
int i = 0;
bool result = int.TryParse(s, out i); //i=numerico

if (result)
{
    Console.WriteLine("valor ingresado es " + i + " (entero).");
    if (i<=0)
    {
        Console.WriteLine("El valor "+s+" debe ser positivo > 0. ");
    }else
    {
    while (i > 0)
    {
        Console.Write(i % 10);
        i /= 10;
    }
    }
}else
{
    Console.WriteLine("El valor "+s+" no se puede transformar a entero. ");
}
