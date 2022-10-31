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
    public partial class ActorForm : Form
    {
        public ActorForm()
        {
            InitializeComponent();
        }

        private void actorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.actorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.movieDatabaseDataSet);

        }

        private void ActorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDatabaseDataSet.Actor' table. You can move, or remove it, as needed.
            this.actorTableAdapter.Fill(this.movieDatabaseDataSet.Actor);

        }

        private void exitButtonActor_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
