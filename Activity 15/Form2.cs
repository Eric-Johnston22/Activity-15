using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_15
{
    public partial class form_results : Form
    {
        public form_results()
        {
            InitializeComponent();
        }

        private void form_results_Load(object sender, EventArgs e)
        {
            lbl_lucky_number.Text = form_LuckyNumbers.luckyNumber.ToString();
            pictureBox1.Image = Image.FromFile(@"C:\Users\ejohn\source\repos\Grand Canyon University\CST-150\Activity 15\images\pixelwizard1.jpg");
        }
    }
}
