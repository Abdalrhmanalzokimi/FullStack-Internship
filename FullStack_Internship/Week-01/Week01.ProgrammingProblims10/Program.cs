class Week01_ProgrammingProblims10
{

    static void Main(string[] args)
    {
        /*Even_Or_Odd();
        double Max = MaxNumber();
        Console.WriteLine($"\n The Max Number = {Max}");
        double sum = SumNum();
        Console.WriteLine($"The Sum = {sum}");
        Multiplication_Table();
        double sum = Sum_Array();
        Console.WriteLine($"The Sum Of Array = {sum}");
        string rev = Reverse_The_Text();
        Console.WriteLine($"The Reverse Text : {rev}");
        Palindrome();
        int f = Factorial();
        Console.WriteLine($"The Factorial = {f}");
        Prime();*/
        int c = Count_Vowels();
        Console.WriteLine($"The Count Vowels = {c}");
    }
    static void Even_Or_Odd()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Enter Any Number To Check If It Is Even Or Odd .");
                double num = Convert.ToDouble(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine($"The Number ( {num} ) is : Even");
                }
                else
                {
                    Console.WriteLine($"The Number ( {num} ) is : Odd");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                continue;
            }
            break;
        }
    }

    static double MaxNumber()
    {
        double d = 0;
        double max =0 ;
        while (true)
        {
            try
            {
                Console.WriteLine("\nEnter Numbers Or Enter ( -1 ) To Stop =  ");

                double num = Convert.ToDouble(Console.ReadLine());
                if ( num == -1) 
                {
                    break;
                }else
                {
                    max=Math.Max(d, num);
                    d= max;
                }
                
            }
            catch (Exception ex) 
            {
            
                Console.WriteLine (ex.Message);
                continue;
            }

            }
        return max;
    }

    static double SumNum()
    {
        double sum = 0;
        while (true) 
        {
            try
            {
                Console.WriteLine("\nEnter Numbers To Sum Oll The Number\n Or Enter ( -1 ) To Stop =  ");
                double num = Convert.ToDouble(Console.ReadLine());

                if( num != -1)
                {
                    sum += num ;
                }
                else 
                {
                    break;
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
                continue;
            }
        }
        return sum;
    }

    static void Multiplication_Table()
    {
        Console.WriteLine("Enter Number of Multiplication Table =");
        int num =Convert.ToInt32 (Console.ReadLine());
        Console.WriteLine(" -------------------------");
        Console.WriteLine("|                         |");
        
        for (int i = 1; i <= 12; i++) 
        {
            int multiplication = i * num;
       Console.WriteLine($"      {i}- {num} x {i} = {multiplication} ");
        Console.WriteLine("|                         |");
        
        }
        
        Console.WriteLine(" -------------------------");
    }  
    static double Sum_Array()
    {
        double sum = 0;
        while (true) {
            try
            {
                ;
                Console.WriteLine("Enter Size Of Array = ");
                int size = Convert.ToInt32(Console.ReadLine());
                double[] arr = new double[size];

                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("Enter Number = ");
                    arr[i] = Convert.ToDouble(Console.ReadLine());
                    sum += arr[i];
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                continue;

            }
            break;
        }

        return sum;

        }

    static string Reverse_The_Text()
    {
        Console.WriteLine("Enter The Text TO Reverse : ");
        string text = Console.ReadLine();
        string reverse = "";
        text = text.ToLower();
        for (int i = text.Length - 1; i >= 0; i--)
        {
            reverse += text[i];
        }
        return reverse;
    }
    static void Palindrome()
    {
        Console.WriteLine("Enter The Text TO Check Is Palindrome Or Not : ");
        string text = Console.ReadLine();
        string reverse = "";
        text = text.ToLower();
        for (int i = text.Length - 1; i >= 0; i--)
        {
            reverse += text[i];
        }
        Console.Write("Rusalt Check the Text :");
        if (reverse == text)
        {
            Console.WriteLine("Is Palindrome");
        }
        else
        {
            Console.WriteLine("Is Not Palindrome");

        }
    }
    static int Count_Vowels()
    {
        int count = 0;
        Console.WriteLine("Enter The Word Or The Statment : ");
        String text = Console.ReadLine();
        text = text.ToLower();
        for (int i = 0; i < text.Length; i++)
        {
            if(text[i] == 'a' || text[i] == 'e' ||
            text[i] == 'i' || text[i] == 'o' || text[i] == 'u' )
            {
                count++;
            }
        }
        return count;
    }

    static void Prime()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Enter The Number To Check If It Is Prime Or Not = ");
                double num = Convert.ToDouble(Console.ReadLine());
                if (num / num == 1 && num / 1 == num)
                {
                    Console.Write("Rusalt Check the Number : Is Prime");
                }
                else
                {
                    Console.Write("Rusalt Check the Number : Is Prime");

                }
            }catch (Exception e) 
            { 
                Console.WriteLine(e.Message);
                continue;
            }
            break;
        }
    }
    static int Factorial()
    {
        int f = 0;
        while (true)
        {
            try
            {

                Console.WriteLine("Enter The Number To Sum Of The Factorial = ");
                int num = Convert.ToInt32(Console.ReadLine());
                f += num;
                for (int i = num - 1; i > 0; i--)
                {

                    f *= i;

                }
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
                continue;
            
            }
            break;
        }
        return f;
    }

}