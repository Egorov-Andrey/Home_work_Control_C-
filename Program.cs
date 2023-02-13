int[] array = {674, 1, 897, 25};

int n = array.Length;

int index = 0;

while (index < n)
{

    if(array[index] < 100)
    {
        Console.WriteLine(array[index]);
    }
    index++;
}



