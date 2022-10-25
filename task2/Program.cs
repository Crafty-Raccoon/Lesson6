//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

int[] InputToArray(string nums)
{
    int[] arr = Array.ConvertAll(nums.Trim().Split(' '), Convert.ToInt32);
    return arr;
}
double[] CrossingCoord(int[] arr1, int[] arr2)
{
    double b1 = arr1[0];
    double b2 = arr2[0];
    double k1 = arr1[1];
    double k2 = arr2[1];
    double[] result = new double[2];
    result[0] = (b2 - b1) / (k1 - k2);
    result[1] = (k1 * (b2 - b1)) / (k1 - k2) + b1;
    return result;
}

Console.WriteLine("Введите коэффициенты первой прямой");
int[] coeff1 = InputToArray(Console.ReadLine());

Console.WriteLine("Введите коэффициенты второй прямой");
int[] coeff2 = InputToArray(Console.ReadLine());

if ((coeff1[0] == coeff2[0]) && (coeff1[1] == coeff2[1]))
{
    Console.WriteLine("Прямые совпадают");
}
else if (coeff1[0] == coeff2[0])
{
    Console.WriteLine("Прямые параллельны");
}
else
{
    double[] result = CrossingCoord(coeff1, coeff2);

    Console.WriteLine($"{result[0]} {result[1]}");
}