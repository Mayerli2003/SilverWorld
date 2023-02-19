using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica3SilverWorld
{
    abstract class Persona
    {
        public abstract void Nombres();

    }
    class PersonaDatos
    {
        private string nombre;

        private string apellido;

        private int edad;

        //private int dui;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        //public int DUI { get => DUI; set => DUI = value; }



        public void DatosUsuario(string _nombre, string _apellido, int _edad/*, int _dui*/)
        {
            this.Nombre = _nombre;
            this.Apellido = _apellido;
            this.Edad = _edad;
            //this.DUI= _dui; 

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-----Ingrese  Sus Datos----- \n");
            Console.WriteLine("Ingrese su Nombre:");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su Apellido:");
            Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese su edad:");
            Edad = int.Parse(Console.ReadLine());
            
        }
        
        public string Mostrar()
        {
            Console.WriteLine("-------------------------------------");
            return " \n Nombre: " + Nombre + " \n Apellido: " + Apellido + "\n Edad: " + Edad /*+ "\n DUI: " + DUI*/;




        }


    }
    class Cliente : Persona
    {
        PersonaDatos datos = new PersonaDatos();
        public void Datos()
        {
            Console.WriteLine(datos.Mostrar());

        }

        public override void Nombres()
        {
           
        
            string[] nombreCliente = new string[4];
            nombreCliente[0] = "Marcos Castilllo";
            nombreCliente[1] = "Azucena Montalvo";
            nombreCliente[2] = "Damaris Lopez";
            nombreCliente[3] = "Dora Martínez";


            Console.WriteLine("Lista de clientes:\n" +
                "\n1-" + nombreCliente[0]
                + "\n ------------------------------------------------------- " +
                "\n2-" + nombreCliente[1]
                + "\n ------------------------------------------------------- " +
                "\n3-" + nombreCliente[2]
                + "\n ------------------------------------------------------- " +
                "\n4-" + nombreCliente[3]
                + "\n ------------------------------------------------------- ");
        
        }
    }
    class Empleado : Persona
    {
        //alcoholicas alcoholicas = new alcoholicas();
        PersonaDatos datos = new PersonaDatos();
        private int codigo1 = 5678;
        private int codigo2 = 2345;
        int codigoGeneral;
        int hora = 0;
        double sueldo = 0;
        double respuesta;



        public int Codigo1 { get => codigo1; set => codigo1 = value; }
        public int Codigo2 { get => codigo2; set => codigo2 = value; }
   



        //public void descuento(int _codigo1, int _codigo2)
        //{
        //    this.Codigo1 = _codigo1;
        //    this.Codigo2 = _codigo2;


        //    Console.WriteLine("-------------------------------------");
        //    Console.WriteLine("-----Ingrese  su codigo----- \n");

        //    codigoGeneral = int.Parse( Console.ReadLine());
        //    if (codigoGeneral == codigo1)
        //    {
        //        respuesta = alcoholicas.Margarita()*0.20;
        //        Console.WriteLine("Precio con el 20% de descuento es de $"+ respuesta);

        //    }
        //    if(codigoGeneral == codigo2)
        //    {
        //        respuesta = alcoholicas.Margarita() * 0.50;
        //        Console.WriteLine("Precio con el 50% de descuento es de $" + respuesta);
        //    }
        //    else
        //    {
        //        Console.WriteLine("El codigo no es correcto o no cuenta con descuento");
        //        Console.WriteLine("Precio sin  descuento es de $" + alcoholicas.Margarita());

        //    }

        //}
        public void Datos()
        {
            Console.WriteLine(datos.Mostrar());

        }

        public override void Nombres()
        {
            string[] nombreEmpleado = new string[10];
            nombreEmpleado[0] = "Matias Castilllo";
            nombreEmpleado[1] = "Rigoberto Montalvo";
            nombreEmpleado[2] = "Maria Monterrosa";
            nombreEmpleado[3] = "Judith Martínez";
            nombreEmpleado[4] = "Marta Caballero";
            nombreEmpleado[5] = "Ricardo Guardado";
            nombreEmpleado[6] = "Marbely Martínez";
            nombreEmpleado[7] = "Roberto Fuentes";
            nombreEmpleado[8] = "Margarita Madrid";
            nombreEmpleado[9] = "Dania Herrera";

            Console.WriteLine("Lista de empleados con descuento:\n" +
                "\n1-" + nombreEmpleado[0] +
                "\n -Tipo de codigo: " + Codigo1 +
                 "\n ------------------------------------------------------- " +
                "\n2-" + nombreEmpleado[1] +
                "\n -Tipo de codigo " + Codigo2 +
                 "\n ------------------------------------------------------- " +
                "\n3-" + nombreEmpleado[2] +
                "\n -Tipo de Contrato: " + Codigo1
                + "\n ------------------------------------------------------- " +
                "\n4-" + nombreEmpleado[3] +
                "\n -Tipo de Contrato: " + Codigo2
                + "\n ------------------------------------------------------- " +
                "\n5-" + nombreEmpleado[4] +
                "\n -Tipo de Contrato: " + Codigo1
                + "\n ------------------------------------------------------- " +
                "\n6-" + nombreEmpleado[5] +
                "\n -Tipo de Contrato: " + Codigo2
                + "\n ------------------------------------------------------- " +
                "\n7-" + nombreEmpleado[6] +
                "\n -Tipo de Contrato: " + Codigo1
                + "\n ------------------------------------------------------- " +
                "\n8-" + nombreEmpleado[7] +
                "\n -Tipo de Contrato: " + Codigo2
                + "\n ------------------------------------------------------- " +
                "\n9-" + nombreEmpleado[8] +
                "\n -Tipo de Contrato: " + Codigo1
                + "\n ------------------------------------------------------- " +
                "\n10-" + nombreEmpleado[9] +
                "\n -Tipo de Contrato: " + Codigo2
                + "\n ------------------------------------------------------- ");
            Console.ReadLine();
        }
        public void Sueldo()
        {
            Console.WriteLine("_______________Calcular sueldo por horas_______________\n");
            Console.WriteLine("----------Por cada hora de trabajo se obtine $5.00----------\n");
            Console.WriteLine("- Ingrese el total de horas trabajadas:\n");
            hora = int.Parse(Console.ReadLine());
            sueldo = hora * 5 + 10;
            Console.WriteLine("- Este es el sueldo segun las horas ingresadas mas los bonos $" + sueldo);
        }

    }
}
