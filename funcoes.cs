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
        
        public double CalcularMedia(double parametro1, double parametro2, double parametro3)
        {
            
            double media;

          
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
            #endregion

          
        }
        #region
        /*
     - adicionei uma classe e criei um arquivo - funcoes.

     - tirei o void pois minha funcao ira trazer retorno. Com void seria sem retorno.
     E coloquei double para representar o tipo de valor que a funcao vai retornar e no final utilizei return media

     - meu arqivo funcoes poderia calcular varias funcoes mas no caso sera apenas para calcularMedia.

     - a funcao calcularMedia foi criada para receber 3 parametros do tipo double : 
     public double CalcularMedia(double parametro1, double parametro2, double parametro3)

     -criei uma variavel dentro da funçao q so serve para a funçao: double media

     -variavel media recebe os valores via parametro n1,n2 e n3. faz o calculo da media.

     - utilizei o "return media" pois a funcao executa, faz o calculo, e armazena nela mesma. Podendo, entao,
     guardar em uma variavel ou textbox, nesse caso, foi uitilizado a variavel media. Ja que e do tipo double.

     - criei um calcular situaçao do aluno. Do tipo string pois sera em texto
     public string VerificaSituacao(double mediaAluno)

     - utilizei if e else e return para mostrar o resultado.

     - E, por fim, o comando  #region/#endregion serve para esconder, deixando o codigo mais limpo.
     */



        #endregion

    }
}
