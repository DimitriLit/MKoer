
internal class Program
{
    static void Main()
    {

        do
        {
            Console.Write("Sisestage esimine arv: ");
            double esimeneNum = double.Parse(Console.ReadLine());

            Console.Write("\nSisestage teine arv: ");
            double teineNum = double.Parse(Console.ReadLine());

            Console.Write("\nSisestage tehe (+, -, /, *): ");
            char tehe = char.Parse(Console.ReadLine());

            double final = 0d;

            switch (tehe)
            {

                case '+':
                    final = esimeneNum + teineNum;
                    break;

                case '-':
                    final = esimeneNum - teineNum;
                    break;

                case '/':
                    final = esimeneNum / teineNum;
                    break;

                case '*':
                    final = esimeneNum * teineNum;
                    break;


                default:
                    Console.WriteLine("IDK, Try again");
                    break;

            }

            Console.WriteLine("\nTulemus: " + final);

            

            for (int i = 0; i < final - 1; i++)
            {

                if (final == 0)
                {
                    break;
                }
                Console.Write("auh ");
            }

            double check = final % 2;
            if (final == 0)
            {
                Console.Write("\n\n");
            }
            else if (check != 1)
            {
                Console.Write("au\n\n");
            }
            else
            {
                Console.WriteLine("auh\n\n");
            }



        }
        while (true);


    }
}

