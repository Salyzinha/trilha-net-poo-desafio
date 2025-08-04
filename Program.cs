using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia1 = new Nokia("(86)9654-3210", "Nokia Alpha 75", "222222222222222", 64);
Console.WriteLine("Smartphone Nokia:");
nokia1.Ligar();
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo("Facebook");
Console.WriteLine("--------------------");

Iphone iphone1 = new Iphone("(86)9876-5432", "iPhone 14", "111111111111111", 128);
Console.WriteLine("Smartphone iPhone:");
iphone1.Ligar();
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("Instagram");
Console.WriteLine("--------------------");