using animal;

class Lion : Animal
{
    public Lion(string country, bool hide, string name, eClassificationAnimal clas) : base(country, hide, name, clas) {}
    
    public override eFavoriteFood GetFavoriteFood() => eFavoriteFood.Meat;

    public override void SayHello() => Console.WriteLine("Рррррраргх");
}