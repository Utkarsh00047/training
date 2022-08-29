using System;
using System.Collections.Generic;
using System.Text;

namespace Case_Study___29_Aug_22.Interfaces
{
    public interface IDoctor
    {
        public string Department { get; set; }
        public string Email { get; set; }

        void create_Doctor();
        void ShowDoctor();
    }
}
