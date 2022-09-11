uint Ackermann(uint a, uint b)
{
  if (a == 0) return b + 1;
  else
  {
    if ((a != 0) && (b == 0)) return Ackermann(a - 1, 1);
    else return Ackermann(a - 1, Ackermann(a, b - 1));
  }
}
Console.Write(Ackermann(2, 2));
