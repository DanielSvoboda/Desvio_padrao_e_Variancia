using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace desvio_padrao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void bubblesort(int[] x) //função para ordenar um vetor, usando algoritmo bubblesort
        {
            int aux;
            for (int i = 1; i < x.Length; i++)
                for (int j = 0; j < x.Length - 1; j++)
                    if (x[j] > x[j + 1])
                    {
                        aux = x[j];
                        x[j] = x[j + 1];
                        x[j + 1] = aux;
                    }
        }


        private void CALCULAR_Click(object sender, EventArgs e) //Botão calcular
        {
            int[] osNumerosVetor = osNumeros.Text.Split(new char[] { ' ', ',', ':', ';', '.' }).Select(n => Convert.ToInt32(n)).ToArray();
            //converte os numeros escritos em um array, separando por caracteres: { ' ', ',', ':', ';', '.' }

            NUMEROS_ORDENADO.Text = ""; //Limpa os numeros ordenados

            bubblesort(osNumerosVetor); // chama a função para ordenar os numeros e armazena em 'NUMEROS_ORDENADO'
            for (int i = 0; i < osNumerosVetor.Length; i++)
            {
                NUMEROS_ORDENADO.Text += osNumerosVetor[i];
                if (i < osNumerosVetor.Length - 1)
                {
                    NUMEROS_ORDENADO.Text += ",";
                }
            }

            oTAMANHO.Text = osNumerosVetor.Length.ToString();  
            // tamanho do texto digitado

            aSOMA.Text = osNumeros.Text.Split(' ', ',', ':', ';', '.').Sum(x => int.Parse(x)).ToString();
            // variavel com a soma dos numeros digitados
            
            int variavelMEDIA = Convert.ToInt32(aSOMA.Text) / Convert.ToInt32(oTAMANHO.Text);
            // variavel com a média 
            
            double variantemediamaior = Convert.ToDouble(aSOMA.Text) / Convert.ToDouble(oTAMANHO.Text);
            aMEDIA.Text = variantemediamaior.ToString();
            // variavel com a média, usado apenas na tela, os calculos são feitos com a variavel de cima

            oDESVIO.Text = "";              //Limpa as variaveis
            aVARIANCIA_A.Text = "V = ";
            aVARIANCIA_B.Text = "V = ";
            int asomadoscubo = 0;





                     
            for (int i = 0; i < osNumerosVetor.Length; i++)    // loop de repetição ate a quantidade de numeros escritos
            {
                if (variavelMEDIA > Convert.ToInt32(osNumerosVetor[i]))    // calcula o desvio
                {
                    int nDesvio = variavelMEDIA - Convert.ToInt32(osNumerosVetor[i]);
                    oDESVIO.Text += "\n" + variavelMEDIA.ToString() + " - " + Convert.ToInt32(osNumerosVetor[i]) + " = " + nDesvio;
                    aVARIANCIA_A.Text += nDesvio + "²";
                    aVARIANCIA_B.Text += nDesvio * nDesvio;
                    asomadoscubo += Convert.ToInt32(nDesvio) * Convert.ToInt32(nDesvio);
                    
                    if (i != osNumerosVetor.Length-1)  // se não estiver no ultimo numero pode add + 
                    {   aVARIANCIA_A.Text += " + ";
                        aVARIANCIA_B.Text += " + ";
                    }
                }
                else
                {   int umCalculoAqui = Convert.ToInt32(osNumerosVetor[i]) - variavelMEDIA;
                    oDESVIO.Text += "\n" + Convert.ToInt32(osNumerosVetor[i]) + " - " + variavelMEDIA.ToString() + " = " + umCalculoAqui;
                    aVARIANCIA_A.Text += umCalculoAqui + "²";
                    aVARIANCIA_B.Text += umCalculoAqui * umCalculoAqui;
                    asomadoscubo += Convert.ToInt32(umCalculoAqui) * Convert.ToInt32(umCalculoAqui);
                    
                    if (i != osNumerosVetor.Length-1) // se não estiver no ultimo numero pode add +
                    {   aVARIANCIA_A.Text += " + ";
                        aVARIANCIA_B.Text += " + ";
                    }
                }
            }




            double VARIANTE = (double)asomadoscubo / (double)osNumerosVetor.Length;    //variante
            aVARIANCIA_C.Text = "V = " + asomadoscubo.ToString() 
                + "        V = " + VARIANTE +  "\n       ---- \n        " 
                + oTAMANHO.Text;
                        
            oDESVIOpADRAO_p.Text = "σ = √" + asomadoscubo.ToString()         //desvio padrao
                + " = √" + VARIANTE + " = " + Convert.ToSingle(Math.Sqrt((double)VARIANTE)) 
                + "\n        ----- \n          " + oTAMANHO.Text;


            int totalMenosUm = osNumerosVetor.Length - 1;
            float VARIANTEb = (float)asomadoscubo / (float)totalMenosUm;

            oDESVIOpADRAO_a.Text = "Sx = √" + asomadoscubo.ToString() 
                + " = √" + VARIANTEb + " = " + Convert.ToSingle(Math.Sqrt((double)VARIANTEb)) 
                + "\n          ----- \n          " + oTAMANHO.Text + " - 1";


            int tamanhoda_aVARIANCIA = aVARIANCIA_A.Text.Length;
            int tamanhoda_aVARIANCIA_B = aVARIANCIA_B.Text.Length;

            aVARIANCIA_A.Text += "\n         ";
            aVARIANCIA_B.Text += "\n         ";

                
            for ( int i=0; i < tamanhoda_aVARIANCIA; i++)
            {   
                aVARIANCIA_A.Text += "-";  // tamanho do traço
            }

            for (int i = 0; i < tamanhoda_aVARIANCIA_B; i++)
            {
                aVARIANCIA_B.Text += "-";// tamanho do traço
            }

            aVARIANCIA_A.Text += "\n";
            aVARIANCIA_B.Text += "\n        ";

            // espaco na linha de baixo antes da media
            for (int i = 0; i < (tamanhoda_aVARIANCIA / 2.5); i++)
            {   aVARIANCIA_A.Text += "  ";  }             

            for (int i = 0; i < (tamanhoda_aVARIANCIA_B/1.5); i++)
            {   aVARIANCIA_B.Text += " ";  }

            aVARIANCIA_A.Text +=  oTAMANHO.Text;
            aVARIANCIA_B.Text += oTAMANHO.Text;

            // mediana
            double[] vetor_ordenado = NUMEROS_ORDENADO.Text.Split(new char[] { ' ', ',', ':', ';', '.' }).Select(n => Convert.ToDouble(n)).ToArray();
            int metade = osNumerosVetor.Length / 2;  

            if (Convert.ToInt32(oTAMANHO.Text) % 2 == 0) //par
            {
                aMEDIANA.Text = ((vetor_ordenado[metade] + vetor_ordenado[metade - 1]) / 2).ToString();
            }
            else                                         //impar
            {
                aMEDIANA.Text = (vetor_ordenado[metade]).ToString();
            }
        }


        private void linkLabel_github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DanielSvoboda");
        }
    }
}
