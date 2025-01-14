using System;

void bubble_sort(int[] x)
{
    for (int i = 0; i < x.Length; i++)
    {
        for (int j = 0; j < x.Length; j++)
        {
            if (x[i] < x[j])
            {
                int tmp = x[j];
                x[j] = x[i];
                x[i] = tmp;
            }
        }
    }
}

int[] x = { 5, 3, 2, 8, 11, -2 };
bubble_sort(x);

for (int i = 0; i < x.Length; i++)
{
    Console.WriteLine(x[i]);
}



