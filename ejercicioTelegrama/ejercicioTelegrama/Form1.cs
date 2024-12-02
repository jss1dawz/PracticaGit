namespace ejercicioTelegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numPalabras = 0;
            double coste;

            textoTelegrama = txtTelegrama.Text;

            if (rbUrgente.Checked)
            {
                tipoTelegrama = 'u';
            }
            else if (rbOrdinario.Checked)
            {
                tipoTelegrama = 'o';
            }

            numPalabras = textoTelegrama.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;

            if (tipoTelegrama == 'o')
            {
                coste = numPalabras <= 10 ? 2.5 : 0.5 * numPalabras;
            }
            else if (tipoTelegrama == 'u')
            {
                coste = numPalabras <= 10 ? 5 : 5 + 0.75 * (numPalabras - 10);
            }
            else
            {
                coste = 0;
            }

            txtPrecio.Text = $"{coste} euros";
        }
    }
}