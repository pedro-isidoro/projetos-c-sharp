using InstrumentExercice.Entities;

namespace InstrumentExercice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bass bass = new Bass() { Name = "Pedrão" };
            EletricGuitar eletricGuitar = new EletricGuitar() { Name = "Pedrinho" };
            Piano piano = new Piano() { Name = "Gui Piovani" };
            Drum drum = new Drum() { Name = "Thiagão and Victors" };
            Guitar guitar = new Guitar() { Name = "Higor" };

            Console.WriteLine(bass.Play());
            Console.WriteLine(eletricGuitar.Play());
            Console.WriteLine(piano.Play());
            Console.WriteLine(drum.Play());
            Console.WriteLine(guitar.Play());
        }
    }
}
