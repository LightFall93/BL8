using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL8_P1_P2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Rectangle f1;
            f1.a_side = 10;
            f1.b_side = 5;
            f1.x = 0;
            f1.y = 0;*/
            Random rand = new Random();

            List<Rectangle> rectangles = new List<Rectangle>();


            for (int i = 0; i < rectangles.Count; i++)
            {
                //rectangles[i] = new Rectangle() { bside = rand.Next(10),aside = rand.Next(10) };
                rectangles.Add(new Rectangle() { aside = rand.Next(10), bside = rand.Next(10), x = 0,y =0});
            }

            //Rectangle found = rectangles.Find(item => item.bside == item.aside);
            //Console.WriteLine("Цена:{0}, Название:{1}", found.bside, found.aside);

            //List<Rectangle> foundBooks = rectangles.FindAll(item => item.bside == 5);





            foreach (var item in rectangles)
            {
                if (item.bside == item.aside)
                {
                    Console.WriteLine(" yyy");
                    break;
                }
            }




            /*
             for (int i = 0; i < rectangles.Count; i++)
            {
                Rectangle rectangle = rectangles[i];
                Console.WriteLine("Сторона:{0}, Сторона:{1}", rectangle.aside, rectangle.bside);
            }
             */




            //SortUn<Rectangle>(rectangles, new IComparer());//rectangles.bside== rectangles.aside



            /*foreach (var item in rectangles)
            {
                if (item.bside == item.aside&&)
                {
                    Console.WriteLine(found;
                    break;
                }
            }*/


            /*for (int j = 0; j < 100; j++)
            {
                if (rectangles.bside == rectangles.aside)
                {
                    
                    break;
                }
            }*/

            /*foreach (var item in rectangles.Distinct())
            {
                Console.WriteLine(item + " - " + rectangles.Where(x => x == item).Count() + " раз");
            }*/


            Console.ReadLine();
        }

        public struct Rectangle
        {
            public int aside;
            public int bside;
            public int x;
            public int y;

            Rectangle(int bside, int aside, int x, int y)
            {
                this.aside = aside;
                this.bside = bside;
                this.x = x;
                this.y = y;

            }

        }

        /*private static void SortUn<TSortingType>(TSortingType[] rectangles, IComparer comparer)
        {
            for (int i = 1; i < rectangles.Length; i++)
            {
                //if (numbers[i - 1].flatNumber > numbers[i].flatNumber)
                if (comparer.Compare(rectangles[i - 1], rectangles[i]) >= 1)
                {
                    var temp = rectangles[i - 1];
                    rectangles[i - 1] = rectangles[i];
                    rectangles[i] = temp;
                }
            }
        }*/


    }

    /*public class IntComparer : IComparer<int>
    {
        public int Compare(int obj1, int obj2)
        {
            if (obj1 > obj2)
            {
                return 1;
            }
            else if (obj1 == obj2)
            {
                return 0;
            }

            return -1;
        }
    }*/

    /*public class RectangleComparer : IComparer<Rectangle>
    {
        public int Compare(Rectangle obj1, Rectangle obj2)
        {
            if (obj1.flatNumber > (obj2).flatNumber)
            {
                return 1;
            }
            else if (obj1.flatNumber == obj2.flatNumber)
            {
                return 0;
            }

            return -1;
        }
    }*/
}
