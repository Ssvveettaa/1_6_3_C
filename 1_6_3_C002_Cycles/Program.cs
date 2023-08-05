// Цикл "for":
string str = String.Empty; // = ""
for (int i = 0; i < 3; i++)
{
    str += "Склейка";
}
Console.WriteLine(str);

// Вложенный цикл "for":
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.Write($"{i, 2} x {j} ={i * j, 3}  ");
    }
    Console.WriteLine();
}
