int GetSecondDigitNumber(int number){
    while (number > 99)
    {
        number = number / 10;
    }

    return number % 10;
}

int number;

Console.WriteLine("Эта программа принимает на вход число и показывает вторую цифру этого числа.");
Console.Write("Введите число: ");
number = int.Parse(Console.ReadLine()!);
if (number > 9) {
    Console.WriteLine($"У числа {number} вторая цифра: {GetSecondDigitNumber(number)}");
}
else {
    Console.WriteLine($"У числа {number} нет второй цифры!!!");
}