// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

public class EjemplosEnClases
{
    public static void Main()
    {
        //CuentaVocales();
        //OperacionMatematica();}
        //MayorDeDosNumeros();
        //DiaDeLaSemana();
        //TablaDeMultiplicar();
        //EjemploArreglo();
        //CambioDeDivisa();
        //MultiploDeCinco();
        //NumeroPrimo();
        //EdadCategoria();
        //VentasDiarias();
        //EscribeTablaMultiplicar();
        //Par_Impar();
        Console.ReadLine();
    }

    static void CuentaVocales()
    {
        String PalabraLarga = "AJEKJIGOJJU";
        Char[] Vocales = { 'A', 'E', 'I', 'O', 'U' };
        int ContadorDeVocales = 0;

        for (int i = 0; i < PalabraLarga.Length; i++)
        {
            for (int e = 0; e < Vocales.Length; e++)
            {
                if (PalabraLarga[i] == Vocales[e])
                {
                    ContadorDeVocales += 1;
                }
            }

        }
        Console.WriteLine();
        Console.WriteLine("El texto tiene : " + ContadorDeVocales + " Vocales");

    }
    static void OperacionMatematica()
    {
        //El usuario debe ingresar dos números y el programa mostrará el resultado de la operación (a+b)*(a-b)
        try
        {
            int Num1, Num2;
            double Result;
            string? Linea = String.Empty;

            Console.WriteLine("Ingrese N1 : ");
            Linea = Console.ReadLine();
            Num1 = Convert.ToInt32(Linea);
            Console.WriteLine("Ingrese N2 : ");
            Linea = Console.ReadLine();
            Num2 = Convert.ToInt32(Linea);
            Result = Convert.ToDouble((Num1 + Num2) * (Num1 - Num2));
            Console.WriteLine();
            Console.WriteLine("El resultado es : " + Result);
        }
        catch (Exception)
        {

            throw;
        }


    }
    static void MayorDeDosNumeros()
    {
        try
        {
            int Num1, Num2;
            string? Linea = String.Empty;

            Console.WriteLine("Ingrese N°1 : ");
            Linea = Console.ReadLine();
            Num1 = Convert.ToInt32(Linea);
            Console.WriteLine("Ingrese N°2 : ");
            Linea = Console.ReadLine();
            Num2 = Convert.ToInt32(Linea);
            if (Num1 > Num2)
            {
                Console.WriteLine("El Numero mayor es : {0}", Num1);
            }
            else if (Num1 == Num2)
            {
                Console.WriteLine("El primer numero {0} es igual al segundo numero {1}", Num1, Num2);
            }
            else
            {
                Console.WriteLine("El Numero mayor es : {0}", Num2);
            }
            Console.WriteLine();
            Console.WriteLine("Si quieres jugar de nuevo digita 1, salir otra tecla...");
            Linea = Console.ReadLine();
            if (Convert.ToInt32(Linea) == 1)
            {
                MayorDeDosNumeros();
            }

        }
        catch (Exception)
        {

            throw;
        }


    }
    static void DiaDeLaSemana()
    {
        int Num1;
        String? Linea;
        Console.WriteLine("Dias de la Semana");
        Console.WriteLine("==================");
        Console.WriteLine();
        Console.WriteLine("Ingrese un Numero del 1 al 7");
        Linea = Console.ReadLine();
        Num1 = Convert.ToInt32(Linea);

        switch (Num1)
        {
            case 1:
                Console.WriteLine("El Numero ingresado {0}, corresponde al dia Domingo", Num1);
                break;

            case 2:
                Console.WriteLine("El Numero ingresado {0}, corresponde al dia Lunes", Num1);
                break;

            case 3:
                Console.WriteLine("El Numero ingresado {0}, corresponde al dia Martes", Num1);
                break;

            case 4:
                Console.WriteLine("El Numero ingresado {0}, corresponde al dia Miercoles", Num1);
                break;

            case 5:
                Console.WriteLine("El Numero ingresado {0}, corresponde al dia Jueves", Num1);
                break;

            case 6:
                Console.WriteLine("El Numero ingresado {0}, corresponde al dia Viernes", Num1);
                break;

            case 7:
                Console.WriteLine("El Numero ingresado {0}, corresponde al dia Sabado", Num1);
                break;

        }

        Console.WriteLine("Si quieres ingresar otro numero presiona 1 o cualquier otra tecla para salir...");
        Num1 = Convert.ToInt32(Console.ReadLine());

        if (Num1 == 1)
        {
            DiaDeLaSemana();
        }
    }
    static void TablaDeMultiplicar()
    {
        try
        {
            byte Num1, I;
            int Result;
            String? Linea;
            Console.WriteLine("Tablas de Multiplicar");
            Console.WriteLine("=====================");
            Console.WriteLine();
            Console.WriteLine("Escriba un numero para la tabla : ");
            Linea = Console.ReadLine();

            Num1 = Convert.ToByte(Linea);
            Console.WriteLine();
            for (I = 1; I < 11; I++)
            {
                Result = Num1 * I;
                Console.WriteLine("{0} * {1} = {2}", Num1, I, Result);
            }
            Console.WriteLine();
            Console.WriteLine("Si quieres otro Numero ingresa 1 o salgo co otra tecla...");
            Linea = Console.ReadLine();
            if (Convert.ToInt32(Linea) == 1)
            {
                TablaDeMultiplicar();
            }


        }
        catch (Exception)
        {

            throw;
        }



    }
    static void EjemploArreglo()
    {
        string[] Arreglo = { "Lorena", "Juan", "Javier", "David" };

        Console.WriteLine("Las Personas en el Arreglo son : ");
        foreach (var item in Arreglo)
        {
            Console.WriteLine(item);
        }
    }
    static void CambioDeDivisa()
    {
        String? Linea, Divisa;
        double NumDivisa, Pesos, Result;
        Int32 TipoCambioSel, TipoCambio1, TipoCambio2, TipoCambio3, TipoCambio4;
        TipoCambio1 = 990; //leo desde otro sistema
        TipoCambio2 = 650; //leo desde otro sistema
        TipoCambio3 = 250; //leo desde otro sistema
        TipoCambio4 = 820; //leo desde otro sistema

        Console.WriteLine("Sistema de Cambio de Divisas");
        Console.WriteLine("============================");
        Console.WriteLine();
        Console.WriteLine("Divisas Disponibles : (1) Dollar; (2) Rublo; (3) Bolivar; (4) Yen ");
        Console.WriteLine("Tipo de cambio      :     {0}CLP;    {1}CLP;      {2}CLP;  {3}CLP ",TipoCambio1, TipoCambio2, TipoCambio3, TipoCambio4);
        Console.WriteLine("==================================================================");
        Console.WriteLine("Seleccione un numero de Divisa");
        Linea = Console.ReadLine();
        NumDivisa = Convert.ToInt32(Linea);


        if (NumDivisa == 1)
        {
            Divisa = "Dolares";
            TipoCambioSel = TipoCambio1;
            Console.WriteLine("El tipo de cambio seleccionado es Dollar, cotizado a 990CLP");
        }
        else if (NumDivisa == 2)
        {
            Divisa = "Rublos";
            TipoCambioSel = TipoCambio2;
            Console.WriteLine("El tipo de cambio seleccionado es Rublo, cotizado a 650CLP");
        }
        else if (NumDivisa == 3)
        {
            Divisa = "Bolivares";
            TipoCambioSel = TipoCambio3;
            Console.WriteLine("El tipo de cambio seleccionado es Bolivar, cotizado a 250CLP");
        }
        else if (NumDivisa == 4)
        {
            Divisa = "Yenes";
            TipoCambioSel = TipoCambio4;
            Console.WriteLine("El tipo de cambio seleccionado es Yen, cotizado a 820CLP");
        }
        else
        {
            Divisa = "x";
            TipoCambioSel = 0;
            Console.WriteLine("El numero de seleccion ingresado no es valido, seleccione una moneda del 1 al 4");
        }

        if (Divisa != "x")
        {
            Console.WriteLine();
            Console.WriteLine("Ingrese la cant. de pesos chilenos para el cambio de divisa ");
            Linea = Console.ReadLine();
            Pesos = Convert.ToInt32(Linea);
            Result = (CalculoDivisa(TipoCambioSel, Pesos));
            Console.WriteLine("La cantidad de " + Pesos + "CLP, corresponden a {0} {1}", Result, Divisa);
            Console.WriteLine();
            Console.WriteLine("Para otra operacion digite 1 : ");
            Linea = Console.ReadLine();
            if (Convert.ToInt32(Linea) == 1)
            {
                CambioDeDivisa();
            }

            static double CalculoDivisa(Int32 Tipo, double Pesos)
            {
                //evaluar el numero de divisa para el tipo de cambio
                return (Pesos / Tipo);
            }

        }

    }
    static void MultiploDeCinco()
    {
        String? Linea = String.Empty;
        double Num1;
        Console.WriteLine("Multiplo de 5");
        Console.WriteLine("==============");
        Console.WriteLine();
        Console.WriteLine("Ingrese un numero para evaluar : ");
        Linea = Console.ReadLine();
        Num1 = Convert.ToDouble(Linea);
        if (Num1 > 0 && Num1 % 5 == 0)

        {
            Console.WriteLine("El numero Ingresado {0} es multiplo de 5 ", Num1);
        }
        else
        {
            Console.WriteLine("El numero Ingresado {0} no es multiplo de 5 ", Num1);
        }

        Console.WriteLine();
        Console.WriteLine("Para probar otro numero ingrese 1 o cualquier otra tecla para salir ");
        Linea = Console.ReadLine();
        if (Convert.ToInt32(Linea) == 1)
        {
            MultiploDeCinco();
        }

    }
    static void NumeroPrimo()
    {
        //Diseñe un método que al ingresar un numero permita identificar si el numero es primo o no es primo
        //( sabiendo que los números primos solo son divisibles por la unidad y el valor del numero)
        String? Linea = String.Empty;
        Int32 Num1;
        Console.WriteLine("Numero primo");
        Console.WriteLine("============");
        Console.WriteLine();
        Console.WriteLine("Ingrese un numero para evaluar : ");
        Linea = Console.ReadLine();
        Num1 = Convert.ToInt32(Linea);
        Console.WriteLine();
        if (EsPrimo(Num1))
        {
            Console.WriteLine("El Numero {0}, es primo", Num1);
        }
        else
        {
            Console.WriteLine("El Numero {0}, no es primo", Num1);
        }

        static bool EsPrimo(int Num1)
        {
            for (int i = 2; i < Num1; i++)
            {
                if ((Num1 % i) == 0)
                {
                    //No es Primo
                    return false;
                }
            }
            return true;
        }
        Console.WriteLine("Para evaluar otro Numero ingrese 1 ");
        Linea = Console.ReadLine();

        if (Convert.ToInt32(Linea) == 1)
        {
            NumeroPrimo();
        }
    }
    static void EdadCategoria()
    {
        // Diseñe un método que identifique la edad ingresada, si ingresa el valor 0 muestre un mensaje de ERROR, 
        //  seguido distinguir la edad ingresad ,
        //  si es menor de 18 , indicar que es menor de edad,
        //  si ingresa mayor a 18 y menor a 60, indicar que es una persona mayor de edad,
        //  y por ultimo si es mayor de 60 , indicar que es una persona adulto mayor

        String? Linea = String.Empty;
        Int32 Edad, Categoria;
        Console.WriteLine("Categoria por edad");
        Console.WriteLine("==================");
        Console.WriteLine();
        Console.WriteLine("Ingrese una edad (num)");
        Linea = Console.ReadLine();
        Edad = Convert.ToInt32(Linea);

        Categoria = SelecCategoria(Edad);

        if (Categoria > 0)
        {
            switch (Categoria)
            {
                case 1:
                    Console.WriteLine("La edad {0}, indica que la persona es menor de edad", Edad);
                    break;
                case 2:
                    Console.WriteLine("La edad {0}, indica que la persona es mayor de edad", Edad);
                    break;
                case 3:
                    Console.WriteLine("La edad {0}, indica que la persona es adulto mayor", Edad);
                    break;
            }
        }
        else
        {
            Console.WriteLine("Undefined...??");
        }
        Console.WriteLine();
        Console.WriteLine("Para evaluar otra edad digite 1");
        String? Linea1 = Console.ReadLine();
        if (Convert.ToInt32(Linea1)==1)
        {
            EdadCategoria();
        }

        static Int32 SelecCategoria(Int32 Edad)
        {
            if (Edad < 18)
            {
                return 1;
            }
            else if (Edad >= 18 && Edad <= 60)
            {
                return 2;
            }
            else if (Edad > 60)
            {
                return 3;
            }
            else
                return 0;
        }

    }
    static void VentasDiarias()
    {
        //Calcular el monto total de ventas del día de una tienda, 
        //se desea saber la cantidad de clientes
        //y el monto comprado por cada cliente
        string[,] ArrayVentas = new string[10, 4]
        {
            { "Lunes", "Clie1", "Tomates", "2500" },
            { "Lunes", "Clie2", "Pepinos", "3200" },
            { "Lunes", "Clie3", "Aji", "500" },
            { "Lunes", "Clie1", "Lechuga", "1000" },
            { "Lunes", "Clie1", "Acelga", "2000" },
            { "Lunes", "Clie2", "Cilantro", "1500" },
            { "Lunes", "Clie3", "Rabanos", "1200" },
            { "Lunes", "Clie4", "Apio", "3500" },
            { "Lunes", "Clie4", "Manzana", "3600" },
            { "Lunes", "Clie5", "Sandia", "5000" },
        
        };
        //Lista de clientes
        List<string> listClie = new List<string>();
        listClie.Add("Clie1");
        listClie.Add("Clie2");
        listClie.Add("Clie3");
        listClie.Add("Clie4");
        listClie.Add("Clie5");
        //La cantidad de clientes
        //Supuesto : Los clientes se repiten durante el dia
        //Se recorrera la lista de clientes y se buscaran sus compras en el arreglo de ventas
        String IdCliente = String.Empty;
        Double MontoCompra=0;
        double Total, TotalTotal;
        int CuentaVentas,CuentaCompras;
        Total = 0;
        CuentaVentas = 0;
        CuentaCompras =0;
        Console.WriteLine("Monto de ventas por cliente");
        Console.WriteLine("==========================");
        Console.WriteLine("Las ventas del dia estan en un arreglo[10,4] y los clientes en una lista");
        Console.WriteLine();
        //Reviso por cada cliente
        foreach (var item in listClie)
        {
            for (int i = 0; i < (ArrayVentas.Length/4); i++)
            {
                if (item == ArrayVentas[i,1])
                {
                    //Acumular cliente
                    //Acumular venta por cliente
                    IdCliente=ArrayVentas[i,1];
                    MontoCompra = MontoCompra + Convert.ToUInt64( ArrayVentas[i, 3]);
                    Total = Total + Convert.ToUInt64(ArrayVentas[i, 3]);
                    CuentaVentas += 1;
                    CuentaCompras += 1;      
                }
            }
            Console.WriteLine("El cliente {0}, compro un total de {1} Pesos, en {2} compra(s)", IdCliente, MontoCompra,CuentaCompras);
            MontoCompra = 0;
            CuentaCompras = 0;
        }
        Console.WriteLine("La venta diaria fue de {0} Pesos", Total);
        Console.WriteLine("La cantidad de clientes del listado es {0}",listClie.Count);
        Console.WriteLine("La cantidad de ventas del dia es {0} " , CuentaVentas);

    }
    static void EscribeTablaMultiplicar()
    {
        {
            try
            {
                byte Num1, I;
                int Result;
                String? Linea;
                Console.WriteLine("Tablas de Multiplicar");
                Console.WriteLine("=====================");
                Console.WriteLine();
                Console.WriteLine("Escriba un numero para la tabla de multiplicar hasta el 108: ");
                Linea = Console.ReadLine();

                Num1 = Convert.ToByte(Linea);
                Console.WriteLine();
                for (I = 1; I < 109; I++)
                {
                    Result = Num1 * I;
                    Console.WriteLine("{0} * {1} = {2}", Num1, I, Result);
                }
                Console.WriteLine();
                Console.WriteLine("Si quieres otro Numero ingresa 1 o salga con otra tecla...");
                Linea = Console.ReadLine();
                if (Convert.ToInt32(Linea) == 1)
                {
                    EscribeTablaMultiplicar();
                }


            }
            catch (Exception)
            {

                throw;
            }



        }
    }
    static void Par_Impar()
    {
        String? Linea = String.Empty;
        double Num1;
        Console.WriteLine("PAR o IMPAR");
        Console.WriteLine("===========");
        Console.WriteLine();
        Console.WriteLine("Ingrese un numero para evaluar si es par o impar: ");
        Linea = Console.ReadLine();
        Num1 = Convert.ToDouble(Linea);
        if (Num1 > 0 && Num1 % 2 == 0)

        {
            Console.WriteLine("El numero Ingresado {0} es Par ", Num1);
        }
        else
        {
            Console.WriteLine("El numero Ingresado {0} no es Impar ", Num1);
        }

        Console.WriteLine();
        Console.WriteLine("Para probar otro numero ingrese 1 o cualquier otra tecla para salir ");
        Linea = Console.ReadLine();
        if (Convert.ToInt32(Linea) == 1)
        {
            Par_Impar();
        }
    }

}





