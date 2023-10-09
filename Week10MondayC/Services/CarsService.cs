using carRoundup.Repositories;
using carRoundUp.Models;
namespace carRoundUp.Services;

public class CarsService
{
  private readonly CarsRepository _repo;
  public CarsService(CarsRepository repo)
  {
    _repo = repo;
  }

  internal Car CreateCar(Car carData)
  {
    Car car = _repo.CreateCar(carData);
    return car;
  }

  internal string DeleteCar(int carId)
  {
    Car car = this.GetOneCarById(carId);
    _repo.DeleteCar(carId);
    return $"{car.Year}{car.Make}{car.Model} has spontaneously combusted";
  }

  internal List<Car> GetCars()
  {
    List<Car> cars = _repo.GetAllCars();
    return cars;
  }

  internal Car GetOneCarById(int carId)
  {
    Car car = _repo.GetOneCarById(carId);
    if (car == null) throw new Exception($"no car with the Id {carId}");
    return car;
  }
}