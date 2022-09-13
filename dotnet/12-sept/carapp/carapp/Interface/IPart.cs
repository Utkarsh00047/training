using System;
using System.Collections.Generic;
using System.Text;

namespace carapp.Interface
{
    public interface IPart
    {
        public int part_cost { get; set; }
        public string part_code { get; set; }
        public int totalCost { get; set; }

        void create_part(string part_added);
        int view_part();
    }
}
