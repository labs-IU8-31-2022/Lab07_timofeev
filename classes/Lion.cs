namespace animal;
using attribute;

[My("Лев на охоте")]
public class Lion : Animal
{
    public Lion() {}
    public Lion(string country, bool hide, string name, eClassificationAnimal clas) : base(country, hide, name, clas) {}
    
    public override eFavoriteFood GetFavoriteFood() => eFavoriteFood.Meat;

    public override void SayHello() => Console.WriteLine("Рррррраргх");
}