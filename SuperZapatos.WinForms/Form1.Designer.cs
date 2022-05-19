
namespace SuperZapatos.WinForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnMenuStores = new System.Windows.Forms.Button();
            this.btnMenuMain = new System.Windows.Forms.Button();
            this.panelMenulogo = new System.Windows.Forms.Panel();
            this.panelMainContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_MainLogo = new System.Windows.Forms.PictureBox();
            this.btnMenuArticles = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.panelMainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MainLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.btnMenuArticles);
            this.panelSideMenu.Controls.Add(this.btnMenuStores);
            this.panelSideMenu.Controls.Add(this.btnMenuMain);
            this.panelSideMenu.Controls.Add(this.panelMenulogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 550);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnMenuStores
            // 
            this.btnMenuStores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnMenuStores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuStores.FlatAppearance.BorderSize = 0;
            this.btnMenuStores.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMenuStores.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMenuStores.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMenuStores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuStores.ForeColor = System.Drawing.Color.Snow;
            this.btnMenuStores.Location = new System.Drawing.Point(0, 290);
            this.btnMenuStores.Name = "btnMenuStores";
            this.btnMenuStores.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMenuStores.Size = new System.Drawing.Size(250, 50);
            this.btnMenuStores.TabIndex = 2;
            this.btnMenuStores.Text = "Tiendas";
            this.btnMenuStores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuStores.UseVisualStyleBackColor = false;
            this.btnMenuStores.Click += new System.EventHandler(this.btnMenuStores_Click);
            // 
            // btnMenuMain
            // 
            this.btnMenuMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnMenuMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuMain.FlatAppearance.BorderSize = 0;
            this.btnMenuMain.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMenuMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnMenuMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnMenuMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuMain.ForeColor = System.Drawing.Color.Snow;
            this.btnMenuMain.Location = new System.Drawing.Point(0, 240);
            this.btnMenuMain.Name = "btnMenuMain";
            this.btnMenuMain.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuMain.Size = new System.Drawing.Size(250, 50);
            this.btnMenuMain.TabIndex = 1;
            this.btnMenuMain.Text = "Menu";
            this.btnMenuMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuMain.UseVisualStyleBackColor = false;
            // 
            // panelMenulogo
            // 
            this.panelMenulogo.BackgroundImage = global::SuperZapatos.WinForms.Properties.Resources.SZ_Logo_Menu;
            this.panelMenulogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenulogo.Location = new System.Drawing.Point(0, 0);
            this.panelMenulogo.MaximumSize = new System.Drawing.Size(250, 240);
            this.panelMenulogo.Name = "panelMenulogo";
            this.panelMenulogo.Size = new System.Drawing.Size(250, 240);
            this.panelMenulogo.TabIndex = 0;
            this.panelMenulogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelMainContainer
            // 
            this.panelMainContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelMainContainer.Controls.Add(this.label1);
            this.panelMainContainer.Controls.Add(this.pictureBox_MainLogo);
            this.panelMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContainer.Location = new System.Drawing.Point(250, 0);
            this.panelMainContainer.Name = "panelMainContainer";
            this.panelMainContainer.Size = new System.Drawing.Size(1037, 550);
            this.panelMainContainer.TabIndex = 1;
            this.panelMainContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogoMain_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(333, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Super Zapatos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox_MainLogo
            // 
            this.pictureBox_MainLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_MainLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_MainLogo.Image")));
            this.pictureBox_MainLogo.Location = new System.Drawing.Point(288, 11);
            this.pictureBox_MainLogo.Name = "pictureBox_MainLogo";
            this.pictureBox_MainLogo.Size = new System.Drawing.Size(439, 348);
            this.pictureBox_MainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_MainLogo.TabIndex = 0;
            this.pictureBox_MainLogo.TabStop = false;
            this.pictureBox_MainLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnMenuArticles
            // 
            this.btnMenuArticles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnMenuArticles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuArticles.FlatAppearance.BorderSize = 0;
            this.btnMenuArticles.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMenuArticles.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMenuArticles.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMenuArticles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuArticles.ForeColor = System.Drawing.Color.Snow;
            this.btnMenuArticles.Location = new System.Drawing.Point(0, 340);
            this.btnMenuArticles.Name = "btnMenuArticles";
            this.btnMenuArticles.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMenuArticles.Size = new System.Drawing.Size(250, 47);
            this.btnMenuArticles.TabIndex = 4;
            this.btnMenuArticles.Text = "Articulos";
            this.btnMenuArticles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuArticles.UseVisualStyleBackColor = false;
            this.btnMenuArticles.Click += new System.EventHandler(this.btnMenuArticles_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1287, 550);
            this.Controls.Add(this.panelMainContainer);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSideMenu.ResumeLayout(false);
            this.panelMainContainer.ResumeLayout(false);
            this.panelMainContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MainLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelMenulogo;
        private System.Windows.Forms.Button btnMenuStores;
        private System.Windows.Forms.Button btnMenuMain;
        private System.Windows.Forms.Panel panelMainContainer;
        private System.Windows.Forms.PictureBox pictureBox_MainLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenuArticles;
    }
}

