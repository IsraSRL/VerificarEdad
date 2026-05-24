namespace VerificarEdad
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnContarClicked(object? sender, EventArgs e)
        {
            int edad = Convert.ToInt32(txtEdad.Text);

            if(edad >= 18)
            {
                lblResultado.Text = "Es mayor de edad";
                lblResultado.TextColor = Color.FromRgb(120, 200, 120);
            }
            else
            {
                lblResultado.Text = "Es menor de edad";
                lblResultado.TextColor = Color.FromRgb(200, 120, 120);
            }
        }
    }
}
