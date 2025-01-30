          //ضرب الاعداد من X الى Y
            int x,y,malte=1;
            Console.Write("entr x= ");  
            x = int.Parse(Console.ReadLine());
            Console.Write("entr y= ");
            y = int.Parse(Console.ReadLine());
            if (x < y)
            {
                for(int i= x; i <= y; i++)
                {
                    malte *= i;
                
                }
            }
            Console.Write(malte);
            Console.ReadKey();