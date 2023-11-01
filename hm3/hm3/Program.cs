using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] labyrinth = {
      {1, 1, 1, 1, 1, 1, 1},
      {1, 0, 0, 0, 0, 0, 1},
      {1, 0, 1, 1, 1, 0, 1},
      {0, 0, 0, 0, 1, 0, 0},
      {1, 1, 0, 0, 1, 1, 1},
      {1, 1, 1, 0, 1, 1, 1},
      {1, 1, 1, 0, 1, 1, 1}
    };

        FindExits(labyrinth, 1, 1);
    }

    static void FindExits(int[,] labyrinth, int i, int j)
    {
        if (i < 0 || i >= labyrinth.GetLength(0) ||
            j < 0 || j >= labyrinth.GetLength(1) ||
            labyrinth[i, j] == 1)
            return;

        if (i == 0 || i == labyrinth.GetLength(0) - 1 ||
            j == 0 || j == labyrinth.GetLength(1) - 1)
        {
            Console.WriteLine($"Выход найден в точке [{i}, {j}]");
            return;
        }

        labyrinth[i, j] = 1; // помечаем как посещенную

        FindExits(labyrinth, i - 1, j); // вверх 
        FindExits(labyrinth, i, j + 1); // вправо
        FindExits(labyrinth, i + 1, j); // вниз
        FindExits(labyrinth, i, j - 1); // влево
    }
}





/*int[,] lab = new int[,]
{
    {1, 1, 1, 1, 1, 1, 1 },
    {1, 0, 0, 0, 0, 0, 1 },
    {1, 0, 1, 1, 1, 0, 1 },
    {0, 0, 0, 0, 1, 0, 0 },
    {1, 1, 0, 0, 1, 1, 1 },
    {1, 1, 1, 0, 1, 1, 1 },
    {1, 1, 1, 0, 1, 1, 1 }
};

static int HasExit(int i, int j, int[,] lab)
{
    if (lab[i, j] == 0 && (i == 0 || j == 0 || i == lab.GetLength(0) - 1 || j == lab.GetLength(1) - 1))
    {
        return 1;
    }
    int count = 0;
    if (lab[i, j] != -1)
    {
        lab[i, j] = -1;// помечаем как посещенную

        if (i > 0) count += HasExit(i - 1, j, lab);
        if (i < lab.GetLength(0) - 1) count += HasExit(i + 1, j, lab);
        if (j > 0) count += HasExit(i, j - 1, lab);
        if (j < lab.GetLength(1) - 1) count += HasExit(i, j + 1, lab);

        return count;
    }
    return 0;
}

int exit1 = HasExit(1, 1, lab);
Console.WriteLine("Number of exits: " + exit1);
*/