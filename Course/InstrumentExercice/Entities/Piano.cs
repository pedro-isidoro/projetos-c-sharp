using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentExercice.Entities
{
    internal class Piano : AbstractInstrument
    {
        public override string Play()
        {
            return Name + " is my favorite piano player";
        }
    }
}
