
namespace SuperZapatos.WinForms
{
    partial class PopUpArticleForm
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
            this.ddl_selectStore = new System.Windows.Forms.ComboBox();
            this.lbl_NameArticle = new System.Windows.Forms.Label();
            this.txt_NameArticle = new System.Windows.Forms.TextBox();
            this.txt_DescArticle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_AddArticle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numBox_Vault = new System.Windows.Forms.NumericUpDown();
            this.numBox_Shelf = new System.Windows.Forms.NumericUpDown();
            this.numBox_Price = new System.Windows.Forms.NumericUpDown();
            this.txtBox_IdStore = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBox_Vault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBox_Shelf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBox_Price)).BeginInit();
            this.SuspendLayout();
            // 
            // ddl_selectStore
            // 
            this.ddl_selectStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_selectStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddl_selectStore.FormattingEnabled = true;
            this.ddl_selectStore.Location = new System.Drawing.Point(98, 71);
            this.ddl_selectStore.Margin = new System.Windows.Forms.Padding(2);
            this.ddl_selectStore.Name = "ddl_selectStore";
            this.ddl_selectStore.Size = new System.Drawing.Size(251, 24);
            this.ddl_selectStore.TabIndex = 0;
            this.ddl_selectStore.SelectedIndexChanged += new System.EventHandler(this.ddl_selectStore_SelectedIndexChanged);
            // 
            // lbl_NameArticle
            // 
            this.lbl_NameArticle.AutoSize = true;
            this.lbl_NameArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NameArticle.Location = new System.Drawing.Point(24, 34);
            this.lbl_NameArticle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NameArticle.Name = "lbl_NameArticle";
            this.lbl_NameArticle.Size = new System.Drawing.Size(58, 17);
            this.lbl_NameArticle.TabIndex = 1;
            this.lbl_NameArticle.Text = "Nombre";
            // 
            // txt_NameArticle
            // 
            this.txt_NameArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NameArticle.Location = new System.Drawing.Point(98, 34);
            this.txt_NameArticle.Margin = new System.Windows.Forms.Padding(2);
            this.txt_NameArticle.Name = "txt_NameArticle";
            this.txt_NameArticle.Size = new System.Drawing.Size(251, 23);
            this.txt_NameArticle.TabIndex = 2;
            this.txt_NameArticle.TextChanged += new System.EventHandler(this.txt_NameArticle_TextChanged);
            // 
            // txt_DescArticle
            // 
            this.txt_DescArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DescArticle.Location = new System.Drawing.Point(98, 107);
            this.txt_DescArticle.Margin = new System.Windows.Forms.Padding(2);
            this.txt_DescArticle.Name = "txt_DescArticle";
            this.txt_DescArticle.Size = new System.Drawing.Size(251, 23);
            this.txt_DescArticle.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descripción";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "En Estante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tienda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 207);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "En Almacen";
            // 
            // btn_AddArticle
            // 
            this.btn_AddArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddArticle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(252)))));
            this.btn_AddArticle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btn_AddArticle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddArticle.ForeColor = System.Drawing.Color.White;
            this.btn_AddArticle.Location = new System.Drawing.Point(123, 264);
            this.btn_AddArticle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddArticle.Name = "btn_AddArticle";
            this.btn_AddArticle.Size = new System.Drawing.Size(132, 42);
            this.btn_AddArticle.TabIndex = 12;
            this.btn_AddArticle.Text = "Guardar";
            this.btn_AddArticle.UseVisualStyleBackColor = false;
            this.btn_AddArticle.Click += new System.EventHandler(this.btn_AddArticle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.numBox_Vault);
            this.groupBox1.Controls.Add(this.numBox_Shelf);
            this.groupBox1.Controls.Add(this.numBox_Price);
            this.groupBox1.Controls.Add(this.txtBox_IdStore);
            this.groupBox1.Controls.Add(this.lbl_NameArticle);
            this.groupBox1.Controls.Add(this.ddl_selectStore);
            this.groupBox1.Controls.Add(this.txt_NameArticle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_DescArticle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 247);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos articulo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // numBox_Vault
            // 
            this.numBox_Vault.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBox_Vault.Location = new System.Drawing.Point(98, 207);
            this.numBox_Vault.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numBox_Vault.Name = "numBox_Vault";
            this.numBox_Vault.Size = new System.Drawing.Size(251, 23);
            this.numBox_Vault.TabIndex = 15;
            this.numBox_Vault.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numBox_Shelf
            // 
            this.numBox_Shelf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBox_Shelf.Location = new System.Drawing.Point(98, 175);
            this.numBox_Shelf.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numBox_Shelf.Name = "numBox_Shelf";
            this.numBox_Shelf.Size = new System.Drawing.Size(251, 23);
            this.numBox_Shelf.TabIndex = 14;
            this.numBox_Shelf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numBox_Price
            // 
            this.numBox_Price.DecimalPlaces = 2;
            this.numBox_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBox_Price.Location = new System.Drawing.Point(98, 138);
            this.numBox_Price.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numBox_Price.Name = "numBox_Price";
            this.numBox_Price.Size = new System.Drawing.Size(251, 23);
            this.numBox_Price.TabIndex = 13;
            this.numBox_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBox_IdStore
            // 
            this.txtBox_IdStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_IdStore.Location = new System.Drawing.Point(67, 252);
            this.txtBox_IdStore.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_IdStore.Name = "txtBox_IdStore";
            this.txtBox_IdStore.Size = new System.Drawing.Size(251, 23);
            this.txtBox_IdStore.TabIndex = 12;
            this.txtBox_IdStore.Visible = false;
            this.txtBox_IdStore.TextChanged += new System.EventHandler(this.txtBbox_TextChanged);
            // 
            // PopUpArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(391, 315);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_AddArticle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PopUpArticleForm";
            this.Text = "Nuevo articulo";
            this.Load += new System.EventHandler(this.PopUpArticleForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBox_Vault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBox_Shelf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBox_Price)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ddl_selectStore;
        private System.Windows.Forms.Label lbl_NameArticle;
        private System.Windows.Forms.TextBox txt_NameArticle;
        private System.Windows.Forms.TextBox txt_DescArticle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_AddArticle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBox_IdStore;
        private System.Windows.Forms.NumericUpDown numBox_Vault;
        private System.Windows.Forms.NumericUpDown numBox_Shelf;
        private System.Windows.Forms.NumericUpDown numBox_Price;
    }
}