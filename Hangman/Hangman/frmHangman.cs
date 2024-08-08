using gnuciDictionary;
using Button = System.Windows.Forms.Button;

namespace Hangman
{
    public partial class frmHangman : Form
    {
        List<Word> lstword = gnuciDictionary.EnglishDictionary.GetAllWords().ToList();
        List<Button> lstbuttonalpha = new();
        string path = Application.StartupPath + @"\images\gallows pic ";
        string word = "";
        int lettersguessed = 0;
        int guessesused = 1;
        int score = 0;

        public frmHangman()
        {
            InitializeComponent();
            btnStart.Click += BtnStart_NewWord_Click;
            btnNewWord.Click += BtnStart_NewWord_Click;
            lstbuttonalpha.AddRange(from Button b in tblLetterDisplay.Controls select b);
            lstbuttonalpha.ForEach(b => b.Click += BtnAlpha_Click);
            lstbuttonalpha.ForEach(b => EnableButton(b, false));
            btnNewWord.Enabled = false;
            lblGameStatus.Text = "Click Start To Begin";
            picGallows.ImageLocation = path + guessesused + ".PNG";
            lblScore.Text = "Score: " + score;
        }
        private void EnableButton(Button btn, bool b = true)
        {
            switch (b)
            {
                case true:
                    lblLetterGuess.Text = "";
                    btn.Enabled = true;
                    btn.BackColor = Color.White;
                    break;
                case false:
                    btn.Enabled = false;
                    btn.BackColor = Color.Gray;
                    break;
            }
        }

        private void StartGame()
        {
            btnStart.Enabled = false;
            panelWordDisplay.Controls.Clear();
            GetNewWord();
            lettersguessed = 0;
            guessesused = 1;
            lstbuttonalpha.ForEach(b => EnableButton(b));
            btnNewWord.Enabled = true;
            lblGameStatus.Text = "Guess A Letter";
            lblWordDisplay.Text = "";
            picGallows.ImageLocation = path + guessesused + ".PNG";
        }
        private void GetNewWord()
        {
            Random rnd = new();
            word = lstword[rnd.Next(0, lstword.Count)].Value.ToString().ToLower();
            char[] charword = word.ToCharArray();
            foreach (char c in charword)
            {
                Label lbl = new();
                panelWordDisplay.Controls.Add(lbl);
                lbl.Text = "_ ";
                lbl.AutoSize = true;
                lbl.Name = c.ToString().ToLower();
            }
        }
        private void LoopWord(string charguessed)
        {
            foreach (Label lbl in panelWordDisplay.Controls)
            {
                if (lbl.Text == "_ ")
                {
                    if (lbl.Name == charguessed)
                    {
                        lbl.Text = charguessed;
                        lettersguessed++;
                    }
                }
            }
            if (!word.Contains(charguessed))
            {
                guessesused++;
                picGallows.ImageLocation = path + guessesused + ".png";
            }
            if (lettersguessed == word.Length) PlayerWins_Loses("win");
            if (guessesused == 8) PlayerWins_Loses("lose");
        }
        private void PlayerWins_Loses(string gamestatus)
        {
            switch (gamestatus)
            {
                case "win":
                    score++;
                    lblGameStatus.Text = "You Win!!";
                    break;
                case "lose":
                    score--;
                    lblGameStatus.Text = "You Lose";
                    break;
            }

            lblScore.Text = "Score: " + score;
            lstbuttonalpha.ForEach(b => EnableButton(b, false));
            btnNewWord.Enabled = false;
            btnStart.Enabled = true;
            lblWordDisplay.Text = word;
        }
        private void BtnAlpha_Click(object? sender, EventArgs e)
        {
            Button b = new();
            if (sender != null)
            {
                b = sender as Button;
            }
            lblLetterGuess.Text += b.Text;
            EnableButton(b, false);
            LoopWord(b.Text.ToLower());
        }

        private void BtnStart_NewWord_Click(object? sender, EventArgs e)
        {
            StartGame();
        }
    }
}
