namespace Sushi_Go
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
            this.pictureBoxHumanBoard = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.pictureBoxHumanHand = new System.Windows.Forms.PictureBox();
            this.textBoxHumanPoint = new System.Windows.Forms.TextBox();
            this.textBoxCompScore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxChoose = new System.Windows.Forms.TextBox();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.buttonUseChopsticks = new System.Windows.Forms.Button();
            this.textBoxSwapChopsticks = new System.Windows.Forms.TextBox();
            this.label01 = new System.Windows.Forms.Label();
            this.label02 = new System.Windows.Forms.Label();
            this.label03 = new System.Windows.Forms.Label();
            this.label04 = new System.Windows.Forms.Label();
            this.label05 = new System.Windows.Forms.Label();
            this.label06 = new System.Windows.Forms.Label();
            this.label07 = new System.Windows.Forms.Label();
            this.label08 = new System.Windows.Forms.Label();
            this.label09 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxRound = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxCompPudding = new System.Windows.Forms.TextBox();
            this.textBoxHumanPudding = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxTotalCPoint = new System.Windows.Forms.TextBox();
            this.textBoxTotalHPoint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxComputerBoard = new System.Windows.Forms.PictureBox();
            this.buttonNextRound = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBoxHard = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHumanBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHumanHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComputerBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxHumanBoard
            // 
            this.pictureBoxHumanBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pictureBoxHumanBoard.Location = new System.Drawing.Point(21, 481);
            this.pictureBoxHumanBoard.Name = "pictureBoxHumanBoard";
            this.pictureBoxHumanBoard.Size = new System.Drawing.Size(1888, 234);
            this.pictureBoxHumanBoard.TabIndex = 1;
            this.pictureBoxHumanBoard.TabStop = false;
            // 
            // Player
            // 
            this.Player.AutoSize = true;
            this.Player.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Player.Location = new System.Drawing.Point(30, 424);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(225, 54);
            this.Player.TabIndex = 3;
            this.Player.Text = "*Human*";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonStart.Font = new System.Drawing.Font("Modern No. 20", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.Maroon;
            this.buttonStart.Location = new System.Drawing.Point(325, 8);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(209, 68);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // pictureBoxHumanHand
            // 
            this.pictureBoxHumanHand.BackColor = System.Drawing.Color.SlateBlue;
            this.pictureBoxHumanHand.Location = new System.Drawing.Point(21, 860);
            this.pictureBoxHumanHand.Name = "pictureBoxHumanHand";
            this.pictureBoxHumanHand.Size = new System.Drawing.Size(1888, 234);
            this.pictureBoxHumanHand.TabIndex = 7;
            this.pictureBoxHumanHand.TabStop = false;
            this.pictureBoxHumanHand.Click += new System.EventHandler(this.pictureBoxSelect_Click);
            // 
            // textBoxHumanPoint
            // 
            this.textBoxHumanPoint.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxHumanPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHumanPoint.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxHumanPoint.Location = new System.Drawing.Point(552, 424);
            this.textBoxHumanPoint.Name = "textBoxHumanPoint";
            this.textBoxHumanPoint.ReadOnly = true;
            this.textBoxHumanPoint.Size = new System.Drawing.Size(84, 49);
            this.textBoxHumanPoint.TabIndex = 8;
            // 
            // textBoxCompScore
            // 
            this.textBoxCompScore.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxCompScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCompScore.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxCompScore.Location = new System.Drawing.Point(552, 107);
            this.textBoxCompScore.Name = "textBoxCompScore";
            this.textBoxCompScore.ReadOnly = true;
            this.textBoxCompScore.Size = new System.Drawing.Size(84, 49);
            this.textBoxCompScore.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label3.Location = new System.Drawing.Point(261, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 46);
            this.label3.TabIndex = 11;
            this.label3.Text = "Current Points:";
            // 
            // textBoxChoose
            // 
            this.textBoxChoose.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChoose.ForeColor = System.Drawing.Color.Navy;
            this.textBoxChoose.Location = new System.Drawing.Point(325, 738);
            this.textBoxChoose.Name = "textBoxChoose";
            this.textBoxChoose.Size = new System.Drawing.Size(109, 58);
            this.textBoxChoose.TabIndex = 12;
            // 
            // buttonChoose
            // 
            this.buttonChoose.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonChoose.Font = new System.Drawing.Font("Modern No. 20", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChoose.ForeColor = System.Drawing.Color.Navy;
            this.buttonChoose.Location = new System.Drawing.Point(21, 734);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(298, 68);
            this.buttonChoose.TabIndex = 13;
            this.buttonChoose.Text = "Choose Card:";
            this.buttonChoose.UseVisualStyleBackColor = false;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // buttonUseChopsticks
            // 
            this.buttonUseChopsticks.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonUseChopsticks.Font = new System.Drawing.Font("Modern No. 20", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUseChopsticks.ForeColor = System.Drawing.Color.Navy;
            this.buttonUseChopsticks.Location = new System.Drawing.Point(552, 734);
            this.buttonUseChopsticks.Name = "buttonUseChopsticks";
            this.buttonUseChopsticks.Size = new System.Drawing.Size(398, 66);
            this.buttonUseChopsticks.TabIndex = 15;
            this.buttonUseChopsticks.Text = "Swap Chopsticks Card:";
            this.buttonUseChopsticks.UseVisualStyleBackColor = false;
            this.buttonUseChopsticks.Click += new System.EventHandler(this.buttonUseChopsticks_Click);
            // 
            // textBoxSwapChopsticks
            // 
            this.textBoxSwapChopsticks.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxSwapChopsticks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSwapChopsticks.ForeColor = System.Drawing.Color.Navy;
            this.textBoxSwapChopsticks.Location = new System.Drawing.Point(956, 738);
            this.textBoxSwapChopsticks.Name = "textBoxSwapChopsticks";
            this.textBoxSwapChopsticks.Size = new System.Drawing.Size(109, 58);
            this.textBoxSwapChopsticks.TabIndex = 16;
            // 
            // label01
            // 
            this.label01.AutoSize = true;
            this.label01.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label01.ForeColor = System.Drawing.Color.Navy;
            this.label01.Location = new System.Drawing.Point(104, 812);
            this.label01.Name = "label01";
            this.label01.Size = new System.Drawing.Size(40, 42);
            this.label01.TabIndex = 17;
            this.label01.Text = "1";
            // 
            // label02
            // 
            this.label02.AutoSize = true;
            this.label02.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label02.ForeColor = System.Drawing.Color.Navy;
            this.label02.Location = new System.Drawing.Point(296, 812);
            this.label02.Name = "label02";
            this.label02.Size = new System.Drawing.Size(40, 42);
            this.label02.TabIndex = 18;
            this.label02.Text = "2";
            // 
            // label03
            // 
            this.label03.AutoSize = true;
            this.label03.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label03.ForeColor = System.Drawing.Color.Navy;
            this.label03.Location = new System.Drawing.Point(466, 812);
            this.label03.Name = "label03";
            this.label03.Size = new System.Drawing.Size(40, 42);
            this.label03.TabIndex = 19;
            this.label03.Text = "3";
            // 
            // label04
            // 
            this.label04.AutoSize = true;
            this.label04.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label04.ForeColor = System.Drawing.Color.Navy;
            this.label04.Location = new System.Drawing.Point(667, 812);
            this.label04.Name = "label04";
            this.label04.Size = new System.Drawing.Size(40, 42);
            this.label04.TabIndex = 20;
            this.label04.Text = "4";
            // 
            // label05
            // 
            this.label05.AutoSize = true;
            this.label05.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label05.ForeColor = System.Drawing.Color.Navy;
            this.label05.Location = new System.Drawing.Point(842, 812);
            this.label05.Name = "label05";
            this.label05.Size = new System.Drawing.Size(40, 42);
            this.label05.TabIndex = 21;
            this.label05.Text = "5";
            // 
            // label06
            // 
            this.label06.AutoSize = true;
            this.label06.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label06.ForeColor = System.Drawing.Color.Navy;
            this.label06.Location = new System.Drawing.Point(1033, 812);
            this.label06.Name = "label06";
            this.label06.Size = new System.Drawing.Size(40, 42);
            this.label06.TabIndex = 22;
            this.label06.Text = "6";
            // 
            // label07
            // 
            this.label07.AutoSize = true;
            this.label07.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label07.ForeColor = System.Drawing.Color.Navy;
            this.label07.Location = new System.Drawing.Point(1227, 812);
            this.label07.Name = "label07";
            this.label07.Size = new System.Drawing.Size(40, 42);
            this.label07.TabIndex = 23;
            this.label07.Text = "7";
            // 
            // label08
            // 
            this.label08.AutoSize = true;
            this.label08.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label08.ForeColor = System.Drawing.Color.Navy;
            this.label08.Location = new System.Drawing.Point(1411, 812);
            this.label08.Name = "label08";
            this.label08.Size = new System.Drawing.Size(40, 42);
            this.label08.TabIndex = 24;
            this.label08.Text = "8";
            // 
            // label09
            // 
            this.label09.AutoSize = true;
            this.label09.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label09.ForeColor = System.Drawing.Color.Navy;
            this.label09.Location = new System.Drawing.Point(1592, 812);
            this.label09.Name = "label09";
            this.label09.Size = new System.Drawing.Size(40, 42);
            this.label09.TabIndex = 25;
            this.label09.Text = "9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(1758, 812);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 42);
            this.label10.TabIndex = 26;
            this.label10.Text = "10";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonExit.Font = new System.Drawing.Font("Modern No. 20", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.Maroon;
            this.buttonExit.Location = new System.Drawing.Point(838, 8);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(209, 68);
            this.buttonExit.TabIndex = 27;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Palatino Linotype", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.BlueViolet;
            this.label14.Location = new System.Drawing.Point(1513, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(321, 57);
            this.label14.TabIndex = 28;
            this.label14.Text = "Current Round:";
            // 
            // textBoxRound
            // 
            this.textBoxRound.BackColor = System.Drawing.Color.Thistle;
            this.textBoxRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRound.ForeColor = System.Drawing.Color.BlueViolet;
            this.textBoxRound.Location = new System.Drawing.Point(1840, 9);
            this.textBoxRound.Name = "textBoxRound";
            this.textBoxRound.ReadOnly = true;
            this.textBoxRound.Size = new System.Drawing.Size(69, 56);
            this.textBoxRound.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(21, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(282, 65);
            this.label15.TabIndex = 30;
            this.label15.Text = "Sushi Go";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Trebuchet MS", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.SeaGreen;
            this.label17.Location = new System.Drawing.Point(685, 110);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(235, 46);
            this.label17.TabIndex = 33;
            this.label17.Text = "Total Points:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(1048, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 46);
            this.label2.TabIndex = 34;
            this.label2.Text = "Pudding Cards:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Trebuchet MS", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Goldenrod;
            this.label16.Location = new System.Drawing.Point(1048, 421);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(279, 46);
            this.label16.TabIndex = 35;
            this.label16.Text = "Pudding Cards:";
            // 
            // textBoxCompPudding
            // 
            this.textBoxCompPudding.BackColor = System.Drawing.Color.Khaki;
            this.textBoxCompPudding.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCompPudding.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.textBoxCompPudding.Location = new System.Drawing.Point(1333, 106);
            this.textBoxCompPudding.Name = "textBoxCompPudding";
            this.textBoxCompPudding.ReadOnly = true;
            this.textBoxCompPudding.Size = new System.Drawing.Size(88, 49);
            this.textBoxCompPudding.TabIndex = 36;
            // 
            // textBoxHumanPudding
            // 
            this.textBoxHumanPudding.BackColor = System.Drawing.Color.Khaki;
            this.textBoxHumanPudding.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHumanPudding.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.textBoxHumanPudding.Location = new System.Drawing.Point(1333, 418);
            this.textBoxHumanPudding.Name = "textBoxHumanPudding";
            this.textBoxHumanPudding.ReadOnly = true;
            this.textBoxHumanPudding.Size = new System.Drawing.Size(88, 49);
            this.textBoxHumanPudding.TabIndex = 37;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Trebuchet MS", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label18.Location = new System.Drawing.Point(261, 427);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(285, 46);
            this.label18.TabIndex = 38;
            this.label18.Text = "Current Points:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Trebuchet MS", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.SeaGreen;
            this.label19.Location = new System.Drawing.Point(685, 424);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(235, 46);
            this.label19.TabIndex = 39;
            this.label19.Text = "Total Points:";
            // 
            // textBoxTotalCPoint
            // 
            this.textBoxTotalCPoint.BackColor = System.Drawing.Color.LightGreen;
            this.textBoxTotalCPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalCPoint.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.textBoxTotalCPoint.Location = new System.Drawing.Point(926, 106);
            this.textBoxTotalCPoint.Name = "textBoxTotalCPoint";
            this.textBoxTotalCPoint.ReadOnly = true;
            this.textBoxTotalCPoint.Size = new System.Drawing.Size(88, 49);
            this.textBoxTotalCPoint.TabIndex = 40;
            // 
            // textBoxTotalHPoint
            // 
            this.textBoxTotalHPoint.BackColor = System.Drawing.Color.LightGreen;
            this.textBoxTotalHPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalHPoint.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.textBoxTotalHPoint.Location = new System.Drawing.Point(923, 422);
            this.textBoxTotalHPoint.Name = "textBoxTotalHPoint";
            this.textBoxTotalHPoint.ReadOnly = true;
            this.textBoxTotalHPoint.Size = new System.Drawing.Size(91, 49);
            this.textBoxTotalHPoint.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 54);
            this.label1.TabIndex = 4;
            this.label1.Text = "Computer";
            // 
            // pictureBoxComputerBoard
            // 
            this.pictureBoxComputerBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pictureBoxComputerBoard.Location = new System.Drawing.Point(21, 178);
            this.pictureBoxComputerBoard.Name = "pictureBoxComputerBoard";
            this.pictureBoxComputerBoard.Size = new System.Drawing.Size(1888, 234);
            this.pictureBoxComputerBoard.TabIndex = 6;
            this.pictureBoxComputerBoard.TabStop = false;
            // 
            // buttonNextRound
            // 
            this.buttonNextRound.BackColor = System.Drawing.Color.Bisque;
            this.buttonNextRound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonNextRound.Font = new System.Drawing.Font("Modern No. 20", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNextRound.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonNextRound.Location = new System.Drawing.Point(552, 8);
            this.buttonNextRound.Name = "buttonNextRound";
            this.buttonNextRound.Size = new System.Drawing.Size(263, 67);
            this.buttonNextRound.TabIndex = 43;
            this.buttonNextRound.Text = "Next Round";
            this.buttonNextRound.UseVisualStyleBackColor = false;
            this.buttonNextRound.Click += new System.EventHandler(this.buttonNextRound_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Monotype Corsiva", 7.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Location = new System.Drawing.Point(174, 1107);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(262, 25);
            this.label20.TabIndex = 44;
            this.label20.Text = "* Game by Phil Walker - Harding";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Monotype Corsiva", 7.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(442, 1107);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(284, 25);
            this.label21.TabIndex = 45;
            this.label21.Text = "*  Illustrations by Nan Rangsima  *";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Monotype Corsiva", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label22.Location = new System.Drawing.Point(15, 1101);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(153, 33);
            this.label22.TabIndex = 46;
            this.label22.Text = "@Gamewright";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SlateBlue;
            this.pictureBox1.Location = new System.Drawing.Point(21, 808);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1888, 52);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // checkBoxHard
            // 
            this.checkBoxHard.AutoSize = true;
            this.checkBoxHard.Font = new System.Drawing.Font("Palatino Linotype", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHard.ForeColor = System.Drawing.Color.DarkMagenta;
            this.checkBoxHard.Location = new System.Drawing.Point(1069, 13);
            this.checkBoxHard.Name = "checkBoxHard";
            this.checkBoxHard.Size = new System.Drawing.Size(169, 62);
            this.checkBoxHard.TabIndex = 49;
            this.checkBoxHard.Text = "Hard ";
            this.checkBoxHard.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1921, 1141);
            this.Controls.Add(this.checkBoxHard);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.buttonNextRound);
            this.Controls.Add(this.textBoxTotalHPoint);
            this.Controls.Add(this.textBoxTotalCPoint);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBoxHumanPudding);
            this.Controls.Add(this.textBoxCompPudding);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxRound);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label09);
            this.Controls.Add(this.label08);
            this.Controls.Add(this.label07);
            this.Controls.Add(this.label06);
            this.Controls.Add(this.label05);
            this.Controls.Add(this.label04);
            this.Controls.Add(this.label03);
            this.Controls.Add(this.label02);
            this.Controls.Add(this.label01);
            this.Controls.Add(this.textBoxSwapChopsticks);
            this.Controls.Add(this.buttonUseChopsticks);
            this.Controls.Add(this.buttonChoose);
            this.Controls.Add(this.textBoxChoose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCompScore);
            this.Controls.Add(this.textBoxHumanPoint);
            this.Controls.Add(this.pictureBoxHumanHand);
            this.Controls.Add(this.pictureBoxComputerBoard);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.pictureBoxHumanBoard);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHumanBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHumanHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComputerBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxHumanBoard;
        private System.Windows.Forms.Label Player;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.PictureBox pictureBoxHumanHand;
        private System.Windows.Forms.TextBox textBoxHumanPoint;
        private System.Windows.Forms.TextBox textBoxCompScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxChoose;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Button buttonUseChopsticks;
        private System.Windows.Forms.TextBox textBoxSwapChopsticks;
        private System.Windows.Forms.Label label01;
        private System.Windows.Forms.Label label02;
        private System.Windows.Forms.Label label03;
        private System.Windows.Forms.Label label04;
        private System.Windows.Forms.Label label05;
        private System.Windows.Forms.Label label06;
        private System.Windows.Forms.Label label07;
        private System.Windows.Forms.Label label08;
        private System.Windows.Forms.Label label09;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxRound;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxCompPudding;
        private System.Windows.Forms.TextBox textBoxHumanPudding;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxTotalCPoint;
        private System.Windows.Forms.TextBox textBoxTotalHPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxComputerBoard;
        private System.Windows.Forms.Button buttonNextRound;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxHard;
    }
}

