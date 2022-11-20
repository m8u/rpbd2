using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpbd2.Entities
{
    public class GeneralCargoType
    {
        public virtual int Id { get; protected set; }
        public virtual string Name { get; set; }
    }
}
