

namespace MVC_phone.Models
{
    using System.Data.Entity;

    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<MVC_phone.Models.Phone> Phones { get; set; }
    }
}