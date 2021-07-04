using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequencePlayer.Models
{
    public enum ScaleList
    {
        [Description("C Major")]
        CMajor = 1,
        [Description("D Major")]
        DMajor = 2,
        [Description("E Major")]
        EMajor = 3,
        [Description("F Major")]
        FMajor = 4,
        [Description("G Major")]
        GMajor = 5,
        [Description("A Minor")]
        AMinor = 6,
            [Description("Harmonic A Minor")]
        HarmonicAMinor = 7
    }

    //if you add here, add to the BuildScale Function
    public enum Notes
    {
        LowASharp = 0,
        LowB = 1,
        MiddleC = 2,
        CSharp = 3,
        D = 4,
        DSharp = 5,
        E = 6,
        ESharp = 7,
        F = 8,
        FSharp = 9,
        G = 10,
        GSharp = 11,
        A = 12,
        ASharp = 13,
        B = 14,
        BSharp  = 15,
        HighC = 16,
        HighCSharp = 17,
        HighD = 18,
        HighE = 19,
        HighFSharp= 20,
            HighDSharp = 21,
        LowA = 22,
        LowG = 23,
        LowE = 24,
        LowF = 25,
        LowGSharp= 26
    }

    public enum NumberList
    {
        [Description("Fibonacci Sequence")]
        Fibonacci =1,
        [Description("Pi")]
        Pi = 2
    }

}
