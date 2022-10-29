namespace animal;
using attribute;

[My("Лев на охоте")]
class Lion : Animal
{
    public Lion(string country, bool hide, string name, eClassificationAnimal clas) : base(country, hide, name, clas) {}
    
    public override eFavoriteFood GetFavoriteFood() => eFavoriteFood.Meat;

    public override void SayHello() => Console.WriteLine("Рррррраргх");
}