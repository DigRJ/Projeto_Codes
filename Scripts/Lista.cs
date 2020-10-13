using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lista 
{
    public List<string[]> Times = new List<string[]>();
    public Lista () {

        Lista_de_Times();

}



    public void Lista_de_Times()
    {
        // BRASIL
        Times.Add(new string[2] { "FLAMENGO", "BRASIL" });
        Times.Add(new string[2] { "FLUMINENSE", "BRASIL" });
        Times.Add(new string[2] { "VASCO DA GAMA", "BRASIL" });
        Times.Add(new string[2] { "BOTAFOGO", "BRASIL" });
        Times.Add(new string[2] { "AMÉRICA", "BRASIL" });
        Times.Add(new string[2] { "BANGU", "BRASIL" });
        Times.Add(new string[2] { "CORINTHIANS", "BRASIL" });
        Times.Add(new string[2] { "PALMEIRAS", "BRASIL" });
        Times.Add(new string[2] { "SÃO PAULO", "BRASIL" });
        Times.Add(new string[2] { "SANTOS", "BRASIL" });
        Times.Add(new string[2] { "GUARANÍ", "BRASIL" });
        Times.Add(new string[2] { "PONTE PRETA", "BRASIL" });
        Times.Add(new string[2] { "RED BULL BRAGANTINO", "BRASIL" });
        Times.Add(new string[2] { "CRUZEIRO", "BRASIL" });
        Times.Add(new string[2] { "ATLÉTICO MINEIRO", "BRASIL" });
        Times.Add(new string[2] { "AMÉRICA MINEIRO", "BRASIL" });
        Times.Add(new string[2] { "IPATINGA", "BRASIL" });
        Times.Add(new string[2] { "GRÊMIO", "BRASIL" });
        Times.Add(new string[2] { "INTERNACIONAL", "BRASIL" });
        Times.Add(new string[2] { "JUVENTUDE", "BRASIL" });
        Times.Add(new string[2] { "AVAÍ", "BRASIL" });
        Times.Add(new string[2] { "FIGUEIRENSE", "BRASIL" });
        Times.Add(new string[2] { "CORITIBA", "BRASIL" });
        Times.Add(new string[2] { "PARANÁ", "BRASIL" });
        Times.Add(new string[2] { "ATLÉTICO PARANAENSE", "BRASIL" });
        Times.Add(new string[2] { "BAHIA", "BRASIL" });
        Times.Add(new string[2] { "VITÓRIA", "BRASIL" });
        Times.Add(new string[2] { "SPORT", "BRASIL" });
        Times.Add(new string[2] { "SANTA CRUZ", "BRASIL" });
        Times.Add(new string[2] { "NAÚTICO", "BRASIL" });
        Times.Add(new string[2] { "FORTALEZA", "BRASIL" });
        Times.Add(new string[2] { "CEARÁ", "BRASIL" });
        Times.Add(new string[2] { "ASA DE ARAPIRACA", "BRASIL" });
        Times.Add(new string[2] { "PAYSANDU", "BRASIL" });
        Times.Add(new string[2] { "REMO", "BRASIL" });
        Times.Add(new string[2] { "GOIÁS", "BRASIL" });
        Times.Add(new string[2] { "GAMA", "BRASIL" });

        // ESPANHA
        Times.Add(new string[2] { "REAL MADRID", "ESPANHA" });
        Times.Add(new string[2] { "BARCELONA", "ESPANHA" });
        Times.Add(new string[2] { "VALENCIA", "ESPANHA" });
        Times.Add(new string[2] { "REAL SOCIEDAD", "ESPANHA" });
        Times.Add(new string[2] { "BETTIS", "ESPANHA" });
        Times.Add(new string[2] { "OSASUNA", "ESPANHA" });
        Times.Add(new string[2] { "LA CORUÑA", "ESPANHA" });
        Times.Add(new string[2] { "ATLÉTICO DE MADRID", "ESPANHA" });
        Times.Add(new string[2] { "PORTO", "PORTUGAL" });
        Times.Add(new string[2] { "SPORTING BRAGA", "PORTUGAL" });
        Times.Add(new string[2] { "BENFICA", "PORTUGAL" });
 
        //ARGENTINA
        Times.Add(new string[2] { "BOCA JUNIORS", "ARGENTINA" });
        Times.Add(new string[2] { "RIVER PLATE ", "ARGENTINA" });
        Times.Add(new string[2] { "INDEPENDIENTE", "ARGENTINA" });
        Times.Add(new string[2] { "LANÚS", "ARGENTINA" });
        Times.Add(new string[2] { "NEWELL'S OLD BOYS", "ARGENTINA" });
        Times.Add(new string[2] { "ATLÉTICO HURACÁN", "ARGENTINA" });
        Times.Add(new string[2] { "ROSÁRIO CENTRAL", "ARGENTINA" });
        Times.Add(new string[2] { "SAN LORENZO", "ARGENTINA" });
        Times.Add(new string[2] { "VÉLEZ SARSFIELD", "ARGENTINA" });
        Times.Add(new string[2] { "ESTUDIANTES", "ARGENTINA" });
      

        //ITÁLIA
        Times.Add(new string[2] { "JUVENTUS", "ITÁLIA" });
        Times.Add(new string[2] { "INTERNAZIONALE DE MILÃO", "ITÁLIA" });
        Times.Add(new string[2] { "GENOA", "ITÁLIA" });
        Times.Add(new string[2] { "MILAN", "ITÁLIA" });
        Times.Add(new string[2] { "LAZIO", "ITÁLIA" });
        Times.Add(new string[2] { "ROMA", "ITÁLIA" });
        Times.Add(new string[2] { "NAPOLI", "ITÁLIA" });
        Times.Add(new string[2] { "SAMPDORIA", "ITÁLIA" });
        Times.Add(new string[2] { "FIORENTINA", "ITÁLIA" });
        Times.Add(new string[2] { "UDINESE", "ITÁLIA" });
        Times.Add(new string[2] { "PARMA", "ITÁLIA" });
       


        // URUGUAI E COLOMBIA 
        Times.Add(new string[2] { "PEÑAROL", "URUGUAI" });
        Times.Add(new string[2] { "NACIONAL", "URUGUAI" });
        Times.Add(new string[2] { "RACING", "URUGUAI" });
        Times.Add(new string[2] { "ATLÉTICO NACIONAL", "COLÔMBIA" });
        Times.Add(new string[2] { "MILLONARIOS", "COLÔMBIA" });
        Times.Add(new string[2] { "DEPORTIVO CALI", "COLÔMBIA" });
        Times.Add(new string[2] { "ONCE CALDAS", "COLÔMBIA" });
        Times.Add(new string[2] { "TOLIMA", "COLÔMBIA" });
        Times.Add(new string[2] { "JUNIOR BARRANQUILLA", "COLÔMBIA" });

        //INGLATERRA
        Times.Add(new string[2] { "MANCHESTER UNITED", "INGLATERRA" });
        Times.Add(new string[2] { "LIVERPOOL", "INGLATERRA" });
        Times.Add(new string[2] { "MANCHESTER CITY", "INGLATERRA" });
        Times.Add(new string[2] { "NEWCASTLE", "INGLATERRA" });
        Times.Add(new string[2] { "SOUTHAMPTON", "INGLATERRA" });
        Times.Add(new string[2] { "TOTTENHAM", "INGLATERRA" });
        Times.Add(new string[2] { "ARSENAL", "INGLATERRA" });
        Times.Add(new string[2] { "ASTON VILLA", "INGLATERRA" });
        Times.Add(new string[2] { "CHELSEA", "INGLATERRA" });
        Times.Add(new string[2] { "EVERTON", "INGLATERRA" });
        Times.Add(new string[2] { "WEST HAM", "INGLATERRA" });


        //EQUADOR E BOLIVIA
        Times.Add(new string[2] { "BARCELONA DE GUAYAQUIL", "EQUADOR" });
        Times.Add(new string[2] { "DEPORTIVO CUENCA", "EQUADOR" });
        Times.Add(new string[2] { "EMELEC", "EQUADOR" });
        Times.Add(new string[2] { "INDEPENDIENTE DEL VALLE", "EQUADOR" });
        Times.Add(new string[2] { "LDU QUITO", "EQUADOR" });
        Times.Add(new string[2] { "BOLIVAR", "BOLÍVIA" });
        Times.Add(new string[2] { "THE STRONGEST", "BOLÍVIA" });
        Times.Add(new string[2] { "JORGE WLSTERMANN", "BOLÍVIA" });
        Times.Add(new string[2] { "SAN JOSÉ", "BOLÍVIA" });
        Times.Add(new string[2] { "ORIENTE PETROLERO", "BOLÍVIA" });
        Times.Add(new string[2] { "REAL POTOSÍ", "BOLÍVIA" });
        Times.Add(new string[2] { "AURORA", "BOLÍVIA" });

        //ALEMANHA
        Times.Add(new string[2] { "BAYERN DE MUNICH", "ALEMANHA" });
        Times.Add(new string[2] { "WEDER BREMEN", "ALEMANHA" });
        Times.Add(new string[2] { "STUTTGART", "ALEMANHA" });
        Times.Add(new string[2] { "KAISERSLAUTERN", "ALEMANHA" });
        Times.Add(new string[2] { "BORUSSIA DORTMUND", "ALEMANHA" });
        Times.Add(new string[2] { "FRANKFURT", "ALEMANHA" });
        Times.Add(new string[2] { "BAYER LAVERKUSEN", "ALEMANHA" });
        Times.Add(new string[2] { "HOFFENHEIM", "ALEMANHA" });
        Times.Add(new string[2] { "LEIPZIG", "ALEMANHA" });
        Times.Add(new string[2] { "SCHALKE 04", "ALEMANHA" });
        Times.Add(new string[2] { "WOLFBURG", "ALEMANHA" });

        //CHILE E PARAGUAI
        Times.Add(new string[2] { "COLO-COLO", "CHILE" });
        Times.Add(new string[2] { "UNIVERSIDAD DO CHILE", "CHILE" });
        Times.Add(new string[2] { "UNIVERSIDAD CATÓLICA", "CHILE" });
        Times.Add(new string[2] { "COBRELOA", "CHILE" });
        Times.Add(new string[2] { "PALESTINO", "CHILE" });
        Times.Add(new string[2] { "OLIMPIA", "PARAGUAI" });
        Times.Add(new string[2] { "CERRO PORTEÑO", "PARAGUAI" });
        Times.Add(new string[2] { "LIBERTAD", "PARAGUAI" });


        //FRANÇA 
        Times.Add(new string[2] { "PARIS SAINT-GERMAN", "FRANÇA" });
        Times.Add(new string[2] { "BORDEAUX", "FRANÇA" });
        Times.Add(new string[2] { "LILLE", "FRANÇA" });
        Times.Add(new string[2] { "LYON", "FRANÇA" });
        Times.Add(new string[2] { "MONACO", "FRANÇA" });
        Times.Add(new string[2] { "MONTPELLIER", "FRANÇA" });
        Times.Add(new string[2] { "OLYMPIQUE DE MARSEILLIE", "FRANÇA" });
        Times.Add(new string[2] { "NANTES", "FRANÇA" });
        Times.Add(new string[2] { "NICE", "FRANÇA" });
        Times.Add(new string[2] { "SAINT-ETIENNE", "FRANÇA" });
        Times.Add(new string[2] { "TOULOUSE", "FRANÇA" });


        // VENEZUELA E PERU
        Times.Add(new string[2] { "DEPORTIVO TÁCHIRA", "VENEZUELA" });
        Times.Add(new string[2] { "DEPORTICO GALICIA", "VENEZUELA" });
        Times.Add(new string[2] { "CARACAS", "VENEZUELA" });
        Times.Add(new string[2] { "ALIANZA LIMA", "PERU" });
        Times.Add(new string[2] { "CIENCIANO", "PERU" });


        //HOLANDA , TURKIA E GRECIA

        Times.Add(new string[2] { "AJAX", "HOLANDA" });
        Times.Add(new string[2] { "PSV", "HOLANDA" });
        Times.Add(new string[2] { "OLYMPIAKOS", "GRÉCIA" });
        Times.Add(new string[2] { "PANATHINAIKOS", "GRÉCIA" });
        Times.Add(new string[2] { "GALATASARAY", "TURQUIA" });
        Times.Add(new string[2] { "FENERBAHÇE", "TURQUIA" });
        Times.Add(new string[2] { "BESIKTAS", "TURQUIA" });


        // MÉXICO
        Times.Add(new string[2] { "AMÉRICA DO MÉXICO", "MÉXICO" });
        Times.Add(new string[2] { "CHIVAS GUADALAJARA", "MÉXICO" });
        Times.Add(new string[2] { "TOLOUCA", "MÉXICO" });
        Times.Add(new string[2] { "CRUZ AZUL", "MÉXICO" });
        Times.Add(new string[2] { "TIGRES", "MÉXICO" });
        Times.Add(new string[2] { "LEÓN", "MÉXICO" });
        Times.Add(new string[2] { "PACHUCA", "MÉXICO" });
        Times.Add(new string[2] { "TIJUANA", "MÉXICO" });
        Times.Add(new string[2] { "MONTERREY", "MÉXICO" });


        // LESTE EUROPEU 

        Times.Add(new string[2] { "LOKOMOTIV", "RÚSSIA" });
        Times.Add(new string[2] { "DÍNAMO DE MOSCOU", "RÚSSIA" });
        Times.Add(new string[2] { "CSKA MOSCOU", "RÚSSIA" });
        Times.Add(new string[2] { "SPARTAK DE MOSCOU", "RÚSSIA" });
        Times.Add(new string[2] { "ZENIT", "RÚSSIA" });
        Times.Add(new string[2] { "DÍNAMO DE KIEV", "UCRÂNIA" });
        Times.Add(new string[2] { "SHAKHTAR DONETSK", "UCRÂNIA" });



    }



}
