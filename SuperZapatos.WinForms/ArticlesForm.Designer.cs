
namespace SuperZapatos.WinForms
{
    partial class ArticlesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.selectStore = new System.Windows.Forms.ComboBox();
            this.label_StoreCbox = new System.Windows.Forms.Label();
            this.ArticleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArticleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArticleDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArticlePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArticleInShelf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArticleInVault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateArticle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteArticle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.newArticle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArticleId,
            this.ArticleName,
            this.ArticleDescription,
            this.ArticlePrice,
            this.ArticleInShelf,
            this.ArticleInVault,
            this.StoreArticle,
            this.UpdateArticle,
            this.DeleteArticle});
            this.dataGridView1.Location = new System.Drawing.Point(12, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1042, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // selectStore
            // 
            this.selectStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectStore.FormattingEnabled = true;
            this.selectStore.Location = new System.Drawing.Point(151, 29);
            this.selectStore.Name = "selectStore";
            this.selectStore.Size = new System.Drawing.Size(412, 24);
            this.selectStore.TabIndex = 1;
            // 
            // label_StoreCbox
            // 
            this.label_StoreCbox.AutoSize = true;
            this.label_StoreCbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StoreCbox.Location = new System.Drawing.Point(61, 29);
            this.label_StoreCbox.Name = "label_StoreCbox";
            this.label_StoreCbox.Size = new System.Drawing.Size(64, 20);
            this.label_StoreCbox.TabIndex = 2;
            this.label_StoreCbox.Text = "Tienda:";
            this.label_StoreCbox.Click += new System.EventHandler(this.label1_Click);
            // 
            // ArticleId
            // 
            this.ArticleId.HeaderText = "ArticleId";
            this.ArticleId.MinimumWidth = 6;
            this.ArticleId.Name = "ArticleId";
            this.ArticleId.Visible = false;
            // 
            // ArticleName
            // 
            this.ArticleName.HeaderText = "Articulo";
            this.ArticleName.MinimumWidth = 6;
            this.ArticleName.Name = "ArticleName";
            // 
            // ArticleDescription
            // 
            this.ArticleDescription.HeaderText = "Descripción";
            this.ArticleDescription.MinimumWidth = 6;
            this.ArticleDescription.Name = "ArticleDescription";
            // 
            // ArticlePrice
            // 
            this.ArticlePrice.HeaderText = "Precio";
            this.ArticlePrice.MinimumWidth = 6;
            this.ArticlePrice.Name = "ArticlePrice";
            // 
            // ArticleInShelf
            // 
            this.ArticleInShelf.HeaderText = "En mostrador";
            this.ArticleInShelf.MinimumWidth = 6;
            this.ArticleInShelf.Name = "ArticleInShelf";
            // 
            // ArticleInVault
            // 
            this.ArticleInVault.HeaderText = "En Bodega";
            this.ArticleInVault.MinimumWidth = 6;
            this.ArticleInVault.Name = "ArticleInVault";
            // 
            // StoreArticle
            // 
            this.StoreArticle.HeaderText = "Tienda";
            this.StoreArticle.MinimumWidth = 6;
            this.StoreArticle.Name = "StoreArticle";
            // 
            // UpdateArticle
            // 
            this.UpdateArticle.HeaderText = "Actualizar";
            this.UpdateArticle.MinimumWidth = 6;
            this.UpdateArticle.Name = "UpdateArticle";
            // 
            // DeleteArticle
            // 
            this.DeleteArticle.HeaderText = "Eliminar";
            this.DeleteArticle.MinimumWidth = 6;
            this.DeleteArticle.Name = "DeleteArticle";
            // 
            // newArticle
            // 
            this.newArticle.Location = new System.Drawing.Point(675, 13);
            this.newArticle.Name = "newArticle";
            this.newArticle.Size = new System.Drawing.Size(193, 55);
            this.newArticle.TabIndex = 3;
            this.newArticle.Text = "Agregar Articulo";
            this.newArticle.UseVisualStyleBackColor = true;
            this.newArticle.Click += new System.EventHandler(this.button1_Click);
            // 
            // ArticlesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1066, 550);
            this.Controls.Add(this.newArticle);
            this.Controls.Add(this.label_StoreCbox);
            this.Controls.Add(this.selectStore);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ArticlesForm";
            this.Text = "ArticlesForm";
            this.Load += new System.EventHandler(this.ArticlesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox selectStore;
        private System.Windows.Forms.Label label_StoreCbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticleDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticlePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticleInShelf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticleInVault;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreArticle;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateArticle;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteArticle;
        private System.Windows.Forms.Button newArticle;
    }
}