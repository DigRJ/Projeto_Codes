using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
public class Mecanicas
{
    public List<string> Tracos_Display = new List<string>();
    public int erros;
    public bool proxima_fase = false;
    public int correcao_acerto = 0;
    public int pontuacao = 0;


    public Mecanicas()
    { }
 

    public string Tracejado(string p, List<string> T, int  count)
    {
        string traco = "";
        correcao_acerto = 0;
        for (int i = 0; i < p.Length; i++)
        {
            if (p[i].ToString() == " " || p[i].ToString() == "-")
            {
                T.Add(p[i].ToString());
                traco = traco + p[i] + " ";
                correcao_acerto += 1;
            }
            else
            {

                T.Add("_");
                traco = traco + T[i] + " ";
            }
        }
      
        Debug.Log(" n de char : " + count.ToString());
        return traco;
    }


    public string Acertou(string letra, int posicao, List<string> traco)
    {
        string atualizacao_palavra = "";

        //Debug.Log("tamanho traços : " + traco.Count.ToString());

        for (int i = 0; i < traco.Count; i++)
        {
           // Debug.Log("entrou no loop ");
            if (posicao == i)
            {
                traco[i] = letra;
               
            }

        }

        

        for (int i = 0; i < traco.Count; i++)
        {
            atualizacao_palavra = atualizacao_palavra + traco[i] + " ";
        }

        return atualizacao_palavra;
    }


    public void Ganhou(int comp1 , int comp2 ) {

        if (comp1 == comp2) {


            Debug.Log("VOCÊ GANHOU !!!!!!!!!!!!!!!!");
            proxima_fase = true;
        
        }

    }

    public void Recompensa(Text Recompensa, Text Score, int pontos) {
       
        if (pontos == 500 ) {
            pontuacao = pontuacao + 500;
            Score.text = " Score : " + pontuacao.ToString();
        }
        else { 
            pontuacao = pontuacao + 250;
            Score.text = " Score : " + pontuacao.ToString();
        }
        Recompensa.text = "+ : " + 500;
     //return pontuacao;
    }


    public void Resetar_Dica(Button Dica  , Text Dica_txt)
    {
        Dica.interactable = true;
        Dica_txt.text = "Uma dica pela metade da recompensa";

    }




    }

