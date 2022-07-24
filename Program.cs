string[] array = { "Hello", "Cat", "Russia", "Case", "Bat", "Mickey" };
Console.WriteLine("Изначальный заданный массив:");
for (int i = 0; i < array.Length; i++)
{
    int n = 0;
     array[n] = array[i];
    Console.Write(array[n] + " ");
    n++;
}