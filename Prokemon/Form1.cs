using Prokemon.pokemons;

namespace Prokemon
{
    public partial class Form1 : Form
    {
        List<Prokemon1> pokemons;
        Prokemon1 selectedPokemon;
        public Form1()
        {
            InitializeComponent();

            pokemons = new List<Prokemon1>();
            pokemons.Add(new Squirtle());
            pokemons.Add(new Charmander());


        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[0];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.textBoxName.Text = selectedPokemon.getName();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[1];
            this.textBoxName.Text = selectedPokemon.getName();
            this.pictureBox1.Image = selectedPokemon.getImage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[2];
            this.textBoxName.Text = selectedPokemon.getName();
            this.pictureBox1.Image = selectedPokemon.getImage();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[3];
            this.textBoxName.Text = selectedPokemon.getName();
            this.pictureBox1.Image = selectedPokemon.getImage();
        }
    }
}