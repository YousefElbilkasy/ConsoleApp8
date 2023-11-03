internal class Program
{
    private static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] splitted = input.Split();
        int[] intsSplitted = new int[splitted.Length];

        for (int i = 0; i < splitted.Length; i++)
        {
            intsSplitted[i] = int.Parse(splitted[i]);
        }

        int max = intsSplitted[0];
        int min = intsSplitted[0];
        int avr = 0;

        for (int i = 0; i < splitted.Length; i++)
        {
            if (intsSplitted[i] < min)
            {
                min = intsSplitted[i];
            }
            else if (intsSplitted[i] > max)
            {
                max = intsSplitted[i];
            }
        }

        for (int i = 0; i < splitted.Length; i++)
        {
            if (intsSplitted[i] != max && intsSplitted[i] != min)
            {
                avr = intsSplitted[i];
            }
        }

        if (intsSplitted[0] == intsSplitted[1])
        {
            avr = intsSplitted[1];
        }

        if (intsSplitted[1] == intsSplitted[2])
        {
            avr = intsSplitted[1];
        }

        if (intsSplitted[0] == intsSplitted[2])
        {
            avr = intsSplitted[2];
        }

        Console.WriteLine(min);
        Console.WriteLine(avr);
        Console.WriteLine(max);
        Console.WriteLine();

        for (int i = 0; i < splitted.Length; i++)
        {
            Console.WriteLine(intsSplitted[i]);
        }
    }
}