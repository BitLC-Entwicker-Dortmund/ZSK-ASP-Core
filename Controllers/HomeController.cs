using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ZSK_ASP_Core.Models;

namespace ZSK_ASP_Core.Controllers {
    public class HomeController : Controller {
        public IActionResult Index ( ) {
            return View ( );
        }
        
        [HttpPost]
        public IActionResult Euro2ZSK ( EuroTyp euro) {

            // Beschaffe den aktuellen ZSK Kurs und speichere das Objekt in der lokalen Variablen kurs
            // Das Objekt enthält die aktuellen Preise von Kuh bis zur kleinen Ziege
            ZSKExchange  kurs  = Database.GetCurrentZSKRate ( );
            //  kurs.RateCow  ist der aktuelle Kurs für eine Kuh - die anderen  Preise - analog

            //int AnzahlKuehe = euro.Betrag / kurs.RateCow;
            //int rest = euro.Betrag % kurs.RateCow;
            // die restlichen Berechnungen - analog

            //Ergebnisse -  Anzahl der Tiere  dann in ein ZSKCurrencyCounter-Objekt speichern und der Methode View
            // als Argument für die Darstellung mitgeben!.

            // An Stelle der Berechnung und Wertzuweisung  -  als Beispiel
            ZSKCurrencyCounter zcc = new ZSKCurrencyCounter ( ) { AmountCows = 1 , AmountSheeps = 2 , AmountGoats = 1 , AmountSmallGoats = 2 };

            // Da wir keinen anderen View angegeben haben, wird automatisch der Name der aktuellen Methode
            // verwendet - daher wird der zugehörige View mit dem Namen Euro2ZSK aufgerufen. 
            // Dieser muß in der Zeile: @model den Datentyp aufweisen, den wir mit zcc übertragen 
            //- also  : ZSKCurrencyCounter
            return View (zcc );
        }       
    }
}
