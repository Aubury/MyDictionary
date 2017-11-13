using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class Irregular_verbs
    {
        public string Infinitive { get; set; }
        public string Past_Simple { get; set; }
        public string Past_Participle { get; set; }
        public string Translation { get; set; }
    
        public override string ToString()
        {
            return $"\nInfinitive = {Infinitive},\nPast Simple =  { Past_Simple},\nPast Participle = {Past_Participle},\nTranslation = {Translation}";
        }
     
    }
}
