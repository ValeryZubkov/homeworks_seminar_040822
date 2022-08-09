//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int number = new Random().Next(10, 100);
int digitFirst = number / 10;
int digitSecond = number % 10;
if(digitFirst > digitSecond)
{
  Console.WriteLine("Наибольшей цифрой случайно выбранного числа " + number + " является: " + digitFirst);  
}
else
{
  if(digitFirst != digitSecond)
  {
  Console.WriteLine("Наибольшей цифрой случайно выбранного числа " + number + " является: " + digitSecond);
  }
  else
  {
    Console.WriteLine("У случайно выбранного числа " + number + " нет наибольшей цифры, т.к. они одинаковы и равны: " + digitFirst);
  }
}