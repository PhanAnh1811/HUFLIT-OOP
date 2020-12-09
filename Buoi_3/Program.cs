using System;
using System.Collections.Generic;
namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Person
            //Person person = new Person("tuananh.61779@gmail.com", "Phan Tuan Anh");
            //Student student = new Student(person.Email, person.Name, "18DH110184");
            //Console.WriteLine(student.ToString());
            #endregion

            #region Product
            //Product product = new Product("Laptop", 25000000);
            //Software software = new Software(product.Name, product.Price, "v20.2.2");
            //Hardware hardware = new Hardware(product.Name, product.Price, "2.5kg");
            //Console.WriteLine(software.ToString());
            //Console.WriteLine(hardware.ToString());
            #endregion

            List<Animal> listAnimal = new List<Animal>(5);
            Lion l1 = new Lion("KING", "Lion King", 99, 100.15);
            Lion l2 = new Lion("QUEEN", "Queen King", 80, 90.15);
            Whale w1 = new Whale("Whale #1", "Whale One", 199, 123.5);
            Whale w2 = new Whale("Whale #2", "Whale Two", 599, 523.5);
            Whale w3 = new Whale("Whale #3", "Whale Three", 159, 423.5);
            listAnimal.Add(l1);
            listAnimal.Add(l2);
            listAnimal.Add(w1);
            listAnimal.Add(w2);
            listAnimal.Add(w3);


            Animal maxAnimal = new Animal();
            maxAnimal.Weight = -1;
            foreach (Animal x in listAnimal)
            {
                if (x.Weight > maxAnimal.Weight)
                {
                    maxAnimal = x;
                }
            }

            Console.WriteLine("Animal have max weight is " + maxAnimal.ToString());

            foreach (Animal x in listAnimal)
            {
                if (x is Lion)
                {
                    Lion lion = (Lion)x;
                    Console.WriteLine(lion.Hunt());
                }
                else
                {
                    Whale whale = (Whale)x;
                    Console.WriteLine(whale.Fish());
                }
            }
        }
    }
}
