// See https://aka.ms/new-console-template for more information
//Ejercicio 1
/*
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
        Console.WriteLine("Numero Invertido:");
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
*/
//Ejercicio 2
int op = 0;
do
{
    Console.WriteLine("Ingrese un Numero Segun la operacion deseada:");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("0. Salir");

    string? sop = Console.ReadLine();
    bool resultop = int.TryParse(sop, out op); //op=numerico

    if (resultop)
    {
        if (op == 0)
        {
            Console.WriteLine("Saliendo...");
        }
        else
        {
            if (op < 5)
            {
                Console.WriteLine("Ingrese un Numero a pera operar:");
                int a = 0;
                string? s1 = Console.ReadLine();
                bool result1 = int.TryParse(s1, out a); //a=numerico

                int b = 0;
                Console.WriteLine("Ingrese un Numero b para operar:");
                string? s2 = Console.ReadLine();
                bool resul2 = int.TryParse(s2, out b); //b=numerico

                int r = 0;
                if (resul2 && result1)
                {
                    switch (op)
                    {
                        case 1:
                            r = a + b;
                            break;
                        case 2:
                            r = a - b;
                            break;
                        case 3:
                            r = a * b;
                            break;
                        case 4:
                            r = a / b;
                            break;
                    }
                    Console.WriteLine("valor del calculo realizado: " + r);
                }
                else
                {
                    Console.WriteLine("valor ingresado de a o b es invalido.");
                    op = 0;
                }

            }
            else
            {
                Console.WriteLine("El valor de operacion no es compatible con ninguna operacion.");
            }
        }
    }
    else
    {
        Console.WriteLine("valor ingresado para realizar una operacion es invalido.");
        op = 0;
    }
    Console.WriteLine("Desea realizar otra Operacion?.");
    Console.WriteLine("1. si");
    Console.WriteLine("0. no");
    string? p = Console.ReadLine();
    bool resulp = int.TryParse(p, out op); //op=numerico
    
    if (!resulp || op != 1)
    {
        if (op == 0)
        {
            Console.WriteLine("Saliendo...");
        }else
        {
            Console.WriteLine("valor ingresado para realizar una operacion es invalido.");
            op = 0;
        }
    }
} while (op != 0);