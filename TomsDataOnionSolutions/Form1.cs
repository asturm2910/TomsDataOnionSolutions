﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomsDataOnionSolutions
{
    public partial class EncryptionWindow : Form
    {
        public EncryptionWindow()
        {
            InitializeComponent();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            Encoder enc = new Encoder();
            string decodedText = enc.decodeAll(encTextBox.Text);
            encTextBox.Text = Utility.addSystemNewLine(decodedText);
        }

        private void saveButton_Click(object sender, EventArgs e) {
            DialogResult ds = saveText.ShowDialog();
            if (ds.Equals(DialogResult.OK)) {
                string fileName = saveText.FileName;
                Console.WriteLine($"{fileName}");

                File.WriteAllText(fileName, encTextBox.Text);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void encTextBox_TextChanged(object sender, EventArgs e)
        {
            currentByteCount.Text = encTextBox.Text.Length.ToString();
        }

        private void encryptPhase2_Click(object sender, EventArgs e)
        {
            Encoder enc = new Encoder();
            BitShifter bs = new BitShifter();
            string decodedText = enc.decodeAll(encTextBox.Text);
            decodedText = bs.TomsOnionShifterDecodeAll(decodedText);
            encTextBox.Text = Utility.addSystemNewLine(decodedText);
        }

        private void encodePhae2_Click(object sender, EventArgs e)
        {
            Encoder enc = new Encoder();
            BitShifter bs = new BitShifter();
            ParityBitEncoder pbe = new ParityBitEncoder();

            //string validatedText = pbe.DeleteIllegalBytes(encTextBox.Text);
            //Console.WriteLine($"Lenght of validated Text: {validatedText.Length}");

            //string encodedText = bs.TomsOnionShifterDecodeAll(enc.decodeAll(pbe.DeleteIllegalBytes(encTextBox.Text)));
            string encodedText = pbe.decodeAll(encTextBox.Text);
            Console.WriteLine($"Original Payload: {encTextBox.Text.Length} ");
            Console.WriteLine($"Decrypted Text: {encodedText.Length}");
            Console.WriteLine(encodedText);
            
            //string ascii85DecodedText = enc.decodeAll(encTextBox.Text);
            //Console.WriteLine($"ascii85DecodedText: {ascii85DecodedText.Length}");
            //string shiftedText = bs.TomsOnionShifterDecodeAll(ascii85DecodedText);
            //string decodedText = pbe.DeleteIllegalBytes(shiftedText);
            //Console.WriteLine($"DecodedText: {decodedText.Length}");

            //
            ///Console.WriteLine(shiftedText);
            //Console.WriteLine("\n\n---====================================================================================================================================---\n\n\n\n");
            //Console.WriteLine(decodedText);
            encTextBox.Text = Utility.addSystemNewLine(encodedText);
        }

        private void cbBinaryDisplay_CheckedChanged(object sender, EventArgs e)
        {
            encTextBox.Text = DisplayHelper.ChangeToBinaryString(encTextBox.Text);
        }
    }
}
