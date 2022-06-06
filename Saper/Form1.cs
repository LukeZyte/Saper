namespace Saper
{
    public partial class Saper : Form
    { 
        public Saper()
        {
            InitializeComponent();
            Grid.InitMap(this, 15, 40, 20);
        }

        private void easyDiff_Click(object sender, EventArgs e)
        {
            Grid.RemoveMap(this);
            Grid.InitMap(this, 10, 50, 12);
            Width = 528;
            Height = 574;
        }

        private void mediumDiff_Click(object sender, EventArgs e)
        {
            Grid.RemoveMap(this);
            Grid.InitMap(this, 15, 45, 25);
            Width = 701;
            Height = 750;
        }

        private void hardDiff_Click(object sender, EventArgs e)
        {
            Grid.RemoveMap(this);
            Grid.InitMap(this, 20, 40, 50);
            Width = 827;
            Height = 874;
        }

        private void expertDiff_Click(object sender, EventArgs e)
        {
            Grid.RemoveMap(this);
            Grid.InitMap(this, 25, 35, 100);
            Width = 901;
            Height = 949;
        }

        private void hardcoreDiff_Click(object sender, EventArgs e)
        {
            Grid.RemoveMap(this);
            Grid.InitMap(this, 30, 30, 200);
            Width = 926;
            Height = 974;
        }

        private void Saper_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The game \"Sapers\" was written in C# using WindowsForms \n\n2022,\nAuthor: £ukasz Jarz¹b", "About Saper");
        }
    }
}