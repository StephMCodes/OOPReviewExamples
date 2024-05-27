using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Object_Oriented_Programming_in_VS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            //                                             | OBJECT ORIENTED PROGRAMMING |

            //                                                          WHY?
            //--------------------------------------------------------------------------------------------------------------------------------

            //Its simple and powerful nature has made it very popular in the industry, and it is quite useful in gaming contexts.
            //Your code can be done and edited faster, you can reuse more.

            //                                                       DICTIONARY
            //--------------------------------------------------------------------------------------------------------------------------------

            //FIELDS: a variable declared within a class (naming convention: pascalCase)

            //METHODS: a function defined within a class (naming convention: CamelCase)

            //CLASSES: the blueprint for objects, and can contain fields and methods. Generally starts with a capital

            //ACCESS MODIFIERS: keywords that set the visibility and access level for fields, properties, classes and methods

            //      PUBLIC: all classes can access code

            //      PRIVATE: only within the same class can you access the code

            //      PROTECTED: accessible only within own class or child class

            //      INTERNAL: code is accessed only from within assembly

            //VIRTUAL: keyword allowing method to be overriden (does not work with static, abstract, private, or override keywords)

            //STATIC: keyword meaning the member belongs to the type and not the specific object (shared within objects of class)



            //                                                THE THREE PILLARS (A PIE)
            //--------------------------------------------------------------------------------------------------------------------------------

            //ABSTRACTION:
            //Used for security, so that only certain things get shown to the user
            //Abstract classes cannot be used on their own (ex: car), but through inheritance (ford : car)
            //Abstract methods do not have a body and must be overriden by each polymorphed class
            //You cannot just create a car object, but a kind of car with polymorphism, such as a ford or subaru, keeping consistency

            Console.WriteLine("Abstract Examples:");
            ford fordF150 = new ford(); //Creation of ford object
            fordF150.AnnounceCar(); //Use of overridden method
            fordF150.Honk(); //Use of car method

            //INTERFACES : ABSTRACTION
            //Interfaces are classes where everything inside is considered both abstract and public
            //The advantage is that since C# does not support multiple inheritance, you can achieve it indirectly with interfaces
            //The convention is to start the interface title with the letter I to avoid confusion
            //Interfaces cannot contain a constructor, fields or variables

            Seaplane seaplane = new Seaplane(); //Creation of seaplane object taking from IPlane interface
            seaplane.AnnouncePlane(); //Use of overridden method
            seaplane.Fly(); //Use of overridden method

            //                                                          ---


            //POLYMORPHISM:
            //Used to inherit fields and methods. That way, classes can have methods that act the same or that are overriden
            //This all starts with the base class (parent)
            //Example: the Slime and Dragon of the Monster base class both have an attack method, but it does not look the same (overriden)
            //But they both have a speed, an hp, etc, even if it may vary. To reuse code, we create a constructor to expedite this process

            Console.WriteLine("Polymorphism Examples:");
            Slime slime = new Slime(10, 3, "Slime"); //Creation of Slime object from base parent Monster with constructor
            slime.AnnounceMonster(); //Use of base class method
            slime.DescribeAttack(); //Use of overridden method

            Dragon dragon = new Dragon(100, 50, "Dragon");
            dragon.AnnounceMonster();
            dragon.DescribeAttack();

            //                                                          ---

            //INHERITANCE:
            //In short, inheritance means that a child class inherits from its parent class. This serves to reuse code as much as posisble
            //Example: Dragon and Slime both inherit the AnnounceMonster method, and the variables of hp, attack and name
            //If you do not want any class to derive from your base class, use the keyword "sealed"

            //                                                          ---

            //ENCAPSULATION:
            //This is used to hide sensitive date and control who can see it.
            //Fields and methods should be declared private and the get/sets and constructors public
            //Example: the 


            //                                                   END AND RESSOURCES
            //--------------------------------------------------------------------------------------------------------------------------------

            //Thank you for reading. Hope this review helped! -Stephanie
            //RESSOURCE: W3School Website



            Console.ReadKey();
        }

        abstract class Car
        {
            public abstract void AnnounceCar();
            
            public void Honk()
            {
                Console.WriteLine("BEEP BEEP!");
            }
        }

        class ford : Car
        {
            public override void AnnounceCar() 
            {
                Console.Write("I am a Ford F150! ");
            }
        }

        interface IPlane
        {
            void AnnouncePlane();
            void Fly();
        }

        class Seaplane : IPlane
        {
            public void AnnouncePlane()
            {
                Console.Write("I am a seaplane! ");
            }
            public void Fly()
            {
                Console.WriteLine("NYOOM!");
            }
        }

        abstract class Monster
        {
            private int hp;
            private int attack;
            private string name;

            protected Monster(int hp, int attack, string name)
            {
                this.hp = hp;
                this.attack = attack;
                this.name = name;
            }

            public void AnnounceMonster()
            {
                Console.WriteLine("A " + name + " has appeared and is ready to attack!");
            }

            public abstract string DescribeAttack();
            
        }

        class Slime : Monster
        {
            public Slime(int hp, int attack, string name) : base(hp, attack, name)
            {
            }

            public override string DescribeAttack()
            {
                return "The slime attacks by spitting acid!";   
            }
        }

        class Dragon : Monster
        {
            public Dragon(int hp, int attack, string name) : base(hp, attack, name)
            {
            }

            public override string DescribeAttack()
            {
                return "The dragon attacks by spitting fire!";
            }
        }

    }
}
