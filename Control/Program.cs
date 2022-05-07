public class Test  // Написать программу, которая из имеющегося массива строк формирует массив из строк,
                   // длина которых меньше либо равна 3 символа.
                   // Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
                   // При решении не рекомендуется пользоваться коллекциями. Лучше обойтись исключительно массивами.
{

    static void Main(string[] args)
    {


        string[] initialArray = new string[] { "Boyfriend", "123", "Dmitry<3^", "Zaratrustra", "Plachy", "Lust-Ga", "LastofBeyond", "Dead4Left", "Bludnik", "DrMish", "Dickens", "834", "shma", "ra"};

        // метода основного вызов
        string[] newArray = CreateNewArray(initialArray); 

        // нового элемента массива печать
        Console.WriteLine(String.Join(" ", newArray)); 
    }

    public static string[] CreateNewArray(string[] array)
    {
        string[] newArray;

        int counter = 0;

        // количества строк подсчет длины меньшей трех иль равной таковой
        foreach (var s in array) 
        {
            if (s.Length <= 3)
            {
                counter++;
            }
        }

        // нового строкового массива инициализация 
        newArray = new string[counter]; 
        counter = 0;

        // в массив новых строк добавление
        foreach (var s in array) 
        {
            if (s.Length <= 3)
            {
                newArray[counter++] = s;
            }
        }

        return newArray; 
    }
}
