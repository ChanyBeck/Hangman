namespace Hangman
{
    partial class frmHangman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHangman));
            Menu = new ToolStrip();
            btnStart = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnNewWord = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            lblGameStatus = new ToolStripLabel();
            toolStripSeparator3 = new ToolStripSeparator();
            lblScore = new ToolStripLabel();
            tblMain = new TableLayoutPanel();
            tblWordDisplay = new TableLayoutPanel();
            lblWordDisplay = new Label();
            panelWordDisplay = new FlowLayoutPanel();
            tblLetterDisplay = new TableLayoutPanel();
            btnAlphaQ = new Button();
            btnAlphaP = new Button();
            btnAlphaO = new Button();
            btnAlphaN = new Button();
            btnAlphaM = new Button();
            btnAlphaL = new Button();
            btnAlphaK = new Button();
            btnAlphaJ = new Button();
            btnAlphaI = new Button();
            btnAlphaH = new Button();
            btnAlphaE = new Button();
            btnAlphaD = new Button();
            btnAlphaV = new Button();
            btnAlphaU = new Button();
            btnAlphaT = new Button();
            btnAlphaY = new Button();
            btnAlphaX = new Button();
            btnAlphaW = new Button();
            btnAlphaS = new Button();
            btnAlphaR = new Button();
            btnAlphaB = new Button();
            btnAlphaA = new Button();
            btnAlphaC = new Button();
            btnAlphaG = new Button();
            btnAlphaF = new Button();
            btnAlphaZ = new Button();
            lblLetterGuess = new Label();
            picGallows = new PictureBox();
            Menu.SuspendLayout();
            tblMain.SuspendLayout();
            tblWordDisplay.SuspendLayout();
            tblLetterDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picGallows).BeginInit();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.AutoSize = false;
            Menu.BackColor = SystemColors.ControlLight;
            Menu.ImageScalingSize = new Size(20, 20);
            Menu.Items.AddRange(new ToolStripItem[] { btnStart, toolStripSeparator1, btnNewWord, toolStripSeparator2, lblGameStatus, toolStripSeparator3, lblScore });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(945, 65);
            Menu.TabIndex = 0;
            Menu.Text = "toolStrip1";
            // 
            // btnStart
            // 
            btnStart.AutoSize = false;
            btnStart.BackColor = SystemColors.ScrollBar;
            btnStart.BackgroundImageLayout = ImageLayout.None;
            btnStart.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnStart.ImageTransparentColor = Color.Magenta;
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(130, 38);
            btnStart.Text = "Start";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 65);
            // 
            // btnNewWord
            // 
            btnNewWord.AutoSize = false;
            btnNewWord.BackColor = SystemColors.ScrollBar;
            btnNewWord.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnNewWord.Image = (Image)resources.GetObject("btnNewWord.Image");
            btnNewWord.ImageTransparentColor = Color.Magenta;
            btnNewWord.Name = "btnNewWord";
            btnNewWord.Size = new Size(130, 38);
            btnNewWord.Text = "New Word";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 65);
            // 
            // lblGameStatus
            // 
            lblGameStatus.AutoSize = false;
            lblGameStatus.BackColor = SystemColors.ScrollBar;
            lblGameStatus.DisplayStyle = ToolStripItemDisplayStyle.Text;
            lblGameStatus.Name = "lblGameStatus";
            lblGameStatus.Size = new Size(300, 38);
            lblGameStatus.Text = "GameStatus";
            lblGameStatus.TextImageRelation = TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 65);
            // 
            // lblScore
            // 
            lblScore.AutoSize = false;
            lblScore.BackColor = SystemColors.ScrollBar;
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(130, 38);
            lblScore.Text = "Score";
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.96227F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.037735F));
            tblMain.Controls.Add(tblWordDisplay, 1, 0);
            tblMain.Controls.Add(tblLetterDisplay, 1, 2);
            tblMain.Controls.Add(lblLetterGuess, 1, 1);
            tblMain.Controls.Add(picGallows, 0, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 65);
            tblMain.Margin = new Padding(3, 4, 3, 4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 3;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 41.827877F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.3442421F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 41.827877F));
            tblMain.Size = new Size(945, 591);
            tblMain.TabIndex = 1;
            // 
            // tblWordDisplay
            // 
            tblWordDisplay.ColumnCount = 1;
            tblWordDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblWordDisplay.Controls.Add(lblWordDisplay, 0, 0);
            tblWordDisplay.Controls.Add(panelWordDisplay, 0, 2);
            tblWordDisplay.Dock = DockStyle.Fill;
            tblWordDisplay.Location = new Point(323, 4);
            tblWordDisplay.Margin = new Padding(3, 4, 3, 4);
            tblWordDisplay.Name = "tblWordDisplay";
            tblWordDisplay.RowCount = 3;
            tblWordDisplay.RowStyles.Add(new RowStyle(SizeType.Percent, 21.0491314F));
            tblWordDisplay.RowStyles.Add(new RowStyle(SizeType.Percent, 46.16038F));
            tblWordDisplay.RowStyles.Add(new RowStyle(SizeType.Percent, 32.7904854F));
            tblWordDisplay.Size = new Size(619, 239);
            tblWordDisplay.TabIndex = 0;
            // 
            // lblWordDisplay
            // 
            lblWordDisplay.BackColor = SystemColors.ScrollBar;
            lblWordDisplay.Dock = DockStyle.Fill;
            lblWordDisplay.Location = new Point(3, 0);
            lblWordDisplay.Name = "lblWordDisplay";
            lblWordDisplay.Size = new Size(613, 50);
            lblWordDisplay.TabIndex = 0;
            lblWordDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelWordDisplay
            // 
            panelWordDisplay.Dock = DockStyle.Fill;
            panelWordDisplay.Font = new Font("Swis721 Blk BT", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            panelWordDisplay.Location = new Point(3, 164);
            panelWordDisplay.Margin = new Padding(3, 4, 3, 4);
            panelWordDisplay.Name = "panelWordDisplay";
            panelWordDisplay.Size = new Size(613, 71);
            panelWordDisplay.TabIndex = 1;
            // 
            // tblLetterDisplay
            // 
            tblLetterDisplay.ColumnCount = 9;
            tblLetterDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblLetterDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblLetterDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblLetterDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblLetterDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblLetterDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblLetterDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblLetterDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblLetterDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblLetterDisplay.Controls.Add(btnAlphaQ, 8, 1);
            tblLetterDisplay.Controls.Add(btnAlphaP, 7, 1);
            tblLetterDisplay.Controls.Add(btnAlphaO, 6, 1);
            tblLetterDisplay.Controls.Add(btnAlphaN, 5, 1);
            tblLetterDisplay.Controls.Add(btnAlphaM, 4, 1);
            tblLetterDisplay.Controls.Add(btnAlphaL, 3, 1);
            tblLetterDisplay.Controls.Add(btnAlphaK, 2, 1);
            tblLetterDisplay.Controls.Add(btnAlphaJ, 1, 1);
            tblLetterDisplay.Controls.Add(btnAlphaI, 0, 1);
            tblLetterDisplay.Controls.Add(btnAlphaH, 8, 0);
            tblLetterDisplay.Controls.Add(btnAlphaE, 5, 0);
            tblLetterDisplay.Controls.Add(btnAlphaD, 4, 0);
            tblLetterDisplay.Controls.Add(btnAlphaV, 0, 2);
            tblLetterDisplay.Controls.Add(btnAlphaU, 0, 2);
            tblLetterDisplay.Controls.Add(btnAlphaT, 0, 2);
            tblLetterDisplay.Controls.Add(btnAlphaY, 0, 2);
            tblLetterDisplay.Controls.Add(btnAlphaX, 0, 2);
            tblLetterDisplay.Controls.Add(btnAlphaW, 0, 2);
            tblLetterDisplay.Controls.Add(btnAlphaS, 0, 2);
            tblLetterDisplay.Controls.Add(btnAlphaR, 0, 2);
            tblLetterDisplay.Controls.Add(btnAlphaB, 2, 0);
            tblLetterDisplay.Controls.Add(btnAlphaA, 1, 0);
            tblLetterDisplay.Controls.Add(btnAlphaC, 3, 0);
            tblLetterDisplay.Controls.Add(btnAlphaG, 7, 0);
            tblLetterDisplay.Controls.Add(btnAlphaF, 6, 0);
            tblLetterDisplay.Controls.Add(btnAlphaZ, 8, 2);
            tblLetterDisplay.Dock = DockStyle.Fill;
            tblLetterDisplay.Location = new Point(323, 347);
            tblLetterDisplay.Margin = new Padding(3, 4, 3, 4);
            tblLetterDisplay.Name = "tblLetterDisplay";
            tblLetterDisplay.RowCount = 3;
            tblLetterDisplay.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblLetterDisplay.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblLetterDisplay.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblLetterDisplay.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tblLetterDisplay.Size = new Size(619, 240);
            tblLetterDisplay.TabIndex = 2;
            // 
            // btnAlphaQ
            // 
            btnAlphaQ.Dock = DockStyle.Fill;
            btnAlphaQ.Location = new Point(547, 83);
            btnAlphaQ.Margin = new Padding(3, 4, 3, 4);
            btnAlphaQ.Name = "btnAlphaQ";
            btnAlphaQ.Size = new Size(69, 71);
            btnAlphaQ.TabIndex = 16;
            btnAlphaQ.Text = "Q";
            btnAlphaQ.UseVisualStyleBackColor = true;
            // 
            // btnAlphaP
            // 
            btnAlphaP.Dock = DockStyle.Fill;
            btnAlphaP.Location = new Point(479, 83);
            btnAlphaP.Margin = new Padding(3, 4, 3, 4);
            btnAlphaP.Name = "btnAlphaP";
            btnAlphaP.Size = new Size(62, 71);
            btnAlphaP.TabIndex = 15;
            btnAlphaP.Text = "P";
            btnAlphaP.UseVisualStyleBackColor = true;
            // 
            // btnAlphaO
            // 
            btnAlphaO.Dock = DockStyle.Fill;
            btnAlphaO.Location = new Point(411, 83);
            btnAlphaO.Margin = new Padding(3, 4, 3, 4);
            btnAlphaO.Name = "btnAlphaO";
            btnAlphaO.Size = new Size(62, 71);
            btnAlphaO.TabIndex = 14;
            btnAlphaO.Text = "O";
            btnAlphaO.UseVisualStyleBackColor = true;
            // 
            // btnAlphaN
            // 
            btnAlphaN.Dock = DockStyle.Fill;
            btnAlphaN.Location = new Point(343, 83);
            btnAlphaN.Margin = new Padding(3, 4, 3, 4);
            btnAlphaN.Name = "btnAlphaN";
            btnAlphaN.Size = new Size(62, 71);
            btnAlphaN.TabIndex = 13;
            btnAlphaN.Text = "N";
            btnAlphaN.UseVisualStyleBackColor = true;
            // 
            // btnAlphaM
            // 
            btnAlphaM.Dock = DockStyle.Fill;
            btnAlphaM.Location = new Point(275, 83);
            btnAlphaM.Margin = new Padding(3, 4, 3, 4);
            btnAlphaM.Name = "btnAlphaM";
            btnAlphaM.Size = new Size(62, 71);
            btnAlphaM.TabIndex = 12;
            btnAlphaM.Text = "M";
            btnAlphaM.UseVisualStyleBackColor = true;
            // 
            // btnAlphaL
            // 
            btnAlphaL.Dock = DockStyle.Fill;
            btnAlphaL.Location = new Point(207, 83);
            btnAlphaL.Margin = new Padding(3, 4, 3, 4);
            btnAlphaL.Name = "btnAlphaL";
            btnAlphaL.Size = new Size(62, 71);
            btnAlphaL.TabIndex = 11;
            btnAlphaL.Text = "L";
            btnAlphaL.UseVisualStyleBackColor = true;
            // 
            // btnAlphaK
            // 
            btnAlphaK.Dock = DockStyle.Fill;
            btnAlphaK.Location = new Point(139, 83);
            btnAlphaK.Margin = new Padding(3, 4, 3, 4);
            btnAlphaK.Name = "btnAlphaK";
            btnAlphaK.Size = new Size(62, 71);
            btnAlphaK.TabIndex = 10;
            btnAlphaK.Text = "K";
            btnAlphaK.UseVisualStyleBackColor = true;
            // 
            // btnAlphaJ
            // 
            btnAlphaJ.Dock = DockStyle.Fill;
            btnAlphaJ.Location = new Point(71, 83);
            btnAlphaJ.Margin = new Padding(3, 4, 3, 4);
            btnAlphaJ.Name = "btnAlphaJ";
            btnAlphaJ.Size = new Size(62, 71);
            btnAlphaJ.TabIndex = 9;
            btnAlphaJ.Text = "J";
            btnAlphaJ.UseVisualStyleBackColor = true;
            // 
            // btnAlphaI
            // 
            btnAlphaI.Dock = DockStyle.Fill;
            btnAlphaI.Location = new Point(3, 83);
            btnAlphaI.Margin = new Padding(3, 4, 3, 4);
            btnAlphaI.Name = "btnAlphaI";
            btnAlphaI.Size = new Size(62, 71);
            btnAlphaI.TabIndex = 8;
            btnAlphaI.Text = "I";
            btnAlphaI.UseVisualStyleBackColor = true;
            // 
            // btnAlphaH
            // 
            btnAlphaH.Dock = DockStyle.Fill;
            btnAlphaH.Location = new Point(547, 4);
            btnAlphaH.Margin = new Padding(3, 4, 3, 4);
            btnAlphaH.Name = "btnAlphaH";
            btnAlphaH.Size = new Size(69, 71);
            btnAlphaH.TabIndex = 7;
            btnAlphaH.Text = "H";
            btnAlphaH.UseVisualStyleBackColor = true;
            // 
            // btnAlphaE
            // 
            btnAlphaE.Dock = DockStyle.Fill;
            btnAlphaE.Location = new Point(343, 4);
            btnAlphaE.Margin = new Padding(3, 4, 3, 4);
            btnAlphaE.Name = "btnAlphaE";
            btnAlphaE.Size = new Size(62, 71);
            btnAlphaE.TabIndex = 4;
            btnAlphaE.Text = "E";
            btnAlphaE.UseVisualStyleBackColor = true;
            // 
            // btnAlphaD
            // 
            btnAlphaD.Dock = DockStyle.Fill;
            btnAlphaD.Location = new Point(275, 4);
            btnAlphaD.Margin = new Padding(3, 4, 3, 4);
            btnAlphaD.Name = "btnAlphaD";
            btnAlphaD.Size = new Size(62, 71);
            btnAlphaD.TabIndex = 3;
            btnAlphaD.Text = "D";
            btnAlphaD.UseVisualStyleBackColor = true;
            // 
            // btnAlphaV
            // 
            btnAlphaV.Dock = DockStyle.Fill;
            btnAlphaV.Location = new Point(275, 162);
            btnAlphaV.Margin = new Padding(3, 4, 3, 4);
            btnAlphaV.Name = "btnAlphaV";
            btnAlphaV.Size = new Size(62, 74);
            btnAlphaV.TabIndex = 21;
            btnAlphaV.Text = "V";
            btnAlphaV.UseVisualStyleBackColor = true;
            // 
            // btnAlphaU
            // 
            btnAlphaU.Dock = DockStyle.Fill;
            btnAlphaU.Location = new Point(207, 162);
            btnAlphaU.Margin = new Padding(3, 4, 3, 4);
            btnAlphaU.Name = "btnAlphaU";
            btnAlphaU.Size = new Size(62, 74);
            btnAlphaU.TabIndex = 20;
            btnAlphaU.Text = "U";
            btnAlphaU.UseVisualStyleBackColor = true;
            // 
            // btnAlphaT
            // 
            btnAlphaT.Dock = DockStyle.Fill;
            btnAlphaT.Location = new Point(139, 162);
            btnAlphaT.Margin = new Padding(3, 4, 3, 4);
            btnAlphaT.Name = "btnAlphaT";
            btnAlphaT.Size = new Size(62, 74);
            btnAlphaT.TabIndex = 19;
            btnAlphaT.Text = "T";
            btnAlphaT.UseVisualStyleBackColor = true;
            // 
            // btnAlphaY
            // 
            btnAlphaY.Dock = DockStyle.Fill;
            btnAlphaY.Location = new Point(479, 162);
            btnAlphaY.Margin = new Padding(3, 4, 3, 4);
            btnAlphaY.Name = "btnAlphaY";
            btnAlphaY.Size = new Size(62, 74);
            btnAlphaY.TabIndex = 24;
            btnAlphaY.Text = "Y";
            btnAlphaY.UseVisualStyleBackColor = true;
            // 
            // btnAlphaX
            // 
            btnAlphaX.Dock = DockStyle.Fill;
            btnAlphaX.Location = new Point(411, 162);
            btnAlphaX.Margin = new Padding(3, 4, 3, 4);
            btnAlphaX.Name = "btnAlphaX";
            btnAlphaX.Size = new Size(62, 74);
            btnAlphaX.TabIndex = 23;
            btnAlphaX.Text = "X";
            btnAlphaX.UseVisualStyleBackColor = true;
            // 
            // btnAlphaW
            // 
            btnAlphaW.Dock = DockStyle.Fill;
            btnAlphaW.Location = new Point(343, 162);
            btnAlphaW.Margin = new Padding(3, 4, 3, 4);
            btnAlphaW.Name = "btnAlphaW";
            btnAlphaW.Size = new Size(62, 74);
            btnAlphaW.TabIndex = 22;
            btnAlphaW.Text = "W";
            btnAlphaW.UseVisualStyleBackColor = true;
            // 
            // btnAlphaS
            // 
            btnAlphaS.Dock = DockStyle.Fill;
            btnAlphaS.Location = new Point(71, 162);
            btnAlphaS.Margin = new Padding(3, 4, 3, 4);
            btnAlphaS.Name = "btnAlphaS";
            btnAlphaS.Size = new Size(62, 74);
            btnAlphaS.TabIndex = 18;
            btnAlphaS.Text = "S";
            btnAlphaS.UseVisualStyleBackColor = true;
            // 
            // btnAlphaR
            // 
            btnAlphaR.Dock = DockStyle.Fill;
            btnAlphaR.Location = new Point(3, 162);
            btnAlphaR.Margin = new Padding(3, 4, 3, 4);
            btnAlphaR.Name = "btnAlphaR";
            btnAlphaR.Size = new Size(62, 74);
            btnAlphaR.TabIndex = 17;
            btnAlphaR.Text = "R";
            btnAlphaR.UseVisualStyleBackColor = true;
            // 
            // btnAlphaB
            // 
            btnAlphaB.Dock = DockStyle.Fill;
            btnAlphaB.Location = new Point(139, 4);
            btnAlphaB.Margin = new Padding(3, 4, 3, 4);
            btnAlphaB.Name = "btnAlphaB";
            btnAlphaB.Size = new Size(62, 71);
            btnAlphaB.TabIndex = 1;
            btnAlphaB.Text = "B";
            btnAlphaB.UseVisualStyleBackColor = true;
            // 
            // btnAlphaA
            // 
            btnAlphaA.Dock = DockStyle.Fill;
            btnAlphaA.Location = new Point(71, 4);
            btnAlphaA.Margin = new Padding(3, 4, 3, 4);
            btnAlphaA.Name = "btnAlphaA";
            btnAlphaA.Size = new Size(62, 71);
            btnAlphaA.TabIndex = 0;
            btnAlphaA.Text = "A";
            btnAlphaA.UseVisualStyleBackColor = true;
            // 
            // btnAlphaC
            // 
            btnAlphaC.Dock = DockStyle.Fill;
            btnAlphaC.Location = new Point(207, 4);
            btnAlphaC.Margin = new Padding(3, 4, 3, 4);
            btnAlphaC.Name = "btnAlphaC";
            btnAlphaC.Size = new Size(62, 71);
            btnAlphaC.TabIndex = 2;
            btnAlphaC.Text = "C";
            btnAlphaC.UseVisualStyleBackColor = true;
            // 
            // btnAlphaG
            // 
            btnAlphaG.Dock = DockStyle.Fill;
            btnAlphaG.Location = new Point(479, 4);
            btnAlphaG.Margin = new Padding(3, 4, 3, 4);
            btnAlphaG.Name = "btnAlphaG";
            btnAlphaG.Size = new Size(62, 71);
            btnAlphaG.TabIndex = 6;
            btnAlphaG.Text = "G";
            btnAlphaG.UseVisualStyleBackColor = true;
            // 
            // btnAlphaF
            // 
            btnAlphaF.Dock = DockStyle.Fill;
            btnAlphaF.Location = new Point(411, 4);
            btnAlphaF.Margin = new Padding(3, 4, 3, 4);
            btnAlphaF.Name = "btnAlphaF";
            btnAlphaF.Size = new Size(62, 71);
            btnAlphaF.TabIndex = 5;
            btnAlphaF.Text = "F";
            btnAlphaF.UseVisualStyleBackColor = true;
            // 
            // btnAlphaZ
            // 
            btnAlphaZ.Dock = DockStyle.Fill;
            btnAlphaZ.Location = new Point(547, 162);
            btnAlphaZ.Margin = new Padding(3, 4, 3, 4);
            btnAlphaZ.Name = "btnAlphaZ";
            btnAlphaZ.Size = new Size(69, 74);
            btnAlphaZ.TabIndex = 25;
            btnAlphaZ.Text = "Z";
            btnAlphaZ.UseVisualStyleBackColor = true;
            // 
            // lblLetterGuess
            // 
            lblLetterGuess.AutoSize = true;
            lblLetterGuess.BackColor = SystemColors.ScrollBar;
            lblLetterGuess.Dock = DockStyle.Fill;
            lblLetterGuess.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblLetterGuess.Location = new Point(323, 247);
            lblLetterGuess.Name = "lblLetterGuess";
            lblLetterGuess.Size = new Size(619, 96);
            lblLetterGuess.TabIndex = 0;
            // 
            // picGallows
            // 
            picGallows.Dock = DockStyle.Fill;
            picGallows.Location = new Point(3, 4);
            picGallows.Margin = new Padding(3, 4, 3, 4);
            picGallows.Name = "picGallows";
            tblMain.SetRowSpan(picGallows, 3);
            picGallows.Size = new Size(314, 583);
            picGallows.SizeMode = PictureBoxSizeMode.Zoom;
            picGallows.TabIndex = 5;
            picGallows.TabStop = false;
            // 
            // frmHangman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 656);
            Controls.Add(tblMain);
            Controls.Add(Menu);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmHangman";
            Text = "Hangman";
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblWordDisplay.ResumeLayout(false);
            tblLetterDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picGallows).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip Menu;
        private ToolStripButton btnStart;
        private ToolStripButton btnNewWord;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel lblGameStatus;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripLabel lblScore;
        private TableLayoutPanel tblMain;
        private FlowLayoutPanel panelWordDisplay;
        private Label lblWordDisplay;
        private TableLayoutPanel tblLetterDisplay;
        private Button btnAlphaU;
        private Button btnAlphaV;
        private Button btnAlphaQ;
        private Button btnAlphaP;
        private Button btnAlphaO;
        private Button btnAlphaN;
        private Button btnAlphaM;
        private Button btnAlphaL;
        private Button btnAlphaK;
        private Button btnAlphaJ;
        private Button btnAlphaI;
        private Button btnAlphaH;
        private Button btnAlphaG;
        private Button btnAlphaE;
        private Button btnAlphaD;
        private Button btnAlphaF;
        private Button btnAlphaZ;
        private Button btnAlphaS;
        private Button btnAlphaT;
        private Button btnAlphaR;
        private Button btnAlphaY;
        private Button btnAlphaX;
        private Button btnAlphaB;
        private Button btnAlphaA;
        private Button btnAlphaW;
        private Button btnAlphaC;
        private Label lblLetterGuess;
        private TableLayoutPanel tblWordDisplay;
        private PictureBox picGallows;
    }
}