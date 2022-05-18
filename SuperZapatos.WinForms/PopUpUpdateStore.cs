using Newtonsoft.Json;
using SuperZapatos.WinForms.Helpers;
using SuperZapatos.WinForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperZapatos.WinForms
{
    public partial class PopUpUpdateStore : Form
    {
        private RequestHelper MyRequest { get; set; }
        private readonly StoresForm _storesForm;

        public PopUpUpdateStore(Store model, StoresForm storeForm)
        {
            InitializeComponent();
            _storesForm = storeForm;
            MyRequest = new RequestHelper();
            txtBox_NameStore.AppendText(model.Name);
            txtBox_Address.AppendText(model.Address);
            txtBox_IdStore.AppendText(model.Id.ToString());
        }

        private void PopUpUpdateStore_Load(object sender, EventArgs e)
        {

        }

        private void lb_NameStore_Click(object sender, EventArgs e)
        {

        }

        private void txtBox_NameStore_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_IdStore_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBox_Address_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            var url = "https://localhost:44300/Services/UpdateStore?dataStore";
            var store = new Store()
            {
                Id = int.Parse(txtBox_IdStore.Text),
                Name = txtBox_NameStore.Text,
                Address = txtBox_Address.Text
            };
            var response = await MyRequest.SendJsonRequest<Store>(url,store);
            var model = JsonConvert.DeserializeObject<DtoResponse<int>>(response);
            if (model.Estado)
            {

                await _storesForm.Update_DgvStores();
                Close();
            }
            else
            {
                _storesForm.Clear_DgvStores();
                MessageBox.Show("Error: " + model.Mensaje + "\n ErrorCode: " + model.Resultado, "Alerta");
                Close();
            }
        }
    }
}
