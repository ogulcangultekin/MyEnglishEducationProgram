using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class ExercisePage : Form
    {
        public ExercisePage()
        {
            InitializeComponent();
        }

        private void txtAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void btnRandomQuestion_Click(object sender, EventArgs e)
        {
            using (FormDbContext _context = new FormDbContext())
            {
               
                Random rand = new Random();
                int toSkip = rand.Next(1, _context.englishes.Count());
                
                var test = _context.englishes.OrderBy(r => r.Soru).Skip(toSkip).Take(1).First();
                txtQuestion.Text = test.Soru;
                linkLblTureng.Text = test.TurengLink;
            }

        }

        private void ExercisePage_Load(object sender, EventArgs e)
        {
            using (FormDbContext _context = new FormDbContext())
            {
                lblCount.Text = "Count:" + Convert.ToString(_context.englishes.Count());
            }
        }

        private void linkLblTureng_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(lblQuestion.Text);
        }
    }
}
