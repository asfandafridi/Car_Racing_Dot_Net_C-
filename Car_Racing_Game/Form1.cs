namespace Car_Racing_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            overLabel.Visible = false;
            btn1.Visible = false;
            //btn2.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemy(gamespeed);
            gameover();
            coins(gamespeed);
            collection();
        }

        int coinCounter;
        Random ran = new Random();
        int x, y;


        void enemy(int speed)
        {
            if (enemy1.Top >= 500)
            {
                x = ran.Next(0, 220);
                enemy1.Location = new Point(x, -10);
            }
            else
            {
                enemy1.Top += speed;
            }

            if(enemy2.Top >= 500)
            {
                x = ran.Next(220, 370);
                enemy2.Location = new Point(x, -10);
            }
            else
            {
                enemy2.Top += speed;
            }

            if (enemy3.Top >= 500)
            {
                x = ran.Next(0, 370);
                enemy3.Location = new Point(x, -10);
            }
            else
            {
                enemy3.Top += speed;
            }

           

        }

        void coins(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = ran.Next(0, 220);
                coin1.Location = new Point(x, 0);
            }
            else
            {
                coin1.Top += speed;
            }

            if (coin2.Top >= 500)
            {
                x = ran.Next(0, 220);
                coin2.Location = new Point(x, 0);
            }
            else
            {
                coin2.Top += speed;
            }

            if (coin3.Top >= 500)
            {
                x = ran.Next(0, 220);
                coin3.Location = new Point(x, 0);
            }
            else
            {
                coin3.Top += speed;
            }

            if (coin4.Top >= 500)
            {
                x = ran.Next(0, 220);
                coin4.Location = new Point(x, 0);
            }
            else
            {
                coin4.Top += speed;
            }
        }


        void gameover()
        {
            if (car1.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                overLabel.Visible = true;
                btn1.Visible = true;

            }

            if (car1.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                overLabel.Visible = true;
                btn1.Visible = true;

            }

            if (car1.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                overLabel.Visible = true;
                btn1.Visible = true;
               
            }
        }
      
        void collection()
        {

            if (car1.Bounds.IntersectsWith(coin1.Bounds))
            {
                coinCounter++;
                score1.Text = "Coins="+coinCounter.ToString();
                x = ran.Next(0, 220);
                coin1.Location = new Point(x, 0);

            }

            if (car1.Bounds.IntersectsWith(coin2.Bounds))
            {
                coinCounter++;
                score1.Text = "Coins=" + coinCounter.ToString();
                x = ran.Next(0, 220);
                coin2.Location = new Point(x, 0);

            }

            if (car1.Bounds.IntersectsWith(coin3.Bounds))
            {
                coinCounter++;
                score1.Text = "Coins=" + coinCounter.ToString();
                x = ran.Next(0, 220);
                coin3.Location = new Point(x, 0);

            }

            if (car1.Bounds.IntersectsWith(coin4.Bounds))
            {
                coinCounter++;
                score1.Text = "Coins=" + coinCounter.ToString();
                x = ran.Next(0, 220);
                coin4.Location = new Point(x, 0);



            }

        }


        void moveline(int speed)
        {
            if(pictureBox1.Top >= 500)
            {
                pictureBox1.Top = -20;
            }
            else
            {
                pictureBox1.Top += speed;
            }

            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = -20;
            }
            else
            {
                pictureBox2.Top += speed;
            }

            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = -20;
            }
            else
            {
                pictureBox3.Top += speed;
            }

            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = -20;
            }
            else
            {
                pictureBox4.Top += speed;
            }

          

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void car1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }
        int gamespeed = 2;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.Visible = false;
            Application.Restart();
        }

       
        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (car1.Left > 0)
                {
                    car1.Left += -12;
                }

            }

            if (e.KeyCode == Keys.Right)
            {
                if (car1.Right < 380)
                {
                    car1.Left += 12;
                }

            }

            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                {
                    gamespeed++;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                {
                    gamespeed--;
                }
            }

        }


    }
}