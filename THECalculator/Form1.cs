using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace THECalculator
{
    public partial class Form1 : Form
    {
        String cache; //expression
        double value;
        bool areItOp(char botao)
        {
            if (botao == '+' || botao == '-' || botao == '÷' || botao == 'x' || botao == '.')
                return true;
            else
                return false;
        }
        public Form1()
        {
            InitializeComponent();
        }
        void onNumClick(object sender, EventArgs e)
        {
            equals.Enabled = true;
            if (sender is Button botao)
            {
                if (botao.Text == "-" && String.IsNullOrEmpty(cache))
                {
                    cache += botao.Text;
                    toDo.Text = cache;
                }
                else if ((botao.Text == "+" || botao.Text== "÷" || botao.Text == "x" || botao.Text == ".") && String.IsNullOrEmpty(cache))
                {
                    preview.Text = "You need to select a number first.";
                    equals.Enabled = false;
                } else 
                {
                    if (!(areItOp(char.Parse(botao.Text)) && cache.Length > 0 && areItOp(cache[cache.Length - 1])))
                    { //verifica se n vai botar algo tipo 2++2
                        cache += botao.Text;
                        preview.Text = "Select another number.";
                        toDo.Text = cache;
                    }
                    calcula();
                }
            }
        }
        void calcula()
        {
            this.ActiveControl = null;
            DataTable table = new DataTable();
            if (cache.Length > 0)
            {
                if (areItOp(cache[cache.Length - 1]))
                {
                    preview.Text = "Select another number.";
                }
                else
                {
                    cache = cache.Replace("÷", "/");
                    cache = cache.Replace("x", "*");
                    try
                    {
                        value = Convert.ToDouble(table.Compute(cache, string.Empty));
                    } catch(Exception e)
                    {
                        result.Text = e.ToString();
                    }
                    if (double.IsNaN(value) || double.IsInfinity(value))
                    {
                        preview.Text = "Cannot divide by zero.";
                    }
                    else
                    {
                        preview.Text = value.ToString(CultureInfo.InvariantCulture); //essa desgraça tem que ser no estilo x.xx pra funcionar decimal grrr
                    }

                }
            }

        }
        bool canIDo()
        {
            if (double.IsNaN(value) || double.IsInfinity(value))
                return false;
            else
                return true;
        }
        private void clear_Click(object sender, EventArgs e)
        {
            cache = String.Empty;
            preview.Text = String.Empty;
            result.Text = String.Empty;
            toDo.Text = String.Empty;
            equals.Enabled = false;
            doitagain.Enabled = false;
        }
        private void equals_Click(object sender, EventArgs e)
        {
            if (canIDo() && Double.TryParse(preview.Text, out _))
            {
                doitagain.Enabled = true;
                result.Text = preview.Text;
                preview.Text = "";
            }
        }

        private void pop_Click(object sender, EventArgs e)
        {
            char[] arraychar = cache.ToCharArray();
            arraychar = arraychar.Take(cache.Length - 1).ToArray();
            cache = new string(arraychar);
            toDo.Text = cache;
        }

        private void doitagain_Click(object sender, EventArgs e)
        {
            if (canIDo())
            {
                cache = result.Text;
                toDo.Text = result.Text;
                calcula();
                preview.Text = "";
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            foreach (Control controle in this.Controls)
            {
                if (e.KeyChar == '\r')
                    equals.PerformClick();
                else if (e.KeyChar == '/')
                    division.PerformClick();
                else if (e.KeyChar == '*')
                    multi.PerformClick();
                else {
                    if (controle is Button button && button.Text == e.KeyChar.ToString())
                        {button.PerformClick();
                    }
                
                }
            }
        }
    }
}
