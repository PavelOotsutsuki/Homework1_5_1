using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string,string> dictionary = new Dictionary<string, string>();

            string wordViolin= "Скрипка";
            string meanViolin= "СКРИПКА, -и, ж. Четырехструнный смычковый музыкальный инструментвысокого регистра. Концерт для скрипки с оркестром. Играть на скрипке.Первая с. (ведущий скрипач в оркестре; также перен.: о человеке, к-ромупринадлежит руководящая роль в чем-н.). II прил. скрипичный, -ая, -ое. С.мастер. С. класс. * Скрипичный ключ (спец.) - знак на нотном стане,устанавливающий высоту и название следующих за ним нот высокого и среднегорегистра.";
            string wordHairdresser = "Парикмахер";
            string meanHairdresser = "ПАРИКМАХЕР. -а, м. Мастер - специалист по прическам, завивке, стрижке,бритью. Дамский, мужской п. II ж. парикмахерша, -и (разг.). II прил.парикмахерский, -ая, -ое.";
            string wordCone = "Конус";
            string meanCone = "КОНУС, -а, м. 1. Геометрическое тело, образованное вращениемпрямоугольного треугольника вокруг одного из его катетов. 2.Предмет такойформы.К. террикона. II прил. конусный, -ая, -ое.";
            string wordFarm = "Ферма";
            string meanFarm = "ФЕРМА, -ы, ж. 1. Животноводческое подразделение в хозяйстве совхозаили колхоза, а также специализированное звероводческое хозяйство. Молочнаяф. Племенная ф. Песцовая ф. 2. Частное хозяйство или сельскохозяйственноепредприятие на собственном или арендуемом земельном участке. К прил.форменный, -ая, oое.";
            string wordRot = "Гниль";
            string meanRot = "ГНИЛЬ, -и, ж. Что-н. гнилое, затхлое, с плесенью. Пахнет гнилью.";

            dictionary.Add(wordViolin.ToUpper(), meanViolin);
            dictionary.Add(wordHairdresser.ToUpper(), meanHairdresser);
            dictionary.Add(wordCone.ToUpper(), meanCone);
            dictionary.Add(wordFarm.ToUpper(), meanFarm);
            dictionary.Add(wordRot.ToUpper(), meanRot);

            Work(dictionary);

            Console.Write("Для продолжения нажмите любую кнопку...");
            Console.ReadKey();
        }

        static void Work(Dictionary <string,string> dictionary)
        {
            Console.Write("Введите слово: ");
            string word = Console.ReadLine().ToUpper();

            if (dictionary.ContainsKey(word))
            {
                Console.WriteLine("Значение слова " + word + ":\n" + dictionary[word]);
            }
            else
            {
                Console.WriteLine("Такого слова в словаре нет");
            }
        }
    }
}