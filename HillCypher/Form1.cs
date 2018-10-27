using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HillCypher
{
    public partial class Form1 : Form
    {

        string textInFile;
        string alphabet = "ABCČDEFGHIJKLMNOPRSŠTUVZŽ".ToLower();

        public Form1()
        {
            InitializeComponent();
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files|*.txt";
            openFileDialog1.Title = "Select a text File";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                textInFile = System.IO.File.ReadAllText(@filename);
                fileText.Text = textInFile;
            }
        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            string encText = encryptText(textInFile.ToLower());
            fileText.Text = encText;
            System.IO.File.WriteAllText(@Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\hillEncrypted.txt", encText);
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            string decText = decryptText(textInFile.ToLower());
            fileText.Text = decText;
            System.IO.File.WriteAllText(@Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\hillDecrypted.txt", decText);
        }

        private string encryptText(string textToEncrypt)
        {
            int[,] matrix = getMatrixFromText(matrixKeyText.Text);
            string text = cleanText(textToEncrypt);
            string newText = "";
            for(int i = 0;i < text.Length; i = i + 2) {
                int numOne = alphabet.IndexOf(text[i]);
                int numTwo = alphabet.IndexOf(text[i + 1]);
                int firstProduct = matrix[0, 0] * numOne + matrix[0, 1] * numTwo;
                int secondProduct = matrix[1, 0] * numOne + matrix[1, 1] * numTwo;
                newText = newText + alphabet[firstProduct % 25];
                newText = newText + alphabet[secondProduct % 25];
            }
            return newText;
        }


        private string decryptText(string textToDecrypt)
        {
            int[,] inputMatrix = getMatrixFromText(matrixKeyText.Text);
            string text = textToDecrypt;
            string newText = "";
            double [,] matrix = inverseMatrix(inputMatrix);
            for (int i = 0; i < text.Length; i = i + 2)
            {
                int numOne = alphabet.IndexOf(text[i]);
                int numTwo = alphabet.IndexOf(text[i + 1]);
                double firstProduct = matrix[0, 0] * numOne + matrix[0, 1] * numTwo;
                double secondProduct = matrix[1, 0] * numOne + matrix[1, 1] * numTwo;
                int firstRounded = Convert.ToInt32(Math.Floor(firstProduct) % 25);
                int secondRounded = Convert.ToInt32(Math.Floor(secondProduct) % 25);
              
                newText = newText + alphabet[firstRounded];
                newText = newText + alphabet[secondRounded];
            }

            return newText;
        }

        private double[,] inverseMatrix(int[,] matrix)
        {
            double[,] inverse = new double[2, 2];

            int determinant = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            if(determinant < 0)
            {
                determinant = determinant * -1;
            }
            double detFraction = modInverse(determinant, 25);
            inverse[0, 0] = (matrix[1, 1] * detFraction)%25;
            inverse[0, 1] = ((-matrix[0, 1] + 25) * detFraction) % 25;
            inverse[1, 0] = ((-matrix[1, 0] + 25) * detFraction) % 25;
            inverse[1, 1] = (matrix[0, 0] * detFraction) % 25;

            return inverse;
        }

        int modInverse(int a, int n)
        {
            int i = n, v = 0, d = 1;
            while (a > 0)
            {
                int t = i / a, x = a;
                a = i % x;
                i = x;
                x = d;
                d = v - t * x;
                v = x;
            }
            v %= n;
            if (v < 0) v = (v + n) % n;
            return v;
        }

        private int[,] getMatrixFromText(string text)
        {
            int[,] matrix = new int[2, 2];
            int textCounter = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matrix[i, j] = alphabet.IndexOf(text[textCounter]);
                    textCounter++;
                }
            }
            return matrix;
        }

        private string cleanText(string text)
        {
            string cleanedText = "";
            for(int i = 0; i < text.Length; i++)
            {
                if(alphabet.IndexOf(text[i]) > -1)
                {
                    cleanedText += text[i];
                }
            }
            if(cleanedText.Length % 2 > 0)
            {
                cleanedText = cleanedText + "ž";
            }
            return cleanedText;
        }
        


        private void matrixKeyText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
