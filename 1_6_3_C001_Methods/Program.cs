// Вид 1:
void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1(); // Вызов метода 1.

// Вид 2:
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения."); // Вызов метода 2.

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; // Инкремент – увеличение счётчика на 1. Декремент – уменьшение счётчика на 1.
    }
}
// Именованные аргументы, когда явно указано какому аргументу какое значение передать,
// актуально если методы принимают несколько аргументов.
Method21(msg: "Текст.", count: 2); // Вызов метода 2.1.
Method21(count: 2, msg: "Новый текст."); // Аргументы можно писать не по порядку.

// Вид 3:
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3(); // Вызов метода 3.
Console.WriteLine(year);

// Вид 4:
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result += text;
        i++;
    }
    return result;
}
string res = Method4(3, "Склейка0"); // Вызов метода 4.
Console.WriteLine(res);

string Method41(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result += text;
    }
    return result;
}
string res1 = Method41(3, "Склейка1"); // Вызов метода 4.1.
Console.WriteLine(res1);
