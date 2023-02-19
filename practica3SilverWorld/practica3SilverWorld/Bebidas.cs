using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica3SilverWorld
{
    abstract class bebidas
    {


        public abstract string tipo();


        public abstract string categoria();


    }
    class alcoholicas : bebidas
    {
        double descuento;
        double respuesta;
        double pagar;
        double total;
        string id;
        int Codigo1 = 5678;
        int Codigo2 = 2345;
        Empleado empleado = new Empleado();

        public override string categoria()
        {
            return "Categoria: para mayores de 18 años";
        }

        public string preparacionMargarita()
        {
            return "Preparacion: mezcla de tequila, triple seco y jugo de limon o lima";

        }
        public string preparacionMojito()
        {
            return "Preparacion:  mezcla de ron, azucar, menta, lima, agua con gas o gaseosa y hielo";

        }
        public string preparacionManhattan()
        {
            return "Preparacion: mezcla de whisky y vermut rojo";

        }
        public string preparacionPColada()
        {
            return "Preparacion:  mezcla de piña, crema de coco y ron";

        }
        public string preparacionDaiquiri()
        {
            return "Preparacion: mezcla de ron blanco y zumo de limon";
        }
        public string preparacionLongIsland()
        {
            return "Preparacion:  mezcla de vodka, tequila, ron blanco, triple seco y zumo de limon";

        }
        public string preparacionBloodyMary()
        {
            return "Preparacion: mezcla de vodka, zumo de tomate, zumo de limon, tabasco, salsa worcestershine, sal pimienta y hielo";

        }
        public string preparacionMaiTai()
        {
            return "Preparacion: mezcla de ron añejo, ron blanco, y zumo de limon";

        }
        public string preparacionSidecar()
        {
            return "Preparacion:  mezcla de cognac o brandy, triple seco y zumo de limon";

        }

        public override string tipo()
        {
            return "Tipo: bebida alcoholica";
        }

        public double margarita()
        {

            return 15.00;
        }
        public void compraMargarita()
        {

            Console.WriteLine("Cuenta con codigo de descuento");
            do
            {
                Console.WriteLine("1.Si");
                Console.WriteLine("2.No");
                Console.WriteLine("3.Salir");
                Console.WriteLine("\nIngrese el numero de su consulta");
                id = Console.ReadLine();
                switch (id)
                {
                    case "1":

                        Console.WriteLine("Ingrese la cantidad de dinero con la que pagara:");
                        pagar = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el codigo:");
                        descuento = double.Parse(Console.ReadLine());

                        if (descuento == Codigo1)
                        {
                            
                            
                            total = pagar - margarita() * 0.50;
                            
                            if (total < 0)
                            {
                                Console.WriteLine("Debe  $" + total + " para pagar su bebida");
                            }
                            if (total >= 0)
                            {
                                Console.WriteLine("Su saldo es de  $" + total);
                            }

                        }
                        if(descuento == Codigo2)
                        {
                            respuesta = margarita() * 0.20;
                            
                            total = pagar - respuesta;
                            if (total < 0)
                            {
                                Console.WriteLine("Debe  $" + total + " para pagar su bebida");
                            }
                            if (pagar >= 0)
                            {
                                Console.WriteLine("Su saldo es de  $" + total);
                            }

                        }

                        
                       

                        break;
                    case "2":
                        Console.WriteLine("Ingrese la cantidad de dinero con la que pagara:");
                        pagar = double.Parse(Console.ReadLine()) ;
                        total = pagar - margarita();
                        if (total < 0)
                        {
                            Console.WriteLine("Debe  $" + total + " para pagar su bebida");
                        }
                        if (total >= 0)
                        {
                            Console.WriteLine("Su saldo es de  $" + total);
                        }
                        break;
                    case "3":
                        Console.WriteLine("Fin de consultas");
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
        public double mojito()
        {
            return 20.50;
        }
        public void compraMojito()
        {
            Console.WriteLine("Ingrese la cantidad de dinero con la que pagara");
            pagar = int.Parse(Console.ReadLine()) - mojito();

            if (pagar < 0)
            {
                Console.WriteLine("Debe  $" + pagar + " para pagar su bebida");
            }
            if (pagar >= 0)
            {
                Console.WriteLine("Su saldo es de  $" + pagar);
            }
        }
        public double manhattan()
        {
            return 29.10;
        }
        public void compraManhattan()
        {
            Console.WriteLine("Ingrese la cantidad de dinero con la que pagara");
            pagar = int.Parse(Console.ReadLine()) - manhattan();

            if (pagar < 0)
            {
                Console.WriteLine("Debe  $" + pagar + " para pagar su bebida");
            }
            if (pagar >= 0)
            {
                Console.WriteLine("Su saldo es de  $" + pagar);
            }
        }
        public double pColada()
        {
            return 20.00;
        }
        public void compraPColada()
        {
            Console.WriteLine("Ingrese la cantidad de dinero con la que pagara");
            pagar = int.Parse(Console.ReadLine()) - pColada();

            if (pagar < 0)
            {
                Console.WriteLine("Debe  $" + pagar + " para pagar su bebida");
            }
            if (pagar >= 0)
            {
                Console.WriteLine("Su saldo es de  $" + pagar);
            }
        }
        public double daiquiri()
        {
            return 17.50;
        }
        public void compraDaiquiri()
        {
            Console.WriteLine("Ingrese la cantidad de dinero con la que pagara");
            pagar = int.Parse(Console.ReadLine()) - daiquiri();

            if (pagar < 0)
            {
                Console.WriteLine("Debe  $" + pagar + " para pagar su bebida");
            }
            if (pagar >= 0)
            {
                Console.WriteLine("Su saldo es de  $" + pagar);
            }
        }
        public double longIsland()
        {
            return 13.50;
        }
        public void compraLongIsland()
        {
            Console.WriteLine("Ingrese la cantidad de dinero con la que pagara");
            pagar = int.Parse(Console.ReadLine()) - longIsland();

            if (pagar < 0)
            {
                Console.WriteLine("Debe  $" + pagar + " para pagar su bebida");
            }
            if (pagar >= 0)
            {
                Console.WriteLine("Su saldo es de  $" + pagar);
            }
        }
        public double bloodyMary()
        {
            return 20.00;
        }
        public void compraBloodyMary()
        {
            Console.WriteLine("Ingrese la cantidad de dinero con la que pagara");
            pagar = int.Parse(Console.ReadLine()) - bloodyMary();

            if (pagar < 0)
            {
                Console.WriteLine("Debe  $" + pagar + " para pagar su bebida");
            }
            if (pagar >= 0)
            {
                Console.WriteLine("Su saldo es de  $" + pagar);
            }
        }
        public double maiTai()
        {
            return 14.50;
        }
        public void compraMaiTai()
        {
            Console.WriteLine("Ingrese la cantidad de dinero con la que pagara");
            pagar = int.Parse(Console.ReadLine()) - maiTai();

            if (pagar < 0)
            {
                Console.WriteLine("Debe  $" + pagar + " para pagar su bebida");
            }
            if (pagar >= 0)
            {
                Console.WriteLine("Su saldo es de  $" + pagar);
            }
        }
        public double sidecar()
        {
            return 30.50;
        }
        public void compraSidecar()
        {
            Console.WriteLine("Ingrese la cantidad de dinero con la que pagara");
            pagar = int.Parse(Console.ReadLine()) - sidecar();

            if (pagar < 0)
            {
                Console.WriteLine("Debe  $" + pagar + " para pagar su bebida");
            }
            if (pagar >= 0)
            {
                Console.WriteLine("Su saldo es de  $" + pagar);
            }
        }

    }
    class licuados : bebidas
    {
        double pagar;
        public override string categoria()
        {
            return "Categoria: para todo público";
        }



        public override string tipo()
        {
            return "Tipo: licuados de frutas";
        }

        public double tropical()
        {
            return 2.50;
        }
        public void compraTropical()
        {
            Console.WriteLine("Ingrse la cantidad de dinero con la que pagara");
            pagar = int.Parse(Console.ReadLine()) - tropical();

            if (pagar < 0)
            {
                Console.WriteLine("Debe  $" + pagar + " para pagar su bebida");
            }
            if (pagar >= 0)
            {
                Console.WriteLine("Su saldo es de  $" + pagar);
            }
        }
        public string preparacionTropical()
        {
            return "Preparacion: mezcla de mago y durazno";
        }
        public double invernal()
        {
            return 2.10;
        }
        public void compraInvernal()
        {
            Console.WriteLine("Ingrese la cantidad de dinero con la que pagara");
            pagar = int.Parse(Console.ReadLine()) - invernal();

            if (pagar < 0)
            {
                Console.WriteLine("Debe  $" + pagar + " para pagar su bebida");
            }
            if (pagar >= 0)
            {
                Console.WriteLine("Su saldo es de  $" + pagar);
            }
        }
        public string preparacionInvernal()
        {
            return "Preparacion: mezcla de ciruelas, cerezas, fresa y leche";
        }
        public double clasico()
        {
            return 2.00;
        }
        public void compraClasico()
        {
            Console.WriteLine("Ingrese la cantidad de dinero con la que pagara");
            pagar = int.Parse(Console.ReadLine()) - clasico();

            if (pagar < 0)
            {
                Console.WriteLine("Debe  $" + pagar + " para pagar su bebida");
            }
            if (pagar >= 0)
            {
                Console.WriteLine("Su saldo es de  $" + pagar);
            }
        }
        public string preparacionClasico()
        {
            return "Preparacion: mezcla de banana con fresa y leche";
        }
        public double chocomilkClasico()
        {
            return 1.50;
        }
        public void compraChocomilkClasico()
        {
            Console.WriteLine("Ingrese la cantidad de dinero con la que pagara");
            pagar = int.Parse(Console.ReadLine()) - chocomilkClasico();

            if (pagar < 0)
            {
                Console.WriteLine("Debe  $" + pagar + " para pagar su bebida");
            }
            if (pagar >= 0)
            {
                Console.WriteLine("Su saldo es de  $" + pagar);
            }
        }
        public string preparacionChocomilk()
        {
            return "Preparacion: mezcla de leche con chololate y vainilla";
        }
        public double completo()
        {
            return 3.50;
        }
        public void compraCompleto()
        {
            Console.WriteLine("Ingrese la cantidad de dinero con la que pagara");
            pagar = int.Parse(Console.ReadLine()) - completo();

            if (pagar < 0)
            {
                Console.WriteLine("Debe  $" + pagar + " para pagar su bebida");
            }
            if (pagar >= 0)
            {
                Console.WriteLine("Su saldo es de  $" + pagar);
            }
        }
        public string preparacionCompleto()
        {
            return "Preparacion: mezcla de mago, durazno, fresa y banana";
        }
    }
    class CalientesInfuciones : bebidas
    {
        double pagar;
        public override string categoria()
        {
            return "Categoria: para todo publico";
        }


        public string preparacionTe()
        {
            return "Preparacion: mezcla de te y agua caliente";
        }
        public override string tipo()
        {
            return "Tipo: bebidas calientes e infusiones";
        }

        public double teBlanco()
        {
            return 1.00;
        }
        public void compraTeBlanco()
        {
            string id;
            double descuento;
            double total;
            double respuesta;
            int Codigo1 = 5678;
            int Codigo2 = 2345;
            Console.WriteLine("Cuenta con codigo de descuento");
            do
            {
                Console.WriteLine("1.Si");
                Console.WriteLine("2.No");
                Console.WriteLine("3.Salir");
                Console.WriteLine("\nIngrese el numero de su consulta");
                id = Console.ReadLine();
                switch (id)
                {
                    case "1":

                        Console.WriteLine("Ingrese la cantidad de dinero con la que pagara:");
                        pagar = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el codigo:");
                        descuento = double.Parse(Console.ReadLine());

                        if (descuento == Codigo1)
                        {


                            total = pagar - teBlanco() * 0.50;

                            if (total < 0)
                            {
                                Console.WriteLine("Debe  $" + total + " para pagar su bebida");
                            }
                            if (total >= 0)
                            {
                                Console.WriteLine("Su saldo es de  $" + total);
                            }

                        }
                        if (descuento == Codigo2)
                        {
                            respuesta = teBlanco() * 0.20;
                            
                            total = pagar - respuesta;
                            if (total < 0)
                            {
                                Console.WriteLine("Debe  $" + total + " para pagar su bebida");
                            }
                            if (pagar >= 0)
                            {
                                Console.WriteLine("Su saldo es de  $" + total);
                            }

                        }




                        break;
                    case "2":
                        Console.WriteLine("Ingrese la cantidad de dinero con la que pagara:");
                        pagar = double.Parse(Console.ReadLine());
                        total = pagar - teBlanco();
                        if (total < 0)
                        {
                            Console.WriteLine("Debe  $" + total + " para pagar su bebida");
                        }
                        if (total >= 0)
                        {
                            Console.WriteLine("Su saldo es de  $" + total);
                        }
                        break;
                    case "3":
                        Console.WriteLine("Fin de consultas");
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
        public double teRojo()
        {
            return 1.10;
        }
        public void compraTeRojo()
        {
            Console.WriteLine("Ingrese la cantidad de dinero con la que pagara");
            pagar = int.Parse(Console.ReadLine()) - teRojo();

            if (pagar < 0)
            {
                Console.WriteLine("Debe  $" + pagar + " para pagar su bebida");
            }
            if (pagar >= 0)
            {
                Console.WriteLine("Su saldo es de  $" + pagar);
            }
        }
        public double teNegroFresa()
        {
            return 2.00;
        }
        public void compraTeNegroFresa()
        {
            Console.WriteLine("Ingrese la cantidad de dinero con la que pagara");
            pagar = int.Parse(Console.ReadLine()) - teNegroFresa();

            if (pagar < 0)
            {
                Console.WriteLine("Debe  $" + pagar + " para pagar su bebida");
            }
            if (pagar >= 0)
            {
                Console.WriteLine("Su saldo es de  $" + pagar);
            }
        }
        public double manzanilla()
        {
            return 1.50;
        }
        public void compraManzanilla()
        {
            Console.WriteLine("Ingrese la cantidad de dinero con la que pagara");
            pagar = int.Parse(Console.ReadLine()) - manzanilla();

            if (pagar < 0)
            {
                Console.WriteLine("Debe  $" + pagar + " para pagar su bebida");
            }
            if (pagar >= 0)
            {
                Console.WriteLine("Su saldo es de  $" + pagar);
            }
        }
        public double matchaLatte()
        {
            return 2.80;
        }
        public string preparacionMatchaLatte()
        {
            return "Preparacion: mezcla de chocolate y leche caliente";
        }
        public void compraMatchaLatte()
        {
            Console.WriteLine("Ingrese la cantidad de dinero con la que pagara");
            pagar = int.Parse(Console.ReadLine()) - matchaLatte();

            if (pagar < 0)
            {
                Console.WriteLine("Debe  $" + pagar + " para pagar su bebida");
            }
            if (pagar >= 0)
            {
                Console.WriteLine("Su saldo es de  $" + pagar);
            }
        }
        public double chocolateCaliente()
        {
            return 2.10;
        }
        public void compraChocolateCaliente()
        {
            Console.WriteLine("Ingrese la cantidad de dinero con la que pagara");
            pagar = int.Parse(Console.ReadLine()) - chocolateCaliente();

            if (pagar < 0)
            {
                Console.WriteLine("Debe  $" + pagar + " para pagar su bebida");
            }
            if (pagar >= 0)
            {
                Console.WriteLine("Su saldo es de  $" + pagar);
            }
        }
        public string preparacionChocolate()
        {
            return "Preparacion: mezcla de chocolate y agua caliente";
        }
        public double cafeNegro()
        {
            return 2.10;
        }
        public void compraCafeNegro()
        {
            Console.WriteLine("Ingrese la cantidad de dinero con la que pagara");
            pagar = int.Parse(Console.ReadLine()) - cafeNegro();

            if (pagar < 0)
            {
                Console.WriteLine("Debe  $" + pagar + " para pagar su bebida");
            }
            if (pagar >= 0)
            {
                Console.WriteLine("Su saldo es de  $" + pagar);
            }
        }
        public string preparacionCafe()
        {
            return "Preparacion: mezcla de cafe y agua caliente";
        }
        
        public string preparacionCapucccino()
        {
            return "Preparacion: mezcla de chocolate, leche y agua caliente";
        }
        public double capuccino()
        {
            return 3.50;
        }
        public void compraCapuccino()
        {
            Console.WriteLine("Ingrese la cantidad de dinero con la que pagara");
            pagar = int.Parse(Console.ReadLine()) - capuccino();

            if (pagar < 0)
            {
                Console.WriteLine("Debe  $" + pagar + " para pagar su bebida");
            }
            if (pagar >= 0)
            {
                Console.WriteLine("Su saldo es de  $" + pagar);
            }
        }

    }

}
