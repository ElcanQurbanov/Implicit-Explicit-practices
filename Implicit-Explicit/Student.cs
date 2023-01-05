using Implicit_Explicit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_Explicit
{
    public class Student : IStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }


    }
}
