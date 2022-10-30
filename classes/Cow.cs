namespace animal;
using attribute;

[My("Корова пасётся на поле")]
public class Cow : Animal
{
    public Cow() {}
    public Cow(string country, bool hide, string name, eClassificationAnimal clas) : base(country, hide, name, clas) {}
    
    public override eFavoriteFood GetFavoriteFood() => eFavoriteFood.Plants;

    public override void SayHello() => Console.WriteLine("Муууу");
}