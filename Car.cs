using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_application
{
    class Car
    {
        public static int _PrevId;
        private int _VehicleId;
        public int VehicleId
        {
            get
            {
                return _VehicleId;
            }
        }
        public string RegNo;
        public DateTime DateOfManufacture;
        public enum Color
        {
            White = 0,
            Black,
            Red,
            Grey,
            Brown
        }
        public string Make;
        public string Model;
        public decimal Price;
        
        public int Speed;
        public static int MaxAccelerate = 140;  // static members
        public static int MinDeaccelerate = 10;
        public static int ServiceYear = 15;

        private string _Status;
        public string Status
        {
            get
            {
                return _Status;
            }
        }
        private decimal _CurrentPrice;
        public decimal CurrentPrice
        {
            get
            {
                _CurrentPrice = Price;
                int difference = DateTime.Now.Year - DateOfManufacture.Year;
                if (difference < Car.ServiceYear)
                {
                    for (int i = 1; i <= difference; i++)
                    {
                        _CurrentPrice = (_CurrentPrice - (_CurrentPrice / 10));
                    }
                }
                else
                {
                    _CurrentPrice = 0;
                }
                return _CurrentPrice;
            }
        }


        public Car()
        {
            _PrevId++;
            _VehicleId = _PrevId;
        }
        public Car(string regNo, string make, string model,  decimal price, DateTime dateOfManufacture)
            : this()
        {
            this.RegNo = regNo;
            this.Make = make;
            this.Model = model;
            this.Price = price;
            this.DateOfManufacture = dateOfManufacture;

            if ((DateTime.Now.Year - this.DateOfManufacture.Year) == 0)
            {
                _Status = "Congratulations on Purchasing a new Car";
            }

        }

        public Car(Car a)
        : this(a.RegNo, a.Make,a.Model,a.Price,a.DateOfManufacture)
        {
            
        }





        public void Start()
        {
            Speed = 20;
            int difference = DateTime.Now.Year - this.DateOfManufacture.Year;
            if (difference > Car.ServiceYear)
            {
                throw new ApplicationException("Car Expired and not started");

            }
            else
            {
                _Status = "Car started at speed of 20";

            }

        }
        public void Stop()
        {
            Speed = 0;
            _Status = "Your Car stopped ";
        }

        public void acclerate(int offsetspeed)
        {

            if (offsetspeed <= 140)
            {
                throw new ApplicationException("speed should not be less than MaxAcceleratespeed");
            }
            else
            {
                throw new ApplicationException("Car speed should not be beyond 140");
            }

        }

        

        public void Deacclerate(int offsetspeed)
        {

            if (offsetspeed <= MinDeaccelerate)
            {
                throw new ApplicationException("speed should not be less than MinDeacceleratespeed");
            }
           
        }

        
    }
}
