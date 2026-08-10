
namespace PROGCP96_V1._1_
{
    partial class Ajuda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Novo");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Abrir");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Salvar");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Glossário");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("ARQUIVO", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Compilar");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("PROJETO", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("And");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Or");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Delete");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("LÓGICAS", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Auxiliar Analógica");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Contador");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Espera");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Temporizador");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("FUNÇÕES", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Display");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Contato Auxiliar");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Bimanual");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Bit");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("ESPECIAIS", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ajuda));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Azure;
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1190, 762);
            this.splitContainer1.SplitterDistance = 307;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.Azure;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.HotTracking = true;
            this.treeView1.Indent = 22;
            this.treeView1.ItemHeight = 30;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.BackColor = System.Drawing.Color.Azure;
            treeNode1.Name = "Nó1";
            treeNode1.Text = "Novo";
            treeNode2.BackColor = System.Drawing.Color.Azure;
            treeNode2.Name = "Nó2";
            treeNode2.Text = "Abrir";
            treeNode3.BackColor = System.Drawing.Color.Azure;
            treeNode3.Name = "Nó3";
            treeNode3.Text = "Salvar";
            treeNode4.BackColor = System.Drawing.Color.Azure;
            treeNode4.ForeColor = System.Drawing.Color.Black;
            treeNode4.Name = "Nó4";
            treeNode4.Text = "Glossário";
            treeNode5.BackColor = System.Drawing.Color.Azure;
            treeNode5.ForeColor = System.Drawing.Color.Black;
            treeNode5.Name = "No_arquivo";
            treeNode5.NodeFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode5.Text = "ARQUIVO";
            treeNode6.BackColor = System.Drawing.Color.Azure;
            treeNode6.ForeColor = System.Drawing.Color.Black;
            treeNode6.Name = "Nó5";
            treeNode6.Text = "Compilar";
            treeNode7.BackColor = System.Drawing.Color.Azure;
            treeNode7.ForeColor = System.Drawing.Color.Black;
            treeNode7.Name = "No_projeto";
            treeNode7.NodeFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode7.Text = "PROJETO";
            treeNode8.BackColor = System.Drawing.Color.Azure;
            treeNode8.ForeColor = System.Drawing.Color.Black;
            treeNode8.Name = "Nó6";
            treeNode8.Tag = "1";
            treeNode8.Text = "And";
            treeNode9.BackColor = System.Drawing.Color.Azure;
            treeNode9.ForeColor = System.Drawing.Color.Black;
            treeNode9.Name = "Nó7";
            treeNode9.Text = "Or";
            treeNode10.BackColor = System.Drawing.Color.Azure;
            treeNode10.ForeColor = System.Drawing.Color.Black;
            treeNode10.Name = "Nó8";
            treeNode10.Text = "Delete";
            treeNode11.BackColor = System.Drawing.Color.Azure;
            treeNode11.ForeColor = System.Drawing.Color.Black;
            treeNode11.Name = "No_logicas";
            treeNode11.NodeFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode11.Text = "LÓGICAS";
            treeNode12.BackColor = System.Drawing.Color.Azure;
            treeNode12.ForeColor = System.Drawing.Color.Black;
            treeNode12.Name = "Nó9";
            treeNode12.Text = "Auxiliar Analógica";
            treeNode13.BackColor = System.Drawing.Color.Azure;
            treeNode13.ForeColor = System.Drawing.Color.Black;
            treeNode13.Name = "Nó10";
            treeNode13.Text = "Contador";
            treeNode14.BackColor = System.Drawing.Color.Azure;
            treeNode14.ForeColor = System.Drawing.Color.Black;
            treeNode14.Name = "Nó11";
            treeNode14.Text = "Espera";
            treeNode15.BackColor = System.Drawing.Color.Azure;
            treeNode15.ForeColor = System.Drawing.Color.Black;
            treeNode15.Name = "Nó12";
            treeNode15.Text = "Temporizador";
            treeNode16.BackColor = System.Drawing.Color.Azure;
            treeNode16.ForeColor = System.Drawing.Color.Black;
            treeNode16.Name = "No_funcoes";
            treeNode16.NodeFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode16.Text = "FUNÇÕES";
            treeNode17.BackColor = System.Drawing.Color.Azure;
            treeNode17.ForeColor = System.Drawing.Color.Black;
            treeNode17.Name = "Nó13";
            treeNode17.Text = "Display";
            treeNode18.BackColor = System.Drawing.Color.Azure;
            treeNode18.ForeColor = System.Drawing.Color.Black;
            treeNode18.Name = "Nó14";
            treeNode18.Text = "Contato Auxiliar";
            treeNode19.BackColor = System.Drawing.Color.Azure;
            treeNode19.ForeColor = System.Drawing.Color.Black;
            treeNode19.Name = "Nó15";
            treeNode19.Text = "Bimanual";
            treeNode20.BackColor = System.Drawing.Color.Azure;
            treeNode20.ForeColor = System.Drawing.Color.Black;
            treeNode20.Name = "Nó16";
            treeNode20.Text = "Bit";
            treeNode21.BackColor = System.Drawing.Color.Azure;
            treeNode21.ForeColor = System.Drawing.Color.Black;
            treeNode21.Name = "No_especiais";
            treeNode21.NodeFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode21.Text = "ESPECIAIS";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode7,
            treeNode11,
            treeNode16,
            treeNode21});
            this.treeView1.Size = new System.Drawing.Size(307, 762);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 401);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(855, 358);
            this.textBox1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(855, 381);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Ajuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 762);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ajuda";
            this.Text = "Ajuda";
            this.Load += new System.EventHandler(this.Ajuda_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}