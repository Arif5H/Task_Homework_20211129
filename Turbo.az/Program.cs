using System;

namespace Turbo.az
{
    class Car_Store
    {
        public static void Main(string[] args)
        {/*turbo.az     saytina daxil olub orada bir Car modelinin tesvirini arashdirin
          * Sonra 4 xususiyyeti olacq sekilde bir Car classı yaradın
          * marka
          * model
          * year
          * price
          * son dersdeki kimi istifadeciden say saorushulsun
          * ve o qeder sayda mashini elave etmek(butun gostericilerini)*/

            Console.Write("Number of Cars ");
            int Carsquantity = Convert.ToInt32(Console.ReadLine());

            Car[] Cars = new Car [Carsquantity];

            for(int i = 0; i< Cars.Length; i++)
            {
                Car Car1 = new Car();

                Console.Write($"Car's Model {i + 1}: ");
                Car1.Model = Console.ReadLine();

                Console.Write($"Car's Brand {i + 1}: ");
                Car1.Brand = Console.ReadLine();

                Console.Write($"Car's Year  {i + 1}: ");
                Car1.Year = Convert.ToInt32 (Console.ReadLine());

                Console.Write($"Car's Location {i + 1}: ");
                Car1.Location = Console.ReadLine();

                Console.Write($"Car's Price {i + 1}: ");
                Car1.Price = Convert.ToDouble (Console.ReadLine());
                Cars[i] = Car1;


            }

            Console.WriteLine("Cars Info: ");
            foreach (var Car in Cars)
            {
                string name = Car.GetCarInfo();

                Console.WriteLine(name + $"\t");
            }

        }
    }
}
