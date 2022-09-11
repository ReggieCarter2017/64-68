string Recursive(int n)
{
    if (n == 0) return string.Empty;
    else return $"{n} {Recursive(n-1)}";
    
}



Console.WriteLine(Recursive(4));