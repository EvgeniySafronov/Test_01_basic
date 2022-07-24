string[] array = { "Hello", "Cat", "Russia", "Case", "Bat", "Mickey" };
for (int i = 0; i < array.Length; i++)
{
    int n = 0;
     array[n] = array[i];
    Console.Write(array[n] + " ");
    n++;
}
for (int i = 0; i < array.Length; i++)
{
    int n = 0;
    if (array[i].Length <=3)
    {
        array[n] = array[i];
        Console.WriteLine(array[n]);
        n++;
    }
}