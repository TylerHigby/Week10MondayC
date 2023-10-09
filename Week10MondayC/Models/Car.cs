namespace carRoundUp.Models;

public class Car
{
  public int Id { get; set; }
  public string Make { get; set; }
  public string Model { get; set; }
  public string Color { get; set; }
  public int Year { get; set; }
  public bool Running { get; set; }

  public Car(int id, string make, string model, string color, int year, bool running)
  {
    Id = id;
    Make = make;
    Model = model;
    Color = color;
    Year = year;
    Running = running;
  }

}