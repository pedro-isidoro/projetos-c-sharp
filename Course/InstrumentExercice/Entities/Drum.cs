using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentExercice.Entities
{
    internal class Drum : AbstractInstrument
    {
        public override string Play()
        {
            return Name + " The Vitors are my favorites drum players";
        }
    }
}
