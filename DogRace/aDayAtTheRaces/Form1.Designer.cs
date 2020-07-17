namespace aDayAtTheRaces
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.racetrackPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblJoe = new System.Windows.Forms.Label();
            this.lblBob = new System.Windows.Forms.Label();
            this.lblAl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.numBets = new System.Windows.Forms.NumericUpDown();
            this.btnBets = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numDog = new System.Windows.Forms.NumericUpDown();
            this.radioAl = new System.Windows.Forms.RadioButton();
            this.radioBob = new System.Windows.Forms.RadioButton();
            this.radioJoe = new System.Windows.Forms.RadioButton();
            this.radioGroupBox = new System.Windows.Forms.GroupBox();
            this.btnRace = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDog)).BeginInit();
            this.SuspendLayout();
            // 
            // racetrackPictureBox
            // 
            this.racetrackPictureBox.Image = global::aDayAtTheRaces.Properties.Resources.bg2;
            this.racetrackPictureBox.Location = new System.Drawing.Point(3, 15);
            this.racetrackPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.racetrackPictureBox.Name = "racetrackPictureBox";
            this.racetrackPictureBox.Size = new System.Drawing.Size(1259, 250);
            this.racetrackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racetrackPictureBox.TabIndex = 0;
            this.racetrackPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::aDayAtTheRaces.Properties.Resources.mydog;
            this.pictureBox1.Location = new System.Drawing.Point(31, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::aDayAtTheRaces.Properties.Resources.mydog;
            this.pictureBox2.Location = new System.Drawing.Point(31, 85);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::aDayAtTheRaces.Properties.Resources.mydog;
            this.pictureBox3.Location = new System.Drawing.Point(31, 153);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(90, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::aDayAtTheRaces.Properties.Resources.mydog;
            this.pictureBox4.Location = new System.Drawing.Point(31, 215);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(90, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.radioAl);
            this.groupBox1.Controls.Add(this.radioBob);
            this.groupBox1.Controls.Add(this.radioJoe);
            this.groupBox1.Controls.Add(this.radioGroupBox);
            this.groupBox1.Controls.Add(this.btnRace);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(16, 272);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1236, 252);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control Area:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblJoe);
            this.groupBox3.Controls.Add(this.lblBob);
            this.groupBox3.Controls.Add(this.lblAl);
            this.groupBox3.Location = new System.Drawing.Point(597, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(465, 164);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bet Description";
            // 
            // lblJoe
            // 
            this.lblJoe.AutoSize = true;
            this.lblJoe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblJoe.Location = new System.Drawing.Point(38, 39);
            this.lblJoe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJoe.Name = "lblJoe";
            this.lblJoe.Size = new System.Drawing.Size(52, 18);
            this.lblJoe.TabIndex = 5;
            this.lblJoe.Text = "label1";
            // 
            // lblBob
            // 
            this.lblBob.AutoSize = true;
            this.lblBob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBob.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBob.Location = new System.Drawing.Point(38, 78);
            this.lblBob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBob.Name = "lblBob";
            this.lblBob.Size = new System.Drawing.Size(52, 18);
            this.lblBob.TabIndex = 6;
            this.lblBob.Text = "label2";
            // 
            // lblAl
            // 
            this.lblAl.AutoSize = true;
            this.lblAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAl.Location = new System.Drawing.Point(38, 124);
            this.lblAl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAl.Name = "lblAl";
            this.lblAl.Size = new System.Drawing.Size(52, 18);
            this.lblAl.TabIndex = 7;
            this.lblAl.Text = "label3";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Controls.Add(this.numBets);
            this.groupBox2.Controls.Add(this.btnBets);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numDog);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(297, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 209);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Task";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Buck Spent:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Active Punter:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Gold;
            this.lblName.Location = new System.Drawing.Point(164, 36);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 20);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "name";
            // 
            // numBets
            // 
            this.numBets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBets.Location = new System.Drawing.Point(145, 69);
            this.numBets.Margin = new System.Windows.Forms.Padding(4);
            this.numBets.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numBets.Name = "numBets";
            this.numBets.Size = new System.Drawing.Size(51, 24);
            this.numBets.TabIndex = 11;
            this.numBets.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnBets
            // 
            this.btnBets.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBets.Location = new System.Drawing.Point(42, 158);
            this.btnBets.Margin = new System.Windows.Forms.Padding(4);
            this.btnBets.Name = "btnBets";
            this.btnBets.Size = new System.Drawing.Size(154, 36);
            this.btnBets.TabIndex = 14;
            this.btnBets.Text = "Place Bet";
            this.btnBets.UseVisualStyleBackColor = false;
            this.btnBets.Click += new System.EventHandler(this.btnBets_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dog Number: ";
            // 
            // numDog
            // 
            this.numDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDog.Location = new System.Drawing.Point(145, 114);
            this.numDog.Margin = new System.Windows.Forms.Padding(4);
            this.numDog.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numDog.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDog.Name = "numDog";
            this.numDog.Size = new System.Drawing.Size(73, 24);
            this.numDog.TabIndex = 13;
            this.numDog.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radioAl
            // 
            this.radioAl.AutoSize = true;
            this.radioAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAl.Location = new System.Drawing.Point(27, 154);
            this.radioAl.Margin = new System.Windows.Forms.Padding(4);
            this.radioAl.Name = "radioAl";
            this.radioAl.Size = new System.Drawing.Size(66, 24);
            this.radioAl.TabIndex = 3;
            this.radioAl.Text = "Tom";
            this.radioAl.UseVisualStyleBackColor = true;
            this.radioAl.CheckedChanged += new System.EventHandler(this.radioAl_CheckedChanged);
            // 
            // radioBob
            // 
            this.radioBob.AutoSize = true;
            this.radioBob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBob.Location = new System.Drawing.Point(27, 108);
            this.radioBob.Margin = new System.Windows.Forms.Padding(4);
            this.radioBob.Name = "radioBob";
            this.radioBob.Size = new System.Drawing.Size(78, 24);
            this.radioBob.TabIndex = 2;
            this.radioBob.Text = "David";
            this.radioBob.UseVisualStyleBackColor = true;
            this.radioBob.CheckedChanged += new System.EventHandler(this.radioBob_CheckedChanged);
            // 
            // radioJoe
            // 
            this.radioJoe.AutoSize = true;
            this.radioJoe.Checked = true;
            this.radioJoe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioJoe.Location = new System.Drawing.Point(27, 65);
            this.radioJoe.Margin = new System.Windows.Forms.Padding(4);
            this.radioJoe.Name = "radioJoe";
            this.radioJoe.Size = new System.Drawing.Size(78, 24);
            this.radioJoe.TabIndex = 1;
            this.radioJoe.TabStop = true;
            this.radioJoe.Text = "Smith";
            this.radioJoe.UseVisualStyleBackColor = true;
            this.radioJoe.CheckedChanged += new System.EventHandler(this.radioJoe_CheckedChanged);
            // 
            // radioGroupBox
            // 
            this.radioGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroupBox.Location = new System.Drawing.Point(13, 36);
            this.radioGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.radioGroupBox.Name = "radioGroupBox";
            this.radioGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.radioGroupBox.Size = new System.Drawing.Size(243, 164);
            this.radioGroupBox.TabIndex = 15;
            this.radioGroupBox.TabStop = false;
            this.radioGroupBox.Text = "Minimum Bet: $5";
            // 
            // btnRace
            // 
            this.btnRace.BackColor = System.Drawing.Color.IndianRed;
            this.btnRace.BackgroundImage = global::aDayAtTheRaces.Properties.Resources.download;
            this.btnRace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRace.ForeColor = System.Drawing.Color.Snow;
            this.btnRace.Location = new System.Drawing.Point(1083, 76);
            this.btnRace.Margin = new System.Windows.Forms.Padding(4);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(135, 85);
            this.btnRace.TabIndex = 8;
            this.btnRace.UseVisualStyleBackColor = false;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::aDayAtTheRaces.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1265, 537);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.racetrackPictureBox);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Dog Race";
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox racetrackPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numDog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numBets;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.Label lblAl;
        private System.Windows.Forms.Label lblBob;
        private System.Windows.Forms.Label lblJoe;
        private System.Windows.Forms.RadioButton radioAl;
        private System.Windows.Forms.RadioButton radioBob;
        private System.Windows.Forms.RadioButton radioJoe;
        private System.Windows.Forms.Button btnBets;
        private System.Windows.Forms.GroupBox radioGroupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

