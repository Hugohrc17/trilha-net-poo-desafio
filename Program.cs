using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo X", imei: "22222", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone(numero: "123456", modelo: "Modelo X", imei: "22222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");