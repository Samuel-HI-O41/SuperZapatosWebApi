using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperZapatos.WinForms
{
    public partial class Form1 : Form
    {

        private Form activeForm = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void btnMenuArticles_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ArticlesForm());
        }

        private void btnMenuStores_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StoresForm());

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelLogoMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMainContainer.Controls.Add(childForm);
            panelMainContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnMenuArticles_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new ArticlesForm());
        }
    }
}
