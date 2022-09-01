using System;
using System.Collections.Generic;
using System.Text;

namespace Fashion_app.Interfaces
{
    public interface ICategory
    {
        public string category_code { get; set; }

        void Category_create();
    }
}
