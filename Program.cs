int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
int[,] matrix2 = { { 5, 6 }, { 7, 8 } };
int[,] matrix3 = new int[2, 2];
int sum = 0;
Console.WriteLine("matrix3=");
string string1 = "";
for(int i = 0; i < 2; i++)
{
    for(int j = 0; j < 2; j++)
    {
        sum = 0;
        for( int k = 0; k < 2; k++)
        {
            sum = sum + matrix1[i, k] * matrix2[k, j];
        }
        matrix3[i, j] = sum;
        string1 += sum + " ";
    }
    Console.WriteLine(string1);
    string1 = "";
}
Console.ReadKey();
