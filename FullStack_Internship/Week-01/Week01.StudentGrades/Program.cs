class Week01_StudentGrades {

    static void Main(String[] args)
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Enter Your FullName : ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Mark1 : ");
                int M1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Mark2 : ");
                int M2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Mark3 : ");
                int M3 = Convert.ToInt32(Console.ReadLine());

                double Avg = 0;

                int Sum = 0;

                int NumOfMarks = 3;

                if (M1 >= 0 && M1 <= 100 && M2 >= 0 && M2 <= 100 && M3 >= 0 && M3 <= 100)
                {
                    Sum += M1 + M2 + M3;
                    Avg = Sum / NumOfMarks;
                }
                else
                {
                    Console.WriteLine("Invalid Enter . Plase Re-Enter The Marks ( 0 - 100) .");
                    continue;
                }

                if (Avg >= 90)
                {
                    Console.WriteLine($"The Student : {name} , The Grade and Avarage is :  (A) {Avg}");
                }
                else if (Avg >= 80)
                {
                    Console.WriteLine($"The Student : {name} , The Grade and Avarage is :  (B) {Avg}");

                }
                else if (Avg >= 70)
                {
                    Console.WriteLine($"The Student : {name} , The Grade and Avarage is :  (C) {Avg}");

                }
                else if (Avg >= 50)
                {
                    Console.WriteLine($"The Student : {name} , The Grade and Avarage is :  (D) {Avg}");

                }
                else
                {
                    Console.WriteLine($"The Student : {name} , The Grade and Avarage is :  (F) {Avg}");

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
    }
