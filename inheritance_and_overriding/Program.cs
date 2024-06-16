// See https://aka.ms/new-console-template for more information

using System.Collections;

namespace inheritance_and_overriding
{


    internal class Program
    {
        static void Main(string[] args)
        {


            Animal myAnimal = new Animal();
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            myAnimal.MakeSound(); 
            myDog.MakeSound();    
            myCat.MakeSound();    

        }
        

    }
}