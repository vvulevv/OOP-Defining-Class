using System;
using System.Collections.Generic;

class Computer
{
    private string name;
    private List<Component> components = new List<Component>();
    private decimal price;

    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Computer name cannot be empty or null.");
            }
            this.name = value;
        }
    }

    public decimal Price
    {
        get { return this.price; }
        set
        {
            if (price < 0)
            {
                throw new ArgumentOutOfRangeException("Computer price cannot be negative.");
            }
            this.price = value;
        }
    }

    public Computer (string name, Component graphicsCard, Component processor,
        Component motherboard, Component hdd, Component ram, Component powerSupply)
    {
        this.Name = name;
        this.components.Add(graphicsCard);
        this.components.Add(processor);
        this.components.Add(motherboard);
        this.components.Add(hdd);
        this.components.Add(ram);
        this.components.Add(powerSupply);

        foreach (Component component in this.components)
        {
            this.price += component.Price;
        }
    }

    public Computer (string name, Component graphicsCard, Component ram, Component processor, Component motherboard)
    {
        this.Name = name;
        this.components.Add(graphicsCard);
        this.components.Add(ram);
        this.components.Add(processor);
        this.components.Add(motherboard);

        foreach (Component component in this.components)
        {
            this.price += component.Price;
        }
    }

    public void printInfo()
    {
        foreach(var component in this.components)
        {
            Console.WriteLine(" - {0} - {1:f2} лв.", component.Name, component.Price);
        }
    }

}