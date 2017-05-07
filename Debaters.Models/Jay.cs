using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debaters.Models
{
    public class Jay : Gambler
    {
        public Jay() : base("Jay")
        {

        }
        public override void FetchNewNumber(object sender, NewNumbertronNumberArgs args)
        {
            if(args.Number % 2 == 0)
                Score += 1;
        }
    }
}
