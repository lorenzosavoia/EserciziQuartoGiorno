using System;/*A partire dalla versione C# 3.0 (.NET 3.5) è stata introdotta la Object Initializer Syntax, un nuovo modo di inizializzare un oggetto di una classe o di una collection Questo nuovo modo ti permette di assegnare valori agli attributi al momento della creazione dell'istanza e senza invocare il costruttore.Da notare la proprietà MATRICOLA dello studente (_myPropertyInternalMatricolaStudente)Di questa variabile una parte la voglio tenere interna all'università (es. i primi 5 bytes)mentre una parte (i secondi 5 bytes) la voglio rendere publica inclusi i tre bytes finali.Esercizio: gestire il fatto che se StudentName non è impostato, allora non potrei impostaretale proprietà. Allora metto i secondi 5 bytes a 0. E la set di StudentName completa l'operazione.*/

namespace EserciziQuartoGiorno{    public class Student    {
        //Proprietà (privata)
        private string _myPropertyInternalMatricolaStudente;        public string MyPropertyPublicMatricolaStudente        {            get            {                return _myPropertyInternalMatricolaStudente.Substring(5);            }            set            {                if (Age < 20)                    _myPropertyInternalMatricolaStudente = "00021" + this.StudentName.Substring(0, 5) + value;                else                    _myPropertyInternalMatricolaStudente = "00022" + this.StudentName.Substring(0, 5) + value;            }        }

        //Esempi di Auto-implemented Property
        // dichiaro le propieta che verranno riempite
        public int StudentID { get; set; }        public string StudentName { get; set; }        public int Age { get; set; }        public string Address { get; set; }

        
        public void StampaStudente()
        {
            Console.WriteLine("StudenteID {0}", StudentID);
            Console.WriteLine("nome studente {0}", StudentName);
            Console.WriteLine("etá studente {0}", Age);
            Console.WriteLine("indirizzo {0}", Address);

        }            }
    class EsempioUsoClassStudent    {        //riempio le propieta che ho precedentemente dichiarato        public void EsempioUsoClassStudent_Main()        {
            //riempio le propieta che ho precedentemente dichiarato creando delle variabili
            Student std = new Student()            {                StudentID = 1,                StudentName = "Garibardi",                Age = 20,                Address = "New York",                MyPropertyPublicMatricolaStudente = "200"            };            int iStudentID = std.StudentID;            string sAppo = std.MyPropertyPublicMatricolaStudente;
        }           }}
