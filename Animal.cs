using System;

class Animal
{
    // Base class method
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

class Dog : Animal
{
    // Overriding the base class method
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

class Cat : Animal
{
    // Overriding the base class method
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of Animal, Dog, and Cat
        Animal genericAnimal = new Animal();
        Dog dog = new Dog();
        Cat cat = new Cat();

        // Calling the MakeSound() method on each instance
        genericAnimal.MakeSound(); // Output: Some generic sound
        dog.MakeSound();           // Output: Bark
        cat.MakeSound();           // Output: Meow
    }
}
