using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListHome
{
    class ArrayListHome
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("index.txt"))
            {
                List<int> listTextFile = reader.ReadToEnd().Replace(Environment.NewLine, " ").Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

                listTextFile.RemoveAll(CheckEven);

                List<int> listTextFileNoRepeatNumbers = new List<int>();

                foreach (int e in listTextFile)
                {
                    if (listTextFileNoRepeatNumbers.Contains(e))
                    {
                        listTextFileNoRepeatNumbers.Add(e);
                    }
                }

                listTextFileNoRepeatNumbers.ForEach(Print);
            }
        }

        public static bool CheckEven(int number)
        {
            return number % 2 == 0;
        }

        public static void Print(int elementList)
        {
            Console.Write($"{elementList}, ");
        }
    }
}
