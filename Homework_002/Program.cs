// По заданному номеру дня недели вывести его название
Console.WriteLine("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine());
string mon = "Понедельник";
string tue = "Вторник";
string wed = "Среда";
string thu = "Четверг";
string fri = "Пятница";
string sat = "Суббота";
string sun = "Воскресенье";
string result = "";
if(number>=1 && number<=7)
{  
    if(number == 1) result = mon;
    if(number == 2) result = tue;
    if(number == 3) result = wed;
    if(number == 4) result = thu;
    if(number == 5) result = fri;
    if(number == 6) result = sat;
    if(number == 7) result = sun;
    Console.WriteLine("Вы ввели " + number+"-й день недели - "+result+".");   
}
else
{
    Console.WriteLine("Такого дня недели не существует.");
}
