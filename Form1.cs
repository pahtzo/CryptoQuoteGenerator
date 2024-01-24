/*
 * CryptoQuote Generator for creating cryptoquotes like those found in newspapers and word puzzle books.
 * Creates two HTML files, one with just the puzzle and reference alphabet to solve
 * and one with the puzzle, solution, and subtitution alphabet.
 * 
 * Nick DeBaggis - 2014, 2024
 */

using CryptoQuoteGenerator.Properties;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Windows.Forms;

namespace CryptoQuoteGenerator
{
    public partial class Form1 : Form
    {
        static string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string key = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string plain = "";
        string plain2 = "";
        string crypted2 = "";
        string shuffled = "";
        string letterspacingpixels;
        string lineheightpercent;

        public Form1()
        {
            InitializeComponent();
            textBox_Alphabet.Text = alphabet;
            textBox_Key.Text = alphabet;
            btn_savesolution.Enabled = false;
            letterspacingpixels = Settings.Default.OutputLetterSpacingPixels;
            lineheightpercent = Settings.Default.OutputLineHeightPercent;
        }

        /*
         * Shuffle the alphabet key into random order.
         */
        private static string Shuffle(string list)
        {
            StringBuilder sb = new StringBuilder();
            Random randomnumber = new Random();
            List<char> chars = new List<char>(list);
            while (chars.Count > 0)
            {
                int index = randomnumber.Next(chars.Count);
                sb.Append(chars[index]);
                chars.RemoveAt(index);
            }
            return sb.ToString();
        }

        /*
         * Check the shuffled alphabet "key" against the ordered alphabet.
         * If the key and alphabet have any matching letters then return false
         * to force another alphabet key shuffle.
         */
        static private bool checkkey(string key)
        {
            for (int i = 0; i < key.Length; i++)
            {
                if (alphabet[i] == key[i])
                {
                    return false;
                }
            }
            return true;
        }

        private void btn_scramble_Click(object sender, EventArgs e)
        {
            shuffled = Shuffle(key);

            // Loop through to ensure the randomized alphabet key has no matching letters in the ordered alphabet.
            // i.e. A != A, B != B, ...
            // This is a bit slow but since we aren't processing batches of cryptoquotes it shouldn't be noticable.
            // Based on code profiling, on average it takes just over 3 shuffles per scramble click
            // to obtain a key where each letter substitution is unique.

            while (checkkey(shuffled) == false)
            {
                shuffled = Shuffle(key);
            }

            textBox_Key.Text = shuffled;
            textBox_PlainText.Text = textBox_PlainText.Text.ToUpper();
            plain = textBox_PlainText.Text;

            char[] crypted = new char[plain.Length];
            StringBuilder sb = new StringBuilder();

            // Perform the cryptoquote substitutions.
            for (int i = 0; i < plain.Length; i++)
            {
                if (plain[i] >= 'A' && plain[i] <= 'Z')
                {
                    crypted[i] = shuffled[plain[i] - 'A'];
                }
                else
                    crypted[i] = plain[i];

            }
            for (int i = 0; i < crypted.Length; i++)
            {
                sb.Append(crypted[i]);
            }
            textBox_CryptedText.Text = sb.ToString();

            crypted2 = textBox_CryptedText.Text.Replace("\n", "<br>");
            plain2 = textBox_PlainText.Text.Replace("\n", "<br>");
            btn_savesolution.Enabled = true;
        }

        private void btn_savesolution_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            if (fb.ShowDialog() != DialogResult.OK) return;

            string path = fb.SelectedPath;
            string solutionfilename;
            string puzzlefilename;
            DateTime dt = DateTime.Now;

            solutionfilename = path + "\\" + dt.ToString("yyyyMMdd_HHmmss") + "-solution.html";
            puzzlefilename = path + "\\" + dt.ToString("yyyyMMdd_HHmmss") + "-puzzle.html";

            savesolution(solutionfilename);
            savepuzzle(puzzlefilename);
            MessageBox.Show("Saved cryptoquote puzzle and solution to:\n\n" + puzzlefilename + "\n" + solutionfilename);
        }

        private void savesolution(String filename)
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter(filename);

            sw.Write(
            "<!DOCTYPE html>" +
            "<html>" +
            "<head>" +
            "<style>" +
            "div.crypt {" +
            "letter-spacing: " + letterspacingpixels + "px;" +
            "font-family:courier, \"courier new\", monospace;" +
            "font-size:large;" +
            "line-height: " + lineheightpercent + "%;" +
            "}" +
            "</style>" +
            "</head>" +
            "<title>CryptoQuote Solution</title>" +
            "<body>" +
            "<div class=\"crypt\">"
            );

            sw.WriteLine("<br>" + alphabet + "<br>");
            sw.WriteLine(shuffled + "<br><br>");
            sw.WriteLine("</div>");
            sw.WriteLine("<div class=\"crypt\">");
            sw.WriteLine("<hr>");
            sw.WriteLine(plain2 + "<br>");
            sw.WriteLine("<hr>");
            sw.Write(crypted2 + "<br>");

            sw.Write(
            "</div>" +
            "</body>" +
            "</html>"
            );

            sw.Close();
        }

        private void savepuzzle(String filename)
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter(filename);

            sw.Write(
            "<!DOCTYPE html>" +
            "<html>" +
            "<head>" +
            "<style>" +
            "div.crypt {" +
            "letter-spacing: " + letterspacingpixels + "px;" +
            "font-family:courier, \"courier new\", monospace;" +
            "font-size:large;" +
            "line-height: " + lineheightpercent + "%;" +
            "}" +
            "</style>" +
            "</head>" +
            "<title>CryptoQuote Puzzle</title>" +
            "<body>" +
            "<div class=\"crypt\">"
            );

            sw.WriteLine("<br>" + alphabet + "<br><br>");
            sw.Write(crypted2 + "<br>");

            sw.Write(
            "</div>" +
            "</body>" +
            "</html>"
            );

            sw.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
