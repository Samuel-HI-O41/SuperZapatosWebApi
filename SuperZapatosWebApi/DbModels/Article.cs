using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperZapatosWebApi.DbModels
{
    public class Article
    {
        [Key]
        public int Id { get; set; }

        public Store Store { get; set; }
        public int StoreId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Total_in_shelf { get; set; }
        public int Total_in_vault { get; set; }
    }
}