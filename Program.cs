using System;

namespace EserciziQuartoGiorno
{ 
    public class Studente1
    {
        private string sMatricolaStudente; // non posso richiamare nel main se non tramite un metodo
        public string sCognomeStudente; // posso richiamare nel main senza problemi

        //metodo per poter usare la private string (accesso mediato)
        // questo mi permette di fare dei controlli oppure imporre dei dati specifici
        public void SetMatricolaStudente(string sIdStudente)
        {
            // devo fare qualcosa prima io 

            //Per esempio: connettiti al DB degli studenti e verifica che la matricola esiste giá
            // Se non esiste la imposti". Se esiste torni un codice d'errore
            this.sMatricolaStudente = "001" + sIdStudente;
        }
        public Studente1()
        {
            this.sMatricolaStudente = "";
        }

        Studente1(string sCognome, string sMatricola)
        {
            sCognomeStudente = sCognome;
            SetMatricolaStudente(sMatricola);
        }

    }
    // classse che in questo caso ereditiamo dentro serie
    public class Contenuto
    {

        protected string titolo;

        public Contenuto(string titolo)
        {
            this.titolo = titolo;
        }

        public void Riproduci()
        {
            Console.WriteLine("Stai guardando " + titolo);
        }
    }
    // classe nuova creata : classe giá esistente da estendere (padre)
    public class Serie : Contenuto
    {

        private string[] cast;

        public Serie(string titolo, string[] cast) : base(titolo)
        {
            this.cast = cast;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Studente1 MioStudente = new Studente1();
            MioStudente.sCognomeStudente = "Rossi";
            MioStudente.SetMatricolaStudente("20321");

            EsempioUsoClassStudent MioEsempio = new EsempioUsoClassStudent();
            MioEsempio.EsempioUsoClassStudent_Main();
            */
            //Student.StampaStudente();
            
        }

    }
}