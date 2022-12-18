string GetWeekend(int number) {
    if (number == 0 || number == 6) {
        return "выходной! УРА!!!";
    }
    else {
        return "будний день! Пора пахать!!!";
    }
}

int number;

Console.WriteLine("Эта программа принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
Console.Write("Введите число от 0 до 6: ");
number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сегодня {GetWeekend(number)}");