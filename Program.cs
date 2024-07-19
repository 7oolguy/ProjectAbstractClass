using ProjectChallange.Models;

Console.WriteLine("Digite Numero de telephone:");
string numero = Console.ReadLine();

Console.WriteLine("Digite Modelo do telephone:");
string modelo = Console.ReadLine();

Console.WriteLine("Digite IMEI do telephone:");
string imei = Console.ReadLine();

Console.WriteLine("Digite Memoria do telephone:");
int memoria = int.Parse(Console.ReadLine());

Iphone iphone = new Iphone(numero, modelo, imei, memoria);
iphone.Ligar();
iphone.ReceberLigacao();
Console.WriteLine("Digite Nome do App para instalar:");
string app = Console.ReadLine();
iphone.InstalarAplicativo(app);

Nokia nokia = new Nokia(numero, modelo, imei, memoria);
nokia.Ligar();
nokia.ReceberLigacao();
Console.WriteLine("Digite Nome do App para instalar:");
app = Console.ReadLine();
nokia.InstalarAplicativo(app);