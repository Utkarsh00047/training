namespace Employee
{
    public class employee
    {

        public int Eid { get; set; }
        public string EName { get; set; }

        public string EcontactNo { get; set; }

        public string Eaddress { get; set; }


        public void Eshow()
        {
            Console.WriteLine(Eid + " " + EName + " " + EcontactNo + " " + Eaddress);
        }

    }
}