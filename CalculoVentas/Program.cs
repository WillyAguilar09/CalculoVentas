using System;
class Ventas
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al sistema de Ventas el Ranchito");
        Console.WriteLine("Favor Ingrese su Nombre");
        string Nombre = Console.ReadLine();
        Console.WriteLine("Favor Ingrese Edad");
        int Edad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Seleccione la Categoria del Producto a comprar");
        Console.WriteLine("1. Carnes");
        Console.WriteLine("2. Refrescos");
        Console.WriteLine("3. Cereales");
        string categoria = Console.ReadLine();
        double precio =0;
        string producto;
        if (categoria == "1")
        {
            Console.WriteLine("Tenemos los siguientes Productos, escriba el numero deseado");
            Console.WriteLine("1. Tajo Premiun 110 Lps");
            Console.WriteLine("2. Carne para bistec 90 Lps");
            Console.WriteLine("3. Pollo deshuesado 60 Lps");
            producto = Console.ReadLine();
            
            if (producto == "1")
            {
                precio = 110;
            }
            else if (producto == "2")
            {
                precio = 90;
            }
            else if (producto == "3")
            {
                precio = 60;
            }
            else
            {
                Console.WriteLine("no tenemos el producto seleccionado");
            }
        }
        else if (categoria == "2")
        {
            Console.WriteLine("Tenemos los siguientes Productos, escriba el numero deseado");
            Console.WriteLine("1. Coca Cola 25Lps");
            Console.WriteLine("2. Fresca 23 Lps");
            Console.WriteLine("3. Canada Dry 28 Lps");
            producto = Console.ReadLine();
            if (producto == "1")
            {
                precio = 110;
            }
            else if (producto == "2")
            {
                precio = 90;
            }
            else if (producto == "3")
            {
                precio = 60;
            }
            else
            {
                Console.WriteLine("no tenemos el producto seleccionado");
            }
        }
        else if (categoria == "3")
        {
            Console.WriteLine("Tenemos los siguientes Productos, escriba el numero deseado");
            Console.WriteLine("1. Zucaritas 80 Lps");
            Console.WriteLine("2. Fruts Loops 95 Lps");
            Console.WriteLine("3. Choco Crispis 110 Lps");
        }
        else
        {
            Console.WriteLine("El numero de producto seleccionado no existe");
        }
         Console.WriteLine("El precio del producto es: " + precio);
    }
}
