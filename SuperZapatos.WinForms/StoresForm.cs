using Newtonsoft.Json;
using RestSharp;
using SuperZapatos.WinForms.Helpers;
using SuperZapatos.WinForms.Models;
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
        private Form ActiveUpdateStoreForm = null;
        public StoresForm()
        {
            InitializeComponent();
            MyRequest = new RequestHelper();
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgv_Stores.Rows[e.RowIndex];
            var storeId = row.Cells[0].Value;
            var store = new Store() { };
            if (storeId != null)
            {
                store = new Store()
                {
                    Id = int.Parse(storeId.ToString()),
                    Name = row.Cells[1].Value.ToString(),
                    Address = row.Cells[2].Value.ToString()
                };
            }

            if (e.ColumnIndex == 3 && store.Id != 0)
            {
                if (ActiveUpdateStoreForm != null)
                {
                    ActiveUpdateStoreForm.Close();
                }
                var updateUpdateForme = new PopUpUpdateStore(store, this);
                ActiveUpdateStoreForm = updateUpdateForme;
                updateUpdateForme.ShowDialog();
            }
            else if (e.ColumnIndex == 4 && store.Id != 0)
            {
                DialogResult rAlert = MessageBox.Show($"¿Estas seguro de eliminar esta tienda: {store.Name} ?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rAlert == DialogResult.OK)
                {
                    var url = "https://localhost:44300/Services/DeleteStore/" + store.Id;

                    var response = await MyRequest.SendSampleRequest<int>(url, "GET");
                    var model = JsonConvert.DeserializeObject<DtoResponse<int>>(response);
                    if (model.Estado)
                    {
                        await Update_DgvStores();
                    }
                    else
                    {
                        Clear_DgvStores();
                        MessageBox.Show("Error: " + model.Mensaje + "\n ErrorCode: " + model.Resultado, "Alerta");
                    }
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btn_SearchStores_Click(object sender, EventArgs e)
        {
            var filter = string.IsNullOrEmpty(txtBox_SearhStores.Text) ? null : txtBox_SearhStores.Text;
            await Update_DgvStores(filter);
        }

        private async void newStore_Click(object sender, EventArgs e)
        {
            var newStore = new Store()
            {
                Name = txtBox_NewStore_Name.Text,
                Address = txtBox_NewStore_Address.Text
            };

            var url = "https://localhost:44300/Services/CreateStore?dataStore";

            var response = await MyRequest.SendJsonRequest<Store>(url, newStore);
            var model = JsonConvert.DeserializeObject<DtoResponse<int>>(response);
            if (model.Estado)
            {
                await Update_DgvStores();
            }
            else
            {
                Clear_DgvStores();
                MessageBox.Show("Error: " + model.Mensaje + "\n ErrorCode: " + model.Resultado, "Alerta");
            }
        }

        #region publicMethods

        public async Task Update_DgvStores(string filter = null)
        {
            var url = "https://localhost:44300/Services/Stores?nameStore=" + filter;
            var response = await MyRequest.SendSampleRequest<string>(url, "Get");
            var model = new StoreRequest() { };
            model = JsonConvert.DeserializeObject<StoreRequest>(response);
            if (model.success)
            {
                Construct_DgvStores(model.stores);
            }
            else
            {
                MessageBox.Show("Error: " + model.error_msg + "\n ErrorCode: " + model.error_code, "Alerta");
                dgv_Stores.Rows.Clear();
            }
        }
        public void Clear_DgvStores()
        {
            dgv_Stores.Rows.Clear();
        }
        #endregion

        #region privateMethods
        private void Construct_DgvStores(List<Store> stores)
        {
            dgv_Stores.Rows.Clear();
            foreach (var item in stores)
            {
                dgv_Stores.Rows.Add(item.Id, item.Name, item.Address, "Actualizar", "Eliminar");
            }
        }
        #endregion
    }
}
