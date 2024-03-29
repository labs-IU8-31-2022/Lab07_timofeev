﻿using attribute;

namespace animal;

public enum eClassificationAnimal
{
    Herbivores,
    Carnivores,
    Omnivores
}

public enum eFavoriteFood
{
    Meat,
    Plants,
    Everything
}

[My("abstract")]
public abstract class Animal
{
    public string Country;
    public bool HideFromOtherAnimals;
    public string Name;
    public eClassificationAnimal WhatAnimal;

    public Animal() {}
    public Animal(string country, bool hide, string name, eClassificationAnimal clas) =>
        (Country, HideFromOtherAnimals, Name, WhatAnimal) = (country, hide, name, clas);

    public void Deconstruct(out string country, out bool hide, out string name, out eClassificationAnimal clas)
    {
        country = Country;
        hide = HideFromOtherAnimals;
        name = Name;
        clas = WhatAnimal;
    }

    public eClassificationAnimal GetClassificationAnimal() => WhatAnimal;

    public abstract eFavoriteFood GetFavoriteFood();

    public abstract void SayHello();
}