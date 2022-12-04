using System;
using System.IO;
using System.Numerics;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Data.Sqlite;
using System.Reflection.Emit;

namespace KnopkaGame
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer ButtonSelect = new System.Media.SoundPlayer("../KnopkaGame/Sounds/ButtonSelect.wav"); //play sound of selected button
        System.Media.SoundPlayer ButtonPush = new System.Media.SoundPlayer("../KnopkaGame/Sounds/ButtonPush.wav"); //play sound of pushed button
        System.Media.SoundPlayer BackMusic = new System.Media.SoundPlayer("../KnopkaGame/Sounds/BackMusic.wav");

        string ConnectionString = "DataSource=../KnopkaGame/Base/Save.db"; //Connection string for sqlite connect
        object id;
        Boolean SFX = true, MusicSound = true;
        public Form1()
        {
            InitializeComponent();
            string sqlExpression = "SELECT * FROM SaveINFO"; //sql expression for db access
            using (var connection = new SqliteConnection(ConnectionString)) //creating connection block to get information about whether the game was started before
            {
                connection.Open();//open db access

                SqliteCommand command = new SqliteCommand(sqlExpression, connection); //creating command for reader
                using (SqliteDataReader reader = command.ExecuteReader()) // Another using block for reader
                {
                    reader.Read(); // Reading first line of columns
                    id = reader["EndingGet"]; // Get statement of whether ending was gotten
                }
                connection.Close();//close db access
            }
            if (Convert.ToBoolean(id)) //if ending was gotten 
            {
                Continue.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/Continue.png"); //continue button replaces start game button
            }
            Settings.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/Settings.png");
            Exit.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/Exit.png");
            BackMusic.Play();
        }
        //Start baton click function
        //Change picture when mouse located on start button
        //Change picture when mouse move out start button

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
            using (var connection = new SqliteConnection(ConnectionString)) //creating connection block to update information about game starting
            {
                connection.Open();//open db access
                SqliteCommand insert = new SqliteCommand("UPDATE SaveINFO SET EndingGet=1 WHERE Ending='GAMESTART'", connection); //creating command for updating info
                insert.ExecuteNonQuery(); //inserting updates
                connection.Close();//close db access
            }
            ButtonPush.Play(); //sound player 
            Continue.Visible = false;//when the game starts the buttons are hidden
            Settings.Visible = false;
            Exit.Visible = false;
            this.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/TableBezWindows.png");//Changing form backgroung 
            Laptop.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/Laptop.png");
            Cup.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/Cup.png");
            Cup.Visible = true;
            Laptop.Visible = true;
        }

        private void Laptop_Click(object sender, EventArgs e)
        {
            Laptop.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/LaptopButtonPressed.png");
            this.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/TableWindows10Red.png");
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Continue.Visible = true;
                Settings.Visible = true;
                Exit.Visible = true;
                foreach (Control items in this.Controls)
                {
                    if (items is PictureBox && ((string)items.Tag == "Items" || ((string)items.Tag == "SettingsMenuUI")))
                    {
                        items.Visible = false;
                    }
                }
            }
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Continue.Visible = false;//when the game starts the buttons are hidden
            Settings.Visible = false;
            Exit.Visible = false;
            SettingsWindow.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/SettingsWindow.png");
            SettingsClose.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/ExitButton.png");
            if (SFX)
            {
                SoundFX.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/SoundOn.png");
            }
            else
            {
                SoundFX.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/SoundOff.png");
            }
            if (MusicSound)
            {
                Music.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/SoundOn.png");
            }
            else
            {
                Music.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/SoundOff.png");
            }
            SettingsClose.Visible = true;
            SoundFX.Visible = true;
            Music.Visible = true;
            SettingsWindow.Visible = true;
        }

        private void SettingsClose_MouseEnter(object sender, EventArgs e)
        {
            SettingsClose.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/ExitButtonLight.png");
            ButtonSelect.Play();
        }

        private void SettingsClose_MouseLeave(object sender, EventArgs e)
        {
            SettingsClose.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/ExitButton.png");
        }

        private void SoundFX_Click(object sender, EventArgs e)
        {
            if (SFX)
            {
                SFX = false;
                SoundFX.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/SoundOff.png");
                ButtonSelect.SoundLocation = "../KnopkaGame/Sounds/Silence.wav";
                ButtonPush.SoundLocation = "../KnopkaGame/Sounds/Silence.wav";
            }
            else
            {
                SFX = true;
                SoundFX.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/SoundOn.png");
                ButtonSelect.SoundLocation = "../KnopkaGame/Sounds/ButtonSelect.wav";
                ButtonPush.SoundLocation = "../KnopkaGame/Sounds/ButtonPush.wav";
            }
        }

        private void Music_Click(object sender, EventArgs e)
        {
            if (MusicSound)
            {
                MusicSound = false;
                Music.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/SoundOff.png");
                BackMusic.SoundLocation = "../KnopkaGame/Sounds/Silence.wav";
            }
            else
            {
                MusicSound = true;
                Music.BackgroundImage = Image.FromFile("../KnopkaGame/Textures/SoundOn.png");
                BackMusic.SoundLocation = "../KnopkaGame/Sounds/BackMusic.wav";
            }
        }

        private void SettingsClose_Click(object sender, EventArgs e)
        {
            SettingsClose.Visible = false;
            SettingsWindow.Visible = false;
            SoundFX.Visible = false;
            Music.Visible = false;
            Continue.Visible = true;
            Settings.Visible = true;
            Exit.Visible = true;
        }

    }
}