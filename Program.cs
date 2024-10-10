using System.ComponentModel;
using DesafioPOO.Models;

Iphone cel1 = new Iphone(numero:"111", modelo:"Iphone 12 pro max", imei:"1111111", memoria:"40gb livres");
Nokia cel2 = new Nokia(numero: "222", modelo: "Nokia 3310", imei: "222222", memoria: "1mb");

//iphone
cel1.Ligar();
cel1.ReceberLigacao();
cel1.InstalarAplicativo("Zap");

//nokia

cel2.Ligar();
cel2.ReceberLigacao();
cel1.InstalarAplicativo("snake game");