using SuperZapatosWebApi.DbModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SuperZapatosWebApi
{
    public class DataContext : DbContext
    {
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<Article> Articles { get; set; }

    }
}