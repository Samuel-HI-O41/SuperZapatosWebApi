using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperZapatos.WinForms.Models
{
    public class StoreRequest
    {
        public List<Store> stores { get; set; }
        public bool success { get; set; }
        public int total_elements { get; set; }
        public string error_msg { get; set; }
        public int error_code { get; set; }
    }

    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
