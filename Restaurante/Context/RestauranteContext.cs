using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Restaurante.Context
{
    public partial class RestauranteContext : DbContext
    {
        public RestauranteContext()
            : base("name=RestauranteContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
