namespace Exercism.Constructors
{
    class RemoteControlCar
    {
        private int speed;
        private int batteryDrain;
        private int distanceDriven;
        private int batteryPercentage;

        public RemoteControlCar(int speed, int batteryDrain)
        {
            this.speed = speed;
            this.batteryDrain = batteryDrain;
            distanceDriven = 0;
            batteryPercentage = 100;
        }

        public bool BatteryDrained() => batteryPercentage < batteryDrain ? true : false;

        public int DistanceDriven() => distanceDriven;

        public void Drive()
        {
            if (!BatteryDrained())
            {
                distanceDriven += speed;
                batteryPercentage -= batteryDrain;
            }
        }

        public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
    }

    class RaceTrack
    {
        private int distance;

        public RaceTrack(int distance) => this.distance = distance;

        public bool TryFinishTrack(RemoteControlCar car)
        {
            while (!car.BatteryDrained())
            {
                car.Drive();
            }
            return car.DistanceDriven() >= distance;
        }
    }
}
