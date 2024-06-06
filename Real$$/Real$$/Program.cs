namespace Real__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string valorDigitadoEmReal = "";
            string valorDigitadoEmDolar = "";
            string valorDigitadoEmEuro= "";
            string valorDigitadoEmIene = "";
            string valorDigitadoEmLibra = "";
            decimal valorConvertido;
            decimal valorEmReal;
            decimal valorEmDolar;
            decimal valorEmEuro;
            decimal valorEmIene;
            decimal valorEmLibra;
            decimal cotacaoRealHoje = 0.17M;
            decimal cotacaoDolarHoje = 5.30M;
            decimal cotacaoEuroHoje = 5.76M;
            decimal cotacaoIeneHoje = 0.034M;
            decimal cotacaoLibraHoje = 6.78M;
           
            //Real
            valorDigitadoEmReal = Console.ReadLine();
            if(Decimal.TryParse(valorDigitadoEmReal, out valorConvertido))
            {
                Console.WriteLine("Digite o valor em reais: " + valorDigitadoEmReal);
            }

            valorEmDolar = valorConvertido * cotacaoDolarHoje;
            valorEmEuro = valorConvertido * cotacaoEuroHoje;
            valorEmIene = valorConvertido * cotacaoIeneHoje;
            valorEmLibra = valorConvertido * cotacaoLibraHoje;

            Console.WriteLine("Valor convertido em dolar e: R$" + valorEmDolar);
            Console.WriteLine("Valor convertido em Euro e: R$" + valorEmEuro);
            Console.WriteLine("Valor convertido em Iene e: R$" + valorEmIene);
            Console.WriteLine("Valor convertido em Libra e: R$" + valorEmLibra);

            //Dolar
            valorDigitadoEmDolar = Console.ReadLine();
            if (Decimal.TryParse(valorDigitadoEmDolar, out valorConvertido))
            {
                Console.WriteLine("Digite o valor em dolar: " + valorDigitadoEmDolar);
            }

            valorEmReal = valorConvertido * cotacaoRealHoje;
            valorEmEuro = valorConvertido * cotacaoEuroHoje;
            valorEmIene = valorConvertido * cotacaoIeneHoje;
            valorEmLibra = valorConvertido * cotacaoLibraHoje;

            Console.WriteLine("Valor convertido em real e: R$" + valorEmReal);
            Console.WriteLine("Valor convertido em Euro e: R$" + valorEmEuro);
            Console.WriteLine("Valor convertido em Iene e: R$" + valorEmIene);
            Console.WriteLine("Valor convertido em Libra e: R$" + valorEmLibra);

            //Euro
            valorDigitadoEmEuro = Console.ReadLine();
            if (Decimal.TryParse(valorDigitadoEmEuro, out valorConvertido))
            {
                Console.WriteLine("Digite o valor em Euro:  " + valorDigitadoEmEuro);
            }

            valorEmReal = valorConvertido * cotacaoRealHoje;
            valorEmDolar = valorConvertido * cotacaoDolarHoje;
            valorEmIene = valorConvertido * cotacaoIeneHoje;
            valorEmLibra = valorConvertido * cotacaoLibraHoje;

            Console.WriteLine("Valor convertido em Real e: R$" + valorEmReal);
            Console.WriteLine("Valor convertido em Dolar e: R$" + valorEmDolar);
            Console.WriteLine("Valor convertido em Iene e: R$" + valorEmIene);
            Console.WriteLine("Valor convertido em Libra e: R$" + valorEmLibra);

            //Iene
            valorDigitadoEmIene = Console.ReadLine();
            if (Decimal.TryParse(valorDigitadoEmIene, out valorConvertido))
            {
                Console.WriteLine("Digite o valor em Iene: " + valorDigitadoEmIene);
            }

            valorEmReal = valorConvertido * cotacaoRealHoje;
            valorEmEuro = valorConvertido * cotacaoEuroHoje;
            valorEmDolar = valorConvertido * cotacaoDolarHoje;
            valorEmLibra = valorConvertido * cotacaoLibraHoje;

            Console.WriteLine("Valor convertido em Real e: R$" + valorEmReal);
            Console.WriteLine("Valor convertido em Euro e: R$" + valorEmEuro);
            Console.WriteLine("Valor convertido em Dolar e: R$" + valorEmDolar);
            Console.WriteLine("Valor convertido em Libra e: R$" + valorEmLibra);

            //Libra
            valorDigitadoEmLibra = Console.ReadLine();
            if (Decimal.TryParse(valorDigitadoEmLibra, out valorConvertido))
            {
                Console.WriteLine("Digite o valor em Libra: " + valorDigitadoEmLibra);
            }

            valorEmReal = valorConvertido * cotacaoRealHoje;
            valorEmEuro = valorConvertido * cotacaoEuroHoje;
            valorEmIene = valorConvertido * cotacaoIeneHoje;
            valorEmDolar = valorConvertido * cotacaoDolarHoje;

            Console.WriteLine("Valor convertido em dolar e: R$" + valorEmDolar);
            Console.WriteLine("Valor convertido em Euro e: R$" + valorEmEuro);
            Console.WriteLine("Valor convertido em Iene e: R$" + valorEmIene);
            Console.WriteLine("Valor convertido em Real e: R$" + valorEmReal);
        }
    }
}
