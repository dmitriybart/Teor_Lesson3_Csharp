// FOR цикл
//string Method4(int count, string text)
//{
   //int i = 0;
    //string result = String.Empty;
    //for (int i = 0; i < count; i++)
    //{
    //    result = result + text;
    //}
    //return result;
//}

// Цикл в цикле (выводим таблицу умножения)
for (int i = 2; i<=10; i++)
{
    for (int j = 2; j <= 10 ; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}