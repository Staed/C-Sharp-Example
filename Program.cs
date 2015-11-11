using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. String/StringBuilder
            String greeting = "Yo";
            Console.WriteLine(greeting);

            // 2. StringBuilder Concept
            StringBuilder spagetti = new StringBuilder();
            for(int i = 0; i < 10; i++)
            {
                spagetti.Append(i);
                spagetti.Append(", ");
            }
            Console.WriteLine(spagetti.ToString());

            // 3. DateTime Concept
            DateTime time = DateTime.Now.AddYears(-30);
            Console.WriteLine(time.ToLongDateString());

            // 4. TimeSpan Concept
            TimeSpan years = DateTime.Now.Subtract(time);
            Console.WriteLine(years);

            // 5. Class Concept (Cont.)
            Coordinates location = new Coordinates(3, 4);
            Console.WriteLine(location.EuclideanDistance());
            location = null;

            // 6. Inheritance & 7. Sealed Class Concept (Cont.)
            Coord_3 thirdDimension = new Coord_3(3, 4, 5);
            Console.WriteLine(thirdDimension.EuclideanDistance());
            thirdDimension = null;

            Console.ReadLine();
        }
    }

    // 5. Class Concept
    class Coordinates
    {
        public int x_coord { get; set; }
        public int y_coord { get; set; }

        public Coordinates()
        {
            this.x_coord = 0;
            this.y_coord = 0;
        }

        public Coordinates(int x, int y)
        {
            this.x_coord = x;
            this.y_coord = y;
        }

        public virtual int EuclideanDistance()
        {
            return (int)Math.Pow(Math.Pow(this.x_coord, 2) + Math.Pow(this.y_coord, 2), 0.5);
        }
    }

    // 6. Inheritance Concept
    // 7. Sealed Class Concept
    sealed class Coord_3 : Coordinates
    {
        public int z_coord { get; set; }

        public Coord_3()
        {
            this.x_coord = 0;
            this.y_coord = 0;
            this.z_coord = 0;
        }

        public Coord_3 (int x, int y, int z)
        {
            this.x_coord = x;
            this.y_coord = y;
            this.z_coord = z;
        }

        public override int EuclideanDistance()
        {
            return (int)Math.Pow(Math.Pow(this.x_coord, 2) + Math.Pow(this.y_coord, 2) + Math.Pow(this.z_coord, 2), 0.5);
        }
    }
}
