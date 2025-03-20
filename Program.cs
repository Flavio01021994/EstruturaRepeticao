// Estruturas Condicionais
// Estruturas de repeticao 
// repete uma ação 

// imprimir todos os números de 1 ate 5 

// enquanto - While
//int numero = 1;

//// Repete uma acao, ENQUANTO algo for verdade
//while (numero < 6)
//{
//    Console.WriteLine(numero);
//    // incremento
//    numero = numero + 1;
//    // numero++; atalho da linha de cima
//}


//// faça - enquanto (Do/While)
//int idade; 

//do
//{
//    Console.WriteLine("Informe a idade:");
//    idade = int.Parse(Console.ReadLine());
//} while(idade !=22);

////para - FOR
//// Quero imprimir os numeros do 1 ao 5
//// 1 cria uma variavel chamada i () indice
//// 2 - Condicao para continuar
//// 3 - incremento ao executar chaves (++)
//for (int i = 0; i < length; i++)
//{
//    Console.WriteLine(i);
//}

////1. Contagem de 1 a 20**

//// Crie um programa que exiba os números de 1 a 20 na tela.

// tratamento de exceção 
//int numero = int.Parse(Console.ReadLine());

//// exception = todo erro tem este nome
//// IOException - In and Out - Entrada e saida
//// FormatException - Erros no formato (tipo de dado)
//// try/catch - tentar/pegar
//// Breakpont
//StreamReader reader = null;
//try

//{
//    reader = new StreamReader("meuarquivo,txt");
//    int num = int.Parse(Console.ReadLine());

//    int resultado = num / 0;
//}
//catch (FormatException ex)
//{
//    Console.WriteLine("Erro: Informe apenas números.");
//}
//catch (OverflowException ex)
//{
//    Console.WriteLine("Erro: numero muito grande");

//catch (DivideByZeroException ex)
//{
//    Console.WriteLine("Erro: tentou dividir por zero");
//}

//finally
//{
//    reader.Close();
//}
//int idade = int.Parse(Console.ReadLine());

//if (idade > 120)
//{
//    throw new ArgumentOutOfRangeException("Idade inválida");
//}
// exercicios

//### **1. Entrada Segura de Números**

//Crie um programa que peça ao usuário para digitar um número inteiro. O programa deve usar `try/catch` para garantir que o usuário insira um número válido.

//**Erros a serem tratados:**

//-Usuário digitar um texto ao invés de um número. (`FormatException`)

//int idade = int.Parse(Console.ReadLine());
//{
//    throw new ArgumentOutOfRangeException("Idade não pode ser negativa");
//}


//### **2. Divisão Segura**

//Crie um programa que peça dois números ao usuário e divida o primeiro pelo segundo. Use `try/catch` para evitar divisão por zero e entrada inválida.

//**Erros a serem tratados:**

//-Usuário digitar um valor não numérico. (`FormatException`)
//- Tentativa de divisão por zero. (`DivideByZeroException`)

//try
//{
//    int num1 = int.Parse(Console.ReadLine());
//    int num2 = int.Parse(Console.ReadLine());
//    int resultado = num1 / num2;
//}

//catch(DivideByZeroException)
//{
//    Console.WriteLine("Divisão por zero");
//}
//catch (FormatException)
//{
//    Console.WriteLine("Informe apenas números");
//}

//### **3. Validação de Idade**

//Peça ao usuário para inserir sua idade e diga se ele é maior ou menor de idade. Use `try/catch` para evitar entradas inválidas.

//**Erros a serem tratados:**

//-Usuário digitar um texto ao invés de um número. (`FormatException`)
//- Usuário inserir um número muito grande. (`OverflowException`)

//try
//{
//    int idade = int.Parse("Informe apenas números");
//    if (idade < 0 || idade > 120) ;

//}
//catch (FormatException)
//{
//    Console.WriteLine("Informe apenas números");
//}
//catch (OverflowException)
//{
//    Console.WriteLine("Idade invalida");
//}