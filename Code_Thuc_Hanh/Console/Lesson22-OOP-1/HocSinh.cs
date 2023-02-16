using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson22_OOP_1
{
    internal class HocSinh
    {
        //15. Auto-Implemented Properties
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        // phuong thuc Tostring
        public override string ToString()
        {
            return this.Name+"\t"+this.Email+"\t"+this.Phone;
        }
    }
}
