namespace RoverChallenge
{
    public class Coordinates
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Position Position { get; set; }
        
    }

    public enum Position
    {
        N,
        E,
        S,
        W
    }
}