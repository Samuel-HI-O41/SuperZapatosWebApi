
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_NameStore = new System.Windows.Forms.Label();
            this.lbl_AddressStore = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
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
            this.dgv_Stores.Location = new System.Drawing.Point(23, 154);
            this.dgv_Stores.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Stores.Name = "dgv_Stores";
            this.dgv_Stores.RowHeadersWidth = 51;
            this.dgv_Stores.RowTemplate.Height = 24;
            this.dgv_Stores.Size = new System.Drawing.Size(703, 278);
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
            this.UpdateStore.HeaderText = "Actualizar";
            this.UpdateStore.MinimumWidth = 6;
            this.UpdateStore.Name = "UpdateStore";
            // 
            // DeleteStore
            // 
            this.DeleteStore.HeaderText = "Eliminar";
            this.DeleteStore.MinimumWidth = 6;
            this.DeleteStore.Name = "DeleteStore";
            // 
            // newStore
            // 
            this.newStore.Location = new System.Drawing.Point(543, 28);
            this.newStore.Margin = new System.Windows.Forms.Padding(2);
            this.newStore.Name = "newStore";
            this.newStore.Size = new System.Drawing.Size(110, 39);
            this.newStore.TabIndex = 1;
            this.newStore.Text = "Agregar Tienda";
            this.newStore.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 25);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(325, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 56);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(325, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lbl_NameStore
            // 
            this.lbl_NameStore.AutoSize = true;
            this.lbl_NameStore.Location = new System.Drawing.Point(25, 28);
            this.lbl_NameStore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NameStore.Name = "lbl_NameStore";
            this.lbl_NameStore.Size = new System.Drawing.Size(102, 13);
            this.lbl_NameStore.TabIndex = 4;
            this.lbl_NameStore.Text = "Nombre de la tienda";
            // 
            // lbl_AddressStore
            // 
            this.lbl_AddressStore.AutoSize = true;
            this.lbl_AddressStore.Location = new System.Drawing.Point(75, 59);
            this.lbl_AddressStore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_AddressStore.Name = "lbl_AddressStore";
            this.lbl_AddressStore.Size = new System.Drawing.Size(52, 13);
            this.lbl_AddressStore.TabIndex = 5;
            this.lbl_AddressStore.Text = "Dirección";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(140, 14);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(325, 20);
            this.textBox3.TabIndex = 6;
            // 
            // btn_SearchStores
            // 
            this.btn_SearchStores.Location = new System.Drawing.Point(543, 14);
            this.btn_SearchStores.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SearchStores.Name = "btn_SearchStores";
            this.btn_SearchStores.Size = new System.Drawing.Size(110, 28);
            this.btn_SearchStores.TabIndex = 7;
            this.btn_SearchStores.Text = "Buscar Tiendas";
            this.btn_SearchStores.UseVisualStyleBackColor = true;
            this.btn_SearchStores.Click += new System.EventHandler(this.btn_SearchStores_Click);
            // 
            // lbl_SearchStore
            // 
            this.lbl_SearchStore.AutoSize = true;
            this.lbl_SearchStore.Location = new System.Drawing.Point(31, 18);
            this.lbl_SearchStore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SearchStore.Name = "lbl_SearchStore";
            this.lbl_SearchStore.Size = new System.Drawing.Size(96, 13);
            this.lbl_SearchStore.TabIndex = 8;
            this.lbl_SearchStore.Text = "Buscar por nombre";
            this.lbl_SearchStore.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_NameStore);
            this.groupBox1.Controls.Add(this.newStore);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.lbl_AddressStore);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 84);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tienda nueva";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_SearchStore);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.btn_SearchStores);
            this.groupBox2.Location = new System.Drawing.Point(23, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(703, 47);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar lista de tiendas";
            // 
            // StoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(735, 447);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_Stores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateStore;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteStore;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_NameStore;
        private System.Windows.Forms.Label lbl_AddressStore;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_SearchStores;
        private System.Windows.Forms.Label lbl_SearchStore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}