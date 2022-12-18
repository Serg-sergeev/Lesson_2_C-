// Эта программа принимает на вход число и показывает тетью цифру этого числа 
// или показывает что третей цифры нет.

int GetSecondDigitNumber(int number){
    while (number > 999)
    {
        number = number / 10;
    }

    return number % 10;
}

int number;

Console.WriteLine("Эта программа принимает на вход число и показывает тетью цифру этого числа.");
Console.Write("Введите число: ");
number = int.Parse(Console.ReadLine()!);
if (number > 99) {
    Console.WriteLine($"У числа {number} третья цифра: {GetSecondDigitNumber(number)}");
}
else {
    Console.WriteLine($"У числа {number} нет третьей цифры!!!");
}