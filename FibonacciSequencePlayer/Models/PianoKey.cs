namespace FibonacciSequencePlayer.Models
{
    public class PianoKey
    {
        public string Name { get; set; }
        public double Frequency { get; set; }
        public int SortOrder { get; set; }
        public Notes PKey { get; set; }
    }
}