using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        int opc = 1;
        do
        {
            string cadena;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese una cadena de 10 caracteres:");
                Console.Write(">> ");
                cadena = Console.ReadLine();
            } while (cadena.Length != 10);

            Console.WriteLine("\nMenú:");
            Console.WriteLine(" 1. Contar todos los espacios en blanco.");
            Console.WriteLine(" 2. Contar únicamente 2 espacios en blanco.");
            Console.WriteLine(" 3. Contar espacios en blanco y números.");
            Console.WriteLine(" 4. Contar espacios en blanco, números y letras mayúsculas.");
            Console.WriteLine(" 5. Contar espacios en blanco, números y letras minúsculas.");
            Console.WriteLine(" 6. Contar espacios en blanco, números y letras mayúsculas y minúsculas.");
            Console.WriteLine(" 0. Salir");

            Console.Write("\n   Seleccione una opción: ");
            if (!int.TryParse(Console.ReadLine(), out opc))
            {
                Console.WriteLine(" Opción no válida. Intente de nuevo.");
                Cerrar();
                continue;
            }

            switch (opc)
            {
                case 1:
                    ContarEspacios(cadena);
                    Cerrar();
                    break;
                case 2:
                    if (!ValidarCasoDos(cadena))
                    {
                        Console.WriteLine("\n   Error: Solo se permiten 2 espacios en blanco. Vuelva a ingresar la cadena.");
                        Cerrar();
                        continue;
                    }
                    ContarDosEspacios(cadena);
                    Cerrar();
                    break;
                case 3:
                    if (!ValidarCasoTres(cadena))
                    {
                        Console.WriteLine("\n   Error: Solo se permiten espacios en blanco y números. Vuelva a ingresar la cadena.");
                        Cerrar();
                        continue;
                    }
                    ContarEspacios(cadena);
                    Cerrar();
                    break;
                case 4:
                    if (!ValidarCasoCuatro(cadena))
                    {
                        Console.WriteLine("\n   Error: Solo se permiten espacios en blanco, números y letras mayúsculas. Vuelva a ingresar la cadena.");
                        Cerrar();
                        continue;
                    }
                    ContarEspacios(cadena);
                    Cerrar();
                    break;
                case 5:
                    if (!ValidarCasoCinco(cadena))
                    {
                        Console.WriteLine("\n   Error: Solo se permiten espacios en blanco, números y letras minúsculas. Vuelva a ingresar la cadena.");
                        Cerrar();
                        continue;
                    }
                    ContarEspacios(cadena);
                    Cerrar();
                    break;
                case 6:
                    if (!ValidarCasoSeis(cadena))
                    {
                        Console.WriteLine("\n   Error: Solo se permiten espacios en blanco, números y letras (mayúsculas y minúsculas). Vuelva a ingresar la cadena.");
                        Cerrar();
                        continue;
                    }
                    ContarEspacios(cadena);
                    Cerrar();
                    break;
                case 0:
                    Console.WriteLine(" Saliendo del programa. ¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine(" Opción no válida. Intente de nuevo.");
                    Cerrar();
                    break;
            }

        } while (opc != 0);
    }

    static void Cerrar()
    {
        Console.WriteLine("\n   Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ContarEspacios(string cadena)
    {
        int esp = 0;
        foreach (char c in cadena)
        {
            if (c == ' ')
                esp++;
        }
        Console.WriteLine($"\n  Número total de espacios en blanco: {esp}");
    }

    static void ContarDosEspacios(string cadena)
    {
        int esp = 0;
        foreach (char c in cadena)
        {
            if (c == ' ')
            {
                esp++;
                if (esp > 2)
                {
                    Console.WriteLine("\n   Más de dos espacios en blanco. Vuelva a ingresar la cadena.");
                    return;
                }
            }
        }
        Console.WriteLine($"\n  Número de espacios en blanco (máximo 2): {esp}");
    }

    static bool ValidarCasoDos(string cadena)
    {
        int esp = 0;
        foreach (char c in cadena)
        {
            if (c == ' ')
            {
                esp++;
                if (esp > 2)
                    return false;
            }
        }
        return esp == 2;
    }

    static bool ValidarCasoTres(string cadena)
    {
        foreach (char c in cadena)
        {
            if (!char.IsWhiteSpace(c) && !char.IsDigit(c))
                return false;
        }
        return true;
    }

    static bool ValidarCasoCuatro(string cadena)
    {
        foreach (char c in cadena)
        {
            if (!char.IsWhiteSpace(c) && !char.IsDigit(c) && !char.IsUpper(c))
                return false;
        }
        return true;
    }

    static bool ValidarCasoCinco(string cadena)
    {
        foreach (char c in cadena)
        {
            if (!char.IsWhiteSpace(c) && !char.IsDigit(c) && !char.IsLower(c))
                return false;
        }
        return true;
    }

    static bool ValidarCasoSeis(string cadena)
    {
        foreach (char c in cadena)
        {
            if (!char.IsWhiteSpace(c) && !char.IsDigit(c) && !char.IsLetter(c))
                return false;
        }
        return true;
    }
}
