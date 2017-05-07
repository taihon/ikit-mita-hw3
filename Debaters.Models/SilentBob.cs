using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debaters.Models
{
    public class SilentBob : Gambler
    {
        public SilentBob(): base("Silent Bob")
        {

        }

        public override void FetchNewNumber(object sender, NewNumbertronNumberArgs args)
        {
            if(!args.Number.IsEven())
                Score+= 1;
        }
    }
}
