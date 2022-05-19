
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Articles = new System.Windows.Forms.DataGridView();
            this.ArticleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArticleStoreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArticleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArticleDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArticlePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArticleInShelf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArticleInVault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateArticle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteArticle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ddl_selectStore = new System.Windows.Forms.ComboBox();
            this.label_StoreCbox = new System.Windows.Forms.Label();
            this.newArticle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Articles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Articles
            // 
            this.dgv_Articles.AllowUserToAddRows = false;
            this.dgv_Articles.AllowUserToDeleteRows = false;
            this.dgv_Articles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Articles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Articles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Articles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Articles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArticleId,
            this.ArticleStoreId,
            this.ArticleName,
            this.ArticleDescription,
            this.ArticlePrice,
            this.ArticleInShelf,
            this.ArticleInVault,
            this.StoreArticle,
            this.UpdateArticle,
            this.DeleteArticle});
            this.dgv_Articles.Location = new System.Drawing.Point(9, 72);
            this.dgv_Articles.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Articles.Name = "dgv_Articles";
            this.dgv_Articles.ReadOnly = true;
            this.dgv_Articles.RowHeadersWidth = 51;
            this.dgv_Articles.RowTemplate.Height = 24;
            this.dgv_Articles.Size = new System.Drawing.Size(782, 366);
            this.dgv_Articles.TabIndex = 0;
            this.dgv_Articles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ArticleId
            // 
            this.ArticleId.HeaderText = "ArticleId";
            this.ArticleId.MinimumWidth = 6;
            this.ArticleId.Name = "ArticleId";
            this.ArticleId.ReadOnly = true;
            this.ArticleId.Visible = false;
            // 
            // ArticleStoreId
            // 
            this.ArticleStoreId.HeaderText = "StoreId";
            this.ArticleStoreId.Name = "ArticleStoreId";
            this.ArticleStoreId.ReadOnly = true;
            this.ArticleStoreId.Visible = false;
            // 
            // ArticleName
            // 
            this.ArticleName.HeaderText = "Articulo";
            this.ArticleName.MinimumWidth = 6;
            this.ArticleName.Name = "ArticleName";
            this.ArticleName.ReadOnly = true;
            // 
            // ArticleDescription
            // 
            this.ArticleDescription.HeaderText = "Descripción";
            this.ArticleDescription.MinimumWidth = 6;
            this.ArticleDescription.Name = "ArticleDescription";
            this.ArticleDescription.ReadOnly = true;
            // 
            // ArticlePrice
            // 
            this.ArticlePrice.HeaderText = "Precio";
            this.ArticlePrice.MinimumWidth = 6;
            this.ArticlePrice.Name = "ArticlePrice";
            this.ArticlePrice.ReadOnly = true;
            // 
            // ArticleInShelf
            // 
            this.ArticleInShelf.HeaderText = "En mostrador";
            this.ArticleInShelf.MinimumWidth = 6;
            this.ArticleInShelf.Name = "ArticleInShelf";
            this.ArticleInShelf.ReadOnly = true;
            // 
            // ArticleInVault
            // 
            this.ArticleInVault.HeaderText = "En Bodega";
            this.ArticleInVault.MinimumWidth = 6;
            this.ArticleInVault.Name = "ArticleInVault";
            this.ArticleInVault.ReadOnly = true;
            // 
            // StoreArticle
            // 
            this.StoreArticle.HeaderText = "Tienda";
            this.StoreArticle.MinimumWidth = 6;
            this.StoreArticle.Name = "StoreArticle";
            this.StoreArticle.ReadOnly = true;
            // 
            // UpdateArticle
            // 
            this.UpdateArticle.HeaderText = "Actualizar";
            this.UpdateArticle.MinimumWidth = 6;
            this.UpdateArticle.Name = "UpdateArticle";
            this.UpdateArticle.ReadOnly = true;
            // 
            // DeleteArticle
            // 
            this.DeleteArticle.HeaderText = "Eliminar";
            this.DeleteArticle.MinimumWidth = 6;
            this.DeleteArticle.Name = "DeleteArticle";
            this.DeleteArticle.ReadOnly = true;
            // 
            // ddl_selectStore
            // 
            this.ddl_selectStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_selectStore.FormattingEnabled = true;
            this.ddl_selectStore.Location = new System.Drawing.Point(106, 28);
            this.ddl_selectStore.Margin = new System.Windows.Forms.Padding(2);
            this.ddl_selectStore.Name = "ddl_selectStore";
            this.ddl_selectStore.Size = new System.Drawing.Size(310, 21);
            this.ddl_selectStore.TabIndex = 1;
            this.ddl_selectStore.SelectedIndexChanged += new System.EventHandler(this.ddl_selectStore_SelectedIndexChanged);
            // 
            // label_StoreCbox
            // 
            this.label_StoreCbox.AutoSize = true;
            this.label_StoreCbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StoreCbox.ForeColor = System.Drawing.Color.White;
            this.label_StoreCbox.Location = new System.Drawing.Point(39, 28);
            this.label_StoreCbox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_StoreCbox.Name = "label_StoreCbox";
            this.label_StoreCbox.Size = new System.Drawing.Size(63, 17);
            this.label_StoreCbox.TabIndex = 2;
            this.label_StoreCbox.Text = "Tienda:";
            this.label_StoreCbox.Click += new System.EventHandler(this.label1_Click);
            // 
            // newArticle
            // 
            this.newArticle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(252)))));
            this.newArticle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.newArticle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newArticle.ForeColor = System.Drawing.Color.White;
            this.newArticle.Location = new System.Drawing.Point(519, 15);
            this.newArticle.Margin = new System.Windows.Forms.Padding(2);
            this.newArticle.Name = "newArticle";
            this.newArticle.Size = new System.Drawing.Size(119, 45);
            this.newArticle.TabIndex = 3;
            this.newArticle.Text = "Agregar Articulo";
            this.newArticle.UseVisualStyleBackColor = false;
            this.newArticle.Click += new System.EventHandler(this.button1_Click);
            // 
            // ArticlesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.Controls.Add(this.newArticle);
            this.Controls.Add(this.label_StoreCbox);
            this.Controls.Add(this.ddl_selectStore);
            this.Controls.Add(this.dgv_Articles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ArticlesForm";
            this.Text = "ArticlesForm";
            this.Load += new System.EventHandler(this.ArticlesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Articles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Articles;
        private System.Windows.Forms.ComboBox ddl_selectStore;
        private System.Windows.Forms.Label label_StoreCbox;
        private System.Windows.Forms.Button newArticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticleStoreId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticleDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticlePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticleInShelf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticleInVault;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreArticle;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateArticle;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteArticle;
    }
}