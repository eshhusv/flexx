//Вариант 20
int mainDiagonal, allNumSum = 0;
int mainDiagonalNum = 0;
int assigment(int[,] sub)
{
    int sum = 0;
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            if (i != j) sum += sub[i,j];
        }
    }
    return sum;
}
int[,] mas = new int[5,5];
Random r = new Random();
for (int i = 0; i < 5; i++)
{
    for(int j = 0; j < 5; j++)
    {
        mas[i, j] = r.Next(20, 40);
        Console.Write(mas[i,j]+" ");
    }
    Console.WriteLine();
}

Console.WriteLine(assigment(mas));