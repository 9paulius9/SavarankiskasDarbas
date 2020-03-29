using System;
using System.Collections.Generic;
using System.Numerics;

namespace ipasavarankiskas
{
    public class Saugojimas
    {
        //Pasirinkimas
        public static string switchpasirinkimas { get; set; }
        public static string AIvedimas { get; set; }
        public static string BIvedimas { get; set; }
        public static string ibanIvedimas { get; set; }

        //Generatorius
        public static int koeficientasA = 16807;
        public static int koeficientasB = 48271;
        public static int skdalinimui = 2147483647;
        public static Int64 pradinisA { get; set; }
        public static Int64 pradinisB { get; set; }
        public static Int64 sugeneruotasSkA { get; set; }
        public static Int64 sugeneruotasSkB { get; set; }
        public static string generatoriusAString { get; set; }
        public static string generatoriusBString { get; set; }
        public static string binaryAString { get; set; }
        public static string binaryBString { get; set; }
        public static int palyginimasCount { get; set; }

        //IbanVerifikatorius
        public static string salisString = "LT";
        public static string saliesKodasString { get; set; }
        public static BigInteger bigIntas { get; set; }
        public static string ibanIntString { get; set; }
        public static string verificationas { get; set; }

        //IbanIsFailo
        public static string line { get; set; }
        public static List<string> saskaitosnr = new List<string>();

        //Generatorius
        public static List<Int64> generatoriusAListas = new List<Int64>();
        public static List<Int64> generatoriusBListas = new List<Int64>();

        //Verificationas
        public static List<string> raidesListas = new List<string>();
    }
}
