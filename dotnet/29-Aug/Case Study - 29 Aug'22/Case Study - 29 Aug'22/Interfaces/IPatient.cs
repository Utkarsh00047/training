using System;
using System.Collections.Generic;
using System.Text;

namespace Case_Study___29_Aug_22.Interfaces
{
    public interface IPatient
    {
        public string p_Email { get; set; }

        void register_patient();
        void show_patient();
    }
}
