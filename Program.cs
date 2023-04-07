using System;

class Processor
{
    public string merk;
    public string tipe;

}

class Intel : Processor
{
    public Intel()
    {
        base.merk = "Intel";
    }
}

namespace AMD1
{
    class AMD : Processor
    {
        public AMD()
        {
            base.merk = "AMD";
        }
    }
}


class Corei3 : Intel
{
    public Corei3()
    {
        base.tipe = "Core i3";
    }
}

class Corei5 : Intel
{
    public Corei5()
    {

        base.tipe = "Core i5";
    }
}

class Corei7 : Intel
{
    public Corei7()
    {

        base.tipe = "Core i7";
    }
}






class Ryzen : AMD1.AMD
{
    public Ryzen()
    {

        base.tipe = "RYZEN";
    }
}

class Athlon : AMD1.AMD
{
    public Athlon()
    {

        base.tipe = "ATHLON";
    }
}






class Vga
{
    public string merk;
}




class Nvidia : Vga
{
    public Nvidia()
    {
        base.merk = "Nvidia";

    }
}

namespace AMD2
{
    class AMD : Vga
    {
        public AMD()
        {
            base.merk = "AMD";
        }
    }
}




class Laptop
{
    public string merk;
    public string tipe;
    public Vga vga;
    public Processor processor;

    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} menyala");
    }

    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} mati");
    }
}


class ASUS : Laptop
{
    public ASUS()
    {
        base.merk = "ASUS";
    }
}

class ACER : Laptop
{
    public ACER()
    {
        base.merk = "Acer";
    }
}

class Lenovo : Laptop
{
    public Lenovo()
    {
        base.merk = "Lenovo";
    }

}



//================================================================================================================================





class ROG : ASUS
{
    public ROG()
    {

        base.tipe = "ROG";
    }
}


class Vivobook : ASUS
{
    public Vivobook()
    {
        base.tipe = "Vivobook";

    }


    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}

//========================================================================================================================================


class swift : ACER
{
    public swift()
    {
        base.tipe = "swift";
    }
}


class Predator : ACER
{
    public Predator()
    {

        base.tipe = "predator";
    }

    public void BermainGame()
    {
        Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
    }
}


//=================================================================================================================================================


class Ideapad : Lenovo
{
    public Ideapad()
    {

        base.tipe = "ideapad";
    }
}

class legion : Lenovo
{
    public legion()
    {
        base.tipe = "legion";
    }

}

//======================================================================================================================================================










internal class Program
{
    static void Main(string[] args)
    {
        Laptop laptop2 = new Ideapad();
        laptop2.vga = new AMD2.AMD();
        laptop2.processor = new Ryzen();

        Predator predator = new Predator();
        predator.vga = new AMD2.AMD();
        predator.processor = new Corei7();

        Laptop laptop1 = new Vivobook();
        laptop1.vga = new Nvidia();
        laptop1.processor = new Corei5();
        //nomor1

        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();



        //nomor 2 ERROR




        //nomor 3


        Console.WriteLine("merk Vga            :" + laptop1.vga.merk);
        Console.WriteLine("merk tipe processor :" + laptop1.processor.tipe);
        Console.WriteLine("merk merk processor :" + laptop1.processor.merk);


        //nomor 4
        predator.BermainGame();



        //nomor 5
        //ACER acer = new Predator();
        //acer.BermainGame();




        //nomer 6
        //kesimpulan yang saya dapat, method tidak bisa di gunakan untuk class lain.

















    }
}