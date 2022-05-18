
namespace SuperZapatos.WinForms
{
    partial class StoresForm
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
            this.dgv_Stores = new System.Windows.Forms.DataGridView();
            this.StoreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateStore = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteStore = new System.Windows.Forms.DataGridViewButtonColumn();
            this.newStore = new System.Windows.Forms.Button();
            this.txtBox_NewStore_Name = new System.Windows.Forms.TextBox();
            this.txtBox_NewStore_Address = new System.Windows.Forms.TextBox();
            this.lbl_NameStore = new System.Windows.Forms.Label();
            this.lbl_AddressStore = new System.Windows.Forms.Label();
            this.txtBox_SearhStores = new System.Windows.Forms.TextBox();
            this.btn_SearchStores = new System.Windows.Forms.Button();
            this.lbl_SearchStore = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Stores
            // 
            this.dgv_Stores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Stores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Stores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Stores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StoreId,
            this.StoreName,
            this.Address,
            this.UpdateStore,
            this.DeleteStore});
            this.dgv_Stores.Location = new System.Drawing.Point(31, 190);
            this.dgv_Stores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Stores.Name = "dgv_Stores";
            this.dgv_Stores.RowHeadersWidth = 51;
            this.dgv_Stores.RowTemplate.Height = 24;
            this.dgv_Stores.Size = new System.Drawing.Size(937, 342);
            this.dgv_Stores.TabIndex = 0;
            this.dgv_Stores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // StoreId
            // 
            this.StoreId.HeaderText = "StoreId";
            this.StoreId.MinimumWidth = 6;
            this.StoreId.Name = "StoreId";
            this.StoreId.Visible = false;
            // 
            // StoreName
            // 
            this.StoreName.HeaderText = "Tienda";
            this.StoreName.MinimumWidth = 6;
            this.StoreName.Name = "StoreName";
            // 
            // Address
            // 
            this.Address.HeaderText = "Dirección";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            // 
            // UpdateStore
            // 
            this.UpdateStore.HeaderText = "-";
            this.UpdateStore.MinimumWidth = 6;
            this.UpdateStore.Name = "UpdateStore";
            this.UpdateStore.Text = "as";
            // 
            // DeleteStore
            // 
            this.DeleteStore.HeaderText = "-";
            this.DeleteStore.MinimumWidth = 6;
            this.DeleteStore.Name = "DeleteStore";
            // 
            // newStore
            // 
            this.newStore.Location = new System.Drawing.Point(724, 34);
            this.newStore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newStore.Name = "newStore";
            this.newStore.Size = new System.Drawing.Size(147, 48);
            this.newStore.TabIndex = 1;
            this.newStore.Text = "Agregar Tienda";
            this.newStore.UseVisualStyleBackColor = true;
            this.newStore.Click += new System.EventHandler(this.newStore_Click);
            // 
            // txtBox_NewStore_Name
            // 
            this.txtBox_NewStore_Name.Location = new System.Drawing.Point(189, 31);
            this.txtBox_NewStore_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_NewStore_Name.Name = "txtBox_NewStore_Name";
            this.txtBox_NewStore_Name.Size = new System.Drawing.Size(432, 22);
            this.txtBox_NewStore_Name.TabIndex = 2;
            // 
            // txtBox_NewStore_Address
            // 
            this.txtBox_NewStore_Address.Location = new System.Drawing.Point(187, 69);
            this.txtBox_NewStore_Address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_NewStore_Address.Name = "txtBox_NewStore_Address";
            this.txtBox_NewStore_Address.Size = new System.Drawing.Size(432, 22);
            this.txtBox_NewStore_Address.TabIndex = 3;
            // 
            // lbl_NameStore
            // 
            this.lbl_NameStore.AutoSize = true;
            this.lbl_NameStore.Location = new System.Drawing.Point(33, 34);
            this.lbl_NameStore.Name = "lbl_NameStore";
            this.lbl_NameStore.Size = new System.Drawing.Size(136, 17);
            this.lbl_NameStore.TabIndex = 4;
            this.lbl_NameStore.Text = "Nombre de la tienda";
            // 
            // lbl_AddressStore
            // 
            this.lbl_AddressStore.AutoSize = true;
            this.lbl_AddressStore.Location = new System.Drawing.Point(100, 73);
            this.lbl_AddressStore.Name = "lbl_AddressStore";
            this.lbl_AddressStore.Size = new System.Drawing.Size(67, 17);
            this.lbl_AddressStore.TabIndex = 5;
            this.lbl_AddressStore.Text = "Dirección";
            // 
            // txtBox_SearhStores
            // 
            this.txtBox_SearhStores.Location = new System.Drawing.Point(187, 17);
            this.txtBox_SearhStores.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_SearhStores.Name = "txtBox_SearhStores";
            this.txtBox_SearhStores.Size = new System.Drawing.Size(432, 22);
            this.txtBox_SearhStores.TabIndex = 6;
            // 
            // btn_SearchStores
            // 
            this.btn_SearchStores.Location = new System.Drawing.Point(724, 17);
            this.btn_SearchStores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SearchStores.Name = "btn_SearchStores";
            this.btn_SearchStores.Size = new System.Drawing.Size(147, 34);
            this.btn_SearchStores.TabIndex = 7;
            this.btn_SearchStores.Text = "Buscar Tiendas";
            this.btn_SearchStores.UseVisualStyleBackColor = true;
            this.btn_SearchStores.Click += new System.EventHandler(this.btn_SearchStores_Click);
            // 
            // lbl_SearchStore
            // 
            this.lbl_SearchStore.AutoSize = true;
            this.lbl_SearchStore.Location = new System.Drawing.Point(41, 22);
            this.lbl_SearchStore.Name = "lbl_SearchStore";
            this.lbl_SearchStore.Size = new System.Drawing.Size(129, 17);
            this.lbl_SearchStore.TabIndex = 8;
            this.lbl_SearchStore.Text = "Buscar por nombre";
            this.lbl_SearchStore.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_NameStore);
            this.groupBox1.Controls.Add(this.newStore);
            this.groupBox1.Controls.Add(this.txtBox_NewStore_Name);
            this.groupBox1.Controls.Add(this.txtBox_NewStore_Address);
            this.groupBox1.Controls.Add(this.lbl_AddressStore);
            this.groupBox1.Location = new System.Drawing.Point(31, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(937, 103);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tienda nueva";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_SearchStore);
            this.groupBox2.Controls.Add(this.txtBox_SearhStores);
            this.groupBox2.Controls.Add(this.btn_SearchStores);
            this.groupBox2.Location = new System.Drawing.Point(31, 126);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(937, 58);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar lista de tiendas";
            // 
            // StoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(980, 550);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_Stores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StoresForm";
            this.Text = "Tiendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Stores;
        private System.Windows.Forms.Button newStore;
        private System.Windows.Forms.TextBox txtBox_NewStore_Name;
        private System.Windows.Forms.TextBox txtBox_NewStore_Address;
        private System.Windows.Forms.Label lbl_NameStore;
        private System.Windows.Forms.Label lbl_AddressStore;
        private System.Windows.Forms.TextBox txtBox_SearhStores;
        private System.Windows.Forms.Button btn_SearchStores;
        private System.Windows.Forms.Label lbl_SearchStore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateStore;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteStore;
    }
}