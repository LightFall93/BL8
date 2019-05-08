using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL8_P1_P2
{
    class Program
    {
        //public class Rectangle//не работает, потомучто нужно по значению как в у  нас в struct
        public struct Rectangle
        {
            public int aside;
            public int bside;

            public void ShowInfo()
            {
                Console.WriteLine($"aside= {aside}  bside= {bside} ");
            }

        }

        static void Main(string[] args)
        {

            Random rand = new Random();

            List<int> joj = new List<int>();
           

            Rectangle[] rectangles = new Rectangle[100];

            for (int i = 0; i < 100; i++)
            {
                rectangles[i] = new Rectangle() { bside = rand.Next(10),aside = rand.Next(10), };
               
            }

            foreach (Rectangle rectangle in rectangles)
            {
                rectangle.ShowInfo();
            }


            int clich = 0;

            bool prov = false;
            
                for (int i = 0; i < rectangles.Length; i++)
            {

                for (int k = 0; k < joj.Count; k++)
                {
                    if (joj[k] == i)
                    {
                        prov = true;
                        break;
                    }
                }

                if (prov==true)
                { 
                    continue;;
                }

                else
                {
                    for (int j = i; j < rectangles.Length; j++)
                        if (Equals(rectangles[i], rectangles[j]) & (i != j))//(rectangles[i] == rectangles[i+1])
                        {
                            joj.Add(j);


                            //Console.WriteLine(rectangles[i].aside + " " + rectangles[i].bside + "  = " + rectangles[j].aside + " " + rectangles[j].bside);
                            clich++;
                        }
                }
            }

                Console.WriteLine("Количество дубликатов " + clich);

            Console.ReadLine();
        }


    }

    
}
