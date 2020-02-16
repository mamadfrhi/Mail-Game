using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shot_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyPreview = true;
            Front_timer.Start();
            inbox_timer_Right.Start();
        }
        
        int back_step = 0;
        private void Front_timer_tick(object sender, EventArgs e)
        {
            Left_fire.Location = new Point(Left_fire.Location.X + 10, Left_fire.Location.Y);
            Right_fire.Location = new Point(Right_fire.Location.X - 10, Right_fire.Location.Y);

            Collision();
        }

        private void Back_timer_Tick(object sender, EventArgs e)
        {
            back_step++;
            if (back_step <= 15)
            {
                Left_fire.Location = new Point(Left_fire.Location.X - 10, Left_fire.Location.Y);
                Right_fire.Location = new Point(Right_fire.Location.X + 10, Right_fire.Location.Y);


            }
            else
            {
                Back_timer.Stop();
                back_step = 0;
                Front_timer.Start();
            }

        }

        private void Collision()
        {
            bool flag1 = Left_fire.Bounds.IntersectsWith(Right_fire.Bounds);

            if (flag1 == true)
            {
                Front_timer.Stop();
                Back_timer.Start();
            }
            else
            {

            }
        }

        int last_loc_x;
        int last_loc_y;
        private void Fire_Click(object sender, EventArgs e)
        {
            Fire_timer.Start();

            last_loc_x = Mail_Pocket.Location.X;
            last_loc_y = Mail_Pocket.Location.Y;

            Fire.Visible = false;
            Mail_pic_box.Visible = false;
            left_m_ctrl_2x.Visible = false;
            left_m_ctrl.Visible = false;
            right_m_ctrl.Visible = false;
            right_m_ctrl_2x.Visible = false;

            inbox_timer_Left.Stop();
            inbox_timer_Right.Stop();

            Again.Visible = true;
            Again.Select();
            
        }

        int pocket_fire_step;
        private void Fire_timer_Tick(object sender, EventArgs e)
        {
            pocket_fire_step++;
            if (pocket_fire_step <= 15)
            {
                Mail_Pocket.Location = new Point(Mail_Pocket.Location.X, Mail_Pocket.Location.Y - 36);
                Collision_To_Fire();
            }
            else
            {
                Fire_timer.Stop();
            }

            //bool flag1 = Mail_Pocket.Bounds.IntersectsWith(inbox_pic.Bounds);

            //int reshow = 0;
            //if (flag1 == true && reshow==0)
            //{
            //    reshow = 1;
            //    MessageBox.Show("نامه به سلامت رسید :D");
            //    //score++;
            //}
            //else
            //{
            //    //score--;
            //}
        }

        int score = 0;
        private void Collision_To_Fire()
        {
            bool flag1 = Mail_Pocket.Bounds.IntersectsWith(Right_fire.Bounds);
            bool flag2 = Mail_Pocket.Bounds.IntersectsWith(Left_fire.Bounds);


            if (flag1 == true && flag2 == true)
            {
                flag1 = false;
            }

            if (flag1 == true)
            {
                //  Mail_Pocket.Location = new Point(Mail_Pocket.Location.X, Mail_Pocket.Location.Y - 100);
                Fire_timer.Stop();
                //  Back_timer.Stop();
                // Front_timer.Stop();
                MessageBox.Show("نامه نابود شد");
                score = score - 10;
            }

            if (flag2 == true)
            {
                //   Mail_Pocket.Location = new Point(Mail_Pocket.Location.X, Mail_Pocket.Location.Y - 130);
                Fire_timer.Stop();
                //  Back_timer.Stop();
                //  Front_timer.Stop();
                MessageBox.Show("نامه نابود شد");
                score = score - 10;
            }

            bool Pocket_And_Inbox = Mail_Pocket.Bounds.IntersectsWith(inbox_pic.Bounds);
            

            if (Pocket_And_Inbox == true )
            {
                Pocket_And_Inbox = false;
                Mail_Pocket.Visible = false;
                inbox_pic.Image = Properties.Resources.Mail_And_Inbox;
                Fire_timer.Stop();
                MessageBox.Show("نــامــه بــه مــقــصــد رســیــد <3");
                score = score + 10;
                
            }

            if (pocket_fire_step==15  && Pocket_And_Inbox==false)
            {
                Fire_timer.Stop();
                Mail_Pocket.Visible = false;
                
                MessageBox.Show("نــامــه بــه مــقــصــد نـــــــرســیــد :(");
                score = score - 5;
            }

            Score_Number_lbl.Text = Convert.ToString(score);
        }

        private void left_m_ctrl_Click(object sender, EventArgs e)
        {
            Mail_Pocket.Location = new Point(Mail_Pocket.Location.X - 5, Mail_Pocket.Location.Y);
            Score_label.Select();
        }

        private void right_m_ctrl_Click_1(object sender, EventArgs e)
        {
            Mail_Pocket.Location = new Point(Mail_Pocket.Location.X + 5, Mail_Pocket.Location.Y);
            Score_label.Select();
        }

        private void right_m_ctrl_2x_Click(object sender, EventArgs e)
        {
            Mail_Pocket.Location = new Point(Mail_Pocket.Location.X + 25, Mail_Pocket.Location.Y);
            Score_label.Select();
        }

        private void left_m_ctrl_2x_Click(object sender, EventArgs e)
        {
            Mail_Pocket.Location = new Point(Mail_Pocket.Location.X - 25, Mail_Pocket.Location.Y);
            Score_label.Select();
        }

        private void Again_Click(object sender, EventArgs e)
        {
            inbox_pic.Location = new Point(318,44);

            Mail_Pocket.Location = new Point( last_loc_x , last_loc_y);
            Mail_Pocket.Visible = true;
            inbox_pic.Image = Properties.Resources.inbox;

            pocket_fire_step = 0;
            Fire_timer.Stop();

            Score_label.Select();

            Mail_pic_box.Visible = true;
            left_m_ctrl_2x.Visible = true;
            left_m_ctrl.Visible = true;
            right_m_ctrl.Visible = true;
            right_m_ctrl_2x.Visible = true;
            Fire.Visible = true;
            Again.Visible = false;

            Back_timer.Start();
            Front_timer.Start();

            inbox_timer_Left.Start();
            
            inbox_step = 0;
        }


        private void Normal_Click_1(object sender, EventArgs e)
        {
            Back_timer.Interval = 20;
            Front_timer.Interval = 20;
        }

        private void Hard_Click(object sender, EventArgs e)
        {

            Back_timer.Interval = 1;
            Front_timer.Interval = 1;
        }

        private void Easy_Click(object sender, EventArgs e)
        {
            Back_timer.Interval = 50;
            Front_timer.Interval = 50;
        }

        int inbox_step = 0;


        private void inbox_timer_Right_Tick(object sender, EventArgs e)
        {
            if (inbox_step < 30)
            {
                inbox_step++;
                inbox_pic.Location = new Point(inbox_pic.Location.X + 10, inbox_pic.Location.Y);
            }
            else
            {
                inbox_timer_Right.Stop();
                inbox_timer_Left.Start();
            }

        }

        private void inbox_timer_Left_Tick(object sender, EventArgs e)
        {
            if (inbox_step > 0)
            {
                inbox_step--;
                inbox_pic.Location = new Point(inbox_pic.Location.X - 10, inbox_pic.Location.Y);
            }

            else
            {
                inbox_timer_Left.Stop();
                inbox_timer_Right.Start();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Score_label.Select();
            foreach (Control control in this.Controls)
            {
                control.PreviewKeyDown += new PreviewKeyDownEventHandler(control_PreviewKeyDown);
            }
        }

        void control_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                e.IsInputKey = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;

            switch (e.KeyCode)
            {
                case Keys.Left: Mail_Pocket.Location = new Point(Mail_Pocket.Location.X - 25, Mail_Pocket.Location.Y); break;
                case Keys.Right: Mail_Pocket.Location = new Point(Mail_Pocket.Location.X + 25, Mail_Pocket.Location.Y); break;
                case Keys.Up: Fire.PerformClick(); break;
                case Keys.Enter: Fire.PerformClick(); break;
                case Keys.Space: Fire.PerformClick(); break;

                //case Keys.Up: label1.Text = "Up Arrow"; break;
                //case Keys.Down: label1.Text = "Down Arrow"; break;
                //case Keys.Space: label1.Text = "Space"; break;
                default: e.Handled = true; break;
            }
        }
        
    }
}
