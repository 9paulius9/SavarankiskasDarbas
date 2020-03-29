using System.Numerics;

namespace ipasavarankiskas
{
    class Salys
    {
        public static string verifiacationLT(string iban)
        {
            iban.ToUpper();
            Saugojimas.salisString = "LT";
            Saugojimas.saliesKodasString = iban.Substring(0, 4); //LT64

            //Tikrinimas
            if (Saugojimas.salisString == Saugojimas.saliesKodasString.Substring(0, 2))
            {
                Saugojimas.saliesKodasString = "2129";
                Saugojimas.ibanIntString = iban.Substring(4, iban.Length - 4) + Saugojimas.saliesKodasString + iban.Substring(2, 2);
                Saugojimas.bigIntas = (BigInteger.Parse(Saugojimas.ibanIntString)) % 97;
                if (Saugojimas.bigIntas == 1)
                {
                    Saugojimas.verificationas = "Tikras Iban numeris";
                }
                else
                {
                    Saugojimas.verificationas = "Blogas Iban numeris";
                }
            }
            else
            {
                Saugojimas.verificationas = "Blogas Iban numeris";
            }

            return Saugojimas.verificationas;
        }
    }
}
