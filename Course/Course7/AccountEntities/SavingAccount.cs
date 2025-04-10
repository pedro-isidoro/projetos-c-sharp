namespace Course7.AccountEntities
{
    //Classes seladas não podem ser herdadas
    //Ex: internal sealed class Account
    //class BusinessAccountPlus : Account
    sealed class SavingAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingAccount()
        {
        }

        public SavingAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        //Sobreposição ou Sobrescrita
        //Sobreposição do método Withdraw
        //É quando voce remplemta na subclasse a operacao que ja existia na superclasse
        /* public override void Withdraw(double amount)
        {
            //Balance -= amount;
            //Palavra base
            base.Withdraw(amount); //Chama o método Withdraw da classe base
            Balance -= 2.0; //Adiciona 2.0 ao valor do saque
        }*/

        //Sealed - Métodos sobrepostos, são os únicos que podem ser selados
        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0; 
        }
    }
}
