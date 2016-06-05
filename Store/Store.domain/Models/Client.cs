using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.domain.Models
{
    public class Client
    {

        public Guid id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public string  TypeClient { get; set; }
        public string PhoneNumber { get; set; }
        public int SecondaryPhoneNumber { get; set; }
        public Guid? AdressId { get; set; }
        public Guid? NationalityId { get; set; }


        #region virtual 

        public virtual Adress Adress{ get; set; }
        public virtual Country Nationality{ get; set; }
         #endregion
}
}
