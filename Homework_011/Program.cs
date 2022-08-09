// Найти третью цифру числа или сообщить, что её нет

Console.WriteLine("Введите любое целое число: ");
string numberText = Console.ReadLine();
int count = numberText.Length;
int number = int.Parse(numberText);
if(number > -100 && number < 100)
{
    Console.WriteLine("В Ващем числе отсутствует 3-я цифра. Повторите попытку.");
} 
else
{
    if (number >= 100)
    {                           //обрабатываются любые положительные  числа  длиной от 3х цифр;
      int parametr = 1;        
      int index = 0;
      while(index < (count - 3)) //цифра 3 в условии работает при числе от 3-х цифр, сюда как разз и попадают такие числа; поменяв ее, мы можем найти любую цифру числа.
      {
      parametr = parametr * 10;  // найдена закономерность изменения переменной parametr при увеличении разряда чисел.
      index++;
      }

    int digitThird = number / parametr % 10;
    Console.WriteLine("Третьей цифрой Вашего числа является " + digitThird); 

    }
    else                              
    {                              // обрабатываются отрицательные числа
     int parametr = 1;             
     int index = 0;
     while(index < (count - 4))  // цифра 4 сменила цифру 3 из-за наличия знака "-" в числе, длина строки которого посчиталась вместе с минусом.
     {
     parametr = parametr * 10;
     index++;
     }

     int digitThird = -number / parametr % 10; 
     Console.WriteLine("Третьей цифрой Вашего числа является " + digitThird); 

    }
}

