using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace Activity4._4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            VHSTape m1 = new VHSTape("Up", 96);
            VHSTape m2 = new VHSTape("Ali", 157);
            VHSTape m3 = new VHSTape("xXx", 124);
            VHSTape m4 = new VHSTape("Air", 95);
            VHSTape m5 = new VHSTape("Saw", 103);
            VHSTape m6 = new VHSTape("Ed", 94);
            VHSTape m7 = new VHSTape("It", 135);
            VHSTape m8 = new VHSTape("JFK", 189);
            VHSTape m9 = new VHSTape("Red", 111);
            VHSTape m10 = new VHSTape("Spy", 120);
            VHSTape m11 = new VHSTape("Up", 96);
            VHSTape m12 = new VHSTape("It", 135);
            Debug.Assert(m1.GetName() == "Up");
            Debug.Assert(m1.GetLength() == 96);
            Debug.Assert(m1.Rented == false);
            m1.Play(97);
            m1.Rewind(100);



        }
    }
}
