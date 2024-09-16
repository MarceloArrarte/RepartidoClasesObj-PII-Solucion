using RepartidoClasesObj_PII.Ejercicio3;

namespace RepartidoClasesObj_PII.Ejercicio4;

public class Program
{
    public static void Main(string[] args)
    {
        Bank banco = new Bank();

        Person clienteRegistrado = new Person("Marcelo", "Hijo");
        banco.AddCustomer(clienteRegistrado);
        Account miCuenta = new Account("000233566", 23699.76, clienteRegistrado);
        banco.AddAccount(miCuenta);
        banco.AddAccount(miCuenta); // No se agrega porque ya existe una cuenta con el mismo número

        Person personaNoRegistrada = new Person("Juan", "Hijo");
        Account cuentaInvalida = new Account("100068455", 56980.35, personaNoRegistrada);
        banco.AddAccount(cuentaInvalida); // No se agrega porque el titular no es cliente del banco

        Account miOtraCuenta = new Account("000233547", 15992.12, clienteRegistrado);
        banco.AddAccount(miOtraCuenta);
        
        Console.WriteLine($"Saldo cuentas antes: $ {miCuenta.Balance} y $ {miOtraCuenta.Balance}");
        miCuenta.TransferTo(miOtraCuenta, 5000);
        Console.WriteLine($"Saldo cuentas: $ {miCuenta.Balance} y $ {miOtraCuenta.Balance}");
    }
}