Console.Write("Введите трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a>99)

Console.WriteLine("Третья цифра в числе "+a.ToString()+" это "+a.ToString()[2]);

else

Console.WriteLine("Третей цифры нету");

