
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.newStore = new System.Windows.Forms.Button();
            this.StoreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateStore = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteStore = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_NameStore = new System.Windows.Forms.Label();
            this.lbl_AddressStore = new System.Windows.Forms.Label();
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
            this.StoreId,
            this.StoreName,
            this.Address,
            this.UpdateStore,
            this.DeleteStore});
            this.dataGridView1.Location = new System.Drawing.Point(31, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(937, 418);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // newStore
            // 
            this.newStore.Location = new System.Drawing.Point(642, 33);
            this.newStore.Name = "newStore";
            this.newStore.Size = new System.Drawing.Size(146, 48);
            this.newStore.TabIndex = 1;
            this.newStore.Text = "Agregar Tienda";
            this.newStore.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(432, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(184, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(432, 22);
            this.textBox2.TabIndex = 3;
            // 
            // lbl_NameStore
            // 
            this.lbl_NameStore.AutoSize = true;
            this.lbl_NameStore.Location = new System.Drawing.Point(28, 33);
            this.lbl_NameStore.Name = "lbl_NameStore";
            this.lbl_NameStore.Size = new System.Drawing.Size(136, 17);
            this.lbl_NameStore.TabIndex = 4;
            this.lbl_NameStore.Text = "Nombre de la tienda";
            // 
            // lbl_AddressStore
            // 
            this.lbl_AddressStore.AutoSize = true;
            this.lbl_AddressStore.Location = new System.Drawing.Point(97, 71);
            this.lbl_AddressStore.Name = "lbl_AddressStore";
            this.lbl_AddressStore.Size = new System.Drawing.Size(67, 17);
            this.lbl_AddressStore.TabIndex = 5;
            this.lbl_AddressStore.Text = "Dirección";
            // 
            // StoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 550);
            this.Controls.Add(this.lbl_AddressStore);
            this.Controls.Add(this.lbl_NameStore);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.newStore);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StoresForm";
            this.Text = "StoresForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}