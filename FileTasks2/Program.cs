using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Задание1. Выведите на экран информацию о каждом типе данных в виде:
// Тип данных – максимальное значение – минимальное значение
           
Console.WriteLine("Задание 1");
string an = "sbyte";
Console.WriteLine( an + $"({sbyte.MinValue}, {sbyte.MaxValue})");
            
string b = "byte";
Console.WriteLine(b + $"({byte.MinValue}, {byte.MaxValue})");
            
string c = "short";
Console.WriteLine(c + $"({short.MinValue}, {short.MaxValue})");
            
string d = "ushort";
Console.WriteLine(d + $"({ushort.MinValue}, {ushort.MaxValue})");
            
string e = "int";
Console.WriteLine(e + $"({int.MinValue}, {int.MaxValue})");
            
string f = "uint";
Console.WriteLine(f + $"({uint.MinValue}, {uint.MaxValue})");
            
string g = "long";
Console.WriteLine(g + $"({long.MinValue}, {long.MaxValue})");
            
string i = "ulong";
Console.WriteLine(i + $"({ulong.MinValue}, {ulong.MaxValue})");
            
string j = "float";
Console.WriteLine(j + $"({float.MinValue}, {float.MaxValue})");
            
string k = "double";
Console.WriteLine(k + $"({double.MinValue}, {double.MaxValue})");
            
string l = "decimal";
Console.WriteLine(l + $"({decimal.MinValue}, {decimal.MaxValue})");
Console. WriteLine();
            
// Задание 2. Напишите программу, в которой принимаются данные пользователя в виде имени, города, возраста и PIN-кода.
// Далее сохраните все значение в соответствующей переменной, а затем распечатайте всю информацию в правильном формате.

Console.WriteLine("Задание 2");
Console.WriteLine("Введите имя");
string name = Console.ReadLine();

Console.WriteLine("Введите город");
string city = Console.ReadLine();

Console.WriteLine("Введите возраст");
string age = Console.ReadLine();
if (age.All(char.IsDigit)) 
{
    //программа пойдет дальше при корректности ввода
}
else
{
    Console.WriteLine("Некорректный ввод! Возраст должен состоять только из цифр.");
}

Console.WriteLine("Введите пин-код");
string pincode= Console.ReadLine();
string info = $"{name} {city} {age} {pincode}";
Console.WriteLine("Имя Город Возраст Пин-Код");
Console.WriteLine(info);
Console. WriteLine();

// Задание 3. Преобразуйте входную строку: строчные буквы замените на заглавные, заглавные – на строчные.
            Console.WriteLine("Задание 3");
Console.WriteLine("Введите фразу: ");
string line = Console.ReadLine();
if (line.All(char.IsLetter))
{
  string Linenew = "";
  foreach (char a in line)
  {
   if (char.IsLower(a))
                        Linenew = Linenew + char.ToUpper(a);
   else
                        Linenew = Linenew + char.ToLower(a);
  }

  Console.WriteLine(Linenew);
  }
  else
  {
   Console.WriteLine("Ошибка! В строке должны быть только буквы.");
  }
Console. WriteLine();


// Задание 4. Введите строку, введите подстроку. Необходимо найти количество вхождений и вывести на экран.
Console.WriteLine("Задание 4");
Console.WriteLine("Введите основную строку:");
string mainString = Console.ReadLine();
        
Console.WriteLine("Введите подстроку для поиска:");
string subString = Console.ReadLine();
        
if (string.IsNullOrEmpty(subString)) // в строке необходимы символы
{
    Console.WriteLine("Подстрока не должна быть пустой.");
    return;
}
int count = CountOccurrences(mainString, subString);
Console.WriteLine($"Количество вхождений подстроки {subString} в строке: {count}"); 
        
static int CountOccurrences(string mainString, string substring)
{
    int count = 0;
    int index = 0;
    while ((index = mainString.IndexOf(substring, index, StringComparison.OrdinalIgnoreCase)) != -1)
    {
        count++; // +1 при нахождении вхождения
        index += substring.Length;
    }

    return count;
}
Console.WriteLine();

// Задание 5.Цель этой задачи - определить, сколько бутылок виски беспошлинной торговли вам
// нужно будет купить, чтобы экономия по сравнению с обычной средней ценой фактически
// покрыла расходы на ваш отпуск. Вам будет предоставлена стандартная цена (normPrice),
// скидка в Duty Free (salePrice) и стоимость отпуска (holidayPrice).Все входные данные будут
// целыми числами. Пожалуйста, верните целое число. Округлить в меньшую сторону.

Console.WriteLine("Задание 5");
double normPrice = 1000;
double salePrice = 20;
double holidayPrice = 4000;
Console.WriteLine(Math.Floor(holidayPrice / (normPrice * (salePrice / 100))));
Console.WriteLine();

// Задание 6. Создать 5 студентов с различными параметрами. Посчитать общий объем выпитого, общий объем алкоголя
// (процент спирта) и кто сколько процентов алкоголя и жидкости от общего количества
// выпил. Предполагается, что студент пьет один вид напитка. Напитки задать в виде структуры:
// наименование типа напитка и процент спирта.

Console.WriteLine("Задание 6");
AlcoholType beer = new AlcoholType(Drink.beer, 5.4);
AlcoholType vine = new AlcoholType(Drink.vine, 30);
AlcoholType rome = new AlcoholType(Drink.rome, 40);
AlcoholType whiskey = new AlcoholType(Drink.whiskey, 45);

List<Student> units = new List<Student>();

units.Add(new Student("Анна", "Лебедь", "meow", new DateTime(2005, 1, 1), 'a', 5, whiskey));
units.Add(new Student("Мария", "Кужкова", "eppe", new DateTime(2004, 1, 2), 'a', 4, vine));
units.Add(new Student("Влада", "Нерд", "yappie", new DateTime(1763, 11, 6), 'a', 20, beer));
units.Add(new Student("Олег", "Сок", "yabloko", new DateTime(2003, 1, 1), 'c', 2, rome));
units.Add(new Student("Катя", "Безымянная", "kek", new DateTime(2002, 1, 1), 'd', 3, beer));

double commonVolume = 0;
double commonAlc = 0;

foreach (Student unit in units)
{
    commonVolume += unit.volume;
    commonAlc += unit.volume * unit.alcohol.percentage * 0.01;
}
Console.WriteLine($"Всего выпито: {commonVolume}л. напитков, в которых содержалось {Math.Round(commonAlc, 2)}л. спирта");
foreach (Student unit in units)
{
    Console.WriteLine($"Студент {unit.name} {unit.surname} выпил {Math.Round((100 * unit.volume / commonVolume), 1)}% от всех напитков и {Math.Round((unit.volume * unit.alcohol.percentage / commonAlc), 1)}% всего спирта");
} 

// Создать структуру студента. У студента есть Фамилия, Имя, его Идентификатор, Дата
// рождения, Категория алкоголизма (a – студент алкоголик, b – студент любитель
// выпить, но не алкоголик, c – студент пьет по праздникам, d – студент не пьет), также у
// студента есть Объем выпитой жидкости конкретного напитка. 
public struct Student
{
    public string surname, name, login;
    DateTime birthDay;
    char alcoholCategory;
    public double volume;
    public AlcoholType alcohol;
    public Student(string name, string surname, string login,
        DateTime birthDay, char alcoholCategory, double volume, AlcoholType alcohol)
    {
        this.surname = surname;
        this.name = name;
        this.login = login;
        this.birthDay = birthDay;
        this.alcoholCategory = alcoholCategory;
        this.volume = volume;
        this.alcohol = alcohol;
    }
    public double AlcVolume()
    {
        return (volume * alcohol.percentage);
    }
}
public struct AlcoholType
{
    public Drink drink;
    public double percentage;
    public AlcoholType(Drink drink, double percentage)
    {
        this.drink = drink;
        this.percentage = percentage;
    }
}
public enum Drink { beer, vine, rome, whiskey }
