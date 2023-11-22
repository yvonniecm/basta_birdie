using NAudio.CoreAudioApi;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VoiceCont_FlapBird
{
    public partial class Form1 : Form
    {
        int score = 0; // default score integer set to 0
        public Form1()
        {
            InitializeComponent();
            MMDeviceEnumerator en = new MMDeviceEnumerator();
            var devices = en.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
            comboBox1.Items.AddRange(devices.ToArray());
            gameoverlogo.Visible = false;

        }

        public int voice;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            gameoverlogo.Visible = false;
            SoundPlayer ss = new SoundPlayer(@"D:\Codes\GameDev\VoiceCont_FlapBird-master\VoiceCont_FlapBird\Assets\ThemeSong.wav");
            ss.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                var selected = (MMDevice)comboBox1.SelectedItem;
                voice = (int)(selected.AudioMeterInformation.MasterPeakValue * 100 + 0.5);
                progressBar1.Value = voice;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        // obstacles 
        void movehurdle()
        {
            if (good1.Left > 0)
            {
                good1.Left += -2;
                // score++;
            }
            else
            {
                good1.Left = 800;
            }

            if (good2.Left > 0)
            {
                good2.Left += -2;
                //score++;
            }
            else
            {
                good2.Left = 1000;
            }

            if (bad1.Left > 0)
            {
                bad1.Left += -2;
                // score++;
            }
            else
            {
                bad1.Left = 1200;
            }
            if (good3.Left > 0)
            {
                good3.Left += -2;
            }
            else
            {
                good3.Left = 800;
            }

            if (good4.Left > 0)
            {
                good4.Left += -2;
            }
            else
            {
                good4.Left = 1000;
            }

            if (bad2.Left > 0)
            {
                bad2.Left += -2;
            }
            else
            {
                bad2.Left = 1200;
            }

            if (bad1.Bounds.IntersectsWith(bird.Bounds) || bad2.Bounds.IntersectsWith(bird.Bounds) ||
                 floor1.Bounds.IntersectsWith(bird.Bounds) || floor2.Bounds.IntersectsWith(bird.Bounds) ||
                 floor1.Bounds.IntersectsWith(bird.Bounds))
            {
                EndGame();
            }
            else if (good1.Bounds.IntersectsWith(bird.Bounds))
            {
                good1.Left = 800;
                score += 100;
                Score.Text = "Score: " + score;
            }
            else if (good2.Bounds.IntersectsWith(bird.Bounds))
            {
                good2.Left = 1000;
                score += 100;
                Score.Text = "Score: " + score;
            }
            else if (good3.Bounds.IntersectsWith(bird.Bounds))
            {
                good3.Left = 800;
                score += 100;
                Score.Text = "Score: " + score;
            }
            else if (good4.Bounds.IntersectsWith(bird.Bounds))
            {
                good4.Left = 1000;
                score += 100;
                Score.Text = "Score: " + score;
            }
        }

        // game over if collide with birdie
        void EndGame()
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            gameoverlogo.Visible = true;
            //Score.Text += score;
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            if (voice > 10 && bird.Top > 15)
            {
                bird.Top += -3;

            }
            else
            {
                if (bird.Top < 430)
                    bird.Top += 3;
            }

            movehurdle();
            // gameoverappear();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void good3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void pictureBox1_Click_3(object sender, EventArgs e)
        {

        }


    }
}