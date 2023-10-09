using System.Net.Http;
using carRoundUp.Models;
using carRoundUp.Services;

[ApiController]
[Route("api/cars")]
public class CarsController : ControllerBase
{
  private readonly CarsService _carsService;
  public CarsController(CarsService cs)
  {
    _carsService = cs;
  }

  [HttpGet("test")]
  public string getTest()
  {
    return "testing";
  }

  [HttpGet]
  public ActionResult<List<Car>> getCars()
  {
    try
    {
      List<Car> cars = _carsService.GetCars();
      return Ok(cars);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpGet("{carId}")]
  public ActionResult<Car> GetOneCarById(int carId)
  {
    try
    {
      Car car = _carsService.GetOneCarById(carId);
      return Ok(car);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpPost]
  public ActionResult<Car> CreateCar([FromBody] Car carData)
  {
    try
    {
      Car car = _carsService.CreateCar(carData);
      return Ok(car);
    }
    catch (Exception error)
    {
      return BadRequest(error.Message);
    }
  }

  [HttpDelete("{carId}")]
  public ActionResult<string> DeleteCar(int carId)
  {
    try
    {
      string message = _carsService.DeleteCar(carId);
      return Ok(message);
    }
    catch (Exception error)
    {
      return BadRequest(error.Message);
    }
  }

}