// Task 41. User enter number M. Count, hom much numbers > 0 user entered.

Console.Clear();

Console.WriteLine("Enter count of numbers: ");
int count = int.Parse(Console.ReadLine() ?? "");

int [] numbers = new int [count];

Console.Write($"Колличество положительных чисел : {HowMuchPositive(numbers)}");

// ------------------Logic-------------------------------------------------------
int HowMuchPositive(int[] numbers) //Метод подсчитывает и возвращает кол-во чисел больше 0
{
int counters = 0;
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine("Enter number: ");
    numbers[i] = int.Parse(Console.ReadLine() ?? "");
    if (numbers[i] > 0) counters += 1;
}
return counters;
}