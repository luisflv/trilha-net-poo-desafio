using DesafioPOO.Models;


Console.Clear();
// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");

Smartphone nokia = new Nokia("123456", "Modelo 1", "111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine();

Console.WriteLine("Smartphone Iphone: ");


Smartphone iphone = new Iphone("78910", "Modelo 2", "222222", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");