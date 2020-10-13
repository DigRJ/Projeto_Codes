using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Teclado
{
    public List<string> teclado = new List<string>();
    List<Button> digitos = new List<Button>();
    public bool verificar = false;
    public string letra = "";


    public Teclado()
    {

        teclado.Add("A");
        teclado.Add("B");
        teclado.Add("C");
        teclado.Add("D");
        teclado.Add("E");
        teclado.Add("F");
        teclado.Add("G");
        teclado.Add("H");
        teclado.Add("I");
        teclado.Add("J");
        teclado.Add("K");
        teclado.Add("L");
        teclado.Add("M");
        teclado.Add("N");
        teclado.Add("O");
        teclado.Add("P");
        teclado.Add("Q");
        teclado.Add("R");
        teclado.Add("S");
        teclado.Add("T");
        teclado.Add("U");
        teclado.Add("V");
        teclado.Add("X");
        teclado.Add("W");
        teclado.Add("Y");
        teclado.Add("Z");
        teclado.Add("Ç");
        teclado.Add("Ñ");
        teclado.Add("0");
        teclado.Add("1");
        teclado.Add("2");
        teclado.Add("3");
        teclado.Add("4");
        teclado.Add("5");
        teclado.Add("6");
        teclado.Add("7");
        teclado.Add("8");
        teclado.Add("9");
        teclado.Add("É");
        teclado.Add("Í");
        teclado.Add("Ê");
        teclado.Add("Ã");
        teclado.Add("Õ");
        teclado.Add("Á");
        

    }

    public void Keyboard(List<string> Numero_Teclas, List<Button> Botao, Button b)
    {

        for (int i = 0; i < Numero_Teclas.Count; i++)
        {
            Botao.Add(b);
        }
    }

    public void Keyboard_Text(List<string> Numero_Teclas, List<Button> Botao)
    {

        for (int i = 0; i < teclado.Count; i++)
        {
            string t = teclado[i];
            Botao[i].GetComponentInChildren<Text>().text = t;

            //Debug.Log(t);
        }

        for (int i = 0; i < teclado.Count; i++)
        {
            // Debug.Log(Botao[i].GetComponentInChildren<Text>().text);

        }

    }

    public void Keyboard_Click(List<Button> Botao)
    {

        for (int i = 0; i < Botao.Count; i++)
        {
            Button btn = Botao[i];
            Botao[i].onClick.AddListener(() => Indentificar_Botao(btn)); //se eu colocar index+=1 dentro dos parenteses da lambida , eu consigo contar quantas vezes eu apertei os butons
            Botao[i].onClick.AddListener(() => Verificar_Acerto());
        }

        void Indentificar_Botao(Button sender)
        {
           // Debug.Log(sender.GetComponentInChildren<Text>().text);
            letra = sender.GetComponentInChildren<Text>().text;
            sender.interactable = false;
        }

        void Verificar_Acerto()
        {
            verificar = true;   
        }

        }

    public void Desbloqueando_Teclado(List<Button> Botao)
    {

        for (int i = 0; i < Botao.Count; i++)
        {

            Botao[i].interactable = true;

        }
    }


}

