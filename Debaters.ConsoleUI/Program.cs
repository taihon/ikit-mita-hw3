using Debaters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debaters.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в спор между Джеем и Тихим Бобом, с участием Числотрона!");
            int numberCount = -1;
            while (numberCount <= 0)
            {
                Console.Clear();
                Console.Write("Пожалуйста, введите количество чисел для спора: ");
                int.TryParse(Console.ReadLine(), out numberCount);
            }
            var jay = new Jay();
            var bob = new SilentBob();
            var numbertron = new Numbertron();
            numbertron.NewNumber += jay.FetchNewNumber;
            numbertron.NewNumber += bob.FetchNewNumber;
            for (int i = 0; i < numberCount; i++)
                numbertron.Generate();
            if(jay.Score > bob.Score)
                Console.WriteLine(jay.Name);
            else if (jay.Score < bob.Score)
                Console.WriteLine(bob.Name);
            else
                Console.WriteLine("DRAW");
            Console.ReadKey();
        }
    }
}
