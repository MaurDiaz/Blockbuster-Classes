using System;
using System.Collections.Generic;

namespace Activity4._4._3
{
    class Blockbuster
    {
        private List<VHSTape> ListOfMovies {get; set;}
        private string _address;

        public Blockbuster()
        {

        }
        public Blockbuster(List<VHSTape> newList, string address)
        {
            this.ListOfMovies = newList;
            this._address = address;
        }
        public void AddMovie(VHSTape newMovie)
        {
            this.ListOfMovies.Add(newMovie);
        }
        public bool CheckCatalog(string title)
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
                        return new VHSTape(movie.GetName(), (int)movie.GetLength());
                    }
                }
            }
            return null;     
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
                    }
                }
            }
        }
    }
}