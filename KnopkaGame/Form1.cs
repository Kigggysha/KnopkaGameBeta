using System.IO;
using System.Numerics;
using System.Windows.Forms;
using System.Threading;

namespace KnopkaGame
{
    public partial class Form1 : Form
    {
        //play sound of selected button
        System.Media.SoundPlayer ButtonSelect = new System.Media.SoundPlayer("../KnopkaGame/Sounds/ButtonSelect.wav");
        //play sound of pushed button
        System.Media.SoundPlayer ButtonPush = new System.Media.SoundPlayer("../KnopkaGame/Sounds/ButtonPush.wav");
        public Form1()
        {
            InitializeComponent();
            Start.BackColor = Color.Transparent;
        }
        //Start button click function
        private void Start_Click(object sender, EventArgs e)
        {
            //sound player
            ButtonPush.Play();
            Start.Visible = false;
            Continue.Visible = false;
            Settings.Visible = false;
            Exit.Visible = false;
            this.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/TableWindows10.png");
            Laptop.Visible = true;
        }
        //Change picture when mouse located on start button
        private void Start_MouseHover(object sender, EventArgs e)
        {
            Start.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/StartButtonSelect.png");
            ButtonSelect.Play();
        }
        //Change picture when mouse move out start button
        private void Start_MouseLeave(object sender, EventArgs e)
        {
            Start.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/StartButton.png");
        }

        private void Continue_MouseEnter(object sender, EventArgs e)
        {
            Continue.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/ContinueSelect.png");
            ButtonSelect.Play();
        }

        private void Continue_MouseLeave(object sender, EventArgs e)
        {
            Continue.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/Continue.png");
        }

        private void Settings_MouseEnter(object sender, EventArgs e)
        {
            Settings.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/SettingsSelect.png");
            ButtonSelect.Play();
        }

        private void Settings_MouseLeave(object sender, EventArgs e)
        {
            Settings.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/Settings.png");
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            Exit.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/ExitSelect.png");
            ButtonSelect.Play();
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/Exit.png");
        }

        private void Start_MouseUp(object sender, MouseEventArgs e)
        {
            Start.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/StartButtonSelect.png");
        }

        private void Start_MouseDown(object sender, MouseEventArgs e)
        {
            Start.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/StartButtonPush.png");
        }

        private void Continue_MouseDown(object sender, MouseEventArgs e)
        {
            Continue.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/ContinuePush.png");
            ButtonPush.Play();
        }

        private void Continue_MouseUp(object sender, MouseEventArgs e)
        {
            Continue.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/ContinueSelect.png");
        }

        private void Settings_MouseDown(object sender, MouseEventArgs e)
        {
            Settings.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/SettingsPush.png");
            ButtonPush.Play();
        }

        private void Settings_MouseUp(object sender, MouseEventArgs e)
        {
            Settings.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/SettingsSelect.png");
        }

        private void Exit_MouseDown(object sender, MouseEventArgs e)
        {
            Exit.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/ExitPush.png");
        }

        private void Exit_MouseUp(object sender, MouseEventArgs e)
        {
            Exit.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/ExitSelect.png");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            ButtonPush.Play();
            Thread.Sleep(400);
            this.Close();
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            Start.Visible = false;
            Continue.Visible = false;
            Settings.Visible = false;
            Exit.Visible = false;
            this.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/TableWindows10.png");
        }

        private void Laptop_Click(object sender, EventArgs e)
        {
            Laptop.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/LaptopButtonPressed.png");
            this.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/TableWindows10Red.png");
        }
    }
}