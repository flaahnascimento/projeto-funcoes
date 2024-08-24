using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_funcoes
{
    public class funcoes
    {
        #region metodo calcular media




        #endregion
        //arquivo que calcula varias funçoes
        public double CalcularMedia(double parametro1, double parametro2, double parametro3)
        {
            //variaveis dentro de uma funcao
            double media;

            //processo calcular media
             media = (parametro1 + parametro2 + parametro3) / 3;
           
            return media;
        }
        #region metodo ue verefica a situçao do aluno
        public string VerificaSituacao(double mediaAluno)
        {
         
            if (mediaAluno >= 5)
            {
                
                return "aprovado";
            }
            else
            {

                return "reprovado";
            }

        }



        #endregion

    }
}
