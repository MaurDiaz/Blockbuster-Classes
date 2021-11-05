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
            
            VHSTape rentedMovie = new VHSTape(); // returned object when a movie is rented
            VHSTape empty = new VHSTape(); // empty object when trying to rent a movie that is not available
            VHSTape rentedMovie2 = new VHSTape(); // returned object when a movie is rented

            Debug.Assert(m1.GetName() == "Up");
            Debug.Assert(m1.GetLength() == 96);
            Debug.Assert(m1.Rented == false);
            //Debug.Assert(m1._played == 0); // field '_played' made public to test it
            m1.Play(97);
            //Debug.Assert(m1._played == 96); // field '_played' made public to test it
            m1.Rewind(100);
            //Debug.Assert(m1._played == 0); // field '_played' made public to test it

            Blockbuster lastRemaining = new Blockbuster("211 NE Revere Ave, Bend, OR 97701, United States");
            //Debug.Assert(lastRemaining._address == "211 NE Revere Ave, Bend, OR 97701, United States");

            lastRemaining.AddMovie(m1);
            lastRemaining.AddMovie(m2);
            lastRemaining.AddMovie(m3);
            lastRemaining.AddMovie(m4);
            lastRemaining.AddMovie(m5);
            lastRemaining.AddMovie(m6);
            lastRemaining.AddMovie(m7);
            lastRemaining.AddMovie(m8);
            lastRemaining.AddMovie(m9);
            lastRemaining.AddMovie(m10);
            lastRemaining.AddMovie(m11);
            lastRemaining.AddMovie(m12);

            Debug.Assert(lastRemaining.ListOfMovies[1].GetName() == "Ali");
            Debug.Assert(lastRemaining.ListOfMovies[9].GetName() == "Spy");
            Debug.Assert(lastRemaining.LookUp("Yes") == false);
            Debug.Assert(lastRemaining.LookUp("JFK") == true);

            rentedMovie = lastRemaining.Rent("Ed");
            Debug.Assert(m6.Rented == true);
            Debug.Assert(rentedMovie.GetName() == "Ed");

            empty = lastRemaining.Rent("Ed");
            Debug.Assert(empty.GetName() == null);

            Debug.Assert(lastRemaining.CheckAvailability("Ed") == false);
            Debug.Assert(lastRemaining.CheckAvailability("Saw") == true);

            lastRemaining.Return("Ed");

            Debug.Assert(m6.Rented == false);

            rentedMovie = lastRemaining.Rent("It");
            rentedMovie2 = lastRemaining.Rent("It");
            Debug.Assert(rentedMovie.GetLength() == rentedMovie2.GetLength());

            Debug.Assert(m7.Rented == true);
            Debug.Assert(m12.Rented == true);

            lastRemaining.Return("It");

            Debug.Assert(m7.Rented == false);
            Debug.Assert(m12.Rented == true);
        }
    }
}
