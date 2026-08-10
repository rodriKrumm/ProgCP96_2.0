using System;
using System.Windows.Forms;

namespace PROGCP96_V1._1_
{
    public partial class Sobre_PROGCP96 : Form
    {
        public Sobre_PROGCP96()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void Sobre_PROGCP96_Load(object sender, EventArgs e)
        {
            linkLabel1.Text = "www.visus.ind.br";
            linkLabel1.Links.Add(0, 16, "www.visus.ind.br");
        }
    }
}
