int [] array = {11, 21, 31, 4, 54, 81, 17, 81};

int n = array.Length;
int find = 81;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}