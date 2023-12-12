namespace Cars;

public interface ICar
{
    public string Model { get; set; } // Property
    public string Color { get; set; } // Property

    public string Start();
    public string Stop();
}
