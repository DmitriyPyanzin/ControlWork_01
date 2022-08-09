partial class Program
{
    static void Main(string[] args)
    {
        void Zadacha()
        {
            Console.Clear();
            Console.WriteLine("Привет Дружок-пирожок! Ты вводишь сколько хочешь элементов, а я выведу массив в котором все элементы состоят из не более чем трех элементов!");
            Console.WriteLine();

            int countElementArray = 0;
            int indexNumber;

            do
            {
                Console.Write("Сколько элементов в массиве тебе нужно: ");
            }
            while (!int.TryParse(Console.ReadLine(), out indexNumber));

            string[] sourceArray = new string[indexNumber];
            FillFirstArray(sourceArray, ref countElementArray);
            string[] requiredArray = new string[countElementArray];
            FillSecondArray(sourceArray, requiredArray);

            Console.WriteLine($"Вот массив который ты ввел [" + string.Join(", ", sourceArray) + "]");
            Console.WriteLine($"Вот такой массив у меня получился [" + string.Join(", ", requiredArray) + "]");
            Console.WriteLine();
        }

        Zadacha();
    }
}