using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
   


        public InMemoryCarDal()
        {
            


            _cars = new List<Car>
            {
                new Car {Id = 1 ,BrandId=1, ColorId=1, DailyPrice=655, Descriptions="Mercedes" , ModelYear= "2015" },
                new Car {Id = 2 ,BrandId=2, ColorId=2, DailyPrice=213, Descriptions="BMW" , ModelYear= "2000" },
                new Car {Id = 3 ,BrandId=1, ColorId=4, DailyPrice=456, Descriptions="Mercedes" , ModelYear= "2005" },
                new Car {Id =4 ,BrandId=3, ColorId=3, DailyPrice=874, Descriptions="Nissan" , ModelYear= "2007" },
                new Car {Id =5 ,BrandId=4, ColorId=1, DailyPrice=545655, Descriptions="Audi" , ModelYear= "2020" },


            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);

        }

        public void Delete(Car car)
        {

          Car  carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);


        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int BrandId)
        {
          return  _cars.Where(c => c.BrandId == BrandId).ToList(); //yeni bir liste haline getirip onu döndürür.
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.BrandId = car.BrandId;

        }
    }
}
