using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class PoliceStation : IMessageWritter
    {
        private bool alarm;
        private string plateOffender;
        public List<PoliceCar> policeCarList { get; private set; }

        public PoliceStation()
        {
            alarm = false;
            policeCarList = new List<PoliceCar>();
            plateOffender = string.Empty;
        }

        public void AddNewPoliceCarToStation(string plate)
        {
            PoliceCar police1 = new PoliceCar(plate);
            policeCarList.Add(police1);
            police1.SetPoliceStation(this);
        }

        public void ActivateAlarm(string plate)
        {
            if (alarm == false)
            {
                alarm = true;
                SetPlateOffender(plate);
                Console.WriteLine(WriteMessage($"The alarm has been activated, the license plate is: {plate}."));
            }
        }
        public void DeactivateAlarm()
        {
            if (alarm == true)
            {
                alarm = false;
                SetPlateOffender(string.Empty);
                Console.WriteLine(WriteMessage($"The alarm has been deactivated."));
            }
        }

        public void SetPlateOffender(string plate)
        {
            plateOffender = plate;
        }

        public void AllChaseCar()
        {
            foreach (PoliceCar car in policeCarList)
            {
                car.StartChaseCar(plateOffender);
            }
        }

        public void AllStopChaseCar()
        {
            foreach (PoliceCar car in policeCarList)
            {
                car.StopChaseCar();
            }
        }

        public override string ToString()
        {
            return $"Police Station notification";
        }

        public virtual string WriteMessage(string message)
        {
            return $"{this}: {message}";
        }
    }
}
