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

        void create_part();
        int view_part();
    }
}
