
Dice d6 = new Dice("Plastic Classsical Dice",6);
//d6.Sides = 6;
//d6.Type = "Plastic Classsical Dice";
var d8 = new Dice("Wooden Fast Dice", 8);
//d8.Sides = 8;
//d8.Type = "Wooden Fast Dice";
Console.WriteLine($"d6 is {d6.Type} with {d6.Sides} sides.");
Console.WriteLine($"d8 is {d8.Type} with {d8.Sides} sides.");


class Dice
{
    int sides;   //field
    //string type; //field

    public int Sides //property
    {
        get { return sides; }   //getter (get value)
        set { sides = value; }  //setter (assign value)
    }
    public string Type { get; set; }

    public Dice(string type,int sides)
    {
        this.Type = type;
        this.Sides = sides;
    }
}