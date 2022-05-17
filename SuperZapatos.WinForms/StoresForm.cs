using RestSharp;
using SuperZapatos.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace SuperZapatos.WinForms
{
    public partial class StoresForm : Form
    {
        private RequestHelper MyRequest { get; set; }
        public StoresForm()
        {
            InitializeComponent();
            MyRequest = new RequestHelper();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_SearchStores_Click(object sender, EventArgs e)
        {
            var url = "https://localhost:44300/Services/Stores?nameStore=" + "test";
            var response =  MyRequest.SendSampleRequest<string>(url, "Get");
            var test = 0;
        }
       
    }
}
