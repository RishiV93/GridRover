namespace RoverChallenge
{
    public class Rover
    {
        public string Instructions { get; set; }

        private Coordinates CurrentLocation { get; set; }

        public void SetInitialLocation(Coordinates coordinates)
        {
            if (coordinates != null)
            {
                this.CurrentLocation = coordinates;
            }
        }

        public Coordinates GetCurrentLocation()
        {
            return CurrentLocation;
        }
    }
}