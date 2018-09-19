using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bKarvalakki_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\work\MiniProjektiViikko1\TietovisaC\bin\Debug\TietovisaC.exe");
        }

        private void bWinForms_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\work\MiniProjektiViikko1\QuizSovellus\bin\Debug\QuizSovellus.exe");
        }

        private void bMonivalinta_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\work\MiniProjektiViikko1\MiniprojektiKysely\bin\Debug\MiniprojektiKysely.exe");
        }
    }
}
