using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineWeb
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            //wevc
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            
            SignUp signUp = new SignUp();
            signUp.ShowDialog();

        }
    }
}
