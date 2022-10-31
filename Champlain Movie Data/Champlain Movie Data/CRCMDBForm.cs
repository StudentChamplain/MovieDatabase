using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Champlain_Movie_Data
{
    public partial class movieDatabaseForm : Form
    {
        public movieDatabaseForm()
        {
            InitializeComponent();
        }

        private void moviesButton_Click(object sender, EventArgs e)
        {
            DisplayMoviesForm details = new DisplayMoviesForm();

            details.ShowDialog();

            
        }
    }
}
