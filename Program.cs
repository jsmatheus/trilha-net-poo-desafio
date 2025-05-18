using DesafioPOO.Models;

Nokia nokia = new Nokia("123 456", "S1", "909001", "32GB");
Iphone iphone = new Iphone("678 890", "X", "123423", "64GB");

nokia.InstalarAplicativo("Whatsapp");
iphone.InstalarAplicativo("Telegram");

nokia.Ligar();
iphone.ReceberLigacao();