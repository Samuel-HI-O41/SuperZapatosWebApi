
namespace SuperZapatos.WinForms
{
    partial class PopUpUpdateStore
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
            this.lb_NameStore = new System.Windows.Forms.Label();
            this.txtBox_NameStore = new System.Windows.Forms.TextBox();
            this.txtBox_Address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_IdStore = new System.Windows.Forms.TextBox();
            this.btn_UpdateStore = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_NameStore
            // 
            this.lb_NameStore.AutoSize = true;
            this.lb_NameStore.Location = new System.Drawing.Point(28, 38);
            this.lb_NameStore.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_NameStore.Name = "lb_NameStore";
            this.lb_NameStore.Size = new System.Drawing.Size(81, 25);
            this.lb_NameStore.TabIndex = 0;
            this.lb_NameStore.Text = "Nombre";
            this.lb_NameStore.Click += new System.EventHandler(this.lb_NameStore_Click);
            // 
            // txtBox_NameStore
            // 
            this.txtBox_NameStore.Location = new System.Drawing.Point(164, 35);
            this.txtBox_NameStore.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtBox_NameStore.Name = "txtBox_NameStore";
            this.txtBox_NameStore.Size = new System.Drawing.Size(499, 30);
            this.txtBox_NameStore.TabIndex = 1;
            this.txtBox_NameStore.TextChanged += new System.EventHandler(this.txtBox_NameStore_TextChanged);
            // 
            // txtBox_Address
            // 
            this.txtBox_Address.Location = new System.Drawing.Point(164, 83);
            this.txtBox_Address.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtBox_Address.Name = "txtBox_Address";
            this.txtBox_Address.Size = new System.Drawing.Size(499, 30);
            this.txtBox_Address.TabIndex = 3;
            this.txtBox_Address.TextChanged += new System.EventHandler(this.txtBox_Address_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dirección";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBox_IdStore
            // 
            this.txtBox_IdStore.Location = new System.Drawing.Point(164, 136);
            this.txtBox_IdStore.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtBox_IdStore.Name = "txtBox_IdStore";
            this.txtBox_IdStore.Size = new System.Drawing.Size(499, 30);
            this.txtBox_IdStore.TabIndex = 5;
            this.txtBox_IdStore.Visible = false;
            this.txtBox_IdStore.TextChanged += new System.EventHandler(this.txtBox_IdStore_TextChanged);
            // 
            // btn_UpdateStore
            // 
            this.btn_UpdateStore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_UpdateStore.Location = new System.Drawing.Point(247, 212);
            this.btn_UpdateStore.Name = "btn_UpdateStore";
            this.btn_UpdateStore.Size = new System.Drawing.Size(202, 54);
            this.btn_UpdateStore.TabIndex = 6;
            this.btn_UpdateStore.Text = "Actualizar";
            this.btn_UpdateStore.UseVisualStyleBackColor = true;
            this.btn_UpdateStore.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lb_NameStore);
            this.groupBox1.Controls.Add(this.txtBox_NameStore);
            this.groupBox1.Controls.Add(this.txtBox_IdStore);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBox_Address);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 194);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la tienda";
            // 
            // PopUpUpdateStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 278);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_UpdateStore);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "PopUpUpdateStore";
            this.Text = "Actualizar Tienda";
            this.Load += new System.EventHandler(this.PopUpUpdateStore_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_NameStore;
        private System.Windows.Forms.TextBox txtBox_NameStore;
        private System.Windows.Forms.TextBox txtBox_Address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_IdStore;
        private System.Windows.Forms.Button btn_UpdateStore;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}