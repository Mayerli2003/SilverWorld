using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica3SilverWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            Empleado empleado = new Empleado();
            alcoholicas alcohol = new alcoholicas();
            licuados licua = new licuados();
            CalientesInfuciones infuciones = new CalientesInfuciones();
            string id;
            PersonaDatos datos = new PersonaDatos();
            double pagar;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("__________Bienbenido al sistema de Silver World__________\n");

                Console.WriteLine("           __________Eliga su rol__________");
                Console.WriteLine("\n1 - Cliente");
                Console.WriteLine("\n2 - Empleado");
                Console.WriteLine("\n3 - Salir");
                Console.WriteLine("----------------------------------------------------------");



                Console.WriteLine("\nIngrese el numero de su consulta");
                id = Console.ReadLine();
                switch (id)
                {
                    case "1":

                        do
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            
                            Console.WriteLine("------------------------Rol de Cliente-------------------------");

                            Console.WriteLine("\n1 - Comprar");
                            Console.WriteLine("\n2 - Lista de bebidas");
                            Console.WriteLine("\n3 - Lista de clientes frecuentes");
                            Console.WriteLine("\n4 - Salir");
                            Console.WriteLine("----------------------------------------------------------");
                            Console.WriteLine("\nIngrese el numero de su consulta");
                            id = Console.ReadLine();
                            switch (id)
                            {
                                case "1":
                                    datos.DatosUsuario(datos.Nombre, datos.Apellido, datos.Edad);
                                    Console.WriteLine(datos.Mostrar());


                                    if (datos.Edad >= 18)
                                    {


                                        Console.WriteLine("El Cliente es mayor de Edad a continuacion estas son las Bebidas para ti");


                                        do
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                            Console.WriteLine("--------------------------------------------------------------");
                                            Console.WriteLine("_____________Menu de bebidas(General)____________\n");
                                            
                                            Console.WriteLine("__________Bebidas alcoholicas__________\n");
                                            Console.WriteLine("\n1 - Margarita-----------------------------$15.00");
                                            Console.WriteLine("\n2 - Mojito--------------------------------$20.50");
                                            Console.WriteLine("\n3 - Manhattan-----------------------------$29.10");
                                            Console.WriteLine("\n4 - Piña colada---------------------------$20.00");
                                            Console.WriteLine("\n5 - Daiquiri------------------------------$17.50");
                                            Console.WriteLine("\n6 - Long Island---------------------------$13.50");
                                            Console.WriteLine("\n7 - Bloody Mary---------------------------$20.00");
                                            Console.WriteLine("\n8 - Mai Tai-------------------------------$14.50");
                                            Console.WriteLine("\n9 - Sidecar-------------------------------$30.50\n");

                                            Console.WriteLine("____________________Licuados____________________\n");
                                            Console.WriteLine("\n10 - Tropical-----------------------------$2.50");
                                            Console.WriteLine("\n11 - Invernal-----------------------------$2.10");
                                            Console.WriteLine("\n12 - Clásico------------------------------$2.00");
                                            Console.WriteLine("\n13 - Chocomilk clásico--------------------$1.50");
                                            Console.WriteLine("\n14 - Completo-----------------------------$3.50\n");

                                            Console.WriteLine("__________Bebidas calientes e infusiones__________\n");
                                            Console.WriteLine("\n15 - Té Blanco----------------------------$1.00");
                                            Console.WriteLine("\n16 - Té Rojo------------------------------$1.10");
                                            Console.WriteLine("\n17 - Té negro de fresa--------------------$2.00");
                                            Console.WriteLine("\n18 - Manzanilla---------------------------$1.50");
                                            Console.WriteLine("\n19 - Matcha Latte-------------------------$2.80");
                                            Console.WriteLine("\n20 - Chocolate caliente-------------------$2.10");
                                            Console.WriteLine("\n21 - Café negro---------------------------$2.10");
                                            Console.WriteLine("\n22 - Capuccino----------------------------$3.50");


                                            Console.WriteLine("----------------------------------------------------------");
                                            Console.WriteLine("\n23 - Salir");
                                           

                                            Console.WriteLine("\nIngrese el numero de su consulta");
                                            id = Console.ReadLine();
                                           
                                            switch (id)
                                            {

                                                case "1":
                                                    Console.WriteLine("Precio: $" + alcohol.margarita());
                                                    alcohol.compraMargarita();
                                                    Console.ReadLine();

                                                    break;

                                                case "2":
                                                    Console.WriteLine("Precio: $" + alcohol.mojito());
                                                    alcohol.compraMojito();
                                                    Console.ReadLine();

                                                    break;
                                                case "3":
                                                    Console.WriteLine("Precio: $" + alcohol.manhattan());
                                                    alcohol.compraManhattan();
                                                    Console.ReadLine();
                                                    break;
                                                case "4":
                                                    Console.WriteLine("Precio: $" + alcohol.pColada());
                                                    alcohol.compraPColada();
                                                    Console.ReadLine();
                                                    break;
                                                case "5":
                                                    Console.WriteLine("Precio: $" + alcohol.daiquiri());
                                                    alcohol.compraDaiquiri();
                                                    Console.ReadLine();
                                                    break;
                                                case "6":
                                                    Console.WriteLine("Precio: $" + alcohol.longIsland());;
                                                    Console.ReadLine();
                                                    break;
                                                case "7":
                                                    Console.WriteLine("Precio: $" + alcohol.bloodyMary());
                                                    alcohol.compraBloodyMary();
                                                    Console.ReadLine();
                                                    break;
                                                case "8":
                                                    Console.WriteLine("Precio: $" + alcohol.maiTai());
                                                    alcohol.compraMaiTai();
                                                    Console.ReadLine();
                                                    break;
                                                case "9":
                                                    Console.WriteLine("Precio: $" + alcohol.sidecar());
                                                    alcohol.compraSidecar();
                                                    Console.ReadLine();
                                                    break;
                                                case "10":
                                                    Console.WriteLine("Precio: $" + licua.tropical());
                                                    licua.compraTropical();
                                                    Console.ReadLine();
                                                    break;
                                                case "11":
                                                    Console.WriteLine("Precio: $" + licua.invernal());
                                                    licua.compraInvernal();
                                                    Console.ReadLine();
                                                    break;
                                                case "12":
                                                    Console.WriteLine("Precio: $" + licua.clasico());
                                                    licua.compraClasico();
                                                    Console.ReadLine();
                                                    break;
                                                case "13":
                                                    Console.WriteLine("Precio: $" + licua.chocomilkClasico());
                                                    licua.compraChocomilkClasico();
                                                    Console.ReadLine();
                                                    break;
                                                case "14":
                                                    Console.WriteLine("Precio: $" + licua.completo());
                                                    licua.compraCompleto();
                                                    Console.ReadLine();
                                                    break;
                                                case "15":
                                                    Console.WriteLine("Precio: $" + infuciones.teBlanco());
                                                    infuciones.compraTeBlanco();
                                                    Console.ReadLine();
                                                    break;
                                                case "16":
                                                    Console.WriteLine("Precio: $" + infuciones.teRojo());
                                                    infuciones.compraTeRojo();
                                                    Console.ReadLine();
                                                    break;
                                                case "17":
                                                    Console.WriteLine("Precio: $" + infuciones.teNegroFresa());
                                                    infuciones.compraTeNegroFresa();
                                                    Console.ReadLine();
                                                    break;
                                                case "18":
                                                    Console.WriteLine("Precio: $" + infuciones.manzanilla());
                                                    infuciones.compraManzanilla();
                                                    Console.ReadLine();
                                                    break;
                                                case "19":
                                                    Console.WriteLine("Precio: $" + infuciones.matchaLatte());
                                                    infuciones.compraMatchaLatte();
                                                    Console.ReadLine();
                                                    break;
                                                case "20":
                                                    Console.WriteLine("Precio: $" + infuciones.chocolateCaliente());
                                                    infuciones.compraChocolateCaliente();
                                                    Console.ReadLine();
                                                    break;
                                                case "21":
                                                    Console.WriteLine("Precio: $" + infuciones.cafeNegro());
                                                    infuciones.compraCafeNegro();
                                                    Console.ReadLine();
                                                    break;
                                                case "22":
                                                    Console.WriteLine("Precio: $" + infuciones.capuccino());
                                                    infuciones.compraCapuccino();
                                                    Console.ReadLine();
                                                    break;
                                                case "23":
                                                    Console.WriteLine("Fin de las consultas");
                                                    break;
                                                default:
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("La opcion que ha elegido no es correcta");
                                                    Console.ReadKey();
                                                    break;

                                            }
                                            


                                        }
                                        while (id != "23");
                                        
                                    }

                                    else
                                    {
                                        Console.WriteLine("El cliente no puede ordenanr nada de bebidas alcoholicas deseas que te muestre el menu infantil");

                                        do
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                            Console.WriteLine("--------------------------------------------------------------");
                                            Console.WriteLine("__________Menu de bebidas(Infantil)\n");

                                            Console.WriteLine("___________________Licuados___________________");
                                            Console.WriteLine("\n1 - Tropical-----------------------------$2.50");
                                            Console.WriteLine("\n2 - Invernal-----------------------------$2.10");
                                            Console.WriteLine("\n3 - Clásico------------------------------$2.00");
                                            Console.WriteLine("\n4 - Chocomilk clásico--------------------$1.50");
                                            Console.WriteLine("\n5 - Completo-----------------------------$3.50\n");
                                            Console.WriteLine("__________Bebidas calientes e infusiones__________\n");
                                            Console.WriteLine("\n6 - Té Blanco----------------------------$1.00");
                                            Console.WriteLine("\n7 - Té Rojo------------------------------$1.10");
                                            Console.WriteLine("\n8 - Té negro de fresa--------------------$2.00");
                                            Console.WriteLine("\n9 - Manzanilla---------------------------$1.50");
                                            Console.WriteLine("\n10 - Matcha Latte------------------------$2.80");
                                            Console.WriteLine("\n11 - Chocolate caliente------------------$2.10");
                                            Console.WriteLine("\n12 - Café negro--------------------------$2.10");
                                            Console.WriteLine("\n13 - Capuccino---------------------------$3.50");


                                            Console.WriteLine("----------------------------------------------------------");
                                            Console.WriteLine("\n14 - Salir");


                                            Console.WriteLine("\nIngrese el numero de su consulta");
                                            id = Console.ReadLine();

                                            switch (id)
                                            {
                                                case "1":
                                                    Console.WriteLine("Precio: $" + licua.tropical());
                                                    licua.compraTropical();
                                                    Console.ReadLine();
                                                    break;
                                                case "2":
                                                    Console.WriteLine("Precio: $" + licua.invernal());
                                                    licua.compraInvernal();
                                                    Console.ReadLine();
                                                    break;
                                                case "3":
                                                    Console.WriteLine("Precio: $" + licua.clasico());
                                                    licua.compraClasico();
                                                    Console.ReadLine();
                                                    break;
                                                case "4":
                                                    Console.WriteLine("Precio: $" + licua.chocomilkClasico());
                                                    licua.compraChocomilkClasico();
                                                    Console.ReadLine();
                                                    break;
                                                case "5":
                                                    Console.WriteLine("Precio: $" + licua.completo());
                                                    licua.compraCompleto();
                                                    Console.ReadLine();
                                                    break;
                                                case "6":
                                                    Console.WriteLine("Precio: $" + infuciones.teBlanco());
                                                    infuciones.compraTeBlanco();
                                                    Console.ReadLine();
                                                    break;
                                                case "7":
                                                    Console.WriteLine("Precio: $" + infuciones.teRojo());
                                                    infuciones.compraTeRojo();
                                                    Console.ReadLine();
                                                    break;
                                                case "8":
                                                    Console.WriteLine("Precio: $" + infuciones.teNegroFresa());
                                                    infuciones.compraTeNegroFresa();
                                                    Console.ReadLine();
                                                    break;
                                                case "9":
                                                    Console.WriteLine("Precio: $" + infuciones.manzanilla());
                                                    infuciones.compraManzanilla();
                                                    Console.ReadLine();
                                                    break;
                                                case "10":
                                                    Console.WriteLine("Precio: $" + infuciones.matchaLatte());
                                                    infuciones.compraMatchaLatte();
                                                    Console.ReadLine();
                                                    break;
                                                case "11":
                                                    Console.WriteLine("Precio: $" + infuciones.chocolateCaliente());
                                                    infuciones.compraChocolateCaliente();
                                                    Console.ReadLine();
                                                    break;
                                                case "12":
                                                    Console.WriteLine("Precio: $" + infuciones.cafeNegro());
                                                    infuciones.compraCafeNegro();
                                                    Console.ReadLine();
                                                    break;
                                                case "13":
                                                    Console.WriteLine("Precio: $" + infuciones.capuccino());
                                                    infuciones.compraCapuccino();
                                                    Console.ReadLine();
                                                    break;
                                                case "14":
                                                    Console.WriteLine("Fin de las consultas");
                                                    break;

                                                default:
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("La opcion que ha elegido no es correcta");
                                                    Console.ReadKey();
                                                    break;

                                            }



                                        }
                                        while (id != "14");


                                    }

                                    break;

                                case "2":
                                    do
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Magenta;
                                        Console.WriteLine("--------------------------------------------------------------");
                                        Console.WriteLine("____________Menu de bebidas____________\n");

                                        Console.WriteLine("__________Bebidas alcoholicas__________\n");
                                        Console.WriteLine("\n1 - Margarita-----------------------------$15.00");
                                        Console.WriteLine("\n2 - Mojito--------------------------------$20.50");
                                        Console.WriteLine("\n3 - Manhattan-----------------------------$29.10");
                                        Console.WriteLine("\n4 - Piña colada---------------------------$20.00");
                                        Console.WriteLine("\n5 - Daiquiri------------------------------$17.50");
                                        Console.WriteLine("\n6 - Long Island---------------------------$13.50");
                                        Console.WriteLine("\n7 - Bloody Mary---------------------------$20.00");
                                        Console.WriteLine("\n8 - Mai Tai-------------------------------$14.50");
                                        Console.WriteLine("\n9 - Sidecar-------------------------------$30.50\n");

                                        Console.WriteLine("____________________Licuados____________________\n");
                                        Console.WriteLine("\n10 - Tropical-----------------------------$2.50");
                                        Console.WriteLine("\n11 - Invernal-----------------------------$2.10");
                                        Console.WriteLine("\n12 - Clásico------------------------------$2.00");
                                        Console.WriteLine("\n13 - Chocomilk clásico--------------------$1.50");
                                        Console.WriteLine("\n14 - Completo-----------------------------$3.50\n");

                                        Console.WriteLine("__________Bebidas calientes e infusiones__________\n");
                                        Console.WriteLine("\n15 - Té Blanco----------------------------$1.00");
                                        Console.WriteLine("\n16 - Té Rojo------------------------------$1.10");
                                        Console.WriteLine("\n17 - Té negro de fresa--------------------$2.00");
                                        Console.WriteLine("\n18 - Manzanilla---------------------------$1.50");
                                        Console.WriteLine("\n19 - Matcha Latte-------------------------$2.80");
                                        Console.WriteLine("\n20 - Chocolate caliente-------------------$2.10");
                                        Console.WriteLine("\n21 - Café negro---------------------------$2.10");
                                        Console.WriteLine("\n22 - Capuccino----------------------------$3.50");


                                        Console.WriteLine("----------------------------------------------------------");
                                        Console.WriteLine("\n23 - Salir");



                                        Console.WriteLine("\nIngrese el numero de su consulta");
                                        id = Console.ReadLine();

                                        switch (id)
                                        {

                                            case "1":
                                                Console.WriteLine("Precio: $" + alcohol.margarita());
                                                Console.WriteLine(alcohol.categoria());
                                                Console.WriteLine(alcohol.tipo());
                                                Console.WriteLine(alcohol.preparacionMargarita());
                                                Console.ReadLine();
                                                break;

                                            case "2":
                                                Console.WriteLine("Precio: $" + alcohol.mojito());
                                                Console.WriteLine(alcohol.categoria());
                                                Console.WriteLine(alcohol.tipo());
                                                Console.WriteLine(alcohol.preparacionMojito());
                                                Console.ReadLine();

                                                break;
                                            case "3":
                                                Console.WriteLine("Precio: $" + alcohol.manhattan());
                                                Console.WriteLine(alcohol.categoria());
                                                Console.WriteLine(alcohol.tipo());
                                                Console.WriteLine(alcohol.preparacionManhattan());
                                                Console.ReadLine();

                                                break;
                                            case "4":
                                                Console.WriteLine("Precio: $" + alcohol.pColada());
                                                Console.WriteLine(alcohol.categoria());
                                                Console.WriteLine(alcohol.tipo());
                                                Console.WriteLine(alcohol.preparacionPColada());
                                                Console.ReadLine();

                                                break;
                                            case "5":
                                                Console.WriteLine("Precio: $" + alcohol.daiquiri());
                                                Console.WriteLine(alcohol.categoria());
                                                Console.WriteLine(alcohol.tipo());
                                                Console.WriteLine(alcohol.preparacionDaiquiri());
                                                Console.ReadLine();

                                                break;
                                            case "6":
                                                Console.WriteLine("Precio: $" + alcohol.longIsland());
                                                Console.WriteLine(alcohol.categoria());
                                                Console.WriteLine(alcohol.tipo());
                                                Console.WriteLine(alcohol.preparacionLongIsland());
                                                Console.ReadLine();

                                                break;
                                            case "7":
                                                Console.WriteLine("Precio: $" + alcohol.bloodyMary());
                                                Console.WriteLine(alcohol.categoria());
                                                Console.WriteLine(alcohol.tipo());
                                                Console.WriteLine(alcohol.preparacionBloodyMary());
                                                Console.ReadLine();

                                                break;
                                            case "8":
                                                Console.WriteLine("Precio: $" + alcohol.maiTai());
                                                Console.WriteLine(alcohol.categoria());
                                                Console.WriteLine(alcohol.tipo());
                                                Console.WriteLine(alcohol.preparacionMaiTai());
                                                Console.ReadLine();

                                                break;
                                            case "9":
                                                Console.WriteLine("Precio: $" + alcohol.sidecar());
                                                Console.WriteLine(alcohol.categoria());
                                                Console.WriteLine(alcohol.tipo());
                                                Console.WriteLine(alcohol.preparacionSidecar());
                                                Console.ReadLine();

                                                break;
                                            case "10":
                                                Console.WriteLine("Precio: $" + licua.tropical());
                                                Console.WriteLine(licua.categoria());
                                                Console.WriteLine(licua.tipo());
                                                Console.WriteLine(licua.preparacionTropical());
                                                Console.ReadLine();

                                                break;
                                            case "11":
                                                Console.WriteLine("Precio: $" + licua.invernal());
                                                Console.WriteLine(licua.categoria());
                                                Console.WriteLine(licua.tipo());
                                                Console.WriteLine(licua.preparacionInvernal());
                                                Console.ReadLine();

                                                break;
                                            case "12":
                                                Console.WriteLine("Precio: $" + licua.clasico());
                                                Console.WriteLine(licua.categoria());
                                                Console.WriteLine(licua.tipo());
                                                Console.WriteLine(licua.preparacionClasico());
                                                Console.ReadLine();

                                                break;
                                            case "13":
                                                Console.WriteLine("Precio: $" + licua.chocomilkClasico());
                                                Console.WriteLine(licua.categoria());
                                                Console.WriteLine(licua.tipo());
                                                Console.WriteLine(licua.preparacionChocomilk());
                                                Console.ReadLine();

                                                break;
                                            case "14":
                                                Console.WriteLine("Precio: $" + licua.completo());
                                                Console.WriteLine(licua.categoria());
                                                Console.WriteLine(licua.tipo());
                                                Console.WriteLine(licua.preparacionCompleto());
                                                Console.ReadLine();

                                                break;
                                            case "15":
                                                Console.WriteLine("Precio: $" + infuciones.teBlanco());
                                                Console.WriteLine(infuciones.categoria());
                                                Console.WriteLine(infuciones.tipo());
                                                Console.WriteLine(infuciones.preparacionTe());
                                                Console.ReadLine();


                                                break;
                                            case "16":
                                                Console.WriteLine("Precio: $" + infuciones.teRojo());
                                                Console.WriteLine(infuciones.categoria());
                                                Console.WriteLine(infuciones.tipo());
                                                Console.WriteLine(infuciones.preparacionTe());
                                                Console.ReadLine();

                                                break;
                                            case "17":
                                                Console.WriteLine("Precio: $" + infuciones.teNegroFresa());
                                                Console.WriteLine(infuciones.categoria());
                                                Console.WriteLine(infuciones.tipo());
                                                Console.WriteLine(infuciones.preparacionTe());
                                                Console.ReadLine();

                                                break;
                                            case "18":
                                                Console.WriteLine("Precio: $" + infuciones.manzanilla());
                                                Console.WriteLine(infuciones.categoria());
                                                Console.WriteLine(infuciones.tipo());
                                                Console.WriteLine(infuciones.preparacionTe());
                                                Console.ReadLine();

                                                break;
                                            case "19":
                                                Console.WriteLine("Precio: $" + infuciones.matchaLatte());
                                                Console.WriteLine(infuciones.categoria());
                                                Console.WriteLine(infuciones.tipo());
                                                Console.WriteLine(infuciones.preparacionMatchaLatte());
                                                Console.ReadLine();

                                                break;
                                            case "20":
                                                Console.WriteLine("Precio: $" + infuciones.chocolateCaliente());
                                                Console.WriteLine(infuciones.categoria());
                                                Console.WriteLine(infuciones.tipo());
                                                Console.WriteLine(infuciones.preparacionChocolate());
                                                Console.ReadLine();

                                                break;
                                            case "21":
                                                Console.WriteLine("Precio: $" + infuciones.cafeNegro());
                                                Console.WriteLine(infuciones.categoria());
                                                Console.WriteLine(infuciones.tipo());
                                                Console.WriteLine(infuciones.preparacionCafe());
                                                Console.ReadLine();
                                                break;
                                            case "22":
                                                Console.WriteLine("Precio: $" + infuciones.capuccino());
                                                Console.WriteLine(infuciones.categoria());
                                                Console.WriteLine(infuciones.tipo());
                                                Console.WriteLine(infuciones.preparacionCapucccino());
                                                Console.ReadLine();
                                                break;

                                            case "23":
                                                Console.WriteLine("Fin de las consultas");
                                               
                                                break;

                                            default:
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("La opcion que ha elegido no es correcta");
                                                Console.ReadKey();
                                                break;

                                        }
                                        Console.ReadLine();


                                    }
                                    while (id != "23");
                                    Console.ReadLine();
                                    break;

                                case "3":
                                    cliente.Nombres();
                                    Console.ReadLine();
                                    break;


                                case "4":
                                    Console.WriteLine("Fin de las consultas");
                                  
                                    break;
                                default:
                                    Console.WriteLine("No es correcto");
                                    break;

                            }

                        }
                        while (id != "4");
                        Console.ReadLine();
                        break;



                    case "2":

                        do
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("------------------------Rol de Empleado-------------------------");

                            Console.WriteLine("\n1 - Comprar");
                            Console.WriteLine("\n2 - Lista de bebidas");
                            Console.WriteLine("\n3 - Lista de empleados");
                            Console.WriteLine("\n4 - Calcular pago por horas de trabajo");
                            Console.WriteLine("\n5 - Salir");
                            Console.WriteLine("----------------------------------------------------------");
                            Console.WriteLine("\nIngrese el numero de su consulta");
                            id = Console.ReadLine();
                            switch (id)
                            {
                                case "1":
                                    datos.DatosUsuario(datos.Nombre, datos.Apellido, datos.Edad);
                                    Console.WriteLine(datos.Mostrar());


                                    if (datos.Edad >= 18)
                                    {


                                        Console.WriteLine("El Cliente es mayor de Edad a continuacion estas son las Bebidas para ti");


                                        do
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                            Console.WriteLine("--------------------------------------------------------------");
                                            Console.WriteLine("______________Menu de bebidas__________\n");

                                            Console.WriteLine("__________Bebidas alcoholicas__________\n");
                                            Console.WriteLine("\n1 - Margarita-----------------------------$15.00");
                                            Console.WriteLine("\n2 - Mojito--------------------------------$20.50");
                                            Console.WriteLine("\n3 - Manhattan-----------------------------$29.10");
                                            Console.WriteLine("\n4 - Piña colada---------------------------$20.00");
                                            Console.WriteLine("\n5 - Daiquiri------------------------------$17.50");
                                            Console.WriteLine("\n6 - Long Island---------------------------$13.50");
                                            Console.WriteLine("\n7 - Bloody Mary---------------------------$20.00");
                                            Console.WriteLine("\n8 - Mai Tai-------------------------------$14.50");
                                            Console.WriteLine("\n9 - Sidecar-------------------------------$30.50\n");

                                            Console.WriteLine("____________________Licuados____________________\n");
                                            Console.WriteLine("\n10 - Tropical-----------------------------$2.50");
                                            Console.WriteLine("\n11 - Invernal-----------------------------$2.10");
                                            Console.WriteLine("\n12 - Clásico------------------------------$2.00");
                                            Console.WriteLine("\n13 - Chocomilk clásico--------------------$1.50");
                                            Console.WriteLine("\n14 - Completo-----------------------------$3.50\n");

                                            Console.WriteLine("__________Bebidas calientes e infusiones__________\n");
                                            Console.WriteLine("\n15 - Té Blanco----------------------------$1.00");
                                            Console.WriteLine("\n16 - Té Rojo------------------------------$1.10");
                                            Console.WriteLine("\n17 - Té negro de fresa--------------------$2.00");
                                            Console.WriteLine("\n18 - Manzanilla---------------------------$1.50");
                                            Console.WriteLine("\n19 - Matcha Latte-------------------------$2.80");
                                            Console.WriteLine("\n20 - Chocolate caliente-------------------$2.10");
                                            Console.WriteLine("\n21 - Café negro---------------------------$2.10");
                                            Console.WriteLine("\n22 - Capuccino----------------------------$3.50");


                                            Console.WriteLine("----------------------------------------------------------");
                                            Console.WriteLine("\n23 - Salir");


                                            Console.WriteLine("\nIngrese el numero de su consulta");
                                            id = Console.ReadLine();

                                            switch (id)
                                            {

                                                case "1":
                                                    Console.WriteLine("Precio: $" + alcohol.margarita());
                                                    alcohol.compraMargarita();
                                                    Console.ReadLine();

                                                    break;

                                                case "2":
                                                    Console.WriteLine("Precio: $" + alcohol.mojito());
                                                    alcohol.compraMojito();
                                                    Console.ReadLine();

                                                    break;
                                                case "3":
                                                    Console.WriteLine("Precio: $" + alcohol.manhattan());
                                                    alcohol.compraManhattan();
                                                    Console.ReadLine();
                                                    break;
                                                case "4":
                                                    Console.WriteLine("Precio: $" + alcohol.pColada());
                                                    alcohol.compraPColada();
                                                    Console.ReadLine();
                                                    break;
                                                case "5":
                                                    Console.WriteLine("Precio: $" + alcohol.daiquiri());
                                                    alcohol.compraDaiquiri();
                                                    Console.ReadLine();
                                                    break;
                                                case "6":
                                                    Console.WriteLine("Precio: $" + alcohol.longIsland());
                                                    alcohol.compraLongIsland();
                                                    Console.ReadLine();
                                                    break;
                                                case "7":
                                                    Console.WriteLine("Precio: $" + alcohol.bloodyMary());
                                                    alcohol.compraBloodyMary();
                                                    Console.ReadLine();
                                                    break;
                                                case "8":
                                                    Console.WriteLine("Precio: $" + alcohol.maiTai());
                                                    alcohol.compraMaiTai();
                                                    Console.ReadLine();
                                                    break;
                                                case "9":
                                                    Console.WriteLine("Precio: $" + alcohol.sidecar());
                                                    alcohol.compraSidecar();
                                                    Console.ReadLine();
                                                    break;
                                                case "10":
                                                    Console.WriteLine("Precio: $" + licua.tropical());
                                                    licua.compraTropical();
                                                    Console.ReadLine();
                                                    break;
                                                case "11":
                                                    Console.WriteLine("Precio: $" + licua.invernal());
                                                    licua.compraInvernal();
                                                    Console.ReadLine();
                                                    break;
                                                case "12":
                                                    Console.WriteLine("Precio: $" + licua.clasico());
                                                    licua.compraClasico();
                                                    Console.ReadLine();
                                                    break;
                                                case "13":
                                                    Console.WriteLine("Precio: $" + licua.chocomilkClasico());
                                                    licua.compraChocomilkClasico();
                                                    Console.ReadLine();
                                                    break;
                                                case "14":
                                                    Console.WriteLine("Precio: $" + licua.completo());
                                                    licua.compraCompleto();
                                                    Console.ReadLine();
                                                    break;
                                                case "15":
                                                    Console.WriteLine("Precio: $" + infuciones.teBlanco());
                                                    infuciones.compraTeBlanco();
                                                    Console.ReadLine();
                                                    break;
                                                case "16":
                                                    Console.WriteLine("Precio: $" + infuciones.teRojo());
                                                    infuciones.compraTeRojo();
                                                    Console.ReadLine();
                                                    break;
                                                case "17":
                                                    Console.WriteLine("Precio: $" + infuciones.teNegroFresa());
                                                    infuciones.compraTeNegroFresa();
                                                    Console.ReadLine();
                                                    break;
                                                case "18":
                                                    Console.WriteLine("Precio: $" + infuciones.manzanilla());
                                                    infuciones.compraManzanilla();
                                                    Console.ReadLine();
                                                    break;
                                                case "19":
                                                    Console.WriteLine("Precio: $" + infuciones.matchaLatte());
                                                    infuciones.compraMatchaLatte();
                                                    Console.ReadLine();
                                                    break;
                                                case "20":
                                                    Console.WriteLine("Precio: $" + infuciones.chocolateCaliente());
                                                    infuciones.compraChocolateCaliente();
                                                    Console.ReadLine();
                                                    break;
                                                case "21":
                                                    Console.WriteLine("Precio: $" + infuciones.cafeNegro());
                                                    infuciones.compraCafeNegro();
                                                    Console.ReadLine();
                                                    break;
                                                case "22":
                                                    Console.WriteLine("Precio: $" + infuciones.capuccino());
                                                    infuciones.compraCapuccino();
                                                    Console.ReadLine();
                                                    break;
                                                case "23":
                                                    Console.WriteLine("Fin de las consultas");
                                                    break;
                                                default:
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("La opcion que ha elegido no es correcta");
                                                    Console.ReadKey();
                                                    break;

                                            }
                                            Console.ReadLine();


                                        }
                                        while (id != "23");
                                    }
                                    else
                                    {
                                        Console.WriteLine("El cliente no puede ordenanr nada de bebidas alcoholicas deseas que te muestre el menu infantil");

                                        do
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                            Console.WriteLine("--------------------------------------------------------------");
                                            Console.WriteLine("__________Menu de bebidas__________\n");

                                            Console.WriteLine("           __________Licuados__________");
                                            Console.WriteLine("\n1 - Tropical-----------------------------$2.50");
                                            Console.WriteLine("\n2 - Invernal-----------------------------$2.10");
                                            Console.WriteLine("\n3 - Clásico------------------------------$2.00");
                                            Console.WriteLine("\n4 - Chocomilk clásico--------------------$1.50");
                                            Console.WriteLine("\n5 - Completo-----------------------------$3.50\n");
                                            Console.WriteLine("__________Bebidas calientes e infusiones__________\n");
                                            Console.WriteLine("\n6 - Té Blanco----------------------------$1.00");
                                            Console.WriteLine("\n7 - Té Rojo------------------------------$1.10");
                                            Console.WriteLine("\n8 - Té negro de fresa--------------------$2.00");
                                            Console.WriteLine("\n9 - Manzanilla---------------------------$1.50");
                                            Console.WriteLine("\n10 - Matcha Latte------------------------$2.80");
                                            Console.WriteLine("\n11 - Chocolate caliente------------------$2.10");
                                            Console.WriteLine("\n12 - Café negro--------------------------$2.10");
                                            Console.WriteLine("\n13 - Capuccino---------------------------$3.50");


                                            Console.WriteLine("----------------------------------------------------------");
                                            Console.WriteLine("\n14 - Salir");


                                            Console.WriteLine("\nIngrese el numero de su consulta");
                                            id = Console.ReadLine();

                                            switch (id)
                                            {
                                                case "1":
                                                    Console.WriteLine("Precio: $" + licua.tropical());
                                                    licua.compraTropical();
                                                    Console.ReadLine();
                                                    break;
                                                case "2":
                                                    Console.WriteLine("Precio: $" + licua.invernal());
                                                    licua.compraInvernal();
                                                    Console.ReadLine();
                                                    break;
                                                case "3":
                                                    Console.WriteLine("Precio: $" + licua.clasico());
                                                    licua.compraClasico();
                                                    Console.ReadLine();
                                                    break;
                                                case "4":
                                                    Console.WriteLine("Precio: $" + licua.chocomilkClasico());
                                                    licua.compraChocomilkClasico();
                                                    Console.ReadLine();
                                                    break;
                                                case "5":
                                                    Console.WriteLine("Precio: $" + licua.completo());
                                                    licua.compraCompleto();
                                                    Console.ReadLine();
                                                    break;
                                                case "6":
                                                    Console.WriteLine("Precio: $" + infuciones.teBlanco());
                                                    infuciones.compraTeBlanco();
                                                    Console.ReadLine();
                                                    break;
                                                case "7":
                                                    Console.WriteLine("Precio: $" + infuciones.teRojo());
                                                    infuciones.compraTeRojo();
                                                    Console.ReadLine();
                                                    break;
                                                case "8":
                                                    Console.WriteLine("Precio: $" + infuciones.teNegroFresa());
                                                    infuciones.compraTeNegroFresa();
                                                    Console.ReadLine();
                                                    break;
                                                case "9":
                                                    Console.WriteLine("Precio: $" + infuciones.manzanilla());
                                                    infuciones.compraManzanilla();
                                                    Console.ReadLine();
                                                    break;
                                                case "10":
                                                    Console.WriteLine("Precio: $" + infuciones.matchaLatte());
                                                    infuciones.compraMatchaLatte();
                                                    Console.ReadLine();
                                                    break;
                                                case "11":
                                                    Console.WriteLine("Precio: $" + infuciones.chocolateCaliente());
                                                    infuciones.compraChocolateCaliente();
                                                    Console.ReadLine();
                                                    break;
                                                case "12":
                                                    Console.WriteLine("Precio: $" + infuciones.cafeNegro());
                                                    infuciones.compraCafeNegro();
                                                    Console.ReadLine();
                                                    break;
                                                case "13":
                                                    Console.WriteLine("Precio: $" + infuciones.capuccino());
                                                    infuciones.compraCapuccino();
                                                    Console.ReadLine();
                                                    break;
                                                case "14":
                                                    Console.WriteLine("Fin de las consultas");
                                                    break;

                                                default:
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("La opcion que ha elegido no es correcta");
                                                    Console.ReadKey();
                                                    break;

                                            }
                                            Console.ReadLine();


                                        }
                                        while (id != "14");

                                    }
                                    Console.WriteLine("-------------------------------------");
                                    Console.ReadLine();
                                    break;

                                case "2":
                                    do
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Magenta;
                                        Console.WriteLine("--------------------------------------------------------------");
                                        Console.WriteLine("____________Menu de bebidas____________\n");

                                        Console.WriteLine("__________Bebidas alcoholicas__________\n");
                                        Console.WriteLine("\n1 - Margarita-----------------------------$15.00");
                                        Console.WriteLine("\n2 - Mojito--------------------------------$20.50");
                                        Console.WriteLine("\n3 - Manhattan-----------------------------$29.10");
                                        Console.WriteLine("\n4 - Piña colada---------------------------$20.00");
                                        Console.WriteLine("\n5 - Daiquiri------------------------------$17.50");
                                        Console.WriteLine("\n6 - Long Island---------------------------$13.50");
                                        Console.WriteLine("\n7 - Bloody Mary---------------------------$20.00");
                                        Console.WriteLine("\n8 - Mai Tai-------------------------------$14.50");
                                        Console.WriteLine("\n9 - Sidecar-------------------------------$30.50\n");

                                        Console.WriteLine("____________________Licuados____________________\n");
                                        Console.WriteLine("\n10 - Tropical-----------------------------$2.50");
                                        Console.WriteLine("\n11 - Invernal-----------------------------$2.10");
                                        Console.WriteLine("\n12 - Clásico------------------------------$2.00");
                                        Console.WriteLine("\n13 - Chocomilk clásico--------------------$1.50");
                                        Console.WriteLine("\n14 - Completo-----------------------------$3.50\n");

                                        Console.WriteLine("__________Bebidas calientes e infusiones__________\n");
                                        Console.WriteLine("\n15 - Té Blanco----------------------------$1.00");
                                        Console.WriteLine("\n16 - Té Rojo------------------------------$1.10");
                                        Console.WriteLine("\n17 - Té negro de fresa--------------------$2.00");
                                        Console.WriteLine("\n18 - Manzanilla---------------------------$1.50");
                                        Console.WriteLine("\n19 - Matcha Latte-------------------------$2.80");
                                        Console.WriteLine("\n20 - Chocolate caliente-------------------$2.10");
                                        Console.WriteLine("\n21 - Café negro---------------------------$2.10");
                                        Console.WriteLine("\n22 - Capuccino----------------------------$3.50");


                                        Console.WriteLine("----------------------------------------------------------");
                                        Console.WriteLine("\n23 - Salir");



                                        Console.WriteLine("\nIngrese el numero de su consulta");
                                        id = Console.ReadLine();

                                        switch (id)
                                        {

                                            case "1":
                                                Console.WriteLine("Precio: $" + alcohol.margarita());
                                                Console.WriteLine(alcohol.categoria());
                                                Console.WriteLine(alcohol.tipo());
                                                Console.WriteLine(alcohol.preparacionMargarita());
                                                Console.ReadLine();
                                                break;

                                            case "2":
                                                Console.WriteLine("Precio: $" + alcohol.mojito());
                                                Console.WriteLine(alcohol.categoria());
                                                Console.WriteLine(alcohol.tipo());
                                                Console.WriteLine(alcohol.preparacionMojito());
                                                Console.ReadLine();
                                                break;
                                            case "3":
                                                Console.WriteLine("Precio: $" + alcohol.manhattan());
                                                Console.WriteLine(alcohol.categoria());
                                                Console.WriteLine(alcohol.tipo());
                                                Console.WriteLine(alcohol.preparacionManhattan());
                                                Console.ReadLine();
                                                break;
                                            case "4":
                                                Console.WriteLine("Precio: $" + alcohol.pColada());
                                                Console.WriteLine(alcohol.categoria());
                                                Console.WriteLine(alcohol.tipo());
                                                Console.WriteLine(alcohol.preparacionPColada());
                                                Console.ReadLine();
                                                break;
                                            case "5":
                                                Console.WriteLine("Precio: $" + alcohol.daiquiri());
                                                Console.WriteLine(alcohol.categoria());
                                                Console.WriteLine(alcohol.tipo());
                                                Console.WriteLine(alcohol.preparacionDaiquiri());
                                                Console.ReadLine();
                                                break;
                                            case "6":
                                                Console.WriteLine("Precio: $" + alcohol.longIsland());
                                                Console.WriteLine(alcohol.categoria());
                                                Console.WriteLine(alcohol.tipo());
                                                Console.WriteLine(alcohol.preparacionLongIsland());
                                                Console.ReadLine();
                                                break;
                                            case "7":
                                                Console.WriteLine("Precio: $" + alcohol.bloodyMary());
                                                Console.WriteLine(alcohol.categoria());
                                                Console.WriteLine(alcohol.tipo());
                                                Console.WriteLine(alcohol.preparacionBloodyMary());
                                                Console.ReadLine();
                                                break;
                                            case "8":
                                                Console.WriteLine("Precio: $" + alcohol.maiTai());
                                                Console.WriteLine(alcohol.categoria());
                                                Console.WriteLine(alcohol.tipo());
                                                Console.WriteLine(alcohol.preparacionMaiTai());
                                                Console.ReadLine();
                                                break;
                                            case "9":
                                                Console.WriteLine("Precio: $" + alcohol.sidecar());
                                                Console.WriteLine(alcohol.categoria());
                                                Console.WriteLine(alcohol.tipo());
                                                Console.WriteLine(alcohol.preparacionSidecar());
                                                Console.ReadLine();
                                                break;
                                            case "10":
                                                Console.WriteLine("Precio: $" + licua.tropical());
                                                Console.WriteLine(licua.categoria());
                                                Console.WriteLine(licua.tipo());
                                                Console.WriteLine(licua.preparacionTropical());
                                                Console.ReadLine();
                                                break;
                                            case "11":
                                                Console.WriteLine("Precio: $" + licua.invernal());
                                                Console.WriteLine(licua.categoria());
                                                Console.WriteLine(licua.tipo());
                                                Console.WriteLine(licua.preparacionInvernal());
                                                Console.ReadLine();
                                                break;
                                            case "12":
                                                Console.WriteLine("Precio: $" + licua.clasico());
                                                Console.WriteLine(licua.categoria());
                                                Console.WriteLine(licua.tipo());
                                                Console.WriteLine(licua.preparacionClasico());
                                                Console.ReadLine();
                                                break;
                                            case "13":
                                                Console.WriteLine("Precio: $" + licua.chocomilkClasico());
                                                Console.WriteLine(licua.categoria());
                                                Console.WriteLine(licua.tipo());
                                                Console.WriteLine(licua.preparacionChocomilk());
                                                Console.ReadLine();
                                                break;
                                            case "14":
                                                Console.WriteLine("Precio: $" + licua.completo());
                                                Console.WriteLine(licua.categoria());
                                                Console.WriteLine(licua.tipo());
                                                Console.WriteLine(licua.preparacionCompleto());
                                                Console.ReadLine();
                                                break;
                                            case "15":
                                                Console.WriteLine("Precio: $" + infuciones.teBlanco());
                                                Console.WriteLine(infuciones.categoria());
                                                Console.WriteLine(infuciones.tipo());
                                                Console.WriteLine(infuciones.preparacionTe());
                                                Console.ReadLine();
                                                break;
                                            case "16":
                                                Console.WriteLine("Precio: $" + infuciones.teRojo());
                                                Console.WriteLine(infuciones.categoria());
                                                Console.WriteLine(infuciones.tipo());
                                                Console.WriteLine(infuciones.preparacionTe());
                                                Console.ReadLine();
                                                break;
                                            case "17":
                                                Console.WriteLine("Precio: $" + infuciones.teNegroFresa());
                                                Console.WriteLine(infuciones.categoria());
                                                Console.WriteLine(infuciones.tipo());
                                                Console.WriteLine(infuciones.preparacionTe());
                                                Console.ReadLine();
                                                break;
                                            case "18":
                                                Console.WriteLine("Precio: $" + infuciones.manzanilla());
                                                Console.WriteLine(infuciones.categoria());
                                                Console.WriteLine(infuciones.tipo());
                                                Console.WriteLine(infuciones.preparacionTe());
                                                Console.ReadLine();
                                                break;
                                            case "19":
                                                Console.WriteLine("Precio: $" + infuciones.matchaLatte());
                                                Console.WriteLine(infuciones.categoria());
                                                Console.WriteLine(infuciones.tipo());
                                                Console.WriteLine(infuciones.preparacionMatchaLatte());
                                                Console.ReadLine();
                                                break;
                                            case "20":
                                                Console.WriteLine("Precio: $" + infuciones.chocolateCaliente());
                                                Console.WriteLine(infuciones.categoria());
                                                Console.WriteLine(infuciones.tipo());
                                                Console.WriteLine(infuciones.preparacionChocolate());
                                                Console.ReadLine();
                                                break;
                                            case "21":
                                                Console.WriteLine("Precio: $" + infuciones.cafeNegro());
                                                Console.WriteLine(infuciones.categoria());
                                                Console.WriteLine(infuciones.tipo());
                                                Console.WriteLine(infuciones.preparacionCafe());
                                                Console.ReadLine();
                                                break;
                                            case "22":
                                                Console.WriteLine("Precio: $" + infuciones.capuccino());
                                                Console.WriteLine(infuciones.categoria());
                                                Console.WriteLine(infuciones.tipo());
                                                Console.WriteLine(infuciones.preparacionCapucccino());
                                                Console.ReadLine();
                                                break;

                                            case "23":
                                                Console.WriteLine("Fin de las consultas");
                                                break;

                                            default:
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("La opcion que ha elegido no es correcta");
                                                Console.ReadKey();
                                                break;

                                        }
                                        Console.ReadLine();


                                    }
                                    while (id != "23");
                                    Console.ReadLine();
                                    break;


                                case "3":
                                    empleado.Nombres();
                                    Console.ReadLine();

                                    break;

                                case "4":
                                    empleado.Sueldo();
                                    Console.ReadLine();

                                    break;

                                case "5":
                                    Console.WriteLine("Fin de las consultas");
                                    break;
                                default:
                                    Console.WriteLine("No es correcto");
                                    break;

                            }

                        }
                        while (id != "5");
                        Console.ReadLine();
                        break;

                    case "3":
                        Environment.Exit(0);
                        break;

                    default:

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("La opcion que ha elegido no es correcta");
                        Console.ReadKey();
                        break;

                }

            }
            while (id != "3");
            Console.ReadLine();

        }
    }
}
