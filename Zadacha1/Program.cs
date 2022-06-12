// Показать натуральные числа от M до N, N и M заданы
void NumbersFromMtoN (int M, int N)
{
    Console.Write(M + " ");
    if (M==N) return;
    M++;
    NumbersFromMtoN(M,N);
}
NumbersFromMtoN(1,20);

