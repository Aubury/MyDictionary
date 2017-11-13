using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class Dictionary_of_irregular_verds
    {
        public static Dictionary<string,Irregular_verbs> MyDict()
        {
            Dictionary<string, Irregular_verbs> dict = new Dictionary<string, Irregular_verbs>();
           
            dict.Add("be", new Irregular_verbs { Infinitive = "be", Past_Simple = "was / were", Past_Participle = "been", Translation = "быть" });
            dict.Add("beat", new Irregular_verbs { Infinitive = "beat", Past_Simple = "beat", Past_Participle = "beaten", Translation = "бить" });
            dict.Add("become", new Irregular_verbs { Infinitive = "become", Past_Simple = "became", Past_Participle = "become", Translation = "становиться" });
            dict.Add("begin", new Irregular_verbs { Infinitive = "begin", Past_Simple = "began", Past_Participle = "begun", Translation = "начинать" });
            dict.Add("break", new Irregular_verbs { Infinitive = "break", Past_Simple = "broke", Past_Participle = "broken", Translation = "ломать" });
            return dict;
                
        }
      
     
    }
}
