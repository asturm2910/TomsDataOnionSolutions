using System;
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
            ParityBitEncoder pbe = new ParityBitEncoder();
            string decodedText = enc.decodeAll(encTextBox.Text);

        }
    }
}
