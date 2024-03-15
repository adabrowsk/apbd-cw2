// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Modyfikcja 1");
Console.WriteLine("Modyfikcja 2");
Console.WriteLine("Modyfikcja 3");

static double GetAverageOfTab(int[] numbers)
{
    int value = 0;
    foreach (var number in numbers)
    {
        value += number;
    }

    return (double) value / numbers.Length;
}

int[] numbers = {1, 2, 3, 4};
double average = GetAverageOfTab(numbers);
Console.WriteLine(average);

static int GetMax(int[] numbers)
{
    int max = numbers[0];
    foreach (var number in numbers)
    {
        if (number > max)
        {
            max = number;
        }
    }

    return max;
}

int[] tab = {9, 3, 7, 23, 56, 4, 0};
int max = GetMax(tab);
Console.WriteLine(max);
