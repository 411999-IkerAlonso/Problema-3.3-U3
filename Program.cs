//Banco.Dados el nombre, DNI, sexo, código y límite de crédito de un cliente y el número,
//tipo (1 - caja de ahorro, 2 - cuenta corriente) y saldo de una cuenta, desarrollar un programa
//que permita registrar las cuentas de los clientes de un banco de acuerdo al siguiente diagrama.
//Además, calcular la cantidad de cajas de ahorro y de cuentas corriente, saldo promedio para caja
//de ahorro, para cuenta corriente y general, porcentaje de clientes femeninos y el cliente con
//mayor límite de crédito.
//Cuenta tiene un cliente (Asociacion) y CLiente hereda de persona 
using Problema_3._3;
using System.Net;
List<Cuenta>cuentas = new List<Cuenta>();
int btnSalir=0;
int cajasDeAhorro = 0;  
int ctaCorriente = 0;
double saldoCorriente = 0;
double saldoAhorro = 0;
double prmCorriente = 0;
double prmAhorro = 0;
double saldoGeneral = 0;
double prmGeneral = 0;
int clientesF = 0;
double ultimoSaldo = 0;
string clienteMayorSaldo = string.Empty;
while (btnSalir!=1)
{
    Console.WriteLine("Ingrese el Dni del cliente");
    int dni = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el nombre del cliente");
    string nombre = Console.ReadLine();
    Console.WriteLine("Ingrese el Sexo del cliente (M o F)");
    string sexo = Console.ReadLine();
    if (sexo == "f" || sexo == "F")
    {
        clientesF++;
    }
    Console.WriteLine("Ingrese el codigo del cliente");
    int codigo = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el Limite de credito del cliente");
    double limite = double.Parse(Console.ReadLine());
    Cliente cliente = new Cliente(dni, nombre, sexo, codigo, limite);
    Console.WriteLine("Ingrese el Numero de cuenta");
    int numero = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el tipo de cuenta (1-caja de ahorro, 2-cuenta corriente)");
    int tipo = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el saldo de la cuenta");
    double saldo = double.Parse(Console.ReadLine());
    ultimoSaldo = saldo;
    Cuenta cuenta = new Cuenta(numero, tipo, saldo, cliente);
    cuentas.Add(cuenta);
    if (tipo == 1)
    {
        cajasDeAhorro++;
        saldoAhorro = saldo;
        prmAhorro += (saldoAhorro / cajasDeAhorro);
    }
    else if (tipo == 2)
    {
        ctaCorriente++;
        saldoCorriente = saldo;
        prmCorriente += (saldoCorriente/ctaCorriente);
    }
    if(saldo > ultimoSaldo || saldo > 0)
    {
        clienteMayorSaldo = cliente.ToString();
    }
    Console.WriteLine("Si desea salir Ingrese 1, caso contrario ingrese 0");
    btnSalir = int.Parse(Console.ReadLine());
    saldoGeneral += saldo;
}
//Cliente cl1 = new Cliente(12345, "Iker", "M", 65, 120000);
//Cuenta c1 = new Cuenta(1, 1, 10000, cl1);
//Console.WriteLine(c1.ToString());
prmGeneral = saldoGeneral / cuentas.Count;
int porcClientesF = (clientesF/cuentas.Count)*100;
Console.WriteLine($"Cantidad de Cajas de Ahorro: {cajasDeAhorro} ");
Console.WriteLine($"Cantidad de Cuentas Corrientes: {ctaCorriente}");
Console.WriteLine($"Saldo Promedio Cajas de Ahorro: {prmAhorro}");
Console.WriteLine($"Saldo Promedio Cuentas Corrientes: {prmCorriente}");
Console.WriteLine($"Saldo Promedio General: {prmGeneral}");
Console.WriteLine($"Porcentaje de Clientes Femeninos: {porcClientesF}%");
Console.WriteLine($"Cliente con mayor saldo: {clienteMayorSaldo}");