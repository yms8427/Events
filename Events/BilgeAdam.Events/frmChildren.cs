using BilgeAdam.Events.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BilgeAdam.Events
{
    public partial class frmChildren : Form
    {
        public frmChildren()
        {
            InitializeComponent();
        }
        public Parent selectedParent;
        private void btnSave_Click(object sender, EventArgs e)
        {
            var child = new Child
            {
                birthDate = dtpBirthDate.Value,
                fullName = txtFullName.Text,
                siblings = new List<Child>()
            };
            selectedParent.AddChild(child);
            this.Close();
        }
    }
}
