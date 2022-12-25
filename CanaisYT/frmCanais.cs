using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CanaisYT
{
    public partial class frmCanais : Form
    {
        public frmCanais()
        {
            InitializeComponent();
            
        }

        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);


        private void frmCanais_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }


        private void btnMW_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process pStart = new System.Diagnostics.Process();
            pStart.StartInfo = new System.Diagnostics.ProcessStartInfo(@"https://www.youtube.com/@MWInformatica/videos");
            pStart.Start();
        }

        private void btnTecnoArt_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process pStart = new System.Diagnostics.Process();
            pStart.StartInfo = new System.Diagnostics.ProcessStartInfo(@"https://www.youtube.com/@tecnoart101/videos");
            pStart.Start();

        }

        private void btnGarimpandoagambiara_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process pStart = new System.Diagnostics.Process();
            pStart.StartInfo = new System.Diagnostics.ProcessStartInfo(@"https://www.youtube.com/@Garimpandoagambiarra/videos");
            pStart.Start();
        }

        private void btnTecmundo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process pStart = new System.Diagnostics.Process();
            pStart.StartInfo = new System.Diagnostics.ProcessStartInfo(@"https://www.youtube.com/@tecmundo/videos");
            pStart.Start();
        }


        private void btnPCdoFafa_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process pStart = new System.Diagnostics.Process();
            pStart.StartInfo = new System.Diagnostics.ProcessStartInfo(@"https://www.youtube.com/@pcdofafa/videos");
            pStart.Start();
        }
        private void btnOlharDigital_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process pStart = new System.Diagnostics.Process();
            pStart.StartInfo = new System.Diagnostics.ProcessStartInfo(@"https://www.youtube.com/@olhardigital/videos");
            pStart.Start();
        }
        private void btnSafesrc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process pStart = new System.Diagnostics.Process();
            pStart.StartInfo = new System.Diagnostics.ProcessStartInfo(@"https://www.youtube.com/@safesrc/videos");
            pStart.Start();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
    
}







