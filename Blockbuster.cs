using System;
using System.Collections.Generic;

namespace Activity4._4._3
{
    class Blockbuster
    {
        public List<VHSTape> ListOfMovies {get; set;}
        private string _address;

        public Blockbuster()
        {

        }
        public Blockbuster(string address)
        {
            this.ListOfMovies = new List<VHSTape>();
            this._address = address;
        }
        public void AddMovie(VHSTape newMovie)
        {
            this.ListOfMovies.Add(newMovie);
        }
        public bool LookUp(string title)
        {
            foreach(VHSTape movie in this.ListOfMovies)
            {
                if(title == movie.GetName())
                {
                    return true;
                }
            }
            return false;
        }
        public bool CheckAvailability(string title)
        {
            foreach(VHSTape movie in this.ListOfMovies)
            {
                if(title == movie.GetName())
                {
                    if(!movie.Rented)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public VHSTape Rent(string title)
        {
            foreach(VHSTape movie in this.ListOfMovies)
            {
                if(title == movie.GetName())
                {
                    if(!movie.Rented)
                    {
                        movie.Rented = true;
                        return new VHSTape(movie.GetName(), movie.GetLength());
                    }
                }
            }
            return new VHSTape();     
        }
        public void Return(string title)
        {
            foreach(VHSTape movie in this.ListOfMovies)
            {
                if(title == movie.GetName())
                {
                    if(movie.Rented)
                    {
                        movie.Rented = false;
                        break;
                    }
                }
            }
        }
    }
}