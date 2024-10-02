using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Practice2
{
    class City : IMessageWritter
    {
        private string name;
        public PoliceStation policeStation;
        public List<Taxi> taxiLicenseList { get; private set; }

        public City(string city_name)
        {
            name = city_name;
            taxiLicenseList = new List<Taxi>();
            policeStation = new PoliceStation();
        }

        public void GiveTaxiLicenses(string plate)
        {
            Taxi taxi1 = new Taxi(plate);
            taxiLicenseList.Add(taxi1);
            Console.WriteLine(taxi1.WriteMessage("Created"));
        }

        public void RemoveTaxiLicenses(Taxi selectedTaxi)
        {
            Console.WriteLine(selectedTaxi.WriteMessage("Removed License"));
            taxiLicenseList.Remove(selectedTaxi);
        }

        public virtual string WriteMessage(string message)
        {
            return $"City notification: {message}";
        }
    }
}
