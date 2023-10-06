namespace Gorjeta
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Clicked(object sender, EventArgs e)
        {
            double valorConta = Convert.ToDouble(entValorConta.Text);
            double perGorjeta = Convert.ToDouble(entPerGorjeta.Text);
            double valorGorjeta = valorConta * perGorjeta/100;
            double total = valorGorjeta + valorConta;

            vslResultado.IsVisible = true;

            lbValorGorjeta.Text = "R$ " + valorGorjeta.ToString("F2");
            lbValorTotal.Text = "R$ " + total.ToString("F2");
        }

        private void BtnNovoCalculo_Clicked(object sender, EventArgs e)
        {
            vslResultado.IsVisible = false;
            entValorConta.Text = string.Empty;
            entPerGorjeta.Text = string.Empty;
            lbValorGorjeta.Text = string.Empty;
            lbValorTotal.Text = string.Empty;
        }
    }
}