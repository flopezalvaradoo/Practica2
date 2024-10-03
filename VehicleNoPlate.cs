namespace Practice2
{
    class VehicleWithoutPlate : Vehicle
    {
        public VehicleWithoutPlate(string typeOfVehicle) : base(typeOfVehicle) { }

        // Override de ToString para no incluir la matrícula
        public override string ToString()
        {
            return $"{GetTypeOfVehicle()} without plate";
        }
    }
}
