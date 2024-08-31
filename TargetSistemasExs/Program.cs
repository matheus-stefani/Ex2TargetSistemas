namespace TargetSistemasExs
{
    using static Console;
    internal class Program
    {
   

        static void Main(string[] args)
        {

            Write("\nInforme um numero:");
            int num = -1;
            do
            {
                try
                {
                    num = Int32.Parse(ReadLine());

                    if (num < 0) { WriteLine("O numero passado:" + num + ", não é um fib!!!"); break; }

                    if (num == 0 || num == 1) { WriteLine("O numero passado:" + num + ", é um fib!!!"); break; }

                    int fib1 = 0;
                    int fib2 = 1;
                    bool isFib = false;
                    while (num > fib1)
                    {

                        int fibA = fib2;
                        fib2 += fib1;
                        fib1 = fibA;

                        if (fib1 == num)
                        {
                            Write("O numero passado:" + num + ", é um fib!!!");
                            isFib = true;
                            break;
                        }


                    }

                    if(!isFib) Write("O numero passado:" + num + ", não é um fib!!!");

                }
                catch {
                    WriteLine("Isso não é um numero inteiro :((");
                    Write("\nInforme um numero:");
                    num = -1;
                }

            } while ( num == -1);


            WriteLine("\nFim do programa!!");

        }
            


        }
    }

