using System;

namespace Store.domain.Models
{
    public class City
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string County { get; set; }
        public Guid StateId { get; set; }


        #region virtual
        public virtual State State { get; set; }

        #endregion
    }
}