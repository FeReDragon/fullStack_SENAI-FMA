using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escola_Bd_Api.Models
{
    public class Student : User
    {
        public int Period { get; set; }
        public int RA { get; set; }
    }
}