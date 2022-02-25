using System;
using System.Globalization;
using System.Collections.Generic;
using Curso_OO.Entities;
using Curso_OO.Entities.Enums;

namespace Curso_OO
{
    class Program
    {
        static void Main(string[] args)
        {
            /* EXEMPLO S/ Orientação à OBJETO;
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Digite X: ");
            double x1 = double.Parse(Console.ReadLine(),CI);
            double x2 = double.Parse(Console.ReadLine(), CI);
            double x3 = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("Digite Y: ");
            double y1 = double.Parse(Console.ReadLine(), CI);
            double y2 = double.Parse(Console.ReadLine(), CI);
            double y3 = double.Parse(Console.ReadLine(), CI);

            double px = (x1 + x2 + x3) / 2;
            double py = (y1 + y2 + y3) / 2;

            double areax = Math.Sqrt(px * (px - x1) * (px - x2) * (px - x3));
            double areay = Math.Sqrt(py * (py - y1) * (py - y2) * (py - y3));

            Console.WriteLine("Área de x = " + areax.ToString("F4", CI));
            Console.WriteLine("Área de y = " + areay.ToString("F4", CI));

            if (areax > areay)
            {
                Console.WriteLine("Maior área: X");
            } else
            {
                Console.WriteLine("Maior área: Y");
            }
            */

            // ---------------------------------------------------------------------

            /* Exemplo C/ Orientação à OBJETO;
            CultureInfo CI = CultureInfo.InvariantCulture;

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Digite X: ");
            x.A = double.Parse(Console.ReadLine(), CI);
            x.B = double.Parse(Console.ReadLine(), CI);
            x.C = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("Digite Y: ");
            y.A = double.Parse(Console.ReadLine(), CI);
            y.B = double.Parse(Console.ReadLine(), CI);
            y.C = double.Parse(Console.ReadLine(), CI);

            double px = (x.A + x.B + x.C) / 2;
            double py = (y.A + y.B + y.C) / 2;

            double areax = Math.Sqrt(px * (px - x.A) * (px - x.B) * (px - x.C));
            double areay = Math.Sqrt(py * (py - y.A) * (py - y.B) * (py - y.C));

            Console.WriteLine("Área de x = " + areax.ToString("F4", CI));
            Console.WriteLine("Área de y = " + areay.ToString("F4", CI));

            if (areax > areay)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
            */

            // ---------------------------------------------------------------------------

            /* Pegando atributos da classe PESSOA e vendo quem é mais velho;
            Pessoa x, y;
            x = new Pessoa();
            y = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            x.nome = Console.ReadLine();
            Console.Write("Idade: ");
            x.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            y.nome = Console.ReadLine();
            Console.Write("Idade: ");
            y.idade = int.Parse(Console.ReadLine());

            if (x.idade > y.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + x.nome);
            } else
            {
                Console.WriteLine("Pessoa mais velha: " + y.nome);
            }
            */

            // --------------------------------------------------------------------------

            /* Pegando atributos da classe FUNCIONARIO e vendo o salário médio;
            CultureInfo CI = CultureInfo.InvariantCulture;

            Funcionario x, y;
            x = new Funcionario();
            y = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            x.nome = Console.ReadLine();
            Console.Write("Idade: ");
            x.salario = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            y.nome = Console.ReadLine();
            Console.Write("Idade: ");
            y.salario = double.Parse(Console.ReadLine(), CI);

            double media = (x.salario + y.salario) / 2;
            Console.WriteLine("Salário médio = " + media.ToString("F2", CI));
            */

            // -----------------------------------------------------------------------

            /* Exemplo do triângulo só que agora utilizando método (função) na classe triângulo para realizar a conta da área;
            CultureInfo CI = CultureInfo.InvariantCulture;

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Digite X: ");
            x.A = double.Parse(Console.ReadLine(), CI);
            x.B = double.Parse(Console.ReadLine(), CI);
            x.C = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("Digite Y: ");
            y.A = double.Parse(Console.ReadLine(), CI);
            y.B = double.Parse(Console.ReadLine(), CI);
            y.C = double.Parse(Console.ReadLine(), CI);

            double areax = x.Area();
            double areay = y.Area();

            Console.WriteLine("Área de x = " + areax.ToString("F4", CI));
            Console.WriteLine("Área de y = " + areay.ToString("F4", CI));

            if (areax > areay)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
            */

            // --------------------------------------------------------

            /* Exemplo Completo: Utilizando a tabela produtos, para a atualização,
             Remoção e a multiplicação do total dos valores dos produtos.
            CultureInfo CI = CultureInfo.InvariantCulture;

            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CI);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            */

            // ---------------------------------------------------

            /* Calcula a área, Perímetro e Diagonal de um retangulo utilizando classe própria
            CultureInfo CI = CultureInfo.InvariantCulture;

            Retangulo r = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");

            r.Largura = double.Parse(Console.ReadLine(), CI);
            r.Altura = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("AREA = " + r.Area().ToString("F2", CI));
            Console.WriteLine("PERÍMETRO = " + r.Perimetro().ToString("F2", CI));
            Console.WriteLine("DIAGONAL = " + r.Diagonal().ToString("F2", CI));
            */

            // ------------------------------------------------------------

            /* Aumentar o salário de um funcionário por x% utilizando a classe Trabalhador.
            CultureInfo CI = CultureInfo.InvariantCulture;

            Trabalhador t = new Trabalhador();

            Console.Write("Nome: ");
            t.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            t.SalarioBruto = double.Parse(Console.ReadLine(), CI);
            Console.Write("Imposto: ");
            t.Imposto = double.Parse(Console.ReadLine(), CI);
            Console.WriteLine();

            Console.WriteLine("Funcionário: " + t);
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double qte = double.Parse(Console.ReadLine(), CI);
            t.AumentarSalario(qte);
            Console.WriteLine();

            Console.Write("Dados atualizados: " + t);
            */

            // -------------------------------------------------------------

            /* Calcula se o aluno passou ou não, utilizando a classe Aluno
            CultureInfo CI = CultureInfo.InvariantCulture;

            Aluno a = new Aluno();

            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            a.Nota1 = double.Parse(Console.ReadLine(), CI);
            a.Nota2 = double.Parse(Console.ReadLine(), CI);
            a.Nota3 = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("NOTA FINAL = " + a.NotaFinal().ToString("F2", CI));

            if (a.NotaFinal() < 60)
            {
                Console.WriteLine("REPROVADO");
            } else
            {
                Console.WriteLine("APROVADO");
            }
            */

            // --------------------------------------------------------------------------
            /* Se não quiser criar várias classes, pode-se criar vários static para resolver os problemas
            static double Pi = 3.14;

            static void Main(string[] args)
            {
                Console.Write("Entre o valor do raio: ");
                double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double circ = Circunferencia(raio);
                double volume = Volume(raio);

                Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
            }

            static double Circunferencia(double r)
            {
                return 2.0 * Pi * r;
            }

            static double Volume(double r)
            {
                return 4.0 / 3.0 * Pi * r * r * r;
            }
            */

            // -----------------------------------------------------

            /* Utilizasse a classe static Calculadora, assim não necessita usar o objeto.Função, usando somente o nome da classe;
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2",
            CultureInfo.InvariantCulture));
            */

            // ---------------------------------------------------------------------------

            /* Exemplo de membro estático, onde basta colocar o nome da classe sem usar objetos.
            Console.Write("Qual é a cotação em dolar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double compra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = ConversorDeMoeda.Conversor(dolar, compra);

            Console.WriteLine("Valor a ser pago em reais = " + total.ToString("F2", CultureInfo.InvariantCulture));
            */

            // ------------------------------------------------------------------------

            /* Mesmo exemplo da classe produto só que utilizando Construtor.
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CI);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            // Construtor personalizado: que recebe parâmetros de input de variáveis.
            Produto p = new Produto(nome, preco, quantidade);

            // Construtor padrão: s/ parâmetros.
            Produto p2 = new Produto();

            // Construtor padrão mas com valores pré definidos.
            Produto p3 = new Produto {
                Nome = "TV",
                Preco = 500.00,
                Quantidade = 10;
            }

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            */

            // -------------------------------------------------------------------
            // UTILIZANDO A CLASSE Produto2
            /* ENCAPSULAMENTO -> GET() and SET()
            Produto2 p = new Produto2("TV", 500.00, 10);

            p.SetNome("TV 4K");
            Console.WriteLine(p.GetNome());
            */

            // --------------------------------------------------------------------

            /* UTILIZANDO PROPS Produto3
            Produto3 p = new Produto3("TV", 500.00, 10);

            p.Nome = "";
            Console.WriteLine(p.Nome);
            */

            // --------------------------------------------------------------------

            /* Exemplo de um banco usando a classe Banco completinha.
            CultureInfo CI = CultureInfo.InvariantCulture;

            Banco contaBancaria;

            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titual da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char condicao = char.Parse(Console.ReadLine());

            if (condicao == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double inicial = double.Parse(Console.ReadLine(), CI);
                contaBancaria = new Banco(conta, nome,  inicial);
            } else
            {
                contaBancaria = new Banco(conta, nome);
            }

            Console.WriteLine();

            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(contaBancaria);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double qte = double.Parse(Console.ReadLine(), CI);
            Console.WriteLine("Dados da conta atualizados:");
            contaBancaria.AdicionarDeposito(qte);
            Console.WriteLine(contaBancaria);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            qte = double.Parse(Console.ReadLine(), CI);
            Console.WriteLine("Dados da conta atualizados:");
            contaBancaria.AdicionarSaque(qte);
            Console.WriteLine(contaBancaria);
            */

            // ------------------------------------------------

            /* Exemplo de Strutct usando a classe Point
            Point p; // Não precisa do new Point();
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);
            p = new Point(); // -> Cria um novo Point (0, 0)
            Console.WriteLine(p);
            */

            // ---------------------------------------------------------------------------------

            /* Operadores nulos e seus atributos
            //double z = null // Erro
            Nullable<double> x = null; // Exemplo de dizer que a variável x é opicional
            double? y = null; // Exemplo de dizer que a variável y é opicional (mais simples)

            Console.WriteLine(x.GetValueOrDefault()); // Pega o valor de X. Caso for nulo, imprime 0;
            Console.WriteLine(x.HasValue); // Diz se existe valor na variável;
            //Console.WriteLine(x.Value); // Pega o valor diretamente da variável, mas se o valor for nulo, da erro;

            //Exemplo pra arrumar e não dar erro no x.Value.
            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            } else
            {
                Console.WriteLine("X is null");
            }

            double? a = null;
            double? b = 10;

            double c = a ?? 5; // Em c, vou jogar o valor de A, caso A for nulo, pega o valor 5;
            double d = b ?? 3; // Em d, vou jogar o valor de B, caso B for nulo, pega o valor 3;

            Console.WriteLine(c);
            Console.WriteLine(d);
            */

            // ----------------------------------------------------------------------

            /* Exemplo de vetor utilizando classe (Product)
            int n = int.Parse(Console.ReadLine());

            CultureInfo CI = CultureInfo.InvariantCulture;

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CI);

                vect[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }

            double avg = sum / n;
            Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CI));
            */

            // ---------------------------------------------------------------

            /* Usando vetores junto com classes, pede o nome, quarto e o email, guarda na classe
             * Room, nas posições dos números dos quartos e depois imprime em ordem crescente.

            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Rooms[] vect = new Rooms[10];

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Rent #" + i);
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                Console.WriteLine();

                vect[room] = new Rooms { Name = name, Email = email, Room = room };
                
            }

            Console.WriteLine("Busy rooms: ");
            for (int i = 0; i < vect.Length; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(vect[i].Room + ": " + vect[i].Name + ", " + vect[i].Email);
                }
            }
            */

            // ----------------------------------------------------

            /* Calculadora usando vetor para somar quantos números você quiser
            int s1 = Calculadora.Sum(2, 3, 4, 2, 13, 123);
            int s2 = Calculadora.Sum(//Quantos números você quiser somar);

            Console.WriteLine(s1);
            */

            // ----------------------------------------------------------

            /* Exemplo de ref e out
            int a = 10; // variável a precisa ser iniciada.
            Calculadora.Triplo(ref a); // ref pega o resultado na classe calculadora e retorna aqui.
            Console.WriteLine(a);

            int b = 10; 
            int triple;// Não obriga o usuário a iniciar um valor
            Calculadora.Triple(b, out triple); // out pega a variavel result na classe calculadora e ela na nossa variável triple;
            Console.WriteLine(triple);
            */

            // -----------------------------------------------------

            /* Exemplo de como utilizar o foreach
            string[] vect = new string[] { "Maria", "Bob", "Alex" };

            foreach (string nome in vect)
            {
                Console.WriteLine(nome); // Para cada nome no vetor, imprima ele.
            }
            */

            // --------------------------------------------------------

            /* Exemplo de listas
            List<string> list = new List<string>(); // Lista vazia
            List<int> lista = new List<int> { 1, 2, 3, 4}; // lista c/ elementos iniciais
            */

            // ------------------------------------------------------------

            /* Exemplos de utilizações de listas;
            List<string> list = new List<string>();
            list.Add("Maria"); // Adiciona um elemento do tipo da sua lista ao final dela.
            list.Insert(2, "Marco"); // Adiciona um elemento do tipo da sua lista no lugar que você quiser.
            list.Count(); // Conta quantos elementos tem em uma lista.
            string s1 = list.Find(x => x[0] == 'A'); // Recebe uma Lambda ou uma função que retorna verdadeiro ou falso caso ache o primeiro elemento, que no exemplo, contém a letra A na inicial.
            string s2 = list.FindLast(x => x[0] == 'A'); // Recebe uma Lambda ou uma função que retorna verdadeiro ou falso caso ache o ultimo elemento, que no exemplo, contém a letra A na inicial.
            int pos1 = list.FindIndex(x => x[0] == 'A'); // Recebe uma Lambda ou uma função que retorna verdadeiro ou falso caso ache o primeiro elemento, pegando assim, sua posição na lista (index).
            int pos2 = list.FindLastIndex(x => x[0] == 'A'); // Recebe uma Lambda ou uma função que retorna verdadeiro ou falso caso ache o ultimo elemento, pegando assim, sua posição na lista (index).
            List<string> list2 = list.FindAll(x => x.Length == 5); // Recebe uma Lambda ou uma função que retorna verdadeiro ou falso caso exista um elemento ou mais com 5 caracter, ele irá mostrar.
            list.Remove("Maria"); // Remove certo elemento da lista;
            list.RemoveAll(x => x[0] == 'M'); // Remove todos os elementos que começam com a letra M.
            */

            // ------------------------------------------------------------------------

            /* Mesmo exemplo do banco, adicionando uma porcentagem de salário a um determinado ID, usando listas (Meio complexo)
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Emplyoee #" + i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CI);
                Console.WriteLine();

                list.Add(new Employee(id, name, salary));

            }

            Console.Write("Enter the employee id that will have salary increase: ");
            double newSalary = double.Parse(Console.ReadLine(), CI);

            Employee emp = list.Find(x => x.Id == newSalary);
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CI);
                emp.increaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("Updated list of employees: ");
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }   
            */

            // -----------------------------------------------------

            /* Básico sobre matriz
            double[,] matriz = new double[2, 3];

            Console.WriteLine(matriz.Length); // Quantos elementos a matriz possui.
            Console.WriteLine(matriz.Rank); // Quanto é a quantidade de linhas da matriz
            Console.WriteLine(matriz.GetLength(0)); // Dimensão 0 da matriz tem dimensão 2 - Linhas
            Console.WriteLine(matriz.GetLength(1)); // Dimensão 0 da matriz tem dimensão 3 - Colunas
            */

            // ---------------------------------------------------------

            /* Exemplo de matriz, além de ver sua diagonal e a soma dos números negativos.
            Console.Write("How many collums and lines do u want? ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(s[j]);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Main Diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(matriz[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] < 0) {
                        count++;
                    }
                }
            }
            Console.WriteLine("There is " + count + " negatives numbers");
            */

            // ------------------------------------------------------------

            /*Matriz que ao você escolher um número dela, mostra os números à direita, esquerda, em cima e embaixo do número escolhido.
            Console.Write("How many lines and collums do u want? ");
            string[] s = Console.ReadLine().Split(' ');
            int M = int.Parse(s[0]);
            int N = int.Parse(s[1]);

            int[,] matriz = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    matriz[i, j] = int.Parse(linha[j]);
                }
            }
            Console.WriteLine();


            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++) {
                    if(matriz[i, j] == number)
                    {
                        Console.WriteLine("Position " + i + ", " + j);
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + matriz[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + matriz[i - 1, j]);
                        }
                        if (j < N -1)
                        {
                            Console.WriteLine("Right: " + matriz[i, j + 1]);
                        }
                        if (i < M - 1)
                        {
                            Console.WriteLine("Left: " + matriz[i + 1, j]);
                        }

                    }
                }
            }
            */

            // --------------------------------------------------------------------

            /* Exemplo de Switch
            int x = int.Parse(Console.ReadLine());
            string day;

            switch (x)
            {
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                // ... Infinitos case
                default:
                    day = "Invalid value";
                    break;


            }

            Console.WriteLine("Day: " + day);
            */

            // -----------------------------------------------

            /* Condição ternária, opcional ao if-else
             - Estrutura: (condição) ? valor_se_verdadeiro : valor_se_falso
             Exemplo: (2 > 4) ? 50 : 80 ----------> Retorna 80;
             Exemplo2: (10 != 3) ? "Maria" : "Alex" ---------> Retorna Maria
            */

            // ---------------------------------------------

            /* String tipos
            string original = "abcde FGHIJ ABC abc DEFG    ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            
            string s3 = original.Trim(); // Remove os espaços em branco, antes e dps
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            string s4 = original.Substring(3); // Começa a contar a partir do index 3;
            string s5 = original.Substring(3, 5); // Começa a contar a partir do index 3 e só mostra os próx 5 elementos.
            
            string s6 = original.Replace('a', 'x'); // Troca o a por x
            string s7 = original.Replace("abc", "xy");

            bool b1 = String.IsNullOrEmpty(original); // Testa se o conteúdo é vazio ou nulo.
            bool b2 = String.IsNullOrWhiteSpace(original); // Testa se o conteúdo é vazio ou tem espaço em branco.

            Console.WriteLine(original);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            */

            // --------------------------------------------

            /* Date tipos
            DateTime d1 = DateTime.Now; // Hora atual
            DateTime d2 = new DateTime(2018, 11, 25);
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3);
            DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 3, 500);

            DateTime d5 = DateTime.Today; // Data de hoje com o horário zerado.
            DateTime d6 = DateTime.UtcNow; // Horario em Greewnwetch;

            DateTime d7 = DateTime.Parse("2000-08-15");
            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d9 = DateTime.Parse("15/08/2000");
            DateTime d10 = DateTime.Parse("15/08/2000 13:04:12");

            DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d12 = DateTime.ParseExact("21/11/2001 13:12:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(d11);
            Console.WriteLine(d12);
            Console.WriteLine();
            Console.WriteLine(d1.Ticks); // Contando os ticks desde o ano 1;
            */

            // ----------------------------------------------
            /* Mias dates tipos
            DateTime d = new DateTime(2018, 11, 25, 20, 45, 3, 500);

            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Second: " + d.Second);
            Console.WriteLine("10) Ticks: " + d.Ticks);
            Console.WriteLine("11) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("12) Mouth: " + d.Month);
            Console.WriteLine("13) Year: " + d.Year);

            Console.WriteLine(d.ToLongDateString()); // quarta feira, 22 de agosto de 2000.
            Console.WriteLine(d.ToLongTimeString());
            Console.WriteLine(d.ToShortDateString());
            Console.WriteLine(d.ToShortTimeString());

            // Operações com Datetime
            DateTime d2 = d.AddHours(2);
            DateTime d3 = d.AddMinutes(3);

            DateTime d4 = new DateTime(200, 10, 18);
            DateTime d5 = new DateTime(200, 10, 10);
            TimeSpan t = d4.Subtract(d5);

            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(t);
            */

            // --------------------------------------------------

            /* Time span tipos
            TimeSpan t1 = new TimeSpan();// 00:00:00
            TimeSpan t2 = new TimeSpan(0, 1, 30); //h, m, s
            TimeSpan t3 = new TimeSpan(9000000000); // converte nanosegundos em hora/min/seg
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21); // d, h, m, s
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321); // d, h, m, s, ms

            TimeSpan t6 = TimeSpan.FromDays(1.5); // Cria uma data contendo 1 dia e meio.
            TimeSpan t7 = TimeSpan.FromHours(1.5);
            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            TimeSpan t9 = TimeSpan.FromSeconds(1.5);
            TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t11 = TimeSpan.FromTicks(213213902L);


            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);
            Console.WriteLine(t11);

            Console.WriteLine();
            Console.WriteLine(t2.Ticks);
            */

            // --------------------------------------------------------

            /* Mais Span tipos
            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            TimeSpan tt = new TimeSpan(4, 6, 1, 32, 61);

            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            Console.WriteLine("1) Day: " + t.Days);
            Console.WriteLine("2) Hour: " + t.Hours);
            Console.WriteLine("3) Millisecond: " + t.Milliseconds);
            Console.WriteLine("4) Minute: " + t.Minutes);
            Console.WriteLine("5) Second: " + t.Seconds);
            Console.WriteLine("6) Ticks: " + t.Ticks);

            Console.WriteLine("7) TotalDays: " + t.TotalDays);
            Console.WriteLine("8) TotalHours: " + t.TotalHours);
            Console.WriteLine("9) TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("10) TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("11) TotalMilliseconds: " + t.TotalMilliseconds);

            TimeSpan sum = t1.Add(t2); // Soma de 2 timespan;
            TimeSpan dif = t1.Subtract(t2);
            TimeSpan multi = t1.Multiply(2);
            TimeSpan div = t1.Divide(5);

            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(multi);
            Console.WriteLine(div);
            */

            // -----------------------------------------------------

            /* Utilizando Local e UTC
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());

            DateTime d2 = DateTime.Parse("2000-08-15T13:05:54Z") // Data no UTC, mas dependendo
            do computador do usuário, essa data é alterada para seu fuso-horário.

            Console.WriteLine(d2);
            */

            // ------------------------------------------------------------------

            /* GIT comandos
            git init -> primeira vez em cada projeto (git controla os arquivos)
            git config --global user.name "Seu Nome" -> Fica salvo após o commit, seu nome
            git config --global user.email "Email" -> Fica salvo após o commit, seu email
            git status -> ver a situação dos commit (vermelho -> não rastreados / verde -> pronto pra commit)
            git add . -> adiciona todos os "vermelhos para verde" para serem commitados
            git log -> para ver os hitóricos de versões mostrando o usuário que modificou
            git log --oneline -> para ver os nomes e os históricos das versões
            git commit -m "Nome do Commit" -> para commitar os commit em verde.
            git clean -df (MAIS O COMANDO EM OUTRA LINHA) git checkout -- .    -> para voltar para o commit feito anteriormente
            git reset --soft HEAD~1 -> remover o último commit mantendo as alterações dos arquivos
            git reset --hard HEAD~1 -> remover o último commit não mantendo as alterações dos arquivos
            git checkout <código do commit> -> serve para visualizar um commit feito anteriormente
            git checkout <nome da branch> -> serve para voltar ao commit atual.
            git remote add origin <URL do repositório remoto> -> Serve para associar nosso repositório local a um remoto (apelido origin)
            git push -u origin (main/master) -> para subir o repositório local para o GitHub
            git push -> Após ter feito o comando acima, basta só utilizar esse para subir o repositório.
            git clone <URL do repositório remoto> -> serve para pegar o repositório remoto e colocá-lo em seu computador.
            git pull origin (master/main) -> serve para atualizar seu repositório local

            */

            // -----------------------------------------------------------------

            /* Enum exemplo Utilizando uma pasta Entities com a classe Order.cs e uma pasta Enums com a classe OrderStatus
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
            */

            // --------------------------------------------------------------------

            /* Exemplo Complexo de utilização de enums, entities, e classes com objetos.
            Entities utilizadas: Department.cs + HourContract.cs + Worker.cs 
            Enums utilizados: WorkLevel.cs
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, salary, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter #" + i + " contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContrat(contract);
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
            */

            // -------------------------------------------------------------------------

            /* Exercício Envolvendo Entidades e o modo StringBuilder para escrever:
             * Usando as entidades Post.cs e Comment.cs
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!", 
                12);
            p1.AddComent(c1);
            p1.AddComent(c2);


            Comment c3 = new Comment("Good night!");
            Comment c4 = new Comment("May the Force be with you");

            Post p2 = new Post(
               DateTime.Parse("28/07/2018 23:14:19"),
               "Good night guys",
               "See you tomorrow",
               5);
            p2.AddComent(c3);
            p2.AddComent(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            */

            // ------------------------------------------------------------

            /* Exemplo Complexo 2 de utilização de enums, entities, e classes com objetos.
             * Entities utilizadas: Product.cs + OrderItem.cs + Ordered.cs + Client.cs
             * Enums utilizados: OrderStatus.cs
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, date);
            Ordered ordered = new Ordered(DateTime.Now, status, client);

            Console.Write("How Many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(nameProduct, price);
                OrderItem orderitem = new OrderItem(quantity, price, product);

                ordered.AddItem(orderitem);

            }

            Console.WriteLine();
            Console.WriteLine("Order Summary: ");
            Console.WriteLine(ordered);
            */

            // -------------------------------------------------------------------------

            /* Explicação de herança: BusinnesAccount.cs + Account.cs;*/

            // -------------------------------------------------------------------------

            /* UPCASTING E DOWCASTING utilizando as classes da explicação da herança junto com a saving.Account.cs
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // UPCASTING -> Conversão da subclasse(businessAcount e SavingsAccount) para a superclasse(Account);

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            // DOWNCASTING -> Conversão da superclasse(Account) para a subclasse(businessAcount e SavingsAccount) ;

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);
            // acc2.Loan(100.0) -> Erro, tem q converter Account para BusinnesAcount, como acima.

            //BusinessAccount acc5 = (BusinessAccount)acc3; // -> Da erro pois BusineesAccount não se conecta com SavingsAccount

            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc6 = (BusinessAccount)acc3; 
              //BusinessAccount acc6 = acc3 as BusinessAccount; # Outro modo de realizar
                acc6.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if(acc3 is SavingsAccount)
            {
                SavingsAccount acc6 = (SavingsAccount)acc3;
              //SavingsAccount acc6 = acc3 as SavingsAccount; # Outro modo de realizar
                acc6.UpdateBalance();
                Console.WriteLine("Update!");
            }
            */

            // ------------------------------------------------------------

            /* Sobreposição, virtual, override
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Ana", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
            */

            // ------------------------------------------------------------------

            /* Exemplo de exercício com herança, polimorfismo e upcasting
             * Utilizando as classes Employee.cs e OutSourcedEmployee.cs
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valueperhour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y' || ch == 'Y')
                {
                    Console.Write("Additional charge: ");
                    double addcharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutSourcedEmployee(name, hours, valueperhour, addcharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valueperhour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Payments: ");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
            */

            // --------------------------------------------------------------------------------

            /* Exercício de herança e polimorfismo
             * Utilizando as classes Product.cs, ImportedProduct.cs e UsedProduct.cs
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char choice = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (choice == 'i' || choice == 'I')
                {
                    Console.Write("Customs fee: ");
                    double customfee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    ImportedProduct importedProduct = new ImportedProduct(name, price, customfee);
                    list.Add(importedProduct);
                }
                else if (choice == 'u' || choice == 'U') 
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    UsedProduct usedProduct = new UsedProduct(name, price, date);
                    list.Add(usedProduct);
                } 
                else 
                {
                    Product product = new Product(name, price);
                    list.Add(product);
                }
             
            }

            Console.WriteLine();
            Console.WriteLine("Price Tags:");
            foreach(Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }
            */


            Console.ReadLine();
        }
    }
}