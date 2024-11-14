global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;

//Упражнение 3.1 Создать перечислимый тип данных отображающий виды банковского
// счета (текущий и сберегательный). Создать переменную типа перечисления, присвоить ей
// значение и вывести это значение на печать.
struct Bank
{
    int Identification;
    string Type;
    int Balance;

    void DisplayInfo()
    {
        Console.WriteLine($"Идентификация:{Identification}, Тип:{Type}, Баланс:{Balance}");
    }

    public enum bank
    { SavingCount, CurrentCount }

    public enum ВУЗ
    { КГУ, КАИ, КХТИ }

    struct Работник
    {
        public ВУЗ university;
        public string Name;
    }

    // Упражнение 3.2 Создать структуру данных, которая хранит информацию о банковском
    // счете – его номер, тип и баланс. Создать переменную такого типа, заполнить структуру
    // значениями и напечатать результат.
    static void Main()
    {
        {
            Console.WriteLine("Упр. 3.1. ");
            Console.WriteLine("Выберите, что запустить: ");
            Console.WriteLine("1) Проверка банковского счета");
            Console.WriteLine("2) Приложение университета");
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        RunBankApplication();
                        break;
                    case 2:
                        RunUniversityApplication();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Введите либо 1, либо 2 ");
                
            }
            
        }

        static void RunBankApplication()
        {
            Console.WriteLine("Упр. 3.2");
            bank CurrentCount = bank.CurrentCount;
            Console.WriteLine(CurrentCount);
            Bank eppie; 
            eppie.Identification = 1;
            eppie.Type = "Сберегательный";
            eppie.Balance = 123456;
            eppie.DisplayInfo();
        }
        
        //Домашнее задание 3.1 Создать перечислимый тип ВУЗ{КГУ, КАИ, КХТИ}.
        //Создать структуру работник с двумя полями: имя, ВУЗ. Заполнить структуру данными и распечатать
        static void RunUniversityApplication()
        { 
            Console.WriteLine("Дз 3.1");
            Работник Worker = new Работник();
            Worker.Name = "Руслана";
            Worker.university = ВУЗ.КГУ;
            Console.WriteLine("Информация о работнике:");
            Console.WriteLine($"Имя работника: {Worker.Name} ");
            Console.WriteLine($"Выбранный ВУЗ: {Worker.university}");
        }
    }
}

      

   
