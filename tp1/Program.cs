using System;
using System.Collections.Generic;
using System.Linq;

namespace tp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer[] defaultComputers = { 
                new Computer(id: 1, brand: "MSI", model: "V1", processorFrequency: 5.2, ram: 16), 
                new Computer(id: 2, brand: "Asus", model: "V2", processorFrequency: 4.2, ram: 8),
                new Server(id: 5, bayNumber: 3, raid: 2, brand: "Dell", model: "V8", processorFrequency: 5.2, ram: 32),
                new Laptop(id: 5, screen: "Samsung", batteryLoad: true, brand: "test", model: "V8", processorFrequency: 5.2, ram: 64)
            };

            LinkedList<Computer> computers = new LinkedList<Computer>(defaultComputers); 

            _DisplayComputers("Parc par défaut", computers);

            //Ajouter d'un ordinateur au parc
            Computer newComputer = new Computer(id: 3, brand: "Dell", model: "V3", processorFrequency: 3.9, ram: 32);
            computers.AddLast(newComputer);

            _DisplayComputers("Nouveau computer ", computers);

            //Supprimer un ordinateur du parc
            computers.RemoveLast();
            _DisplayComputers("Supprimer un computer", computers);

            //Rechercher un computer
            var searchedComputer = computers.FirstOrDefault(computer => computer.getId() == 1);
            Console.WriteLine("\nMarque du computer 1 : " + searchedComputer.getBrand());

            //Changer la marque du dernier ordinateur
            computers.First.Value = new Computer(id: 3, brand: "Dell", model: "V5", processorFrequency: 5.4, ram: 64);
            _DisplayComputers("Parc final ", computers);


        }

        //Afficher le parc actuel
        private static void _DisplayComputers(String title, LinkedList<Computer> computers)
        {
            Console.WriteLine("\n--- " + title + " ---");
            foreach (Computer _computer in computers)
            {
                Console.WriteLine("Id " + _computer.getId());
                Console.WriteLine("Marque : " + _computer.getBrand());
                Console.WriteLine("Fréquence processeur : " + _computer.getProcessorFrequency() + " Ghz");
                Console.WriteLine("RAM : " + _computer.getRam() + " Go");
            }
        }
    }
}
