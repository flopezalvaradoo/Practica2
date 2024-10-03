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
        public PoliceStation? policeStation;
        public List<Taxi> taxiLicenseList { get; private set; }

        public City(string city_name)
        {
            name = city_name;
            taxiLicenseList = new List<Taxi>();
        }

        public void SetPoliceStation(PoliceStation PoliceSta)
        {
            policeStation = PoliceSta;
        }

        public override string ToString()
        {
            return $"{GetName()} notification";
        }

        public string GetName()
        {
            return name;   
        }
        public void GiveTaxiLicenses(string plate)
        {
            Taxi taxi1 = new Taxi(plate);
            taxiLicenseList.Add(taxi1);
            Console.WriteLine(taxi1.WriteMessage("Created (from city)"));
        }

        public void RemoveTaxiLicenses(Taxi selectedTaxi)
        {
            Console.WriteLine(selectedTaxi.WriteMessage("Removed License"));
            taxiLicenseList.Remove(selectedTaxi);
        }

        public virtual string WriteMessage(string message)
        {
            return $"{this}: {message}";
        }
    }
}
