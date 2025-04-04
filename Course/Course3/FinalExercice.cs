using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Course3
{
    internal class FinalExercice
    {
        //private int _accountNumber;
        public int AccountNumber {  get; private set; }
        public string AccountName { get; set; }
        //private double _total;
        public double Total { get; private set; }

        public FinalExercice()
        {

        }

        public FinalExercice(int accountNumber, string accountName)
        {
            AccountNumber = accountNumber;
            AccountName = accountName;
            //if (ThereAreInitialValue == 'n') {
                //_total = 0;
                
            //}
        } 
        
        public FinalExercice(int accountNumber, string accountName, double initialValue) : this()
        {
            AddToTotal(initialValue);
        }

        /*public int AccountNumber
        {
            get { return _accountNumber; }
            set
            {
                if (value != null)
                {
                    _accountNumber = value;
                }
            }
        }*/


        public void AddToTotal(double value)
        {
            Total += value;
        }

        public void RemoveFromTotal(double value)
        {
            Total -= (value + 5);
        }

        public override string ToString()
        {
            return "Conta " + AccountNumber + ", Titular: " + AccountName + ", Saldo: $ " + Total.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
