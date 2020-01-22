using System;
using System.IO;

namespace Filhantering_Fil_Summa
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("talfil.tf", FileMode.OpenOrCreate, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            StreamWriter sw = new StreamWriter("talfil.txt");
            StreamWriter sw_sum = new StreamWriter("Summa.txt");

            int sum = 0;
            int fsum = 0; 
            int fasum = 0;
            string row = "";
            
            for (int i = 0; i < fs.Length / 4; i++)
            {
                int num = br.ReadInt32();
                sum += num;
                sw.WriteLine(num);
                // Console.WriteLine(num);
            }

            sw.Close();

            StreamReader sr = new StreamReader("talfil.txt");

            for (int i = 0; i < fs.Length / 4; i++)
            {
                row = sr.ReadLine();
                if (row == "5")
                {
                    fsum += 1;
                }
            }

            sr.Close();

            StreamReader sr1 = new StreamReader("talfil.txt");

            for (int i = 0; i < fs.Length / 4; i++)
            {
                row = sr1.ReadLine();
                if (row == "5")
                {
                    fasum += 1;
                }
                else if (row == "15")
                {
                    fasum += 1;
                }
                else if (row == "25")
                {
                    fasum += 1;
                }
                else if (row == "35")
                {
                    fasum += 1;
                }
                else if (row == "45")
                {
                    fasum += 1;
                }
                else if (row == "50")
                {
                    fasum += 1;
                }
                else if (row == "51")
                {
                    fasum += 1;
                }
                else if (row == "52")
                {
                    fasum += 1;
                }
                else if (row == "53")
                {
                    fasum += 1;
                }
                else if (row == "54")
                {
                    fasum += 1;
                }
                else if (row == "55")
                {
                    fasum += 2;
                }
                else if (row == "56")
                {
                    fasum += 1;
                }
                else if (row == "57")
                {
                    fasum += 1;
                }
                else if (row == "58")
                {
                    fasum += 1;
                }
                else if (row == "59")
                {
                    fasum += 1;
                }
                else if (row == "65")
                {
                    fasum += 1;
                }
                else if (row == "75")
                {
                    fasum += 1;
                }
                else if (row == "85")
                {
                    fasum += 1;
                }
                else if (row == "95")
                {
                    fasum += 1;
                }
                else
                {
                    fasum += 0;
                }
            }

            sr1.Close();

            sw_sum.WriteLine("The sum of all the numbers in the file: " + sum);
            sw_sum.WriteLine("The sum of all the singular fives in the file: " + fsum);
            sw_sum.WriteLine("The sum of all the fives in the file: " + fasum);

            Console.WriteLine("File length: " + fs.Length / 4); 
            Console.WriteLine("The sum of all the numbers in the file: " + sum);
            Console.WriteLine("The sum of all the singular fives in the file: " + fsum);
            Console.WriteLine("The sum of all the fives in the file: " + fasum);

            br.Close();
            sw_sum.Close();

            Console.ReadLine();
        }
    }
}
