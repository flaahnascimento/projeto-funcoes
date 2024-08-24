using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_funcoes
{
    public partial class Form1 : Form
    {
        // variaveis publicas
        double n1, n2, n3, media;

        public Form1()
        {
            InitializeComponent();
        }
    
        private void BTNCALCULAR_Click(object sender, EventArgs e)
        {

            //entradas com as variaveis recebendo oq o usuario digitou
            n1 = double.Parse(txtn1.Text);
            n2 = double.Parse(txtn2.Text);
            n3 = double.Parse(txtm.Text);

            //processamento

            //utilizando funçooes
            funcoes obj = new funcoes();

            media = obj.CalcularMedia(n1, n2, n3);


            
            txtn3.Text = obj.CalcularMedia(n1, n2, n3).ToString();

            lblsitu.Text = obj.VerificaSituacao(media);



        }
  
       
        }
    }



