Console.Clear();

Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("               Bem vindo                "); Thread.Sleep(800);
Console.WriteLine(" 💻💵 Calculadora Crédito Rotativo 💵💻 "); Thread.Sleep(1300);
Console.ResetColor();
Console.WriteLine();

Console.Write("Digite o valor total da fatura (R$)             : ");
double valorFatura = Convert.ToSingle(Console.ReadLine()); 

Console.Write("Digite o percentual do pagamento mínimo (%)     : ");
double jurosPagMinimo = Convert.ToSingle(Console.ReadLine()); 
double jurosPagMinimo2 = jurosPagMinimo/100;

Console.Write("Digite o percentual da taxa de juros mensais (%): ");
double jurosMensais = Convert.ToSingle(Console.ReadLine()); 
double jurosMensais2 = jurosMensais/100;

Console.WriteLine();
Console.Write("Obrigada, aqui está seu resultado: 💻"); Thread.Sleep(1500);
Console.Clear();

double valPagMinimo = valorFatura * jurosPagMinimo2; //Valor do pagamento mínimo
double valNaoPago = valorFatura - valPagMinimo; //Val não pago:
double jurosPagar = jurosMensais2 * valNaoPago; //Juros
double iofMensal = 0.0038 * valNaoPago; //IOF Mensal
double iofDiario = 0.000082 * 30 * valNaoPago; //IOF Diário
double valAPagar = valNaoPago + 
    jurosPagar + 
    iofMensal + 
    iofDiario; //Val da prox fatura
double credRotativo = jurosPagar + 
    iofMensal + 
    iofDiario; //Juros totais/ credito rotativo

Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine(@"➕〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️➕ 
 |    Resultado Crédito de Juros Rorativo    | 
➕〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️➕ ");
 Console.ResetColor();
Console.WriteLine($@"➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖ 
  Valor total da fatura: {valorFatura:C}
  Pagamento mínimo:      {jurosPagMinimo}% 
  Taxa de juros mensais: {jurosMensais}% 
➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖ 
  Valor Pagamento mínimo: {valPagMinimo:C} 
➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖
  Caso o valor mínimo seja pago:

  Valor não pago: {valNaoPago:C}
  Juros:          {jurosPagar:C}
  IOF Mensal:     {iofMensal:C}
  IOF Diário:     {iofDiario:C}
➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖ 
  Valor a pagar na próxima fatura: {valAPagar:C}
  Custo do crédito rotativo:       {credRotativo:C}
➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖ 
 ");
