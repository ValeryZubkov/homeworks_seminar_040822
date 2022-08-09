// Выяснить является ли число чётным

Console.WriteLine("Ведите число для проверки: ");
int number = int.Parse(Console.ReadLine());
if(number%2 == 0)
{
  Console.WriteLine("Введенное Вами число " + number+ " яляется четным!");
}
else
{
  Console.WriteLine("К сожалению, введенное Вами число " + number+ " не яляется четным.");  
}