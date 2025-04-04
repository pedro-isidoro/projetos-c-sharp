using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course2
{
    internal class Student
    {
        public string Name;
        public double Note1;
        public double Note2;
        public double Note3;

        public double FinalNote() {
            return Note1 + Note2 + Note3;
        }public string Situation() {
            if(FinalNote() >= 60.0)
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";
            }
        }
    }
}
