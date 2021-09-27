using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearwoxCodeChallenge.Consol
{
    public static class QuestionClass
    {
        public static List<string> NameList = new List<string>
        {
            "Jimmy",
            "Jeffrey",
            "John"
        };

        public static dynamic TESTModule(dynamic value)
        {
            dynamic result;
            switch (value)
            {
                case < 1:
                    result = "throw proper exception";
                    break;
                case <= 4 :
                    result = value * 2;
                    break;
                case > 4:
                    result = value * 3;
                    break;
                case 1.0f:
                    result = 3.0f;
                    break;
                case 3.0f:
                    result = 3.0f;
                    break;
                default:
                    string str = Convert.ToString(value);
                    str = str.ToUpper();
                    result = str;
                    break;

            }
            return result;
        }
    }
}
