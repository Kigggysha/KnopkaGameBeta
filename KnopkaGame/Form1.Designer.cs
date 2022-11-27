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
            this.Start = new System.Windows.Forms.PictureBox();
            this.Continue = new System.Windows.Forms.PictureBox();
            this.Settings = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.Laptop = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Continue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Laptop)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Transparent;
            this.Start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Start.BackgroundImage")));
            this.Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Start.Location = new System.Drawing.Point(65, 65);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(435, 115);
            this.Start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Start.TabIndex = 0;
            this.Start.TabStop = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            this.Start.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Start_MouseDown);
            this.Start.MouseEnter += new System.EventHandler(this.Start_MouseHover);
            this.Start.MouseLeave += new System.EventHandler(this.Start_MouseLeave);
            this.Start.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Start_MouseUp);
            // 
            // Continue
            // 
            this.Continue.BackColor = System.Drawing.Color.Transparent;
            this.Continue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Continue.BackgroundImage")));
            this.Continue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Continue.Location = new System.Drawing.Point(65, 200);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(435, 115);
            this.Continue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Continue.TabIndex = 1;
            this.Continue.TabStop = false;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            this.Continue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Continue_MouseDown);
            this.Continue.MouseEnter += new System.EventHandler(this.Continue_MouseEnter);
            this.Continue.MouseLeave += new System.EventHandler(this.Continue_MouseLeave);
            this.Continue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Continue_MouseUp);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Settings.BackgroundImage")));
            this.Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Settings.Location = new System.Drawing.Point(65, 335);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(435, 115);
            this.Settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Settings.TabIndex = 2;
            this.Settings.TabStop = false;
            this.Settings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Settings_MouseDown);
            this.Settings.MouseEnter += new System.EventHandler(this.Settings_MouseEnter);
            this.Settings.MouseLeave += new System.EventHandler(this.Settings_MouseLeave);
            this.Settings.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Settings_MouseUp);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit.BackgroundImage")));
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit.Location = new System.Drawing.Point(65, 475);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(435, 115);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 3;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Exit_MouseDown);
            this.Exit.MouseEnter += new System.EventHandler(this.Exit_MouseEnter);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            this.Exit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Exit_MouseUp);
            // 
            // Laptop
            // 
            this.Laptop.BackColor = System.Drawing.Color.Transparent;
            this.Laptop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Laptop.BackgroundImage")));
            this.Laptop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Laptop.Location = new System.Drawing.Point(150, 163);
            this.Laptop.Name = "Laptop";
            this.Laptop.Size = new System.Drawing.Size(490, 316);
            this.Laptop.TabIndex = 4;
            this.Laptop.TabStop = false;
            this.Laptop.Visible = false;
            this.Laptop.Click += new System.EventHandler(this.Laptop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 701);
            this.Controls.Add(this.Laptop);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.Start);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "KnopkaGame";
            ((System.ComponentModel.ISupportInitialize)(this.Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Continue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Laptop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox Start;
        private PictureBox Continue;
        private PictureBox Settings;
        private PictureBox Exit;
        private PictureBox Laptop;
    }
}