using RepartidoClasesObj_PII.Ejercicio3;

namespace RepartidoClasesObj_PII.Ejercicio4;

public class Account
{
    private string number;
    private double balance;
    private Person owner;

    public string Number
    {
        get
        {
            return number;
        }
    }

    public double Balance
    {
        get { return Math.Round(balance, 2); }
        set { balance = Math.Max(value, 0); }
    }

    public Person Owner
    {
        get { return owner; }
        set { owner = value; }
    }

    public Account(string number, double balanceInicial, Person owner)
    {
        this.number = number;
        Balance = balanceInicial;
        this.owner = owner;
    }

    private bool AmountAvailable(double amount)
    {
        return balance >= amount;
    }

    public void AddToBalance(double amount)
    {
        Balance += amount;
    }

    public void RemoveFromBalance(double amount)
    {
        if (AmountAvailable(amount))
        {
            AddToBalance(-amount);
        }
    }

    public void TransferTo(Account account, double amount)
    {
        if (AmountAvailable(amount))
        {
            RemoveFromBalance(amount);
            account.AddToBalance(amount);
            
            Console.WriteLine($"Transferencia realizada: {this.Number} -> {account.Number} ($ {amount})");
        }
    }
}