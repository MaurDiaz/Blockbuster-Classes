using System;

namespace Activity4._4._3
{
    class VHSTape
    {
        private readonly string _name;
        public int _played;
        private readonly int _length;
        public bool Rented {set; get;}

        public VHSTape(string name, int length)
        {
            this._name = name;
            this._length = length;
            this.Rented = false;
            this._played = 0;
        }
        public void Play(int time)
        {
            this._played += time;
            if(this._played > this._length) 
            {
                this._played = this._length;
            }
        }
        public void Rewind(int time)
        {
            this._played -= time;
            if(this._played < 0)
            {
                this._played = 0;
            }
        }
        public string GetName()
        {
            return this._name;
        }
        public double GetLength()
        {
            return this._length;
        }
        
    }
}