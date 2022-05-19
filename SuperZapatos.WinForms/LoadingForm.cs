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
    public partial class LoadingForm : Form
    {
        private readonly Form _parentForm;

        public LoadingForm()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            MyLoading.Load("Content/loading.gif");
            MyLoading.Location = new Point((this.Width / 2) - (MyLoading.Width / 2),
                                           (this.Height / 2) - (MyLoading.Height / 2));
        }

        private void MyLoading_Click(object sender, EventArgs e)
        {

        }
    }
}
