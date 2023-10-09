using carRoundUp.Models;

namespace carRoundup.Repositories;
public class CarsRepository
{
  private List<Car> _FakeDb;
  public CarsRepository()
  {
    _FakeDb = new List<Car>();
    _FakeDb.Add(new Car(1, "Honda", "Civic", "Red", 2010, true));
    _FakeDb.Add(new Car(2, "Jeep", "Wrangler", "Black", 2003, true));
    _FakeDb.Add(new Car(3, "Mazda", "3", "Silver", 2005, false));
  }

  internal Car CreateCar(Car carData)
  {
    int carId = _FakeDb[_FakeDb.Count - 1].Id;
    carData.Id = carId + 1;
    _FakeDb.Add(carData);
    return carData;
  }

  internal void DeleteCar(int carId)
  {
    Car car = _FakeDb.Find(c => c.Id == carId);
    _FakeDb.Remove(car);
  }

  internal List<Car> GetAllCars()
  {
    return _FakeDb;
  }

  internal Car GetOneCarById(int carId)
  {
    Car car = _FakeDb.Find(c => c.Id == carId);
    return car;
  }
}