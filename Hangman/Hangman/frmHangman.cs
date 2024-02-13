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
using System.Drawing.Drawing2D;

namespace Hangman
{
    public partial class frmHangman : Form
    {
        List<Word> lstword = gnuciDictionary.EnglishDictionary.GetAllWords().ToList();
        List<Button> lstbuttonalpha = new();
        string word;
        public frmHangman()
        {
            InitializeComponent();
            btnStart.Click += BtnStart_Click;
            btnNewWord.Click += BtnNewWord_Click;
            //lstbuttonalpha.AddRange(from Button b in tblLetterDisplay.Controls select b);
            foreach (Button b in tblLetterDisplay.Controls)
            {
                b.Click += BtnAlpha_Click;
            }
        }

        private void GetNewWord()
        {
            Random rnd = new();
            //word = lstword[rnd.Next(0, lstword.Count)].Value.ToString();
            char[] charword = lstword[rnd.Next(0, lstword.Count)].Value.ToString().ToArray();
            foreach (char c in charword)
            {
                lblWordGuess.Text += 0;
            }
        }
        private void BtnAlpha_Click(object? sender, EventArgs e)
        {
            Button b = sender as Button;
            lblLetterGuess.Text += b.Text;
            b.Enabled = false;
            b.BackColor = Color.Gray;
        }

        private void BtnNewWord_Click(object? sender, EventArgs e)
        {
            GetNewWord();
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            GetNewWord();
        }
    }
}
