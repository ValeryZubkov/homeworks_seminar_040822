// Найти третью цифру числа или сообщить, что её нет

Console.WriteLine("Введите любое целое число: ");
int number = int.Parse(Console.ReadLine());
int Digitsnumber(int numb)   // функция подсчета количества цифр в числе
{
int digitNumber = 1;
while(numb / 10 >= 1 || numb / 10 <= -1)
{
    numb = numb / 10;
    digitNumber = digitNumber + 1;
}
return digitNumber;
}

if(number > -100 && number < 100)
{
    Console.WriteLine("В Вашем числе отсутствует 3-я цифра. Повторите попытку.");
} 
else
{                            
      int parametr = 1;        
      int index = 0;
      while(index < (Digitsnumber(number) - 3)) //цифра 3 в условии работает при числе от 3-х цифр, сюда как раз и попадают такие числа; поменяв ее, мы можем найти любую цифру числа.
      {
      parametr = parametr * 10;  // найдена закономерность изменения переменной parametr при увеличении разряда чисел.
      index++;
      }
    if(number > 99)                  //проверка на положительное-отрицательное
    {
    int digitThird = number / parametr % 10;
    Console.WriteLine("Третьей цифрой Вашего числа является: " + digitThird);     
    }
    else
    {
    int digitThird = -number / parametr % 10;
    Console.WriteLine("Третьей цифрой Вашего числа является: " + digitThird);  
    } 
}

