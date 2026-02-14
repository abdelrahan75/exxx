using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve_task_day7_c_
{
    internal class File : Readable  , Writeable
    {
        public void Write()
        {
            Console.WriteLine("write now");
        }

        public void Read()
        {
            Console.WriteLine("read now");
        }
    }
}
