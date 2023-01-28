int[] array = {21, 32, 43, 4, 18, 36, 18, 28};

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }   
    index++;
}