// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un Texto:");
string? i = Console.ReadLine();

if (i != null)
{
    int l = i.Length;
    Console.WriteLine("Longitud del Texto: " + l);
    Console.WriteLine("Ingrese otro Texto:");
    string? i2 = Console.ReadLine();
    if (i2 != null)
    {
        string concatenado = string.Concat(i, i2, ".");
        Console.WriteLine("Textos Concatenados: " + concatenado);
        string[] subacadenas = concatenado.Split(" ");
        Console.WriteLine("Subcadena de la ingresada con marca final ' ': " + subacadenas[0]);
        foreach (char a in concatenado)
        {
            Console.WriteLine(a);
        }
        string saludo = "Hola";
        Console.WriteLine("Verificamos si " + saludo + " se encuentra en " + concatenado);
        int pos = concatenado.IndexOf(saludo);
        if (pos >= 0)
        {
            Console.WriteLine("La palabra " + saludo + " se encontro en " + concatenado);
        }
        else
        {
            Console.WriteLine("La palabra " + saludo + " No se encontro en " + concatenado);
        }
        Console.WriteLine("Convertimos la palabra " + saludo + " en mayuscula " + saludo.ToUpper());
        Console.WriteLine("Convertimos la palabra " + saludo + " en minuscula " + saludo.ToLower());
        Console.WriteLine("Ingrese otro Texto con separaciones con , (Ej: uno,dos,tres):");
        string? i3 = Console.ReadLine();
        if (i3 != null)
        {
            string[] partes = i3.Split(",");
            Console.WriteLine("Elementos separados:");
            foreach (string parte in partes)
            {
                Console.WriteLine(parte);
            }
        }
        else
        {
            Console.WriteLine("Texto ingresado Invalido.");
        }
    }
    else
    {
        Console.WriteLine("Texto ingresado Invalido.");
    }
}
else
{
    Console.WriteLine("Texto ingresado Invalido.");
}