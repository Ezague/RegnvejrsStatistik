namespace RegnvejrsStatistik;

class Program
{
    public static void Main()
    {
        double[] regnStatistik;
        Console.Write("Indtast antal dage: ");
        if (int.TryParse(Console.ReadLine(), out int antalDage))
        {
            regnStatistik = new double[antalDage];
            for (int i = 0; i < antalDage; i++)
            {
                Console.Write("Indtast regnvejr for dag {0} i mm: ", i + 1);
                if (double.TryParse(Console.ReadLine(), out double regn))
                {
                    regnStatistik[i] = regn;
                }
                else throw new FormatException();
            }
            for (int j = 0; j < antalDage; j++)
            {
                Console.WriteLine("Regnvejr for dag {0}: {1} mm", j + 1, regnStatistik[j]);
            }
        }
        else throw new FormatException();

        Console.WriteLine("Gennemsnitlig regnvejr: {0} mm", RegnVejr.GennemsnitligRegnvejr(regnStatistik));

        Console.WriteLine("Maksimalt regnvejr: {0} mm", RegnVejr.MaksimaltRegnvejr(regnStatistik));

        Console.WriteLine("Minimum regnvejr: {0} mm", RegnVejr.MinimumRegnvejr(regnStatistik));
    }
}

class RegnVejr
{

    public static double GennemsnitligRegnvejr(double[] regn)
    {
        return regn.Average();
    }

    public static double MaksimaltRegnvejr(double[] regn)
    {
        return regn.Max();
    }

    public static double MinimumRegnvejr(double[] regn)
    {
        return regn.Min();
    }
}