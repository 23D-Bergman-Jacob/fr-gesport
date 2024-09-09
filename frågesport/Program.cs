using System.Globalization;

string svar;
string spela;
int ocd;
while (1==1){
ocd = 0;
System.Console.WriteLine("Är Jacob den enda 18 åringen i klassen?");
System.Console.WriteLine("a=han är inte 18 b=nej c=ja");
svar = Console.ReadLine();
if (svar.ToLower() == "c") {ocd ++;}
System.Console.WriteLine("Hur många bultar finns det i ölandsbron?");
System.Console.WriteLine("a=0  b=20438 c= 7 428 954");
svar = Console.ReadLine();
if (svar.ToLower() == "a"){ocd ++;}
System.Console.WriteLine("Är bananen en");
System.Console.WriteLine("a=frukt b=bär c=grönsak");
svar = Console.ReadLine();
if (svar.ToLower() == "b"){ocd ++;}
System.Console.WriteLine("Är glas");
System.Console.WriteLine("a=en vätska b=en gas c=fast form");
svar = Console.ReadLine();
if (svar.ToLower() == "a"){ocd ++;}
System.Console.WriteLine("Vart uppfans lycko cakan?");
System.Console.WriteLine("a=China b=Japan c=USA");
svar = Console.ReadLine();
if (svar.ToLower() == "b"){ocd ++;}
System.Console.WriteLine("Vart uppfans glassen");
System.Console.WriteLine("a=Frankrike b=USA c=China");
svar = Console.ReadLine();
if (svar.ToLower() == "c"){ocd ++;}
System.Console.WriteLine("I pacman vad hette det rosa spöket");
System.Console.WriteLine("a=Pinky b=Inky c=Clyde");
svar = Console.ReadLine();
if (svar.ToLower() == "a"){ocd ++ ;}
System.Console.WriteLine("Vad står J för i Donald J. Trump");
System.Console.WriteLine("a=Junior b=John c=James");
svar = Console.ReadLine();
if (svar.ToLower() == "b"){ocd ++;}
if (ocd < 3){System.Console.WriteLine("Gå tillbaka till skolan! Du fick bara");  System.Console.WriteLine(ocd+"poäng");}
if (ocd > 3|ocd<5){
System.Console.WriteLine("du fick: "+ocd+" poäng");}
if (ocd>5){System.Console.WriteLine("Snyggt! du fick"+ocd+" poäng");}
System.Console.WriteLine("Vill du spela igen Ja/Nej");
while (1==1){
spela = Console.ReadLine();
if (spela.ToLower()=="ja"){break;}
if (spela.ToLower()=="nej"){break;}
}
if (spela.ToLower() == "nej"){break;}
}
Console.ReadLine();
