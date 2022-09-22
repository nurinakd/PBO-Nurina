class Ban
{
    public string merk;
    public Ban(string merk)
    {
        this.merk = merk;
    }
}

class Michelin : Ban
{
    public Michelin() : base("Michelin")
    {
    }
}

class Bridgestone : Ban
{
    public Bridgestone() : base("Bridgestone")
    {
    }
}

class Mobil
{
    public string merk;
    public string tipe;
    public Ban ban;

    public Mobil(string merk, string tipe, Ban ban)
    {
        this.merk = merk;
        this.tipe = tipe;
        this.ban = ban;
    }
    
    public void NyalakanMesin()
    {
        Console.WriteLine($"Mesin mobil {merk} bertipe {tipe} menyala");
    }
    public void MatikanMesin()
    {
        Console.WriteLine($"Mesin mobil {merk} bertipe {tipe} mati");
    }
}

class Toyota : Mobil
{
    public Toyota(string tipe, Ban ban) : base("Toyota", tipe, ban)
    {
    }
}

class Agya : Toyota
{
    public Agya(Ban ban) : base("Agya", ban)
    {
    }
}

class Avanza : Toyota
{
    public Avanza(Ban ban) : base("Avanza", ban)
    {
    }
    public void NyalakanLampu()
    {
        Console.WriteLine($"Lampu mobil {merk} bertipe {tipe} menyala");
    }
}

class Innova : Toyota
{
    public Innova(Ban ban) : base("Innova", ban)
    {
    }
}

class Daihatsu : Mobil
{
    public Daihatsu(string tipe, Ban ban) : base("Daihatsu", tipe, ban)
    {
    }
}

class Ayla : Daihatsu
{
    public Ayla(Ban ban) : base("Ayla", ban)
    {
    }
}

class Xenia : Daihatsu
{
    public Xenia(Ban ban) : base ("Xenia", ban)
    {
    }
}

class Honda : Mobil
{
    public Honda(string tipe, Ban ban) : base("Honda", tipe, ban)
    {
    }
}

class Brio : Honda
{
    public Brio(Ban ban) : base("Brio", ban)
    {
    }
}

class Civic : Honda
{
    public Civic(Ban ban) : base("Civic", ban)
    {
    }
    public void VtecKickedIn()
    {
        Console.WriteLine("Ngeeeng Wooosh!!!");
    }
}

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ban ban1 = new Michelin();
            Ban ban2 = new Bridgestone();

            Console.WriteLine("1.");
            Mobil mobil1 = new Agya(ban1);
            mobil1.NyalakanMesin();
            mobil1.MatikanMesin();
            
            Console.WriteLine("\n2.");
            Mobil mobil2 = new Avanza(ban2);
            ((Avanza)mobil2).NyalakanLampu();

            Console.WriteLine("\n3.");
            Console.WriteLine(mobil1.ban);

            Console.WriteLine("\n4.");
            Mobil civic1 = new Civic(ban2);
            ((Civic)civic1).VtecKickedIn();

            Console.WriteLine("\n5.");
            Mobil honda1 = civic1;
            honda1.NyalakanMesin();
            honda1.MatikanMesin();
            ((Civic)honda1).VtecKickedIn();

        }
    }
}
