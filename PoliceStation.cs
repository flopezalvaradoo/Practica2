using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class PoliceStation
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

        public void AddPoliceCarToStation(string plate)
        {
            PoliceCar police1 = new PoliceCar(plate);
            policeCarList.Add(police1);
        }

        public void ActivateAlarm()
        {
            if (alarm == false)
            {
                alarm = true;
            }
        }
        public void DeactivateAlarm()
        {
            if (alarm == true)
            {
                alarm = false;
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
    }
}
