namespace Practica31Github
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Este es el codigo que hace Andres. El programa funciona ahora correctamente.
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numPalabras = 0;
            double coste;
            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            if (cbUrgente.Checked)
                tipoTelegrama = 'u';
            else
                tipoTelegrama = 'o';
            //Obtengo el n�mero de palabras que forma el telegrama
            //numPalabras = textoTelegrama.Length;



            foreach (char c in textoTelegrama)
            {
                if (c == ' ')
                    numPalabras += 1;
                else if (c == '.')
                    numPalabras += 1;
                else if (c == ',')
                    numPalabras += 1;
            }

            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    coste = 2.5 + (0.5 * (numPalabras - 10));
            else
            //Si el telegrama es urgente
            if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            else
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";
        }
    }
    
}