//القاسم  المشترك الاكبر 
            Console.WriteLine("a=");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("y=");
            int y = int.Parse(Console.ReadLine());
            for (int i=1;a!= y;i++)
            {
                if (a > y)
                    a = a - y;
                else
                    y = y - a;
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("a="+a);
            Console.WriteLine("y=" + y);
            Console.ReadKey();