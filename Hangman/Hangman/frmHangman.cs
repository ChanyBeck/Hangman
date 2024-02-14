using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gnuciDictionary;
using System.Diagnostics.CodeAnalysis;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace Hangman
{
    public partial class frmHangman : Form
    {
        List<Word> lstword = gnuciDictionary.EnglishDictionary.GetAllWords().ToList();
        List<Button> lstbuttonalpha = new();
        //List<char> charword = new();
        Random rnd = new();
        int correctletters;

        public frmHangman()
        {
            InitializeComponent();
            btnStart.Click += BtnStart_Click;
            btnNewWord.Click += BtnNewWord_Click;
            //char[] charword = lstword[rnd.Next(0, lstword.Count)].Value.ToString().ToArray();
            lstbuttonalpha.AddRange(from Button b in tblLetterDisplay.Controls select b);
            lstbuttonalpha.ForEach(b => b.Click += BtnAlpha_Click);
            lblGameStatus.Text = "Click Start To Begin";
        }
        private void StartGame()
        {
            GetNewWord();
            lstbuttonalpha.ForEach(b => EnableButton(b));
            lblGameStatus.Text = "Guess A Letter";
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
                    lblLetterGuess.Text += btn.Text;
                    btn.Enabled = false;
                    btn.BackColor = Color.Gray;
                    break;
            }
        }

        private void GetNewWord()
        {
            panelWordDisplay.Controls.Clear();
            char[] charword = lstword[rnd.Next(0, lstword.Count)].Value.ToString().ToArray();
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
            foreach(Label lbl in panelWordDisplay.Controls)
            {
                if (lbl.Text == "_ ")
                {
                    if (lbl.Name == charguessed)
                    {
                        lbl.Text = charguessed;
                        correctletters++;
                    }
                }
            }
            
        }
        private void BtnAlpha_Click(object? sender, EventArgs e)
        {
            Button b = sender as Button;
            EnableButton(b, false);
            LoopWord(b.Text.ToLower());
        }

        private void BtnNewWord_Click(object? sender, EventArgs e)
        {
            StartGame();
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            StartGame();
        }
    }
}
