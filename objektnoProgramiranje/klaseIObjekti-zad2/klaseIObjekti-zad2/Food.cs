using System;

public class Food
{
    private FoodType type;
    private int weight;

    public Food(FoodType type, int weight)
    {
        this.type = type;
        this.weight = weight;
    }

    public int Weight => weight;

    public double Protein => type.Protein * weight / 100.0;

    public double Carbs => type.Carbs * weight / 100.0;

    private double Fat => type.Fat * weight / 100.0;

    public override string ToString()
    {
        string str = type.Name + ": \np - " + Math.Round(Protein, 1) + "\nc - " + Math.Round(Carbs, 1) + "\nf - " + Math.Round(Fat, 1);
        return str;
    }
    public string ToStringInGrams()
    {
        string str = "\nFood: " + "\n" + type.Name + ": \np - " + Math.Round(Protein) + "\nc - " + Math.Round(Carbs, 1) + "\nf - " + Math.Round(Fat, 1) + "\ng - " + this.weight;
        return str;
    }



}
