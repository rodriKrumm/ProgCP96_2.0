using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGCP96_V1._1_
{
    public partial class Dispositivos : Form
    {
       
        public static string label1 = " ";
        public static string label2 = " ";
        public static string label3 = " ";
        public static string label4 = " ";
        public static string label5 = " ";

        public static int pendrive;
       
        public static string[] vetorDriver = new string[5];

        public Dispositivos()
        {
            InitializeComponent();          
        }
    
        private void Dispositivos_Load(object sender, EventArgs e)
        {

        }

        private void Dispositivos_Shown(object sender, EventArgs e)
        {          
           DriveInfo[] allDrives = DriveInfo.GetDrives();
           
           for (int i = 0; i < vetorDriver.Length; i++)
           {
                vetorDriver[i] = " ";
           }
            
           for(int i =0; i < allDrives.Length; i++)
           { 
              vetorDriver[i] = allDrives[i].ToString();
              label1 = vetorDriver[1];
              label2 = vetorDriver[2];
              label3 = vetorDriver[3];
              label4 = vetorDriver[4];          
           }
     
            radioButton1.Text = label1;
            radioButton2.Text = label2;
            radioButton3.Text = label3;
            radioButton4.Text = label4;
            
            if (radioButton1.Text == " ")
            {
                radioButton1.Visible = false;
            }
            if (radioButton2.Text == " ")
            {
                radioButton2.Visible = false;
            }
            if (radioButton3.Text == " ")
            {
                radioButton3.Visible = false;
            }
            if (radioButton4.Text == " ")
            {
                radioButton4.Visible = false;
            }

            if (pendrive == 1)
            {
                radioButton1.Checked = true;
            }
            if (pendrive == 2)
            {
                radioButton2.Checked = true;
            }
            if (pendrive == 3)
            {
                radioButton3.Checked = true;
            }
            if (pendrive == 4)
            {
                radioButton4.Checked = true;
            }       
        }

        private void click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(radioButton1.Checked == true)
           {
                Form1.USB = label1;
                pendrive = 1;
           }
           if (radioButton2.Checked == true)
           {
                Form1.USB = label2;
                pendrive = 2;
           }
           if (radioButton3.Checked == true)
           {
                Form1.USB = label3;
                pendrive = 3;
           }
           if (radioButton4.Checked == true)
           {
                Form1.USB = label4;
                pendrive = 4;
           }

            File.Copy(Form1.caminho + @"\FileLad.bin", Form1.USB + @"\FileLad.bin", true);
           
            if (File.Exists(Form1.USB + @"\FileLad.bin"))
            {
                File.Copy(Form1.caminho + @"\FileBM1.txt", Form1.USB + @"\FileBM1.txt", true);
                File.Copy(Form1.caminho + @"\FileBM2.txt", Form1.USB + @"\FileBM2.txt", true);
                File.Copy(Form1.caminho + @"\FileB01.txt", Form1.USB + @"\FileB01.txt", true);
                File.Copy(Form1.caminho + @"\FileB02.txt", Form1.USB + @"\FileB02.txt", true);
                File.Copy(Form1.caminho + @"\FileA01.txt", Form1.USB + @"\FileA01.txt", true);
                File.Copy(Form1.caminho + @"\FileA02.txt", Form1.USB + @"\FileA02.txt", true);
                File.Copy(Form1.caminho + @"\FileA03.txt", Form1.USB + @"\FileA03.txt", true);
                File.Copy(Form1.caminho + @"\FileA04.txt", Form1.USB + @"\FileA04.txt", true);
                File.Copy(Form1.caminho + @"\FileC01.txt", Form1.USB + @"\FileC01.txt", true);
                File.Copy(Form1.caminho + @"\FileC02.txt", Form1.USB + @"\FileC02.txt", true);
                File.Copy(Form1.caminho + @"\FileD00.txt", Form1.USB + @"\FileD00.txt", true);
                File.Copy(Form1.caminho + @"\FileD01.txt", Form1.USB + @"\FileD01.txt", true);
                File.Copy(Form1.caminho + @"\FileD02.txt", Form1.USB + @"\FileD02.txt", true);
                File.Copy(Form1.caminho + @"\FileD03.txt", Form1.USB + @"\FileD03.txt", true);
                File.Copy(Form1.caminho + @"\FileD04.txt", Form1.USB + @"\FileD04.txt", true);
                File.Copy(Form1.caminho + @"\FileD05.txt", Form1.USB + @"\FileD05.txt", true);
                File.Copy(Form1.caminho + @"\FileD06.txt", Form1.USB + @"\FileD06.txt", true);
                File.Copy(Form1.caminho + @"\FileD07.txt", Form1.USB + @"\FileD07.txt", true);
                File.Copy(Form1.caminho + @"\FileD08.txt", Form1.USB + @"\FileD08.txt", true);
                File.Copy(Form1.caminho + @"\FileR01.txt", Form1.USB + @"\FileR01.txt", true);
                File.Copy(Form1.caminho + @"\FileR02.txt", Form1.USB + @"\FileR02.txt", true);
                File.Copy(Form1.caminho + @"\FileR03.txt", Form1.USB + @"\FileR03.txt", true);
                File.Copy(Form1.caminho + @"\FileR04.txt", Form1.USB + @"\FileR04.txt", true);
                File.Copy(Form1.caminho + @"\FileR05.txt", Form1.USB + @"\FileR05.txt", true);
                File.Copy(Form1.caminho + @"\FileR06.txt", Form1.USB + @"\FileR06.txt", true);
                File.Copy(Form1.caminho + @"\FileR07.txt", Form1.USB + @"\FileR07.txt", true);
                File.Copy(Form1.caminho + @"\FileR08.txt", Form1.USB + @"\FileR08.txt", true);
                File.Copy(Form1.caminho + @"\FileT01.txt", Form1.USB + @"\FileT01.txt", true);
                File.Copy(Form1.caminho + @"\FileT02.txt", Form1.USB + @"\FileT02.txt", true);
                File.Copy(Form1.caminho + @"\FileT03.txt", Form1.USB + @"\FileT03.txt", true);
                File.Copy(Form1.caminho + @"\FileT04.txt", Form1.USB + @"\FileT04.txt", true);
                File.Copy(Form1.caminho + @"\FileT05.txt", Form1.USB + @"\FileT05.txt", true);
                File.Copy(Form1.caminho + @"\FileT06.txt", Form1.USB + @"\FileT06.txt", true);
                File.Copy(Form1.caminho + @"\FileT07.txt", Form1.USB + @"\FileT07.txt", true);
                File.Copy(Form1.caminho + @"\FileT08.txt", Form1.USB + @"\FileT08.txt", true);
                File.Copy(Form1.caminho + @"\FileT09.txt", Form1.USB + @"\FileT09.txt", true);
                File.Copy(Form1.caminho + @"\FileT10.txt", Form1.USB + @"\FileT10.txt", true);
                File.Copy(Form1.caminho + @"\FileT11.txt", Form1.USB + @"\FileT11.txt", true);
                File.Copy(Form1.caminho + @"\FileT12.txt", Form1.USB + @"\FileT12.txt", true);
                File.Copy(Form1.caminho + @"\FileT13.txt", Form1.USB + @"\FileT13.txt", true);
                File.Copy(Form1.caminho + @"\FileT14.txt", Form1.USB + @"\FileT14.txt", true);
                File.Copy(Form1.caminho + @"\FileT15.txt", Form1.USB + @"\FileT15.txt", true);
                File.Copy(Form1.caminho + @"\FileT16.txt", Form1.USB + @"\FileT16.txt", true);
                File.Copy(Form1.caminho + @"\FileT17.txt", Form1.USB + @"\FileT17.txt", true);
                File.Copy(Form1.caminho + @"\FileT18.txt", Form1.USB + @"\FileT18.txt", true);
                File.Copy(Form1.caminho + @"\FileT19.txt", Form1.USB + @"\FileT19.txt", true);
                File.Copy(Form1.caminho + @"\FileT20.txt", Form1.USB + @"\FileT20.txt", true);
                File.Copy(Form1.caminho + @"\FileT21.txt", Form1.USB + @"\FileT21.txt", true);
                File.Copy(Form1.caminho + @"\FileT22.txt", Form1.USB + @"\FileT22.txt", true);
                File.Copy(Form1.caminho + @"\FileT23.txt", Form1.USB + @"\FileT23.txt", true);
                File.Copy(Form1.caminho + @"\FileT24.txt", Form1.USB + @"\FileT24.txt", true);
                File.Copy(Form1.caminho + @"\Comentarios.txt", Form1.USB + @"\Comentarios.txt", true);
                MessageBox.Show("Transferido com sucesso!");
                
                //var usbDevices = GetUSBDevices();
                
            }

            else
            {
                MessageBox.Show("Não foi possível transferir!");
            }

         
            Close();
        }
    }
}
