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
            panelLetterGuess = new FlowLayoutPanel();
            lblLetterGuess = new Label();
            tblLetterDisplay = new TableLayoutPanel();
            btnAlphaB = new Button();
            btnAlphaA = new Button();
            btnAlphaX = new Button();
            this.btnAlphaY = new Button();
            this.btnAlphaV = new Button();
            this.btnAlphaW = new Button();
            this.btnAlphaU = new Button();
            this.btnAlphaR = new Button();
            this.btnAlphaS = new Button();
            this.btnAlphaT = new Button();
            btnAlphaC = new Button();
            btnAlphaD = new Button();
            btnAlphaE = new Button();
            btnAlphaG = new Button();
            this.btnAlphaH = new Button();
            btnAlphaI = new Button();
            btnAlphaJ = new Button();
            btnAlphaK = new Button();
            btnAlphaL = new Button();
            btnAlphaM = new Button();
            this.btnAlphaN = new Button();
            this.btnAlphaO = new Button();
            this.btnAlphaP = new Button();
            this.btnAlphaQ = new Button();
            btnAlphaF = new Button();
            btnAlphaZ = new Button();
            Menu.SuspendLayout();
            tblMain.SuspendLayout();
            panelWordDisplay.SuspendLayout();
            panelLetterGuess.SuspendLayout();
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
            tblMain.Controls.Add(panelLetterGuess, 1, 1);
            tblMain.Controls.Add(tblLetterDisplay, 1, 2);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 49);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 3;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 38.38772F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 23.2245655F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 38.38772F));
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
            panelWordDisplay.Size = new Size(541, 164);
            panelWordDisplay.TabIndex = 1;
            // 
            // lblWordDisplay
            // 
            lblWordDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblWordDisplay.BackColor = SystemColors.ScrollBar;
            lblWordDisplay.Location = new Point(3, 0);
            lblWordDisplay.Name = "lblWordDisplay";
            lblWordDisplay.Size = new Size(520, 35);
            lblWordDisplay.TabIndex = 0;
            lblWordDisplay.Text = "Word";
            lblWordDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWordGuess
            // 
            lblWordGuess.Location = new Point(3, 35);
            lblWordGuess.Name = "lblWordGuess";
            lblWordGuess.Size = new Size(520, 112);
            lblWordGuess.TabIndex = 1;
            lblWordGuess.Text = "label1";
            // 
            // panelLetterGuess
            // 
            panelLetterGuess.Controls.Add(lblLetterGuess);
            panelLetterGuess.Dock = DockStyle.Fill;
            panelLetterGuess.Location = new Point(283, 173);
            panelLetterGuess.Name = "panelLetterGuess";
            panelLetterGuess.Size = new Size(541, 96);
            panelLetterGuess.TabIndex = 2;
            // 
            // lblLetterGuess
            // 
            lblLetterGuess.Location = new Point(3, 0);
            lblLetterGuess.Name = "lblLetterGuess";
            lblLetterGuess.Size = new Size(520, 90);
            lblLetterGuess.TabIndex = 0;
            lblLetterGuess.Text = "label1";
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
            tblLetterDisplay.Controls.Add(this.btnAlphaQ, 8, 1);
            tblLetterDisplay.Controls.Add(this.btnAlphaP, 7, 1);
            tblLetterDisplay.Controls.Add(this.btnAlphaO, 6, 1);
            tblLetterDisplay.Controls.Add(this.btnAlphaN, 5, 1);
            tblLetterDisplay.Controls.Add(btnAlphaM, 4, 1);
            tblLetterDisplay.Controls.Add(btnAlphaL, 3, 1);
            tblLetterDisplay.Controls.Add(btnAlphaK, 2, 1);
            tblLetterDisplay.Controls.Add(btnAlphaJ, 1, 1);
            tblLetterDisplay.Controls.Add(btnAlphaI, 0, 1);
            tblLetterDisplay.Controls.Add(this.btnAlphaH, 8, 0);
            tblLetterDisplay.Controls.Add(btnAlphaE, 5, 0);
            tblLetterDisplay.Controls.Add(btnAlphaD, 4, 0);
            tblLetterDisplay.Controls.Add(this.btnAlphaT, 0, 2);
            tblLetterDisplay.Controls.Add(this.btnAlphaS, 0, 2);
            tblLetterDisplay.Controls.Add(this.btnAlphaR, 0, 2);
            tblLetterDisplay.Controls.Add(this.btnAlphaU, 0, 2);
            tblLetterDisplay.Controls.Add(this.btnAlphaW, 0, 2);
            tblLetterDisplay.Controls.Add(this.btnAlphaV, 0, 2);
            tblLetterDisplay.Controls.Add(this.btnAlphaY, 0, 2);
            tblLetterDisplay.Controls.Add(btnAlphaX, 0, 2);
            tblLetterDisplay.Controls.Add(btnAlphaB, 2, 0);
            tblLetterDisplay.Controls.Add(btnAlphaA, 1, 0);
            tblLetterDisplay.Controls.Add(btnAlphaC, 3, 0);
            tblLetterDisplay.Controls.Add(btnAlphaG, 7, 0);
            tblLetterDisplay.Controls.Add(btnAlphaF, 6, 0);
            tblLetterDisplay.Controls.Add(btnAlphaZ, 8, 2);
            tblLetterDisplay.Dock = DockStyle.Fill;
            tblLetterDisplay.Location = new Point(283, 275);
            tblLetterDisplay.Name = "tblLetterDisplay";
            tblLetterDisplay.RowCount = 3;
            tblLetterDisplay.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblLetterDisplay.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblLetterDisplay.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblLetterDisplay.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblLetterDisplay.Size = new Size(541, 165);
            tblLetterDisplay.TabIndex = 3;
            // 
            // btnAlphaB
            // 
            btnAlphaB.Dock = DockStyle.Fill;
            btnAlphaB.Location = new Point(123, 3);
            btnAlphaB.Name = "btnAlphaB";
            btnAlphaB.Size = new Size(54, 49);
            btnAlphaB.TabIndex = 2;
            btnAlphaB.Text = "B";
            btnAlphaB.UseVisualStyleBackColor = true;
            // 
            // btnAlphaA
            // 
            btnAlphaA.Dock = DockStyle.Fill;
            btnAlphaA.Location = new Point(63, 3);
            btnAlphaA.Name = "btnAlphaA";
            btnAlphaA.Size = new Size(54, 49);
            btnAlphaA.TabIndex = 1;
            btnAlphaA.Text = "A";
            btnAlphaA.UseVisualStyleBackColor = true;
            // 
            // btnAlphaX
            // 
            btnAlphaX.Dock = DockStyle.Fill;
            btnAlphaX.Location = new Point(3, 113);
            btnAlphaX.Name = "btnAlphaX";
            btnAlphaX.Size = new Size(54, 49);
            btnAlphaX.TabIndex = 3;
            btnAlphaX.Text = "X";
            btnAlphaX.UseVisualStyleBackColor = true;
            // 
            // btnAlphaY
            // 
            this.btnAlphaY.Dock = DockStyle.Fill;
            this.btnAlphaY.Location = new Point(63, 113);
            this.btnAlphaY.Name = "btnAlphaY";
            this.btnAlphaY.Size = new Size(54, 49);
            this.btnAlphaY.TabIndex = 4;
            this.btnAlphaY.Text = "Y";
            this.btnAlphaY.UseVisualStyleBackColor = true;
            // 
            // btnAlphaV
            // 
            this.btnAlphaV.Dock = DockStyle.Fill;
            this.btnAlphaV.Location = new Point(303, 113);
            this.btnAlphaV.Name = "btnAlphaV";
            this.btnAlphaV.Size = new Size(54, 49);
            this.btnAlphaV.TabIndex = 5;
            this.btnAlphaV.Text = "V";
            this.btnAlphaV.UseVisualStyleBackColor = true;
            // 
            // btnAlphaW
            // 
            this.btnAlphaW.Dock = DockStyle.Fill;
            this.btnAlphaW.Location = new Point(363, 113);
            this.btnAlphaW.Name = "btnAlphaW";
            this.btnAlphaW.Size = new Size(54, 49);
            this.btnAlphaW.TabIndex = 6;
            this.btnAlphaW.Text = "W";
            this.btnAlphaW.UseVisualStyleBackColor = true;
            // 
            // btnAlphaU
            // 
            this.btnAlphaU.Dock = DockStyle.Fill;
            this.btnAlphaU.Location = new Point(423, 113);
            this.btnAlphaU.Name = "btnAlphaU";
            this.btnAlphaU.Size = new Size(54, 49);
            this.btnAlphaU.TabIndex = 7;
            this.btnAlphaU.Text = "U";
            this.btnAlphaU.UseVisualStyleBackColor = true;
            // 
            // btnAlphaR
            // 
            this.btnAlphaR.Dock = DockStyle.Fill;
            this.btnAlphaR.Location = new Point(123, 113);
            this.btnAlphaR.Name = "btnAlphaR";
            this.btnAlphaR.Size = new Size(54, 49);
            this.btnAlphaR.TabIndex = 8;
            this.btnAlphaR.Text = "R";
            this.btnAlphaR.UseVisualStyleBackColor = true;
            // 
            // btnAlphaS
            // 
            this.btnAlphaS.Dock = DockStyle.Fill;
            this.btnAlphaS.Location = new Point(183, 113);
            this.btnAlphaS.Name = "btnAlphaS";
            this.btnAlphaS.Size = new Size(54, 49);
            this.btnAlphaS.TabIndex = 9;
            this.btnAlphaS.Text = "S";
            this.btnAlphaS.UseVisualStyleBackColor = true;
            // 
            // btnAlphaT
            // 
            this.btnAlphaT.Dock = DockStyle.Fill;
            this.btnAlphaT.Location = new Point(243, 113);
            this.btnAlphaT.Name = "btnAlphaT";
            this.btnAlphaT.Size = new Size(54, 49);
            this.btnAlphaT.TabIndex = 10;
            this.btnAlphaT.Text = "T";
            this.btnAlphaT.UseVisualStyleBackColor = true;
            // 
            // btnAlphaC
            // 
            btnAlphaC.Dock = DockStyle.Fill;
            btnAlphaC.Location = new Point(183, 3);
            btnAlphaC.Name = "btnAlphaC";
            btnAlphaC.Size = new Size(54, 49);
            btnAlphaC.TabIndex = 12;
            btnAlphaC.Text = "C";
            btnAlphaC.UseVisualStyleBackColor = true;
            // 
            // btnAlphaD
            // 
            btnAlphaD.Dock = DockStyle.Fill;
            btnAlphaD.Location = new Point(243, 3);
            btnAlphaD.Name = "btnAlphaD";
            btnAlphaD.Size = new Size(54, 49);
            btnAlphaD.TabIndex = 13;
            btnAlphaD.Text = "D";
            btnAlphaD.UseVisualStyleBackColor = true;
            // 
            // btnAlphaE
            // 
            btnAlphaE.Dock = DockStyle.Fill;
            btnAlphaE.Location = new Point(303, 3);
            btnAlphaE.Name = "btnAlphaE";
            btnAlphaE.Size = new Size(54, 49);
            btnAlphaE.TabIndex = 14;
            btnAlphaE.Text = "E";
            btnAlphaE.UseVisualStyleBackColor = true;
            // 
            // btnAlphaG
            // 
            btnAlphaG.Dock = DockStyle.Fill;
            btnAlphaG.Location = new Point(423, 3);
            btnAlphaG.Name = "btnAlphaG";
            btnAlphaG.Size = new Size(54, 49);
            btnAlphaG.TabIndex = 15;
            btnAlphaG.Text = "G";
            btnAlphaG.UseVisualStyleBackColor = true;
            // 
            // btnAlphaH
            // 
            this.btnAlphaH.Dock = DockStyle.Fill;
            this.btnAlphaH.Location = new Point(483, 3);
            this.btnAlphaH.Name = "btnAlphaH";
            this.btnAlphaH.Size = new Size(55, 49);
            this.btnAlphaH.TabIndex = 17;
            this.btnAlphaH.Text = "H";
            this.btnAlphaH.UseVisualStyleBackColor = true;
            // 
            // btnAlphaI
            // 
            btnAlphaI.Dock = DockStyle.Fill;
            btnAlphaI.Location = new Point(3, 58);
            btnAlphaI.Name = "btnAlphaI";
            btnAlphaI.Size = new Size(54, 49);
            btnAlphaI.TabIndex = 18;
            btnAlphaI.Text = "I";
            btnAlphaI.UseVisualStyleBackColor = true;
            // 
            // btnAlphaJ
            // 
            btnAlphaJ.Dock = DockStyle.Fill;
            btnAlphaJ.Location = new Point(63, 58);
            btnAlphaJ.Name = "btnAlphaJ";
            btnAlphaJ.Size = new Size(54, 49);
            btnAlphaJ.TabIndex = 19;
            btnAlphaJ.Text = "J";
            btnAlphaJ.UseVisualStyleBackColor = true;
            // 
            // btnAlphaK
            // 
            btnAlphaK.Dock = DockStyle.Fill;
            btnAlphaK.Location = new Point(123, 58);
            btnAlphaK.Name = "btnAlphaK";
            btnAlphaK.Size = new Size(54, 49);
            btnAlphaK.TabIndex = 20;
            btnAlphaK.Text = "K";
            btnAlphaK.UseVisualStyleBackColor = true;
            // 
            // btnAlphaL
            // 
            btnAlphaL.Dock = DockStyle.Fill;
            btnAlphaL.Location = new Point(183, 58);
            btnAlphaL.Name = "btnAlphaL";
            btnAlphaL.Size = new Size(54, 49);
            btnAlphaL.TabIndex = 21;
            btnAlphaL.Text = "L";
            btnAlphaL.UseVisualStyleBackColor = true;
            // 
            // btnAlphaM
            // 
            btnAlphaM.Dock = DockStyle.Fill;
            btnAlphaM.Location = new Point(243, 58);
            btnAlphaM.Name = "btnAlphaM";
            btnAlphaM.Size = new Size(54, 49);
            btnAlphaM.TabIndex = 22;
            btnAlphaM.Text = "M";
            btnAlphaM.UseVisualStyleBackColor = true;
            // 
            // btnAlphaN
            // 
            this.btnAlphaN.Dock = DockStyle.Fill;
            this.btnAlphaN.Location = new Point(303, 58);
            this.btnAlphaN.Name = "btnAlphaN";
            this.btnAlphaN.Size = new Size(54, 49);
            this.btnAlphaN.TabIndex = 23;
            this.btnAlphaN.Text = "N";
            this.btnAlphaN.UseVisualStyleBackColor = true;
            // 
            // btnAlphaO
            // 
            this.btnAlphaO.Dock = DockStyle.Fill;
            this.btnAlphaO.Location = new Point(363, 58);
            this.btnAlphaO.Name = "btnAlphaO";
            this.btnAlphaO.Size = new Size(54, 49);
            this.btnAlphaO.TabIndex = 24;
            this.btnAlphaO.Text = "O";
            this.btnAlphaO.UseVisualStyleBackColor = true;
            // 
            // btnAlphaP
            // 
            this.btnAlphaP.Dock = DockStyle.Fill;
            this.btnAlphaP.Location = new Point(423, 58);
            this.btnAlphaP.Name = "btnAlphaP";
            this.btnAlphaP.Size = new Size(54, 49);
            this.btnAlphaP.TabIndex = 25;
            this.btnAlphaP.Text = "P";
            this.btnAlphaP.UseVisualStyleBackColor = true;
            // 
            // btnAlphaQ
            // 
            this.btnAlphaQ.Dock = DockStyle.Fill;
            this.btnAlphaQ.Location = new Point(483, 58);
            this.btnAlphaQ.Name = "btnAlphaQ";
            this.btnAlphaQ.Size = new Size(55, 49);
            this.btnAlphaQ.TabIndex = 26;
            this.btnAlphaQ.Text = "Q";
            this.btnAlphaQ.UseVisualStyleBackColor = true;
            // 
            // btnAlphaF
            // 
            btnAlphaF.Dock = DockStyle.Fill;
            btnAlphaF.Location = new Point(363, 3);
            btnAlphaF.Name = "btnAlphaF";
            btnAlphaF.Size = new Size(54, 49);
            btnAlphaF.TabIndex = 27;
            btnAlphaF.Text = "F";
            btnAlphaF.UseVisualStyleBackColor = true;
            // 
            // btnAlphaZ
            // 
            btnAlphaZ.Dock = DockStyle.Fill;
            btnAlphaZ.Location = new Point(483, 113);
            btnAlphaZ.Name = "btnAlphaZ";
            btnAlphaZ.Size = new Size(55, 49);
            btnAlphaZ.TabIndex = 28;
            btnAlphaZ.Text = "Z";
            btnAlphaZ.UseVisualStyleBackColor = true;
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
            panelWordDisplay.ResumeLayout(false);
            panelLetterGuess.ResumeLayout(false);
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
        private FlowLayoutPanel panelLetterGuess;
        private Label lblWordDisplay;
        private Label lblWordGuess;
        private Label lblLetterGuess;
        private TableLayoutPanel tblLetterDisplay;
        private Button btnAlphaA;
        private Button btnAlphaB;
        private Button button27;
        private Button button26;
        private Button button25;
        private Button btnAlpha;
        private Button btnAlphaM;
        private Button btnAlphaL;
        private Button btnAlphaK;
        private Button btnAlphaJ;
        private Button btnAlphaI;
        private Button button18;
        private Button btnAlphaG;
        private Button btnAlphaE;
        private Button btnAlphaD;
        private Button btnAlphaF;
        private Button btnAlphaZ;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button btnAlphaX;
        private Button btnAlphaC;
        private Button btnAlphah;
    }
}