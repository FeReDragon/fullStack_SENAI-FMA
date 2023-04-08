using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escola_Bd_Api.Models
{
    public class Teacher : User
    {
        public string Department { get; set; }
        public string Registration { get; set; }
    }
}