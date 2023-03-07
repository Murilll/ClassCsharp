ContaCorrente conta1 = new ContaCorrente("123456", "Murilo", 500);
ContaCorrente conta2 = new ContaCorrente("654321", "Douglas", 400);
ContaCorrente conta3 = new ContaCorrente("765343", "Ana", 600);
ContaCorrente conta4 = new ContaCorrente("123123", "Fabricio", 100);
ContaCorrente conta5 = new ContaCorrente("321321", "Diamantina", 700);

Retangulo retan1 = new Retangulo(10, 22);
Retangulo retan2 = new Retangulo(8, 20);
Retangulo retan3 = new Retangulo(70, 62);

Funcionario func1 = new Funcionario("Murilo", "123.456.789-10", 1500, 50);
Funcionario func2 = new Funcionario("Fulano", "109.876.543-21", 2000, 40);

Console.WriteLine($"\n" +
    $"Nº da conta = {conta1.NúmeroConta}\n" +
    $"Nome: {conta1.Nome}\n" +
    $"Saldo: {conta1.Saldo}");

conta1.alterarNome("Murillo");
conta1.deposito(300);
conta1.saque(100);

Console.WriteLine($"\n" +
    $"Nº da conta = {conta1.NúmeroConta}\n" +
    $"Nome: {conta1.Nome}\n" +
    $"Saldo: {conta1.Saldo}");

Console.WriteLine($"\nA: {retan1.A}" +
    $"\nB: {retan1.B}" +
    $"\nArea: {retan1.Area()}" +
    $"\nPerimetro: {retan1.Perimetro()}");

func1.GetBonificacao(500);
func1.AumentarSalario(1000);
func1.GetFaltas(20);

Console.WriteLine($"\nNome Funcionario: {func1.Nome}" +
    $"\nCPF: {func1.CPF}" +
    $"\nSalario: {func1.Salário}" +
    $"\nFaltou: {func1.Faltou()}\n\n");

float x = float.Parse(Console.ReadLine());
float y = float.Parse(Console.ReadLine());

Console.WriteLine($"\nSOMA: {Calculadora.soma(x,y)}" +
    $"\nSUB: {Calculadora.sub(x,y)}" +
    $"\nMULT: {Calculadora.mult(x,y)}" +
    $"\nDIV: {Calculadora.div(x,y)}");
