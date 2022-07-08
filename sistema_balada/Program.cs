using System;

namespace sistema_checkinbalada
{
    class Program
    {
        static void Main(string[] args)
        {
           
        int[] a = new int[10];

            int i;
            int total = 0;
            int q_pgCheque = 0, q_pgCartao = 0, q_pgCedulas = 0, lidos = 0;
            int Vcheque = 12, Vcartao = 15, Vcedulas = 10;


            Console.WriteLine("-----Início do Programa-----");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("                CAIXA ABERTO");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Digite as formas de pagamento: ");
            Console.WriteLine("['1' = cheque] || ['2' = cartão] || ['3' = cédulas]");
            Console.WriteLine();


            for (i = 0; i < 10; i++)

            {
                a[i] = int.Parse(Console.ReadLine());
            }


            for (i = 0; i < 10; i++)

                if (a[i] >= 1 && a[i] <= 3)

                {
                    Console.WriteLine("- forma de pagamento salva no sistema -");
                }

                else
                {
                    Console.WriteLine("*** Número digitado inválido ***");
                }


            for (i = 0; i < 10; i++)

                if (a[i] == 1)

                {
                    q_pgCheque++;
                    lidos++;
                }



                else

                {

                    if (a[i] == 2)

                    {
                        q_pgCartao++;
                        lidos++;
                    }


                    if (a[i] == 3)

                    {
                        q_pgCedulas++;
                        lidos++;
                    }


                }


            total = ((Vcheque * q_pgCheque) + (Vcartao * q_pgCartao) + (Vcedulas * q_pgCedulas));


            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Pagamentos com cheque: {0}", q_pgCheque);
            Console.WriteLine("Pagamentos com cartão: {0}", q_pgCartao);
            Console.WriteLine("Pagamentos com cédulas: {0}", q_pgCedulas);
            Console.WriteLine("Total de ingressos vendidos lidos pelo sistema: {0}", lidos);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("==> A receita total de ingressos foi de: R$ {0},00 <==", total);
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("---------Fim do Programa----------");
            Console.ReadKey();

        }
    }
}
