using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterSheet
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            //yes, the naming convention is bad right here
            AddCharacter Add = new AddCharacter();

            Add.ShowDialog();
        }

        private void btnUpdateCharacter_Click(object sender, EventArgs e)
        {
            UpdateCharacter Update = new UpdateCharacter();
            Update.Show();
        }
    }
}
