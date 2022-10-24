// Task 43. Write programm that finds the intersection point of two staight lines
// y = k1 * x + b1, y = k2 * x + b2;   b1, k1, b2, k2 - user inputs

Console.Clear();

//точка пересечения - решить систеу из двух уравнений, выразить х через b1 и b2 и ее 
//подставить хоть в 1 хоть во 2 уравнение, тем самым получим y

double [] numbers = new double [4];
FillArray(numbers);

Coordination(numbers);

// ------------------Logic-------------------------------------------------------
double[] FillArray(double[] numbers) //Заполняем массив введеными числами
{
    for (int i = 0; i < 4; i++)
    {
    Console.WriteLine("Введите число: ");
    numbers[i] = double.Parse(Console.ReadLine() ?? "");
    }
    return numbers;
}

void Coordination(double[] numbers) //Находим точку пересечения
{
    double y = 0;
    double x = 0;
    double i = -100;
    while (i < 100)
    {       //решение системы уравнений 2 5 4 9
            // y = b1 * x + k1    2x +  5     -2x 4 x = -2
            // y = b2 * x + k2    4x +  9
    if ((numbers[0] * i) + numbers[1] == (numbers[2] * i) + numbers[3])
        Console.WriteLine(i);
        x = i;
        y = (numbers[2] * x) + numbers[3];       
        Console.WriteLine($"b1 = {numbers[0]}, k1 = {numbers[1]}, b2 = {numbers[2]}, k2 = {numbers[3]} -> ({x};{y})");
        break;
    }
}

//Не получилось(

