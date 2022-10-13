using Exercices_voiture.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices_voiture.Structures
{
    internal struct Voiture 
    {
        private int _kilometrage;
        public int Kilometrage { get {return _kilometrage; }}

        private int _puissance;
        public int Puissance { get { return _puissance; } }

        private Carburants _carburant;
        public Carburants Carburant { get { return _carburant; } }

        private Marques _marque;
        public Marques Marque { get { return _marque; } }


        public string? Couleur { get; set; }

        public Voiture(Marques marque, int puissance, Carburants carburant):this()
        {
            _puissance = puissance;
            _carburant = carburant;
            _marque = marque;
            _kilometrage = 0;
        }

        public Voiture(Marques marque, int puissance): this()
        {
            _puissance = puissance;
            _marque = marque;
            _kilometrage = 0;
        }

        /// <summary>
        /// ajoute des km la voiture
        /// </summary>
        public void Roule()
        {
            if (_marque == Marques.Renault)
                _kilometrage += 75;
            if (_marque.ToString() is "VW")
                _kilometrage += 100;
        }

        public void boosterLaVoiture(int cheveaux)
        {
            if (cheveaux > _puissance)
            {
                _puissance = cheveaux;
            }
        }


    }
}