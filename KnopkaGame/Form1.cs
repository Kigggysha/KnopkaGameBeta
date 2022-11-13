using System.Windows.Forms;

namespace KnopkaGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Start.BackColor = Color.Transparent;
        }
        private void Start_Click(object sender, EventArgs e)
        {

        }
        //Change picture when mouse located on start button
        private void Start_MouseHover(object sender, EventArgs e)
        {
            Start.BackgroundImage = Image.FromFile("D:/C#/KnopkaGameBeta/KnopkaGame/KnopkaGame/Textures/StartButtonSelect.png");
        }
        //Change picture when mouse move out start button
        private void Start_MouseLeave(object sender, EventArgs e)
        {
            Start.BackgroundImage = Image.FromFile("D:/C#/KnopkaGameBeta/KnopkaGame/KnopkaGame/Textures/StartButton.png");
        }
    }
}