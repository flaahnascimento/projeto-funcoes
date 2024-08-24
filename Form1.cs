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
        // 
        double n1, n2, n3, media;

        public Form1()
        {
            InitializeComponent();
        }
    
        private void BTNCALCULAR_Click(object sender, EventArgs e)
        {

            //
            n1 = double.Parse(txtn1.Text);
            n2 = double.Parse(txtn2.Text);
            n3 = double.Parse(txtm.Text);

            

            //
            funcoes obj = new funcoes();
            media = obj.CalcularMedia(n1, n2, n3);
            txtn3.Text = obj.CalcularMedia(n1, n2, n3).ToString();

            //
            lblsitu.Text = obj.VerificaSituacao(media);


            #region
            /*passo 1: criei a variavel publica para acessar em todas etapas e botoes.

passo 2: fiz as variaveis receberem e guardarem o que o usuario digitou 

passo 3: para eu utilizar a funçao que esta la no arquivo funcoes. eu coloco o arquivo funcoes e declaro um nome = new funçoes.
funcoes obj = new funcoes(); . E agora se acessa tudo que esta no calcularMedia atraves do nome que declarei "obj" é ele que referencia.

- utilizei a variavel media para receber a funçao e adicionar as 3 variaveis que guardaram
os valores dgitados pelo usuario, as variaveis serao os 3 parametros solicitados na funcao e
esses parametros tem como funçao enviar os valores para a funçao.


- pedi para o textbox de resultado receber a funcao calcularMedia.ToString(); ja que eu utilizei o return. 
/Por que ToString? porque permite o textbox receber o resultado.


- utilizei dois label: "situaçao do aluno" , "X". o label situaçao ira
 receber o retorno da funcao "situaçao do aluno"
*/


            #endregion
        }


    }
    }



