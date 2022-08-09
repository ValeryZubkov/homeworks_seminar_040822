// Удалить вторую цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
if(number > 99 && number < 1000)
{
   int digitFirst = number / 100;
   int digitLast = number % 10;
   int result = digitFirst * 10 + digitLast;
   Console.WriteLine("При удалении второй цифры трехзначного числа " + number + " получим следующее значение: " + result);
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число. Повторите попытку.");
}