using System;

namespace Minimum_Steps
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                string str = Console.ReadLine();
                string[] values = str.Split(' ');
                int k = int.Parse(values[0]);
                int m = int.Parse(values[1]);
                int n = int.Parse(values[2]);
                long result = 0;

                if (k == m)
                {
                    result = 0;
                    Console.WriteLine(result);
                }

                if (k > m)
                {
                    Console.WriteLine(DiffStep(k, m));
                }

                if (k < m)
                {
                    if (m % n != 0)
                    {
                        if (k < m / n + 1)
                        {
                            while (k < m / n + 1)
                            {
                                k = k * n;
                                result++;
                            }

                            result += DiffStep(k, m / n + 1);

                            while (k < m)
                            {
                                k = k * n;
                                result++;
                            }

                            result += DiffStep(k, m);
                            Console.WriteLine(result);
                            break;
                        }

                        if (k > m / n + 1)
                        {
                            result += DiffStep(k, m / n + 1);

                            while (k < m)
                            {
                                k = k * n;
                                result++;
                            }

                            result += DiffStep(k, m);
                            Console.WriteLine(result);
                            break;
                        }
                    }

                    if (m % n == 0)
                    {
                        if (k < m / n)
                        {
                            while (k < m / n)
                            {
                                k = k * n;
                                result++;
                            }

                            result += DiffStep(k, m / n);

                            while (k < m)
                            {
                                k = k * n;
                                result++;
                            }

                            result += DiffStep(k, m);
                            Console.WriteLine(result);
                            break;
                        }

                        if (k > m / n)
                        {
                            result += DiffStep(k, m / n);

                            while (k < m)
                            {
                                k = k * n;
                                result++;
                            }

                            result += DiffStep(k, m);
                            Console.WriteLine(result);
                            break;
                        }
                    }
                }

                t--;
            }
        }
        public static long DiffStep(int k, int m)
        {
            int dif = k - m;
            int value = dif / 2;
            if (dif % 2 == 0) return (value);
            else return (value + 1);
        }
    }
    
}
