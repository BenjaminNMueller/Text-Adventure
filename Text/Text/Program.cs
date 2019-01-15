using System;

namespace Text
{
    class Program
    {
        static void Main(string[] args)
        {
            string Hauptcharakter, Person, Böse, Lakeien, Problem1, Problem2;
            string grenze = "+----------------------------------------------------------------------------------------------------+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-----------------------------------------------------------------------------------------------+";
            Console.WriteLine(grenze);
            Console.SetCursorPosition(97, 3);
            Console.WriteLine("Dies ist eine Geschichte bei der du mitbestimmen kannst. \n\n {0}",grenze);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(grenze);
            Console.SetCursorPosition(95, 3);
            Console.WriteLine("Also. Starten wir. Was ist dein Hauptcharakter?");
            Console.SetCursorPosition(93, 4);
            Console.WriteLine("M = Magier D = Dieb K = Krieger P = Pferd");
            Console.SetCursorPosition(110, 5);
            Console.WriteLine("Eingabe = \n");
            Console.WriteLine(grenze);
            Console.SetCursorPosition(120, 5);
            Hauptcharakter = Console.ReadLine().ToUpper();
            Console.SetCursorPosition(95, 3);
            Console.WriteLine("Was ist die zweite Person, die in der Geschichte vorkommt?");
            Console.SetCursorPosition(93, 4);
            Console.WriteLine("        P = Prinzessin O= Opa H = Hund K = Kürbis   ");
            Console.SetCursorPosition(110, 5);
            Console.WriteLine("Eingabe =  ");
            Console.SetCursorPosition(120, 5);
            Person = Console.ReadLine().ToUpper();
            Console.Clear();
            Console.WriteLine(grenze);
            Console.SetCursorPosition(95, 3);
            Console.WriteLine("Wer ist der Bösewicht der Geschichte?");
            Console.SetCursorPosition(93, 4);
            Console.WriteLine("B = böser Magier K = König M = Mathe H = Huhn ");
            Console.SetCursorPosition(110, 5);
            Console.WriteLine("Eingabe = \n");
            Console.WriteLine(grenze);
            Console.SetCursorPosition(120, 5);
            Böse = Console.ReadLine().ToUpper();
            Console.Clear();
            Console.WriteLine(grenze);
            Console.SetCursorPosition(95, 3);
            Console.WriteLine("Wer sind die Lakeien des Bösewichten (Mehrzahl)?");
            Console.SetCursorPosition(110, 5);
            Console.WriteLine("Eingabe = \n");
            Console.WriteLine(grenze);
            Console.SetCursorPosition(120, 5);
            Lakeien = Console.ReadLine().ToUpper();
            switch(Hauptcharakter)
            {
                case "M":
                    Hauptcharakter = "Magier";
                    break;
                case "D":
                    Hauptcharakter = "Dieb";
                    break;
                case "K":
                    Hauptcharakter = "Krieger";
                    break;
                case "P":
                    Hauptcharakter = "Pferd";
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Fehler bei Hauptcharakter");
                    Console.Read();
                    break;
            }
            switch (Person)
            {
                case "P":
                    Person = "Prinzessin";
                    break;
                case "O":
                    Person = "Opa";
                    break;
                case "H":
                    Person = "Hund";
                    break;
                case "K":
                    Person = "Kürbis";
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Fehler bei Person");
                    Console.Read();
                    break;
            }
            switch (Böse)
            {
                case "B":
                    Böse = "Böser Magier";
                    break;
                case "K":
                    Böse = "König";
                    break;
                case "M":
                    Böse = "Mathe";
                    break;
                case "H":
                    Böse = "Huhn";
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Fehler bei Bösewicht");
                    Console.Read();
                    break;
            }
            switch(Hauptcharakter)
            {
                case "Magier":
                    switch(Person)
                    {
                        case "Prinzessin":
                            switch(Böse)
                            {
                                case "Böser Magier":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Magier. Der Magier war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Die Prinzessin wurde vom bösen Magier entführt!\n Direkt macht sich der Magier auf den weg um die Prinzessin zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen Magiers. Doch seine Lakeien, die {0} versperrten dem Magier den Weg.\n \" Wir, die {0} werden dich nicht zum bösen Magier hindurch lassen.\"",Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "König":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Magier. Der Magier war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! die Prinzessin wurde vom König entführt!\n Direkt macht sich der Magier auf den weg um die Prinzessin zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen Königs. Doch seine Lakeien, die {0} versperrten ihm den Weg.\n \" Wir, die {0} werden dich nicht zu unserem König hindurch lassen.\"",Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "Mathe":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Magier. Der Magier war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! die Prinzessin wurde von Mathe entführt!\n Direkt macht sich der Magier auf den weg um die Prinzessin zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm von Mathe. Doch seine Lakeien, die {0} versperrten dem Magier den Weg.\n \" Wir, die {0} werden dich nicht zu Mathe hindurch lassen.\"",Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "Huhn":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Magier. Der Magier war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Die Prinzessin wurde von einem Huhn entführt!\n Direkt macht sich der Magier auf den weg um die Prinzessin zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen Huhn. Doch seine Lakeien, die {0} versperrten dem Magier den Weg.\n \" Wir, die {0} werden dich nicht zum Huhn hindurch lassen.\"",Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                            }
                            break;
                        case "Opa":
                            switch (Böse)
                            {
                                case "Böser Magier":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Magier. Der Magier war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Opa wurde von dem bösen Magier entführt!\n Direkt macht sich der Magier auf den weg um seinen Opa zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen Magiers. Doch seine Lakeien, die {0} versperrten dem Magier den Weg.\n \" Wir, die {0} werden dich nicht zum bösen Magier hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "König":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Magier. Der Magier war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Opa wurde von dem König entführt!\n Direkt macht sich der Magier auf den weg um den Opa zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen König. Doch seine Lakeien, die {0} versperrten dem Magier den Weg.\n \" Wir, die {0} werden dich nicht zu unserem König hindurch lassen.\"",Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "Mathe":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Magier. Der Magier war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Opa wurde von Mathe entführt!\n Direkt macht sich der Magier auf den weg um den Opa zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm vn Mathe. Doch seine Lakeien, die {0} versperrten dem Magier den Weg.\n \" Wir, die {0} werden dich nicht zu Mathe hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "Huhn":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Magier. Der Magier war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Opa wurde von einem Huhn entführt!\n Direkt macht sich der Magier auf den weg um den Opa zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen Huhns. Doch seine Lakeien, die {0} versperrten dem Magier den Weg.\n \" Wir, die {0} werden dich nicht zum Huhn hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                            }
                            break;
                        case "Hund":
                            switch (Böse)
                            {
                                case "Böser Magier":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Magier. Der Magier war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Hund wurde von dem bösen Magier entführt!\n Direkt macht sich der Magier auf den weg um den Hund zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen Magiers. Doch seine Lakeien, die {0} versperrten dem Magier den Weg.\n \" Wir, die {0} werden dich nicht zum Magier hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "König":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Magier. Der Magier war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Hund wurde von dem König entführt!\n Direkt macht sich der Magier auf den weg um den Hund zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen Königs. Doch seine Lakeien, die {0} versperrten dem Magier den Weg.\n \" Wir, die {0} werden dich nicht zum König hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "Mathe":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Magier. Der Magier war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Hund wurde von Mathe entführt!\n Direkt macht sich der Magier auf den weg um den Hund zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm von Mathe. Doch seine Lakeien, die {0} versperrten dem Magier den Weg.\n \" Wir, die {0} werden dich nicht zu Mathe hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "Huhn":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Magier. Der Magier war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Hund wurde von einem Huhn entführt!\n Direkt macht sich der Magier auf den weg um den Hund zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen Huhns. Doch seine Lakeien, die {0} versperrten dem Magier den Weg.\n \" Wir, die {0} werden dich nicht zum Huhn hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                            }
                            break;
                        case "Kürbis":
                            switch (Böse)
                            {
                                case "Böser Magier":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Magier. Der Magier war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Kürbis wurde von dem bösen Magier entführt!\n Direkt macht sich der Magier auf den weg um den Kürbis zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen Magiers. Doch seine Lakeien, die {0} versperrten dem Magier den Weg.\n \" Wir, die {0} werden dich nicht zum Magier hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "König":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Magier. Der Magier war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Kürbis wurde von dem König entführt!\n Direkt macht sich der Magier auf den weg um den Kürbis zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen Königs. Doch seine Lakeien, die {0} versperrten dem Magier den Weg.\n \" Wir, die {0} werden dich nicht zum König hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "Mathe":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Magier. Der Magier war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Kürbis wurde von Mathe entführt!\n Direkt macht sich der Magier auf den weg um den Kürbis zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm von Mathe. Doch seine Lakeien, die {0} versperrten dem Magier den Weg.\n \" Wir, die {0} werden dich nicht zu Mathe hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "Huhn":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Magier. Der Magier war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Kürbis wurde von einem Huhn entführt!\n Direkt macht sich der Magier auf den weg um den Kürbis zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des Huhns. Doch seine Lakeien, die {0} versperrten dem Magier den Weg.\n \" Wir, die {0} werden dich nicht zum Huhn hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                            }
                            break;
                    }
                    break;
                case "Dieb":
                    switch (Person)
                    {
                        case "Prinzessin":
                            switch (Böse)
                            {
                                case "Böser Magier":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Dieb. Der Dieb war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Die Prinzessin wurde von dem bösen Magier entführt!\n Direkt macht sich der Dieb auf den weg um die Prinzessin zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen Magiers. Doch seine Lakeien, die {0} versperrten dem Dieb den Weg.\n \" Wir, die {0} werden dich nicht zum Magier hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "König":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Dieb. Der Dieb war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Die Prinzessin wurde von dem König entführt!\n Direkt macht sich der Dieb auf den weg um die Prinzessin zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen Königs. Doch seine Lakeien, die {0} versperrten dem Dieb den Weg.\n \" Wir, die {0} werden dich nicht zum König hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "Mathe":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Dieb. Der Dieb war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Die Prinzessin wurde von Mathe entführt!\n Direkt macht sich der Dieb auf den weg um die Prinzessin zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm von Mathe. Doch seine Lakeien, die {0} versperrten dem Dieb den Weg.\n \" Wir, die {0} werden dich nicht zu Mathe hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "Huhn":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Dieb. Der Dieb war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Die Prinzessin wurde von Einem Huhn entführt!\n Direkt macht sich der Dieb auf den weg um die Prinzessin zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen Huhns. Doch seine Lakeien, die {0} versperrten dem Dieb den Weg.\n \" Wir, die {0} werden dich nicht zum Huhn hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                            }
                            break;
                        case "Opa":
                            switch (Böse)
                            {
                                case "Böser Magier":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Dieb. Der Dieb war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Opa wurde von dem bösen Magier entführt!\n Direkt macht sich der Dieb auf den weg um den Opa zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen Magiers. Doch seine Lakeien, die {0} versperrten dem Dieb den Weg.\n \" Wir, die {0} werden dich nicht zum Magier hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "König":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Dieb. Der Dieb war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Opa wurde von dem König entführt!\n Direkt macht sich der Dieb auf den weg um den Opa zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen Magiers. Doch seine Lakeien, die {0} versperrten dem Dieb den Weg.\n \" Wir, die {0} werden dich nicht zum Magier hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "Mathe":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Dieb. Der Dieb war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Opa wurde von dem bösen Magier entführt!\n Direkt macht sich der Dieb auf den weg um den Opa zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen Magiers. Doch seine Lakeien, die {0} versperrten dem Dieb den Weg.\n \" Wir, die {0} werden dich nicht zum Magier hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "Huhn":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Dieb. Der Dieb war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Opa wurde von dem bösen Magier entführt!\n Direkt macht sich der Dieb auf den weg um den Opa zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen Magiers. Doch seine Lakeien, die {0} versperrten dem Dieb den Weg.\n \" Wir, die {0} werden dich nicht zum Magier hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                            }
                            break;
                        case "Hund":
                            switch (Böse)
                            {
                                case "Böser Magier":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Dieb. Der Dieb war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Hund wurde von dem bösen Magier entführt!\n Direkt macht sich der Dieb auf den weg um den Hund zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen Magiers. Doch seine Lakeien, die {0} versperrten dem Dieb den Weg.\n \" Wir, die {0} werden dich nicht zum Magier hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "König":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Dieb. Der Dieb war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Hund wurde von dem König entführt!\n Direkt macht sich der Dieb auf den weg um den Hund zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen Königs. Doch seine Lakeien, die {0} versperrten dem Dieb den Weg.\n \" Wir, die {0} werden dich nicht zum König hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "Mathe":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Dieb. Der Dieb war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Hund wurde von Mathe entführt!\n Direkt macht sich der Dieb auf den weg um den Hund zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm von Mathe. Doch seine Lakeien, die {0} versperrten dem Dieb den Weg.\n \" Wir, die {0} werden dich nicht zu Mathe hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "Huhn":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Dieb. Der Dieb war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Hund wurde von einem Huhn entführt!\n Direkt macht sich der Dieb auf den weg um den Hund zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen Huhns. Doch seine Lakeien, die {0} versperrten dem Dieb den Weg.\n \" Wir, die {0} werden dich nicht zum Huhn hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                            }
                            break;
                        case "Kürbis":
                            switch (Böse)
                            {
                                case "Böser Magier":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Dieb. Der Dieb war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Kürbis wurde von dem bösen Magier entführt!\n Direkt macht sich der Dieb auf den weg um den Kürbis zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen Magiers. Doch seine Lakeien, die {0} versperrten dem Dieb den Weg.\n \" Wir, die {0} werden dich nicht zum Magier hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "König":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Dieb. Der Dieb war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Kürbis wurde vom König entführt!\n Direkt macht sich der Dieb auf den weg um den Kürbis zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen Königs. Doch seine Lakeien, die {0} versperrten dem Dieb den Weg.\n \" Wir, die {0} werden dich nicht zum König hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "Mathe":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Dieb. Der Dieb war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Kürbis wurde von Mathe entführt!\n Direkt macht sich der Dieb auf den weg um den Kürbis zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm von Mathe. Doch seine Lakeien, die {0} versperrten dem Dieb den Weg.\n \" Wir, die {0} werden dich nicht zu Mathe hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "Huhn":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Dieb. Der Dieb war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Kürbis wurde von einem Huhn entführt!\n Direkt macht sich der Dieb auf den weg um den Kürbis zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen Huhns. Doch seine Lakeien, die {0} versperrten dem Dieb den Weg.\n \" Wir, die {0} werden dich nicht zum Huhn hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                            }
                            break;
                    }
                    break;
                case "Krieger":
                    switch (Person)
                    {
                        case "Prinzessin":
                            switch (Böse)
                            {
                                case "Böser Magier":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Krieger. Der Krieger war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Die Prinzessin wurde von dem bösen Magier entführt!\n Direkt macht sich der Krieger auf den weg um die Prinzessin zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen Magiers. Doch seine Lakeien, die {0} versperrten dem Krieger den Weg.\n \" Wir, die {0} werden dich nicht zum Magier hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "König":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Krieger. Der Krieger war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Die Prinzessin wurde von dem König entführt!\n Direkt macht sich der Krieger auf den weg um die Prinzessin zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen Königs. Doch seine Lakeien, die {0} versperrten dem Krieger den Weg.\n \" Wir, die {0} werden dich nicht zum König hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "Mathe":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Krieger. Der Krieger war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Die Prinzessin wurde von Mathe entführt!\n Direkt macht sich der Krieger auf den weg um die Prinzessin zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm von Mathe. Doch seine Lakeien, die {0} versperrten dem Krieger den Weg.\n \" Wir, die {0} werden dich nicht zu Mathe hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "Huhn":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Krieger. Der Krieger war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Die Prinzessin wurde von einem Huhn entführt!\n Direkt macht sich der Krieger auf den weg um die Prinzessin zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen Huhns. Doch seine Lakeien, die {0} versperrten dem Krieger den Weg.\n \" Wir, die {0} werden dich nicht zum Huhn hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                            }
                            break;
                        case "Opa":
                            switch (Böse)
                            {
                                case "Böser Magier":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Krieger. Der Krieger war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Opa wurde von dem bösen Magier entführt!\n Direkt macht sich der Krieger auf den weg um den Opa zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen Magiers. Doch seine Lakeien, die {0} versperrten dem Krieger den Weg.\n \" Wir, die {0} werden dich nicht zum Magier hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "König":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Krieger. Der Krieger war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Opa wurde von dem König entführt!\n Direkt macht sich der Krieger auf den weg um den Opa zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen Königs. Doch seine Lakeien, die {0} versperrten dem Krieger den Weg.\n \" Wir, die {0} werden dich nicht zum König hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "Mathe":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Krieger. Der Krieger war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Opa wurde von Mathe entführt!\n Direkt macht sich der Krieger auf den weg um den Opa zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm von Mathe. Doch seine Lakeien, die {0} versperrten dem Krieger den Weg.\n \" Wir, die {0} werden dich nicht zu Mathe hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "Huhn":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Krieger. Der Krieger war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Opa wurde von einem Huhn entführt!\n Direkt macht sich der Krieger auf den weg um den Opa zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen Huhns. Doch seine Lakeien, die {0} versperrten dem Krieger den Weg.\n \" Wir, die {0} werden dich nicht zum Huhn hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                            }
                            break;
                        case "Hund":
                            switch (Böse)
                            {
                                case "Böser Magier":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Krieger. Der Krieger war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Hund wurde von dem bösen Magier entführt!\n Direkt macht sich der Krieger auf den weg um den Hund zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen Magiers. Doch seine Lakeien, die {0} versperrten dem Krieger den Weg.\n \" Wir, die {0} werden dich nicht zum Magier hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "König":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Krieger. Der Krieger war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Hund wurde von dem König entführt!\n Direkt macht sich der Krieger auf den weg um den Hund zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen Königs. Doch seine Lakeien, die {0} versperrten dem Krieger den Weg.\n \" Wir, die {0} werden dich nicht zum König hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "Mathe":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Krieger. Der Krieger war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Hund wurde von Mathe entführt!\n Direkt macht sich der Krieger auf den weg um den Hund zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm von Mathe. Doch seine Lakeien, die {0} versperrten dem Krieger den Weg.\n \" Wir, die {0} werden dich nicht zu Mathe hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "Huhn":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Krieger. Der Krieger war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Hund wurde von einem Huhn entführt!\n Direkt macht sich der Krieger auf den weg um den Hund zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen Huhns. Doch seine Lakeien, die {0} versperrten dem Krieger den Weg.\n \" Wir, die {0} werden dich nicht zum Huhn hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                            }
                            break;
                        case "Kürbis":
                            switch (Böse)
                            {
                                case "Böser Magier":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Krieger. Der Krieger war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Kürbis wurde von dem bösen Magier entführt!\n Direkt macht sich der Krieger auf den weg um den Kürbis zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen Magiers. Doch seine Lakeien, die {0} versperrten dem Krieger den Weg.\n \" Wir, die {0} werden dich nicht zum Magier hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "König":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Krieger. Der Krieger war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Kürbis wurde von dem König entführt!\n Direkt macht sich der Krieger auf den weg um den Kürbis zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen Königs. Doch seine Lakeien, die {0} versperrten dem Krieger den Weg.\n \" Wir, die {0} werden dich nicht zum König hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "Mathe":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Krieger. Der Krieger war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Kürbis wurde von Mathe entführt!\n Direkt macht sich der Krieger auf den weg um den Kürbis zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm von Mathe. Doch seine Lakeien, die {0} versperrten dem Krieger den Weg.\n \" Wir, die {0} werden dich nicht zu Mathe hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "Huhn":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über einen Krieger. Der Krieger war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht er da?! Sein Kürbis wurde von einem Huhn entführt!\n Direkt macht sich der Krieger auf den weg um den Kürbis zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam er bis zum Turm des bösen Huhns. Doch seine Lakeien, die {0} versperrten dem Krieger den Weg.\n \" Wir, die {0} werden dich nicht zum Huhn hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                            }
                            break;
                    }
                    break;
                case "Pferd":
                    switch (Person)
                    {
                        case "Prinzessin":
                            switch (Böse)
                            {
                                case "Böser Magier":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über ein Pferd. Das Pferd war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht es da?! Die Prinzessin wurde vom bösen Magier entführt!\n Direkt macht sich das Pferd auf den Weg um die Prinzessin zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam es bis zum Turm des bösen Magiers. Doch seine Lakeien, die {0} versperrten dem Pferd den Weg.\n \" Wir, die {0} werden dich nicht zum Magier hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "König":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über ein Pferd. Das Pferd war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht es da?! Die Prinzessin wurde vom König entführt!\n Direkt macht sich das Pferd auf den Weg um die Prinzessin zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam es bis zum Turm des bösen Königs. Doch seine Lakeien, die {0} versperrten dem Pferd den Weg.\n \" Wir, die {0} werden dich nicht zum König hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "Mathe":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über ein Pferd. Das Pferd war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht es da?! Die Prinzessin wurde von Mathe entführt!\n Direkt macht sich das Pferd auf den Weg um die Prinzessin zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam es bis zum Turm von Mathe. Doch seine Lakeien, die {0} versperrten dem Pferd den Weg.\n \" Wir, die {0} werden dich nicht zu Mathe hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "Huhn":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über ein Pferd. Das Pferd war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht es da?! Die Prinzessin wurde von einem Huhn entführt!\n Direkt macht sich das Pferd auf den Weg um die Prinzessin zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam es bis zum Turm des bösen Huhns. Doch seine Lakeien, die {0} versperrten dem Pferd den Weg.\n \" Wir, die {0} werden dich nicht zum Huhn hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                            }
                            break;
                        case "Opa":
                            switch (Böse)
                            {
                                case "Böser Magier":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über ein Pferd. Das Pferd war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht es da?! Sein Opa wurde vom bösen Magier entführt!\n Direkt macht sich das Pferd auf den Weg um den Opa zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam es bis zum Turm des bösen Magiers. Doch seine Lakeien, die {0} versperrten dem Pferd den Weg.\n \" Wir, die {0} werden dich nicht zum Magier hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "König":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über ein Pferd. Das Pferd war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht es da?! Sein Opa wurde vom König entführt!\n Direkt macht sich das Pferd auf den Weg um den Opa zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam es bis zum Turm des bösen Königs. Doch seine Lakeien, die {0} versperrten dem Pferd den Weg.\n \" Wir, die {0} werden dich nicht zum König hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "Mathe":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über ein Pferd. Das Pferd war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht es da?! Sein Opa wurde von Mathe entführt!\n Direkt macht sich das Pferd auf den Weg um den Opa zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam es bis zum Turm von Mathe. Doch seine Lakeien, die {0} versperrten dem Pferd den Weg.\n \" Wir, die {0} werden dich nicht zu Mathe hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "Huhn":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über ein Pferd. Das Pferd war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht es da?! Sein Opa wurde von einem Huhn entführt!\n Direkt macht sich das Pferd auf den Weg um den Opa zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam es bis zum Turm des bösen Huhns. Doch seine Lakeien, die {0} versperrten dem Pferd den Weg.\n \" Wir, die {0} werden dich nicht zum Huhn hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                            }
                            break;
                        case "Hund":
                            switch (Böse)
                            {
                                case "Böser Magier":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über ein Pferd. Das Pferd war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht es da?! Sein bester Kollege, der Hund wurde vom bösen Magier entführt!\n Direkt macht sich das Pferd auf den Weg um den Hund zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam es bis zum Turm des bösen Magiers. Doch seine Lakeien, die {0} versperrten dem Pferd den Weg.\n \" Wir, die {0} werden dich nicht zum Magier hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "König":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über ein Pferd. Das Pferd war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht es da?! Sein bester Kollege, der Hund wurde vom König entführt!\n Direkt macht sich das Pferd auf den Weg um den Hund zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam es bis zum Turm des bösen Königs. Doch seine Lakeien, die {0} versperrten dem Pferd den Weg.\n \" Wir, die {0} werden dich nicht zum König hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "Mathe":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über ein Pferd. Das Pferd war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht es da?! Sein bester Kollege, der Hund wurde von Mathe entführt!\n Direkt macht sich das Pferd auf den Weg um den Hund zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam es bis zum Turm von Mathe. Doch seine Lakeien, die {0} versperrten dem Pferd den Weg.\n \" Wir, die {0} werden dich nicht zu Mathe hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "Huhn":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über ein Pferd. Das Pferd war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht es da?! Sein bester Kollege, der Hund wurde von einem Huhn entführt!\n Direkt macht sich das Pferd auf den Weg um den Hund zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam es bis zum Turm des bösen Huhns. Doch seine Lakeien, die {0} versperrten dem Pferd den Weg.\n \" Wir, die {0} werden dich nicht zum Huhn hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                            }
                            break;
                        case "Kürbis":
                            switch (Böse)
                            {
                                case "Böser Magier":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über ein Pferd. Das Pferd war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht es da?! Sein Kürbis wurde vom bösen Magier entführt!\n Direkt macht sich das Pferd auf den Weg um den Kürbis zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam es bis zum Turm des bösen Magiers. Doch seine Lakeien, die {0} versperrten dem Pferd den Weg.\n \" Wir, die {0} werden dich nicht zum Magier hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "König":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über ein Pferd. Das Pferd war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht es da?! Sein Kürbis wurde vom König entführt!\n Direkt macht sich das Pferd auf den Weg um den Kürbis zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam es bis zum Turm des bösen König. Doch seine Lakeien, die {0} versperrten dem Pferd den Weg.\n \" Wir, die {0} werden dich nicht zum König hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "Mathe":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über ein Pferd. Das Pferd war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht es da?! Sein Kürbis wurde von Mathe entführt!\n Direkt macht sich das Pferd auf den Weg um den Kürbis zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam es bis zum Turm von Mathe. Doch seine Lakeien, die {0} versperrten dem Pferd den Weg.\n \" Wir, die {0} werden dich nicht zu Mathe hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);
                                    break;
                                case "Huhn":
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.WriteLine("Das ist eine Geschichte über ein Pferd. Das Pferd war gerade von einer langen Reise in sein Dorf zurückgekehrt. \n Doch was sieht es da?! Sein Kürbis wurde von einem Huhn entführt!\n Direkt macht sich das Pferd auf den Weg um den Kürbis zu retten.");
                                    Console.WriteLine("Nach mehreren Tagen kam es bis zum Turm des bösen Huhns. Doch seine Lakeien, die {0} versperrten dem Pferd den Weg.\n \" Wir, die {0} werden dich nicht zum Huhn hindurch lassen.\"", Lakeien);
                                    Console.SetCursorPosition(0, 7);
                                    Console.WriteLine("was wirst du tun?");
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine("K = Kämpfen Z = Zaubern B = Beschwichtigen \n");
                                    Console.WriteLine(grenze);

                                    break;
                            }
                            break;
                    }
                    break;
            }
            Problem1 = Console.ReadLine().ToUpper();



            switch (Problem1)
            {
                case "K":
                    Console.Clear();
                    Console.WriteLine(grenze);
                    switch (Hauptcharakter)
                    {
                        case "Magier":
                            //Deadend
                            Console.WriteLine("Der Magier nimmt seinen Zauberstab und schlägt den ersten der {0} zu Boden. Die restlichen {0} stürtzen sich auf ihn und nehmen den Magier fest.", Lakeien);
                            Console.SetCursorPosition(0, 4);
                            Console.WriteLine(grenze);
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("GAME OVER");
                            break;
                        case "Dieb":                                                                                                                                                                                                    //Dieb kämpfen
                            Console.WriteLine("Der Dieb wirft eine Rauchgranate. Er schleicht sich an jeden einzelnen heran und schaltet sie aus, bevor sie es bemerken können.");
                            Console.SetCursorPosition(0, 4);
                            Console.WriteLine(grenze);
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine(grenze);
                            Console.SetCursorPosition(0, 8);
                            Console.WriteLine(grenze);
                            Console.SetCursorPosition(0, 2);
                            switch(Böse)
                            {
                                case "Böser Magier":
                                    Console.WriteLine("Der Dieb geht zum höchsten Punkt des Turms und findet den bösen Magier.\n");
                                    Console.WriteLine("Was soll er tun?\n");
                                    Console.WriteLine("K= Kämpfen S= Schleichen A= Ansprechen G= Gehen");
                                    Problem2 = Console.ReadLine().ToUpper();
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.SetCursorPosition(0, 9);
                                    Console.WriteLine(grenze);
                                    Console.SetCursorPosition(0, 2);
                                    switch (Problem2)
                                    {
                                        case "K":
                                            int hp_D = 100, hp_M = 100, knie=2, superAttacke = 0, wand = 0, sand =0;
                                            Random rnd = new Random();
                                            int angriff_M;
                                            rnd = new Random();
                                            string angriff_D;
                                            Console.WriteLine("Der Dieb bekämpft den Magier.\n");
                                            Console.ReadLine();
                                            
                                            for(int i=100; i>=0 && hp_D > 0 && hp_M > 0; i++)                         //Pokemon Fight!!!!!!!!!!!!!
                                            {
                                                Console.Clear();
                                                Console.WriteLine("HP Dieb = {0}        HP Magier = {1}", hp_D, hp_M);
                                                Console.WriteLine("Welche Attacke wird der Dieb einsetzen?\nSandwirbel: S      Messersturm: M     Pantomime: P     Bogen: B     Schlag dich selbst: X     ");
                                                angriff_D = Console.ReadLine().ToUpper();
                                                switch (angriff_D)                                    //Dieb greift an
                                                {
                                                    case "S":
                                                        Console.Clear();
                                                        Console.WriteLine("Der Dieb wirft dem Magier Sand ins Gesicht. Genauigkeit des Magiers wird schlechter");
                                                        sand = 1;
                                                        Console.ReadLine();
                                                        break;
                                                    case "M":
                                                        Console.Clear();
                                                        Console.WriteLine("Der Dieb bewirft den Magier mit Küchenmessern. Sehr Effektiv");
                                                        Console.ReadLine();
                                                        hp_M = hp_M - 20;
                                                        break;
                                                    case "P":
                                                        Console.Clear();
                                                        Console.WriteLine("Der Dieb tut so, als wäre eine unsichtbare Wand vor ihm.\n Der Magier ist verwirrt und greift diese Runde nicht an.");
                                                        wand = 1;
                                                        Console.ReadLine();
                                                        break;
                                                    case "B":
                                                        Console.Clear();
                                                        if (knie > 0)
                                                        {
                                                            Console.WriteLine("Der Dieb schiesst dem Magier einen Pfeil ins Knie. ");
                                                            Console.ReadLine();
                                                            hp_M = hp_M - 25;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Du hast dem Magier schon in beide Knie geschossen. Angriff nicht sehr effektiv.");
                                                            Console.ReadLine();
                                                            hp_M = hp_M - 5;
                                                        }
                                                        break;
                                                    case "X":
                                                        Console.Clear();
                                                        Console.WriteLine("Der Dieb schlägt sich selbst.\n\nGenial.");
                                                        Console.ReadLine();
                                                        hp_D = hp_D - 10;
                                                        break;

                                                    default:
                                                        Console.WriteLine("Du hast dem Dieb keine richtige Aufgabe gegeben. Er greift diese Runde nicht an.");
                                                        break;
                                                }

                                                if(wand == 1)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Der Magier greift nicht an");        //Dank der Pantomieme greift der Magier nicht an
                                                    wand = 0;
                                                    superAttacke = 0;
                                                    goto Ende_pokemon;
                                                }

                                                if (sand == 1)
                                                {
                                                    angriff_M = rnd.Next(1, 8);         //Sand macht es möglich, dass der Magier nicht trifft.
                                                }
                                                else
                                                {
                                                    angriff_M = rnd.Next(1, 7);
                                                }

                                                if (superAttacke == 1)
                                                {
                                                    Console.WriteLine("Der Magier hat sein Zauber aufgeladen und schickt einen Laser auf den Dieb zu.");
                                                    hp_D = hp_D - 70;                                                                                           //Der aufgeladene Angriff wurde nicht geblockt
                                                    superAttacke = 0;
                                                    goto Ende_pokemon;
                                                }

                                                switch (angriff_M)                                                  //Magier greift an
                                                {
                                                    case 1:
                                                        Console.Clear();
                                                        Console.WriteLine("Der Magier lädt seine Attacke auf.");
                                                        superAttacke = 1;
                                                        break;
                                                    case 2:
                                                        Console.Clear();
                                                        Console.WriteLine("Der Magier lässt es Steine regnen.");
                                                        hp_D = hp_D - 40;
                                                        break;
                                                    case 3:
                                                        Console.Clear();
                                                        Console.WriteLine("Der Magier zaubert einen Wirbelsturm herbei.");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Der Dieb fällt um.");
                                                        hp_D = hp_D - 5;
                                                        break;
                                                    case 4:
                                                        Console.Clear();
                                                        Console.WriteLine("Der Magier fliegt dumm rum. Nicht sehr effektiv");
                                                        break;
                                                    case 5:
                                                        Console.Clear();
                                                        Console.WriteLine("Der Magier schiesst einen Feuerball.");
                                                        hp_D = hp_D - 20;
                                                        break;
                                                    case 6:
                                                        Console.Clear();
                                                        Console.WriteLine("Der Magier trinkt einen Heiltrank.");
                                                        hp_M = hp_M + 10;
                                                        break;
                                                    case 7:
                                                        Console.Clear();
                                                        Console.WriteLine("Der Magier versucht den Dieb in die Luft zu sprengen, doch er verfehlt und trifft sich selbst.");
                                                        hp_M = hp_M - 30;
                                                        break;
                                                }
                                                Ende_pokemon:
                                                Console.ReadLine();
                                            }
                                            if(hp_D <= 0)
                                            {
                                                Console.WriteLine("Der Dieb ist gestorben.\n Game Over");
                                            }
                                            if(hp_M <= 0)
                                            {
                                                Console.WriteLine("Der Dieb hat den bösen Magier besiegt!");
                                                Console.ReadLine();
                                                Console.Clear();
                                                Console.Write("Er geht mit ");
                                                switch (Person)
                                                {
                                                    case "Prinzessin":
                                                        Console.Write("der Prinzessin");
                                                        break;
                                                    case "Opa":
                                                        Console.Write("seinem Opa");
                                                        break;
                                                    case "Hund":
                                                        Console.Write("seinem Hund");
                                                        break;
                                                    case "Kürbis":
                                                        Console.Write("seinem Kürbis");
                                                        break;
                                                }
                                                Console.Write(" ins Dorf zurück.");
                                                Console.ReadLine();
                                                Console.Clear();
                                                Console.WriteLine("THE END!!!");
                                            }
                                            break;

                                        case "S":
                                            //Deadend
                                            Console.WriteLine("Der Dieb gibt sein bestes beim Schleichen, doch er tappt in eine Falle des Magiers und wird von magischem Feuer verbrennt.");
                                            Console.Clear();
                                            Console.WriteLine("GAME OVER");
                                            break;

                                        case "A":
                                            Console.WriteLine("Der Dieb sagt zum bösen Zauberer:\"Hey du! Lass das!\"\n\"Ok, wenn du unbedingt willst.\", sagt der Magier und verschwindet.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.Write("Der Dieb geht mit ");
                                            switch (Person)
                                            {
                                                case "Prinzessin":
                                                    Console.Write("der Prinzessin");
                                                    break;
                                                case "Opa":
                                                    Console.Write("seinem Opa");
                                                    break;
                                                case "Hund":
                                                    Console.Write("seinem Hund");
                                                    break;
                                                case "Kürbis":
                                                    Console.Write("seinem Kürbis");
                                                    break;
                                            }
                                            Console.Write(" ins Dorf zurück.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("THE END!!!");
                                            break;

                                        case "G":
                                            //Deadend
                                            Console.WriteLine("Der Dieb dreht sich um und geht wieder ins Dorf zurück.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("GAME OVER");
                                            break;

                                        default:
                                            Console.WriteLine("DU WAS FALSCH GEMACHT HABEN!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                                            break;
                                    }
                                    break;

                                case "König":
                                    Console.WriteLine("Der Dieb findet den König im Turm auf.");
                                    Console.WriteLine("Wie wird er vorgehen?\n");
                                    Console.WriteLine("K= Kämpfen S= Schleichen A= Ansprechen G= Gehen");
                                    Problem2 = Console.ReadLine().ToUpper();
                                    Console.Clear();
                                    switch(Problem2)
                                    {
                                        case "K":
                                            int hp_D = 100, hp_K = 100, knie = 2, superAttacke = 0, geld = 0, sand = 0;
                                            Random rnd = new Random();
                                            int angriff_K;
                                            rnd = new Random();
                                            string angriff_D;
                                            Console.WriteLine("Der Dieb bekämpft den König.\n");
                                            Console.ReadLine();

                                            for (int i = 100; i >= 0 && hp_D > 0 && hp_K > 0; i++)                         //Pokemon Fight!!!!!!!!!!!!!
                                            {
                                                Console.Clear();
                                                Console.WriteLine("HP Dieb = {0}        HP Magier = {1}", hp_D, hp_K);
                                                Console.WriteLine("Welche Attacke wird der Dieb einsetzen?\nSandwirbel: S      Messersturm: M     Geldwurf: G      Bogen: B     Schlag dich selbst: X     ");
                                                angriff_D = Console.ReadLine().ToUpper();
                                                switch (angriff_D)                                    //Dieb greift an
                                                {
                                                    case "S":
                                                        Console.Clear();
                                                        Console.WriteLine("Der Dieb wirft dem König Sand ins Gesicht. Genauigkeit des Königs wird schlechter");
                                                        sand = 1;
                                                        Console.ReadLine();
                                                        break;
                                                    case "M":
                                                        Console.Clear();
                                                        Console.WriteLine("Der Dieb bewirft den König mit Küchenmessern. Sehr Effektiv");
                                                        Console.ReadLine();
                                                        hp_K = hp_K - 20;
                                                        break;
                                                    case "P":
                                                        Console.Clear();
                                                        Console.WriteLine("Der Dieb wirft Münzen auf den Boden.\nDer König sammelt sie auf. ");
                                                        geld = 1;
                                                        Console.ReadLine();
                                                        break;
                                                    case "B":
                                                        Console.Clear();
                                                        if (knie > 0)
                                                        {
                                                            Console.WriteLine("Der Dieb schiesst dem König einen Pfeil ins Knie. ");
                                                            Console.ReadLine();
                                                            hp_K = hp_K - 25;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Du hast dem König schon in beide Knie geschossen. Angriff nicht sehr effektiv.");
                                                            Console.ReadLine();
                                                            hp_K = hp_K - 5;
                                                        }
                                                        break;
                                                    case "X":
                                                        Console.Clear();
                                                        Console.WriteLine("Der Dieb schlägt sich selbst.\n\nGenial.");
                                                        Console.ReadLine();
                                                        hp_D = hp_D - 10;
                                                        break;
                                                    default:
                                                        Console.Clear();
                                                        Console.WriteLine("Du hast dem Dieb kein richtiges Kommando gegeben.\nEr greifft nicht an.");
                                                        Console.ReadLine();
                                                        break;
                                                }

                                                if (geld == 1)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Der König greift nicht an, da er \ndamit beschäftigt ist, die Münzen aufzusammeln.");        //Dank dem Geldwurf greift der König nicht an
                                                    geld = 0;
                                                    goto Ende_pokemon;
                                                }

                                                if (sand == 1)
                                                {
                                                    angriff_K = rnd.Next(1, 8);         //Sand macht es möglich, dass der König nicht trifft.
                                                }
                                                else
                                                {
                                                    angriff_K = rnd.Next(1, 7);
                                                }

                                                if (superAttacke == 1)
                                                {
                                                    Console.WriteLine("Der König hat seine Armbrust fertig geladen und schiesst einen brennenden Pfeil auf den Dieb.");
                                                    hp_D = hp_D - 70;                                                                                           //Der aufgeladene Angriff wurde nicht geblockt
                                                    superAttacke = 0;
                                                    goto Ende_pokemon;
                                                }

                                                switch (angriff_K)                                                  //König greift an
                                                {
                                                    case 1:
                                                        Console.Clear();
                                                        Console.WriteLine("Der König lädt seine Armbrust.");
                                                        superAttacke = 1;
                                                        break;
                                                    case 2:
                                                        Console.Clear();
                                                        Console.WriteLine("Der König holt drei {0} und greift den Dieb mit ihnen an.", Lakeien);
                                                        hp_D = hp_D - 40;
                                                        break;
                                                    case 3:
                                                        Console.Clear();
                                                        Console.WriteLine("Der König wirft dem Dieb eine Münze an den Kopf.\n\n+1 Münze");
                                                        hp_D = hp_D - 5;
                                                        break;
                                                    case 4:
                                                        Console.Clear();
                                                        Console.WriteLine("Der König putzt seine Krone.\nNicht sehr effektiv");
                                                        break;
                                                    case 5:
                                                        Console.Clear();
                                                        Console.WriteLine("Der König bewirft den Dieb mit einer Schatztruhe");
                                                        hp_D = hp_D - 20;
                                                        break;
                                                    case 6:
                                                        Console.Clear();
                                                        Console.WriteLine("Der König isst einen Apfel.");
                                                        hp_K = hp_K + 10;
                                                        break;
                                                    case 7:
                                                        Console.Clear();
                                                        Console.WriteLine("Der König versucht den Dieb zu schlagen, doch er verfehlt und trifft sich selbst.");
                                                        hp_K = hp_K - 30;
                                                        break;
                                                }
                                                Ende_pokemon:
                                                Console.ReadLine();
                                            }
                                            if (hp_D <= 0)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Der Dieb ist gestorben.\n Game Over");
                                            }
                                            if (hp_K <= 0)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Der Dieb hat den König besiegt!");
                                                Console.ReadLine();
                                                Console.Clear();
                                                Console.Write("Er geht mit ");
                                                switch (Person)
                                                {
                                                    case "Prinzessin":
                                                        Console.Write("der Prinzessin");
                                                        break;
                                                    case "Opa":
                                                        Console.Write("seinem Opa");
                                                        break;
                                                    case "Hund":
                                                        Console.Write("seinem Hund");
                                                        break;
                                                    case "Kürbis":
                                                        Console.Write("seinem Kürbis");
                                                        break;
                                                }
                                                Console.Write(" ins Dorf zurück.");
                                                Console.ReadLine();
                                                Console.Clear();
                                                Console.WriteLine("THE END!!!");
                                            }
                                            break;
                                        case "S":
                                            //Deadend
                                            Console.WriteLine("Der Dieb schleicht sich an den König, wärend dieser am essen ist.\n Gerade als den finalen Schlag machen wollte, rutschte der Dieb auf einer Bananenschale aus.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("GAME OVER");

                                            break;
                                        case "A":
                                            Console.Clear();
                                            Console.Write("Der Dieb spricht den König an, er solle doch sein Vorhaben überdenken. Der König nimmt die Aufforderung zu herzen und lässt ihn und ");
                                            switch(Person)
                                            {
                                                case "Prinzessin":
                                                    Console.Write("die Prinzessin gehen.");
                                                    break;
                                                case "Opa":
                                                    Console.Write("seinen Opa gehen.");
                                                    break;
                                                case "Hund":
                                                    Console.Write("seinen Hund gehen.");
                                                        break;
                                                case "Kürbis":
                                                    Console.Write("seinen Kürbis gehen");
                                                    break;
                                            }
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("THE END!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                                            break;
                                        case "G":
                                            //Deadend
                                            Console.WriteLine("Der Dieb dreht sich um und geht wieder ins Dorf zurück.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("GAME OVER");
                                            break;

                                        default:
                                            Console.WriteLine("falsche Angabe!");
                                            break;
                                    }
                                    break;

                                case "Mathe":
                                    Console.WriteLine("Der Dieb findet Mathe.");
                                    Console.WriteLine("Was wirst du tun?\n");
                                    Console.WriteLine("K= Kämpfen S= Schleichen A= Ansprechen G= Gehen");
                                    Problem2 = Console.ReadLine().ToUpper();
                                    Console.Clear();
                                    switch(Problem2)
                                    {
                                        case "K":                                                           //Matheaufgaben
                                            Random rnd = new Random();
                                            int zahl_1, zahl_2;
                                            int lösung;
                                            rnd = new Random();
                                            Console.WriteLine("Der Dieb bekämpft Mathe");
                                            Console.ReadKey();
                                            Console.Clear();
                                            int hp_D = 100, hp_M = 100, aufgabe;
                                            for(int i=100; i >0 && hp_D >0 && hp_M >0; i++)
                                            {
                                                Console.WriteLine(" HP Dieb = {0}       HP Mathe = {1}", hp_D, hp_M);
                                                zahl_1 = rnd.Next(1, 1000);
                                                zahl_2 = rnd.Next(1, 1000);
                                                aufgabe = zahl_1 - zahl_2;
                                                Console.WriteLine("\n\nMathe stellt dem Dieb eine Rechenaufgabe.\n\nAufgabe: {0} - {1} = ", zahl_1, zahl_2);
                                                lösung = Convert.ToInt32(Console.ReadLine());
                                                if(lösung == aufgabe)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Richtig!");
                                                    hp_M = hp_M - 20;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Falsch! Die Lösung wäre {0}", aufgabe);
                                                    hp_D = hp_D - 50;

                                                }
                                                Console.ReadKey();
                                                Console.Clear();

                                            }

                                            if (hp_D <= 0)
                                            {
                                                Console.WriteLine("Der Dieb konnte die Matheaufgaben nicht verstehen und ist an Überanstrengung gestorben.\n Game Over");
                                            }
                                            if (hp_M <= 0)
                                            {
                                                Console.WriteLine("Der Dieb hat Mathe in seinem eigenen Spiel geschlagen! Mathe hat sich vor Entsetzen in Luft aufgelöst.");
                                                Console.ReadLine();
                                                Console.Clear();
                                                Console.Write("Der Dieb geht mit ");
                                                switch (Person)
                                                {
                                                    case "Prinzessin":
                                                        Console.Write("der Prinzessin");
                                                        break;
                                                    case "Opa":
                                                        Console.Write("seinem Opa");
                                                        break;
                                                    case "Hund":
                                                        Console.Write("seinem Hund");
                                                        break;
                                                    case "Kürbis":
                                                        Console.Write("seinem Kürbis");
                                                        break;
                                                }
                                                Console.Write(" ins Dorf zurück.");
                                                Console.ReadLine();
                                                Console.Clear();
                                                Console.WriteLine("THE END!!!");
                                            }
                                            break;

                                        case "S":
                                            //Deadend
                                            Console.WriteLine("Der Dieb schleicht sich an Mathe heran und will es erstechen,\n doch da merkt er, dass Mathe gar keine Person, sondern nur eine Idee der Menschen ist.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("Der Dieb versteht gar nichts mehr und rennt davon.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("GAME OVER");
                                            break;

                                        case "A":
                                            //Deadend
                                            Console.WriteLine("Der Dieb versucht mit Mathe zu verhandeln, doch da Mathe die menschliche Sprache nicht versteht, beschiesst es ihn mit einer Tödlichen X-Gleichung.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("GAME OVER");

                                            break;

                                        case "G":
                                            //Deadend
                                            Console.WriteLine("Der Dieb dreht um und geht ins Dorf zurück.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("GAME OVER");
                                            break;

                                        default:
                                            Console.WriteLine("Keine richtige Angabe gemacht.");
                                            break;
                                    }
                                    break;

                                case "Huhn":
                                    int streicheln = 0;
                                    Console.WriteLine("Der Dieb hat das huhnige Huhn aufgespührt.");
                                    Huhn:
                                    Console.WriteLine("Was wird er tun?\n");
                                    Console.WriteLine("K= Kämpfen S= Streicheln A= Ansprechen G= Gehen");
                                    Problem2 = Console.ReadLine().ToUpper();
                                    Console.Clear();
                                    switch(Problem2)
                                    {
                                        case "K":
                                            //Deadend
                                            Console.WriteLine("Der Dieb will das Huhn bekämpfen, doch als er sieht, wie süss das Huhn doch ist, stirbt er an einem Süssigkeitsüberschuss.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("GAME OVER");
                                            break;

                                        case "S":
                                            if (streicheln == 0)
                                            {
                                                Console.WriteLine("Der Dieb streichelt das Huhn.");
                                                streicheln = 1;
                                            }
                                            if (streicheln == 1)
                                            {
                                                Console.WriteLine("Der Dieb streichelt das Huhn wieder.");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Oops, something went wrong :(");
                                            }
                                            goto Huhn;

                                        case "A":
                                            Console.Write("Der Dieb versucht mit dem Huhn zu reden.\nDas Huhn kann ihn zwar nicht verstehen, aber es merk, dass der Dieb ");
                                            switch (Person)
                                            {
                                                case "Prinzessin":
                                                    Console.Write("die Prinzessin");
                                                    break;
                                                case "Opa":
                                                    Console.Write("seinen Opa");
                                                    break;
                                                case "Hund":
                                                    Console.Write("seinen Hund");
                                                    break;
                                                case "Kürbis":
                                                    Console.Write("seinen Kürbis");
                                                    break;
                                            }
                                            Console.Write(" retten möchte.\n Es lässt die beiden gehen.");
                                            Console.ReadKey();
                                            Console.WriteLine("Winner Winner Chicken Dinner");
                                            break;

                                        case "G":
                                            if(streicheln == 1)
                                            {
                                                Console.WriteLine("Der Dieb ist überglücklich, weil er das Huhn streicheln konnte, und geht ins Dorf zurück.");
                                                Console.ReadKey();
                                                Console.Clear();
                                                Console.WriteLine("kuscheliges GAME OVER");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Der Dieb geht ins Dorf zurück.");
                                                Console.ReadKey();
                                                Console.Clear();
                                                Console.WriteLine("GAME OVER");
                                            }

                                            break;
                                    }
                                    break;
                            }

                            break;
                        case "Krieger":                                                                                                                                                                                         //Krieger kämfpen
                            Console.WriteLine("Der Krieger stösst einen mächtigen Schrei aus und stürmt auf die {0} los. Er wirft den Ersten in die Luft und schleudert ihn weiter als man sehen konnte. Verängstigt von diesem Anblick rannten die restlichen {0} davon", Lakeien);
                            Console.SetCursorPosition(0, 4);
                            Console.WriteLine(grenze);
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine(grenze);
                            Console.SetCursorPosition(0, 8);
                            Console.WriteLine(grenze);
                            Console.SetCursorPosition(0, 3);
                            switch (Böse)
                            {
                                case "Böser Magier":
                                    Console.WriteLine("Der Krieger findet den böser Magier im Turm. Was wird er tun?");
                                    Console.WriteLine("K= Kämpfen L= Lesen S= Stürmen A= Ansprechen");
                                    Problem2 = Console.ReadLine().ToUpper();
                                    Console.Clear();
                                    switch (Problem2)
                                    {
                                        case "K":
                                            int hp_K = 100, hp_M = 100, chanceAxt, blocken = 0, einschüchtern = 0, angriff_M, superAttacke = 0;
                                            string angriff_K;
                                            Random rnd = new Random();
                                            Console.WriteLine("Der Krieger bekämpft den Magier.");
                                            Console.ReadKey();
                                            for (int i = 100; i > 0 && hp_K > 0 && hp_M > 0; i--)                                       //Pokemon fight
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Wie soll der Krieger angreifen\nAxtwurf = A     Sturmangriff = S     Kaffepause = K     Blocken = B     Einschüchtern = E");
                                                angriff_K = Console.ReadLine();
                                                Console.Clear();
                                                switch(angriff_K)                                                   //Angriff Krieger
                                                {
                                                    case "A":
                                                        Console.WriteLine("Der Krieger wirft eine Axt.");
                                                        Console.ReadKey();
                                                        chanceAxt = rnd.Next(1, 4);
                                                        Console.Clear();
                                                        if(chanceAxt == 1)
                                                        {
                                                            Console.WriteLine("Die Axt hat den Magier getroffen.");
                                                            hp_M = hp_M - 40;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Die Axt hat ihr Ziel verfehlt");
                                                        }
                                                        break;

                                                    case "S":
                                                        Console.WriteLine("Der Krieger stürmt auf den Magier zu und rammt ihn um.");
                                                        hp_M = hp_M - 20;

                                                        break;

                                                    case "K":
                                                        Console.WriteLine("Der Krieger macht eine Kaffepause.");
                                                        hp_K = hp_K + 20;

                                                        break;

                                                    case "B":
                                                        Console.WriteLine("Der Krieger nimmt den Schild zu Hand und ist bereit, den nächsten Angriff zu blocken.");
                                                        blocken = 1;

                                                        break;

                                                    case "E":
                                                        if (einschüchtern == 2)
                                                        {
                                                            Console.WriteLine("Dem Krieger fällt nichts neues ein.");
                                                        }
                                                        if (einschüchtern == 1)
                                                        {
                                                            Console.WriteLine("Der Krieger sagt nochmals das gleiche.\nNun wird der Magier wütend.\nAngriff des Magiers steigt.");
                                                            einschüchtern = 2;
                                                        }
                                                        if (einschüchtern == 0)
                                                        {
                                                            Console.WriteLine("Der Krieger sagt, das der Magier nie genug gut sein werde, um an die Magieruni zu kommen.\nDer Magier wird Traurig.\nAngriff des Magiers sinkt.");
                                                            einschüchtern = 1;
                                                        }
                                                        break;

                                                    default:
                                                        Console.WriteLine("Du hast dem Krieger keine Anweisungen gegeben. Er greift diese Runde nicht an.");
                                                        break;

                                                }
                                                Console.ReadKey();
                                                Console.Clear();
                                                if(blocken == 1)                                                //Angriff wird geblockt
                                                {
                                                    Console.WriteLine("Der Krieger blockt den Angriff.");
                                                    blocken = 0;
                                                    superAttacke = 1;
                                                    goto EndePokemon;
                                                }
                                                
                                                if(superAttacke == 1)                                          //Magier hat Superattacke fertig aufgeladen
                                                {
                                                    Console.WriteLine("Der Magier hat seinen Angriff fertig aufgeladen und schiesst einen Laser auf den Krieger.");
                                                    if (einschüchtern == 0)
                                                    {
                                                        hp_K = hp_K - 50;
                                                    }
                                                    if (einschüchtern == 1)
                                                    {
                                                        hp_K = hp_K - 25;
                                                    }
                                                    if (einschüchtern == 2)
                                                    {
                                                        hp_K = hp_K - 60;
                                                    }
                                                    goto EndePokemon;
                                                }
                                                angriff_M = rnd.Next(1, 6);
                                                switch(angriff_M)
                                                {
                                                    case 1:
                                                        Console.WriteLine("Der Magier lädt seinen Angriff auf.");
                                                        superAttacke = 1;
                                                        break;

                                                    case 2:
                                                        Console.Clear();
                                                        Console.WriteLine("Der Magier lässt es Steine regnen.");
                                                        hp_K = hp_K - 40;
                                                        break;
                                                    case 3:
                                                        Console.Clear();
                                                        Console.WriteLine("Der Magier zaubert einen Wirbelsturm herbei.");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Der Krieger fällt um.");
                                                        hp_K = hp_K - 5;
                                                        break;
                                                    case 4:
                                                        Console.Clear();
                                                        Console.WriteLine("Der Magier fliegt dumm rum. Nicht sehr effektiv");
                                                        break;
                                                    case 5:
                                                        Console.Clear();
                                                        Console.WriteLine("Der Magier schiesst einen Feuerball.");
                                                        hp_K = hp_K - 20;
                                                        break;
                                                    case 6:
                                                        Console.Clear();
                                                        Console.WriteLine("Der Magier trinkt einen Heiltrank.");
                                                        hp_M = hp_M + 10;
                                                        break;

                                                }
                                                EndePokemon:
                                                Console.ReadKey();

                                            }
                                            if(hp_K < 0)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Der Krieger ist gestorben.");
                                                Console.ReadKey();
                                                Console.Clear();
                                                Console.WriteLine("GAME OVER");
                                            }
                                            if(hp_M > 0)
                                            {
                                                Console.Clear();
                                                Console.Write("Der Krieger hat den Magier besiegt. Er geht mit");
                                                switch (Person)
                                                {
                                                    case "Prinzessin":
                                                        Console.Write("der Prinzessin");
                                                        break;
                                                    case "Opa":
                                                        Console.Write("seinem Opa");
                                                        break;
                                                    case "Hund":
                                                        Console.Write("seinem Hund");
                                                        break;
                                                    case "Kürbis":
                                                        Console.Write("seinem Kürbis");
                                                        break;
                                                }
                                                Console.Write(" ins Dorf zurück.");
                                                Console.ReadLine();
                                                Console.Clear();
                                                Console.WriteLine("THE END!!!");
                                            }
                                            
                                            break;

                                        case "L":
                                            Console.WriteLine("Der Krieger hat ein Buch mit Zaubersprüchen gefunden.\nEr probiert einen Zauberspruch aus.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Random rand = new Random();
                                            int chance = rand.Next(1,5);
                                            if(chance == 1 || chance == 2)
                                            {
                                                Console.WriteLine("Der Krieger explodiert.");
                                                Console.ReadKey();
                                                Console.Clear();
                                                Console.WriteLine("GAME OVER");
                                            }
                                            if(chance == 3)
                                            {
                                                Console.WriteLine("Der Krieger und der Magier werden von einem Schwarzen Loch eingesaugt.");
                                                Console.ReadKey();
                                                Console.Clear();
                                                Console.WriteLine("GAME OVER?");
                                            }
                                            if(chance == 4)
                                            {
                                                Console.Write("Der Krieger verwandelt den Magier in eine Sonnenblume.\nEr geht mit");
                                                switch (Person)
                                                {
                                                    case "Prinzessin":
                                                        Console.Write("der Prinzessin");
                                                        break;
                                                    case "Opa":
                                                        Console.Write("seinem Opa");
                                                        break;
                                                    case "Hund":
                                                        Console.Write("seinem Hund");
                                                        break;
                                                    case "Kürbis":
                                                        Console.Write("seinem Kürbis");
                                                        break;
                                                }
                                                Console.Write(" ins Dorf zurück.");
                                                Console.ReadLine();
                                                Console.Clear();
                                                Console.WriteLine("THE END!!!");
                                            }
                                            else
                                            {
                                                Console.WriteLine("How did you even get here???");
                                            }

                                            break;

                                        case "S":
                                            Random rando = new Random();
                                            chance = rando.Next(1,3);
                                            if (chance == 1)
                                            {
                                                Console.WriteLine("Der Krieger stosst den Magier vom Turm.");
                                                Console.ReadKey();
                                                Console.Clear();
                                                Console.Write("Der Krieger geht mit");
                                                switch (Person)
                                                {
                                                    case "Prinzessin":
                                                        Console.Write("der Prinzessin");
                                                        break;
                                                    case "Opa":
                                                        Console.Write("seinem Opa");
                                                        break;
                                                    case "Hund":
                                                        Console.Write("seinem Hund");
                                                        break;
                                                    case "Kürbis":
                                                        Console.Write("seinem Kürbis");
                                                        break;
                                                }
                                                Console.Write(" ins Dorf zurück.");
                                                Console.ReadLine();
                                                Console.Clear();
                                                Console.WriteLine("THE END!!!");
                                            }
                                            break;

                                        case "A":
                                            //Deadend
                                            Console.WriteLine("Der Krieger spricht den bösen Magier an. Er kämpft mit Worten.\nDoch leider hat der Magier keine Moral und wirft dem Krieger ein Buch an den Kopf.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("GAME OVER");

                                            break;
                                    }
                                    break;

                                case "König":
                                    AnfangKönig:
                                    Console.WriteLine("Der Krieger findet den König im Turm. Was wird er tun?");
                                    Console.WriteLine("K= Kämpfen L= Lesen S= Stürmen A= Ansprechen");
                                    Problem2 = Console.ReadLine().ToUpper();
                                    Console.Clear();
                                    switch (Problem2)
                                    {
                                        case "K":
                                            //Deadend
                                            Console.WriteLine("Der Krieger will den König bekämpfen, doch ihm wird Geld versprochen, wenn er den König nicht bekämpft.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("Der Krieger geht nach hause.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("GAME OVER\nDu hast dich bestechen lassen!");
                                            break;

                                        case "L":
                                            //Deadend
                                            Console.WriteLine("Der Krieger liesst ein Buch.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("GAME OVER\n(lesen tötet)");
                                            break;

                                        case "S":
                                            Console.WriteLine("Der Krieger stürmt auf den König zu und wirft ihn aus einem Turmfenster.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("The End!!!");
                                            break;

                                        case "A":
                                            Console.WriteLine("Der Krieger will den König ansprechen.\nWas soll er sagen?\nVerhandeln = V     Drohen = D     Beleidigen = B     Weinen = W     Kekse = K");
                                            Problem2 = Console.ReadLine();
                                            switch(Problem2)
                                            {
                                                case "V":
                                                    Console.WriteLine("Der Krieger bietet dem König fünf Wildschweine.\n Der König nimmt das angebot an.\"Genau die habe ich gebraucht für mein Wildschweinragu!\"");
                                                    Console.Write("Der Krieger geht mit");
                                                    switch (Person)
                                                    {
                                                        case "Prinzessin":
                                                            Console.Write("der Prinzessin");
                                                            break;
                                                        case "Opa":
                                                            Console.Write("seinem Opa");
                                                            break;
                                                        case "Hund":
                                                            Console.Write("seinem Hund");
                                                            break;
                                                        case "Kürbis":
                                                            Console.Write("seinem Kürbis");
                                                            break;
                                                    }
                                                    Console.Write(" ins Dorf zurück.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("THE END!!!");
                                                    break;

                                                case "D":
                                                    Console.Write("Der Krieger droht dem König:\"Wenn du ");
                                                    switch (Person)
                                                    {
                                                        case "Prinzessin":
                                                            Console.Write("die Prinzessin");
                                                            break;
                                                        case "Opa":
                                                            Console.Write("meinen Opa");
                                                            break;
                                                        case "Hund":
                                                            Console.Write("meinen Hund");
                                                            break;
                                                        case "Kürbis":
                                                            Console.Write("meinen Kürbis");
                                                            break;
                                                    }
                                                    Console.Write(" nicht freilässt, dann werde ich so richtig ungemütlich.\"");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    Console.WriteLine("Der König war nicht sehr eingeschüchtert.\nWie der Krieger gesagt hat, wurde er ungemütlich.\nBesser gesagt ihm wurde ungemütlich.");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    Console.WriteLine("Dem Krieger wurde es so ungemütlich, dass er wieder zurück in das Dorf ging.");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    Console.WriteLine("GAME OVER");
                                                    break;

                                                case "B":
                                                    //Deadend
                                                    Console.WriteLine("Der Krieger beleidigt den König.");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    Console.WriteLine("Es hat nichts genützt.");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    Console.WriteLine("GAME OVER");
                                                    break;

                                                case "W":
                                                    Console.WriteLine("Der Krieger fängt an zu weinen.");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    Console.Write("Aus Mitleid lässt der König");
                                                    switch (Person)
                                                    {
                                                        case "Prinzessin":
                                                            Console.Write("die Prinzessin");
                                                            break;
                                                        case "Opa":
                                                            Console.Write("seinen Opa");
                                                            break;
                                                        case "Hund":
                                                            Console.Write("seinen Hund");
                                                            break;
                                                        case "Kürbis":
                                                            Console.Write("seinen Kürbis");
                                                            break;
                                                    }
                                                    Console.Write(" frei.");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    Console.WriteLine("The End");
                                                    break;

                                                case "K":
                                                    int Keks = 0;
                                                    if (Keks == 5)
                                                    {
                                                        Console.WriteLine("Der Krieger gibt dem König einen Keks.\nDer König isst den Keks.\nDer König ist nun so voll, dass er explodiert.");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        Console.Write("Der Krieger geht mit");
                                                        switch (Person)
                                                        {
                                                            case "Prinzessin":
                                                                Console.Write("der Prinzessin");
                                                                break;
                                                            case "Opa":
                                                                Console.Write("seinem Opa");
                                                                break;
                                                            case "Hund":
                                                                Console.Write("seinem Hund");
                                                                break;
                                                            case "Kürbis":
                                                                Console.Write("seinem Kürbis");
                                                                break;
                                                        }
                                                        Console.Write(" ins Dorf zurück.");
                                                        Console.ReadLine();
                                                        Console.Clear();
                                                        Console.WriteLine("THE END!!!");

                                                    }
                                                    if (Keks < 5)
                                                    {
                                                        Console.WriteLine("Der Krieger gibt dem König einen Keks.\nDer König nimmt den Keks dankend an und isst ihn.");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        Keks++;
                                                        goto AnfangKönig;
                                                    }

                                                    break;
                                            }

                                            break;

                                        default:
                                            Console.WriteLine("Keine richtige Angabe");
                                            break;
                                    }
                                    break;

                                case "Mathe":
                                    Console.WriteLine("Der Krieger hat Mathe gefunden. Mathe fordert ihn zu einem Kopfrechnungs-Wettkampf heraus.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    //Anfang Matheaufgaben 
                                    {
                                        Random Rnd = new Random();
                                        int zahl_1, zahl_2;
                                        int lösung;
                                        Rnd = new Random();
                                        Console.WriteLine("Der Krieger bekämpft Mathe");
                                        Console.ReadKey();
                                        Console.Clear();
                                        int Hp_K = 100, Hp_M = 100, aufgabe;
                                        for (int i = 100; i > 0 && Hp_K > 0 && Hp_M > 0; i++)
                                        {
                                            Console.WriteLine(" HP Krieger = {0}       HP Mathe = {1}", Hp_K, Hp_M);
                                            zahl_1 = Rnd.Next(1, 1000);
                                            zahl_2 = Rnd.Next(1, 1000);
                                            aufgabe = zahl_1 * zahl_2;
                                            Console.Write("\n\nMathe stellt dem Krieger eine Rechenaufgabe.\n\nAufgabe: {0} - {1} = ", zahl_1, zahl_2);
                                            lösung = Convert.ToInt32(Console.ReadLine());
                                            if (lösung == aufgabe)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Richtig!");
                                                Hp_M = Hp_M - 20;
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Falsch! Die Lösung wäre {0}", aufgabe);
                                                Hp_K = Hp_K - 50;

                                            }
                                            Console.ReadKey();
                                            Console.Clear();

                                        }

                                        if (Hp_K <= 0)
                                        {
                                            Console.WriteLine("Der Krieger konnte die Matheaufgaben nicht verstehen und ist an Überanstrengung gestorben.\n Game Over");
                                        }
                                        if (Hp_M <= 0)
                                        {
                                            Console.WriteLine("Der Krieger hat Mathe in seinem eigenen Spiel geschlagen! Mathe hat sich vor Entsetzen in Luft aufgelöst.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.Write("Der Krieger geht mit ");
                                            switch (Person)
                                            {
                                                case "Prinzessin":
                                                    Console.Write("der Prinzessin");
                                                    break;
                                                case "Opa":
                                                    Console.Write("seinem Opa");
                                                    break;
                                                case "Hund":
                                                    Console.Write("seinem Hund");
                                                    break;
                                                case "Kürbis":
                                                    Console.Write("seinem Kürbis");
                                                    break;
                                            }
                                            Console.Write(" ins Dorf zurück.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("THE END!!!");
                                        }
                                    }
                                    break;

                                case "Huhn":
                                    int streicheln = 0;
                                    Console.WriteLine("Der Krieger hat das huhnige Huhn aufgespührt.");
                                    Huhn:
                                    Console.WriteLine("Was wird er tun?\n");
                                    Console.WriteLine("K= Kämpfen S= Streicheln A= Ansprechen G= Gehen");
                                    Problem2 = Console.ReadLine().ToUpper();
                                    Console.Clear();
                                    switch (Problem2)
                                    {
                                        case "K":
                                            //Deadend
                                            Console.WriteLine("Der Krieger will das Huhn bekämpfen, doch als er sieht, wie süss das Huhn doch ist, stirbt er an einem Süssigkeitsüberschuss.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("GAME OVER");
                                            break;

                                        case "S":
                                            if (streicheln == 0)
                                            {
                                                Console.WriteLine("Der Krieger streichelt das Huhn.");
                                                streicheln = 1;
                                            }
                                            if (streicheln == 1)
                                            {
                                                Console.WriteLine("Der Krieger streichelt das Huhn wieder.");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Oops, something went wrong :(");
                                            }
                                            goto Huhn;

                                        case "A":
                                            Console.Write("Der Krieger versucht mit dem Huhn zu reden.\nDas Huhn kann ihn zwar nicht verstehen, aber es merk, dass der Krieger ");
                                            switch (Person)
                                            {
                                                case "Prinzessin":
                                                    Console.Write("die Prinzessin");
                                                    break;
                                                case "Opa":
                                                    Console.Write("seinen Opa");
                                                    break;
                                                case "Hund":
                                                    Console.Write("seinen Hund");
                                                    break;
                                                case "Kürbis":
                                                    Console.Write("seinen Kürbis");
                                                    break;
                                            }
                                            Console.Write(" retten möchte.\n Es lässt die beiden gehen.");
                                            Console.ReadKey();
                                            Console.WriteLine("Winner Winner Chicken Dinner");
                                            break;

                                        case "G":
                                            if (streicheln == 1)
                                            {
                                                Console.WriteLine("Der Krieger ist überglücklich, weil er das Huhn streicheln konnte, und geht ins Dorf zurück.");
                                                Console.ReadKey();
                                                Console.Clear();
                                                Console.WriteLine("kuscheliges GAME OVER");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Der Krieger geht ins Dorf zurück.");
                                                Console.ReadKey();
                                                Console.Clear();
                                                Console.WriteLine("GAME OVER");
                                            }

                                            break;
                                    }
                                    break;
                            }
                            break;
                        case "Pferd":
                            Console.WriteLine("Das Pferd wiehert und haut mit seinen Hufen den ersten der {0} um. Dem Nächsten verpasste es einen Kopfstoss, sodass er taumelte und umfiel. \"Schnell weg!\", rief einer der {0}. \"Wir wussten nicht das dieses Pferd Karate kann!\"", Lakeien);
                            Console.SetCursorPosition(0, 4);
                            Console.WriteLine(grenze);
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine(grenze);
                            Console.SetCursorPosition(0, 8);
                            Console.WriteLine(grenze);
                            Console.SetCursorPosition(0, 2);
                            switch (Böse)
                            {
                                case "Böser Magier":
                                    Console.WriteLine("Das Pferd findet den Magier. Was wird es tun?");
                                    Console.WriteLine("K= Kämpfen H= Herausfordern S= Sprechen X= Xylophon");
                                    Problem2 = Console.ReadLine().ToUpper();
                                    Console.Clear();
                                    switch (Problem2)
                                    {
                                        case "K":
                                            Console.WriteLine("Das Pferd Bekämpft den Magier");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("Der Magier schlägt vor, einen Würfel zu werfen.\nWer die Zahl erratet darf die Geisel mitnehmen.");
                                            Console.ReadLine();
                                            Console.WriteLine("Das Pferd willigt ein.");
                                            Console.ReadLine();


                                            //Anfang Würfelspiel
                                            int resultat = 0;
                                            for (int zähler = 100; zähler > 0 && resultat < 1; zähler++)
                                            {
                                                Console.Clear();
                                                Console.Write("Das Pferd rät: ");
                                                int zahl_Pferd = Convert.ToInt32(Console.ReadLine());   //Eingabe Würfelzahl
                                                Console.Write("Der Magier rät: ");
                                                System.Threading.Thread.Sleep(100);
                                                Random magierRand = new Random();                       //Würfelzahl des Magiers
                                                int zahl_Magier = magierRand.Next(1, 7);
                                                Console.Write(zahl_Magier);
                                                Console.ReadLine();
                                                Random rnd = new Random();                              //Zahl des Würfels
                                                int Würfel = rnd.Next(1, 7);
                                                Console.Write("Der Würfel fällt auf ");
                                                System.Threading.Thread.Sleep(100);
                                                Console.Write(Würfel);
                                                Console.ReadLine();
                                                Console.Clear();
                                                //Abfrage ob jemand die Zahl erraten hat
                                                if (Würfel == zahl_Pferd)
                                                {
                                                    resultat++;
                                                    Console.WriteLine("Das Pferd hat gewonnen!");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.Write("Es geht mit ");
                                                    switch (Person)
                                                    {
                                                        case "Prinzessin":
                                                            Console.Write("der Prinzessin");
                                                            break;
                                                        case "Opa":
                                                            Console.Write("seinem Opa");
                                                            break;
                                                        case "Hund":
                                                            Console.Write("seinem Hund");
                                                            break;
                                                        case "Kürbis":
                                                            Console.Write("seinem Kürbis");
                                                            break;
                                                    }
                                                    Console.Write(" ins Dorf zurück.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("THE END!!!");
                                                }
                                                if (Würfel == zahl_Magier)
                                                {
                                                    resultat++;
                                                    Console.WriteLine("Der Magier hat gewonnen!");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("Das Pferd wird in den Kerker gesperrt und wird nie mehr freigelassen.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("GAME OVER");
                                                }
                                                if (Würfel != zahl_Magier && Würfel != zahl_Pferd)
                                                {
                                                    Console.WriteLine("Keiner hat die Zahl erraten.");
                                                    Console.ReadLine();

                                                }
                                                if (Würfel == zahl_Pferd && Würfel == zahl_Magier)
                                                {
                                                    Console.WriteLine("Beide haben die Zahl erraten.\nEs wird weiter gewürfelt.");
                                                    Console.ReadLine();
                                                }
                                            }

                                            break;

                                        case "H":
                                            Console.WriteLine("Das Pferd fordert den Magier zu einem Podrennen heraus.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Random rand = new Random();                              //Zufälliges Ende
                                            int Podrennen = rand.Next(1, 4);
                                            switch(Podrennen)
                                            {
                                                case 1:
                                                    Console.WriteLine("Direkt am Start fällt der Motor des Pferdes aus. Trotz dem anfänglichen Missgeschick kommt es\nam Ende noch zu einem Kopf an Kopf rennen.\nMit minimalem Vorsprung gewinnt der Magier.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("GAME OVER");
                                                    break;

                                                case 2:
                                                    Console.WriteLine("Das Pferd ist schneller als der Magier. Schon in der Hälfte des Rennes ist klar, wer gewinnen wird.\nDoch das Pferd wird übermütig und will eine Rolle machen.\nDie Rolle funktioniert einwandfrei doch als es wieder auf den Boden kommt\nverliert es die Haftung und fliegt in eine Felswand.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("GAME OVER");
                                                    break;

                                                case 3:
                                                    Console.WriteLine("Das Pferd hat einen Vorsprung. Dem Magier passt das garnicht und er verwandelt ein Treibwerk des Pferdes in eine Kuh.\nDies zählt als eine Regelmissachtung und der Magier wird disqualifiziert.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("GEWONNEN");
                                                    break;
                                            }

                                            break;

                                        case "S":
                                            //Deadend
                                            Console.WriteLine("Das Pferd will mit dem Magier verhandeln,\ndoch leider versteht er kein Pferdisch.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("Der Magier jagt das Pferd aus seinem Turm.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("GAME OVER");
                                            break;

                                        case "X":
                                            Console.WriteLine("Das Pferd hat ein Xylophon gefunden und möchte dem Magier ein kleines Liedchen vorspielen.");
                                            Console.ReadLine();
                                            Console.Write("Töne: A B C D E F G\n\nErster Ton: ");       //Anfang Eingabe Töne
                                            string ton1 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nZweiter Ton: ");
                                            string ton2 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nDritter Ton: ");
                                            string ton3 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nVierter Ton: ");
                                            string ton4 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nFünfter Ton: ");
                                            string ton5 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nSechster Ton: ");
                                            string ton6 = Console.ReadLine().ToUpper();                 //Schluss Eingabe Töne
                                            Console.Clear();
                                            //Ausgabe Töne
                                            {
                                                switch (ton1)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton2)
                                                {
                                                    case "A":
                                                        Console.Beep(1500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton3)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton4)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton5)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton6)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                            }

                                            Console.WriteLine("Der Magier ist so begeistert von den Spielkünsten des Pferdes, dass er explodiert.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.Write("Das Pferd geht mit ");
                                            switch (Person)
                                            {
                                                case "Prinzessin":
                                                    Console.Write("der Prinzessin");
                                                    break;
                                                case "Opa":
                                                    Console.Write("seinem Opa");
                                                    break;
                                                case "Hund":
                                                    Console.Write("seinem Hund");
                                                    break;
                                                case "Kürbis":
                                                    Console.Write("seinem Kürbis");
                                                    break;
                                            }
                                            Console.Write(" ins Dorf zurück.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("THE END!!!");

                                            break;
                                    }
                                    break;

                                case "König":
                                    Console.WriteLine("Das Pferd findet den König. Was wird es tun?");
                                    Console.WriteLine("K= Kämpfen H= Herausfordern S= Sprechen X= Xylophon");
                                    Problem2 = Console.ReadLine().ToUpper();
                                    Console.Clear();
                                    switch (Problem2)
                                    {
                                        case "K":
                                            Console.WriteLine("Das Pferd Bekämpft den König");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("Der König schlägt vor, einen Würfel zu werfen.\nWer die Zahl erratet darf die Geisel mitnehmen.");
                                            Console.ReadLine();
                                            Console.WriteLine("Das Pferd willigt ein.");
                                            Console.ReadLine();


                                            //Anfang Würfelspiel
                                            int resultat = 0;
                                            for (int zähler = 100; zähler > 0 && resultat < 1; zähler++)
                                            {
                                                Console.Clear();
                                                Console.Write("Das Pferd rät: ");
                                                int zahl_Pferd = Convert.ToInt32(Console.ReadLine());   //Eingabe Würfelzahl
                                                Console.Write("Der König rät: ");
                                                System.Threading.Thread.Sleep(100);
                                                Random königRand = new Random();                       //Würfelzahl des Magiers
                                                int zahl_König = königRand.Next(1, 7);
                                                Console.Write(zahl_König);
                                                Console.ReadLine();
                                                Random rnd = new Random();                              //Zahl des Würfels
                                                int Würfel = rnd.Next(1, 7);
                                                Console.Write("Der Würfel fällt auf ");
                                                System.Threading.Thread.Sleep(100);
                                                Console.Write(Würfel);
                                                Console.ReadLine();
                                                Console.Clear();
                                                //Abfrage ob jemand die Zahl erraten hat
                                                if (Würfel == zahl_Pferd)
                                                {
                                                    resultat++;
                                                    Console.WriteLine("Das Pferd hat gewonnen!");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.Write("Es geht mit ");
                                                    switch (Person)
                                                    {
                                                        case "Prinzessin":
                                                            Console.Write("der Prinzessin");
                                                            break;
                                                        case "Opa":
                                                            Console.Write("seinem Opa");
                                                            break;
                                                        case "Hund":
                                                            Console.Write("seinem Hund");
                                                            break;
                                                        case "Kürbis":
                                                            Console.Write("seinem Kürbis");
                                                            break;
                                                    }
                                                    Console.Write(" ins Dorf zurück.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("THE END!!!");
                                                }
                                                if (Würfel == zahl_König)
                                                {
                                                    resultat++;
                                                    Console.WriteLine("Der König hat gewonnen!");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("Das Pferd wird in den Kerker gesperrt und wird nie mehr freigelassen.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("GAME OVER");
                                                }
                                                if (Würfel != zahl_König && Würfel != zahl_Pferd)
                                                {
                                                    Console.WriteLine("Keiner hat die Zahl erraten.");
                                                    Console.ReadLine();

                                                }
                                                if (Würfel == zahl_Pferd && Würfel == zahl_König)
                                                {
                                                    Console.WriteLine("Beide haben die Zahl erraten.\nEs wird weiter gewürfelt.");
                                                    Console.ReadLine();
                                                }
                                            }

                                            break;

                                        case "H":
                                            Console.WriteLine("Das Pferd fordert den König zu einem Podrennen heraus.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Random rand = new Random();                              //Zufälliges Ende
                                            int Podrennen = rand.Next(1, 4);
                                            switch (Podrennen)
                                            {
                                                case 1:
                                                    Console.WriteLine("Direkt am Start fällt der Motor des Pferdes aus. Trotz dem anfänglichen Missgeschick kommt es\nam Ende noch zu einem Kopf an Kopf rennen.\nMit minimalem Vorsprung gewinnt der König.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("GAME OVER");
                                                    break;

                                                case 2:
                                                    Console.WriteLine("Das Pferd ist schneller als der König. Schon in der Hälfte des Rennes ist klar, wer gewinnen wird.\nDoch das Pferd wird übermütig und will eine Rolle machen.\nDie Rolle funktioniert einwandfrei doch als es wieder auf den Boden kommt\nverliert es die Haftung und fliegt in eine Felswand.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("GAME OVER");
                                                    break;

                                                case 3:
                                                    Console.WriteLine("Das Pferd hat einen Vorsprung. Dem König passt das garnicht und er schickt seine Lakeien, um den Podrenner des Pferds auseinanderzunehmen.\nDies zählt als eine Regelmissachtung und der König wird disqualifiziert.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("GEWONNEN");
                                                    break;
                                            }

                                            break;

                                        case "S":
                                            //Deadend
                                            Console.WriteLine("Das Pferd will mit dem König verhandeln,\ndoch leider versteht er kein Pferdisch.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("Der König jagt das Pferd aus seinem Turm.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("GAME OVER");
                                            break;

                                        case "X":
                                            Console.WriteLine("Das Pferd hat ein Xylophon gefunden und möchte dem König ein kleines Liedchen vorspielen.");
                                            Console.ReadLine();
                                            Console.Write("Töne: A B C D E F G\n\nErster Ton: ");       //Anfang Eingabe Töne
                                            string ton1 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nZweiter Ton: ");
                                            string ton2 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nDritter Ton: ");
                                            string ton3 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nVierter Ton: ");
                                            string ton4 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nFünfter Ton: ");
                                            string ton5 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nSechster Ton: ");
                                            string ton6 = Console.ReadLine().ToUpper();                 //Schluss Eingabe Töne
                                            Console.Clear();
                                            //Ausgabe Töne
                                            {
                                                switch (ton1)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton2)
                                                {
                                                    case "A":
                                                        Console.Beep(1500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton3)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton4)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton5)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton6)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                            }

                                            Console.WriteLine("Der König ist so begeistert von den Spielkünsten des Pferdes, dass er explodiert.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.Write("Das Pferd geht mit ");
                                            switch (Person)
                                            {
                                                case "Prinzessin":
                                                    Console.Write("der Prinzessin");
                                                    break;
                                                case "Opa":
                                                    Console.Write("seinem Opa");
                                                    break;
                                                case "Hund":
                                                    Console.Write("seinem Hund");
                                                    break;
                                                case "Kürbis":
                                                    Console.Write("seinem Kürbis");
                                                    break;
                                            }
                                            Console.Write(" ins Dorf zurück.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("THE END!!!");

                                            break;
                                    }
                                    break;

                                case "Mathe":
                                    Console.WriteLine("Das Pferd findet Mathe Was wird es tun?");
                                    Console.WriteLine("K= Kämpfen H= Herausfordern S= Sprechen X= Xylophon");
                                    Problem2 = Console.ReadLine().ToUpper();
                                    Console.Clear();
                                    switch(Problem2)
                                    {
                                        case "K":
                                            Console.WriteLine("Das Pferd will Mathe bekämpfen. Doch wie bekämpft man etwas,\ndas keinen Körper hat und eigentlich nur eine Vorstellung der Menschen ist?");
                                            Console.ReadLine();
                                            Console.WriteLine("Das Pferd denkt zu viel über diese Frage nach und wird von einer hinterhältigen Quadratwurzel von Mathe direkt getroffen.");
                                            Console.ReadLine();
                                            Console.WriteLine("Das Pferd ist gestorben.");
                                            Console.ReadLine();
                                            Console.WriteLine("GAME OVER");
                                            break;

                                        case "H":
                                            Random rnd = new Random();
                                            int zahl_1, zahl_2;
                                            int lösung;
                                            rnd = new Random();
                                            Console.WriteLine("Mathe fordert das Pferd zu einer Runde Rechnen auf.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            int hp_P = 100, hp_M = 100, aufgabe;
                                            for (int i = 100; i > 0 && hp_P > 0 && hp_M > 0; i++)
                                            {
                                                Console.WriteLine(" HP Pferd = {0}       HP Mathe = {1}", hp_P, hp_M);
                                                zahl_1 = rnd.Next(1, 1000);
                                                zahl_2 = rnd.Next(1, 1000);
                                                aufgabe = zahl_1 - zahl_2;
                                                Console.WriteLine("\n\nMathe stellt dem Pferd eine Rechenaufgabe.\n\nAufgabe: {0} - {1} = ", zahl_1, zahl_2);
                                                lösung = Convert.ToInt32(Console.ReadLine());
                                                if (lösung == aufgabe)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Richtig!");
                                                    hp_M = hp_M - 20;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Falsch! Die Lösung wäre {0}", aufgabe);
                                                    hp_P = hp_P - 50;

                                                }
                                                Console.ReadKey();
                                                Console.Clear();

                                            }

                                            if (hp_P <= 0)
                                            {
                                                Console.WriteLine("Das Pferd konnte die Matheaufgaben nicht verstehen und ist an Überanstrengung gestorben.\n Game Over");
                                            }
                                            if (hp_M <= 0)
                                            {
                                                Console.WriteLine("Das Pferd hat Mathe in seinem eigenen Spiel geschlagen! Mathe hat sich vor Entsetzen in Luft aufgelöst.");
                                                Console.ReadLine();
                                                Console.Clear();
                                                Console.Write("Das Pferd geht mit ");
                                                switch (Person)
                                                {
                                                    case "Prinzessin":
                                                        Console.Write("der Prinzessin");
                                                        break;
                                                    case "Opa":
                                                        Console.Write("seinem Opa");
                                                        break;
                                                    case "Hund":
                                                        Console.Write("seinem Hund");
                                                        break;
                                                    case "Kürbis":
                                                        Console.Write("seinem Kürbis");
                                                        break;
                                                }
                                                Console.Write(" ins Dorf zurück.");
                                                Console.ReadLine();
                                                Console.Clear();
                                                Console.WriteLine("THE END!!!");
                                            }
                                            break;

                                        case "S":
                                            //Deadend
                                            Console.WriteLine("Das Pferd will mit Mathe verhandeln,\ndoch leider versteht es kein Pferdisch.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("Mathe jagt das Pferd aus seinem Turm.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("GAME OVER");
                                            break;

                                        case "X":
                                            Console.WriteLine("Das Pferd hat ein Xylophon gefunden und möchte Mathe ein kleines Liedchen vorspielen.");
                                            Console.ReadLine();
                                            Console.Write("Töne: A B C D E F G\n\nErster Ton: ");       //Anfang Eingabe Töne
                                            string ton1 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nZweiter Ton: ");
                                            string ton2 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nDritter Ton: ");
                                            string ton3 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nVierter Ton: ");
                                            string ton4 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nFünfter Ton: ");
                                            string ton5 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nSechster Ton: ");
                                            string ton6 = Console.ReadLine().ToUpper();                 //Schluss Eingabe Töne
                                            Console.Clear();
                                            //Ausgabe Töne
                                            {
                                                switch (ton1)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton2)
                                                {
                                                    case "A":
                                                        Console.Beep(1500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton3)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton4)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton5)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton6)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                            }

                                            Console.WriteLine("Mathe ist so begeistert von den Spielkünsten des Pferdes, dass es explodiert.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.Write("Das Pferd geht mit ");
                                            switch (Person)
                                            {
                                                case "Prinzessin":
                                                    Console.Write("der Prinzessin");
                                                    break;
                                                case "Opa":
                                                    Console.Write("seinem Opa");
                                                    break;
                                                case "Hund":
                                                    Console.Write("seinem Hund");
                                                    break;
                                                case "Kürbis":
                                                    Console.Write("seinem Kürbis");
                                                    break;
                                            }
                                            Console.Write(" ins Dorf zurück.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("THE END!!!");

                                            break;
                                    }
                                    
                                    break;

                                case "Huhn":
                                    Console.WriteLine("Das Pferd findet das Huhn. Was wird es tun?");
                                    Console.WriteLine("K= Kämpfen H= Herausfordern S= Sprechen X= Xylophon");
                                    Problem2 = Console.ReadLine().ToUpper();
                                    Console.Clear();
                                    switch (Problem2)
                                    {
                                        case "K":
                                            Console.WriteLine("Das Pferd Bekämpft das Huhn");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("Das Huhn schlägt vor, einen Würfel zu werfen.\nWer die Zahl erratet darf die Geisel mitnehmen.");
                                            Console.ReadLine();
                                            Console.WriteLine("Das Pferd willigt ein.");
                                            Console.ReadLine();


                                            //Anfang Würfelspiel
                                            int resultat = 0;
                                            for (int zähler = 100; zähler > 0 && resultat < 1; zähler++)
                                            {
                                                Console.Clear();
                                                Console.Write("Das Pferd rät: ");
                                                int zahl_Pferd = Convert.ToInt32(Console.ReadLine());   //Eingabe Würfelzahl
                                                Console.Write("Das Huhn rät: ");
                                                System.Threading.Thread.Sleep(100);
                                                Random huhnRand = new Random();                       //Würfelzahl Huhn
                                                int zahl_Huhn = huhnRand.Next(1, 7);
                                                Console.Write(zahl_Huhn);
                                                Console.ReadLine();
                                                Random rnd = new Random();                              //Zahl des Würfels
                                                int Würfel = rnd.Next(1, 7);
                                                Console.Write("Der Würfel fällt auf ");
                                                System.Threading.Thread.Sleep(100);
                                                Console.Write(Würfel);
                                                Console.ReadLine();
                                                Console.Clear();
                                                //Abfrage ob jemand die Zahl erraten hat
                                                if (Würfel == zahl_Pferd)
                                                {
                                                    resultat++;
                                                    Console.WriteLine("Das Pferd hat gewonnen!");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.Write("Es geht mit ");
                                                    switch (Person)
                                                    {
                                                        case "Prinzessin":
                                                            Console.Write("der Prinzessin");
                                                            break;
                                                        case "Opa":
                                                            Console.Write("seinem Opa");
                                                            break;
                                                        case "Hund":
                                                            Console.Write("seinem Hund");
                                                            break;
                                                        case "Kürbis":
                                                            Console.Write("seinem Kürbis");
                                                            break;
                                                    }
                                                    Console.Write(" ins Dorf zurück.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("THE END!!!");
                                                }
                                                if (Würfel == zahl_Huhn)
                                                {
                                                    resultat++;
                                                    Console.WriteLine("Das Huhn hat gewonnen!");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("Das Pferd wird in den Kerker gesperrt und wird nie mehr freigelassen.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("GAME OVER");
                                                }
                                                if (Würfel != zahl_Huhn && Würfel != zahl_Pferd)
                                                {
                                                    Console.WriteLine("Keiner hat die Zahl erraten.");
                                                    Console.ReadLine();

                                                }
                                                if (Würfel == zahl_Pferd && Würfel == zahl_Huhn)
                                                {
                                                    Console.WriteLine("Beide haben die Zahl erraten.\nEs wird weiter gewürfelt.");
                                                    Console.ReadLine();
                                                }
                                            }

                                            break;

                                        case "H":
                                            Console.WriteLine("Das Pferd fordert das Huhn zu einem Podrennen heraus.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Random rand = new Random();                              //Zufälliges Ende
                                            int Podrennen = rand.Next(1, 4);
                                            switch (Podrennen)
                                            {
                                                case 1:
                                                    Console.WriteLine("Direkt am Start fällt der Motor des Pferdes aus. Trotz dem anfänglichen Missgeschick kommt es\nam Ende noch zu einem Kopf an Kopf rennen.\nMit minimalem Vorsprung gewinnt das Huhn.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("GAME OVER");
                                                    break;

                                                case 2:
                                                    Console.WriteLine("Das Pferd ist schneller als das Huhn. Schon in der Hälfte des Rennes ist klar, wer gewinnen wird.\nDoch das Pferd wird übermütig und will eine Rolle machen.\nDie Rolle funktioniert einwandfrei doch als es wieder auf den Boden kommt\nverliert es die Haftung und fliegt in eine Felswand.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("GAME OVER");
                                                    break;

                                                case 3:
                                                    Console.WriteLine("Das Pferd hat einen Vorsprung. Dem Huhn passt das garnicht und es bewirft das Pferd mit Eiern.\nDies zählt als eine Regelmissachtung und das Huhn wird disqualifiziert.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("GEWONNEN");
                                                    break;
                                            }

                                            break;

                                        case "S":
                                            Console.WriteLine("Das Pferd will mit dem Huhn verhandeln.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("Das Huhn willigt ein, die Geisel freizulassen und bekommt dafür eine Schnabelfeile.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.Write("Das Pferd geht mit ");
                                            switch (Person)
                                            {
                                                case "Prinzessin":
                                                    Console.Write("der Prinzessin");
                                                    break;
                                                case "Opa":
                                                    Console.Write("seinem Opa");
                                                    break;
                                                case "Hund":
                                                    Console.Write("seinem Hund");
                                                    break;
                                                case "Kürbis":
                                                    Console.Write("seinem Kürbis");
                                                    break;
                                            }
                                            Console.Write(" ins Dorf zurück.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("THE END!!!");

                                            break;

                                        case "X":
                                            Console.WriteLine("Das Pferd hat ein Xylophon gefunden und möchte dem Huhn ein kleines Liedchen vorspielen.");
                                            Console.ReadLine();
                                            Console.Write("Töne: A B C D E F G\n\nErster Ton: ");       //Anfang Eingabe Töne
                                            string ton1 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nZweiter Ton: ");
                                            string ton2 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nDritter Ton: ");
                                            string ton3 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nVierter Ton: ");
                                            string ton4 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nFünfter Ton: ");
                                            string ton5 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nSechster Ton: ");
                                            string ton6 = Console.ReadLine().ToUpper();                 //Schluss Eingabe Töne
                                            Console.Clear();
                                            //Ausgabe Töne
                                            {
                                                switch (ton1)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton2)
                                                {
                                                    case "A":
                                                        Console.Beep(1500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton3)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton4)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton5)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton6)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                            }

                                            Console.WriteLine("Das Huhn ist so begeistert von den Spielkünsten des Pferdes, dass es explodiert.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.Write("Das Pferd geht mit ");
                                            switch (Person)
                                            {
                                                case "Prinzessin":
                                                    Console.Write("der Prinzessin");
                                                    break;
                                                case "Opa":
                                                    Console.Write("seinem Opa");
                                                    break;
                                                case "Hund":
                                                    Console.Write("seinem Hund");
                                                    break;
                                                case "Kürbis":
                                                    Console.Write("seinem Kürbis");
                                                    break;
                                            }
                                            Console.Write(" ins Dorf zurück.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("THE END!!!");

                                            break;
                                    }

                                    break;
                            }
                            break;
                    }
                    break;
                case "Z":                   
                    Console.Clear();
                    Console.WriteLine(grenze);
                    switch (Hauptcharakter)
                    {
                        case "Magier":
                            Console.WriteLine("Der Magier nimmt seinen Zauberstab heraus und beschwört eine grosse Flutwelle, die alle {0} wegschwemmt und ein kleines Bauerndorf überflutet. +10 Magiepunkte", Lakeien);
                            Console.SetCursorPosition(0, 4);
                            Console.WriteLine(grenze);
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine(grenze);
                            Console.SetCursorPosition(0, 8);
                            Console.WriteLine(grenze);
                            Console.SetCursorPosition(0, 3);
                            switch (Böse)
                            {
                                case "Böser Magier":
                                    Console.WriteLine("Der Magier trifft auf seinen Erzfeind.\n\nDEN BÖSEN MAGIER\n\nWas wird er tun?\n");
                                    Console.Write("D= Duellieren R=Reden C=Cheaten\n");
                                    string eingabe = Console.ReadLine().ToUpper();
                                    Console.Clear();
                                    switch(eingabe)
                                    {
                                        case "D":
                                            //Die Magier duellieren sich und es lauft auf einen Kampf der Elemente heraus
                                            Console.WriteLine("Es gibt ein grosses Magierduell, um für ein und alle Mal zu bestimmen, wer der beste Magier ist.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Random rnd = new Random();
                                            int attackeBöserMagier = rnd.Next(1,4);
                                            int hp_Magier = 100, hp_BöserMagier = 100, attackeMagier = 0;
                                            for (int i = 1; i < 100 && hp_BöserMagier > 0 && hp_Magier > 0; i++)
                                            {
                                                attackeBöserMagier = rnd.Next(1, 4);
                                                Console.WriteLine("HP Magier = {0}        HP Böser Magier = {1}\n", hp_Magier, hp_BöserMagier);
                                                Console.WriteLine("F: Feuer W: Wasser P: Pflanze\n");
                                                string attacke = Console.ReadLine().ToUpper();
                                                switch (attacke)
                                                {
                                                    case "F":
                                                        Console.WriteLine("Der Magier zaubert einen Feuersturm herbei.");
                                                        attackeMagier = 1;
                                                        break;

                                                    case "W":
                                                        Console.WriteLine("Der Magier zaubert einen Tsunami herbei.");
                                                        attackeMagier = 2;
                                                        break;

                                                    case "P":
                                                        Console.WriteLine("Der Magier zaubert drei Ents herbei.");
                                                        attackeMagier = 3;

                                                        break;

                                                    default:
                                                        Console.WriteLine("Fehler bei der Attacke.");
                                                        attackeMagier = 0;
                                                        break;
                                                }
                                                Console.ReadLine();
                                                switch(attackeBöserMagier)
                                                {
                                                    case 1:
                                                        Console.WriteLine("Der böse Magier zaubert einen Feuersturm herbei.\n");
                                                        break;

                                                    case 2:
                                                        Console.WriteLine("Der böse Magier zaubert einen Tsunami herbei.\n");
                                                        break;

                                                    case 3:
                                                        Console.WriteLine("Der böse Magier zaubert drei Ents herbei.\n");
                                                        break;
                                                }
                                                Console.ReadLine();
                                                //Runden
                                                {
                                                    //Gleiches Element
                                                    if (attackeMagier == attackeBöserMagier)
                                                    {
                                                        Console.WriteLine("Die Magier haben die gleiche art der Magie verwendet und schaden sich gegenseitig nicht.");
                                                    }
                                                    //Gute Runden
                                                    if (attackeMagier == 1 && attackeBöserMagier == 3)
                                                    {
                                                        Console.WriteLine("Der Magier verbrennt die Ents und verletzt den bösen Magier.");
                                                        hp_BöserMagier = hp_BöserMagier - 25;
                                                    }
                                                    if (attackeMagier == 2 && attackeBöserMagier == 1)
                                                    {
                                                        Console.WriteLine("Der Zunami löscht den Feuersturm und überschwemmt den bösen Magier.");
                                                        hp_BöserMagier = hp_BöserMagier - 25;
                                                    }
                                                    if (attackeMagier == 3 && attackeBöserMagier == 2)
                                                    {
                                                        Console.WriteLine("Die Ents halten den Zunami von dir fern und schlagen den bösen Magier.");
                                                        hp_BöserMagier = hp_BöserMagier - 25;
                                                    }
                                                    //Schlechte Runden
                                                    if (attackeMagier == 1 && attackeBöserMagier == 2)
                                                    {
                                                        Console.WriteLine("Der Zunami löscht den Feuersturm und überschwemmt den Magier.");
                                                        hp_Magier = hp_Magier - 25;
                                                    }
                                                    if (attackeMagier == 2 && attackeBöserMagier == 3)
                                                    {
                                                        Console.WriteLine("Der Zunami wird von den Ents aufgehalten und der Magier wird von ihnen geschlagen.");
                                                        hp_Magier = hp_Magier - 25;
                                                    }
                                                    if (attackeMagier == 3 && attackeBöserMagier == 1)
                                                    {
                                                        Console.WriteLine("Der böse Magier verbrennt die Ents und verletzt den Magier.");
                                                        hp_Magier = hp_Magier - 25;
                                                    }
                                                    if (attackeMagier == 0)
                                                    {
                                                        Console.WriteLine("Die Attacke des bösen Magiers trifft den Magier und zieht ihm viel Leben ab.");
                                                        hp_Magier = hp_Magier - 50;
                                                    }
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                }
                                            }
                                            //Endversionen
                                            {
                                                if (hp_Magier <= 0)
                                                {
                                                    Console.WriteLine("Der Magier ist gestorben.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("GAME OVER");
                                                }
                                                if (hp_BöserMagier <= 0)
                                                {
                                                    Console.WriteLine("Der böse Magier wurde besiegt.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.Write("Der Magier geht mit");
                                                    switch (Person)
                                                    {
                                                        case "Prinzessin":
                                                            Console.Write("der Prinzessin");
                                                            break;
                                                        case "Opa":
                                                            Console.Write("seinem Opa");
                                                            break;
                                                        case "Hund":
                                                            Console.Write("seinem Hund");
                                                            break;
                                                        case "Kürbis":
                                                            Console.Write("seinem Kürbis");
                                                            break;
                                                    }
                                                    Console.Write(" ins Dorf zurück.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("THE END!!!");
                                                }
                                            }
                                            break;

                                        case "R":
                                            Console.WriteLine("Der Magier versucht den bösen Magier zu vernunft zu bringen\ndoch dieser will nichts hören und zaubert den Magier in eine zeitlose Dimension.");
                                            Console.ReadLine();
                                            Console.WriteLine("GAME OVER\nfür immer und ewig");
                                            break;

                                        case "C":
                                            Console.WriteLine("Der Magier öffnet die Konsole.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            //Konsolensimulation
                                            Console.ForegroundColor=ConsoleColor.Green;
                                            //Ladesimulation
                                            for (int i = 1; i < 10; i++ )
                                            {
                                                Console.Write("Loading Mainframe |");
                                                System.Threading.Thread.Sleep(70);
                                                Console.Clear();
                                                Console.Write("Loading Mainframe /");
                                                System.Threading.Thread.Sleep(70);
                                                Console.Clear();
                                                Console.Write("Loading Mainframe -");
                                                System.Threading.Thread.Sleep(70);
                                                Console.Clear();
                                                Console.Write("Loading Mainframe \\");
                                                System.Threading.Thread.Sleep(70);
                                                Console.Clear();
                                                Console.Write("Loading Mainframe |");
                                                System.Threading.Thread.Sleep(70);
                                                Console.Clear();
                                                Console.Write("Loading Mainframe /");
                                                System.Threading.Thread.Sleep(70);
                                                Console.Clear();
                                                Console.Write("Loading Mainframe -");
                                                System.Threading.Thread.Sleep(70);
                                                Console.Clear();
                                                Console.Write("Loading Mainframe \\");
                                                System.Threading.Thread.Sleep(70);
                                                Console.Clear();
                                            }
                                            //Eingabesimulation
                                            Console.WriteLine("Mainframe loaded");
                                            System.Threading.Thread.Sleep(600);
                                            Console.Write("h");
                                            System.Threading.Thread.Sleep(200);
                                            Console.Write("p");
                                            System.Threading.Thread.Sleep(200);
                                            Console.Write("_");
                                            System.Threading.Thread.Sleep(200);
                                            Console.Write("b");
                                            System.Threading.Thread.Sleep(200);
                                            Console.Write("ö");
                                            System.Threading.Thread.Sleep(200);
                                            Console.Write("s");
                                            System.Threading.Thread.Sleep(200);
                                            Console.Write("e");
                                            System.Threading.Thread.Sleep(200);
                                            Console.Write("r");
                                            System.Threading.Thread.Sleep(200);
                                            Console.Write("M");
                                            System.Threading.Thread.Sleep(200);
                                            Console.Write("a");
                                            System.Threading.Thread.Sleep(200);
                                            Console.Write("g");
                                            System.Threading.Thread.Sleep(200);
                                            Console.Write("i");
                                            System.Threading.Thread.Sleep(200);
                                            Console.Write("e");
                                            System.Threading.Thread.Sleep(200);
                                            Console.Write("r");
                                            System.Threading.Thread.Sleep(200);
                                            Console.Write(" ");
                                            System.Threading.Thread.Sleep(200);
                                            Console.Write("=");
                                            System.Threading.Thread.Sleep(200);
                                            Console.Write(" ");
                                            System.Threading.Thread.Sleep(200);
                                            Console.Write("0");
                                            System.Threading.Thread.Sleep(400);
                                            Console.Clear();
                                            System.Threading.Thread.Sleep(600);
                                            for(int i= 100; i>=0;i--)
                                            {
                                                Console.WriteLine("hp_böserMagier = {0}", i);
                                                System.Threading.Thread.Sleep(50);
                                            }
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("Der böse Magier bekommt auf einmal einen Herzinfarkt. Er stirbt an Ort und Stelle.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("THE END");




                                            break;
                                    }
                                    break;

                                case "König":
                                    Console.WriteLine("Der Magier trifft auf den König.");
                                    Console.ReadLine();
                                    Console.Clear();
                                    Console.WriteLine("Dem Magier wird es so langsam zu viel Arbeit.\nEr zückt sein DeathNote und schreibt den Namen des Königs hinein.\nWenige Sekunden später bricht der König zusammen.");
                                    Console.ReadLine();
                                    Console.Clear();
                                    Console.Write("Der Magier geht mit");
                                    switch (Person)
                                    {
                                        case "Prinzessin":
                                            Console.Write("der Prinzessin");
                                            break;
                                        case "Opa":
                                            Console.Write("seinem Opa");
                                            break;
                                        case "Hund":
                                            Console.Write("seinem Hund");
                                            break;
                                        case "Kürbis":
                                            Console.Write("seinem Kürbis");
                                            break;
                                    }
                                    Console.Write(" ins Dorf zurück.");
                                    Console.ReadLine();
                                    Console.Clear();
                                    Console.WriteLine("THE END!!!");
                                    break;

                                case "Mathe":
                                    int lösung1 = 3, lösung2 = 16, lösung3 = 8;
                                    Console.WriteLine("Der Magier trifft auf Mathe.");
                                    Console.ReadLine();
                                    Console.SetCursorPosition(0, 3);
                                    Console.WriteLine("Der Magier gibt dem Zauberer eine Rechenpyramiede vor. wenn er diese lösen kann, so lässt Mathe die Geisel frei.\nWenn er aber einen Fehler macht, so wird er einen Qualvollen Tod sterben.");
                                    Console.ReadLine();
                                    Console.Clear();
                                    Console.WriteLine("Multipliziere!\n");
                                    Console.WriteLine("            ------");
                                    Console.WriteLine("           |  96  |");
                                    Console.WriteLine("            ------");
                                    Console.WriteLine("        ------  ------");
                                    Console.WriteLine("       |  z2  ||  06  |");
                                    Console.WriteLine("        ------  ------");
                                    Console.WriteLine("    ------  ------  ------");
                                    Console.WriteLine("   |  z3  ||  02  ||  z1  |");
                                    Console.WriteLine("    ------  ------  ------");
                                    Console.Write("\n Zahl 1 = ");
                                    int zahl1 = Convert.ToInt32(Console.ReadLine());
                                    Console.SetCursorPosition(0, 12);
                                    Console.Write("                                             ");
                                    Console.SetCursorPosition(0, 12);
                                    Console.Write("Zahl 2 = ");
                                    int zahl2 = Convert.ToInt32(Console.ReadLine());
                                    Console.SetCursorPosition(0, 12);
                                    Console.Write("                                             ");
                                    Console.SetCursorPosition(0, 12);
                                    Console.Write("Zahl 3 = ");
                                    int zahl3 = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    if(zahl1 == lösung1 && zahl2 == lösung2 && zahl3 == lösung3)
                                    {
                                        Console.Write("Die Antwort war richtig!\n\nDer Magier geht mit ");
                                        switch (Person)
                                        {
                                            case "Prinzessin":
                                                Console.Write("der Prinzessin");
                                                break;
                                            case "Opa":
                                                Console.Write("seinem Opa");
                                                break;
                                            case "Hund":
                                                Console.Write("seinem Hund");
                                                break;
                                            case "Kürbis":
                                                Console.Write("seinem Kürbis");
                                                break;
                                        }
                                        Console.Write(" ins Dorf zurück.");
                                        Console.ReadLine();
                                        Console.Clear();
                                        Console.WriteLine("THE END!!!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Die Antwort war falsch.");
                                        Console.ReadLine();
                                        Console.Clear();
                                        Console.WriteLine("Der Magier wird in 100 Stücke zerrissen");
                                        Console.ReadLine();
                                        Console.Clear();
                                        Console.WriteLine("GAME OVER");
                                    }
                                    break;

                                case "Huhn":
                                    Console.WriteLine("Der Magier trifft auf das Huhn");
                                    Console.ReadLine();
                                    Console.SetCursorPosition(0, 3);
                                    Console.WriteLine("Der Magier versucht das Huhn zu streicheln.\nDas gefällt dem Huhn nicht und es pickt ihn zu tode.");
                                    Console.ReadLine();
                                    Console.SetCursorPosition(0, 3);
                                    Console.WriteLine("                                                                                                     ");
                                    Console.SetCursorPosition(0, 3);
                                    Console.WriteLine("GAME OVER");
                                    break;
                            }
                            break;
                        case "Dieb":
                            Console.WriteLine("Der Dieb nimmt eine Schlafbombe und wirft sie zwischen die {0}. In wenigen Sekunden sind alle eingeschlafen. Ist zwar keine Magie, aber auch wirkungsvoll.", Lakeien);
                            Console.SetCursorPosition(0, 4);
                            Console.WriteLine(grenze);
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine(grenze);
                            Console.SetCursorPosition(0, 9);
                            Console.WriteLine(grenze);
                            Console.SetCursorPosition(0, 3);
                            switch (Böse)
                            {
                                case "Böser Magier":
                                    Console.WriteLine("Der Dieb geht zum höchsten Punkt des Turms und findet den bösen Magier.\n");
                                    Console.WriteLine("Was soll er tun?\n");
                                    Console.WriteLine("K= Kämpfen S= Schleichen A= Ansprechen G= Gehen");
                                    Problem2 = Console.ReadLine().ToUpper();
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine(grenze);
                                    Console.SetCursorPosition(0, 2);
                                    switch (Problem2)
                                    {
                                        case "K":
                                            int hp_D = 100, hp_M = 100, knie = 2, superAttacke = 0, wand = 0, sand = 0;
                                            Random rnd = new Random();
                                            int angriff_M;
                                            rnd = new Random();
                                            string angriff_D;
                                            Console.WriteLine("Der Dieb bekämpft den Magier.\n");
                                            Console.ReadLine();

                                            for (int i = 100; i >= 0 && hp_D > 0 && hp_M > 0; i++)                         //Pokemon Fight!!!!!!!!!!!!!
                                            {
                                                Console.Clear();
                                                Console.WriteLine("HP Dieb = {0}        HP Magier = {1}", hp_D, hp_M);
                                                Console.WriteLine("Welche Attacke wird der Dieb einsetzen?\nSandwirbel: S      Messersturm: M     Pantomime: P     Bogen: B     Schlag dich selbst: X     ");
                                                angriff_D = Console.ReadLine().ToUpper();
                                                switch (angriff_D)                                    //Dieb greift an
                                                {
                                                    case "S":
                                                        Console.Clear();
                                                        Console.WriteLine("Der Dieb wirft dem Magier Sand ins Gesicht. Genauigkeit des Magiers wird schlechter");
                                                        sand = 1;
                                                        Console.ReadLine();
                                                        break;
                                                    case "M":
                                                        Console.Clear();
                                                        Console.WriteLine("Der Dieb bewirft den Magier mit Küchenmessern. Sehr Effektiv");
                                                        Console.ReadLine();
                                                        hp_M = hp_M - 20;
                                                        break;
                                                    case "P":
                                                        Console.Clear();
                                                        Console.WriteLine("Der Dieb tut so, als wäre eine unsichtbare Wand vor ihm.\n Der Magier ist verwirrt und greift diese Runde nicht an.");
                                                        wand = 1;
                                                        Console.ReadLine();
                                                        break;
                                                    case "B":
                                                        Console.Clear();
                                                        if (knie > 0)
                                                        {
                                                            Console.WriteLine("Der Dieb schiesst dem Magier einen Pfeil ins Knie. ");
                                                            Console.ReadLine();
                                                            hp_M = hp_M - 25;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Du hast dem Magier schon in beide Knie geschossen. Angriff nicht sehr effektiv.");
                                                            Console.ReadLine();
                                                            hp_M = hp_M - 5;
                                                        }
                                                        break;
                                                    case "X":
                                                        Console.Clear();
                                                        Console.WriteLine("Der Dieb schlägt sich selbst.\n\nGenial.");
                                                        Console.ReadLine();
                                                        hp_D = hp_D - 10;
                                                        break;

                                                    default:
                                                        Console.WriteLine("Du hast dem Dieb keine richtige Aufgabe gegeben. Er greift diese Runde nicht an.");
                                                        break;
                                                }

                                                if (wand == 1)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Der Magier greift nicht an");        //Dank der Pantomieme greift der Magier nicht an
                                                    wand = 0;
                                                    superAttacke = 0;
                                                    goto Ende_pokemon;
                                                }

                                                if (sand == 1)
                                                {
                                                    angriff_M = rnd.Next(1, 8);         //Sand macht es möglich, dass der Magier nicht trifft.
                                                }
                                                else
                                                {
                                                    angriff_M = rnd.Next(1, 7);
                                                }

                                                if (superAttacke == 1)
                                                {
                                                    Console.WriteLine("Der Magier hat sein Zauber aufgeladen und schickt einen Laser auf den Dieb zu.");
                                                    hp_D = hp_D - 70;                                                                                           //Der aufgeladene Angriff wurde nicht geblockt
                                                    superAttacke = 0;
                                                    goto Ende_pokemon;
                                                }

                                                switch (angriff_M)                                                  //Magier greift an
                                                {
                                                    case 1:
                                                        Console.Clear();
                                                        Console.WriteLine("Der Magier lädt seine Attacke auf.");
                                                        superAttacke = 1;
                                                        break;
                                                    case 2:
                                                        Console.Clear();
                                                        Console.WriteLine("Der Magier lässt es Steine regnen.");
                                                        hp_D = hp_D - 40;
                                                        break;
                                                    case 3:
                                                        Console.Clear();
                                                        Console.WriteLine("Der Magier zaubert einen Wirbelsturm herbei.");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Der Dieb fällt um.");
                                                        hp_D = hp_D - 5;
                                                        break;
                                                    case 4:
                                                        Console.Clear();
                                                        Console.WriteLine("Der Magier fliegt dumm rum. Nicht sehr effektiv");
                                                        break;
                                                    case 5:
                                                        Console.Clear();
                                                        Console.WriteLine("Der Magier schiesst einen Feuerball.");
                                                        hp_D = hp_D - 20;
                                                        break;
                                                    case 6:
                                                        Console.Clear();
                                                        Console.WriteLine("Der Magier trinkt einen Heiltrank.");
                                                        hp_M = hp_M + 10;
                                                        break;
                                                    case 7:
                                                        Console.Clear();
                                                        Console.WriteLine("Der Magier versucht den Dieb in die Luft zu sprengen, doch er verfehlt und trifft sich selbst.");
                                                        hp_M = hp_M - 30;
                                                        break;
                                                }
                                                Ende_pokemon:
                                                Console.ReadLine();
                                            }
                                            if (hp_D <= 0)                                                      //Dieb verliert
                                            {
                                                Console.WriteLine("Der Dieb ist gestorben.\n Game Over");
                                            }
                                            if (hp_M <= 0)                                                      //Dieb gewinnt
                                            {
                                                Console.WriteLine("Der Dieb hat den bösen Magier besiegt!");
                                                Console.ReadLine();
                                                Console.Clear();
                                                Console.Write("Er geht mit ");
                                                switch (Person)
                                                {
                                                    case "Prinzessin":
                                                        Console.Write("der Prinzessin");
                                                        break;
                                                    case "Opa":
                                                        Console.Write("seinem Opa");
                                                        break;
                                                    case "Hund":
                                                        Console.Write("seinem Hund");
                                                        break;
                                                    case "Kürbis":
                                                        Console.Write("seinem Kürbis");
                                                        break;
                                                }
                                                Console.Write(" ins Dorf zurück.");
                                                Console.ReadLine();
                                                Console.Clear();
                                                Console.WriteLine("THE END!!!");
                                            }
                                            break;

                                        case "S":
                                            //Deadend
                                            Console.WriteLine("Der Dieb gibt sein bestes beim Schleichen, doch er tappt in eine Falle des Magiers und wird von magischem Feuer verbrennt.");
                                            Console.Clear();
                                            Console.WriteLine("GAME OVER");
                                            break;

                                        case "A":
                                            Console.WriteLine("Der Dieb sagt zum bösen Zauberer:\"Hey du! Lass das!\"\n\"Ok, wenn du unbedingt willst.\", sagt der Magier und verschwindet.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.Write("Der Dieb geht mit ");
                                            switch (Person)
                                            {
                                                case "Prinzessin":
                                                    Console.Write("der Prinzessin");
                                                    break;
                                                case "Opa":
                                                    Console.Write("seinem Opa");
                                                    break;
                                                case "Hund":
                                                    Console.Write("seinem Hund");
                                                    break;
                                                case "Kürbis":
                                                    Console.Write("seinem Kürbis");
                                                    break;
                                            }
                                            Console.Write(" ins Dorf zurück.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("THE END!!!");
                                            break;

                                        case "G":
                                            //Deadend
                                            Console.WriteLine("Der Dieb dreht sich um und geht wieder ins Dorf zurück.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("GAME OVER");
                                            break;

                                        default:
                                            Console.WriteLine("DU WAS FALSCH GEMACHT HABEN!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                                            break;
                                    }
                                    break;

                                case "König":
                                    Console.WriteLine("Der Dieb findet den König im Turm auf.");
                                    Console.WriteLine("Wie wird er vorgehen?\n");
                                    Console.WriteLine("K= Kämpfen S= Schleichen A= Ansprechen G= Gehen");
                                    Problem2 = Console.ReadLine().ToUpper();
                                    Console.Clear();
                                    switch (Problem2)
                                    {
                                        case "K":
                                            int hp_D = 100, hp_K = 100, knie = 2, superAttacke = 0, geld = 0, sand = 0;
                                            Random rnd = new Random();
                                            int angriff_K;
                                            rnd = new Random();
                                            string angriff_D;
                                            Console.WriteLine("Der Dieb bekämpft den König.\n");
                                            Console.ReadLine();

                                            for (int i = 100; i >= 0 && hp_D > 0 && hp_K > 0; i++)                         //Pokemon Fight!!!!!!!!!!!!!
                                            {
                                                Console.Clear();
                                                Console.WriteLine("HP Dieb = {0}        HP Magier = {1}", hp_D, hp_K);
                                                Console.WriteLine("Welche Attacke wird der Dieb einsetzen?\nSandwirbel: S      Messersturm: M     Geldwurf: G      Bogen: B     Schlag dich selbst: X     ");
                                                angriff_D = Console.ReadLine().ToUpper();
                                                switch (angriff_D)                                    //Dieb greift an
                                                {
                                                    case "S":
                                                        Console.Clear();
                                                        Console.WriteLine("Der Dieb wirft dem König Sand ins Gesicht. Genauigkeit des Königs wird schlechter");
                                                        sand = 1;
                                                        Console.ReadLine();
                                                        break;
                                                    case "M":
                                                        Console.Clear();
                                                        Console.WriteLine("Der Dieb bewirft den König mit Küchenmessern. Sehr Effektiv");
                                                        Console.ReadLine();
                                                        hp_K = hp_K - 20;
                                                        break;
                                                    case "P":
                                                        Console.Clear();
                                                        Console.WriteLine("Der Dieb wirft Münzen auf den Boden.\nDer König sammelt sie auf. ");
                                                        geld = 1;
                                                        Console.ReadLine();
                                                        break;
                                                    case "B":
                                                        Console.Clear();
                                                        if (knie > 0)
                                                        {
                                                            Console.WriteLine("Der Dieb schiesst dem König einen Pfeil ins Knie. ");
                                                            Console.ReadLine();
                                                            hp_K = hp_K - 25;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Du hast dem König schon in beide Knie geschossen. Angriff nicht sehr effektiv.");
                                                            Console.ReadLine();
                                                            hp_K = hp_K - 5;
                                                        }
                                                        break;
                                                    case "X":
                                                        Console.Clear();
                                                        Console.WriteLine("Der Dieb schlägt sich selbst.\n\nGenial.");
                                                        Console.ReadLine();
                                                        hp_D = hp_D - 10;
                                                        break;
                                                    default:
                                                        Console.Clear();
                                                        Console.WriteLine("Du hast dem Dieb kein richtiges Kommando gegeben.\nEr greifft nicht an.");
                                                        Console.ReadLine();
                                                        break;
                                                }

                                                if (geld == 1)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Der König greift nicht an, da er \ndamit beschäftigt ist, die Münzen aufzusammeln.");        //Dank dem Geldwurf greift der König nicht an
                                                    geld = 0;
                                                    goto Ende_pokemon;
                                                }

                                                if (sand == 1)
                                                {
                                                    angriff_K = rnd.Next(1, 8);         //Sand macht es möglich, dass der König nicht trifft.
                                                }
                                                else
                                                {
                                                    angriff_K = rnd.Next(1, 7);
                                                }

                                                if (superAttacke == 1)
                                                {
                                                    Console.WriteLine("Der König hat seine Armbrust fertig geladen und schiesst einen brennenden Pfeil auf den Dieb.");
                                                    hp_D = hp_D - 70;                                                                                           //Der aufgeladene Angriff wurde nicht geblockt
                                                    superAttacke = 0;
                                                    goto Ende_pokemon;
                                                }

                                                switch (angriff_K)                                                  //König greift an
                                                {
                                                    case 1:
                                                        Console.Clear();
                                                        Console.WriteLine("Der König lädt seine Armbrust.");
                                                        superAttacke = 1;
                                                        break;
                                                    case 2:
                                                        Console.Clear();
                                                        Console.WriteLine("Der König holt drei {0} und greift den Dieb mit ihnen an.", Lakeien);
                                                        hp_D = hp_D - 40;
                                                        break;
                                                    case 3:
                                                        Console.Clear();
                                                        Console.WriteLine("Der König wirft dem Dieb eine Münze an den Kopf.\n\n+1 Münze");
                                                        hp_D = hp_D - 5;
                                                        break;
                                                    case 4:
                                                        Console.Clear();
                                                        Console.WriteLine("Der König putzt seine Krone.\nNicht sehr effektiv");
                                                        break;
                                                    case 5:
                                                        Console.Clear();
                                                        Console.WriteLine("Der König bewirft den Dieb mit einer Schatztruhe");
                                                        hp_D = hp_D - 20;
                                                        break;
                                                    case 6:
                                                        Console.Clear();
                                                        Console.WriteLine("Der König isst einen Apfel.");
                                                        hp_K = hp_K + 10;
                                                        break;
                                                    case 7:
                                                        Console.Clear();
                                                        Console.WriteLine("Der König versucht den Dieb zu schlagen, doch er verfehlt und trifft sich selbst.");
                                                        hp_K = hp_K - 30;
                                                        break;
                                                }
                                                Ende_pokemon:
                                                Console.ReadLine();
                                            }
                                            if (hp_D <= 0)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Der Dieb ist gestorben.\n Game Over");
                                            }
                                            if (hp_K <= 0)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Der Dieb hat den König besiegt!");
                                                Console.ReadLine();
                                                Console.Clear();
                                                Console.Write("Er geht mit ");
                                                switch (Person)
                                                {
                                                    case "Prinzessin":
                                                        Console.Write("der Prinzessin");
                                                        break;
                                                    case "Opa":
                                                        Console.Write("seinem Opa");
                                                        break;
                                                    case "Hund":
                                                        Console.Write("seinem Hund");
                                                        break;
                                                    case "Kürbis":
                                                        Console.Write("seinem Kürbis");
                                                        break;
                                                }
                                                Console.Write(" ins Dorf zurück.");
                                                Console.ReadLine();
                                                Console.Clear();
                                                Console.WriteLine("THE END!!!");
                                            }
                                            break;
                                        case "S":
                                            //Deadend
                                            Console.WriteLine("Der Dieb schleicht sich an den König, wärend dieser am essen ist.\n Gerade als den finalen Schlag machen wollte, rutschte der Dieb auf einer Bananenschale aus.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("GAME OVER");

                                            break;
                                        case "A":
                                            Console.Clear();
                                            Console.Write("Der Dieb spricht den König an, er solle doch sein Vorhaben überdenken. Der König nimmt die Aufforderung zu herzen und lässt ihn und ");
                                            switch (Person)
                                            {
                                                case "Prinzessin":
                                                    Console.Write("die Prinzessin gehen.");
                                                    break;
                                                case "Opa":
                                                    Console.Write("seinen Opa gehen.");
                                                    break;
                                                case "Hund":
                                                    Console.Write("seinen Hund gehen.");
                                                    break;
                                                case "Kürbis":
                                                    Console.Write("seinen Kürbis gehen");
                                                    break;
                                            }
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("THE END!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                                            break;
                                        case "G":
                                            //Deadend
                                            Console.WriteLine("Der Dieb dreht sich um und geht wieder ins Dorf zurück.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("GAME OVER");
                                            break;

                                        default:
                                            Console.WriteLine("falsche Angabe!");
                                            break;
                                    }
                                    break;

                                case "Mathe":
                                    Console.WriteLine("Der Dieb findet Mathe.");
                                    Console.WriteLine("Was wirst du tun?\n");
                                    Console.WriteLine("K= Kämpfen S= Schleichen A= Ansprechen G= Gehen");
                                    Problem2 = Console.ReadLine().ToUpper();
                                    Console.Clear();
                                    switch (Problem2)
                                    {
                                        case "K":                                                           //Matheaufgaben
                                            Random rnd = new Random();
                                            int zahl_1, zahl_2;
                                            int lösung;
                                            rnd = new Random();
                                            Console.WriteLine("Der Dieb bekämpft Mathe");
                                            Console.ReadKey();
                                            Console.Clear();
                                            int hp_D = 100, hp_M = 100, aufgabe;
                                            for (int i = 100; i > 0 && hp_D > 0 && hp_M > 0; i++)
                                            {
                                                Console.WriteLine(" HP Dieb = {0}       HP Mathe = {1}", hp_D, hp_M);
                                                zahl_1 = rnd.Next(1, 1000);
                                                zahl_2 = rnd.Next(1, 1000);
                                                aufgabe = zahl_1 - zahl_2;
                                                Console.WriteLine("\n\nMathe stellt dem Dieb eine Rechenaufgabe.\n\nAufgabe: {0} - {1} = ", zahl_1, zahl_2);
                                                lösung = Convert.ToInt32(Console.ReadLine());
                                                if (lösung == aufgabe)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Richtig!");
                                                    hp_M = hp_M - 20;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Falsch! Die Lösung wäre {0}", aufgabe);
                                                    hp_D = hp_D - 50;

                                                }
                                                Console.ReadKey();
                                                Console.Clear();

                                            }

                                            if (hp_D <= 0)
                                            {
                                                Console.WriteLine("Der Dieb konnte die Matheaufgaben nicht verstehen und ist an Überanstrengung gestorben.\n Game Over");
                                            }
                                            if (hp_M <= 0)
                                            {
                                                Console.WriteLine("Der Dieb hat Mathe in seinem eigenen Spiel geschlagen! Mathe hat sich vor Entsetzen in Luft aufgelöst.");
                                                Console.ReadLine();
                                                Console.Clear();
                                                Console.Write("Der Dieb geht mit ");
                                                switch (Person)
                                                {
                                                    case "Prinzessin":
                                                        Console.Write("der Prinzessin");
                                                        break;
                                                    case "Opa":
                                                        Console.Write("seinem Opa");
                                                        break;
                                                    case "Hund":
                                                        Console.Write("seinem Hund");
                                                        break;
                                                    case "Kürbis":
                                                        Console.Write("seinem Kürbis");
                                                        break;
                                                }
                                                Console.Write(" ins Dorf zurück.");
                                                Console.ReadLine();
                                                Console.Clear();
                                                Console.WriteLine("THE END!!!");
                                            }
                                            break;

                                        case "S":
                                            //Deadend
                                            Console.WriteLine("Der Dieb schleicht sich an Mathe heran und will es erstechen,\n doch da merkt er, dass Mathe gar keine Person, sondern nur eine Idee der Menschen ist.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("Der Dieb versteht gar nichts mehr und rennt davon.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("GAME OVER");
                                            break;

                                        case "A":
                                            //Deadend
                                            Console.WriteLine("Der Dieb versucht mit Mathe zu verhandeln, doch da Mathe die menschliche Sprache nicht versteht, beschiesst es ihn mit einer Tödlichen X-Gleichung.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("GAME OVER");

                                            break;

                                        case "G":
                                            //Deadend
                                            Console.WriteLine("Der Dieb dreht um und geht ins Dorf zurück.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("GAME OVER");
                                            break;

                                        default:
                                            Console.WriteLine("Keine richtige Angabe gemacht.");
                                            break;
                                    }
                                    break;

                                case "Huhn":
                                    int streicheln = 0;
                                    Console.WriteLine("Der Dieb hat das huhnige Huhn aufgespührt.");
                                    Huhn:
                                    Console.WriteLine("Was wird er tun?\n");
                                    Console.WriteLine("K= Kämpfen S= Streicheln A= Ansprechen G= Gehen");
                                    Problem2 = Console.ReadLine().ToUpper();
                                    Console.Clear();
                                    switch (Problem2)
                                    {
                                        case "K":
                                            //Deadend
                                            Console.WriteLine("Der Dieb will das Huhn bekämpfen, doch als er sieht, wie süss das Huhn doch ist, stirbt er an einem Süssigkeitsüberschuss.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("GAME OVER");
                                            break;

                                        case "S":
                                            if (streicheln == 0)
                                            {
                                                Console.WriteLine("Der Dieb streichelt das Huhn.");
                                                streicheln = 1;
                                            }
                                            if (streicheln == 1)
                                            {
                                                Console.WriteLine("Der Dieb streichelt das Huhn wieder.");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Oops, something went wrong :(");
                                            }
                                            goto Huhn;

                                        case "A":
                                            Console.Write("Der Dieb versucht mit dem Huhn zu reden.\nDas Huhn kann ihn zwar nicht verstehen, aber es merk, dass der Dieb ");
                                            switch (Person)
                                            {
                                                case "Prinzessin":
                                                    Console.Write("die Prinzessin");
                                                    break;
                                                case "Opa":
                                                    Console.Write("seinen Opa");
                                                    break;
                                                case "Hund":
                                                    Console.Write("seinen Hund");
                                                    break;
                                                case "Kürbis":
                                                    Console.Write("seinen Kürbis");
                                                    break;
                                            }
                                            Console.Write(" retten möchte.\n Es lässt die beiden gehen.");
                                            Console.ReadKey();
                                            Console.WriteLine("Winner Winner Chicken Dinner");
                                            break;

                                        case "G":
                                            if (streicheln == 1)
                                            {
                                                Console.WriteLine("Der Dieb ist überglücklich, weil er das Huhn streicheln konnte, und geht ins Dorf zurück.");
                                                Console.ReadKey();
                                                Console.Clear();
                                                Console.WriteLine("kuscheliges GAME OVER");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Der Dieb geht ins Dorf zurück.");
                                                Console.ReadKey();
                                                Console.Clear();
                                                Console.WriteLine("GAME OVER");
                                            }

                                            break;
                                    }
                                    break;
                            }
                            break;
                        case "Krieger":
                            Console.WriteLine("Der krieger versucht zu zaubern, doch alles was passiert, ist, dass ein Grashalm 3 Meter neben ihm anfangt zu brennen. Kurz darauf wurde er von den {0} gefangen genommen.", Lakeien);
                            Console.SetCursorPosition(0, 4);
                            Console.WriteLine(grenze);
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("GAME OVER");
                            break;
                        case "Pferd":
                            Console.WriteLine("Das Pferd versucht zu zaubern und stösst ein lautes Wiehern aus. einige Sekunden später kommt eine Herde von Pferden angalopiert und trampelt die {0} nieder.", Lakeien);
                            Console.SetCursorPosition(0, 4);
                            Console.WriteLine(grenze);
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine(grenze);
                            Console.SetCursorPosition(0, 8);
                            Console.WriteLine(grenze);
                            Console.SetCursorPosition(0, 3);
                            switch (Böse)
                            {
                                case "Böser Magier":
                                    Console.WriteLine("Das Pferd findet den Magier. Was wird es tun?");
                                    Console.WriteLine("K= Kämpfen H= Herausfordern S= Sprechen X= Xylophon");
                                    Problem2 = Console.ReadLine().ToUpper();
                                    Console.Clear();
                                    switch (Problem2)
                                    {
                                        case "K":
                                            Console.WriteLine("Das Pferd Bekämpft den Magier");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("Der Magier schlägt vor, einen Würfel zu werfen.\nWer die Zahl erratet darf die Geisel mitnehmen.");
                                            Console.ReadLine();
                                            Console.WriteLine("Das Pferd willigt ein.");
                                            Console.ReadLine();


                                            //Anfang Würfelspiel
                                            int resultat = 0;
                                            for (int zähler = 100; zähler > 0 && resultat < 1; zähler++)
                                            {
                                                Console.Clear();
                                                Console.Write("Das Pferd rät: ");
                                                int zahl_Pferd = Convert.ToInt32(Console.ReadLine());   //Eingabe Würfelzahl
                                                Console.Write("Der Magier rät: ");
                                                System.Threading.Thread.Sleep(100);
                                                Random magierRand = new Random();                       //Würfelzahl des Magiers
                                                int zahl_Magier = magierRand.Next(1, 7);
                                                Console.Write(zahl_Magier);
                                                Console.ReadLine();
                                                Random rnd = new Random();                              //Zahl des Würfels
                                                int Würfel = rnd.Next(1, 7);
                                                Console.Write("Der Würfel fällt auf ");
                                                System.Threading.Thread.Sleep(100);
                                                Console.Write(Würfel);
                                                Console.ReadLine();
                                                Console.Clear();
                                                //Abfrage ob jemand die Zahl erraten hat
                                                if (Würfel == zahl_Pferd)
                                                {
                                                    resultat++;
                                                    Console.WriteLine("Das Pferd hat gewonnen!");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.Write("Es geht mit ");
                                                    switch (Person)
                                                    {
                                                        case "Prinzessin":
                                                            Console.Write("der Prinzessin");
                                                            break;
                                                        case "Opa":
                                                            Console.Write("seinem Opa");
                                                            break;
                                                        case "Hund":
                                                            Console.Write("seinem Hund");
                                                            break;
                                                        case "Kürbis":
                                                            Console.Write("seinem Kürbis");
                                                            break;
                                                    }
                                                    Console.Write(" ins Dorf zurück.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("THE END!!!");
                                                }
                                                if (Würfel == zahl_Magier)
                                                {
                                                    resultat++;
                                                    Console.WriteLine("Der Magier hat gewonnen!");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("Das Pferd wird in den Kerker gesperrt und wird nie mehr freigelassen.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("GAME OVER");
                                                }
                                                if (Würfel != zahl_Magier && Würfel != zahl_Pferd)
                                                {
                                                    Console.WriteLine("Keiner hat die Zahl erraten.");
                                                    Console.ReadLine();

                                                }
                                                if (Würfel == zahl_Pferd && Würfel == zahl_Magier)
                                                {
                                                    Console.WriteLine("Beide haben die Zahl erraten.\nEs wird weiter gewürfelt.");
                                                    Console.ReadLine();
                                                }
                                            }

                                            break;

                                        case "H":
                                            Console.WriteLine("Das Pferd fordert den Magier zu einem Podrennen heraus.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Random rand = new Random();                              //Zufälliges Ende
                                            int Podrennen = rand.Next(1, 4);
                                            switch (Podrennen)
                                            {
                                                case 1:
                                                    Console.WriteLine("Direkt am Start fällt der Motor des Pferdes aus. Trotz dem anfänglichen Missgeschick kommt es\nam Ende noch zu einem Kopf an Kopf rennen.\nMit minimalem Vorsprung gewinnt der Magier.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("GAME OVER");
                                                    break;

                                                case 2:
                                                    Console.WriteLine("Das Pferd ist schneller als der Magier. Schon in der Hälfte des Rennes ist klar, wer gewinnen wird.\nDoch das Pferd wird übermütig und will eine Rolle machen.\nDie Rolle funktioniert einwandfrei doch als es wieder auf den Boden kommt\nverliert es die Haftung und fliegt in eine Felswand.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("GAME OVER");
                                                    break;

                                                case 3:
                                                    Console.WriteLine("Das Pferd hat einen Vorsprung. Dem Magier passt das garnicht und er verwandelt ein Treibwerk des Pferdes in eine Kuh.\nDies zählt als eine Regelmissachtung und der Magier wird disqualifiziert.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("GEWONNEN");
                                                    break;
                                            }

                                            break;

                                        case "S":
                                            //Deadend
                                            Console.WriteLine("Das Pferd will mit dem Magier verhandeln,\ndoch leider versteht er kein Pferdisch.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("Der Magier jagt das Pferd aus seinem Turm.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("GAME OVER");
                                            break;

                                        case "X":
                                            Console.WriteLine("Das Pferd hat ein Xylophon gefunden und möchte dem Magier ein kleines Liedchen vorspielen.");
                                            Console.ReadLine();
                                            Console.Write("Töne: A B C D E F G\n\nErster Ton: ");       //Anfang Eingabe Töne
                                            string ton1 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nZweiter Ton: ");
                                            string ton2 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nDritter Ton: ");
                                            string ton3 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nVierter Ton: ");
                                            string ton4 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nFünfter Ton: ");
                                            string ton5 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nSechster Ton: ");
                                            string ton6 = Console.ReadLine().ToUpper();                 //Schluss Eingabe Töne
                                            Console.Clear();
                                            //Ausgabe Töne
                                            {
                                                switch (ton1)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton2)
                                                {
                                                    case "A":
                                                        Console.Beep(1500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton3)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton4)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton5)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton6)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                            }

                                            Console.WriteLine("Der Magier ist so begeistert von den Spielkünsten des Pferdes, dass er explodiert.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.Write("Das Pferd geht mit ");
                                            switch (Person)
                                            {
                                                case "Prinzessin":
                                                    Console.Write("der Prinzessin");
                                                    break;
                                                case "Opa":
                                                    Console.Write("seinem Opa");
                                                    break;
                                                case "Hund":
                                                    Console.Write("seinem Hund");
                                                    break;
                                                case "Kürbis":
                                                    Console.Write("seinem Kürbis");
                                                    break;
                                            }
                                            Console.Write(" ins Dorf zurück.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("THE END!!!");

                                            break;
                                    }
                                    break;

                                case "König":
                                    Console.WriteLine("Das Pferd findet den König. Was wird es tun?");
                                    Console.WriteLine("K= Kämpfen H= Herausfordern S= Sprechen X= Xylophon");
                                    Problem2 = Console.ReadLine().ToUpper();
                                    Console.Clear();
                                    switch (Problem2)
                                    {
                                        case "K":
                                            Console.WriteLine("Das Pferd Bekämpft den König");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("Der König schlägt vor, einen Würfel zu werfen.\nWer die Zahl erratet darf die Geisel mitnehmen.");
                                            Console.ReadLine();
                                            Console.WriteLine("Das Pferd willigt ein.");
                                            Console.ReadLine();


                                            //Anfang Würfelspiel
                                            int resultat = 0;
                                            for (int zähler = 100; zähler > 0 && resultat < 1; zähler++)
                                            {
                                                Console.Clear();
                                                Console.Write("Das Pferd rät: ");
                                                int zahl_Pferd = Convert.ToInt32(Console.ReadLine());   //Eingabe Würfelzahl
                                                Console.Write("Der König rät: ");
                                                System.Threading.Thread.Sleep(100);
                                                Random königRand = new Random();                       //Würfelzahl des Magiers
                                                int zahl_König = königRand.Next(1, 7);
                                                Console.Write(zahl_König);
                                                Console.ReadLine();
                                                Random rnd = new Random();                              //Zahl des Würfels
                                                int Würfel = rnd.Next(1, 7);
                                                Console.Write("Der Würfel fällt auf ");
                                                System.Threading.Thread.Sleep(100);
                                                Console.Write(Würfel);
                                                Console.ReadLine();
                                                Console.Clear();
                                                //Abfrage ob jemand die Zahl erraten hat
                                                if (Würfel == zahl_Pferd)
                                                {
                                                    resultat++;
                                                    Console.WriteLine("Das Pferd hat gewonnen!");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.Write("Es geht mit ");
                                                    switch (Person)
                                                    {
                                                        case "Prinzessin":
                                                            Console.Write("der Prinzessin");
                                                            break;
                                                        case "Opa":
                                                            Console.Write("seinem Opa");
                                                            break;
                                                        case "Hund":
                                                            Console.Write("seinem Hund");
                                                            break;
                                                        case "Kürbis":
                                                            Console.Write("seinem Kürbis");
                                                            break;
                                                    }
                                                    Console.Write(" ins Dorf zurück.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("THE END!!!");
                                                }
                                                if (Würfel == zahl_König)
                                                {
                                                    resultat++;
                                                    Console.WriteLine("Der König hat gewonnen!");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("Das Pferd wird in den Kerker gesperrt und wird nie mehr freigelassen.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("GAME OVER");
                                                }
                                                if (Würfel != zahl_König && Würfel != zahl_Pferd)
                                                {
                                                    Console.WriteLine("Keiner hat die Zahl erraten.");
                                                    Console.ReadLine();

                                                }
                                                if (Würfel == zahl_Pferd && Würfel == zahl_König)
                                                {
                                                    Console.WriteLine("Beide haben die Zahl erraten.\nEs wird weiter gewürfelt.");
                                                    Console.ReadLine();
                                                }
                                            }

                                            break;

                                        case "H":
                                            Console.WriteLine("Das Pferd fordert den König zu einem Podrennen heraus.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Random rand = new Random();                              //Zufälliges Ende
                                            int Podrennen = rand.Next(1, 4);
                                            switch (Podrennen)
                                            {
                                                case 1:
                                                    Console.WriteLine("Direkt am Start fällt der Motor des Pferdes aus. Trotz dem anfänglichen Missgeschick kommt es\nam Ende noch zu einem Kopf an Kopf rennen.\nMit minimalem Vorsprung gewinnt der König.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("GAME OVER");
                                                    break;

                                                case 2:
                                                    Console.WriteLine("Das Pferd ist schneller als der König. Schon in der Hälfte des Rennes ist klar, wer gewinnen wird.\nDoch das Pferd wird übermütig und will eine Rolle machen.\nDie Rolle funktioniert einwandfrei doch als es wieder auf den Boden kommt\nverliert es die Haftung und fliegt in eine Felswand.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("GAME OVER");
                                                    break;

                                                case 3:
                                                    Console.WriteLine("Das Pferd hat einen Vorsprung. Dem König passt das garnicht und er schickt seine Lakeien, um den Podrenner des Pferds auseinanderzunehmen.\nDies zählt als eine Regelmissachtung und der König wird disqualifiziert.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("GEWONNEN");
                                                    break;
                                            }

                                            break;

                                        case "S":
                                            //Deadend
                                            Console.WriteLine("Das Pferd will mit dem König verhandeln,\ndoch leider versteht er kein Pferdisch.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("Der König jagt das Pferd aus seinem Turm.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("GAME OVER");
                                            break;

                                        case "X":
                                            Console.WriteLine("Das Pferd hat ein Xylophon gefunden und möchte dem König ein kleines Liedchen vorspielen.");
                                            Console.ReadLine();
                                            Console.Write("Töne: A B C D E F G\n\nErster Ton: ");       //Anfang Eingabe Töne
                                            string ton1 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nZweiter Ton: ");
                                            string ton2 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nDritter Ton: ");
                                            string ton3 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nVierter Ton: ");
                                            string ton4 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nFünfter Ton: ");
                                            string ton5 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nSechster Ton: ");
                                            string ton6 = Console.ReadLine().ToUpper();                 //Schluss Eingabe Töne
                                            Console.Clear();
                                            //Ausgabe Töne
                                            {
                                                switch (ton1)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton2)
                                                {
                                                    case "A":
                                                        Console.Beep(1500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton3)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton4)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton5)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton6)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                            }

                                            Console.WriteLine("Der König ist so begeistert von den Spielkünsten des Pferdes, dass er explodiert.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.Write("Das Pferd geht mit ");
                                            switch (Person)
                                            {
                                                case "Prinzessin":
                                                    Console.Write("der Prinzessin");
                                                    break;
                                                case "Opa":
                                                    Console.Write("seinem Opa");
                                                    break;
                                                case "Hund":
                                                    Console.Write("seinem Hund");
                                                    break;
                                                case "Kürbis":
                                                    Console.Write("seinem Kürbis");
                                                    break;
                                            }
                                            Console.Write(" ins Dorf zurück.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("THE END!!!");

                                            break;
                                    }
                                    break;

                                case "Mathe":
                                    Console.WriteLine("Das Pferd findet Mathe Was wird es tun?");
                                    Console.WriteLine("K= Kämpfen H= Herausfordern S= Sprechen X= Xylophon");
                                    Problem2 = Console.ReadLine().ToUpper();
                                    Console.Clear();
                                    switch (Problem2)
                                    {
                                        case "K":
                                            Console.WriteLine("Das Pferd will Mathe bekämpfen. Doch wie bekämpft man etwas,\ndas keinen Körper hat und eigentlich nur eine Vorstellung der Menschen ist?");
                                            Console.ReadLine();
                                            Console.WriteLine("Das Pferd denkt zu viel über diese Frage nach und wird von einer hinterhältigen Quadratwurzel von Mathe direkt getroffen.");
                                            Console.ReadLine();
                                            Console.WriteLine("Das Pferd ist gestorben.");
                                            Console.ReadLine();
                                            Console.WriteLine("GAME OVER");
                                            break;

                                        case "H":
                                            Random rnd = new Random();
                                            int zahl_1, zahl_2;
                                            int lösung;
                                            rnd = new Random();
                                            Console.WriteLine("Mathe fordert das Pferd zu einer Runde Rechnen auf.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            int hp_P = 100, hp_M = 100, aufgabe;
                                            for (int i = 100; i > 0 && hp_P > 0 && hp_M > 0; i++)
                                            {
                                                Console.WriteLine(" HP Pferd = {0}       HP Mathe = {1}", hp_P, hp_M);
                                                zahl_1 = rnd.Next(1, 1000);
                                                zahl_2 = rnd.Next(1, 1000);
                                                aufgabe = zahl_1 - zahl_2;
                                                Console.WriteLine("\n\nMathe stellt dem Pferd eine Rechenaufgabe.\n\nAufgabe: {0} - {1} = ", zahl_1, zahl_2);
                                                lösung = Convert.ToInt32(Console.ReadLine());
                                                if (lösung == aufgabe)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Richtig!");
                                                    hp_M = hp_M - 20;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Falsch! Die Lösung wäre {0}", aufgabe);
                                                    hp_P = hp_P - 50;

                                                }
                                                Console.ReadKey();
                                                Console.Clear();

                                            }

                                            if (hp_P <= 0)
                                            {
                                                Console.WriteLine("Das Pferd konnte die Matheaufgaben nicht verstehen und ist an Überanstrengung gestorben.\n Game Over");
                                            }
                                            if (hp_M <= 0)
                                            {
                                                Console.WriteLine("Das Pferd hat Mathe in seinem eigenen Spiel geschlagen! Mathe hat sich vor Entsetzen in Luft aufgelöst.");
                                                Console.ReadLine();
                                                Console.Clear();
                                                Console.Write("Das Pferd geht mit ");
                                                switch (Person)
                                                {
                                                    case "Prinzessin":
                                                        Console.Write("der Prinzessin");
                                                        break;
                                                    case "Opa":
                                                        Console.Write("seinem Opa");
                                                        break;
                                                    case "Hund":
                                                        Console.Write("seinem Hund");
                                                        break;
                                                    case "Kürbis":
                                                        Console.Write("seinem Kürbis");
                                                        break;
                                                }
                                                Console.Write(" ins Dorf zurück.");
                                                Console.ReadLine();
                                                Console.Clear();
                                                Console.WriteLine("THE END!!!");
                                            }
                                            break;

                                        case "S":
                                            //Deadend
                                            Console.WriteLine("Das Pferd will mit Mathe verhandeln,\ndoch leider versteht es kein Pferdisch.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("Mathe jagt das Pferd aus seinem Turm.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("GAME OVER");
                                            break;

                                        case "X":
                                            Console.WriteLine("Das Pferd hat ein Xylophon gefunden und möchte Mathe ein kleines Liedchen vorspielen.");
                                            Console.ReadLine();
                                            Console.Write("Töne: A B C D E F G\n\nErster Ton: ");       //Anfang Eingabe Töne
                                            string ton1 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nZweiter Ton: ");
                                            string ton2 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nDritter Ton: ");
                                            string ton3 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nVierter Ton: ");
                                            string ton4 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nFünfter Ton: ");
                                            string ton5 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nSechster Ton: ");
                                            string ton6 = Console.ReadLine().ToUpper();                 //Schluss Eingabe Töne
                                            Console.Clear();
                                            //Ausgabe Töne
                                            {
                                                switch (ton1)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton2)
                                                {
                                                    case "A":
                                                        Console.Beep(1500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton3)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton4)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton5)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton6)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                            }

                                            Console.WriteLine("Mathe ist so begeistert von den Spielkünsten des Pferdes, dass es explodiert.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.Write("Das Pferd geht mit ");
                                            switch (Person)
                                            {
                                                case "Prinzessin":
                                                    Console.Write("der Prinzessin");
                                                    break;
                                                case "Opa":
                                                    Console.Write("seinem Opa");
                                                    break;
                                                case "Hund":
                                                    Console.Write("seinem Hund");
                                                    break;
                                                case "Kürbis":
                                                    Console.Write("seinem Kürbis");
                                                    break;
                                            }
                                            Console.Write(" ins Dorf zurück.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("THE END!!!");

                                            break;
                                    }

                                    break;

                                case "Huhn":
                                    Console.WriteLine("Das Pferd findet das Huhn. Was wird es tun?");
                                    Console.WriteLine("K= Kämpfen H= Herausfordern S= Sprechen X= Xylophon");
                                    Problem2 = Console.ReadLine().ToUpper();
                                    Console.Clear();
                                    switch (Problem2)
                                    {
                                        case "K":
                                            Console.WriteLine("Das Pferd Bekämpft das Huhn");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("Das Huhn schlägt vor, einen Würfel zu werfen.\nWer die Zahl erratet darf die Geisel mitnehmen.");
                                            Console.ReadLine();
                                            Console.WriteLine("Das Pferd willigt ein.");
                                            Console.ReadLine();


                                            //Anfang Würfelspiel
                                            int resultat = 0;
                                            for (int zähler = 100; zähler > 0 && resultat < 1; zähler++)
                                            {
                                                Console.Clear();
                                                Console.Write("Das Pferd rät: ");
                                                int zahl_Pferd = Convert.ToInt32(Console.ReadLine());   //Eingabe Würfelzahl
                                                Console.Write("Das Huhn rät: ");
                                                System.Threading.Thread.Sleep(100);
                                                Random huhnRand = new Random();                       //Würfelzahl Huhn
                                                int zahl_Huhn = huhnRand.Next(1, 7);
                                                Console.Write(zahl_Huhn);
                                                Console.ReadLine();
                                                Random rnd = new Random();                              //Zahl des Würfels
                                                int Würfel = rnd.Next(1, 7);
                                                Console.Write("Der Würfel fällt auf ");
                                                System.Threading.Thread.Sleep(100);
                                                Console.Write(Würfel);
                                                Console.ReadLine();
                                                Console.Clear();
                                                //Abfrage ob jemand die Zahl erraten hat
                                                if (Würfel == zahl_Pferd)
                                                {
                                                    resultat++;
                                                    Console.WriteLine("Das Pferd hat gewonnen!");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.Write("Es geht mit ");
                                                    switch (Person)
                                                    {
                                                        case "Prinzessin":
                                                            Console.Write("der Prinzessin");
                                                            break;
                                                        case "Opa":
                                                            Console.Write("seinem Opa");
                                                            break;
                                                        case "Hund":
                                                            Console.Write("seinem Hund");
                                                            break;
                                                        case "Kürbis":
                                                            Console.Write("seinem Kürbis");
                                                            break;
                                                    }
                                                    Console.Write(" ins Dorf zurück.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("THE END!!!");
                                                }
                                                if (Würfel == zahl_Huhn)
                                                {
                                                    resultat++;
                                                    Console.WriteLine("Das Huhn hat gewonnen!");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("Das Pferd wird in den Kerker gesperrt und wird nie mehr freigelassen.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("GAME OVER");
                                                }
                                                if (Würfel != zahl_Huhn && Würfel != zahl_Pferd)
                                                {
                                                    Console.WriteLine("Keiner hat die Zahl erraten.");
                                                    Console.ReadLine();

                                                }
                                                if (Würfel == zahl_Pferd && Würfel == zahl_Huhn)
                                                {
                                                    Console.WriteLine("Beide haben die Zahl erraten.\nEs wird weiter gewürfelt.");
                                                    Console.ReadLine();
                                                }
                                            }

                                            break;

                                        case "H":
                                            Console.WriteLine("Das Pferd fordert das Huhn zu einem Podrennen heraus.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Random rand = new Random();                              //Zufälliges Ende
                                            int Podrennen = rand.Next(1, 4);
                                            switch (Podrennen)
                                            {
                                                case 1:
                                                    Console.WriteLine("Direkt am Start fällt der Motor des Pferdes aus. Trotz dem anfänglichen Missgeschick kommt es\nam Ende noch zu einem Kopf an Kopf rennen.\nMit minimalem Vorsprung gewinnt das Huhn.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("GAME OVER");
                                                    break;

                                                case 2:
                                                    Console.WriteLine("Das Pferd ist schneller als das Huhn. Schon in der Hälfte des Rennes ist klar, wer gewinnen wird.\nDoch das Pferd wird übermütig und will eine Rolle machen.\nDie Rolle funktioniert einwandfrei doch als es wieder auf den Boden kommt\nverliert es die Haftung und fliegt in eine Felswand.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("GAME OVER");
                                                    break;

                                                case 3:
                                                    Console.WriteLine("Das Pferd hat einen Vorsprung. Dem Huhn passt das garnicht und es bewirft das Pferd mit Eiern.\nDies zählt als eine Regelmissachtung und das Huhn wird disqualifiziert.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("GEWONNEN");
                                                    break;
                                            }

                                            break;

                                        case "S":
                                            Console.WriteLine("Das Pferd will mit dem Huhn verhandeln.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("Das Huhn willigt ein, die Geisel freizulassen und bekommt dafür eine Schnabelfeile.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.Write("Das Pferd geht mit ");
                                            switch (Person)
                                            {
                                                case "Prinzessin":
                                                    Console.Write("der Prinzessin");
                                                    break;
                                                case "Opa":
                                                    Console.Write("seinem Opa");
                                                    break;
                                                case "Hund":
                                                    Console.Write("seinem Hund");
                                                    break;
                                                case "Kürbis":
                                                    Console.Write("seinem Kürbis");
                                                    break;
                                            }
                                            Console.Write(" ins Dorf zurück.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("THE END!!!");

                                            break;

                                        case "X":
                                            Console.WriteLine("Das Pferd hat ein Xylophon gefunden und möchte dem Huhn ein kleines Liedchen vorspielen.");
                                            Console.ReadLine();
                                            Console.Write("Töne: A B C D E F G\n\nErster Ton: ");       //Anfang Eingabe Töne
                                            string ton1 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nZweiter Ton: ");
                                            string ton2 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nDritter Ton: ");
                                            string ton3 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nVierter Ton: ");
                                            string ton4 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nFünfter Ton: ");
                                            string ton5 = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            Console.Write("Töne: A B C D E F G\n\nSechster Ton: ");
                                            string ton6 = Console.ReadLine().ToUpper();                 //Schluss Eingabe Töne
                                            Console.Clear();
                                            //Ausgabe Töne
                                            {
                                                switch (ton1)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton2)
                                                {
                                                    case "A":
                                                        Console.Beep(1500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton3)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton4)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton5)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                                switch (ton6)
                                                {
                                                    case "A":
                                                        Console.Beep(1000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "B":
                                                        Console.Beep(1500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "C":
                                                        Console.Beep(2000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "D":
                                                        Console.Beep(2500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "E":
                                                        Console.Beep(3000, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "F":
                                                        Console.Beep(3500, 900);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                    case "G":
                                                        Console.Beep(4000, 300);
                                                        System.Threading.Thread.Sleep(100);
                                                        break;
                                                }
                                            }

                                            Console.WriteLine("Das Huhn ist so begeistert von den Spielkünsten des Pferdes, dass es explodiert.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.Write("Das Pferd geht mit ");
                                            switch (Person)
                                            {
                                                case "Prinzessin":
                                                    Console.Write("der Prinzessin");
                                                    break;
                                                case "Opa":
                                                    Console.Write("seinem Opa");
                                                    break;
                                                case "Hund":
                                                    Console.Write("seinem Hund");
                                                    break;
                                                case "Kürbis":
                                                    Console.Write("seinem Kürbis");
                                                    break;
                                            }
                                            Console.Write(" ins Dorf zurück.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("THE END!!!");

                                            break;
                                    }

                                    break;
                            }


                            break;
                    }
                    break;
                case "B":
                    Console.Clear();
                    Console.WriteLine(grenze);
                    switch (Hauptcharakter)
                    {
                        case "Magier":
                            Console.WriteLine("Der Magier versucht, die {0} zu beschwichtigen, doch bevor er etwas sagen kann. wird er von ihnen gefangen genommen.", Lakeien);
                            Console.SetCursorPosition(0, 4);
                            Console.WriteLine(grenze);
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("GAME OVER");
                            break;
                        case "Dieb":
                            Console.WriteLine("Der Dieb versucht die {0} zu beschwichtigen indem er ihnen anbietet, den Schatz des Bösewichten mit den {0} zu teilen.", Lakeien);
                            switch (Böse)
                            {
                                case "König": //König
                                    Console.WriteLine("\"Zwar finden wir es nicht richtig den König zu hintergehen, aber er hat einen Riesen Schatz und bezahlt uns schlecht. Wir nehmen deinen Deal an.\"");
                                    Console.SetCursorPosition(0, 4);
                                    Console.WriteLine(grenze);
                                    Console.ReadLine();
                                    Console.Clear();
                                    Console.WriteLine(grenze);
                                    switch (Person)
                                    {
                                        case "Prinzessin":
                                            Console.WriteLine("Der Dieb geht zusammen mit den {0} in den Turm des Königs. Die {0} nehmen den König gefangen.\nZusammen mit der Prinzessin geht der Dieb zurück in sein Dorf.", Lakeien);
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("THE END!!!!!");
                                            break;

                                        case "Opa":
                                            Console.WriteLine("Der Dieb geht zusammen mit den {0} in den Turm des Königs. Die {0} nehmen den König gefangen.\nZusammen mit dem Opa geht der Dieb zurück in sein Dorf.", Lakeien);
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("THE END!!!!!");


                                            break;


                                        case "Hund":
                                            Console.WriteLine("Der Dieb geht zusammen mit den {0} in den Turm des Königs. Die {0} nehmen den König gefangen.\nZusammen mit seinem Hund geht der Dieb zurück in sein Dorf. ", Lakeien);
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("THE END!!!!!\n\n\n\nPet your pets!!");

                                            break;

                                        case "Kürbis":
                                            Console.WriteLine("Der Dieb geht zusammen mit den {0} in den Turm des Königs. Die {0} nehmen den König gefangen.\nZusammen mit seinem Kürbis geht der Dieb zurück in sein Dorf ", Lakeien);
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("THE END!!!!!\n\n\n\nKerniges Ende \"Badum Zzzz\"");

                                            break;
                                    }
                                    Console.SetCursorPosition(0, 8);
                                    Console.WriteLine(grenze);
                                    Console.SetCursorPosition(0, 3);
                                    break;
                                case "Böser Magier": //böser Magier
                                    Console.WriteLine("\"Der böse Magier hat keinen Schatz und wir haben zu fiel Angst vor ihm um ihn zu hintergehen\", sagten die {0} und nahmen dich fest.", Lakeien);
                                    Console.SetCursorPosition(0, 4);
                                    Console.WriteLine(grenze);
                                    Console.ReadLine();
                                    Console.Clear();
                                    Console.WriteLine("GAME OVER");
                                    break;
                                case "Mathe": //Mathe
                                    Console.WriteLine("\"Mathematik ist alles was wir wollen. Wir sind schon überglücklich, der Mathematik dienen zu können.\", sagten die {0} und nahme dich fest.", Lakeien);
                                    Console.SetCursorPosition(0, 4);
                                    Console.WriteLine(grenze);
                                    Console.ReadLine();
                                    Console.Clear();
                                    Console.WriteLine("GAME OVER");
                                    break;
                                case "Huhn": //Huhn
                                    Console.WriteLine("\"Wir werden das Huhn nie hintergehen! Es tat schon so viel für uns! Für manche von uns hat es sogar Familien und Dörfer gerettet.\" sagten die {0} voller stolz und nahmen dich fest.", Lakeien);
                                    Console.SetCursorPosition(0, 4);
                                    Console.WriteLine(grenze);
                                    Console.ReadLine();
                                    Console.Clear();
                                    Console.WriteLine("GAME OVER");
                                    break;
                            }
                            break;
                        case "Krieger":
                            Console.WriteLine("Der Krieger setzte sich mit den {0} auf den Boden und erzählte ihnen von seiner traurigen vorgeschichte, und wie viel ihm die Geisel des Bösewichten bedeutet. Aufgelöst in Tränen liessen die {0} den Krieger durch.", Lakeien);
                            Console.SetCursorPosition(0, 4);
                            Console.WriteLine(grenze);
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine(grenze);
                            Console.SetCursorPosition(0, 8);
                            Console.WriteLine(grenze);
                            Console.SetCursorPosition(0, 3);
                            switch (Böse)
                            {
                                case "Böser Magier":
                                    Console.WriteLine("Der Krieger findet den böser Magier im Turm. Was wird er tun?");
                                    Console.WriteLine("K= Kämpfen L= Lesen S= Stürmen A= Ansprechen");
                                    Problem2 = Console.ReadLine().ToUpper();
                                    Console.Clear();
                                    switch (Problem2)
                                    {
                                        case "K":
                                            int hp_K = 100, hp_M = 100, chanceAxt, blocken = 0, einschüchtern = 0, angriff_M, superAttacke = 0;
                                            string angriff_K;
                                            Random rnd = new Random();
                                            Console.WriteLine("Der Krieger bekämpft den Magier.");
                                            Console.ReadKey();
                                            for (int i = 100; i > 0 && hp_K > 0 && hp_M > 0; i--)                                       //Pokemon fight
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Wie soll der Krieger angreifen\nAxtwurf = A     Sturmangriff = S     Kaffepause = K     Blocken = B     Einschüchtern = E");
                                                angriff_K = Console.ReadLine();
                                                Console.Clear();
                                                switch (angriff_K)                                                   //Angriff Krieger
                                                {
                                                    case "A":
                                                        Console.WriteLine("Der Krieger wirft eine Axt.");
                                                        Console.ReadKey();
                                                        chanceAxt = rnd.Next(1, 4);
                                                        Console.Clear();
                                                        if (chanceAxt == 1)
                                                        {
                                                            Console.WriteLine("Die Axt hat den Magier getroffen.");
                                                            hp_M = hp_M - 40;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Die Axt hat ihr Ziel verfehlt");
                                                        }
                                                        break;

                                                    case "S":
                                                        Console.WriteLine("Der Krieger stürmt auf den Magier zu und rammt ihn um.");
                                                        hp_M = hp_M - 20;

                                                        break;

                                                    case "K":
                                                        Console.WriteLine("Der Krieger macht eine Kaffepause.");
                                                        hp_K = hp_K + 20;

                                                        break;

                                                    case "B":
                                                        Console.WriteLine("Der Krieger nimmt den Schild zu Hand und ist bereit, den nächsten Angriff zu blocken.");
                                                        blocken = 1;

                                                        break;

                                                    case "E":
                                                        if (einschüchtern == 2)
                                                        {
                                                            Console.WriteLine("Dem Krieger fällt nichts neues ein.");
                                                        }
                                                        if (einschüchtern == 1)
                                                        {
                                                            Console.WriteLine("Der Krieger sagt nochmals das gleiche.\nNun wird der Magier wütend.\nAngriff des Magiers steigt.");
                                                            einschüchtern = 2;
                                                        }
                                                        if (einschüchtern == 0)
                                                        {
                                                            Console.WriteLine("Der Krieger sagt, das der Magier nie genug gut sein werde, um an die Magieruni zu kommen.\nDer Magier wird Traurig.\nAngriff des Magiers sinkt.");
                                                            einschüchtern = 1;
                                                        }
                                                        break;

                                                    default:
                                                        Console.WriteLine("Du hast dem Krieger keine Anweisungen gegeben. Er greift diese Runde nicht an.");
                                                        break;

                                                }
                                                Console.ReadKey();
                                                Console.Clear();
                                                if (blocken == 1)                                                //Angriff wird geblockt
                                                {
                                                    Console.WriteLine("Der Krieger blockt den Angriff.");
                                                    blocken = 0;
                                                    superAttacke = 1;
                                                    goto EndePokemon;
                                                }

                                                if (superAttacke == 1)                                          //Magier hat Superattacke fertig aufgeladen
                                                {
                                                    Console.WriteLine("Der Magier hat seinen Angriff fertig aufgeladen und schiesst einen Laser auf den Krieger.");
                                                    if (einschüchtern == 0)
                                                    {
                                                        hp_K = hp_K - 50;
                                                    }
                                                    if (einschüchtern == 1)
                                                    {
                                                        hp_K = hp_K - 25;
                                                    }
                                                    if (einschüchtern == 2)
                                                    {
                                                        hp_K = hp_K - 60;
                                                    }
                                                    goto EndePokemon;
                                                }
                                                angriff_M = rnd.Next(1, 6);
                                                switch (angriff_M)
                                                {
                                                    case 1:
                                                        Console.WriteLine("Der Magier lädt seinen Angriff auf.");
                                                        superAttacke = 1;
                                                        break;

                                                    case 2:
                                                        Console.Clear();
                                                        Console.WriteLine("Der Magier lässt es Steine regnen.");
                                                        hp_K = hp_K - 40;
                                                        break;
                                                    case 3:
                                                        Console.Clear();
                                                        Console.WriteLine("Der Magier zaubert einen Wirbelsturm herbei.");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Der Krieger fällt um.");
                                                        hp_K = hp_K - 5;
                                                        break;
                                                    case 4:
                                                        Console.Clear();
                                                        Console.WriteLine("Der Magier fliegt dumm rum. Nicht sehr effektiv");
                                                        break;
                                                    case 5:
                                                        Console.Clear();
                                                        Console.WriteLine("Der Magier schiesst einen Feuerball.");
                                                        hp_K = hp_K - 20;
                                                        break;
                                                    case 6:
                                                        Console.Clear();
                                                        Console.WriteLine("Der Magier trinkt einen Heiltrank.");
                                                        hp_M = hp_M + 10;
                                                        break;

                                                }
                                                EndePokemon:
                                                Console.ReadKey();

                                            }
                                            if (hp_K < 0)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Der Krieger ist gestorben.");
                                                Console.ReadKey();
                                                Console.Clear();
                                                Console.WriteLine("GAME OVER");
                                            }
                                            if (hp_M > 0)
                                            {
                                                Console.Clear();
                                                Console.Write("Der Krieger hat den Magier besiegt. Er geht mit");
                                                switch (Person)
                                                {
                                                    case "Prinzessin":
                                                        Console.Write("der Prinzessin");
                                                        break;
                                                    case "Opa":
                                                        Console.Write("seinem Opa");
                                                        break;
                                                    case "Hund":
                                                        Console.Write("seinem Hund");
                                                        break;
                                                    case "Kürbis":
                                                        Console.Write("seinem Kürbis");
                                                        break;
                                                }
                                                Console.Write(" ins Dorf zurück.");
                                                Console.ReadLine();
                                                Console.Clear();
                                                Console.WriteLine("THE END!!!");
                                            }

                                            break;

                                        case "L":
                                            Console.WriteLine("Der Krieger hat ein Buch mit Zaubersprüchen gefunden.\nEr probiert einen Zauberspruch aus.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Random rand = new Random();
                                            int chance = rand.Next(1, 5);
                                            if (chance == 1 || chance == 2)
                                            {
                                                Console.WriteLine("Der Krieger explodiert.");
                                                Console.ReadKey();
                                                Console.Clear();
                                                Console.WriteLine("GAME OVER");
                                            }
                                            if (chance == 3)
                                            {
                                                Console.WriteLine("Der Krieger und der Magier werden von einem Schwarzen Loch eingesaugt.");
                                                Console.ReadKey();
                                                Console.Clear();
                                                Console.WriteLine("GAME OVER?");
                                            }
                                            if (chance == 4)
                                            {
                                                Console.Write("Der Krieger verwandelt den Magier in eine Sonnenblume.\nEr geht mit");
                                                switch (Person)
                                                {
                                                    case "Prinzessin":
                                                        Console.Write("der Prinzessin");
                                                        break;
                                                    case "Opa":
                                                        Console.Write("seinem Opa");
                                                        break;
                                                    case "Hund":
                                                        Console.Write("seinem Hund");
                                                        break;
                                                    case "Kürbis":
                                                        Console.Write("seinem Kürbis");
                                                        break;
                                                }
                                                Console.Write(" ins Dorf zurück.");
                                                Console.ReadLine();
                                                Console.Clear();
                                                Console.WriteLine("THE END!!!");
                                            }
                                            else
                                            {
                                                Console.WriteLine("How did you even get here???");
                                            }

                                            break;

                                        case "S":
                                            Random rando = new Random();
                                            chance = rando.Next(1, 3);
                                            if (chance == 1)
                                            {
                                                Console.WriteLine("Der Krieger stosst den Magier vom Turm.");
                                                Console.ReadKey();
                                                Console.Clear();
                                                Console.Write("Der Krieger geht mit");
                                                switch (Person)
                                                {
                                                    case "Prinzessin":
                                                        Console.Write("der Prinzessin");
                                                        break;
                                                    case "Opa":
                                                        Console.Write("seinem Opa");
                                                        break;
                                                    case "Hund":
                                                        Console.Write("seinem Hund");
                                                        break;
                                                    case "Kürbis":
                                                        Console.Write("seinem Kürbis");
                                                        break;
                                                }
                                                Console.Write(" ins Dorf zurück.");
                                                Console.ReadLine();
                                                Console.Clear();
                                                Console.WriteLine("THE END!!!");
                                            }
                                            break;

                                        case "A":
                                            //Deadend
                                            Console.WriteLine("Der Krieger spricht den bösen Magier an. Er kämpft mit Worten.\nDoch leider hat der Magier keine Moral und wirft dem Krieger ein Buch an den Kopf.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("GAME OVER");

                                            break;
                                    }
                                    break;

                                case "König":
                                    AnfangKönig:
                                    Console.WriteLine("Der Krieger findet den König im Turm. Was wird er tun?");
                                    Console.WriteLine("K= Kämpfen L= Lesen S= Stürmen A= Ansprechen");
                                    Problem2 = Console.ReadLine().ToUpper();
                                    Console.Clear();
                                    switch (Problem2)
                                    {
                                        case "K":
                                            //Deadend
                                            Console.WriteLine("Der Krieger will den König bekämpfen, doch ihm wird Geld versprochen, wenn er den König nicht bekämpft.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("Der Krieger geht nach hause.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("GAME OVER\nDu hast dich bestechen lassen!");
                                            break;

                                        case "L":
                                            //Deadend
                                            Console.WriteLine("Der Krieger liesst ein Buch.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("GAME OVER\n(lesen tötet)");
                                            break;

                                        case "S":
                                            Console.WriteLine("Der Krieger stürmt auf den König zu und wirft ihn aus einem Turmfenster.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("The End!!!");
                                            break;

                                        case "A":
                                            Console.WriteLine("Der Krieger will den König ansprechen.\nWas soll er sagen?\nVerhandeln = V     Drohen = D     Beleidigen = B     Weinen = W     Kekse = K");
                                            Problem2 = Console.ReadLine();
                                            switch (Problem2)
                                            {
                                                case "V":
                                                    Console.WriteLine("Der Krieger bietet dem König fünf Wildschweine.\n Der König nimmt das angebot an.\"Genau die habe ich gebraucht für mein Wildschweinragu!\"");
                                                    Console.Write("Der Krieger geht mit");
                                                    switch (Person)
                                                    {
                                                        case "Prinzessin":
                                                            Console.Write("der Prinzessin");
                                                            break;
                                                        case "Opa":
                                                            Console.Write("seinem Opa");
                                                            break;
                                                        case "Hund":
                                                            Console.Write("seinem Hund");
                                                            break;
                                                        case "Kürbis":
                                                            Console.Write("seinem Kürbis");
                                                            break;
                                                    }
                                                    Console.Write(" ins Dorf zurück.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("THE END!!!");
                                                    break;

                                                case "D":
                                                    Console.Write("Der Krieger droht dem König:\"Wenn du ");
                                                    switch (Person)
                                                    {
                                                        case "Prinzessin":
                                                            Console.Write("die Prinzessin");
                                                            break;
                                                        case "Opa":
                                                            Console.Write("meinen Opa");
                                                            break;
                                                        case "Hund":
                                                            Console.Write("meinen Hund");
                                                            break;
                                                        case "Kürbis":
                                                            Console.Write("meinen Kürbis");
                                                            break;
                                                    }
                                                    Console.Write(" nicht freilässt, dann werde ich so richtig ungemütlich.\"");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    Console.WriteLine("Der König war nicht sehr eingeschüchtert.\nWie der Krieger gesagt hat, wurde er ungemütlich.\nBesser gesagt ihm wurde ungemütlich.");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    Console.WriteLine("Dem Krieger wurde es so ungemütlich, dass er wieder zurück in das Dorf ging.");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    Console.WriteLine("GAME OVER");
                                                    break;

                                                case "B":
                                                    //Deadend
                                                    Console.WriteLine("Der Krieger beleidigt den König.");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    Console.WriteLine("Es hat nichts genützt.");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    Console.WriteLine("GAME OVER");
                                                    break;

                                                case "W":
                                                    Console.WriteLine("Der Krieger fängt an zu weinen.");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    Console.Write("Aus Mitleid lässt der König");
                                                    switch (Person)
                                                    {
                                                        case "Prinzessin":
                                                            Console.Write("die Prinzessin");
                                                            break;
                                                        case "Opa":
                                                            Console.Write("seinen Opa");
                                                            break;
                                                        case "Hund":
                                                            Console.Write("seinen Hund");
                                                            break;
                                                        case "Kürbis":
                                                            Console.Write("seinen Kürbis");
                                                            break;
                                                    }
                                                    Console.Write(" frei.");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    Console.WriteLine("The End");
                                                    break;

                                                case "K":
                                                    int Keks = 0;
                                                    if (Keks == 5)
                                                    {
                                                        Console.WriteLine("Der Krieger gibt dem König einen Keks.\nDer König isst den Keks.\nDer König ist nun so voll, dass er explodiert.");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        Console.Write("Der Krieger geht mit");
                                                        switch (Person)
                                                        {
                                                            case "Prinzessin":
                                                                Console.Write("der Prinzessin");
                                                                break;
                                                            case "Opa":
                                                                Console.Write("seinem Opa");
                                                                break;
                                                            case "Hund":
                                                                Console.Write("seinem Hund");
                                                                break;
                                                            case "Kürbis":
                                                                Console.Write("seinem Kürbis");
                                                                break;
                                                        }
                                                        Console.Write(" ins Dorf zurück.");
                                                        Console.ReadLine();
                                                        Console.Clear();
                                                        Console.WriteLine("THE END!!!");

                                                    }
                                                    if (Keks < 5)
                                                    {
                                                        Console.WriteLine("Der Krieger gibt dem König einen Keks.\nDer König nimmt den Keks dankend an und isst ihn.");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        Keks++;
                                                        goto AnfangKönig;
                                                    }

                                                    break;
                                            }

                                            break;

                                        default:
                                            Console.WriteLine("Keine richtige Angabe");
                                            break;
                                    }
                                    break;

                                case "Mathe":
                                    Console.WriteLine("Der Krieger hat Mathe gefunden. Mathe fordert ihn zu einem Kopfrechnungs-Wettkampf heraus.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    //Anfang Matheaufgaben 
                                    {
                                        Random Rnd = new Random();
                                        int zahl_1, zahl_2;
                                        int lösung;
                                        Rnd = new Random();
                                        Console.WriteLine("Der Krieger bekämpft Mathe");
                                        Console.ReadKey();
                                        Console.Clear();
                                        int Hp_K = 100, Hp_M = 100, aufgabe;
                                        for (int i = 100; i > 0 && Hp_K > 0 && Hp_M > 0; i++)
                                        {
                                            Console.WriteLine(" HP Krieger = {0}       HP Mathe = {1}", Hp_K, Hp_M);
                                            zahl_1 = Rnd.Next(1, 1000);
                                            zahl_2 = Rnd.Next(1, 1000);
                                            aufgabe = zahl_1 * zahl_2;
                                            Console.Write("\n\nMathe stellt dem Krieger eine Rechenaufgabe.\n\nAufgabe: {0} - {1} = ", zahl_1, zahl_2);
                                            lösung = Convert.ToInt32(Console.ReadLine());
                                            if (lösung == aufgabe)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Richtig!");
                                                Hp_M = Hp_M - 20;
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Falsch! Die Lösung wäre {0}", aufgabe);
                                                Hp_K = Hp_K - 50;

                                            }
                                            Console.ReadKey();
                                            Console.Clear();

                                        }

                                        if (Hp_K <= 0)
                                        {
                                            Console.WriteLine("Der Krieger konnte die Matheaufgaben nicht verstehen und ist an Überanstrengung gestorben.\n Game Over");
                                        }
                                        if (Hp_M <= 0)
                                        {
                                            Console.WriteLine("Der Krieger hat Mathe in seinem eigenen Spiel geschlagen! Mathe hat sich vor Entsetzen in Luft aufgelöst.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.Write("Der Krieger geht mit ");
                                            switch (Person)
                                            {
                                                case "Prinzessin":
                                                    Console.Write("der Prinzessin");
                                                    break;
                                                case "Opa":
                                                    Console.Write("seinem Opa");
                                                    break;
                                                case "Hund":
                                                    Console.Write("seinem Hund");
                                                    break;
                                                case "Kürbis":
                                                    Console.Write("seinem Kürbis");
                                                    break;
                                            }
                                            Console.Write(" ins Dorf zurück.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("THE END!!!");
                                        }
                                    }
                                    break;

                                case "Huhn":
                                    int streicheln = 0;
                                    Console.WriteLine("Der Krieger hat das huhnige Huhn aufgespührt.");
                                    Huhn:
                                    Console.WriteLine("Was wird er tun?\n");
                                    Console.WriteLine("K= Kämpfen S= Streicheln A= Ansprechen G= Gehen");
                                    Problem2 = Console.ReadLine().ToUpper();
                                    Console.Clear();
                                    switch (Problem2)
                                    {
                                        case "K":
                                            //Deadend
                                            Console.WriteLine("Der Krieger will das Huhn bekämpfen, doch als er sieht, wie süss das Huhn doch ist, stirbt er an einem Süssigkeitsüberschuss.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("GAME OVER");
                                            break;

                                        case "S":
                                            if (streicheln == 0)
                                            {
                                                Console.WriteLine("Der Krieger streichelt das Huhn.");
                                                streicheln = 1;
                                            }
                                            if (streicheln == 1)
                                            {
                                                Console.WriteLine("Der Krieger streichelt das Huhn wieder.");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Oops, something went wrong :(");
                                            }
                                            goto Huhn;

                                        case "A":
                                            Console.Write("Der Krieger versucht mit dem Huhn zu reden.\nDas Huhn kann ihn zwar nicht verstehen, aber es merk, dass der Krieger ");
                                            switch (Person)
                                            {
                                                case "Prinzessin":
                                                    Console.Write("die Prinzessin");
                                                    break;
                                                case "Opa":
                                                    Console.Write("seinen Opa");
                                                    break;
                                                case "Hund":
                                                    Console.Write("seinen Hund");
                                                    break;
                                                case "Kürbis":
                                                    Console.Write("seinen Kürbis");
                                                    break;
                                            }
                                            Console.Write(" retten möchte.\n Es lässt die beiden gehen.");
                                            Console.ReadKey();
                                            Console.WriteLine("Winner Winner Chicken Dinner");
                                            break;

                                        case "G":
                                            if (streicheln == 1)
                                            {
                                                Console.WriteLine("Der Krieger ist überglücklich, weil er das Huhn streicheln konnte, und geht ins Dorf zurück.");
                                                Console.ReadKey();
                                                Console.Clear();
                                                Console.WriteLine("kuscheliges GAME OVER");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Der Krieger geht ins Dorf zurück.");
                                                Console.ReadKey();
                                                Console.Clear();
                                                Console.WriteLine("GAME OVER");
                                            }

                                            break;
                                    }
                                    break;
                            }

                            break;
                        case "Pferd":
                            Console.WriteLine("Das Pferd versucht, die {0} zu beschwichtigen doch erst jetzt wird ihm bewusst, dass es nicht sprechen kann. Es wurde von den {0} festgenommen.", Lakeien);
                            Console.SetCursorPosition(0, 4);
                            Console.WriteLine(grenze);
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("GAME OVER");
                            break;
                    }
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Fehler beim ersten Problem");
                    Console.Read();
                    break;
             

            
            }
            Console.ReadLine();
            


        }
    }
}
