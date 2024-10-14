namespace ConsoleApp
{
    class program
    {
        static void Main(string[] args)
        {

            int tvt;
            int vn;
            int vb;
            int vc1, vc2, vc3, tvc;
            double pc1 = 0, pc2 = 0, pc3 = 0, pvc = 0;
            double pcv, pcn = 0, pcb = 0;
            string c1, c2, c3;
            char resposta = 's', resposta2 = 'S';



            do
            {
                Console.Write("Informe o nome do primeiro candidato (a): ");
                c1 = Console.ReadLine();
                Console.Write("Informe o nome do segunda candidato (a): ");
                c2 = Console.ReadLine();
                Console.Write("Informe o nome do terceiro candidato (a): ");
                c3 = Console.ReadLine();
                Console.WriteLine("Candidatos: {0} {1} {2} ", c1, c2, c3);
                Console.WriteLine("Os dados foram inseridos corretamente? Se sim precione S para continuar, caso contrio aperte qualquer tecla para recomeçar");
                resposta = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (resposta != 's' && resposta2 != 'S');

            do
            {
                Console.Write("Insira a quantidade de votos quea o candidato {0} recebeu: ", c1);
                vc1 = int.Parse(Console.ReadLine());
                Console.Write("Insira a quantidade de votos que o candidato: {0} recebeu ", c2);
                vc2 = int.Parse(Console.ReadLine());
                Console.Write("Insira a quantidaed de votos que o canidato: {0} recebeu: ", c3);
                vc3 = int.Parse(Console.ReadLine());
                Console.Write("Insira a quantidade de votos brancos ");
                vn = int.Parse(Console.ReadLine());
                Console.Write("Insira a quantidade de votos nulos ");
                vb = int.Parse(Console.ReadLine());

                Console.WriteLine("Os dados foram inseridos corretamente? Se sim precione S para continuar, caso contrio aperte qualquer tecla para recomeçar");
                resposta = Console.ReadKey().KeyChar;

                Console.WriteLine();

            } while (resposta != 's' && resposta2 != 'S');



            tvt = vc1 + vc2 + vc3 + vn + vb;
            tvc = (vc1 + vc2 + vc3) * 100 / tvt;
            pc1 = (vc1 * 100) / tvt;
            pc2 = (vc2 * 100) / tvt;
            pc3 = (vc3 * 100) / tvt;
            pcn = (vn * 100) / tvt;
            pcb = (vb * 100) / tvt;





            Console.WriteLine("Dados totais das votações: ");

            Console.WriteLine("total de votos: {0} ", tvt);
            Console.WriteLine("percentual de votos em relação aos candidatos: {0}% ", tvc);
            Console.WriteLine("percentual de votos do candidato: {0} {1}% ", c1, pc1);
            Console.WriteLine("percentual de votos do candidato: {0} {1}% ", c2, pc2);
            Console.WriteLine("percentual de votos do candidato: {0} {1}% ", c3, pc3);
            Console.WriteLine("Percentual de votos nulos {0}% ", pcn);
            Console.WriteLine("percentual de votos do brancos: {0}% ", pcb);

        }
    }
}