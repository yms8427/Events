using BilgeAdam.Events.Enums;
using BilgeAdam.Events.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace BilgeAdam.Events
{
    public partial class frmMain : Form
    {
        private BindingList<Parent> parents;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var p = new Parent
            {
                fullName = txtFullName.Text,
                birthDate = dtpBirthDate.Value,
                gender = rdbFemale.Checked ? Gender.Female : Gender.Male
            };
            parents.Add(p);
            txtFullName.Clear();
            dtpBirthDate.Value = dtpBirthDate.MaxDate;
            rdbFemale.Checked = true;
            lstParents.SelectedIndex = -1;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            dtpBirthDate.MaxDate = new DateTime(now.Year, now.Month, now.Day).AddYears(-18);
            dtpBirthDate.MinDate = new DateTime(now.Year, now.Month, now.Day).AddYears(-90);
            grbMatch.Visible = false;
            LoadData();
            lstParents.SelectedIndex = -1;
        }

        private void lstParents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstParents.SelectedIndex == -1)
            {
                grbMatch.Visible = false;
            }
            else
            {
                var selected = lstParents.SelectedItem as Parent;
                grbMatch.Visible = true;
                txtSelectedParent.Text = selected.fullName;
                txtSelectedBirthDate.Text = selected.birthDate.ToString("dd/MM/yyyy");
                cmbSpouse.Enabled = selected.spouse == null;
                cmbSpouse.DataSource = null;
                if (selected.spouse != null)
                {
                    cmbSpouse.Items.Add(selected.spouse);
                    cmbSpouse.SelectedItem = selected.spouse;
                }
                else
                {
                    cmbSpouse.DataSource = GetAvailableMatches(selected).ToList();
                }
            }
        }

        private void LoadData()
        {
            parents = new BindingList<Parent>();
            parents.Add(new Parent { fullName = "Rüstem Yıldız", birthDate = new DateTime(1987, 12, 17), gender = Gender.Male });
            parents.Add(new Parent { fullName = "Aysun Şenocak", birthDate = new DateTime(1990, 2, 18), gender = Gender.Female });
            parents.Add(new Parent { fullName = "Kadir Cündübey", birthDate = new DateTime(1994, 6, 20), gender = Gender.Male });
            parents.Add(new Parent { fullName = "Cavit Usta", birthDate = new DateTime(1992, 8, 30), gender = Gender.Male });
            parents.Add(new Parent { fullName = "Nihal Tekin", birthDate = new DateTime(1999, 10, 20), gender = Gender.Female });
            parents.Add(new Parent { fullName = "Figen Uluca", birthDate = new DateTime(2000, 3, 27), gender = Gender.Female });
            parents.Add(new Parent { fullName = "Yağmur Yanık", birthDate = new DateTime(1988, 8, 3), gender = Gender.Female });
            parents.Add(new Parent { fullName = "Yasemin Boca", birthDate = new DateTime(1995, 2, 10), gender = Gender.Female });
            parents.Add(new Parent { fullName = "Hamit Ayrık", birthDate = new DateTime(1996, 8, 17), gender = Gender.Male });
            parents.Add(new Parent { fullName = "Selçuk Kaya", birthDate = new DateTime(1997, 5, 13), gender = Gender.Male });
            parents.Add(new Parent { fullName = "Ahmet Yüksek", birthDate = new DateTime(1991, 2, 26), gender = Gender.Male });
            parents.Add(new Parent { fullName = "Gülsüm Ceylan", birthDate = new DateTime(2001, 11, 10), gender = Gender.Female });
            parents.Add(new Parent { fullName = "Orhan Aydın", birthDate = new DateTime(1993, 5, 1), gender = Gender.Male });
            foreach (var p in parents)
            {
                p.OnMatched += OnMathcedToAnother;
                p.OnChildAdded += ChildAdded;
            }
            lstParents.DataSource = parents;
        }

        private void ChildAdded(Parent parent, Child child)
        {
            if (parent.children == null)
            {
                parent.children = new List<Child>();
            }
            parent.children.Add(child);

            if (parent.gender == Gender.Male)
            {
                child.father = parent;
            }
            else
            {
                child.mother = parent;
            }
        }

        private void OnMathcedToAnother(Parent self, Parent spouse)
        {
            self.spouse = spouse;
        }

        private IEnumerable<Parent> GetAvailableMatches(Parent parent)
        {
            yield return new Parent { fullName = "Seçiniz" };
            foreach (var p in parents)
            {
                if (p.spouse != null)
                {
                    continue;
                }
                if (parent.gender != p.gender)
                {
                    yield return p;
                }
            }
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            var selected = lstParents.SelectedItem as Parent;
            var spouse = cmbSpouse.SelectedItem as Parent;
            selected.SetSpouse(spouse);
            cmbSpouse.Enabled = false;
        }

        private void ctxAddChild_Click(object sender, EventArgs e)
        {
            if (lstParents.SelectedItem == null)
            {
                return;
            }
            var selected = lstParents.SelectedItem as Parent;
            if (selected.spouse == null)
            {
                return;
            }
            var f = new frmChildren();
            f.selectedParent = selected;
            f.ShowDialog();
        }
    }
}
