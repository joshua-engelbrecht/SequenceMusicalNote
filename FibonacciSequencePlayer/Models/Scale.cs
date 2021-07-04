using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequencePlayer.Models
{
    public class Scale
    {
        public string Name { get; set; }
        public IList<PianoKey> Keys { get; set; }
    }
}
