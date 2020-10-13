using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using UnityEngine.UI;

public class Palavras {

public string capt_Dica = "";
public Mecanicas Mecanics = new Mecanicas();
public Lista Listando = new Lista();


    public bool Verificar_Dica;

    public  Palavras ( ) 
    {
       
       


    }

~Palavras(){
//Debug.Log("Lista destruida");
}




public void   Imprimir_Lista ( List <string[]> Lista) 
{

       for (int i =0; i < Lista.Count; i++ ){

            string time = Lista[i][0];
            string dica = Lista[i][1];
            //Debug.Log(" Time : " + time + " dica  : " + dica);
    
        }
        }


public string Escolhendo_Palavra(List <string[]> Lista)
{
string palavra = "";
System.Random r = new System.Random();
int aleatorio = r.Next(0, Lista.Count);
palavra =  Lista[aleatorio][0];
        capt_Dica = Lista[aleatorio][1];
        Lista.RemoveAt(aleatorio);
return palavra;


}

  public void  Dica( Text texto, Button btn)
  {
        texto.text = "Time oriundo do país : " + capt_Dica;
        btn.interactable = false;
  }

    public void Cobrando_Dica()
    {
        Verificar_Dica = true;
    }



}  //GERAL