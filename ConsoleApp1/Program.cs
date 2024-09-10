//task 1
//Console.WriteLine("THE КАЛЬКУЛЯТОРРР");
//double a, b;
//Console.WriteLine("Вводите свои числа: ");
//a = double.Parse(Console.ReadLine());
//b = double.Parse(Console.ReadLine());
//Console.WriteLine("Выберите желаемое действие (+ - / *) : ");
//char c = char.Parse(Console.ReadLine());
//char d = 'y';
//if (c == '+')
//{
//    Console.WriteLine(a + " + " + b + " = " + (a + b));
//}
//if (c == '-')
//{
//    Console.WriteLine(a + " - " + b + " = " + (a - b));
//}
//if (c == '/')
//{
//    if (a == 0 || b == 0)
//    {
//        Console.WriteLine("Делить на ноль нельзя");
//        return;
//    }
//     Console.WriteLine(a + " / " + b + " = " + (a / b));


//}
//if (c == '*')
//{
//    Console.WriteLine(a + " * " + b + " = " + (a * b));
//}
//task 2
//Console.WriteLine("Подсчет в тексте");
//Console.WriteLine("Введите строку");
//int word = 0;
//int predl = 0;
//string str = Console.ReadLine();
//foreach (char i in str)
//{
//    if (i == ' ')
//    {
//        word++;
//    }
//    if (i == '.' || i == '?' || i == '!')
//    {
//        predl++;
//    }  
//}
//Console.WriteLine("В вашей строке " + str.Length + " символов, " + (word + 1) +  " слов -а -о, и " + predl + " предложений -я ");
//task 3
//Console.WriteLine("Таблица умножения");
//for (int i = 1; i < 10; i++)
//{
//    for (int o = 1; o < 10; o++)
//    {
//        Console.WriteLine(o + " * " + i + " = " + o * i);
//    }
//}
//task 4
//Console.WriteLine("Факториал числа");
//int num = int.Parse(Console.ReadLine());
//int result = 1;
//for (int i = 1; i <= num; i++)
//{
//    result *= i;
//}
//Console.WriteLine("Факториал числа " + num + " = " + result);
//task 5 
//Console.WriteLine("Числа Фибоначчи");
//int n = int.Parse(Console.ReadLine());
//int x = 0; int l = 1; int temp; 
//for (int i = 0; i < n; i++)
//{
//    temp = x;
//    x = l;
//    l = temp + l;
//}
//Console.WriteLine(x);
//task 6
//Console.WriteLine("Поиск простых чисел");
//int n = int.Parse(Console.ReadLine());
//for (int i = 0; i < n; i++)
//{
//    Console.WriteLine(1 + i);
//}
//task 7
//Console.WriteLine("Угадай число");
//Random random = new Random();
//int ran = random.Next(0,101);
//int choice = int.Parse(Console.ReadLine());
//if (choice == ran)
//{
//    Console.WriteLine("Победа!");
//}
//else
//{
//    Console.WriteLine("Вы не угадали, было число " + ran);
//}
//task 8 
/*Console.WriteLine("Калькулятор площади фигур");
string figure = Console.ReadLine();
if (figure == "круг")
{
    int r = int.Parse(Console.ReadLine());
    Console.WriteLine("Площадь круга равна " + (3, 14 * (r * r)));
}
if (figure == "треугольник")
{
    int a = int.Parse(Console.ReadLine());
    int h = int.Parse(Console.ReadLine());
    Console.WriteLine("Площадь треугольник равна " + (1 / 2 * a * h));
}
if (figure == "прямоугольник")
{
    int v = int.Parse(Console.ReadLine());
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine("Площадь прямоугольника равна " + v * n);
}*/
//task 9
//Console.WriteLine("Выберите вариант\n 1) Килограммы в граммы \n 2) Граммы в килограммы \n3) Километры в метры \n4) метры в километры");
//double z = 0;
//switch (Convert.ToInt32(Console.ReadLine()))
//{
//    case 1: Console.WriteLine("Введите килограммы");
//        z = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine($"Ваши граммы: {Convert.ToDouble(z*1000)}");
//        break;
//    case 2:
//        Console.WriteLine("Введите граммы");
//        z = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine($"Ваши килограммы: {Convert.ToDouble(z / 1000)}");
//        break;
//    case 3:
//        Console.WriteLine("Введите Километры");
//        z = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine($"Ваши метры: {Convert.ToDouble(z * 1000)}");
//        break;
//    case 4:
//        Console.WriteLine("Введите метры");
//        z = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine($"Ваши Километры: {Convert.ToDouble(z / 1000)}");
//        break;
//}
//9

//Console.WriteLine("Введите число");
//double z = Convert.ToInt32(Console.ReadLine());
//for(int i = 0; i <= 100; i++)
//{
//    Console.WriteLine($"{i}% от {z} равен {Convert.ToDouble(z / 100) * i}");
//}
//10

//Console.WriteLine("Введите число");
//int z = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Выберите валюту \n 1)Рубли в доллары \n 2)Доллары в рубли");
//switch (Convert.ToUInt32(Console.ReadLine()))
//{
//    case 1:
//        Console.WriteLine(z % 90);
//        break;
//    case 2:
//        Console.WriteLine(z*90);
//        break;

//}
//11
//Console.WriteLine("Выберите валюту которую хотите перевести (рубли, доллар, евро, йена)");
//string vall = Console.ReadLine();
//double rezult = 0;
//if (vall == "рубли")
//{
//    Console.WriteLine("Введите сумму: ");
//    double summa = int.Parse(Console.ReadLine());
//    Console.WriteLine("Выберите валюту в которую хотите перевести (доллар, евро, йена)");
//    vall = Console.ReadLine();
//    if(vall == "доллар")
//    {
//        rezult = summa * 0.011;
//        Console.WriteLine(rezult);
//    }
//    if (vall == "евро")
//    {
//        rezult = summa * 0.010074;
//        Console.WriteLine(rezult);
//    }
//    if (vall == "йена")
//    {
//        rezult = summa * 1.62;
//        Console.WriteLine(rezult);
//    }
//}
//if (vall == "доллар")
//{
//    Console.WriteLine("Введите сумму: ");
//    double summa = int.Parse(Console.ReadLine());
//    Console.WriteLine("Выберите валюту в которую хотите перевести (рубли, евро, йена)");
//    vall = Console.ReadLine();
//    if (vall == "рубли")
//    {
//        rezult = summa * 90;
//        Console.WriteLine(rezult);
//    }
//    if (vall == "евро")
//    {
//        rezult = summa * 0.90373;
//        Console.WriteLine(rezult);
//    }
//    if (vall == "йена")
//    {
//        rezult = summa * 146.64;
//        Console.WriteLine(rezult);
//    }

//}
//if (vall == "евро")
//{
//    Console.WriteLine("Введите сумму: ");
//    double summa = int.Parse(Console.ReadLine());
//    Console.WriteLine("Выберите валюту в которую хотите перевести (рубли, доллар, йена)");
//    vall = Console.ReadLine();
//    if (vall == "рубли")
//    {
//        rezult = summa * 99.26;
//        Console.WriteLine(rezult);
//    }
//    if (vall == "доллар")
//    {
//        rezult = summa * 1.11;
//        Console.WriteLine(rezult);
//    }
//    if (vall == "йена")
//    {
//        rezult = summa * 162.26;
//        Console.WriteLine(rezult);
//    }

//}
//if (vall == "йена")
//{
//    Console.WriteLine("Введите сумму: ");
//    double summa = int.Parse(Console.ReadLine());
//    Console.WriteLine("Выберите валюту в которую хотите перевести (рубли, доллар, евро)");
//    vall = Console.ReadLine();
//    if (vall == "рубли")
//    {
//        rezult = summa * 0.615604;
//        Console.WriteLine(rezult);
//    }
//    if (vall == "доллар")
//    {
//        rezult = summa * 0.006819;
//        Console.WriteLine(rezult);
//    }
//    if (vall == "евро")
//    {
//        rezult = summa * 0.006163;
//        Console.WriteLine(rezult);
//    }

//}
//task 12
/*int[] numbers = { 1, 2, 3, 4, 5,6,7,8,9,10,0 };
int maxnum = numbers[0];
int minnum = numbers[0];
int indmax = 0;
int indmin = 0;
for(int i = 0; i < numbers.Length;i++)
{
    if(numbers[i] > maxnum)
    {
        maxnum = numbers[i];
        indmax = i;
    }
    if(numbers[i] < minnum) { 
        minnum = numbers[i];
        indmin = i;
    }
}
Console.WriteLine($"Максимальное: {maxnum} и его индекс {indmax}");

Console.WriteLine($"маленький опарыш: {minnum} и его индекс {indmin}");
*/
//task 13
/*int[] numbers = { 1, 2, 3, 4, 5,6,7,8,9,10,0 };
int num = 0;
for (int i = 0; i < numbers.Length; i++)
{
    for (int j = 0; j < numbers.Length; j++)
    {
        if (numbers[i] > numbers[j])
        {
            num = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = num;
        }
    }
}
foreach(int i in numbers)
{
    Console.WriteLine(i + " ");
}
Console.WriteLine("///////////////////////");
Array.Sort(numbers);
foreach(int i in numbers)
{
    Console.WriteLine(i + " ");
}*/
//task 14
/*int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 0 };
bool z = false;
int search = int.Parse(Console.ReadLine());
for(int i = 0; i < numbers.Length; i++)
{
    if (search == numbers[i])
    {
        Console.WriteLine(i);
        z = true;
    }
}
if (!z)
{
    Console.WriteLine("Число не найдено");
}*/
//task 15
//int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 0 };
//int num = 0;
//for (int i = numbers.Length-1; i >= 0; i--)
//{
//    Console.WriteLine(numbers[i] + " ");
//}
//taski 16
/*Console.WriteLine("Введите размер матрицы AxB");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int[,] matr = new int[a,b];
int[,] matr1 = new int[a, b];
Console.WriteLine("Введите первую матрицу");
for (int i = 0; i < a; i++)
{
    for(int j = 0; j < b; j++)
    {
        matr[i,j] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("Введите 2 матрицу");
for (int i = 0; i < a; i++)
{
    for (int j = 0; j < b; j++)
    {
        matr1[i, j] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("Введите операцию * + - транспорирование");
switch (Console.ReadLine())
{
    case "+":
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                matr[i, j] = matr[i, j] + matr1[i, j];
            }
        }
        break;
    case "-":
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                matr[i, j] = matr[i, j] - matr1[i, j];
            }
        }
        break;
    case "*":
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                matr[i, j] = matr[i, j] * matr1[i, j];
            }
        }
        break;
    case "транспорирование":
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                matr1[j, i] = matr[i, j];
            }
        }
        matr = matr1;
        break;
}
for (int i = 0; i < a; i++)
{
    for (int j = 0; j < b; j++)
    {
        Console.Write(matr[i,j] + " ");
    }
    Console.WriteLine(" ");
}*/
//task17
/*Console.WriteLine("Введите ваше 10-ное число");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Введите систему счисления для перевода (2, 8, 16)");
int choice = int.Parse(Console.ReadLine());
switch (choice)
{
    case 2:
        string result = Convert.ToString(num, 2);
        Console.WriteLine(result);
        break;
    case 8:
        string result1 = Convert.ToString(num, 8);
        Console.WriteLine(result1);
        break;
    case 16:
        string result2 = Convert.ToString(num, 16);
        Console.WriteLine(result2);
        break;
}*/
//task18
/*Console.WriteLine("Числовая пирамида");
int l = 1 + 2 * (10 - 1);
int n = 1;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(new string(' ', (int)(l - n / 2)) + new string('1', n));
    n += 2;
}*/
/*//task19
Console.WriteLine("Введите строку");
string str = Console.ReadLine();
Console.WriteLine("Введите подстроку для поиска");
string substr = Console.ReadLine();
int index = str.IndexOf(substr);
if (index == -1)
{
    Console.WriteLine("Вхождения не найдено");
}
else
{
    Console.WriteLine(index);
}*/
//task 20
Console.WriteLine("Удаление пробелов");
Console.WriteLine("Ваша строка");
string str = Console.ReadLine();
while (str.Contains("  ")) 
{
    str = str.Replace("  ", " ");
}
Console.WriteLine(str);
//task 21
/*Console.WriteLine("Введите первую дату (ДД.ММ.ГГГГ):");
string firstDateInput = Console.ReadLine();
Console.WriteLine("Введите вторую дату (ДД.ММ.ГГГГ):");
string secondDateInput = Console.ReadLine();
DateTime firstDate;
DateTime secondDate;
if (DateTime.TryParseExact(firstDateInput, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out firstDate) &&
    DateTime.TryParseExact(secondDateInput, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out secondDate))
{
    TimeSpan difference = secondDate - firstDate;
    int daysDifference = (int)difference.TotalDays;
    Console.WriteLine($"Количество дней между датами: {daysDifference}");
}
else
{
    Console.WriteLine("Некорректный формат даты. Используйте формат ДД.ММ.ГГГГ.");
}*/
//task 22
/*using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
static void CheckPhoneNum()
{
    Console.WriteLine("Введите номер телефона (проверка работает только на номера России):");
    string phoneNumber = Console.ReadLine();
    if (phoneNumber.Length > 11)
    {
        Console.WriteLine("Номер телефона должен состоять из 11 цифр.");
    }
    if (phoneNumber.Length == 11 && phoneNumber[0] == '8' && phoneNumber[1] == '9')
    {
        bool isNumeric = true;
        foreach (char c in phoneNumber)
        {
            if (!char.IsDigit(c))
            {
                isNumeric = false;
                break;
            }
        }

        if (isNumeric)
        {
            Console.WriteLine("Номер телефона введен корректно!");
        }
        else
        {
            Console.WriteLine("Номер телефона должен состоять только из цифр.");
        }
    }

}
static void CheckEmail()
{
    Console.WriteLine("Введите вашу эл.почту");
    string email = Console.ReadLine();
    if (email.Contains("@") && email.Contains(".") && email.IndexOf('@') > 0 && email.IndexOf('.') > email.IndexOf('@'))
    {
        Console.WriteLine("Ваша почта верна");
    }
    else
    {
        Console.WriteLine("Ваша почта не верна");
    }

}
Console.WriteLine("\nВыберите, что вы хотите проверить: ");
Console.WriteLine("1. Номер телефона");
Console.WriteLine("2. email");
int choice = int.Parse(Console.ReadLine());
switch (choice)
{
    case 1:
        CheckPhoneNum();
        break;
    case 2:
        CheckEmail();
        break;
}
    */
    /*//task 23
public class PasswordGenerator
{
    public static string GeneratePassword(int length, bool useLowercase, bool useUppercase, bool useNumbers, bool useSpecial)
    {
        Random random = new Random();
        if (length <= 0)
            throw new ArgumentException("Длина пароля должна быть положительным числом");

        char[] password = new char[length];
        string charsToUse = "";

        if (useLowercase) charsToUse += "abcdefghijklmnopqrstuvwxyz";
        if (useUppercase) charsToUse += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        if (useNumbers) charsToUse += "0123456789";
        if (useSpecial) charsToUse += "!@#$%^&*()-_=+";

        for (int i = 0; i < length; i++)
        {
            password[i] = charsToUse[random.Next(charsToUse.Length)];
        }

        return new string(password);
    }
    static void Main()
    {
        Console.WriteLine("Введите желаемую длину пароля");
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine("Далее выбирайте true/false");
        Console.WriteLine("Использовать маленькие буквы?");
        bool useLowercase = bool.Parse(Console.ReadLine());
        Console.WriteLine("Использовать большие буквы?");
        bool useUppercase = bool.Parse(Console.ReadLine());
        Console.WriteLine("Использовать цифры?");
        bool useNumbers = bool.Parse(Console.ReadLine());
        Console.WriteLine("Использовать специальные символы");
        bool useSpecial = bool.Parse(Console.ReadLine());
        string password = PasswordGenerator.GeneratePassword(length, useLowercase, useUppercase, useNumbers, useSpecial);
        Console.WriteLine("Вот ваш пароль " + password);
    }
}
*/
/*class magazine
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество покупок: ");
        int count = Convert.ToInt32(Console.ReadLine());

        List<Purchase> purchases = new List<Purchase>();

        for (int i = 0; i < count; i++)
        {
            Console.Write($"Введите название {i + 1} покупки: ");
            string name = Console.ReadLine();

            Console.Write($"Введите стоимость {i + 1} покупки: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            purchases.Add(new Purchase(name, price));
        }

        decimal total = 0;
        decimal vat = 0;

        Console.WriteLine("Чек:");
        foreach (var purchase in purchases)
        {
            Console.WriteLine($"{purchase.Name} - {purchase.Price} руб.");

            total += purchase.Price;
            vat += purchase.Price * 0.2m; // 20% НДС
        }

        Console.WriteLine($"Общая сумма: {total} руб.");
        Console.WriteLine($"НДС: {vat} руб.");
        Console.WriteLine($"Итого: {total + vat} руб.");
    }
}
class Purchase
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Purchase(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}*/
////26 
/*using System;

class TimeCalculator
{
    static void Main(string[] args)
    {
        Console.Write("Введите первое время (часы и минуты через пробел): ");
        string[] time1 = Console.ReadLine().Split(' ');
        int hours1 = Convert.ToInt32(time1[0]);
        int minutes1 = Convert.ToInt32(time1[1]);

        Console.Write("Введите второе время (часы и минуты через пробел): ");
        string[] time2 = Console.ReadLine().Split(' ');
        int hours2 = Convert.ToInt32(time2[0]);
        int minutes2 = Convert.ToInt32(time2[1]);

        Console.Write("Выберите операцию (+ или -): ");
        string operation = Console.ReadLine();

        if (operation == "+")
        {
            AddTime(hours1, minutes1, hours2, minutes2);
        }
        else if (operation == "-")
        {
            SubtractTime(hours1, minutes1, hours2, minutes2);
        }
        else
        {
            Console.WriteLine("Неправильная операция");
        }
    }

    static void AddTime(int hours1, int minutes1, int hours2, int minutes2)
    {
        int totalMinutes = minutes1 + minutes2;
        int totalHours = hours1 + hours2 + totalMinutes / 60;
        totalMinutes %= 60;

        Console.WriteLine($"Результат: {totalHours} часов {totalMinutes} минут");
    }

    static void SubtractTime(int hours1, int minutes1, int hours2, int minutes2)
    {
        int totalMinutes = minutes1 - minutes2;
        int totalHours = hours1 - hours2;

        if (totalMinutes < 0)
        {
            totalMinutes += 60;
            totalHours--;
        }

        Console.WriteLine($"Результат: {totalHours} часов {totalMinutes} минут");
    }
}*/
////27
/*using System;
class QuadraticEquationSolver
{
    static void Main(string[] args)
    {
        Console.Write("Введите коэффициент a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите коэффициент b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите коэффициент c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        Solve(a, b, c);
    }

    static void Solve(double a, double b, double c)
    {
        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("Уравнение имеет бесконечно много решений");
                }
                else
                {
                    Console.WriteLine("Уравнение не имеет решений");
                }
            }
            else
            {
                double root = -c / b;

                Console.WriteLine($"Корень уравнения: x = {root}");
            }
        }
        else
        {
            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                Console.WriteLine($"Корни уравнения: x1 = {root1}, x2 = {root2}");
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);

                Console.WriteLine($"Корень уравнения: x = {root}");
            }
            else
            {
                Console.WriteLine("Уравнение не имеет вещественных корней");
            }
        }
    }
}*/
/*////28
using System;

class LinearSystemSolver
{
    static void Main(string[] args)
    {
        Console.Write("Введите коэффициент a1: ");
        double a1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите коэффициент b1: ");
        double b1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите коэффициент c1: ");
        double c1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите коэффициент a2: ");
        double a2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите коэффициент b2: ");
        double b2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите коэффициент c2: ");
        double c2 = Convert.ToDouble(Console.ReadLine());

        SolveSystem(a1, b1, c1, a2, b2, c2);
    }

    static void SolveSystem(double a1, double b1, double c1, double a2, double b2, double c2)
    {
        double determinant = a1 * b2 - a2 * b1;

        if (determinant == 0)
        {
            if (a1 * c2 - a2 * c1 == 0 && b1 * c2 - b2 * c1 == 0)
            {
                Console.WriteLine("Система имеет бесконечно много решений");
            }
            else
            {
                Console.WriteLine("Система не имеет решений");
            }
        }
        else
        {
            double x = (b2 * c1 - b1 * c2) / determinant;
            double y = (a1 * c2 - a2 * c1) / determinant;

            Console.WriteLine($"Решение системы: x = {x}, y = {y}");
        }
    }
}*/
////29
/*using System;
using System.IO;

class DiskMonitoring
{
    static void Main(string[] args)
    {
        DriveInfo[] drives = DriveInfo.GetDrives();

        foreach (DriveInfo drive in drives)
        {
            if (drive.IsReady)
            {
                Console.WriteLine($"Диск: {drive.Name}");
                Console.WriteLine($"Тип диска: {drive.DriveType}");
                Console.WriteLine($"Общий размер: {GetFileSize(drive.TotalSize)}");
                Console.WriteLine($"Свободное место: {GetFileSize(drive.AvailableFreeSpace)}");
                Console.WriteLine($"Занятое место: {GetFileSize(drive.TotalSize - drive.AvailableFreeSpace)}");
                Console.WriteLine();
            }
        }
    }

    static string GetFileSize(long size)
    {
        if (size < 1024)
        {
            return $"{size} байт";
        }
        else if (size < 1024 * 1024)
        {
            return $"{size / 1024} КБ";
        }
        else if (size < 1024 * 1024 * 1024)
        {
            return $"{size / (1024 * 1024)} МБ";
        }
        else
        {
            return $"{size / (1024 * 1024 * 1024)} ГБ";
        }
    }
}*/
//30
/*using System;
using System.IO;

class FileManager
{
    static void Main(string[] args)
    {
        Console.WriteLine("Файловый менеджер");
        Console.WriteLine("------------------");

        while (true)
        {
            Console.WriteLine("1. Создать файл");
            Console.WriteLine("2. Удалить файл");
            Console.WriteLine("3. Копировать файл");
            Console.WriteLine("4. Переместить файл");
            Console.WriteLine("5. Выход");

            Console.Write("Выберите операцию: ");
            int operation = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    CreateFile();
                    break;
                case 2:
                    DeleteFile();
                    break;
                case 3:
                    CopyFile();
                    break;
                case 4:
                    MoveFile();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Неправильный выбор. Попробуйте еще раз.");
                    break;
            }
        }
    }

    static void CreateFile()
    {
        Console.Write("Введите имя файла: ");
        string fileName = Console.ReadLine();

        try
        {
            using (FileStream file = File.Create(fileName))
            {
                Console.WriteLine("Файл создан успешно.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка создания файла: " + ex.Message);
        }
    }

    static void DeleteFile()
    {
        Console.Write("Введите имя файла: ");
        string fileName = Console.ReadLine();

        try
        {
            File.Delete(fileName);
            Console.WriteLine("Файл удален успешно.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка удаления файла: " + ex.Message);
        }
    }

    static void CopyFile()
    {
        Console.Write("Введите имя исходного файла: ");
        string sourceFileName = Console.ReadLine();

        Console.Write("Введите имя целевого файла: ");
        string targetFileName = Console.ReadLine();

        try
        {
            File.Copy(sourceFileName, targetFileName);
            Console.WriteLine("Файл скопирован успешно.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка копирования файла: " + ex.Message);
        }
    }

    static void MoveFile()
    {
        Console.Write("Введите имя исходного файла: ");
        string sourceFileName = Console.ReadLine();

        Console.Write("Введите имя целевого файла: ");
        string targetFileName = Console.ReadLine();

        try
        {
            File.Move(sourceFileName, targetFileName);
            Console.WriteLine("Файл перемещен успешно.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка перемещения файла: " + ex.Message);
        }
    }
}*/
//31
/*using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class JsonProcessor
{
    static void Main(string[] args)
    {
        string jsonFilePath = "data.json";

        try
        {
            string json = File.ReadAllText(jsonFilePath);
            List<Data> data = JsonConvert.DeserializeObject<List<Data>>(json);

            Console.WriteLine("Данные из JSON-файла:");
            Console.WriteLine("------------------------");

            Console.WriteLine("| Имя | Возраст | Город |");
            Console.WriteLine("| --- | --- | --- |");

            foreach (Data item in data)
            {
                Console.WriteLine($"| {item.Name} | {item.Age} | {item.City} |");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка чтения JSON-файла: " + ex.Message);
        }
    }
}

public class Data
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
}
*/
