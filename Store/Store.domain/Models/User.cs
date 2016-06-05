using System;

namespace Store.domain.Models
{
    public class User: Client
    {

        protected User(){ }

        public User(string UserName, string Password,string TypeUser)
        {
            this.Id = new Guid();
            this.UserName = UserName;
            this.Password = Password;
            this.TypeUser = TypeUser;
        }

        #region Propriedades 
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string TypeUser { get; set; }
        #endregion

    }
}
