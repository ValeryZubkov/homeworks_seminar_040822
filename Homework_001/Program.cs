//По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine("Ведите Первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите Второе число: ");
int numberB = int.Parse(Console.ReadLine());
if(numberA == numberB * numberB)
{
  Console.WriteLine("Ура! Первое число является квадратом Второго.");
}
else
{
  Console.WriteLine("К сожалению, Первое число не является квадратом Второго.");
}