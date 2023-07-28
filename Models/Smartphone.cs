using DesafioPOO.Models;

Smartphone nokia = new Nokia("551156779338", "C1", "12345678910", 64 );
Smartphone iphone = new Iphone("551155649338", "I12", "5698778910", 512 );

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("DIO");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("DIO");
