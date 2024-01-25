# Hangman
Created By: Chani Beck
## Overview
This document describes requirements for the software implementation of the classic game of Hangman. This software will allow a user to play a guessing game with the computer. A description of the game plus the requirements of this implementation are provided below.
## The Game
Hangman is a guessing game where the player is provided with a word and tries to guess it by suggesting letters  within a certain number of guesses. The word to guess is represented by a row of dashes representing each letter of the word. If the guessing player suggests a letter which occurs in the word, the letter is displayed in its correct positions. If the suggested letter does not occur in the word, an element of a hanged stick figure is displayed. The player can win by guessing all the letters that appear in the word, thereby completing the word, before the diagram is completed. However, if the stick figure is complete — signifying that all guesses have been used, the player loses.
