namespace Pokedex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Buscar_Click(object sender, EventArgs e)
        {

           
            try
            {
                long numero = Convert.ToInt64(textNumero.Text);

                if (numero <= 0)
                {
                    MessageBox.Show("El numero ingresado No es valido");
                }
                else
                {
                    using var cliente = new HttpClient();
                    var resultado = await cliente.GetStringAsync($"https://pokeapi.co/api/v2/pokemon/{numero}/");

                    var pokemon = Welcome.FromJson(resultado);
                    //Imagen
                    ImagenPokemon.Load(pokemon.Sprites.FrontDefault.OriginalString);
                    //Datos
                    textNombre.Text = pokemon.Name;
                    textNumber.Text = pokemon.Order.ToString();
                    textTipo.Text = pokemon.Types[0].Type.Name;
                    //Movimientos
                    textMov1.Text = pokemon.Moves[0].MoveMove.Name;
                    textMov2.Text = pokemon.Moves[1].MoveMove.Name;
                    textMov3.Text = pokemon.Moves[2].MoveMove.Name;
                    textMov4.Text = pokemon.Moves[3].MoveMove.Name;
                    //Habilidades
                    textVida.Text = pokemon.Stats[0].BaseStat.ToString();
                    textAtaque.Text = pokemon.Stats[1].BaseStat.ToString();
                    textDefensa.Text = pokemon.Stats[2].BaseStat.ToString();
                    textVelocidad.Text = pokemon.Stats[5].BaseStat.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("!Error Inesperado¡\n Intente de nuevo");
            }
            
            



        }

        private void labelCerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}