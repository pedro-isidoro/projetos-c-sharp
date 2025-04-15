using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentExercice.Entities
{
    internal abstract class AbstractInstrument : IInstrument
    {
        public string Name { get; set; }

        public abstract string Play();
    }
}
