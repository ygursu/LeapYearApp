using System.Runtime.Intrinsics.X86;

bool ArtikYilMi(int yil)
{
    return
        yil % 4 == 0 &&
        (yil % 100 != 0 || yil % 400 == 0);
}

static bool ArtikYilMi(int yil)
{
    return
        yil % 4 == 0 &&
        (yil % 100 != 0 || yil % 400 == 0);
}

static void Main(string[] args)
{
    for (int i = 1900, sira = 1; i <= 2100; i++)
    {
        if (ArtikYilMi(i))
        {
            Console.Write(i + " ");
            if (sira++ % 7 == 0)
                Console.WriteLine();
        }
    }

    Console.ReadKey();
}
Çıktı:



static bool ArtikYilMi(int yil)
{
    return
        yil % 4 == 0 &&
        (yil % 100 != 0 || yil % 400 == 0);
}

static void Main(string[] args)
{
    for (int i = 1900, sira = 1; i <= 2100; i++)
    {
        if (DateTime.IsLeapYear(i))
        {
            Console.Write(i + " ");
            if (sira++ % 7 == 0)
                Console.WriteLine();
        }
    }

    Console.ReadKey();
}
