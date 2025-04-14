using System.Globalization;

namespace Course10.FirstExerciceEntities
{
    internal class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return DueDate + " - R$ " + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
