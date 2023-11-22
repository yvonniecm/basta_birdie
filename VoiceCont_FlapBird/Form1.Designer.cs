namespace VoiceCont_FlapBird
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            progressBar1 = new ProgressBar();
            button1 = new Button();
            comboBox1 = new ComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            bird = new PictureBox();
            timer2 = new System.Windows.Forms.Timer(components);
            good1 = new PictureBox();
            bad1 = new PictureBox();
            gameoverlogo = new PictureBox();
            good2 = new PictureBox();
            floor1 = new PictureBox();
            floor2 = new PictureBox();
            floor3 = new PictureBox();
            good3 = new PictureBox();
            good4 = new PictureBox();
            bad2 = new PictureBox();
            button2 = new Button();
            Score = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)good1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bad1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gameoverlogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)good2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)floor1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)floor2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)floor3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)good3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)good4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bad2).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(14, 7);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(345, 23);
            progressBar1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(502, 7);
            button1.Name = "button1";
            button1.Size = new Size(94, 23);
            button1.TabIndex = 1;
            button1.Text = "Start Game";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(365, 7);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // bird
            // 
            bird.Image = (Image)resources.GetObject("bird.Image");
            bird.Location = new Point(34, 244);
            bird.Name = "bird";
            bird.Size = new Size(34, 24);
            bird.SizeMode = PictureBoxSizeMode.AutoSize;
            bird.TabIndex = 3;
            bird.TabStop = false;
            bird.Click += pictureBox1_Click;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // good1
            // 
            good1.BackColor = Color.Transparent;
            good1.Image = Properties.Resources.pipe_green;
            good1.Location = new Point(218, 335);
            good1.Name = "good1";
            good1.Size = new Size(51, 92);
            good1.TabIndex = 4;
            good1.TabStop = false;
            good1.Click += pictureBox1_Click_1;
            // 
            // bad1
            // 
            bad1.BackColor = Color.Transparent;
            bad1.Image = (Image)resources.GetObject("bad1.Image");
            bad1.Location = new Point(710, 180);
            bad1.Name = "bad1";
            bad1.Size = new Size(52, 247);
            bad1.TabIndex = 6;
            bad1.TabStop = false;
            bad1.Click += pictureBox1_Click_2;
            // 
            // gameoverlogo
            // 
            gameoverlogo.BackColor = Color.Transparent;
            gameoverlogo.Image = Properties.Resources.gameover;
            gameoverlogo.Location = new Point(276, 68);
            gameoverlogo.Name = "gameoverlogo";
            gameoverlogo.Size = new Size(190, 46);
            gameoverlogo.TabIndex = 7;
            gameoverlogo.TabStop = false;
            // 
            // good2
            // 
            good2.BackColor = Color.Transparent;
            good2.Image = Properties.Resources.pipe_green;
            good2.Location = new Point(475, 282);
            good2.Name = "good2";
            good2.Size = new Size(52, 145);
            good2.TabIndex = 5;
            good2.TabStop = false;
            // 
            // floor1
            // 
            floor1.BackColor = Color.Transparent;
            floor1.Image = Properties.Resources._base;
            floor1.Location = new Point(-4, 416);
            floor1.Name = "floor1";
            floor1.Size = new Size(285, 111);
            floor1.TabIndex = 8;
            floor1.TabStop = false;
            // 
            // floor2
            // 
            floor2.BackColor = Color.Transparent;
            floor2.Image = Properties.Resources._base;
            floor2.Location = new Point(276, 416);
            floor2.Name = "floor2";
            floor2.Size = new Size(285, 111);
            floor2.TabIndex = 9;
            floor2.TabStop = false;
            // 
            // floor3
            // 
            floor3.BackColor = Color.Transparent;
            floor3.Image = Properties.Resources._base;
            floor3.Location = new Point(558, 416);
            floor3.Name = "floor3";
            floor3.Size = new Size(285, 111);
            floor3.TabIndex = 10;
            floor3.TabStop = false;
            // 
            // good3
            // 
            good3.BackColor = Color.Transparent;
            good3.Image = Properties.Resources.pipe_green___R;
            good3.Location = new Point(217, -101);
            good3.Name = "good3";
            good3.Size = new Size(52, 320);
            good3.TabIndex = 11;
            good3.TabStop = false;
            good3.Click += good3_Click;
            // 
            // good4
            // 
            good4.BackColor = Color.Transparent;
            good4.Image = Properties.Resources.pipe_green___R;
            good4.Location = new Point(475, -164);
            good4.Name = "good4";
            good4.Size = new Size(52, 321);
            good4.TabIndex = 12;
            good4.TabStop = false;
            // 
            // bad2
            // 
            bad2.BackColor = Color.Transparent;
            bad2.Image = Properties.Resources.pipe_red___R;
            bad2.Location = new Point(710, -193);
            bad2.Name = "bad2";
            bad2.Size = new Size(52, 321);
            bad2.TabIndex = 13;
            bad2.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(602, 7);
            button2.Name = "button2";
            button2.Size = new Size(94, 23);
            button2.TabIndex = 14;
            button2.Text = "Restart";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Score
            // 
            Score.BackColor = Color.Wheat;
            Score.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Score.Location = new Point(287, 438);
            Score.Name = "Score";
            Score.Size = new Size(209, 43);
            Score.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(192, 255, 255);
            BackgroundImage = Properties.Resources.background_day;
            ClientSize = new Size(750, 493);
            Controls.Add(Score);
            Controls.Add(button2);
            Controls.Add(floor3);
            Controls.Add(floor2);
            Controls.Add(floor1);
            Controls.Add(gameoverlogo);
            Controls.Add(bad1);
            Controls.Add(good2);
            Controls.Add(good1);
            Controls.Add(bird);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(progressBar1);
            Controls.Add(good3);
            Controls.Add(good4);
            Controls.Add(bad2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bird).EndInit();
            ((System.ComponentModel.ISupportInitialize)good1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bad1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gameoverlogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)good2).EndInit();
            ((System.ComponentModel.ISupportInitialize)floor1).EndInit();
            ((System.ComponentModel.ISupportInitialize)floor2).EndInit();
            ((System.ComponentModel.ISupportInitialize)floor3).EndInit();
            ((System.ComponentModel.ISupportInitialize)good3).EndInit();
            ((System.ComponentModel.ISupportInitialize)good4).EndInit();
            ((System.ComponentModel.ISupportInitialize)bad2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Button button1;
        private ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox bird;
        private System.Windows.Forms.Timer timer2;
        private PictureBox good1;
        private PictureBox bad1;
        private PictureBox gameoverlogo;
        private PictureBox good2;
        private PictureBox floor1;
        private PictureBox floor2;
        private PictureBox floor3;
        private PictureBox good3;
        private PictureBox good4;
        private PictureBox bad2;
        private Button button2;
        private TextBox Score;
    }
}