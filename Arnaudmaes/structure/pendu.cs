
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arnaudmaes.Structures
{
    internal struct pendu 
    {
        private int _life = 5;
        public int life { get {return _life;} set { _life = value; }}

        private int _generalCount;
        public int generalCount { get {return _generalCount;} set { _generalCount = value; }}


        private char[] _lettreTrouve = new char[100];

        public char[] lettreTrouve { get {return _lettreTrouve;}}
        private char[] _lettrerater = new char[100];
        public char[] lettrerater { get {return _lettrerater;}}
        private char[] _mot;
        public char[] mot { get {return _mot;}}


        public pendu(char[] mot, int generalCount):this()
        {
            _mot = mot;
            _generalCount = generalCount;
        }

        public string verif(string lettre)
        {
         int count = 0;
         for(int i=0;i<mot.Length;i++){
            if(mot[i]==lettre[0]){
                count++;
                generalCount--;
            }
         }
         if(count>0){
            System.Console.WriteLine("félicitation");
            lettreTrouve[lettreTrouve.Length-1]= lettre[0];
         }else{
            life--;
            lettrerater[lettrerater.Length-1] = lettre[0];
         }
         return lettre;   
        }

        


    }
}