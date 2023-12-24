using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456", "tipo 1", "11111111", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("999999", "15 Pro Max", "22222222", 512);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");