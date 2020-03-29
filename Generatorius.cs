using System;

namespace ipasavarankiskas
{
    class Generatorius
    {
        public static int generuoti(long A, long B)
        {
            Saugojimas.pradinisA = A; //65;
            Saugojimas.pradinisB = B;//8921;

            for (int i = 0; i < 1000000; i++)
            {
                //A Generatorius
                Saugojimas.sugeneruotasSkA = (Saugojimas.pradinisA * Saugojimas.koeficientasA) % Saugojimas.skdalinimui;
                Saugojimas.pradinisA = (Int32)Saugojimas.sugeneruotasSkA;
                Saugojimas.generatoriusAListas.Add(Saugojimas.pradinisA);

                //B Generatorius
                Saugojimas.sugeneruotasSkB = (Saugojimas.pradinisB * Saugojimas.koeficientasB) % Saugojimas.skdalinimui;
                Saugojimas.pradinisB = (Int32)Saugojimas.sugeneruotasSkB;
                Saugojimas.generatoriusBListas.Add(Saugojimas.pradinisB);
            }

            for (int j = 0; j < Saugojimas.generatoriusAListas.Count; j++)
            {
                Saugojimas.generatoriusAString = Convert.ToString(Saugojimas.generatoriusAListas[j], 2).PadLeft(32, '0');
                Saugojimas.generatoriusBString = Convert.ToString(Saugojimas.generatoriusBListas[j], 2).PadLeft(32, '0');

                Saugojimas.binaryAString = Saugojimas.generatoriusAString.Substring(Saugojimas.generatoriusAString.Length - 8, 8);
                Saugojimas.binaryBString = Saugojimas.generatoriusBString.Substring(Saugojimas.generatoriusBString.Length - 8, 8);

                if (Saugojimas.binaryAString == Saugojimas.binaryBString)
                {
                    Saugojimas.palyginimasCount++;
                }
            }
            return Saugojimas.palyginimasCount;
        }
    }
}


