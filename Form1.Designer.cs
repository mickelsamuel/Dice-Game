
namespace Dice_Project
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
            this.startgamebutton = new System.Windows.Forms.Button();
            this.player1name = new System.Windows.Forms.TextBox();
            this.player2name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dicepic = new System.Windows.Forms.PictureBox();
            this.player1rollbutton = new System.Windows.Forms.Button();
            this.player1holdbutton = new System.Windows.Forms.Button();
            this.player2rollbutton = new System.Windows.Forms.Button();
            this.player2holdbutton = new System.Windows.Forms.Button();
            this.player1globallabel = new System.Windows.Forms.Label();
            this.player2globallabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.player1roundlabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.player2roundlabel = new System.Windows.Forms.Label();
            this.exitbutton = new System.Windows.Forms.Button();
            this.player1label = new System.Windows.Forms.Label();
            this.player2label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.turnlabel = new System.Windows.Forms.Label();
            this.winnerlabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dicepic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // startgamebutton
            // 
            this.startgamebutton.Location = new System.Drawing.Point(380, 460);
            this.startgamebutton.Margin = new System.Windows.Forms.Padding(6);
            this.startgamebutton.Name = "startgamebutton";
            this.startgamebutton.Size = new System.Drawing.Size(139, 49);
            this.startgamebutton.TabIndex = 0;
            this.startgamebutton.Text = "Start Game";
            this.startgamebutton.UseVisualStyleBackColor = true;
            this.startgamebutton.Click += new System.EventHandler(this.startgame_Click);
            // 
            // player1name
            // 
            this.player1name.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.player1name.Location = new System.Drawing.Point(84, 352);
            this.player1name.Margin = new System.Windows.Forms.Padding(6);
            this.player1name.Name = "player1name";
            this.player1name.Size = new System.Drawing.Size(182, 39);
            this.player1name.TabIndex = 1;
            // 
            // player2name
            // 
            this.player2name.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.player2name.Location = new System.Drawing.Point(667, 352);
            this.player2name.Margin = new System.Windows.Forms.Padding(6);
            this.player2name.Name = "player2name";
            this.player2name.Size = new System.Drawing.Size(182, 39);
            this.player2name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(132, 292);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(703, 292);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Player 2";
            // 
            // dicepic
            // 
            this.dicepic.Location = new System.Drawing.Point(396, 292);
            this.dicepic.Margin = new System.Windows.Forms.Padding(6);
            this.dicepic.Name = "dicepic";
            this.dicepic.Size = new System.Drawing.Size(104, 110);
            this.dicepic.TabIndex = 5;
            this.dicepic.TabStop = false;
            // 
            // player1rollbutton
            // 
            this.player1rollbutton.Location = new System.Drawing.Point(84, 559);
            this.player1rollbutton.Margin = new System.Windows.Forms.Padding(6);
            this.player1rollbutton.Name = "player1rollbutton";
            this.player1rollbutton.Size = new System.Drawing.Size(139, 49);
            this.player1rollbutton.TabIndex = 6;
            this.player1rollbutton.Text = "Roll";
            this.player1rollbutton.UseVisualStyleBackColor = true;
            this.player1rollbutton.Click += new System.EventHandler(this.player1roll_Click);
            // 
            // player1holdbutton
            // 
            this.player1holdbutton.Location = new System.Drawing.Point(84, 663);
            this.player1holdbutton.Margin = new System.Windows.Forms.Padding(6);
            this.player1holdbutton.Name = "player1holdbutton";
            this.player1holdbutton.Size = new System.Drawing.Size(139, 49);
            this.player1holdbutton.TabIndex = 7;
            this.player1holdbutton.Text = "Hold";
            this.player1holdbutton.UseVisualStyleBackColor = true;
            this.player1holdbutton.Click += new System.EventHandler(this.player1hold_Click);
            // 
            // player2rollbutton
            // 
            this.player2rollbutton.Location = new System.Drawing.Point(688, 559);
            this.player2rollbutton.Margin = new System.Windows.Forms.Padding(6);
            this.player2rollbutton.Name = "player2rollbutton";
            this.player2rollbutton.Size = new System.Drawing.Size(139, 49);
            this.player2rollbutton.TabIndex = 8;
            this.player2rollbutton.Text = "Roll";
            this.player2rollbutton.UseVisualStyleBackColor = true;
            this.player2rollbutton.Click += new System.EventHandler(this.player2roll_Click);
            // 
            // player2holdbutton
            // 
            this.player2holdbutton.Location = new System.Drawing.Point(688, 663);
            this.player2holdbutton.Margin = new System.Windows.Forms.Padding(6);
            this.player2holdbutton.Name = "player2holdbutton";
            this.player2holdbutton.Size = new System.Drawing.Size(139, 49);
            this.player2holdbutton.TabIndex = 9;
            this.player2holdbutton.Text = "Hold";
            this.player2holdbutton.UseVisualStyleBackColor = true;
            this.player2holdbutton.Click += new System.EventHandler(this.player2hold_Click);
            // 
            // player1globallabel
            // 
            this.player1globallabel.AutoSize = true;
            this.player1globallabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.player1globallabel.ForeColor = System.Drawing.SystemColors.Control;
            this.player1globallabel.Location = new System.Drawing.Point(236, 98);
            this.player1globallabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.player1globallabel.Name = "player1globallabel";
            this.player1globallabel.Size = new System.Drawing.Size(27, 32);
            this.player1globallabel.TabIndex = 10;
            this.player1globallabel.Text = "0";
            // 
            // player2globallabel
            // 
            this.player2globallabel.AutoSize = true;
            this.player2globallabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.player2globallabel.ForeColor = System.Drawing.SystemColors.Control;
            this.player2globallabel.Location = new System.Drawing.Point(822, 98);
            this.player2globallabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.player2globallabel.Name = "player2globallabel";
            this.player2globallabel.Size = new System.Drawing.Size(27, 32);
            this.player2globallabel.TabIndex = 11;
            this.player2globallabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(674, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Global Score:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(84, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 32);
            this.label6.TabIndex = 13;
            this.label6.Text = "Global Score:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(82, 154);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 32);
            this.label7.TabIndex = 14;
            this.label7.Text = "Round Score:";
            // 
            // player1roundlabel
            // 
            this.player1roundlabel.AutoSize = true;
            this.player1roundlabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.player1roundlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.player1roundlabel.Location = new System.Drawing.Point(236, 154);
            this.player1roundlabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.player1roundlabel.Name = "player1roundlabel";
            this.player1roundlabel.Size = new System.Drawing.Size(27, 32);
            this.player1roundlabel.TabIndex = 15;
            this.player1roundlabel.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(673, 154);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 32);
            this.label9.TabIndex = 16;
            this.label9.Text = "Round Score:";
            // 
            // player2roundlabel
            // 
            this.player2roundlabel.AutoSize = true;
            this.player2roundlabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.player2roundlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.player2roundlabel.Location = new System.Drawing.Point(822, 154);
            this.player2roundlabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.player2roundlabel.Name = "player2roundlabel";
            this.player2roundlabel.Size = new System.Drawing.Size(27, 32);
            this.player2roundlabel.TabIndex = 17;
            this.player2roundlabel.Text = "0";
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(380, 761);
            this.exitbutton.Margin = new System.Windows.Forms.Padding(6);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(139, 49);
            this.exitbutton.TabIndex = 18;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exit_Click);
            // 
            // player1label
            // 
            this.player1label.AutoSize = true;
            this.player1label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.player1label.ForeColor = System.Drawing.SystemColors.Control;
            this.player1label.Location = new System.Drawing.Point(152, 41);
            this.player1label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.player1label.Name = "player1label";
            this.player1label.Size = new System.Drawing.Size(78, 32);
            this.player1label.TabIndex = 19;
            this.player1label.Text = "label3";
            // 
            // player2label
            // 
            this.player2label.AutoSize = true;
            this.player2label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.player2label.ForeColor = System.Drawing.SystemColors.Control;
            this.player2label.Location = new System.Drawing.Point(723, 41);
            this.player2label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.player2label.Name = "player2label";
            this.player2label.Size = new System.Drawing.Size(78, 32);
            this.player2label.TabIndex = 20;
            this.player2label.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(380, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 32);
            this.label3.TabIndex = 21;
            this.label3.Text = "Turn:";
            // 
            // turnlabel
            // 
            this.turnlabel.AutoSize = true;
            this.turnlabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.turnlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.turnlabel.Location = new System.Drawing.Point(460, 154);
            this.turnlabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.turnlabel.Name = "turnlabel";
            this.turnlabel.Size = new System.Drawing.Size(78, 32);
            this.turnlabel.TabIndex = 22;
            this.turnlabel.Text = "label4";
            // 
            // winnerlabel
            // 
            this.winnerlabel.AutoSize = true;
            this.winnerlabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.winnerlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.winnerlabel.Location = new System.Drawing.Point(448, 674);
            this.winnerlabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.winnerlabel.Name = "winnerlabel";
            this.winnerlabel.Size = new System.Drawing.Size(0, 32);
            this.winnerlabel.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 22.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(300, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 77);
            this.label4.TabIndex = 24;
            this.label4.Text = "Dice Game";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(572, 848);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(229, 32);
            this.label8.TabIndex = 25;
            this.label8.Text = "Gamble Responsibly";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(855, 394);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1226, 726);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(1076, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(769, 256);
            this.label10.TabIndex = 27;
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(2025, 949);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.winnerlabel);
            this.Controls.Add(this.turnlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.player2label);
            this.Controls.Add(this.player1label);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.player2roundlabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.player1roundlabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.player2globallabel);
            this.Controls.Add(this.player1globallabel);
            this.Controls.Add(this.player2holdbutton);
            this.Controls.Add(this.player2rollbutton);
            this.Controls.Add(this.player1holdbutton);
            this.Controls.Add(this.player1rollbutton);
            this.Controls.Add(this.dicepic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player2name);
            this.Controls.Add(this.player1name);
            this.Controls.Add(this.startgamebutton);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dicepic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startgamebutton;
        private System.Windows.Forms.TextBox player1name;
        private System.Windows.Forms.TextBox player2name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox dicepic;
        private System.Windows.Forms.Button player1rollbutton;
        private System.Windows.Forms.Button player1holdbutton;
        private System.Windows.Forms.Button player2rollbutton;
        private System.Windows.Forms.Button player2holdbutton;
        private System.Windows.Forms.Label player1globallabel;
        private System.Windows.Forms.Label player2globallabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label player1roundlabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label player2roundlabel;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Label player1label;
        private System.Windows.Forms.Label player2label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label turnlabel;
        private System.Windows.Forms.Label winnerlabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
    }
}

