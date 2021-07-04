using FibonacciSequencePlayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequencePlayer.Utils
{
    public class BuildScalesUtility
    {
        public static Scale GetScale(ScaleList scaleToBuild)
        {
            Scale scale = new Scale();
            switch (scaleToBuild)
            {
                case ScaleList.CMajor:
                    scale.Name = "C Major";
                    scale = BuildScale(scale, new List<Notes> { Notes.LowB, Notes.MiddleC, Notes.D, Notes.E, Notes.F, Notes.G, Notes.A, Notes.B, Notes.HighC, Notes.HighD });
                    break;
                case ScaleList.DMajor:
                    scale.Name = "D Major";
                    scale = BuildScale(scale, new List<Notes> { Notes.CSharp, Notes.D, Notes.E, Notes.FSharp, Notes.G, Notes.A, Notes.B, Notes.HighCSharp, Notes.D, Notes.HighE });
                    break;
                case ScaleList.EMajor:
                    scale.Name = "E Major";
                    scale = BuildScale(scale, new List<Notes> { Notes.DSharp, Notes.E, Notes.FSharp, Notes.GSharp, Notes.A, Notes.B, Notes.HighCSharp, Notes.HighDSharp, Notes.HighE, Notes.HighFSharp});
                    break;
                case ScaleList.AMinor:
                    scale.Name = "A Minor";
                    scale = BuildScale(scale, new List<Notes> { Notes.LowG, Notes.LowA, Notes.LowB, Notes.MiddleC, Notes.D, Notes.E, Notes.F, Notes.G, Notes.A, Notes.B});
                    break;

                case ScaleList.FMajor:
                    scale.Name = "F Major";
                    scale = BuildScale(scale, new List<Notes> { Notes.LowE, Notes.LowF, Notes.LowG, Notes.LowA, Notes.LowASharp, Notes.MiddleC, Notes.D, Notes.E, Notes.F, Notes.G });
                    break;

                case ScaleList.GMajor:
                    scale.Name = "G Major";
                    scale = BuildScale(scale, new List<Notes> { Notes.LowA, Notes.LowB, Notes.MiddleC, Notes.D, Notes.E, Notes.F, Notes.G, Notes.A, Notes.B, Notes.HighC });
                    break;
                case ScaleList.HarmonicAMinor:
                    scale.Name = "Harmonic A Minor";
                    scale = BuildScale(scale, new List<Notes> { Notes.LowGSharp, Notes.LowA, Notes.LowB, Notes.MiddleC, Notes.D, Notes.E, Notes.F, Notes.GSharp, Notes.A, Notes.B});
                    break;
            }

            return scale;
        }

        private static Scale BuildScale(Scale scale, List<Notes> list)
        {
            int sortOrder = 0;
            scale.Keys = new List<PianoKey>();
            foreach(Notes key in list)
            {
                switch (key)
                {
                    case Notes.LowASharp:
                        scale.Keys.Add(new PianoKey
                        {
                            PKey = key,
                            Name = "Low A #",
                            Frequency = 223.082,
                            SortOrder = sortOrder
                        });
                    break;

                    case Notes.LowB:
                        scale.Keys.Add(new PianoKey
                        {
                            PKey = key,
                            Name = "Low B",
                            Frequency = 246.942,
                            SortOrder = sortOrder
                        });
                        break;

                    case Notes.MiddleC:
                        scale.Keys.Add(new PianoKey
                        {
                            PKey = key,
                            Name = "Middle C",
                            Frequency = 261.626,
                            SortOrder = sortOrder
                        });
                        break;

                    case Notes.CSharp:
                        scale.Keys.Add(new PianoKey
                        {
                            PKey = key,
                            Name = "C #",
                            Frequency = 277.183,
                            SortOrder = sortOrder
                        });
                        break;

                    case Notes.D:
                        scale.Keys.Add(new PianoKey
                        {
                            PKey = key,
                            Name = "D",
                            Frequency = 293.665,
                            SortOrder = sortOrder
                        });
                        break;

                    case Notes.DSharp:
                        scale.Keys.Add(new PianoKey
                        {
                            PKey = key,
                            Name = "D #",
                            Frequency = 311.127,
                            SortOrder = sortOrder
                        });
                        break;

                    case Notes.E:
                        scale.Keys.Add(new PianoKey
                        {
                            PKey = key,
                            Name = "E",
                            Frequency = 329.628,
                            SortOrder = sortOrder
                        });
                        break;
                    case Notes.F:
                        scale.Keys.Add(new PianoKey
                        {
                            PKey = key,
                            Name = "F",
                            Frequency = 349.228,
                            SortOrder = sortOrder
                        });
                        break;
                    case Notes.FSharp:
                        scale.Keys.Add(new PianoKey
                        {
                            PKey = key,
                            Name = "F #",
                            Frequency = 369.994,
                            SortOrder = sortOrder
                        });
                        break;
                    case Notes.G:
                        scale.Keys.Add(new PianoKey
                        {
                            PKey = key,
                            Name = "G",
                            Frequency = 391.995,
                            SortOrder = sortOrder
                        });
                        break;
                    case Notes.GSharp:
                        scale.Keys.Add(new PianoKey
                        {
                            PKey = key,
                            Name = "G #",
                            Frequency = 415.305,
                            SortOrder = sortOrder
                        });
                        break;
                    case Notes.A:
                        scale.Keys.Add(new PianoKey
                        {
                            PKey = key,
                            Name = "A",
                            Frequency = 440.000,
                            SortOrder = sortOrder
                        });
                        break;
                    case Notes.ASharp:
                        scale.Keys.Add(new PianoKey
                        {
                            PKey = key,
                            Name = "A #",
                            Frequency = 466.164,
                            SortOrder = sortOrder
                        });
                        break;
                    case Notes.B:
                        scale.Keys.Add(new PianoKey
                        {
                            PKey = key,
                            Name = "B",
                            Frequency = 493.883,
                            SortOrder = sortOrder
                        });
                        break;
                    case Notes.HighC:
                        scale.Keys.Add(new PianoKey
                        {
                            PKey = key,
                            Name = "High C",
                            Frequency = 523.251,
                            SortOrder = sortOrder
                        });
                        break;
                    case Notes.HighCSharp:
                        scale.Keys.Add(new PianoKey
                        {
                            PKey = key,
                            Name = "High C #",
                            Frequency = 554.365,
                            SortOrder = sortOrder
                        });
                        break;
                    case Notes.HighD:
                        scale.Keys.Add(new PianoKey
                        {
                            PKey = key,
                            Name = "High D",
                            Frequency = 587.330,
                            SortOrder = sortOrder
                        });
                        break;
                    case Notes.HighDSharp:
                        scale.Keys.Add(new PianoKey
                        {
                            PKey = key,
                            Name = "High D #",
                            Frequency = 622.254,
                            SortOrder = sortOrder
                        });
                        break;
                    case Notes.HighE:
                        scale.Keys.Add(new PianoKey
                        {
                            PKey = key,
                            Name = "High E",
                            Frequency = 659.255,
                            SortOrder = sortOrder
                        });
                        break;
                    case Notes.HighFSharp:
                        scale.Keys.Add(new PianoKey
                        {
                            PKey = key,
                            Name = "High F #",
                            Frequency = 739.989,
                            SortOrder = sortOrder
                        });
                        break;
                    case Notes.LowA:
                        scale.Keys.Add(new PianoKey
                        {
                            PKey = key,
                            Name = "Low A",
                            Frequency = 220.000,
                            SortOrder = sortOrder
                        });
                        break;
                    case Notes.LowG:
                        scale.Keys.Add(new PianoKey
                        {
                            PKey = key,
                            Name = "Low G",
                            Frequency = 195.998,
                            SortOrder = sortOrder
                        });
                        break;
                    case Notes.LowE:
                        scale.Keys.Add(new PianoKey
                        {
                            PKey = key,
                            Name = "Low E",
                            Frequency = 164.814,
                            SortOrder = sortOrder
                        });
                        break;
                    case Notes.LowF:
                        scale.Keys.Add(new PianoKey
                        {
                            PKey = key,
                            Name = "Low F",
                            Frequency = 174.614,
                            SortOrder = sortOrder
                        });
                        break;
                    case Notes.LowGSharp:
                        scale.Keys.Add(new PianoKey
                        {
                            PKey = key,
                            Name = "Low G Sharp",
                            Frequency = 207.652,
                            SortOrder = sortOrder
                        });
                        break;
                }

                sortOrder++;
            }
            return scale;
        }
    }

}
