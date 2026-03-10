using System.Diagnostics.Eventing.Reader;

namespace Appimc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double alt, peso, imc;
            alt = (double)numAltura.Value;
            peso = (double)numPeso.Value;


            imc = peso / Math.Pow(alt, 2);

            lblImc.Text = $"IMC: {imc:F2} kg/m²";//lá

            lblClassif.Text = Classificar(imc);
        }
        string Classificar(double imc)
        {
            if (imc < 18.5)
                return "Abaixo do Peso";
            if (imc < 25)
                return "peso normal";
            if (imc < 30)
                return "Sobrepeso";
            if (imc < 35)
                return "obesidade I";
            if (imc < 40)
                return "obesidade II";
            return "Obesidade Mórbida";

        }
        private void numAltura_ValueChanged(object sender, EventArgs e)
        {
            decimal a = numAltura.Value;
            //if (!(a == 0))//true
            //btCalcular.Enabled = true;
            //else//false
            //btCalcular.Enabled = false;
            btCalcular.Enabled = (a != 0);
        }

        private void lblClassif_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bem-vindo à Calculadora de IMC");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Deseja realmente sair?", "Calculadora de IMC", MessageBoxButtons.YesNo);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Tchau!");
        }
    }
}
