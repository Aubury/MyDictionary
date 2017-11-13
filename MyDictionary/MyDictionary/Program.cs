﻿//Задача:
//Создать интерактивный словарь неправильных глаголов.
//Пользователь должен иметь возможность вводить глаголы в 1й форме,
//в ответ на экране отображается 2я и 3я формы и перевод.
//Если слово не найдено в словаре - сообщать об этом пользователю.
//Приложение должно работать до тех пор, пога не будет введен символ или слово для завершения работы.


//Особенности реализации:
//1) В качестве источника данных использовать класс IrregularVerbsRepository
//2) Создать класс описывающий одну словарную статью.
//     Он должен содержать 3 свойства для каждой формы + 1 свойство для перевода
//3) Для хранения словаря и поиска по нему использовать коллекцию Dictionary<ключ, словарная_статья>,
//     где ключ - глагол в 1й форме, а словарная_статья - класс, созданный в п.2
//4) При запуске приожения заполнять Dictionary используя IrregularVerbsRepository

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пример использования репозитария
            //IrregularVerbsRepository repo = new IrregularVerbsRepository();
            //var verbs = repo.GetWords();
          
          Dictionary<string, Irregular_verbs> verbs = Dictionary_of_irregular_verds.MyDict();

            do
            {
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Input verb : ");
                    string value = Console.ReadLine();
             
                    if (verbs.ContainsKey(value))
                    {
                        Console.WriteLine($"{ verbs[value]}");
                    }
                    else 
                     {
                   Console.WriteLine($"Key = \\ {value} \\ is not found.");
                     }

            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);


            Console.WriteLine("Dictionary: ");
            foreach (KeyValuePair<string, Irregular_verbs> p in verbs)
            {
                Console.WriteLine($"{p.Key} {p.Value} ");
                Console.WriteLine();
            }
        }
    }
    }

