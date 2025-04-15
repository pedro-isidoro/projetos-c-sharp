using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentExercice.Entities
{
    internal class Bass : AbstractInstrument
    {
        public override string Play()
        {
            return Name + " is The bass player";
        }
    }
}
