using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorBases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string aux = "";


  public string decToBin(string answer)
  {    
            string result; 
            int num = Convert.ToInt32(answer);
            result = "";
            while (num > 1)
            {
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                num /= 2;
            }
            result = Convert.ToString(num) + result;
            return result;
  }




  public string octToBin(string aux)
  {
      long n1, n5, p = 1;
      long dec = 0, i = 1, j, d;
      long binno = 0;


      n1 = Convert.ToInt64(aux);
      n5 = n1;

      for (j = n1; j > 0; j = j / 10)
      {
          d = j % 10;
          if (i == 1)
              p = p * 1;
          else
              p = p * 8;

          dec = dec + (d * p);
          i++;
      }

      i = 1;

      for (j = dec; j > 0; j = j / 2)
      {
          binno = binno + (dec % 2) * i;
          i = i * 10;
          dec = dec / 2;
      }

      string res = binno.ToString();
      return res;
  }




  private static readonly Dictionary<char, string> hexCharacterToBinary = new Dictionary<char, string> {
    { '0', "0000" },
    { '1', "0001" },
    { '2', "0010" },
    { '3', "0011" },
    { '4', "0100" },
    { '5', "0101" },
    { '6', "0110" },
    { '7', "0111" },
    { '8', "1000" },
    { '9', "1001" },
    { 'a', "1010" },
    { 'b', "1011" },
    { 'c', "1100" },
    { 'd', "1101" },
    { 'e', "1110" },
    { 'f', "1111" }
};

  public string hexToBin(string aux)
  {
      StringBuilder result = new StringBuilder();
      foreach (char c in aux)
      {
          result.Append(hexCharacterToBinary[char.ToLower(c)]);
      }
      return result.ToString();
  }




  public string binToDec(string aux)
  {
      char[] array = aux.ToCharArray();
    Array.Reverse(array);
    
    int sum = 0; 

    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] == '1')
        {
            if (i == 0)
            {
                sum += 1;
            }
            else
            {
                sum += (int)Math.Pow(2, i);
            }
        }

    }

    string res = sum.ToString();
    return res;
}



  public string binToOctal(string aux)
  {
      int pad = aux.Length % 3;
      aux = new string('0', 3 - pad) + aux;

      int n = aux.Length / 3;
      char[] bin = aux.ToCharArray();
      char[] oct = new char[n];
      for (int i = 0; i < n; i++)
      {
          int digit = bin.Skip(3 * i).Take(3).Aggregate(0,
              (x, v) => (int)v - (int)'0' + 2 * x);

          oct[i] = (char)(digit + (int)'0');
      }

      string oct_valor = new string(oct);

      return oct_valor;

  }


  public static string binToHex(string aux)
  {
      StringBuilder result = new StringBuilder(aux.Length / 8 + 1);


      int mod4Len = aux.Length % 8;
      if (mod4Len != 0)
      {
          aux = aux.PadLeft(((aux.Length / 8) + 1) * 8, '0');
      }

      for (int i = 0; i < aux.Length; i += 8)
      {
          string eightBits = aux.Substring(i, 8);
          result.AppendFormat("{0:X2}", Convert.ToByte(eightBits, 2));
      }

      return result.ToString();
  }



        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }


        bool isBinary(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '1')
                    return false;
            }

            return true;
        }



        bool isHex(string str)
        {
            foreach (char c in str)
            {
                if (c > 'f')
                    return false;
            }

            return true;
        }


        private void btnConvert_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(NumTXT.Text))
            {
                MessageBox.Show("Digite um numero!");
                return;
            }

            if (Binary1.Checked == false && Dec1.Checked == false && Oc1.Checked == false && Hex1.Checked == false)
            {
                MessageBox.Show("Escolha a base do numero!");
                return;
            }

            if (Binary2.Checked == false && Dec2.Checked == false && Oc2.Checked == false && Hex2.Checked == false)
            {
                MessageBox.Show("Escolha a base de conversão do numero!");
                return;
            }



            if (Dec1.Checked == true)
            {
                try
                {
                    aux = decToBin(NumTXT.Text);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Numero Invalido");
                }
            }



            else if (Hex1.Checked == true)
            {
                if (isHex(NumTXT.Text) == false)
                {
                    MessageBox.Show("Numero Invalido!");
                    return;
                }

                aux = hexToBin(NumTXT.Text);
            }



            else if (Oc1.Checked == true)
            {

                if (NumTXT.Text.ToLower().Contains('8') || NumTXT.Text.ToLower().Contains('9'))
                {
                    MessageBox.Show("Numero Invalido!");
                    return;
                }

                try
                {
                    aux = octToBin(NumTXT.Text);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Numero Invalido");
                }
            }


            else
            {
                if (isBinary(NumTXT.Text) == false)
                {
                    MessageBox.Show("Numero Invalido!");
                    return;
                }

                aux = NumTXT.Text;
            }



            if (Dec2.Checked == true)
            {
                ConvertTXT.Text = binToDec(aux);
            }

            else if (Hex2.Checked == true)
            {
                ConvertTXT.Text = binToHex(aux);
            }

            else if (Oc2.Checked == true)
            {
                ConvertTXT.Text = binToOctal(aux);
            }

            else
            {
                ConvertTXT.Text = aux;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ConvertTXT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
