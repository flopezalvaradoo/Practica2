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
            Console.WriteLine(WriteMessage($"Police Car with plate: {plate} added"));
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

        public void ChaseCar()
        {
//hacer que los coches se pongan en modo persecucion
        }

        public virtual string WriteMessage(string message)
        {
            return $"Police Station notification: {message}";
        }
    }
}
