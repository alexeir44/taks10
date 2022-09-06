// Инициализация переменных
string? UserNumber;
int i, number;

//начало программы
Console.WriteLine("Введи трехзначное число");
UserNumber = Console.ReadLine();
i = 0;

foreach (char c in UserNumber)
    i++;

if ((i>2)&&(int.TryParse(UserNumber, out number)))
    Console.Write("Значение 3 разряда = " + UserNumber[2]);
else
    Console.Write("Ошибка ввода");