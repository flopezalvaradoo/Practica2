namespace Practice2
{
    class Scooter : VehicleWithoutPlate
    {
        //constant string as TypeOfVehicle wont change allong PoliceCar instances.
        private static string typeOfVehicle = "Scooter";

        public Scooter() : base(typeOfVehicle)
        {
            //Values of atributes are set just when the instance is done if not needed before.
            SetSpeed(45.0f);
        }
    }
}
