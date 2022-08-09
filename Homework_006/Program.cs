// Показать последнюю цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
if(number > 99 && number < 1000)
{
   int digitLast = number % 10;
   Console.WriteLine("Последней цифрой введенного Вами трехзначного числа является: " + digitLast);
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число. Повторите попытку.");
}