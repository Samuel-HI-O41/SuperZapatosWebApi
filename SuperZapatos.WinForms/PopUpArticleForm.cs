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
    public partial class PopUpArticleForm : Form
    {
        private RequestHelper MyRequest { get; set; }
        private readonly ArticlesForm _articleForm;
        private Article PreviusArticle { get; set; }
        public PopUpArticleForm(Article model, ArticlesForm articleForm)
        {
            InitializeComponent();
            _articleForm = articleForm;
            MyRequest = new RequestHelper();
            PreviusArticle = model;
        }

        private void PopUpArticleForm_Load(object sender, EventArgs e)
        {
            SettingDropdowm_Stores();
            txtBox_IdStore.AppendText(PreviusArticle.Id.ToString());
            if (PreviusArticle.Id != 0)
            {
                this.Text = "Actualizar Articulo";
                btn_AddArticle.Text = "Actualizar";
                ddl_selectStore.SelectedValue = PreviusArticle.StoreId;
            }
            txt_NameArticle.AppendText(PreviusArticle.Name == null ? "" : PreviusArticle.Name);
            txt_DescArticle.AppendText(PreviusArticle.Description == null ? "" : PreviusArticle.Description);
            numBox_Price.Value = PreviusArticle.Price;
            numBox_Shelf.Value = PreviusArticle.Total_in_shelf;
            numBox_Vault.Value = PreviusArticle.Total_in_vault;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btn_AddArticle_Click(object sender, EventArgs e)
        {
            int articleId = int.Parse(txtBox_IdStore.Text);
            var article = new Article()
            {
                Id = articleId,
                Name = txt_NameArticle.Text,
                StoreId = int.Parse(ddl_selectStore.SelectedValue.ToString()),
                Description = txt_DescArticle.Text,
                Price = numBox_Price.Value,
                Total_in_shelf = (int)numBox_Shelf.Value,
                Total_in_vault = (int)numBox_Vault.Value,

            };

            string url = article.Id == 0 ? "https://localhost:44300/Services/CreateArticle?data" : "https://localhost:44300/Services/UpdateArticle?data";

            var response = await MyRequest.SendJsonRequest<Article>(url, article);
            var model = JsonConvert.DeserializeObject<DtoResponse<int>>(response);
            if (model.Estado)
            {
                await _articleForm.Update_DgvArticles("0");
                Close();
            }
            else
            {
                _articleForm.Clear_DgvArticles();
                MessageBox.Show("Error: " + model.Mensaje + "\n ErrorCode: " + model.Resultado, "Alerta");
                Close();
            }
        }

        #region publicMethods
        public async Task<List<Store>> GetListStores()
        {
            var url = "https://localhost:44300/Services/Stores?nameStore=" + null;
            var response = await MyRequest.SendSampleRequest<string>(url, "Get");
            var model = new StoreRequest() { };
            var storeList = new List<Store>() { };
            model = JsonConvert.DeserializeObject<StoreRequest>(response);
            if (model.success)
            {
                storeList = model.stores;
            }
            else
            {
                MessageBox.Show("Error: " + model.error_msg + "\n ErrorCode: " + model.error_code, "Alerta");
            }

            return storeList.ToList();
        }

        private async void SettingDropdowm_Stores()
        {
            var storeList = await GetListStores();
            if (storeList.Count() == 0)
            {
                MessageBox.Show("No  existen tiendas disponibles para este articulo, puede agregarlas en la sección Tiendas", "Alerta");
                Close();
            }
            else
            {
                storeList = storeList.OrderBy(x => x.Id).ToList();
                ddl_selectStore.DataSource = storeList;
                ddl_selectStore.DisplayMember = "Name";
                ddl_selectStore.ValueMember = "Id";
                var storeIdSelected = storeList.First();
                this.ddl_selectStore.SelectedValue = storeIdSelected.Id;
            }
        }

        #endregion

        private void txtBbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_PriceArticle_TextChanged(object sender, EventArgs e)
        {

        }

        private void ddl_selectStore_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
