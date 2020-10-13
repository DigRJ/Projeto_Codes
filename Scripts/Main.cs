using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;


public class Main : MonoBehaviour
{
    private Palavras Times = new Palavras();
    private Mecanicas Mecanics = new Mecanicas();
    private Teclado Digito = new Teclado();
    public Lista L = new Lista();
    private string Palavra = "";
    private string Tracos = "";
    private List<Button> Teclado = new List<Button>();
    private bool acerto_ou_erro = false;
    private bool verificar_char = true;
    private int cont_erros = 0;
    private int recompensa = 500;
    private int score = 0;
    private bool cobrar_dica = false;
    private bool perdeu = false;

    public  int  conta_acertos = 0;
    public Text palavra;
    public GameObject Grid;
    public GameObject Container_Teclado;
    public Button Tecla;
    public Image Painel_Btn;
    public Image Painel_Dica;
    public Image Painel_Recompensa;
    public Image Painel_Score;
    public Text Dica;
    public Text Text_Recompensa;
    public Text Text_Score;
    public Button Btn_Dica;
    public Image Painel_Bola_Fora;
    public Image Painel_Goool;
    public Text Txt_bola_fora;
    public Text Txt_goool;

   
    void Awake()
    {
        
        

        //lista de times
        Times.Imprimir_Lista(L.Times);

        // escolhendo palavras dentre os times
        Palavra = Times.Escolhendo_Palavra(L.Times);
        Debug.Log("Time Escolhido : ");
        Debug.Log(Palavra);
       
        //tracejando o time escolhido 
        Tracos = Mecanics.Tracejado(Palavra, Mecanics.Tracos_Display, conta_acertos);
        conta_acertos = Mecanics.correcao_acerto; // corrige numero de acerto , ao corresponder hífen e espaço em branco da palavra
        //Debug.Log(Tracos);

        // jogando traços dentro do container 
        palavra.text = Tracos;
        palavra = Instantiate(palavra, Grid.transform, false) as Text;



        // setando recompensa
       

        // Teclado
        Digito.Keyboard(Digito.teclado, Teclado, Tecla);
        for (int i = 0; i < Teclado.Count; i++) {

            Teclado[i] = Instantiate(Teclado[i], Container_Teclado.transform, false) as Button;
            // Teclado[i].onClick.AddListener(() => Verificar(Teclado));
        }

        Digito.Keyboard_Click(Teclado);
        Digito.Keyboard_Text(Digito.teclado, Teclado);


        // instanciando botão  da dica

        
        Dica = Instantiate(Dica, Painel_Dica.transform, false) as Text;
        Btn_Dica = Instantiate(Btn_Dica, Painel_Btn.transform, false) as Button;
        Btn_Dica.onClick.AddListener(() => Times.Dica(Dica,Btn_Dica));
        Btn_Dica.onClick.AddListener(() => Times.Cobrando_Dica());
        cobrar_dica = Times.Verificar_Dica;
        // instanciando 

        Text_Recompensa = Instantiate(Text_Recompensa, Painel_Recompensa.transform, false);
        Text_Recompensa.text = "+ : " + recompensa.ToString();
        Text_Score = Instantiate(Text_Score, Painel_Score.transform, false);


        //instanciando contador bolas fora
        Txt_bola_fora = Instantiate(Txt_bola_fora, Painel_Bola_Fora.transform, false);
        Txt_bola_fora.text = "0/6";
        Txt_bola_fora.color = Color.red;

        //instanciando contador bolas fora
        Txt_goool = Instantiate(Txt_goool, Painel_Goool.transform, false);
        Txt_goool.text = "0/" + Palavra.Length.ToString();
        Txt_goool.color = Color.cyan;
    }


    //void Verificar (object sender, EventArgs e){ Debug.Log("Apertou a tecla : " + this.name);}



    void Update() {

        if (Digito.verificar == true) {

            for (int i = 0; i < Palavra.Length; i++) {

                if (Digito.letra.ToUpper() == Palavra[i].ToString().ToUpper())
                {
                    // Debug.Log("ACERTOU");
                    palavra.text = Mecanics.Acertou(Digito.letra, i, Mecanics.Tracos_Display);
                    acerto_ou_erro = true;
                    conta_acertos += 1;
                    Txt_goool.text = conta_acertos.ToString() + "/" + Palavra.Length.ToString();

                }
            }

            if (Palavra.Contains(Digito.letra.ToUpper()) == false) {
                cont_erros += 1;
                Txt_bola_fora.text = cont_erros.ToString() + "/6";
                //Debug.Log("errou :" + cont_erros.ToString());

            }

            Debug.Log("numero de acertos : " + conta_acertos);
            Mecanics.Ganhou(conta_acertos, Palavra.Length);

        /*    if (!acerto_ou_erro ) {
                cont_erros += 1;
                Debug.Log("Erro nº : " + cont_erros.ToString() );
            }
                acerto_ou_erro = false; */
                Digito.verificar = false;
         }


        if (Times.Verificar_Dica == true) {
            recompensa = recompensa / 2;
            Text_Recompensa.text = "+ : " + recompensa.ToString();
            //Debug.Log(recompensa.ToString());
            Times.Verificar_Dica = false;
        }


        if (Mecanics.proxima_fase == true) {


            Tracos = "";
            Mecanics.Tracos_Display.Clear();
            conta_acertos = 0;
            cont_erros = 0;
            // resetando dica
            Mecanics.Resetar_Dica(Btn_Dica, Dica);
            //desbloqueando teclas sem interactividade
            Digito.Desbloqueando_Teclado(Teclado);
            Mecanics.Recompensa(Text_Recompensa, Text_Score, recompensa);
            recompensa = 500;

            //escolhendo palavra
            Palavra = Times.Escolhendo_Palavra(L.Times);
            Debug.Log("Time Escolhido : ");
            Debug.Log(Palavra);


            //tracejando o time escolhido 
            Tracos = Mecanics.Tracejado(Palavra, Mecanics.Tracos_Display, conta_acertos);
            conta_acertos = Mecanics.correcao_acerto; // corrige numero de acerto , ao corresponder hífen e espaço em branco da palavra
            //Debug.Log(Tracos);
            palavra.text = Tracos;
            Mecanics.proxima_fase = false;
            // resetando gools
            Txt_goool.text = conta_acertos.ToString() + "/" + Palavra.Length.ToString();
            Txt_bola_fora.text = cont_erros + "/" + "6";
        }



    }

 }


  


