using Store.domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Infraestructure.Data.Map
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable("Users");
            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
           Property(x => x.UserName)
                .HasMaxLength(60)
                .IsRequired();

            Property(x => x.Password)
                .HasMaxLength(20)
                .IsRequired();

            Property(x => x.TypeUser)
                .HasMaxLength(20)
                .IsRequired();
        }


    }
}
