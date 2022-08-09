partial class Program
{
    static string[] FillFirstArray(string[] array, ref int count)
    {
        Console.WriteLine();

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Введи элемент, ну пожалуйста!");
            array[i] = Console.ReadLine();
            Console.WriteLine();
            if (array[i].Length <= 3) count++;
        }
        Console.WriteLine();

        return array;
    }

    static string[] FillSecondArray(string[] firstArray, string[] secondArray)
    {
        int j = 0;
        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i].Length <= 3)
            {
                secondArray[j] += firstArray[i];
                j++;
            }
        }
        return secondArray;
    }
}