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
                if (reader.ReadLine() == null)
                {
                    throw new Exception("Пустой файл");
                }
                else
                {
                    using (StreamReader reader2 = new StreamReader("index.txt"))
                    {
                        List<int> listTextFile = reader2.ReadToEnd().Replace(Environment.NewLine, " ").Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

                        listTextFile.RemoveAll(CheckEven);

                        List<int> listTextFileNoRepeatNumbers = new List<int>();

                        for (int i = 0; i < listTextFile.Count; ++i)
                        {
                            if (listTextFileNoRepeatNumbers.IndexOf(listTextFile[i]) == -1)
                            {
                                listTextFileNoRepeatNumbers.Add(listTextFile[i]);
                            }
                        }

                        listTextFileNoRepeatNumbers.ForEach(Print);
                    }
                }
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
