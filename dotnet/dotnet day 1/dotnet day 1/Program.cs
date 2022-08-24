using System;

namespace dotnet_day_1
{
    class Program
    {
        class global
        {
            public string id, name, contact, course;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 For Enter Student Detail");
            Console.WriteLine("Press 2 For Print Student Detail");

            Console.WriteLine("Press 3 For palindrome");
            Console.WriteLine("Press 4 For armstrong number");
            string response = "Y";
            int n=0;
            global b = new global();
            for(; response=="Y" ; )
            {
                Console.WriteLine("enter your choice");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine(n);
                b.name = "1";
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Write Student Id");
                        b.id = Console.ReadLine();
                        Console.WriteLine("Write Student Name");
                        b.name = Console.ReadLine();
                        Console.WriteLine("Write Student Contact");
                        b.contact= Console.ReadLine();
                        Console.WriteLine("Write Student Course");
                        b.contact = Console.ReadLine();
                        Console.WriteLine("done");
                        break;
                    case 2:
                        if (b.name.Length > 1)
                        {
                            Console.WriteLine("Student Name : " + b.name);
                            Console.WriteLine("Student Contact : " + b.contact);
                            Console.WriteLine("Student Name : " + b.course);
                        }
                        else
                            Console.WriteLine("Please first enter Student Detail");

                        break;
                    case 3:
                        Console.WriteLine("palindrome");
                        int num, rem, sum = 0, temp;
                        Console.WriteLine("To Find a Number is Palindrome or not");
                        Console.Write("\n Enter a number: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        temp = num;
                        while (num > 0)
                        {
                            rem = num % 10; 
                            num = num / 10;    
                            sum = sum * 10 + rem;

                        }
                        Console.WriteLine("\n The Reversed Number is: {0} \n", sum);
                        if (temp == sum)    
                        {
                            Console.WriteLine("\n Number is Palindrome \n\n");
                        }
                        else
                        {
                            Console.WriteLine("\n Number is not a palindrome \n\n");
                        }
                        break;
                    case 4:
                        Console.WriteLine("armstrong");
                        int n_a, r, sum_a = 0, temp_a;
                        Console.Write("Enter the Number= ");
                        n_a = int.Parse(Console.ReadLine());
                        temp_a = n_a;
                        while (n_a > 0)
                        {
                            r = n_a % 10;
                            sum_a = sum_a + (r * r * r);
                            n = n / 10;
                        }
                        if (temp_a == sum_a)
                            Console.Write("Armstrong Number.");
                        else
                            Console.Write("Not Armstrong Number.");
                        break;
                    default:
                        Console.WriteLine("enter correct choice");
                        break;
                }
                Console.WriteLine("press Y to continue");
                response = Console.ReadLine();
            }

        }
    }
}
