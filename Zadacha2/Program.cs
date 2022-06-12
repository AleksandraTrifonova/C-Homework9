// Найти сумму элементов от M до N, N и M заданы.
int SumElements (int m, int n)
{ 
    if(m == n) return n;
    else return m + SumElements(m+1, n); 
}
Console.WriteLine("Сумма элементов от M до N равна: ");
Console.Write(SumElements(1, 10));
