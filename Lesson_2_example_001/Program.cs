int GetLastDigit(int number){
    return number % 10;
}

Console.WriteLine("Эта программа принимает на вход трехзначное число, а на выходе показывает последнюю цифру.");
Console.Write("Введите трехзначное число ");
int number = int.Parse(Console.ReadLine()!);



if (number < 100 || number >= 1000){
    Console.WriteLine("Вы ввели не трехзначное число!");
}
else {
    Console.WriteLine($"Последняя цифра числа {number} - {GetLastDigit(number)}");
}