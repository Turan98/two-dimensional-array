int [,] array =
{
    {2,7,9,4,3},
    {6,3,8,12,2},
    {7,2,8,0,3}
    
};

int height = array.GetLength(0);
int weight = array.GetLength(1);
int length = array.Length;
double sum = 0;
double average_sum = 0;

for (int i = 0; i < height; i++)
{
    for (int j = 0; j < weight; j++)
    {
        Console.Write(array[i,j] + "\t");
        sum = sum + array[i,j];
    }
    Console.WriteLine();
    
    
}
Console.WriteLine();
average_sum = sum / length;
Console.WriteLine(length);
Console.WriteLine(sum);
Console.WriteLine(average_sum);

