﻿using System;

namespace EserciziQuartoGiorno
        //Proprietà (privata)
        private string _myPropertyInternalMatricolaStudente;

        //Esempi di Auto-implemented Property
        // dichiaro le propieta che verranno riempite
        public int StudentID { get; set; }

        
        public void StampaStudente()
        {
            Console.WriteLine("StudenteID {0}", StudentID);
            Console.WriteLine("nome studente {0}", StudentName);
            Console.WriteLine("etá studente {0}", Age);
            Console.WriteLine("indirizzo {0}", Address);

        }
    class EsempioUsoClassStudent
            //riempio le propieta che ho precedentemente dichiarato creando delle variabili
            Student std = new Student()
