// See https://aka.ms/new-console-template for more information
Console.WriteLine("введите номер дня нидели: ");
int x = Convert.ToInt32( Console.ReadLine());

if (x==1)
{
    Console.WriteLine(x+" это пнидельник ");
}
else if (x==2)
{
    Console.WriteLine(x+" это вторник ");
}
else if (x==3)
{
    Console.WriteLine(x+" это среда ");
}
else if (x==4)
{
    Console.WriteLine(x+" это четверг ");
}
else if (x==5)
{
    Console.WriteLine(x+" это пятница ");
}
else if (x==6)
{
    Console.WriteLine(x+" это суббота ");
}
else if (x==7)
{
    Console.WriteLine(x+" это воскрисенье ");
}
else
{
   Console.WriteLine(" такова дня недели нет  ");
}