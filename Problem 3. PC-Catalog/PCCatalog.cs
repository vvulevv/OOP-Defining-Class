using System;
using System.Collections.Generic;
using System.Linq;

class PCCatalog
{
    static void Main()
    {
        Component graphicsCard = new Component("nVidia", 350m);
        Component hdd = new Component("WesternDigital", 130m, "1TB 3.5 HDD (7200 оборота/минута)");
        Component ram = new Component("AsRock", 210m, "8GB (2x 4096MB) - DDR3, 1600Mhz");
        Component motherboard = new Component("AsRock", 520m);
        Component processor = new Component("Intel", 600m, "Core i5-4460 (4-ядрен, 3.20 - 3.40 GHz, 6MB кеш)");
        Component powerSupply = new Component("Superpowerrr", 250m, "5000W");
        Component biggerHdd = new Component("WesternDigital", 189m, "2TB 3.5 HDD");

        Computer lenovo = new Computer("Lenovo", graphicsCard, hdd, ram, motherboard, processor, powerSupply);
        Computer dell = new Computer("Dell", graphicsCard, biggerHdd, ram, motherboard, processor, powerSupply);
        Computer acer = new Computer("Acer", graphicsCard, ram, processor, motherboard);

        List<Computer> computers = new List<Computer>();
        computers.Add(lenovo);
        computers.Add(dell);
        computers.Add(acer);

        computers = computers.OrderBy(computer => computer.Price).ToList();

        foreach (var computer in computers)
        {
            computer.printInfo();
            Console.WriteLine();
        }

    }
}