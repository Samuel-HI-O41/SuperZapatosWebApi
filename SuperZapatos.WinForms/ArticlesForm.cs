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
using System.Web.Mvc;
using System.Windows.Forms;

namespace SuperZapatos.WinForms
{
    public partial class ArticlesForm : Form
    {
        private RequestHelper MyRequest { get; set; }

        public ArticlesForm()
        {
            InitializeComponent();
            MyRequest = new RequestHelper();
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgv_Articles.Rows[e.RowIndex];
                var articleId = row.Cells["ArticleId"].Value;
                var article = new Article() { };
                if (articleId != null)
                {
                    article = new Article()
                    {
                        Id = int.Parse(articleId.ToString()),
                        Name = row.Cells["ArticleName"].Value.ToString(),
                        Description = row.Cells["ArticleDescription"].Value.ToString(),
                        Price = decimal.Parse(row.Cells["ArticlePrice"].Value.ToString()),
                        Total_in_shelf = int.Parse(row.Cells["ArticleInShelf"].Value.ToString()),
                        Total_in_vault = int.Parse(row.Cells["ArticleInVault"].Value.ToString()),
                        StoreId = int.Parse(row.Cells["ArticleStoreId"].Value.ToString()),
                    };
                }

                if (e.ColumnIndex == 8 && article.Id != 0)
                {
                    var updateForm = new PopUpArticleForm(article, this);
                    updateForm.ShowDialog();
                }
                else if (e.ColumnIndex == 9 && article.Id != 0)
                {
                    DialogResult rAlert = MessageBox.Show($"¿Estas seguro de eliminar este articulo: {article.Name} ?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (rAlert == DialogResult.OK)
                    {
                        var url = "https://localhost:44300/Services/DeleteArticle/" + article.Id;

                        var response = await MyRequest.SendSampleRequest<int>(url, "GET");
                        var model = JsonConvert.DeserializeObject<DtoResponse<int>>(response);
                        if (model.Estado)
                        {
                            var selected = ddl_selectStore.SelectedValue.ToString();
                            await Update_DgvArticles(selected);
                        }
                        else
                        {
                            Clear_DgvArticles();
                            MessageBox.Show("Error: " + model.Mensaje + "\n ErrorCode: " + model.Resultado, "Alerta");
                        }
                    }
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ArticlesForm_Load(object sender, EventArgs e)
        {
            SettingDropdowm_Stores();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopUpArticleForm popUp = new PopUpArticleForm(new Article(), this);
            popUp.ShowDialog();
        }

        private async void ddl_selectStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedValue = ddl_selectStore.SelectedValue.ToString();
            int idStore = 0;
            var convertNumber = int.TryParse(selectedValue, out idStore);
            await Update_DgvArticles(idStore.ToString());
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
        public void Clear_DgvArticles()
        {
            dgv_Articles.Rows.Clear();
        }

        public async Task Update_DgvArticles(string storeId = null)
        {
            var url = "https://localhost:44300/Services/Articles_Stores/" + storeId;
            var response = await MyRequest.SendSampleRequest<string>(url, "Get");
            var model = new ArticleRequest() { };
            model = JsonConvert.DeserializeObject<ArticleRequest>(response);
            if (model.success)
            {
                Construct_DgvArticles(model.articles);
            }
            else
            {
                MessageBox.Show("Error: " + model.error_msg + "\n ErrorCode: " + model.error_code, "Alerta");
                Clear_DgvArticles();
            }
        }

        #endregion

        #region privateMethods

        private async void SettingDropdowm_Stores()
        {
            var storeList = await GetListStores();
            var itemAllStores = new Store() { Name = "Todas", Id = 0 };
            storeList.Add(itemAllStores);
            ddl_selectStore.DataSource = storeList.OrderBy(x => x.Id).ToList();
            ddl_selectStore.DisplayMember = "Name";
            ddl_selectStore.ValueMember = "Id";
            ddl_selectStore.SelectedValue = 0;
        }

        private void Construct_DgvArticles(List<Article> articles)
        {
            Clear_DgvArticles();
            foreach (var item in articles)
            {
                dgv_Articles.Rows.Add(item.Id, item.StoreId, item.Name, item.Description, item.Price, item.Total_in_shelf, item.Total_in_vault, item.Store.Name, "Actualizar", "Eliminar");
            }
            ArticlePrice.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            ArticleInShelf.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            ArticleInVault.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        #endregion


    }
}
