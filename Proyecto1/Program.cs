// See https://aka.ms/new-console-template for more information
//Ejercicio 1
using Microsoft.VisualBasic;

Console.WriteLine("Ingrese un Numero:");
string? s = Console.ReadLine();
int i =0;
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
//Ejercicio 2
int op = 0;
do
{
    Console.WriteLine("Ingrese un Numero Segun la operacion deseada:");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Valor Absoluto");
    Console.WriteLine("6. Cuadrado");
    Console.WriteLine("7. Raíz Cuadrada");
    Console.WriteLine("8. Seno");
    Console.WriteLine("9. Coseno");
    Console.WriteLine("10. Parte Entera");
    Console.WriteLine("11. Numero Maximo");
    Console.WriteLine("12. Numero Minimo");
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
            if (op < 5 || op==11|| op ==12)
            {
                Console.WriteLine("Ingrese una Numero a para operar:");
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
                    string ms1="";
                    switch (op)
                    {
                        case 1:
                            r = a + b;
                            ms1 = "La suma de  " +a+ " con " +b;
                            break;
                        case 2:
                            r = a - b;
                            ms1 = "La resta de  " +a+ " con " +b;
                            break;
                        case 3:
                            r = a * b;
                            ms1 = "El producto de  " +a+ " con " +b;
                            break;
                        case 4:
                            r = a / b;
                            ms1 = "El cociente de  " +a+ " con " +b;
                            break;
                        case 11:
                            if (a > b)
                            {
                                Console.WriteLine("EL numero " + a + " es mayor que el numero " + b);
                            }
                            else
                            {
                                Console.WriteLine("EL numero " + b + " es mayor que el numero " + a);
                            }
                            break;
                        case 12:
                            if (b < a)
                            {
                                Console.WriteLine("EL numero " + a + " es menor que el numero " + b);
                            }
                            else
                            {
                                Console.WriteLine("EL numero " + b + " es menor que el numero " + a);
                            }
                            break;
                    }
                    Console.WriteLine(ms1+" es igual a  " + r);
                }
                else
                {
                    Console.WriteLine("valor ingresado de a o b es invalido.");
                    op = 0;
                }

            }
            else
            {
                if (op < 11 && op > 4)
                {
                    Console.WriteLine("Ingrese un Numero pera operar:");
                    float c = 0;
                    string? s3 = Console.ReadLine();
                    bool result3 = float.TryParse(s3, out c); //c=numerico
                    if (result3)
                    {
                        float r = 0;
                        string ms="";
                        switch (op)
                        {
                            case 5:
                                r = Math.Abs(c);
                                ms = "El valor absoluto de " + c;
                                break;
                            case 6:
                                r = c * c;
                                ms = "El cuadrado de " + c;
                                break;
                            case 7:
                                r = (float)Math.Sqrt(c);
                                ms = "La raiz Cuadrada de " + c;
                                break;
                            case 8:
                                r = (float)Math.Sin(c);
                                ms = "El Seno de " + c;
                                break;
                            case 9:
                                r = (float)Math.Cos(c);
                                ms = "El Coseno de " + c;
                                break;
                            case 10:
                                string[] parteEntera = s3.Split(".");
                                float.TryParse(parteEntera[0], out r);//Parte entera de la cadena s3 ingresada
                                break;
                        }
                        Console.WriteLine(ms+" es igual a "+ r);
                    }
                    else
                    {
                        Console.WriteLine("valor ingresado del numero es invalido.");
                        op = 0;
                    }
                }
                else
                {
                    Console.WriteLine("El valor de operacion no es compatible con ninguna operacion.");
                }
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
