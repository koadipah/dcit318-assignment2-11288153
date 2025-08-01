﻿using System;

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

class InheritanceDemo
{
    static void Main()
    {
        Animal a = new Animal();
        Dog d = new Dog();
        Cat c = new Cat();

        a.MakeSound();
        d.MakeSound();
        c.MakeSound();
    }
}
