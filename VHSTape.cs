using System;

namespace Activity4._4._3
{
    class VHSTape
    {
        private string _name;
        private double _length, _played;
        private bool _rented;


        public VHSTape()
        {

        }
        public VHSTape(string name, double length)
        {
            this._name = name;
            this._length = length;
            this._rented = false;
            this._played = 0.0;
        }
        public void Play(double time)
        {
            this._played += time;

            if (this._played > this._length) 
            {
                this._played = this._length;
            }
        }
    }
}