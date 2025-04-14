using System;
using Course10.Entities;

namespace Course10.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }
        //Dessa maneira, é sem interface. Deixando aberto com 2 pontos de alteração - Um acoplamento forte
        //O que significa? Caso altere o BrasilTax, terei que voltar aqui e arrumar
        //O que não é bem visto na POO
        //private BrazilTaxService _brazilTaxService = new BrazilTaxService();
        //Com a Interface - acoplamento fraco
        private ITaxService _TaxService;

        //Chamamos de inversão de controle, por meio de injeção de dependência - pois agora com interface,
        //passamos ela como prop
        //É quando informamos o objeto por meio do construtor
        public RentalService (double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _TaxService = taxService;
        }

        //Inversão de controle
        //Padrão de desenvolvimento que consiste em retirar da classe a responsabilidade de instanciar
        //suas dependências.

        //Injeção de dependências
        //É uma forma de realizar a inversão de controle: um componente externo instancia a dependência,
        //que é então injetada no objeto "pai".
        // Pode ser implementada de várias formas:
           // Construtor - Como aqui
           //Objeto de instanciação (builder / factory)
           //Container / framework

        public void ProccessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if(duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double Tax = _TaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, Tax);
        }
    }
}
