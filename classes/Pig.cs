using animal;

class Pig : Animal
{
    public Pig(string country, bool hide, string name, eClassificationAnimal clas) : base(country, hide, name, clas) {}
    
    public override eFavoriteFood GetFavoriteFood() => eFavoriteFood.Everything;

    public override void SayHello() => Console.WriteLine("Хрю-хрю");
}