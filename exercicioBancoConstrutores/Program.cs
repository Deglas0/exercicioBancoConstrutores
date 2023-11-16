namespace exercicioBancoConstrutores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = null;

            Console.WriteLine("Olá, bem vindo ao Banco con5trut0rs\n" +
                              "vejo que não há uma conta vinculada, porfavor crie uma conta:");

            Console.WriteLine("Digite o numero da conta:");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu nome:");
            string titular = Console.ReadLine();
            Console.WriteLine("ok, tudo certo!!\n" +
                              "Agora preciso saber se você quer começar com um deposito inicial\n" +
                              "ou não?\n" +
                              "s/S = sim\n" +
                              "n/N = não");

            string escolha;
            escolha = Console.ReadLine();
            if (escolha == "s" || escolha == "S")
            {
                Console.WriteLine("Quanto seria o deposito iiccial: ");
                double saldo = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, saldo);
            }
            else if (escolha == "n" || escolha == "N")
            {
                Console.WriteLine("ok, então vamos continnuar" +
                                  "╰(*°▽°*)╯");

                conta = new ContaBancaria(numero, titular);
            }
            else
            {
                Console.WriteLine("opção invalida, porfavor digite uma opção valida");
            }
            Console.WriteLine(conta); Console.WriteLine(conta);

            int iterator = 0;
            
            while (iterator == 0)
            {

                int sw = int.Parse(Console.ReadLine());
                if (sw == null) { sw = 0; }
                switch (sw)
                {
                    case 0:
                        Console.WriteLine(conta);
                        break;
                    case 1:
                        Console.WriteLine("sacar!!\n" +
                                          "digite o valor que deseja sacar:");
                        double s1 = double.Parse(Console.ReadLine());
                        conta.Saque(s1);
                        break;
                    
                    case 2:
                        Console.WriteLine("depositar!!\n+" +
                                          "digite o valor que deseja depositar:");
                        double d1 = double.Parse(Console.ReadLine());
                        conta.Deposito(d1);
                        break;     
                     
                    case 3:
                        Console.WriteLine("Obrigado por usar o Banco Con5trut0rs\n" +
                                          "Volte sempre༼ つ ◕_◕ ༽つ");
                        break;

                }
            }

        }
    }
}