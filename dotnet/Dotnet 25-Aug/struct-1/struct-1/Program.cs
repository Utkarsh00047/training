using System;

namespace struct_1
{
    struct empolyee
    {
        public int id;
        public string name, org;
    }
    class Program
    {
        static void Main(string[] args)
        {
            empolyee[] emp = new empolyee[2];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Please enter employee id, Name, org");


                emp[i].id = Int32.Parse(Console.ReadLine());
                emp[i].name = Console.ReadLine();
                emp[i].org = Console.ReadLine();
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("First employee :" +i+" Detals -");
                Console.Write(emp[i].id+" ,"+emp[i].name+" , "+emp[i].org);
            }

        }
    }
}
