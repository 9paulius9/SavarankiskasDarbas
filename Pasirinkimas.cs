using System;

namespace ipasavarankiskas
{
    class Pasirinkimas
    {
        public static void switchPasirinkimas()
        {
            Console.WriteLine("Rasti atitinkancius skaicius 1 000 000 generavimu režyje:1");
            Console.WriteLine("Patikrinti Iban numeri:2");
            Console.WriteLine("Patikrinti Iban numeri iš failo:3");

            try
            {
                Saugojimas.switchpasirinkimas = Console.ReadLine();
                switch (Convert.ToInt16(Saugojimas.switchpasirinkimas))
                {
                    case 1:
                        Console.WriteLine("Ivesktie A generatoriaus skaiciu.(PVZ:65)");
                        Saugojimas.AIvedimas = Console.ReadLine();
                        Console.WriteLine("Ivesktie B generatoriaus skaiciu.(PVZ:8921)");
                        Saugojimas.BIvedimas = Console.ReadLine();
                        Console.WriteLine("Atikmenu skaičius = " + Generatorius.generuoti(Convert.ToInt64(Saugojimas.AIvedimas), Convert.ToInt64(Saugojimas.BIvedimas)));
                        break;
                    case 2:
                        Console.WriteLine("Iveskite Iban numeri");
                        Saugojimas.ibanIvedimas = Console.ReadLine();
                        Console.WriteLine(Salys.verifiacationLT(Saugojimas.ibanIvedimas));
                        break;
                    case 3:
                        TikrinamasFailas.Tikrinimas();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Klaidingas skaicius");
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Ivedete bloga skaiciu");
                Console.WriteLine($"Generic Exception Handler: {e}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Ivedete neskaiciu\n");
                Console.WriteLine($"Generic Exception Handler: {e}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Bloga įvestis");
                Console.WriteLine($"Generic Exception Handler: {e}");
            }
        }
    }
}

