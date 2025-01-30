      //حساب الاعداد الاولية بين x و y
            Console.Write("entr (X): ");
            int X = int.Parse(Console.ReadLine());
            Console.Write("entr (Y): ");
            int Y = int.Parse(Console.ReadLine());
            int a = X; int b = Y;

            for (int m = a + 1 ; m < Y ; m++)
            {
                int t=1;
                for(int i=2;i< m;i++)
                    if (m % i == 0)
                    {
                        t = 0;
                        continue;
                    }
                if (t == 1)
                    Console.WriteLine(m);
            }
 
                Console.ReadKey();