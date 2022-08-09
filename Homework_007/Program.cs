//Показать вторую цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
if(number > 99 && number < 1000)
{
   int digitLast = number % 100 / 10;
   Console.WriteLine("Второй цифрой введенного Вами трехзначного числа является: " + digitLast);
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число. Повторите попытку.");
}