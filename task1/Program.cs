// Вид 1 (Ничего не возвращают и ничего не принимают)
void Method1()
{
    Console.WriteLine("Автор - Бартенев Дмитрий");
} 
//Method1();

// Вид 2 (Ничего не возвращают, но принмают значения)
void Method2(string msg)
{
    Console.WriteLine (msg);
}
//Method2("Текст сообщения");
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
    Console.WriteLine (msg);
    i++;
    }
}
//Method21(msg: "Текст сообщения", count: 4);

//Вид 3 (Что-то возвращают, но ничего не принимают)
int Method3()
{
    return DateTime.Now.Year;
}
//int year = Method3();
//Console.WriteLine(year);

//Вид 4 (Что-то возвращают и что-то принимают)
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while(i < count)
    {
        result = result + text;
        i++;

    }
    return result;
}
string res = Method4(10, "qwerty");
Console.WriteLine(res);