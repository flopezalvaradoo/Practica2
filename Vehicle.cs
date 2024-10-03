using Practice2;

namespace Practice2
{
    abstract class Vehicle : IMessageWritter
    {
        private string typeOfVehicle;
        private float speed;

        // Constructor común para establecer el tipo de vehículo
        public Vehicle(string typeOfVehicle)
        {
            this.typeOfVehicle = typeOfVehicle;
            this.speed = 0f;
        }

        // Método ToString para ser sobreescrito en subclases
        public abstract override string ToString();

        public string GetTypeOfVehicle()
        {
            return typeOfVehicle;
        }

        public float GetSpeed()
        {
            return speed;
        }

        public void SetSpeed(float speed)
        {
            this.speed = speed;
        }

        // Implementar la interfaz IMessageWritter con el formato de mensaje común
        public string WriteMessage(string message)
        {
            return $"{this}: {message}";
        }
    }

}
