using System;
using System.Text;
using System.Windows.Forms;

namespace InformationSecurityLab9
{
    public partial class Form1 : Form
    {

        private bool isEncrypted = false;
        private int M = 32;
        private int[] encryptKeys;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {

            if (isEncrypted)
            {
                textBoxDecrypted.Text = Decrypt(textBoxEncrypted.Text.ToLower(), encryptKeys);
                textBoxEncrypted.Text = String.Empty;
                buttonEncrypt.Text = "Шифровать";
                isEncrypted = false;
            }
            else
            {
                encryptKeys = RandomKeysGen(textBoxDecrypted.Text.Length);
                textBoxEncrypted.Text = Encrypt(textBoxDecrypted.Text.ToLower(), encryptKeys);
                textBoxDecrypted.Text = String.Empty;
                buttonEncrypt.Text = "Расшифровать";
                isEncrypted = true;
            }
        }

        private string Encrypt(string input, int[] keys)
        {
            char[] array = input.ToCharArray();
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < array.Length; i++)
            {
                char c = (char)((array[i] - 'а' + keys[i]) % M);
                builder.Append((char)(c + 'а'));
            }
            return builder.ToString();
        }

        private string Decrypt(string input, int[] keys)
        {
            char[] array = input.ToCharArray();
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < array.Length; i++)
            {
                char c = (char)((array[i] - 'а' - keys[i]) % M);
                builder.Append((char)(c + 'а'));
            }
            return builder.ToString().ToLower();
        }

        private int[] RandomKeysGen(int size)
        {
            int[] keys = new int[size];

            Random random = new Random();
            for (int i = 0; i < size; i++) 
            { 
                keys[i] = random.Next(M);
            }

            return keys;
        }
    }
}
