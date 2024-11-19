Console.WriteLine("Введите номер операции:");
Console.WriteLine("1. Сложение");
Console.WriteLine("2. Вычитание");
Console.WriteLine("3. Умножение");
Console.WriteLine("4. Деление");

string input = Console.ReadLine();
int choice;
bool yamakasi = int.TryParse(input, out choice);

if (yamakasi)
{
    Console.Write("Введите первое число: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.Write("Введите второе число: ");
    int num2 = int.Parse(Console.ReadLine());

    double result = 0;
    bool andergraund = true;

    switch (choice)
    {
        case 1:
            result = num1 + num2;
            break;
        case 2:
            result = num1 - num2;
            break;
        case 3:
            result = num1 * num2;
            break;
        case 4:
            if (num2 == 0)
            {
                andergraund = false;
            }
            else
            {
                result = (double)num1 / num2;
            }
            break;
        default:
            andergraund = false;
            break;
    }

    if (andergraund)
    {
        Console.WriteLine($"Результат: {result}");
    }
    else
    {
        Console.WriteLine("Ошибка: Неверный ввод или деление на 0");
    }
}