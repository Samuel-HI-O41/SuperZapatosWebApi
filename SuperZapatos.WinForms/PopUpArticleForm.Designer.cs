
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
            this.cbox_SelectStore = new System.Windows.Forms.ComboBox();
            this.lbl_NameArticle = new System.Windows.Forms.Label();
            this.txt_NameArticle = new System.Windows.Forms.TextBox();
            this.txt_DescArticle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_PriceArticle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_shelfArticle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_vaultArticle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_AddArticle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbox_SelectStore
            // 
            this.cbox_SelectStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_SelectStore.FormattingEnabled = true;
            this.cbox_SelectStore.Location = new System.Drawing.Point(128, 76);
            this.cbox_SelectStore.Name = "cbox_SelectStore";
            this.cbox_SelectStore.Size = new System.Drawing.Size(333, 28);
            this.cbox_SelectStore.TabIndex = 0;
            // 
            // lbl_NameArticle
            // 
            this.lbl_NameArticle.AutoSize = true;
            this.lbl_NameArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NameArticle.Location = new System.Drawing.Point(52, 36);
            this.lbl_NameArticle.Name = "lbl_NameArticle";
            this.lbl_NameArticle.Size = new System.Drawing.Size(68, 20);
            this.lbl_NameArticle.TabIndex = 1;
            this.lbl_NameArticle.Text = "Nombre";
            // 
            // txt_NameArticle
            // 
            this.txt_NameArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NameArticle.Location = new System.Drawing.Point(128, 31);
            this.txt_NameArticle.Name = "txt_NameArticle";
            this.txt_NameArticle.Size = new System.Drawing.Size(333, 26);
            this.txt_NameArticle.TabIndex = 2;
            // 
            // txt_DescArticle
            // 
            this.txt_DescArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DescArticle.Location = new System.Drawing.Point(128, 120);
            this.txt_DescArticle.Name = "txt_DescArticle";
            this.txt_DescArticle.Size = new System.Drawing.Size(333, 26);
            this.txt_DescArticle.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descripción";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_PriceArticle
            // 
            this.txt_PriceArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PriceArticle.Location = new System.Drawing.Point(128, 164);
            this.txt_PriceArticle.Name = "txt_PriceArticle";
            this.txt_PriceArticle.Size = new System.Drawing.Size(333, 26);
            this.txt_PriceArticle.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Precio";
            // 
            // txt_shelfArticle
            // 
            this.txt_shelfArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_shelfArticle.Location = new System.Drawing.Point(128, 204);
            this.txt_shelfArticle.Name = "txt_shelfArticle";
            this.txt_shelfArticle.Size = new System.Drawing.Size(333, 26);
            this.txt_shelfArticle.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "En Estante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tienda";
            // 
            // txt_vaultArticle
            // 
            this.txt_vaultArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vaultArticle.Location = new System.Drawing.Point(128, 244);
            this.txt_vaultArticle.Name = "txt_vaultArticle";
            this.txt_vaultArticle.Size = new System.Drawing.Size(333, 26);
            this.txt_vaultArticle.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "En Almacen";
            // 
            // btn_AddArticle
            // 
            this.btn_AddArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddArticle.Location = new System.Drawing.Point(149, 285);
            this.btn_AddArticle.Name = "btn_AddArticle";
            this.btn_AddArticle.Size = new System.Drawing.Size(176, 53);
            this.btn_AddArticle.TabIndex = 12;
            this.btn_AddArticle.Text = "Guardar";
            this.btn_AddArticle.UseVisualStyleBackColor = true;
            // 
            // PopUpArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 350);
            this.Controls.Add(this.btn_AddArticle);
            this.Controls.Add(this.txt_vaultArticle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_shelfArticle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_PriceArticle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_DescArticle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_NameArticle);
            this.Controls.Add(this.lbl_NameArticle);
            this.Controls.Add(this.cbox_SelectStore);
            this.Name = "PopUpArticleForm";
            this.Text = "Nuevo articulo";
            this.Load += new System.EventHandler(this.PopUpArticleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbox_SelectStore;
        private System.Windows.Forms.Label lbl_NameArticle;
        private System.Windows.Forms.TextBox txt_NameArticle;
        private System.Windows.Forms.TextBox txt_DescArticle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_PriceArticle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_shelfArticle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_vaultArticle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_AddArticle;
    }
}