namespace Practice2
{
    class PoliceCar : Vehicle
    {
        //constant string as TypeOfVehicle wont change allong PoliceCar instances
        private const string typeOfVehicle = "Police Car"; 
        private bool isPatrolling;
        private SpeedRadar speedRadar;
        private bool chassingCar;
        private PoliceStation? policeStation;

        public PoliceCar(string plate) : base(typeOfVehicle, plate)
        {
            isPatrolling = false;
            speedRadar = new SpeedRadar();
            chassingCar = false;
        }

        public void SetPoliceStation(PoliceStation polStation)
        {
            Console.WriteLine(WriteMessage("added to police station."));
            policeStation = polStation;
        }

        public void UseRadar(Vehicle vehicle)
        {
            if (isPatrolling)
            {
                speedRadar.TriggerRadar(vehicle);
                float speed_meassurement = speedRadar.GetLastReading();
                string meassurement;

                if (speed_meassurement > speedRadar.GetLegalSpeed())
                {
                    meassurement = "Catched above legal speed.";
                    Console.WriteLine(WriteMessage($"Triggered radar. Result: {meassurement}"));
                    
                    StartChaseCar(vehicle.GetPlate());
                    if (policeStation != null)
                    {
                        policeStation.ActivateAlarm(vehicle.GetPlate());
                    }
                }
                else
                {
                    meassurement = "Driving legally.";
                    Console.WriteLine(WriteMessage($"Triggered radar. Result: {meassurement}"));
                }
                
            }
            else
            {
                Console.WriteLine(WriteMessage($"has no active radar."));
            }
        }

        public void StartChaseCar(string plate)
        {
            if (isPatrolling == true)
            {
                if (chassingCar == false)
                {
                    chassingCar = true;
                    Console.WriteLine(WriteMessage($"starts chassing vehicle with plate {plate}."));
                }
                else
                {
                    Console.WriteLine(WriteMessage($"is already chassing vehicle with plate {plate}."));
                }
            }
            else
            {
                Console.WriteLine(WriteMessage($"can't chase, it is not patrolling."));
            }
        }

        public void StopChaseCar()
        {
            if (chassingCar == true)
            {
                chassingCar = false;
                Console.WriteLine(WriteMessage("stops chassing."));
            }
            else
            {
                Console.WriteLine(WriteMessage($"is not chassing."));
            }
        }

        public bool IsPatrolling()
        {
            return isPatrolling;
        }

        public void StartPatrolling()
        {
            if (!isPatrolling)
            {
                isPatrolling = true;
                Console.WriteLine(WriteMessage("started patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("is already patrolling."));
            }
        }

        public void EndPatrolling()
        {
            if (isPatrolling)
            {
                isPatrolling = false;
                Console.WriteLine(WriteMessage("stopped patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("was not patrolling."));
            }
        }

        public void PrintRadarHistory()
        {
            Console.WriteLine(WriteMessage("Report radar speed history:"));
            foreach (float speed in speedRadar.SpeedHistory)
            {
                Console.WriteLine(speed);
            }
        }

    }
}