using System;
using System.Windows.Forms;

namespace PROGCP96_V1._1_
{
    public partial class Ajuda : Form
    {
        public Ajuda()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            if (treeView1.SelectedNode.Text == "And")
            {


                MessageBox.Show(treeView1.SelectedNode.Name.ToString());
                pictureBox1.Image = Properties.Resources.Novo_projeto;
                /* player.URL = @"C:\Users\proje\Videos\Captures\and.mp4";
                player.Ctlcontrols.play();*/
            }

        }

        private void player_Enter(object sender, EventArgs e)
        {

        }

        private void Ajuda_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {



        }
    }
}
