using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   
     public abstract class Universitate 
    {
       abstract public void add();
       abstract public void read();
    }
    public class Facultate : Universitate
    {
        private string numeFacultate;
        private string domeniuFacultate;
        public Facultate(string nume, string domeniu)
        {
            numeFacultate = nume;
            domeniuFacultate = domeniu;
        }
        public override void add()
        {

        }
        public override void read()
        {
            Console.WriteLine("Nume facultate: {0}\n Domeniu Facultate: {1}\n", numeFacultate, domeniuFacultate);
        }
    }
    public class Cursuri :Universitate
    {
        private string numeCurs;
        private string shortDescription;
        private int durataCurs;
        public Cursuri (string nume , string descriere , int durata)
        {
            numeCurs = nume;
            shortDescription = descriere;
            durataCurs = durata;
        }
        public override void add()
        {

        }
        public override void read()
        {
            Console.WriteLine("Nume curs: {0}\n Descriere: {1}\n Durata: {2}\n", numeCurs, shortDescription, durataCurs);
        }
    }
    public class Profesori : Universitate
    {
        private string numeProfesor;
        private string prenumeProfesor;
        private string materiePredata;
        public Profesori(string nume , string prenume , string materie)
        {
            numeProfesor = nume;
            prenumeProfesor = prenume;
            materiePredata = materie;
        }
        public override void add()
        {

        }
        public override void read()
        {
            Console.WriteLine("Nume profesor: {0}\n Prenume profesor: {1}\n Materie: {2}\n", numeProfesor, prenumeProfesor, materiePredata);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Facultate facultate = new Facultate("Politehnica", "inginerie");
            Cursuri curs = new Cursuri("PSSC", "Proiectarea sistemelor software complexe ", 3);
            Profesori profesor = new Profesori("Agape", "Mihai", "PSSC");
            facultate.read();
            curs.read();
            profesor.read();

        }
    }
}
