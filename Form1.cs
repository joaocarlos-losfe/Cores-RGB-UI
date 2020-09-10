using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Definição_e_alteração_de_cores
{
    public partial class Form1 : Form
    {
        int R = 0; int G = 0; int B = 0;

        int cc = 0;

        List<string> cores = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ct_vermelho.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            ct_verde.Text = trackBar2.Value.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            ct_azul.Text = trackBar3.Value.ToString();
        }

        private void ct_vermelho_TextChanged(object sender, EventArgs e)
        {

            if (ct_vermelho.Text.Length == 0)
                ct_vermelho.Text = "0";

            if(ct_vermelho.Text!= null && int.Parse(ct_vermelho.Text) < 256)
                trackBar1.Value = int.Parse(ct_vermelho.Text);

            R = trackBar1.Value;

            mudarCorPainel();
        }

        private void ct_verde_TextChanged(object sender, EventArgs e)
        {
            if (ct_verde.Text.Length == 0)
                ct_verde.Text = "0";

            if (ct_verde.Text != null && int.Parse(ct_verde.Text) < 256)
                trackBar2.Value = int.Parse(ct_verde.Text);

            G = trackBar2.Value;

            mudarCorPainel();
        }

        private void ct_azul_TextChanged(object sender, EventArgs e)
        {
            if (ct_azul.Text.Length == 0)
                ct_azul.Text = "0";

            if (ct_azul.Text != null && int.Parse(ct_azul.Text) < 256)
                trackBar3.Value = int.Parse(ct_azul.Text);

            B = trackBar3.Value;

            mudarCorPainel();
        }
        private void mudarCorPainel()
        {
            if (int.Parse(ct_vermelho.Text) > 255 || int.Parse(ct_verde.Text) > 255 || int.Parse(ct_azul.Text) > 255)
                erro_texto_rgb.Visible = true;
            else
                erro_texto_rgb.Visible = false;
            
            painelCor.BackColor = Color.FromArgb(R, B, G);
            R0.Text = R.ToString();
            G1.Text = G.ToString();
            B2.Text = B.ToString();
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            cores.Add("Cor" + " " + cc +": " + trackBar1.Value.ToString() + "," + trackBar2.Value.ToString() + "," + trackBar3.Value.ToString());

            Console.WriteLine("------------");
            Console.WriteLine(DateTime.Now.DayOfWeek);
            foreach (string cor in cores)
            {
                Console.WriteLine(cor);
            }
            
            cc++;
            numero_de_cores_salvas.Text = cc.ToString();
        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            saveFileDialog1.Title = "Salvar como...";

            string DiretorioNomeArquivo = saveFileDialog1.FileName + ".txt";
            
            Console.WriteLine(DiretorioNomeArquivo);

            using (File.Create(DiretorioNomeArquivo)){}

            File.WriteAllLines(DiretorioNomeArquivo, cores);

            MessageBox.Show("Salvo em " + DiretorioNomeArquivo);

            Process.Start("notepad", DiretorioNomeArquivo);
        }
    }
}
