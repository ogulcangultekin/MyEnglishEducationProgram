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
    public partial class AddVocabulary : Form
    {
        FormDbContext _context = new FormDbContext();
        public AddVocabulary()
        {
            InitializeComponent();
        }

        private void txtQuestion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void btnAddVocabulary_Click(object sender, EventArgs e)
        {
            using (FormDbContext _context = new FormDbContext())
            {
                var englishes = new English
                {


                    Soru = txtQuestion.Text,
                    Cevap = txtAnswer.Text,
                    TurengLink= "https://tureng.com/tr/turkce-ingilizce/"+txtQuestion.Text


                };
                 _context.englishes.Add(englishes);
                _context.SaveChanges();
                txtQuestion.Text = "";
                txtAnswer.Text = "";
                MessageBox.Show("Added");
                txtQuestion.Focus();


            }
        }
    }
}
