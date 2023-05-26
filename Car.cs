using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___IComparable___Sorting__
{
    internal class Car : IComparable<Car>
    {
       
            string _make;
            string _model;
            int _year;
            int _mileage;

            public Car(string make, string model, int year, int mileage)
            {
                _make = make;
                _model = model;
                _year = year;
                _mileage = mileage;
            }

            public string Make { get => _make; set => _make = value; }
            public string Model { get => _model; set => _model = value; }
            public int Year { get => _year; set => _year = value; }
            public int Mileage { get => _mileage; set => _mileage = value; }

        public int CompareTo(Car? other)
        {
            if (this._year > other._year)
            {
                return 1;
            }
            else if (this._year < other._year)
            {
                return -1;
            }
            else 
            {
                return 0;
            }
        }

        public override string ToString()
            {
                return $"{_year} {_make} {_model} -" +
                    $" Mileage {_mileage}";
            }
        
    }
}
