using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasper
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("input.txt"))
            {
                string massage = reader.ReadToEnd();

                string[] arrayLineMassage = massage.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0, j = 0; i < arrayLineMassage.Length; ++i)
                {
                    int numberElementArray = arrayLineMassage[i].IndexOf("id") + 1;
                    List<string> listSortedLineMassage = new List<string>();
                    listSortedLineMassage.Add(arrayLineMassage[i].Substring(numberElementArray));

                }
            }

            var listId = new List<object>();
            /*
             + взять из фала текст
             + преобразовать в строку
             + преобразовать в массив строки
             +найти все id, а точнее числа стоящие рядом
             сравнить их между собой и вставить в другой массив по порядку
             сравнить их по циклу и сохронить в нужное место массива или списка
             */
        }
    }
}
