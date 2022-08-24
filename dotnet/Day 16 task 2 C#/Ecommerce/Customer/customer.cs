namespace Customer
{
    public class customer
    {
        public int Cid{ get; set; }
        public string CName{ get; set; }

        public string CcontactNo { get; set; }

        public string  Caddress { get; set; }


        public void Cshow()
        {
            Console.WriteLine(Cid + " " + CName + " " + CcontactNo + " " + Caddress);
        }

    }
}