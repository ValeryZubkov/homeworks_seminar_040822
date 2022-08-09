// Показать числа от -N до N
Console.WriteLine("Ведите число N: ");
int number = int.Parse(Console.ReadLine());
int count = -number;
while(count <= number)
{
    Console.Write(" " + count + " ");
    count++;
}