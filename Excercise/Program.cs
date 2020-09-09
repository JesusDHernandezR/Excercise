using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var OP = "s";

            while (OP == "s")
            {
                var OPC = "s";
                string nombre, consigna, numeroCuenta;
                long saldoRetirar, saldoApertura = 0;
                int opcion, nota1, nota2, nota3, option;
                Console.WriteLine(" ____________________MENU________________");
                Console.WriteLine("|1. PROMEDIO ESTUDIANTE Y MEJOR NOTA     |");
                Console.WriteLine("|2. NUMERO DE PULSACIONES DE UNA PERSONA |");
                Console.WriteLine("|3. INFORMACION FINANCIERA DE UNA PERSONA|");
                Console.WriteLine("|4. SALIR________________________________| ");
                Console.WriteLine("DIGITE SU OPCION: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("------------PROMEDIO ESTUDIANTE------------");
                        Console.WriteLine("Ingrese su nota 1: ");
                        nota1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese su nota 2: ");
                        nota2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese su nota 3: ");
                        nota3 = int.Parse(Console.ReadLine());
                        int prom = (nota1 + nota2 + nota3) / 3;
                        Console.WriteLine("Su definitiva es: " + prom);
                        if (prom >= 0 && prom < 3)
                        {
                            Console.WriteLine("ASIGNATURA PERDIDA");
                        }
                        else
                        {
                            Console.WriteLine("ASIGNATURA GANADA");
                        }
                        break;
                    case 2:
                        Console.Clear();
                        string sexo;
                        int edad, pulsaciones;
                        Console.WriteLine("------------PULSACIONES------------");
                        Console.WriteLine("Ingrese su edad: ");
                        edad = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese su sexo [F/M]: ");
                        sexo = Console.ReadLine();
                        if (sexo == "f" || sexo == "F")
                        {
                            pulsaciones = (220 - edad) / 10;
                            Console.WriteLine("Sus pulsaciones: " + pulsaciones);
                        }
                        else if (sexo == "m" || sexo == "M")
                        {
                            pulsaciones = (210 - edad) / 10;
                            Console.WriteLine("Sus pulsaciones: " + pulsaciones);
                        }
                        break;
                    case 3:
                        while (OPC == "s")
                        {
                            Console.Clear();
                            Console.WriteLine(" ______MENU_____");
                            Console.WriteLine("|1. CONSIGNAR   |");
                            Console.WriteLine("|2. RETIRAR     |");
                            Console.WriteLine("|3. SALIR_______|");
                            Console.WriteLine("DIGITE SU OPCION: ");
                            option = int.Parse(Console.ReadLine());
                            switch (option)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("------------CUENTA FINANCIERA------------");
                                    Console.WriteLine("Ingrese su nombre: ");
                                    nombre = Console.ReadLine();
                                    Console.WriteLine("Ingrese su No. Cuenta: ");
                                    numeroCuenta = Console.ReadLine();
                                    Console.WriteLine("Desea hacer una consignacion? s(si)/n(no): ");
                                    consigna = Console.ReadLine();
                                    if (consigna != "s")
                                    {
                                        saldoApertura = 0;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ingrese cantidad: ");
                                        saldoApertura = long.Parse(Console.ReadLine());
                                    }
                                    Console.Clear();
                                    Console.WriteLine("------INFORMACION DE LA CUENTA-----: ");
                                    Console.WriteLine("NOMBRE: " + nombre);
                                    Console.WriteLine("No. CUENTA: " + numeroCuenta);
                                    Console.WriteLine("SALDO: " + saldoApertura);
                                    Console.WriteLine("Presione ENTER para continuar");
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("------------CUENTA FINANCIERA------------");
                                    Console.WriteLine("Ingrese su nombre: ");
                                    nombre = Console.ReadLine();
                                    Console.WriteLine("Ingrese su No. Cuenta: ");
                                    numeroCuenta = Console.ReadLine();
                                    Console.WriteLine("Desea retirar? s(si)/n(no): ");
                                    string retira = Console.ReadLine();
                                    if (retira != "s")
                                    {
                                        saldoRetirar = 0;
                                    }
                                    else
                                    {
                                        if (saldoApertura == 0)
                                        {
                                            Console.WriteLine("Usted no tiene dinero en su cuenta");
                                            Console.WriteLine("Presione ENTER para continuar");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ingrese cantidad: ");
                                            saldoRetirar = long.Parse(Console.ReadLine());
                                            saldoApertura = saldoApertura - saldoRetirar;
                                        }
                                    }
                                    Console.Clear();
                                    Console.WriteLine("------INFORMACION DE LA CUENTA-----: ");
                                    Console.WriteLine("NOMBRE: " + nombre);
                                    Console.WriteLine("No. CUENTA: " + numeroCuenta);
                                    Console.WriteLine("SALDO: " + saldoApertura);
                                    Console.WriteLine("Presione ENTER para continuar");
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    Environment.Exit(0);
                                    break;
                            }
                        }
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
                do
                {
                    Console.WriteLine("desea seguir? s(si)/n(no): ");
                    OP = Console.ReadLine();
                } while (OP == "s" && OP != "s");
                if (OP == "s")
                {
                    Console.WriteLine("Presione ENTER para continuar");
                }
                else
                {
                    Console.WriteLine("Presione ENTER para Salir");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
