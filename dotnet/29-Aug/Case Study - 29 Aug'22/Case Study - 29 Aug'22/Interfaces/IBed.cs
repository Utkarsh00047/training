using System;
using System.Collections.Generic;
using System.Text;

namespace Case_Study___29_Aug_22.Interfaces
{
    public interface IBed
    {
         int Price { get; set; }
         string Bed_Code { get; set; }

        void Bookbed();
        void ShowBed();
    }
}
