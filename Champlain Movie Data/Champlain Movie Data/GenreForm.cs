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
    public partial class GenreForm : Form
    {
        public GenreForm()
        {
            InitializeComponent();
        }

        private void genreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.genreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.movieDatabaseDataSet);

        }

        private void GenreForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDatabaseDataSet.Genre' table. You can move, or remove it, as needed.
            this.genreTableAdapter.Fill(this.movieDatabaseDataSet.Genre);

        }
    }
}
