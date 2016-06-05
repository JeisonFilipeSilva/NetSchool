using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.domain.Models
{
    public class Adress
    {

        public Guid Id { get; set; }
        public string Street { get; set; }
        public string Complemenet { get; set; }
        public int Number { get; set; }
        public string District { get; set; }
        public int ZipCode { get; set; }
        public Guid? CityId { get; set; }

        #region Virtual
        public virtual City City{ get; set; }
        #endregion
    }
}
