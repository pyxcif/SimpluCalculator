using System;
using System.Collections.Generic;

namespace SimpluCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("how many input :  ");
            var test = Console.ReadLine();
            if(int.TryParse(test,out int number))
            {
                Calculator x = new Calculator();
                    x.start(number);
            }
            else
            {
                Console.WriteLine($"{test} is not a number ");
            }
        }
    }
    class Calculator
    {
        private List<float> lista = new List<float>();
        
        public void start(int x)
        {   
            for(int i = 0; i < x; i++)
            {
                loadNumber();
            }
            ceFaciCuNumere();
        }
        private void ceFaciCuNumere()
        {
            Console.WriteLine("enter sign(suma,inmultire,diferenta,impartire,afiseaza numerele): ");
            string x = Console.ReadLine();
            
            switch (x)
            {
                case "suma":
                    calculeazaSuma();
                    break;
                case "inmultire":
                    calculeazaInmultire();
                    break;
                case "diferenta":
                    calculeazaDiferenta();
                    break;
                case "impartire":
                    calculeazaImpartire();
                    break;
                default:
                    Console.WriteLine("WRONG INPUT");
                    ceFaciCuNumere();
                    break;
            }
        }

        private void loadNumber()
        {
            Console.WriteLine("Enter number: ");
            string numar = Console.ReadLine();
            var x = int.TryParse(numar, out int number);
            if (x)
            {
                lista.Add(number);
            }
        }
        private void printList()
        {    
            foreach(float element in lista)
            {
                Console.WriteLine(element);
            }
     
        }
        private void calculeazaSuma()
        {
            float total = 0;
            foreach (float element in lista)
            {
                total=total + element;
            }
            Console.WriteLine(total);
        }
        private void calculeazaDiferenta()
        {
            
                float total = 0;
                foreach (float element in lista)
                {
                    total = total - element;
                }
            Console.WriteLine(total);
        }
        private void calculeazaInmultire()
        {
            float total = 1;
            foreach (float element in lista)
            {
                total = total * element;
            }
            Console.WriteLine(total);
        }
        private void calculeazaImpartire()
        {
            float total = 1;
            foreach (float element in lista)
            {
                total = total / element;
            }
            Console.WriteLine(total);

        }
    }
}
