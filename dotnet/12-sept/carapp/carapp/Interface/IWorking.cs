using System;
using System.Collections.Generic;
using System.Text;

namespace carapp.Interface
{
    public interface IWorking
    {
        public string working_date { get; set; }
        public int working_hours { get; set; }
        public int day_pay { get; set; }
        public int hourly_cost { get; set; }

        void working_day_pay();
    }
}
