Console.Write("Ingrese el número del algoritmo que desea ver: ");
int opcion = int.Parse(Console.ReadLine());
int ctnBodega, ctnMin, cantidad, totalCliente,opcion2,unidadesVender;
double total, totalVendido,descuento;
switch (opcion){
    case 1:
        Console.Write("Ingrese la cantidad en bodega: ");
        ctnBodega = int.Parse(Console.ReadLine());
        Console.Write("Ingrese la cantidad en minima requerida: ");
        ctnMin = int.Parse(Console.ReadLine());
        if(ctnBodega > ctnMin)
{
            Console.Write($"Cantidad en bodega: {ctnBodega}\nCantidad minima requerida: {ctnMin}.\nNo es necesario realizar el pedido");
        }
        if (ctnBodega < ctnMin)
        {
            Console.Write($"Cantidad en bodega: {ctnBodega}\nCantidad minima requerida: {ctnMin}.\nSi es necesario realizar el pedido");
        }
        break;
     case 2:
        Console.Write("Ingrese la cantidad en bodega: ");
        ctnBodega = int.Parse(Console.ReadLine());
        Console.Write("Ingrese la cantidad en minima requerida: ");
        ctnMin = int.Parse(Console.ReadLine());
        if (ctnBodega > ctnMin)
        {
            Console.Write($"Cantidad en bodega: {ctnBodega}\nCantidad minima requerida: {ctnMin}.\nNo es necesario realizar el pedido");
        }
        else
        {
            Console.Write($"Cantidad en bodega: {ctnBodega}\nCantidad minima requerida: {ctnMin}.\nSi es necesario realizar el pedido");
        }
        break;
    case 3:
        Console.Write("Ingrese la cantidad en bodega: ");
        ctnBodega = int.Parse(Console.ReadLine());
        Console.Write("Ingrese la cantidad en minima requerida: ");
        ctnMin = int.Parse(Console.ReadLine());
        unidadesVender = ctnBodega - ctnMin;
        if (ctnBodega > ctnMin && unidadesVender < 10)
        {
            Console.Write($"Cantidad en bodega: {ctnBodega}\nCantidad minima requerida: {ctnMin}\nNo es necesario realizar el pedido\nUnidades que faltan vender:{unidadesVender}\nAlerta Generada");
        }
        else if (ctnBodega > ctnMin)
        {
            Console.Write($"Cantidad en bodega: {ctnBodega}\nCantidad minima requerida: {ctnMin}\nNo es necesario realizar el pedido\nUnidades que faltan vender:{unidadesVender}");
        }
        else
        {
            Console.Write($"Cantidad en bodega: {ctnBodega}\nCantidad minima requerida: {ctnMin}\nSi es necesario realizar el pedido");
        }
        break;
    case 4:
        Console.Write("Ingrese la cantidad en bodega: ");
        ctnBodega = int.Parse(Console.ReadLine());
        Console.Write("Ingrese la cantidad en minima requerida: ");
        ctnMin = int.Parse(Console.ReadLine());

        if (ctnBodega > ctnMin)
        {
            unidadesVender = ctnBodega - ctnMin;
            if (unidadesVender < 10)
            {
                Console.Write($"Cantidad en bodega: {ctnBodega}\nCantidad minima requerida: {ctnMin}\nNo es necesario realizar pedido al provedor\nUnidades que hacen falta vender: {unidadesVender}\nAlerta Generada");
            }
            else
            {
                Console.Write($"Cantidad en bodega: {ctnBodega}\nCantidad minima requerida: {ctnMin}\nNo es necesario realizar pedido al provedor\nUnidades que hacen falta vender: {unidadesVender}");
            }
        }
        else
        {
            Console.WriteLine("Si es necesario realizar el pedido");
            Console.Write("Cantidad deseada a pedir: ");
            int cntPedir = int.Parse(Console.ReadLine());
            Console.Write("Valor de la compra: ");
            int valorUnitario = int.Parse(Console.ReadLine());
            Console.Write("Dinero en caja: ");
            int dineroCaja = int.Parse(Console.ReadLine());
            int valorCompra = cntPedir * valorUnitario;
            int resta = dineroCaja - valorCompra;
            if (resta < 0)
            {
                Console.Write($"Cantidades de compra deseada: {cntPedir}\n Valor de compra: {valorCompra} \nValor en caja: {dineroCaja}\nNo puede realizar el pedido, dinero insuficiente en caja");
            }
            else
            {
                Console.Write($"Cantidades de compra deseada: {cntPedir}\nSi es posible realizar el pedido.\nValor resultante en caja: {resta}");
            }
        }
        break;
    case 5:
        Console.Write("Ingrese el número de la semana (1-7): ");
        int dia = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el valor de la compra: ");
        double precio = double.Parse(Console.ReadLine());
        double descuentoDia;
        switch (dia)
        {
            case 1:
                descuentoDia = precio * 0.05;
                Console.Write($"El total a pagar es: {precio - descuentoDia }");
                break;
            case 2:
                descuentoDia = precio * 0.03;
                Console.Write($"El total a pagar es: {precio - descuentoDia }");
                break;
            case 3:
                descuentoDia = precio * 0.1;
                Console.Write($"El total a pagar es: {precio - descuentoDia }");
                break;
            case 4:
                descuentoDia = precio * 0.04;
                Console.Write($"El total a pagar es: {precio - descuentoDia }");
                break;
            case 5:
                descuentoDia = precio * 0.06;
                Console.Write($"El total a pagar es: {precio - descuentoDia }");
                break;
            case 6:
                descuentoDia = precio * 0.02;
                Console.Write($"El total a pagar es: {precio - descuentoDia }");
                break;
            case 7:
                descuentoDia = precio * 0.01;
                Console.Write($"El total a pagar es: {precio - descuentoDia }");
                break;
            default:
                Console.Write("Ingreso un número invalido");
                break;
        }
        break;
    case 6:
        Console.Write("Ingrese la cantidad de productos que va a comprar: ");
        cantidad = int.Parse(Console.ReadLine());
        totalCliente = 0;
        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write($"Cantidad del producto {i}: ");
            int cantidadProducto = int.Parse(Console.ReadLine());
            Console.Write($"Valor del producto {i}: ");
            int valorProducto = int.Parse(Console.ReadLine());
            int precioTotalProducto = cantidadProducto * valorProducto;
            totalCliente += precioTotalProducto;
        }
        Console.WriteLine($"El total que usted debe de pagar es: ${totalCliente}");
        break;
    case 7:
        int contador = 1;
        totalVendido= 0;    
        while(contador > 0)
        {
            Console.WriteLine($"Cliente {contador}");
            Console.Write("Ingrese la cantidad de productos que va a comprar: ");
            cantidad = int.Parse(Console.ReadLine());
            total = 0;
            for (int i = 1; i <= cantidad; i++)
            {
                Console.Write($"Cantidad del producto {i}: ");
                int cantidadProducto = int.Parse(Console.ReadLine());
                Console.Write($"Valor del producto {i}: ");
                int valorProducto = int.Parse(Console.ReadLine());
                int precioTotalProducto = cantidadProducto * valorProducto;
                total += precioTotalProducto;
                
            }
            if (total > 100000)
            {
                descuento = total * 0.1;
                total = total - descuento;
                Console.WriteLine("Por compras superiores a $100.000 tiene un descuento del 10%");
                Console.WriteLine($"El total que usted debe de pagar con descuento es: ${total}");
                totalVendido += total;
            }
            else
            {
                Console.WriteLine($"El total que usted debe de pagar es: ${total}");
                totalVendido += total;
            }
            Console.Write("Ingrese el 1 para atender otro usuario: ");
            opcion2 = int.Parse(Console.ReadLine());
            if (opcion2 == 1)
            {
                contador += 1;
            }
            else
            {
                contador = 0;
                Console.WriteLine($"Total Vendido: ${totalVendido}");
            }
        }
        break;
    default:
        Console.WriteLine("Ingreso un número inválido");
        break;
}