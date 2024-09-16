using System.Collections;
using RepartidoClasesObj_PII.Ejercicio3;

namespace RepartidoClasesObj_PII.Ejercicio4;

public class Bank
{
    private ArrayList customers;
    private ArrayList accounts;

    public Bank()
    {
        customers = new ArrayList();
        accounts = new ArrayList();
    }

    public void AddCustomer(Person p)
    {
        customers.Add(p);
    }

    public void AddAccount(Account acc)
    {
        foreach (Account existingAccount in accounts)
        {
            if (acc.Number == existingAccount.Number)
            {
                Console.WriteLine($"Ya existe la cuenta nro. {acc.Number}");
                return;
            }
        }

        bool clienteRegistrado = false;
        foreach (Person customer in customers)
        {
            if (acc.Owner.GetName() == customer.GetName())
            {
                clienteRegistrado = true;
            }
        }

        if (!clienteRegistrado)
        {
            Console.WriteLine($"El dueño de la cuenta {acc.Owner.GetName()} no está registrado en el banco.");
            return;
        }

        accounts.Add(acc);
    }
}