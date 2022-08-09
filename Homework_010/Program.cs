// Выяснить, кратно ли число заданному, если нет, вывести остаток.
int numberConst = 4;
Console.WriteLine("Введите число для проверки его кратности числу " + numberConst + ": ");
int numberUser = int.Parse(Console.ReadLine());
int number = numberUser % numberConst;
if(number == 0)
{
    Console.WriteLine("Введенное Вами число " + numberUser + " кратно числу " + numberConst + ".");
}
else
{
    Console.WriteLine("Остаток равен " + number + " т.к. введенное Вами число " + numberUser + " не кратно числу " + numberConst + "."); 
}