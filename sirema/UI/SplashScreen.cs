using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sirema.UI
{
    public partial class SplashScreen : Form
    {
        int counter = 0;
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(counter == 5)
            {
                Login jurusan = new Login();
                timer1.Enabled = false;
                jurusan.Show();
                this.Hide();
            }
            else
            {
                counter++;
            }
        }
    }
}
