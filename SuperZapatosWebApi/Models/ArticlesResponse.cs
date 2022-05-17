using SuperZapatosWebApi.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperZapatosWebApi.Models
{
    [Serializable]
    public class ArticlesResponse
    {
        public List<Article> stores { get; set; }
        public bool success { get; set; }
        public int total_elements { get; set; }
        public string error_msg { get; set; }
        public int error_code { get; set; }
    }
}