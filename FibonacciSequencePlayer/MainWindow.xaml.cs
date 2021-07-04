using FibonacciSequencePlayer.Models;
using FibonacciSequencePlayer.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FibonacciSequencePlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public delegate void UpdateTextCallback(string message);
        public ScaleList CurrentScale;
        public NumberList CurrentNumber;
        public int NumberOfIterations;
        private List<int> _sequence = new List<int>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            SequenceList.Items.Clear();

            CurrentScale = (ScaleList)ScaleListBox.SelectedItem;

            CurrentNumber = (NumberList)NumberListBox.SelectedItem;

            NumberOfIterations = int.Parse(NumberOfDigits.Text) - 1;

            switch (CurrentNumber)
            {
                case NumberList.Fibonacci:
                    _sequence = MathFunctions.CalculateFibonacciNumber(NumberOfIterations);
                    break;
                case NumberList.Pi:
                    _sequence = MathFunctions.CalculatePi(NumberOfIterations);
                    break;
            }

            Thread test = new Thread(new ThreadStart(PlaySong));
            test.Start();

        }

        private void PlaySong()
        {
            Scale scale = BuildScalesUtility.GetScale(CurrentScale);

            foreach (int n in _sequence)
            {
                SequenceList.Dispatcher.Invoke(
                    new UpdateTextCallback(this.UpdateList),
                    new object[] { n.ToString() }
                );

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

        private void UpdateList(string message)
        {
            SequenceList.Items.Add(message);
        }
    }
}
