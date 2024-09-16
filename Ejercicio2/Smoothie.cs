using System.Collections;

namespace RepartidoClasesObj_PII.Ejercicio2;

public class Smoothie
{
    private List<Ingredient> ingredients;

    private string name;

    public string Name
    {
        get
        {
            return name;
        }
    }

    private double basePrice;

    public double BasePrice
    {
        get
        {
            return basePrice;
        }
    }

    public Smoothie(string name, double basePrice)
    {
        ingredients = new List<Ingredient>();
        this.name = name;
        this.basePrice = basePrice;
    }

    private bool HasIngredient(string name)
    {
        foreach (Ingredient addedIngredient in ingredients)
        {
            if (addedIngredient.Name == name)
            {
                return true;
            }
        }
    
        return false;
    }

    public void AddIngredient(Ingredient ingredient)
    {
        if (!HasIngredient(ingredient.Name))
        {
            ingredients.Add(ingredient);
        }
    }

    public double GetTotalPrice()
    {
        double result = basePrice;
        foreach (Ingredient addedIngredient in ingredients)
        {
            result += addedIngredient.Price;
        }
    
        return result;
    }

    public string GetFullName()
    {
        string result = name;

        for (int i = 0; i < ingredients.Count; i++)
        {
            string ingredientName = ((Ingredient)ingredients[i]).Name.ToLower();
            if (i == 0)
            {
                result += " con ";
            }
            
            if (i > 0 && i < ingredients.Count - 1)
            {
                result += ", ";
            }

            if (i == ingredients.Count - 1)
            {
                result += " y ";
            }

            result += ingredientName;
        }

        return result;
    }
    
    
    // BONUS TRACK
    // Otra forma de implementar algunos de los métodos de manera más concisa.
    /*
    private bool HasIngredient(string name)
    {
        // Retorna true si existe algún ingrediente con el nombre name
        return ingredients.Any(ingredient => ingredient.Name == name);
    }

    public double GetTotalPrice()
    {
        // Retorna la suma de los Price de cada Ingredient en ingredients
        return basePrice + ingredients.Sum(ingredient => ingredient.Price);
    }
    */
}