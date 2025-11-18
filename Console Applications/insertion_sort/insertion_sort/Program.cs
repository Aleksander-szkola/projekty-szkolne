int[] a = new int[] { 5, 4, 3, 2, 1 };
Random rand = new Random();

while (true)
{
    for (int i = 0; i < a.Length; i++)
    {
        int j = rand.Next(a.Length);
        int temp = a[i];
        a[i] = a[j];
        a[j] = temp;
    }

    bool posortowane = true;
    for (int i = 1; i < a.Length; i++)
    {
        if (a[i - 1] > a[i])
        {
            posortowane = false;
            break;
        }
    }
    if (posortowane)
    {
        break;
    }
}
for (int i = 0; i < a.Length; i++)
{
    Console.WriteLine(a[i]);
}