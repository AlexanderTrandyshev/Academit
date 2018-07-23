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
            //TODO добавить путь, где лежит файл
            const string path = "ПУТЬ ДЛЯ ФАЙЛА ГДЕ ВСЕ ЧИСЛА";

            using (StreamReader sr = new StreamReader(path))
            {
                if (sr.ReadToEnd() != null)
                {
                    throw new Exception("Пустой файл");
                }
                else
                {
                    string fileCopy =sr.ReadToEnd();

                    List<int> listNumber = new List<int>();

                    for (int i = 0; i < fileCopy.Length; ++i)
                    {
                        //TODO добавить реализацию добавления данных в список

                        /*
                         * Разбить строку на отдельные числа
                          Конверктировать строку в число
                          Добавить все числа в список
                        */
                    }

                    //TODO удалить из списка (отдельным циклом) все  четные числа
                }

                //TODO добавить реализацию сравнения каждого числа и все числа добавить в новый список без повторения.
                /* Двойной\Одинарный цикл.
                 * Сравнение одного числа с другими в списке.
                 * Длина первого цикла n-1, а второй до конца списка.
                 * Опирация сравнения должна быть пример(есть число в 1 списке проверяет есть ли такое число во втором, если нет то добавит число иначе берет следующее)
                 * 
                 */
            }
        }
    }
}
