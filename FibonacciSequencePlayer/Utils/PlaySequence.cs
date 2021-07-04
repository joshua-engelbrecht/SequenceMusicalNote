using FibonacciSequencePlayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FibonacciSequencePlayer.Utils
{
    public static class PlaySequence
    {
        public static void PlaySong(Scale scale, List<int> sequence, ListBox SequenceBox)
        {
            foreach (int n in sequence)
            {
                SequenceBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal,
                new Action(delegate ()
                {
                    SequenceBox.Items.Add(Convert.ToString(n));
                }));

                if (n > 9)
                {
                    var intList = n.ToString().Select(digit => int.Parse(digit.ToString()));
                    foreach (int i in intList)
                    {
                        Console.Beep((int)scale.Keys[i].Frequency, (int)500);
                    }

                }
                else
                {
                    Console.Beep((int)scale.Keys[n].Frequency, (int)500);
                }
            }
        }
    }
}
