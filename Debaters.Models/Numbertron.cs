using System;

namespace Debaters.Models
{
    public class Numbertron
    {
        private Random rng;
        public event NumbertronNewNumber NewNumber;
        public Numbertron()
        {
            rng = new Random();
        }

        public void Generate()
        {
            NewNumber?.Invoke(this, new NewNumbertronNumberArgs { Number = rng.Next() });
        }
    }
    public delegate void NumbertronNewNumber(object sender, NewNumbertronNumberArgs args);
}