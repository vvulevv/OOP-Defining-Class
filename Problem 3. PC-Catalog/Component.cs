using System;

class Component
{
    private string name;
    private decimal price;
    private string details; //optional

    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Component name cannot be empty or null.");
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
                throw new ArgumentOutOfRangeException("Component price cannot be negative.");
            }
            this.price = value;
        }
    }

    public string Details
    {
        get { return this.details; }
        set
        {
            if (!(string.IsNullOrEmpty(details)) && details == "")
            {
                throw new ArgumentNullException("Component details cannot be empty string.");
            }
            this.details = value;
        }
    }

    public Component (string name, decimal price, string details = null)
    {
        this.Name = name;
        this.Price = price;
        this.Details = details;
    }

    public override string ToString()
    {
        if (!(string.IsNullOrEmpty(this.Details)))
        {
            return String.Format("Component name: {0}\nComponent price: {1}\nComponent details: {2}",
                this.Name, this.Price, this.Details);
        }
        else
        {
            return String.Format("Component name: {0}\nComponent price: {1}\n",
                this.Name, this.Price);
        }
    }
}