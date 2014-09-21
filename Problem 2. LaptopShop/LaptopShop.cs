using System;

class LaptopShop
{
    static void Main()
    {
        Laptop lenovo = new Laptop("Lenovo Yoga 2 Pro", 2259);
        Console.WriteLine(lenovo);

        Console.WriteLine();

        Battery lion = new Battery("Li-Ion, 4 cells, 2550mAh", (float)5.5);

        Laptop dell = new Laptop("Dell Inspiron", 3425, "Dell", "Intel 2955U 1.40 GHz, 2 MB cache",
            8, "Intel HD Graphics 4400", 1500, "18\"", lion);
        Console.WriteLine(dell);
    }     
}