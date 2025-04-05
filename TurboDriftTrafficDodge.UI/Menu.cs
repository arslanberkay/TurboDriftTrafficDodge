using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurboDriftTrafficDodge.UI
{
    public partial class Menu : Form
    {
        ArabaYarisAlani ArabaYarisAlanFormu;

        public Menu(ArabaYarisAlani arabaYarisAlaniFormu)
        {
            InitializeComponent();
            ArabaYarisAlanFormu = arabaYarisAlaniFormu;
        }

        bool sesAcikMi = false;
        private void btnSesKapa_Click(object sender, EventArgs e)
        {
            sesAcikMi = !sesAcikMi;
            if (sesAcikMi)
            {
                ArabaYarisAlanFormu.sp.Stop();
                btnSesKapa.ImageIndex = 1;
            }
            else
            {
                ArabaYarisAlanFormu.sp.Play();
                btnSesKapa.ImageIndex = 0;
            }
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            ArabaYarisAlani arabaYarisAlani = new ArabaYarisAlani();
            arabaYarisAlani.Show();
            this.Hide();
        }
    }
}
