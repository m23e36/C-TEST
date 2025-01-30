//عدد فردي ام زوجي
            int x, i, t = 0;
            Console.Write("x=");
            x = Int32.Parse(Console.ReadLine());
           for(i = 2; i < x; i++)
           if (x % i == 0)
                t = 1;
            if (t == 0)
                Console.WriteLine(" primer ");
            else
                Console.WriteLine("not primer ");
            Console.ReadKey()