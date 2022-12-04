namespace KnopkaGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Continue = new System.Windows.Forms.PictureBox();
            this.Settings = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.Laptop = new System.Windows.Forms.PictureBox();
            this.Cup = new System.Windows.Forms.PictureBox();
            this.SettingsWindow = new System.Windows.Forms.PictureBox();
            this.SettingsClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Continue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Laptop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsClose)).BeginInit();
            this.SuspendLayout();
            // 
            // Continue
            // 
            this.Continue.BackColor = System.Drawing.Color.Transparent;
            this.Continue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Continue.Location = new System.Drawing.Point(57, 140);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(435, 115);
            this.Continue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Continue.TabIndex = 1;
            this.Continue.TabStop = false;
            this.Continue.Tag = "knopki";
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            this.Continue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Continue_MouseDown);
            this.Continue.MouseEnter += new System.EventHandler(this.Continue_MouseEnter);
            this.Continue.MouseLeave += new System.EventHandler(this.Continue_MouseLeave);
            this.Continue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Continue_MouseUp);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Settings.Location = new System.Drawing.Point(57, 275);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(435, 115);
            this.Settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Settings.TabIndex = 2;
            this.Settings.TabStop = false;
            this.Settings.Tag = "knopki";
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            this.Settings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Settings_MouseDown);
            this.Settings.MouseEnter += new System.EventHandler(this.Settings_MouseEnter);
            this.Settings.MouseLeave += new System.EventHandler(this.Settings_MouseLeave);
            this.Settings.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Settings_MouseUp);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit.Location = new System.Drawing.Point(57, 415);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(435, 115);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 3;
            this.Exit.TabStop = false;
            this.Exit.Tag = "knopki";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Exit_MouseDown);
            this.Exit.MouseEnter += new System.EventHandler(this.Exit_MouseEnter);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            this.Exit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Exit_MouseUp);
            // 
            // Laptop
            // 
            this.Laptop.BackColor = System.Drawing.Color.Transparent;
            this.Laptop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Laptop.Location = new System.Drawing.Point(-4, 69);
            this.Laptop.Name = "Laptop";
            this.Laptop.Size = new System.Drawing.Size(666, 440);
            this.Laptop.TabIndex = 4;
            this.Laptop.TabStop = false;
            this.Laptop.Tag = "Items";
            this.Laptop.Visible = false;
            this.Laptop.Click += new System.EventHandler(this.Laptop_Click);
            // 
            // Cup
            // 
            this.Cup.BackColor = System.Drawing.Color.Transparent;
            this.Cup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cup.Location = new System.Drawing.Point(560, 248);
            this.Cup.Name = "Cup";
            this.Cup.Size = new System.Drawing.Size(127, 142);
            this.Cup.TabIndex = 5;
            this.Cup.TabStop = false;
            this.Cup.Tag = "Items";
            this.Cup.Visible = false;
            // 
            // SettingsWindow
            // 
            this.SettingsWindow.BackColor = System.Drawing.Color.Transparent;
            this.SettingsWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsWindow.Location = new System.Drawing.Point(120, 70);
            this.SettingsWindow.Name = "SettingsWindow";
            this.SettingsWindow.Size = new System.Drawing.Size(960, 540);
            this.SettingsWindow.TabIndex = 6;
            this.SettingsWindow.TabStop = false;
            this.SettingsWindow.Tag = "SettingsMenuUI";
            this.SettingsWindow.Visible = false;
            // 
            // SettingsClose
            // 
            this.SettingsClose.BackColor = System.Drawing.Color.Transparent;
            this.SettingsClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsClose.Location = new System.Drawing.Point(1005, 90);
            this.SettingsClose.Name = "SettingsClose";
            this.SettingsClose.Size = new System.Drawing.Size(45, 45);
            this.SettingsClose.TabIndex = 7;
            this.SettingsClose.TabStop = false;
            this.SettingsClose.Tag = "SettingsMenuUI";
            this.SettingsClose.Visible = false;
            this.SettingsClose.Click += new System.EventHandler(this.SettingsClose_Click);
            this.SettingsClose.MouseEnter += new System.EventHandler(this.SettingsClose_MouseEnter);
            this.SettingsClose.MouseLeave += new System.EventHandler(this.SettingsClose_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 701);
            this.Controls.Add(this.SettingsClose);
            this.Controls.Add(this.Cup);
            this.Controls.Add(this.Laptop);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.SettingsWindow);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "KnopkaGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            ((System.ComponentModel.ISupportInitialize)(this.Continue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Laptop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox Continue;
        private PictureBox Settings;
        private PictureBox Exit;
        private PictureBox Laptop;
        private PictureBox Cup;
        private PictureBox SettingsWindow;
        private PictureBox SettingsClose;
    }
}