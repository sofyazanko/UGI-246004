using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace taskexam
{ 
    internal class Program
{
    static void Main(string[] args)
    {
        int n = 1000000;
        int mod = 1000000000;

        Console.WriteLine($"S(10^6) mod 10^9={CalculateS(n, mod):D9}");//:D9 чтоюы были 9 цифр или дополн нулями вначале
        }

    static long CalculateS(int n, int mod)
    {
        long[] sigma = new long[n + 1];//массив для суммы квадр делит,n+1 потому что индексы начин с 0
        for (int d = 1; d <= n; d++)
        {
            long dmod = ((long)d * d);//сохр квадр делит 
            for (int a = d; a <= n; a += d)//находим все числа а котор дел на d нач с d и на него же увелич
            {
                sigma[a] += dmod;//доб квадр текущ делит к текущ сумм b берем остаток 

            }
        }
        long Summ = 0;
        for (int i = 1; i <= n; i++)
        {
            Summ = (Summ + (sigma[i]%mod)) % mod;//оставляем послед 9 цифр суммы
        }
        return Summ;
    }

        static long Sigma(int n)//метод для вычисл суммы квадр делит n
        {
            long sum = 0;
            for (int d = 1; d * d <= n; d++)//делители идут с 1, тк на 0 нельзя и квадр делит не превыш n
            {
                if (n % d == 0)
                {
                    sum += (long) d * d;//доб квадр дел к общ сумме
                    int pairD = n / d;//для парного делит
                    if (pairD != d)//чтоб не повторялись делители
                    {
                        sum += (long)pairD * pairD;//long чтобы если превысит
                    }
                }
            }
            return sum;
        }
    }
}




