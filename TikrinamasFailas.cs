using System;
using System.IO;

namespace ipasavarankiskas
{
    class TikrinamasFailas
    {
        public static void Tikrinimas()
        {
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(@"D:\\Files\Darbai(Disk D)\\Programavimas\\ipasavarankiskas\\ipasavarankiskas\\saskaitos.txt");
                while ((Saugojimas.line = file.ReadLine()) != null)
                {
                    Saugojimas.saskaitosnr.Add(Saugojimas.line);

                }
                Console.WriteLine("Isvesti i faila:1");
                Console.WriteLine("Isvesti i Console:2");
                Saugojimas.switchpasirinkimas = Console.ReadLine();

                switch (Convert.ToInt16(Saugojimas.switchpasirinkimas))
                {
                    case 1:

                        StreamWriter sw = new StreamWriter("D:\\Files\\Darbai(Disk D)\\Programavimas\\ipasavarankiskas\\ipasavarankiskas\\saskaitosPatikrintos.txt");
                        for (int i = 0; i < Saugojimas.saskaitosnr.Count; i++)
                        {
                            sw.WriteLine(Saugojimas.saskaitosnr[i] + ": ".PadRight(5) + Salys.verifiacationLT(Saugojimas.saskaitosnr[i]));
                        }
                        sw.Close();
                        Console.WriteLine("Irasyta i faila ,,saskaitosPatikrintos'' ");
                        break;

                    case 2:
                        for (int i = 0; i < Saugojimas.saskaitosnr.Count; i++)
                        {
                            Console.WriteLine(Saugojimas.saskaitosnr[i] + ": ".PadRight(5) + Salys.verifiacationLT(Saugojimas.saskaitosnr[i]));
                        }
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Klaidingas skaicius");
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("blogas failas\n");
                Console.WriteLine($"Generic Exception Handler: {e}");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Bloga Direktorija\n");
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
