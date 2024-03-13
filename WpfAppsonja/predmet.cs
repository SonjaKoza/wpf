using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppsonja
{
    internal class predmet
    {
         public string subjectName;
        public List<double> marks = new List<double>();
        public predmet (string subject, List<double> Marks)
        {
            subjectName = subject;
            marks = Marks;
        }
    }
}
