namespace Shot_Game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any Resources1 being used.
        /// </summary>
        /// <param name="disposing">true if managed Resources1 should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Front_timer = new System.Windows.Forms.Timer(this.components);
            this.Back_timer = new System.Windows.Forms.Timer(this.components);
            this.left_m_ctrl = new System.Windows.Forms.Button();
            this.Fire_timer = new System.Windows.Forms.Timer(this.components);
            this.right_m_ctrl = new System.Windows.Forms.Button();
            this.left_m_ctrl_2x = new System.Windows.Forms.Button();
            this.right_m_ctrl_2x = new System.Windows.Forms.Button();
            this.Difficulity_strp_mnu = new System.Windows.Forms.MenuStrip();
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Hard = new System.Windows.Forms.ToolStripMenuItem();
            this.Normal = new System.Windows.Forms.ToolStripMenuItem();
            this.Easy = new System.Windows.Forms.ToolStripMenuItem();
            this.Score_label = new System.Windows.Forms.Label();
            this.inbox_timer_Right = new System.Windows.Forms.Timer(this.components);
            this.inbox_timer_Left = new System.Windows.Forms.Timer(this.components);
            this.Score_Number_lbl = new System.Windows.Forms.Label();
            this.inbox_pic = new System.Windows.Forms.PictureBox();
            this.Again = new System.Windows.Forms.Button();
            this.Mail_pic_box = new System.Windows.Forms.PictureBox();
            this.Mail_Pocket = new System.Windows.Forms.PictureBox();
            this.Fire = new System.Windows.Forms.Button();
            this.Left_fire = new System.Windows.Forms.PictureBox();
            this.Right_fire = new System.Windows.Forms.PictureBox();
            this.Difficulity_strp_mnu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inbox_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mail_pic_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mail_Pocket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Left_fire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Right_fire)).BeginInit();
            this.SuspendLayout();
            // 
            // Front_timer
            // 
            this.Front_timer.Interval = 10;
            this.Front_timer.Tick += new System.EventHandler(this.Front_timer_tick);
            // 
            // Back_timer
            // 
            this.Back_timer.Interval = 10;
            this.Back_timer.Tick += new System.EventHandler(this.Back_timer_Tick);
            // 
            // left_m_ctrl
            // 
            this.left_m_ctrl.BackColor = System.Drawing.Color.DarkGreen;
            this.left_m_ctrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.left_m_ctrl.ForeColor = System.Drawing.Color.LavenderBlush;
            this.left_m_ctrl.Location = new System.Drawing.Point(853, 625);
            this.left_m_ctrl.Name = "left_m_ctrl";
            this.left_m_ctrl.Size = new System.Drawing.Size(40, 40);
            this.left_m_ctrl.TabIndex = 4;
            this.left_m_ctrl.Text = "<";
            this.left_m_ctrl.UseVisualStyleBackColor = false;
            this.left_m_ctrl.Click += new System.EventHandler(this.left_m_ctrl_Click);
            // 
            // Fire_timer
            // 
            this.Fire_timer.Interval = 5;
            this.Fire_timer.Tick += new System.EventHandler(this.Fire_timer_Tick);
            // 
            // right_m_ctrl
            // 
            this.right_m_ctrl.BackColor = System.Drawing.Color.DarkGreen;
            this.right_m_ctrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.right_m_ctrl.ForeColor = System.Drawing.Color.LavenderBlush;
            this.right_m_ctrl.Location = new System.Drawing.Point(943, 625);
            this.right_m_ctrl.Name = "right_m_ctrl";
            this.right_m_ctrl.Size = new System.Drawing.Size(40, 40);
            this.right_m_ctrl.TabIndex = 7;
            this.right_m_ctrl.Text = ">";
            this.right_m_ctrl.UseVisualStyleBackColor = false;
            this.right_m_ctrl.Click += new System.EventHandler(this.right_m_ctrl_Click_1);
            // 
            // left_m_ctrl_2x
            // 
            this.left_m_ctrl_2x.BackColor = System.Drawing.Color.DarkGreen;
            this.left_m_ctrl_2x.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.left_m_ctrl_2x.ForeColor = System.Drawing.Color.LemonChiffon;
            this.left_m_ctrl_2x.Location = new System.Drawing.Point(800, 625);
            this.left_m_ctrl_2x.Name = "left_m_ctrl_2x";
            this.left_m_ctrl_2x.Size = new System.Drawing.Size(47, 40);
            this.left_m_ctrl_2x.TabIndex = 8;
            this.left_m_ctrl_2x.Text = "<<";
            this.left_m_ctrl_2x.UseVisualStyleBackColor = false;
            this.left_m_ctrl_2x.Click += new System.EventHandler(this.left_m_ctrl_2x_Click);
            // 
            // right_m_ctrl_2x
            // 
            this.right_m_ctrl_2x.BackColor = System.Drawing.Color.DarkGreen;
            this.right_m_ctrl_2x.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.right_m_ctrl_2x.ForeColor = System.Drawing.Color.LavenderBlush;
            this.right_m_ctrl_2x.Location = new System.Drawing.Point(989, 625);
            this.right_m_ctrl_2x.Name = "right_m_ctrl_2x";
            this.right_m_ctrl_2x.Size = new System.Drawing.Size(47, 40);
            this.right_m_ctrl_2x.TabIndex = 9;
            this.right_m_ctrl_2x.Text = ">>";
            this.right_m_ctrl_2x.UseVisualStyleBackColor = false;
            this.right_m_ctrl_2x.Click += new System.EventHandler(this.right_m_ctrl_2x_Click);
            // 
            // Difficulity_strp_mnu
            // 
            this.Difficulity_strp_mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hardToolStripMenuItem});
            this.Difficulity_strp_mnu.Location = new System.Drawing.Point(0, 0);
            this.Difficulity_strp_mnu.Name = "Difficulity_strp_mnu";
            this.Difficulity_strp_mnu.Size = new System.Drawing.Size(1065, 24);
            this.Difficulity_strp_mnu.TabIndex = 11;
            this.Difficulity_strp_mnu.Text = "menuStrip1";
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Hard,
            this.Normal,
            this.Easy});
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            this.hardToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.hardToolStripMenuItem.Text = "Difficulity";
            // 
            // Hard
            // 
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(114, 22);
            this.Hard.Text = "Hard";
            this.Hard.Click += new System.EventHandler(this.Hard_Click);
            // 
            // Normal
            // 
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(114, 22);
            this.Normal.Text = "Normal";
            this.Normal.Click += new System.EventHandler(this.Normal_Click_1);
            // 
            // Easy
            // 
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(114, 22);
            this.Easy.Text = "Easy";
            this.Easy.Click += new System.EventHandler(this.Easy_Click);
            // 
            // Score_label
            // 
            this.Score_label.AutoSize = true;
            this.Score_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Score_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Score_label.Location = new System.Drawing.Point(7, 63);
            this.Score_label.Name = "Score_label";
            this.Score_label.Size = new System.Drawing.Size(70, 25);
            this.Score_label.TabIndex = 12;
            this.Score_label.Text = "Score:";
            // 
            // inbox_timer_Right
            // 
            this.inbox_timer_Right.Interval = 10;
            this.inbox_timer_Right.Tick += new System.EventHandler(this.inbox_timer_Right_Tick);
            // 
            // inbox_timer_Left
            // 
            this.inbox_timer_Left.Interval = 10;
            this.inbox_timer_Left.Tick += new System.EventHandler(this.inbox_timer_Left_Tick);
            // 
            // Score_Number_lbl
            // 
            this.Score_Number_lbl.AutoSize = true;
            this.Score_Number_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score_Number_lbl.ForeColor = System.Drawing.Color.Lime;
            this.Score_Number_lbl.Location = new System.Drawing.Point(94, 63);
            this.Score_Number_lbl.Name = "Score_Number_lbl";
            this.Score_Number_lbl.Size = new System.Drawing.Size(23, 25);
            this.Score_Number_lbl.TabIndex = 14;
            this.Score_Number_lbl.Text = "0";
            // 
            // inbox_pic
            // 
            this.inbox_pic.Image = ((System.Drawing.Image)(resources.GetObject("inbox_pic.Image")));
            this.inbox_pic.Location = new System.Drawing.Point(318, 44);
            this.inbox_pic.Name = "inbox_pic";
            this.inbox_pic.Size = new System.Drawing.Size(81, 72);
            this.inbox_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inbox_pic.TabIndex = 13;
            this.inbox_pic.TabStop = false;
            // 
            // Again
            // 
            this.Again.BackColor = System.Drawing.Color.DodgerBlue;
            this.Again.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Again.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Again.Image = global::Shot_Game.Properties.Resources.arrow_refresh_reload_icon_29_png;
            this.Again.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Again.Location = new System.Drawing.Point(72, 671);
            this.Again.Name = "Again";
            this.Again.Size = new System.Drawing.Size(91, 40);
            this.Again.TabIndex = 10;
            this.Again.Text = "Again";
            this.Again.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Again.UseVisualStyleBackColor = false;
            this.Again.Visible = false;
            this.Again.Click += new System.EventHandler(this.Again_Click);
            // 
            // Mail_pic_box
            // 
            this.Mail_pic_box.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Mail_pic_box.Image = ((System.Drawing.Image)(resources.GetObject("Mail_pic_box.Image")));
            this.Mail_pic_box.Location = new System.Drawing.Point(899, 639);
            this.Mail_pic_box.Name = "Mail_pic_box";
            this.Mail_pic_box.Size = new System.Drawing.Size(38, 26);
            this.Mail_pic_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mail_pic_box.TabIndex = 6;
            this.Mail_pic_box.TabStop = false;
            // 
            // Mail_Pocket
            // 
            this.Mail_Pocket.Image = ((System.Drawing.Image)(resources.GetObject("Mail_Pocket.Image")));
            this.Mail_Pocket.Location = new System.Drawing.Point(665, 593);
            this.Mail_Pocket.Name = "Mail_Pocket";
            this.Mail_Pocket.Size = new System.Drawing.Size(81, 72);
            this.Mail_Pocket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mail_Pocket.TabIndex = 3;
            this.Mail_Pocket.TabStop = false;
            // 
            // Fire
            // 
            this.Fire.BackColor = System.Drawing.Color.Peru;
            this.Fire.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fire.ForeColor = System.Drawing.Color.Crimson;
            this.Fire.Image = global::Shot_Game.Properties.Resources.Arrows_Up;
            this.Fire.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Fire.Location = new System.Drawing.Point(59, 593);
            this.Fire.Name = "Fire";
            this.Fire.Size = new System.Drawing.Size(118, 72);
            this.Fire.TabIndex = 2;
            this.Fire.Text = "Fire!";
            this.Fire.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Fire.UseVisualStyleBackColor = false;
            this.Fire.Click += new System.EventHandler(this.Fire_Click);
            // 
            // Left_fire
            // 
            this.Left_fire.Cursor = System.Windows.Forms.Cursors.No;
            this.Left_fire.Image = ((System.Drawing.Image)(resources.GetObject("Left_fire.Image")));
            this.Left_fire.Location = new System.Drawing.Point(-23, 214);
            this.Left_fire.Name = "Left_fire";
            this.Left_fire.Size = new System.Drawing.Size(422, 214);
            this.Left_fire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Left_fire.TabIndex = 1;
            this.Left_fire.TabStop = false;
            // 
            // Right_fire
            // 
            this.Right_fire.Cursor = System.Windows.Forms.Cursors.No;
            this.Right_fire.Image = ((System.Drawing.Image)(resources.GetObject("Right_fire.Image")));
            this.Right_fire.Location = new System.Drawing.Point(665, 214);
            this.Right_fire.Name = "Right_fire";
            this.Right_fire.Size = new System.Drawing.Size(422, 214);
            this.Right_fire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Right_fire.TabIndex = 0;
            this.Right_fire.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1065, 723);
            this.Controls.Add(this.Score_Number_lbl);
            this.Controls.Add(this.inbox_pic);
            this.Controls.Add(this.Score_label);
            this.Controls.Add(this.Again);
            this.Controls.Add(this.right_m_ctrl_2x);
            this.Controls.Add(this.left_m_ctrl_2x);
            this.Controls.Add(this.right_m_ctrl);
            this.Controls.Add(this.Mail_pic_box);
            this.Controls.Add(this.left_m_ctrl);
            this.Controls.Add(this.Mail_Pocket);
            this.Controls.Add(this.Fire);
            this.Controls.Add(this.Left_fire);
            this.Controls.Add(this.Right_fire);
            this.Controls.Add(this.Difficulity_strp_mnu);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Difficulity_strp_mnu;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Burn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Difficulity_strp_mnu.ResumeLayout(false);
            this.Difficulity_strp_mnu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inbox_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mail_pic_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mail_Pocket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Left_fire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Right_fire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Right_fire;
        private System.Windows.Forms.PictureBox Left_fire;
        private System.Windows.Forms.Timer Front_timer;
        private System.Windows.Forms.Timer Back_timer;
        private System.Windows.Forms.PictureBox Mail_Pocket;
        private System.Windows.Forms.Button left_m_ctrl;
        private System.Windows.Forms.PictureBox Mail_pic_box;
        private System.Windows.Forms.Timer Fire_timer;
        private System.Windows.Forms.Button right_m_ctrl;
        private System.Windows.Forms.Button left_m_ctrl_2x;
        private System.Windows.Forms.Button right_m_ctrl_2x;
        private System.Windows.Forms.Button Again;
        private System.Windows.Forms.MenuStrip Difficulity_strp_mnu;
        private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Normal;
        private System.Windows.Forms.ToolStripMenuItem Easy;
        private System.Windows.Forms.ToolStripMenuItem Hard;
        private System.Windows.Forms.Label Score_label;
        private System.Windows.Forms.PictureBox inbox_pic;
        private System.Windows.Forms.Timer inbox_timer_Right;
        private System.Windows.Forms.Timer inbox_timer_Left;
        private System.Windows.Forms.Button Fire;
        private System.Windows.Forms.Label Score_Number_lbl;
    }
}

