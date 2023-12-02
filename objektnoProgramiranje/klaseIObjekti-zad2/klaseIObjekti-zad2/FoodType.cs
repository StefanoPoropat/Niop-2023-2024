public class FoodType
{
    string name;
    int protein;
    int carbs;
    int fat;
    private static int counter = 0;

    public string Name { get => name; set => name = value; }
    public int Protein { get => protein; set => protein = value; }
    public int Carbs { get => carbs; set => carbs = value; }
    public int Fat { get => fat; set => fat = value; }

    public FoodType(string name, int protein, int carbs, int fat)
    {
        this.Name = name;
        this.Protein = protein;
        this.Carbs = carbs;
        this.Fat = fat;
        counter++;
    }

    public static int GetNumberOfCreatedInstances()
    {
        return counter;
    }

    public override string ToString()
    {
        string str = "" + this.Name + ": p - " + this.Protein + "%, c - " + this.Carbs + "%, f - " + this.Fat + "%";
        return str;
    }

}
