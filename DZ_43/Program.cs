// Task 43. Write programm that finds the intersection point of two staight lines
// y = k1 * x + b1, y = k2 * x + b2;   b1, k1, b2, k2 - user inputs

//Console.Clear();

//точка пересечения - решить систеу из двух уравнений, выразить х через b1 и b2 и ее 
//подставить хоть в 1 хоть во 2 уравнение, тем самым получим y

double [] numbers = new double [4];
FillArray(numbers); //Заполняем массив введеными числами

Coordination(numbers); // Метод выводит координаты точки пересечения прямых

// ------------------Logic-------------------------------------------------------
double[] FillArray(double[] numbers) 
{
    for (int i = 0; i < 4; i++)
    {
    Console.WriteLine("Введите число: ");
    numbers[i] = double.Parse(Console.ReadLine() ?? "");
    }
    return numbers;
}

void Coordination(double[] numbers) 
{ 
    for (double i = -5.0; i < 5.00; i += 0.10) 
    {       //решение системы уравнений 5 2 9 4
            // y = k1 * x + b1    y = 5x + 2 
            // y = k2 * x + b2    y = 9x + 
        
        Math.Round(i, 1); //Не работает)
        Console.WriteLine(i);
        if (numbers[0] * i + numbers[1] == numbers[2] * i + numbers[3])
        {
            Console.WriteLine(i);
            double x = i;
            double y = (numbers[0] * x) + numbers[1];       
            Console.WriteLine($"b1 = {numbers[0]}, k1 = {numbers[1]}, b2 = {numbers[2]}, k2 = {numbers[3]} -> ({x};{y})");
            break;
        }
    }
}

//Все работает если начинать с -0.5 , но затем значения double становится 0,00000000000001


