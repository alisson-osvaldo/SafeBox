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

namespace SafeBox.Forms
{
    public partial class FrmInfo : Form
    {
        public FrmInfo()
        {
            InitializeComponent();
        }

        private void btnGitHub_Click(object sender, EventArgs e)
        {
            string target = "https://github.com/alisson-osvaldo";

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = target,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                {
                    MessageBox.Show(noBrowser.Message);
                }
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void btnLinkedin_Click(object sender, EventArgs e)
        {
            string target = "https://www.linkedin.com/in/alisson-osvaldo-1420161aa/";

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = target,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                {
                    MessageBox.Show(noBrowser.Message);
                }
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string target = "https://www.linkedin.com/in/alisson-osvaldo-1420161aa/";

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = target,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                {
                    MessageBox.Show(noBrowser.Message);
                }
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            lblVideo.ForeColor = Color.LawnGreen;
            lblVideo.Location = new Point(490, 176);
            lblVideo.Text = "Muito obrigado por utilizaro o SafeBox";
            btnVideo.IconColor = Color.LawnGreen;

            axWindowsMediaPlayer1.Visible = true;
            //Adicionar aqui método de busca recursiva em diretórios (pastas) e arquivos, para localizar o URL do video. 
            axWindowsMediaPlayer1.URL = @"D:\Save Projects\Estudo CSharp POO\SafeBox\SafeBox\video\duck.mp4";           
        }
    }   
}
