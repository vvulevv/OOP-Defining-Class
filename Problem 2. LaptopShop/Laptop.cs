using System;

class Laptop
{
    private string model; //mandatory
    private string manufacturer;
    private string processor;
    private int ram;
    private string graphicsCard;
    private int hdd;
    private string screen;
    private Battery battery;
    private decimal price; //mandatory

    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            if(model != null && model.Length <1)
            {
                throw new ArgumentNullException("Laptop model cannot be empty.");
            }
            this.model = value;
        }
    }

    public string Manufacturer
    {
        get
        {
            return this.manufacturer;
        }
        set
        {
            if (manufacturer != null && manufacturer.Length <1)
            {
                throw new ArgumentNullException("Laptop manufacturer cannot be empty.");
            }
            this.manufacturer = value;
        }
    }

    public string Processor
    {
        get
        {
            return this.processor;
        }
        set
        {
            if (processor != null && processor.Length <1)
            {
                throw new ArgumentNullException("Enter valid value for processor.");
            }
            this.processor = value;
        }
    }

    public int Ram
    {
        get
        {
            return this.ram;
        }
        set
        {
            if (ram < 0)
            {
                throw new ArgumentOutOfRangeException("RAM cannot be negative.");
            }
            this.ram = value;
        }
    }

    public string GraphicsCard
    {
        get
        {
            return this.graphicsCard;
        }
        set
        {
            if (graphicsCard != null && graphicsCard.Length < 1)
            {
                throw new ArgumentNullException("Invalid value for graphics card. Cannot be empty!");
            }
            this.graphicsCard = value;
        }
    }

    public int Hdd
    {
        get
        {
            return this.hdd;
        }
        set
        {
            if (hdd < 0)
            {
                throw new ArgumentOutOfRangeException("HDD cannot be negative.");
            }
            this.hdd = value;
        }
    }

    public string Screen
    {
        get
        {
            return this.screen;
        }
        set
        {
            if (screen != null && screen.Length < 1)
            {
                throw new ArgumentNullException("Invalid value for screen. Cannot be empty!");
            }
            this.screen = value;
        }
    }

    public decimal Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (price < 0)
            {
                throw new ArgumentOutOfRangeException("Price cannot be negative number.");
            }
            this.price = value;
        }
    }

    public Battery Battery
    {
        get
        {
            return this.battery;
        }
        set
        {
            this.battery = value;
        }
    }

    //Constructors:

    public Laptop(string model, decimal price)
    {
        this.Model = model;
        this.Price = price;
    }
    public Laptop (string model, decimal price, string manufacturer = null, string processor = null, int ram = 0,
        string graphicsCard = null, int hdd = 0, string screen = null, Battery battery = null) 
        : this (model, price)
    {
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.Ram = ram;
        this.GraphicsCard = graphicsCard;
        this.Hdd = hdd;
        this.Screen = screen;
        this.Battery = battery;
    }

    public override string ToString()
    {
        string result = "";

        if (this.Price !=0 )
        {
            result = String.Format("Price: {0} lv.", this.Price);
        }
        return String.Format("Model: {0}\nManufacturer: {1}\nProcessor: {2}\nRAM: {8} GB\nGraphics card: {3}\nHDD: {4} GB\nSreen: {5}\nBattery: {6}\n{7}",
            this.Model, this.Manufacturer, this.Processor, this.GraphicsCard, this.Hdd, this.Screen, this.Battery, result, this.Ram);
    }

}