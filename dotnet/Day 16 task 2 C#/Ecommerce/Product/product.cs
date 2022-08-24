namespace Product
{
    public class product
    {

        public int Pid { get; set; }
        public string PName { get; set; }

        public double Pprice { get; set; }

        


        public void Pshow()
        {
            Console.WriteLine(Pid + " " + PName + " " + Pprice);
        }
    }
}