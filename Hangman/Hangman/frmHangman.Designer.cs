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
            panelGallows = new FlowLayoutPanel();
            panelWordDisplay = new FlowLayoutPanel();
            lblWordDisplay = new Label();
            lblWordGuess = new Label();
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
            Menu.SuspendLayout();
            tblMain.SuspendLayout();
            panelWordDisplay.SuspendLayout();
            tblLetterDisplay.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.AutoSize = false;
            Menu.BackColor = SystemColors.ControlLight;
            Menu.Items.AddRange(new ToolStripItem[] { btnStart, toolStripSeparator1, btnNewWord, toolStripSeparator2, lblGameStatus, toolStripSeparator3, lblScore });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(827, 49);
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
            toolStripSeparator1.Size = new Size(6, 49);
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
            toolStripSeparator2.Size = new Size(6, 49);
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
            toolStripSeparator3.Size = new Size(6, 49);
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
            tblMain.Controls.Add(panelGallows, 0, 0);
            tblMain.Controls.Add(panelWordDisplay, 1, 0);
            tblMain.Controls.Add(tblLetterDisplay, 1, 2);
            tblMain.Controls.Add(lblLetterGuess, 1, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 49);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 3;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 41.827877F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.3442421F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 41.827877F));
            tblMain.Size = new Size(827, 443);
            tblMain.TabIndex = 1;
            // 
            // panelGallows
            // 
            panelGallows.Dock = DockStyle.Fill;
            panelGallows.Location = new Point(3, 3);
            panelGallows.Name = "panelGallows";
            tblMain.SetRowSpan(panelGallows, 3);
            panelGallows.Size = new Size(274, 437);
            panelGallows.TabIndex = 0;
            // 
            // panelWordDisplay
            // 
            panelWordDisplay.Controls.Add(lblWordDisplay);
            panelWordDisplay.Controls.Add(lblWordGuess);
            panelWordDisplay.Dock = DockStyle.Fill;
            panelWordDisplay.Location = new Point(283, 3);
            panelWordDisplay.Name = "panelWordDisplay";
            panelWordDisplay.Size = new Size(541, 179);
            panelWordDisplay.TabIndex = 1;
            // 
            // lblWordDisplay
            // 
            lblWordDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblWordDisplay.BackColor = SystemColors.ScrollBar;
            lblWordDisplay.Location = new Point(3, 0);
            lblWordDisplay.Name = "lblWordDisplay";
            lblWordDisplay.Size = new Size(535, 35);
            lblWordDisplay.TabIndex = 0;
            lblWordDisplay.Text = "Word";
            lblWordDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWordGuess
            // 
            lblWordGuess.Font = new Font("Webdings", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblWordGuess.Location = new Point(3, 35);
            lblWordGuess.Name = "lblWordGuess";
            lblWordGuess.Size = new Size(535, 129);
            lblWordGuess.TabIndex = 1;
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
            tblLetterDisplay.Location = new Point(283, 260);
            tblLetterDisplay.Name = "tblLetterDisplay";
            tblLetterDisplay.RowCount = 3;
            tblLetterDisplay.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblLetterDisplay.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblLetterDisplay.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblLetterDisplay.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblLetterDisplay.Size = new Size(541, 180);
            tblLetterDisplay.TabIndex = 3;
            // 
            // btnAlphaQ
            // 
            btnAlphaQ.Dock = DockStyle.Fill;
            btnAlphaQ.Location = new Point(483, 63);
            btnAlphaQ.Name = "btnAlphaQ";
            btnAlphaQ.Size = new Size(55, 54);
            btnAlphaQ.TabIndex = 26;
            btnAlphaQ.Text = "Q";
            btnAlphaQ.UseVisualStyleBackColor = true;
            // 
            // btnAlphaP
            // 
            btnAlphaP.Dock = DockStyle.Fill;
            btnAlphaP.Location = new Point(423, 63);
            btnAlphaP.Name = "btnAlphaP";
            btnAlphaP.Size = new Size(54, 54);
            btnAlphaP.TabIndex = 25;
            btnAlphaP.Text = "P";
            btnAlphaP.UseVisualStyleBackColor = true;
            // 
            // btnAlphaO
            // 
            btnAlphaO.Dock = DockStyle.Fill;
            btnAlphaO.Location = new Point(363, 63);
            btnAlphaO.Name = "btnAlphaO";
            btnAlphaO.Size = new Size(54, 54);
            btnAlphaO.TabIndex = 24;
            btnAlphaO.Text = "O";
            btnAlphaO.UseVisualStyleBackColor = true;
            // 
            // btnAlphaN
            // 
            btnAlphaN.Dock = DockStyle.Fill;
            btnAlphaN.Location = new Point(303, 63);
            btnAlphaN.Name = "btnAlphaN";
            btnAlphaN.Size = new Size(54, 54);
            btnAlphaN.TabIndex = 23;
            btnAlphaN.Text = "N";
            btnAlphaN.UseVisualStyleBackColor = true;
            // 
            // btnAlphaM
            // 
            btnAlphaM.Dock = DockStyle.Fill;
            btnAlphaM.Location = new Point(243, 63);
            btnAlphaM.Name = "btnAlphaM";
            btnAlphaM.Size = new Size(54, 54);
            btnAlphaM.TabIndex = 22;
            btnAlphaM.Text = "M";
            btnAlphaM.UseVisualStyleBackColor = true;
            // 
            // btnAlphaL
            // 
            btnAlphaL.Dock = DockStyle.Fill;
            btnAlphaL.Location = new Point(183, 63);
            btnAlphaL.Name = "btnAlphaL";
            btnAlphaL.Size = new Size(54, 54);
            btnAlphaL.TabIndex = 21;
            btnAlphaL.Text = "L";
            btnAlphaL.UseVisualStyleBackColor = true;
            // 
            // btnAlphaK
            // 
            btnAlphaK.Dock = DockStyle.Fill;
            btnAlphaK.Location = new Point(123, 63);
            btnAlphaK.Name = "btnAlphaK";
            btnAlphaK.Size = new Size(54, 54);
            btnAlphaK.TabIndex = 20;
            btnAlphaK.Text = "K";
            btnAlphaK.UseVisualStyleBackColor = true;
            // 
            // btnAlphaJ
            // 
            btnAlphaJ.Dock = DockStyle.Fill;
            btnAlphaJ.Location = new Point(63, 63);
            btnAlphaJ.Name = "btnAlphaJ";
            btnAlphaJ.Size = new Size(54, 54);
            btnAlphaJ.TabIndex = 19;
            btnAlphaJ.Text = "J";
            btnAlphaJ.UseVisualStyleBackColor = true;
            // 
            // btnAlphaI
            // 
            btnAlphaI.Dock = DockStyle.Fill;
            btnAlphaI.Location = new Point(3, 63);
            btnAlphaI.Name = "btnAlphaI";
            btnAlphaI.Size = new Size(54, 54);
            btnAlphaI.TabIndex = 18;
            btnAlphaI.Text = "I";
            btnAlphaI.UseVisualStyleBackColor = true;
            // 
            // btnAlphaH
            // 
            btnAlphaH.Dock = DockStyle.Fill;
            btnAlphaH.Location = new Point(483, 3);
            btnAlphaH.Name = "btnAlphaH";
            btnAlphaH.Size = new Size(55, 54);
            btnAlphaH.TabIndex = 17;
            btnAlphaH.Text = "H";
            btnAlphaH.UseVisualStyleBackColor = true;
            // 
            // btnAlphaE
            // 
            btnAlphaE.Dock = DockStyle.Fill;
            btnAlphaE.Location = new Point(303, 3);
            btnAlphaE.Name = "btnAlphaE";
            btnAlphaE.Size = new Size(54, 54);
            btnAlphaE.TabIndex = 14;
            btnAlphaE.Text = "E";
            btnAlphaE.UseVisualStyleBackColor = true;
            // 
            // btnAlphaD
            // 
            btnAlphaD.Dock = DockStyle.Fill;
            btnAlphaD.Location = new Point(243, 3);
            btnAlphaD.Name = "btnAlphaD";
            btnAlphaD.Size = new Size(54, 54);
            btnAlphaD.TabIndex = 13;
            btnAlphaD.Text = "D";
            btnAlphaD.UseVisualStyleBackColor = true;
            // 
            // btnAlphaV
            // 
            btnAlphaV.Dock = DockStyle.Fill;
            btnAlphaV.Location = new Point(243, 123);
            btnAlphaV.Name = "btnAlphaV";
            btnAlphaV.Size = new Size(54, 54);
            btnAlphaV.TabIndex = 10;
            btnAlphaV.Text = "V";
            btnAlphaV.UseVisualStyleBackColor = true;
            // 
            // btnAlphaU
            // 
            btnAlphaU.Dock = DockStyle.Fill;
            btnAlphaU.Location = new Point(183, 123);
            btnAlphaU.Name = "btnAlphaU";
            btnAlphaU.Size = new Size(54, 54);
            btnAlphaU.TabIndex = 9;
            btnAlphaU.Text = "U";
            btnAlphaU.UseVisualStyleBackColor = true;
            // 
            // btnAlphaT
            // 
            btnAlphaT.Dock = DockStyle.Fill;
            btnAlphaT.Location = new Point(123, 123);
            btnAlphaT.Name = "btnAlphaT";
            btnAlphaT.Size = new Size(54, 54);
            btnAlphaT.TabIndex = 8;
            btnAlphaT.Text = "T";
            btnAlphaT.UseVisualStyleBackColor = true;
            // 
            // btnAlphaY
            // 
            btnAlphaY.Dock = DockStyle.Fill;
            btnAlphaY.Location = new Point(423, 123);
            btnAlphaY.Name = "btnAlphaY";
            btnAlphaY.Size = new Size(54, 54);
            btnAlphaY.TabIndex = 7;
            btnAlphaY.Text = "Y";
            btnAlphaY.UseVisualStyleBackColor = true;
            // 
            // btnAlphaX
            // 
            btnAlphaX.Dock = DockStyle.Fill;
            btnAlphaX.Location = new Point(363, 123);
            btnAlphaX.Name = "btnAlphaX";
            btnAlphaX.Size = new Size(54, 54);
            btnAlphaX.TabIndex = 6;
            btnAlphaX.Text = "X";
            btnAlphaX.UseVisualStyleBackColor = true;
            // 
            // btnAlphaW
            // 
            btnAlphaW.Dock = DockStyle.Fill;
            btnAlphaW.Location = new Point(303, 123);
            btnAlphaW.Name = "btnAlphaW";
            btnAlphaW.Size = new Size(54, 54);
            btnAlphaW.TabIndex = 5;
            btnAlphaW.Text = "W";
            btnAlphaW.UseVisualStyleBackColor = true;
            // 
            // btnAlphaS
            // 
            btnAlphaS.Dock = DockStyle.Fill;
            btnAlphaS.Location = new Point(63, 123);
            btnAlphaS.Name = "btnAlphaS";
            btnAlphaS.Size = new Size(54, 54);
            btnAlphaS.TabIndex = 4;
            btnAlphaS.Text = "S";
            btnAlphaS.UseVisualStyleBackColor = true;
            // 
            // btnAlphaR
            // 
            btnAlphaR.Dock = DockStyle.Fill;
            btnAlphaR.Location = new Point(3, 123);
            btnAlphaR.Name = "btnAlphaR";
            btnAlphaR.Size = new Size(54, 54);
            btnAlphaR.TabIndex = 3;
            btnAlphaR.Text = "R";
            btnAlphaR.UseVisualStyleBackColor = true;
            // 
            // btnAlphaB
            // 
            btnAlphaB.Dock = DockStyle.Fill;
            btnAlphaB.Location = new Point(123, 3);
            btnAlphaB.Name = "btnAlphaB";
            btnAlphaB.Size = new Size(54, 54);
            btnAlphaB.TabIndex = 2;
            btnAlphaB.Text = "B";
            btnAlphaB.UseVisualStyleBackColor = true;
            // 
            // btnAlphaA
            // 
            btnAlphaA.Dock = DockStyle.Fill;
            btnAlphaA.Location = new Point(63, 3);
            btnAlphaA.Name = "btnAlphaA";
            btnAlphaA.Size = new Size(54, 54);
            btnAlphaA.TabIndex = 1;
            btnAlphaA.Text = "A";
            btnAlphaA.UseVisualStyleBackColor = true;
            // 
            // btnAlphaC
            // 
            btnAlphaC.Dock = DockStyle.Fill;
            btnAlphaC.Location = new Point(183, 3);
            btnAlphaC.Name = "btnAlphaC";
            btnAlphaC.Size = new Size(54, 54);
            btnAlphaC.TabIndex = 12;
            btnAlphaC.Text = "C";
            btnAlphaC.UseVisualStyleBackColor = true;
            // 
            // btnAlphaG
            // 
            btnAlphaG.Dock = DockStyle.Fill;
            btnAlphaG.Location = new Point(423, 3);
            btnAlphaG.Name = "btnAlphaG";
            btnAlphaG.Size = new Size(54, 54);
            btnAlphaG.TabIndex = 15;
            btnAlphaG.Text = "G";
            btnAlphaG.UseVisualStyleBackColor = true;
            // 
            // btnAlphaF
            // 
            btnAlphaF.Dock = DockStyle.Fill;
            btnAlphaF.Location = new Point(363, 3);
            btnAlphaF.Name = "btnAlphaF";
            btnAlphaF.Size = new Size(54, 54);
            btnAlphaF.TabIndex = 27;
            btnAlphaF.Text = "F";
            btnAlphaF.UseVisualStyleBackColor = true;
            // 
            // btnAlphaZ
            // 
            btnAlphaZ.Dock = DockStyle.Fill;
            btnAlphaZ.Location = new Point(483, 123);
            btnAlphaZ.Name = "btnAlphaZ";
            btnAlphaZ.Size = new Size(55, 54);
            btnAlphaZ.TabIndex = 28;
            btnAlphaZ.Text = "Z";
            btnAlphaZ.UseVisualStyleBackColor = true;
            // 
            // lblLetterGuess
            // 
            lblLetterGuess.AutoSize = true;
            lblLetterGuess.BackColor = SystemColors.ScrollBar;
            lblLetterGuess.Dock = DockStyle.Fill;
            lblLetterGuess.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblLetterGuess.Location = new Point(283, 185);
            lblLetterGuess.Name = "lblLetterGuess";
            lblLetterGuess.Size = new Size(541, 72);
            lblLetterGuess.TabIndex = 4;
            // 
            // frmHangman
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 492);
            Controls.Add(tblMain);
            Controls.Add(Menu);
            Name = "frmHangman";
            Text = "Hangman";
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            panelWordDisplay.ResumeLayout(false);
            tblLetterDisplay.ResumeLayout(false);
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
        private FlowLayoutPanel panelGallows;
        private FlowLayoutPanel panelWordDisplay;
        private Label lblWordDisplay;
        private Label lblWordGuess;
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
    }
}