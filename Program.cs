int sum = 0;
int Recursive(int m, int n)
{
    if (m <= n)
    {
        sum += m;
        m += 1;
        return Recursive(m, n);
    }
    else
    {
        return m=sum;
    }

}



Console.WriteLine(Recursive(10, 100));
