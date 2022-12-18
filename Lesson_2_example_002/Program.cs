int GetMaxDigit(int number) {
    if (number / 10 > number % 10){
        return number / 10;
    }
    else {
        return number % 10;
    }
}

int number;

Console.WriteLine("Эта программа выводит случайное число из отрезка [10,99] и показывает наибольшею цифру.");
number = new Random().Next(10,100);
Console.WriteLine($"Сгенерировано случайное число: {number}");
Console.WriteLine($"Наибольшая цифра: {GetMaxDigit(number)}");
