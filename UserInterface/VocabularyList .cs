﻿using DataAccess;
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
    public partial class Form1 : Form
    {
        FormDbContext _context = new FormDbContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            using (FormDbContext _context = new FormDbContext())
            {
                var result = from c in _context.englishes
                             select new 
                             {
                                 c.Soru,
                                 c.Cevap,
                                 c.TurengLink
                             };
                vocabularyList.DataSource= result.ToList();

            }
        }

        private void addVocubaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormAddVocabulary = new AddVocabulary();
            FormAddVocabulary.Show();
        }

      
    }
}