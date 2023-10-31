# Programação Orientada a Objetos - C#

## $\tt\orange{⁕ \space Introdução \space à \space C\#}$

- Tipos de variáveis
    
    
    | Tipo C# | Tipo .NET | Valores | Observações |
    | --- | --- | --- | --- |
    | sbyte | System.SByte | -128 até 127 | Números inteiros pequenos |
    | short | System.Int16 | -32768 até 32767 | Números inteiros médios |
    | int | System.Int36 | -2³¹ até 2³¹ -1 | Números inteiros grandes |
    | long | System.Int64 | -2⁶³ até 2⁶³ -1 | Números inteiros muito grandes |
    | byte | System.Byte | 0 até 255 | Números inteiros pequenos e positivos |
    | ushort | System.Uint16 | 0 até 65535 | Números inteiros médios e positivos |
    | uint | System.Uint32 | 0 até 2³² -1 | Números inteiros grandes e positivos |
    | ulong | System.Uint64 | 0 até 2⁶⁴ - 1 | Números inteiros muito grandes e positivos |
    | float | System.Single | Números quebrados pequenos | - |
    | double | System.Double | Números quebrados médios | - |
    | decimal | System.Decimal | Números quebrados grandes | Usado para calculos de alta precisão  |
    | char | System.Char | Caractere único  | Qualquer caractere Unicode |
    | bool | System.Boolean | “true” ou “false” | Apenas verdadeiro e falso |
    
- Saída de dados
    
    ```csharp
    using System;
    using System.Globalization;
    
    namespace ConsoleApplication2 {
    	class Program {
    		static void Main(string[] args) {
    
    			double saldo = 10.35784;
    			int idade = 32;
    			string nome = "Maria";
    
    			//Mostra um texto no console quebrando a linha.
    			Console.WriteLine("Bom dia!"); 
    			//Mostra um texto no console sem quebrar a linha.
    			Console.Write("Olá mundo!"); 
    
    			//Delimita o tamanho decimal.
    			Console.WriteLine(x.ToString("F2")); 
    			//Ignora a regionalização a linguagem (A "," vira ".", nesse caso)
    			Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture)); 
    
    			
    			//Placeholder
    			Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome,  idade, saldo); 
    
    			//Interpolação
    			Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais"); 
    
    			//Concatenação
    			Console.WriteLine(nome +" tem "+ idade+ " anos e tem saldo igual a + "saldo.ToString("F2") +" reais"); 
    
            }
        }
    }
    ```
    
- Operadores de atribuição
    
    
    | Operador | Exemplo | O que acontece |
    | --- | --- | --- |
    | = | a = 10; | a RECEBE 10 |
    | += | a += 10; | a RECEBE a + 10 |
    | -= | a -= 10; | a RECEBE a - 10 |
    | *= | a *= 10; | a RECEBE a * 10 |
    | /= | a /= 10; | a RECEBE a / 10 |
    | % | a %= 10; | a RECEBE a % 10 |
    | ++ | a++; ou ++a; | a = a +1 |
    | -- | a--; ou --a; | a = a - 1 |
- Casting (Conversão de tipos de variáveis)
    
    ```csharp
    using System;
    
    namespace Curso{
        internal class Program{
            static void Main(string[] args){
                double a;
                int b;
                a = 2.4;
                //Transformando uma var double em int.
                b = (int)a;
                Console.WriteLine(b);
                int c = 5, d = 2;
                //Essa visão precisa de um casting pra mostrar o valor correto.
                double resultado = (double)c / d;
                Console.WriteLine(resultado);
    
            }
        }
    }
    ```
    
- Operadores aritméticos
    
    
    | Operador | Significado |
    | --- | --- |
    | + | Adição |
    | = | Subtração |
    | * | multiplicação |
    | / | divisão |
    | % | resto da divisão |
    
    ```csharp
    using System;
    
    namespace Curso{
        internal class Program{
            static void Main(string[] args){
                //Multiplicação será feita antes da soma
                int n1 = 3 + 4 * 2;
                //Parenteses quebram a precedência
                int n2 = (3 + 4) * 2;
                //Sobra da divisão
                int n3 = 17 % 3;
                //Precisa do casting pro compilador retornar um valor double
                double n4 = (double) 10 / 8;
                //Pode ser feito dessa forma também
                double n5 = 10.0 / 8;
    
                //Delta
                double a = 1.0, b = -3.0, c = -4.0;
                double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
    
                //Bhaskara
                double x1 = (-b + Math.Sqrt(delta)) / 2.0 * a; 
                double x2 = (-b - Math.Sqrt(delta)) / 2.0 * a;
    
                Console.WriteLine(n1);
                Console.WriteLine(n2);
                Console.WriteLine(n3);
                Console.WriteLine(n4);
                Console.WriteLine(n5);
                Console.WriteLine(delta);
                Console.WriteLine(x1);
                Console.WriteLine(x2);
                Console.ReadLine();
            }
        }
    }
    ```
    
- Entrada de Dados - Trabalhando com Strings
    - Console.ReadLine(); → Retorna dados em forma de string.
    
    ```csharp
    using System;
    
    namespace Curso{
        internal class Program{
            static void Main(string[] args){
                string frase = Console.ReadLine();
                Console.WriteLine("Você digitou: " + frase);
    
                //Separando uma string com vetor e split
                string frases = Console.ReadLine();
                string[] vet = frases.Split(' ');
                string p1 = vet[0], p2 = vet[1], p3 = vet[2];
                Console.WriteLine("Primeira palavra: {0} \nSegunda palavra: {1} \nTerceira Palavra: {2}", p1, p2, p3);
                
                Console.ReadLine();
            }
        }
    }
    ```
    
- Entrada de Dados
    - Em C#, usamos o .Parse para converter o valor de uma variável.
    
    ```csharp
    using System;
    using System.Globalization;
    
    namespace Curso{
        internal class Program{
            static void Main(string[] args){
                //Convertendo para int com o Parse:
                int n1 =  int.Parse(Console.ReadLine());
                Console.WriteLine(n1);
                //Convertando para char com o Parse:
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine(ch);
                //Convertendo para double com o Parse e ignorando a linguagem da maquina;
                double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //O "F2" delimita as casas decimais
                Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
    ```
    
    - Atividade:
        
        ```csharp
        using System;
        using System.Globalization;
        
        namespace Curso
        {
            internal class Program
            {
                static void Main(string[] args)
                {
                    Console.WriteLine("Entre com seu nome completo:");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Quantos Quartos tem na sua casa?");
                    int quartos = int.Parse(Console.ReadLine());
                    Console.WriteLine("Entre com o preço de um produto:");
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
                    string[] vet = Console.ReadLine().Split(' ');
        
                    Console.WriteLine("Nome: {0}", nome);
                    Console.WriteLine("Quartos: {0}", quartos);
                    Console.WriteLine("Preço: " + preco, CultureInfo.InvariantCulture);
                    Console.WriteLine("Ultimo Nome: {0}", vet[0]);
                    Console.WriteLine("Idade: {0}", int.Parse(vet[1]));
                    Console.WriteLine("Altura: {0}", double.Parse(vet[2]).ToString("F2", CultureInfo.InvariantCulture));
                }
            }
        }
        ```
        
- Lista de exercícios de estrutura sequencial
    - 1 - Soma de dois valores
        
        ```csharp
        using System;
        
        namespace Curso{
            internal class Program{
                static void Main(string[] args){
                    Console.WriteLine("Infomre o primeiro valor: ");
                    int n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o segundo valor: ");
                    int n2 = int.Parse(Console.ReadLine());
                    int soma = n1 + n2;
        
                    Console.WriteLine("Soma = {0}", soma);
                }
            }
        }
        ```
        
    - 2 - Área de um circulo
        
        ```csharp
        using System;
        using System.Globalization;
        
        namespace Curso{
            internal class Program{
                static void Main(string[] args) {
                    Console.WriteLine("Informe o raio: ");
                    double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    double a = 3.14159 * Math.Pow(2, r);
                    Console.WriteLine("A = {0}", a.ToString("F4", CultureInfo.InvariantCulture));
                }
            }
        }
        ```
        
    - 3 - Diferença
        
        ```csharp
        using System;
        
        namespace Curso{
            internal class Program{
                static void Main(string[] args){
                    Console.WriteLine("Infomre o primeiro valor: ");
                    int n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o segundo valor: ");
                    int n2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Infomre o terceiro valor: ");
                    int n3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o quarto valor: ");
                    int n4 = int.Parse(Console.ReadLine());
                    int diferenca = (n1 * n2) - (n3 * n4);
        
                    Console.WriteLine("Diferença = {0}", diferenca);
                }
            }
        }
        ```
        
    - 4 - Salário
        
        ```csharp
        using System;
        using System.Globalization;
        
        namespace Curso{
            internal class Program{
                static void Main(string[] args)
                {
                    Console.WriteLine("Infomre o número do funcionário: ");
                    int numeroFuncionario = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a quantidade de horas trabalhadas: ");
                    int horasTrabalhadas = int.Parse(Console.ReadLine());
                    Console.WriteLine("Infomre o valor que recebe por hora: ");
                    double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    double salarioFinal = horasTrabalhadas * valorHora;
        
                    Console.WriteLine("NUMBER = {0}", numeroFuncionario);
                    Console.WriteLine("SALARY = R$ {0}", salarioFinal.ToString("F2", CultureInfo.InvariantCulture));
                }
            }
        }
        ```
        
    - 5 - Valor peças
        
        ```csharp
        using System;
        using System.Globalization;
        
        namespace Curso{
            internal class Program{
                static void Main(string[] args)
                {
                    Console.WriteLine("Informe o código da peça 1: ");
                    int numeroPeca1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a quantidade de peças 1: ");
                    int quantidadePeca1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Infomre o valor da peça 1: ");
                    double valorPeca1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
                    Console.WriteLine("Informe o código da peça 2: ");
                    int numeroPeca2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a quantidade de peças 2: ");
                    int quantidadePeca2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Infomre o valor da peça 2: ");
                    double valorPeca2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
                    double valorTotal = (quantidadePeca1 * valorPeca1) + (quantidadePeca2 * valorPeca2);
                    Console.WriteLine("VALOR A PAGAR: {0}", valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        
                }
            }
        }
        ```
        
    - 6 - Área de várias formas
        
        ```csharp
        using System;
        using System.Globalization;
        
        namespace Curso{
            internal class Program{
                static void Main(string[] args)
                {
                    Console.WriteLine("Infomre o primeiro valor: ");
                    float numA = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Informe o segundo valor: ");
                    float numB = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Informe o segundo valor: ");
                    float numC = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
                    float triangulo, ciruclo, trapezio, quadrado, retangulo;
        
                    triangulo = (numA * numC) / 2;
                    ciruclo = 3.14159f * (numC * numC);
                    trapezio = ((numA + numB) * numC) / 2;
                    quadrado = numB * numB;
                    retangulo = numA * numB;
        
                    Console.WriteLine("TRIANGULO = {0}", triangulo.ToString("F3", CultureInfo.InvariantCulture));
                    Console.WriteLine("CIRCULO = {0}", ciruclo.ToString("F3", CultureInfo.InvariantCulture));
                    Console.WriteLine("TRAPEZIO = {0}", trapezio.ToString("F3", CultureInfo.InvariantCulture));
                    Console.WriteLine("QUADRADO = {0}", quadrado.ToString("F3", CultureInfo.InvariantCulture));
                    Console.WriteLine("RETANGULO = {0}", retangulo.ToString("F3", CultureInfo.InvariantCulture));
                }
            }
        }
        ```
        

## $\tt\orange{⁕ \space Lógica \space de \space programação}$

- Operadores comparativos
    
    
    | Operador | Significado |
    | --- | --- |
    | > | maior |
    | < | menor |
    | >= | maior igual |
    | <= | menor igual |
    | == | igual |
    | != | diferente |
    
- Operadores Lógicos
    
    
    | Operador | Significado |
    | --- | --- |
    | && | E |
    | || | OU |
    | ! | NÃO |
    
    Precedência: ! → && → || 
    
- Estrutura condicional
    - Simples
        
        ```csharp
        if(condição){
        	comandos
        }
        ```
        
    - Composta
        
        ```csharp
        if(condição){
        	comandos;
        } else {
        	comandos;
        }
        ```
        
    - Encadeamentos
        
        ```csharp
        if(condição){
        	comandos;
        } else if{
        	comandos;
        } else if{
        	comandos;
        } else{
        	comandos;
        }
        ```
        
- Escopo e inicialização
    
    Escopo → Local em que uma variavel pode ser referenciada
    
- Lista de exercícios de estrutura condicional
    - 1 - Verificar se um número é negativo ou positivo
        
        ```csharp
        using System;
        
        namespace CursoConsole{
            internal class Program{
                public static void Main(string[] args){
                    int num = Int32.Parse(Console.ReadLine());
        
                    if (num < 0){
                        Console.WriteLine("{0} é um número negativo", num);
                    } else{
                        Console.WriteLine("{0} é um número positivo", num);
                    }
                }
            }
        }
        ```
        
    - 2 - Verificar se um número é par ou ímpar
        
        ```csharp
        using System;
        
        namespace CursoConsole{
            internal class Program{
                public static void Main(string[] args){
                    int num = Int32.Parse(Console.ReadLine());
        
                    if (num % 2 == 0){
                        Console.WriteLine("{0} é um número par", num);
                    } else{
                        Console.WriteLine("{0} é um número ímpar", num);
                    }
                }
            }
        }
        ```
        
    - 3 - Verificar se os números são múltiplos um do outro
        
        ```csharp
        using System;
        
        namespace CursoConsole{
            internal class Program{
                public static void Main(string[] args){
                    int num1 = Int32.Parse(Console.ReadLine());
                    int num2 = Int32.Parse(Console.ReadLine());
                    
                    if (num1 % num2 ==  0 || num2 % num1 == 0){
                        Console.WriteLine("São multiplos");
                    } else{
                        Console.WriteLine("Não são multiplos");
                    }
                }
            }
        }
        ```
        
    - 4 - Verificar duração de um jogo
        
        ```csharp
        using System;
        using System.Security.Claims;
        
        namespace CursoConsole{
            internal class Program{
                public static void Main(string[] args){
                    int inicial = Int32.Parse(Console.ReadLine());
                    int final = Int32.Parse(Console.ReadLine());
                    int duracao = 0;
                    
                    if (inicial < final){
                        duracao = final - inicial;
                    } else{
                        duracao = 24 - inicial + final;
                    }
        
                    Console.WriteLine("Duração do jogo: {0} horas",duracao);
                }
            }
        }
        ```
        
    - 5 - Soma de uma conta de lanchonete
        
        ```csharp
        using System;
        
        namespace CursoConsole{
            internal class Program{
                public static void Main(string[] args){
                    Console.WriteLine("Código - Especificação - Preco");
                    Console.WriteLine("1 - Cachorro Quente - R$ 4.00");
                    Console.WriteLine("2 - X-Salada - R$ 4.50");
                    Console.WriteLine("3 - X-Bacon - R$ 5.00");
                    Console.WriteLine("4 - Torrada Simples - R$ 2.00");
                    Console.WriteLine("4 - Refrigerante - R$ 1.50");
                    
                    int id = Int32.Parse(Console.ReadLine());
                    double quant = Double.Parse(Console.ReadLine());
                    double conta = 0.0;
                    switch (id) {
                        case 1:
                            conta = 4.00 * quant;
                            break;
                        case 2:
                            conta = 4.50 * quant;
                            break;
                        case 3:
                            conta = 5.00 * quant;
                            break;
                        case 4:
                            conta = 2.00 * quant;
                            break;
                        case 5:
                            conta = 1.50 * quant;
                            break;
                    }
        
                    Console.WriteLine("Valor total da conta: R$ {0}",conta.ToString("F2"));
                }
            }
        }
        ```
        
    - 6 - Identificador de intervalos
        
        ```csharp
        using System;
        
        namespace CursoConsole{
            internal class Program{
                public static void Main(string[] args){
                    double num = Double.Parse(Console.ReadLine());
        
                    if (num >= 0.0 && num <= 25.0){
                        Console.WriteLine("Intervalo: [0,25]");
                    } else if (num > 25.0 && num <= 50.0){
                        Console.WriteLine("Intervalo: (25,50]");
                    } else if (num > 50.0 && num <= 75.0){
                        Console.WriteLine("Intervalo: (50,75]");
                    } else if (num > 75.0 && num <= 100.0){
                        Console.WriteLine("Intervalo: (75,100]");
                    }else {
                     Console.WriteLine("Não faz parte do intervalo determinado");   
                    }
                }
            }
        }
        ```
        
- Funções
    
    ```csharp
    using System;
    
    namespace Curso
    {
        internal class Program
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Digite 3 números: ");
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                int n3 = int.Parse(Console.ReadLine());
    
                double resultado = Maior(n1,n2, n3);
    
                Console.WriteLine("Maior = " + resultado);
    
                
            }
    
            private static int Maior(int n1, int n2, int n3) {
                if(n1 > n2 && n1 > n3) {
                    return n1;
                } else if(n2 > n3) {
                    return n2;
                } else {
                    return n3;
                }
            }
        }
    }
    ```
    
- Debug no Visual Studio
    - Adicionar Break Point: F9
    - Iniciar Debug: F5
    - Próximo passo:  F10
    - Próximo passo (Entrando em funções): F11
    
    Aba “Locals” conta todas as variáveis do escopo local de onde o programa estiver executando.
    
- Estruturas de repetição
    - While: Condicional - Não sabe quantas repetição irão acontecer
        
        ```csharp
        while(condição){
        Comandos
        }
        ```
        
    - For: Contagem - Conhece o número de repetições
        
        ```csharp
        for(inicio; condição; incremento){
        Comandos
        }
        ```
        
        O incremento é a primeira coisa que acontece depois das chaves do for
        

## $\tt\orange{⁕ \space Classes, \space atributos \space e \space métodos}$

- Object e ToString
    
    Toda classe em C# é uma subclasse de Object, que tem métodos:
    
    - GetType → retorna o tipo do objeto
    - Equals → Compara se o objeto é igual a outro
    - GetHashCode → Retona um código hash do objeto
    - ToString → Converde o objeto para String
    
    Override aqui não é uma notação é uma assinatura!
    
- Membros estáticos
    
    Chamados de membros de classe, os outros são membros de instância.
    
    Eles fazem sentindo independentemente do objeto, ou seja, não precisam de um objeto para ser chamado, dá pra chamar logo na classe.
    
    Ações comuns:
    
    → Classes utilitárias
    
    → Declarações de constantes
    
    Classes que só possuem membros estáticos podem ser considerada uma classe estática, que é uma classe que não pode ser instanciada.
    
- Construtor
    
    Executada no momento da instanciação do objeto.
    
    Usada pra iniciar valores dos atributos, permitir ou obrigar que o objeto receba dados ou dependências no momento de sua instanciação
    
    Sempre haverá um construtor, caso ele não for definido, o default será utilizado. 
    
    É possível definir mais de um construtor.
    
- Sintaxe alternativa para inicializar valores sem construtores definidos
    
    Funciona até sem construtores, porque precisa do construtor padrão (sem argumentos)
    
    ```csharp
    Produto produto3 = new Produto(){
    	Nome = "TV", 
    	Preco= 5000.00, 
    	Quantidade = 20
    };
    ```
    
- This
    
    É uma referencia para o próprio objeto
    
    É útil para referenciar outro construtor em um construtor e passar o próprio objeto como argumento na chamada de um método ou construtor.
    
    - Reaproveitar um construtor:
        
        ```csharp
        public Produto(){
        	Quantidade = 0;
        }
        
        public Produto(String nome, double preco) : this(){
        	Nome = nome;
        	Preco = preco;
        }
        
        public Produto(String nome, double preco, int quantidade) : this(nome, preco){
        	Quantidade = quantidade
        }
        ```
        
    
- Encapsulamento
    
    Atributos privados começam com underline e letra minúscula 
    
- Properties - “Acessadores”
    
    São definições de métodos encapsulados, porém expondo uma sintaxe similar a de atributos, e não métodos
    
- Ordem Sugerida
    1. Atributos privados
    2. Propriedades autoimplementadas
    3. Construtores
    4. Propriedades customizadas
    5. Outros métodos da classe
- Modificadores de Acesso
    
    Assembly = Projeto
    
    Default = Internal
    
    ![Untitled](Programac%CC%A7a%CC%83o%20Orientada%20a%20Objetos%20-%20C#%2074e8d408af29459f8e77f8d7252ef3ba/Untitled.png)
    

## $\tt\orange{⁕ \space Comportamento \space de\space memória, \space vetores, \space listas, \space etc.}$

- Tipo referencia: Classe
    
    Então a classe seria como um ponteiro, temos que utilizar o construtor para instanciar uma.
    
    Se Y = X, Y aponta para o mesmo lugar que X
    
- Tipo valor: Struct
    
    Seria uma classe que pode ser instanciada sem o construtor. Não tem suporte a herança, mas permite interfaces. 
    
    Se Y = X, Y recebe uma cópia do valor de X.
    
- Garbage Collector
    
    Quando um elemento perde a referencia, o garbage collector vai limpar ele da memória em um momento futuro.
    
    Existe também a desalocação por escopo, que quando uma coisa sai do escopo, por exemplo, uma variável definida dentro de um if, ao sair do if, aquele espaço na memória é desalocado.
    
- Nullable
    
    Permite valores nullos dentro de uma variável
    
    ```csharp
    double? x = null;
    Console.WriteLine(x.GetValueOrDefault());
    Console.WriteLine(x.HasValue());
    Console.WriteLine(x.Value()); //Vai estourar um erro se o valor for null
    double y = x ?? 5; //Se x for nullo, vou jogar 5
    ```
    
- Vetores
    
    ```csharp
    double[] vect = new double[10];
    ```
    
    Ao instanciar um vetor do tipo classe, os valores padrão do vetor serão null.
    
- Modificador Params
    
    Faz com o método aceite vetores, sem ser necessariamente um vetor, ou seja, ele aceita um conjunto variável de parâmetros.
    
    Trabalhamos com os dados da mesma forma que trabalhamos com vetores.
    
    ```csharp
    public static int Sum(params int[] numbers){
    	int sum = 0
    	for(int i = 0; i < numbers.Length; i++){
    		sum += numbers[i];
    	}
    	return sum;
    }
    ```
    
- Code Smells → Devem ser evitados
    - Modificador ref
        
        Ele vai passar o valor por referencia, ou seja, como um ponteiro na memória.
        tem que colocar ela na hora de criar o método e na hora de chamar o metodo também.
        
        ```csharp
        public static void Triple(ref int x){
        	x = x * 3;
        }
        Calculator.Triple(ref x);
        ```
        
    - Modificador out
        
        Serve para guardar o resultado em um parâmetro de saída, também por referência.
        Novamente, deve-se colocar um out na criação da função e na chamada também.
        
        ```csharp
        public static void Triple(int origin, out int result){
        	result = origin * 3;
        }
        
        Calculator.Triple(x, out result);
        ```
        
    
- Boxing e unboxing
    
    Boxing: Processo de conversão de um objeto tipo valor para um objeto tipo refeência compatível. (Vai mandar do Stack para o Heap)
    Unboxing: Processo de conversao de um objeto tipo refência para um objeto tipo valor compatível. (Tem que fazer um casting, ela vai trazer o valor que estava no Heap)
    
- Foreach
    
    Sintaxe opcional e simplificada para percorrer coleções.
    
    ```csharp
    foreach (string obj in vect){
    	Console.WriteLine(obj);
    }
    ```
    
- Listas
    
    Lista é uma estrtura de dados, onde todos os dados são do mesmo tipo, ela é iniciada vazia e os elementos são alocados sob demanda, sendo ordenada por meio das posições.
    System.Collections.Generic; <- Pacote da lista
    
    ```csharp
    List<string> list = new List<string>();
    
    //No C# já da pra instanciar alguns números na sua chamada:
    List<string> list = new List<string> {"Maria", "Alex"};
    
    //Adicionar elementos no final da lista.
    list.Add("Mateus");
    
    //Adicionar objetos no final da lista.
    list.Add(new Product());
    
    //No insert é possivel escolher o indice de entrada de cada elemento.
    list.Insert(2, "João");
    
    //Count, mostra o tamanho da lista.
    Console.WriteLine("List count: " + list.Count);
    
    //Encontrar o primeiro ou último elemento da lista que satisfaça um predicado (Algo que retorna true ou false): Find ou FindLast.
    string s1 = list.Find(x => x[0] == 'M');
    Console.WriteLine("First 'A': " + s1);
    
    string s2 = list.FindLast(x => x[0] == "A");
    Console.WriteLine("Last 'A': " + s2);
    
    //Encontrar a primeira ou última posição da lista que satisfaça um predicado (Algo que retorna true ou false): FindIndex ou FindLastIndex.
    
    int pos1 = list.FindIndex(x => x[0] == 'M');
    Console.WriteLine("First postion 'M': " + pos1);
    
    int pos2 = list.FindLastIndex(x => x[0] == "A");
    Console.WriteLine("Last position 'A': " + pos2);
    
    //Filtrar a Lista com base em um predicado: FindAll.
    List<string> list2 = list.FindAll(x => x.Length == 5);
    foreach (string obj in list2){
    	Console.WriteLine(obj);
    }
    
    //Remover elementos da lista: 
    list.Remove("Alex"); //Se ele não encontrar o elemento, ele não faz nada.
    list.RemoveAll(x => x[0] == 'M'); //Remove todos que começam com N
    list.RemoveAt(2); //Remove por Index
    list.RemoveRange(2, 2) //Parametros: posição inicial e depois uma contagem.
    ```
    
- Matriz
    
    Matriz é um arranjo bidimensional. Linhas e Colunas.
    Estrutras de dados homogêneas, e ela é alocada de uma vez só (tamanho fixo)
    
    ```csharp
    int [,] num = new double[2, 3]
    
    Console.WriteLine(num.Length); //Tamanho total: linhas x colunas
    
    Console.WriteLine(num.Rank); //quantidade de Linhas
    
    Console.WriteLine(num.GetLength(0)); //Tamanho da primeira dimensão: Linhas
    Console.WriteLine(num.GetLength(1)); //Tamanho da segunda dimensão: Colunas
    ```
    

## $\tt\orange{⁕ \space Tópicos\space especiais\space em \space C\#}$
