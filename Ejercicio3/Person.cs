namespace RepartidoClasesObj_PII.Ejercicio3;

public class Person
{
    private string name;
    private string role;
    private Person firstProgenitor;
    private Person secondProgenitor;

    public Person(string name, string role)
    {
        this.name = name;
        this.role = role;
    }

    public Person(string name, string role, Person firstP, Person secondP) : this(name, role)
    {
        this.firstProgenitor = firstP;
        this.secondProgenitor = secondP;
    }

    public string GetName()
    {
        return name;
    }

    public void ShowFamilyTree()
    {
        Person[] family = 
        [
            this,
            firstProgenitor,
            secondProgenitor,
            firstProgenitor.firstProgenitor,
            firstProgenitor.secondProgenitor,
            secondProgenitor.firstProgenitor,
            secondProgenitor.secondProgenitor
        ];

        foreach (Person p in family)
        {
            Console.Write($"{p.name} es {p.role.ToLower()}. ");
        }
        
        Console.WriteLine();
    }
}