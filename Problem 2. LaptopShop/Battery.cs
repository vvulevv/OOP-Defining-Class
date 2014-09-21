using System;

class Battery
{
    private string type;
    private float batteryLife;

    public Battery(string type, float batteryLife)
    {
        this.Type = type;
        this.BatteryLife = batteryLife;
    }

    public string Type 
    { 
        get
        {
            return this.type;
        }
        set
        {
            if (type != null && type.Length < 1) 
            {
                throw new ArgumentNullException("Battery type shouldn't be empty.");
            }
            this.type = value;
        }
    }

    public float BatteryLife
    {
        get
        {
            return this.batteryLife;
        }
        set
        {
            if (batteryLife < 0)
            {
                throw new ArgumentOutOfRangeException("Battery Life should be a positive number.");
            }
            this.batteryLife = value;
        }
    }

    public override string ToString()
    {
        string result = "";
        if (this.Type != null)
        {
            result = "Battery Type: " + this.Type;  
        }
        if (this.BatteryLife >= 0)
        {
            result = result + "  Battery Life: " + this.BatteryLife + " hours";
        }
        return result;
    }

}