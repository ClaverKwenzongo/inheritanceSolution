using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceSolution
{
    internal class Book : Product
    {
        public string authorName;

        public Book()
        {
            authorName = "Claver Kwenzongo ";
        }
    }
}
