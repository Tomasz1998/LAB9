using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB9
{
    static public class ExtensionMethods
    {
        public static (int, int) Podziel(this int dzielna, int dzielnik)
        {
            return (dzielna / dzielnik, dzielna % dzielnik);
        }
        public static int IloscZnakow(this string znaki, char SzukanaLitera)
        {
            int ile = 0;
            for (int i = 0; i < znaki.Length; i++)
            {
                if (znaki[i] == SzukanaLitera)
                {
                    ile++;
                }
            }
            return ile;
        }
        //public static int IloscZnakow1(this string znaki, char litery)
        //{
        //    return znaki.Where(x => x.Equals(litery)).Count();
        //}
        public static int IloscZnakow(this string znaki, char SzukanaLitera, bool caseInvarian = true)
        {
            if (!caseInvarian)
            {
                znaki.IloscZnakow(SzukanaLitera);
            }

            if (char.IsLetter(SzukanaLitera))
            {
                return znaki.IloscZnakow(char.ToLower(SzukanaLitera))
                    + znaki.IloscZnakow(char.ToUpper(SzukanaLitera));
            }
            else
            {
                return znaki.IloscZnakow(SzukanaLitera);
            }
        }
        //public static int IloscZnakow(this string znaki, char SzukanaLitera, bool caseInvarian = true)
        //{
        //    if (caseInvarian)
        //    {
        //        znaki = znaki.ToLower();
        //        SzukanaLitera = char.ToLower(SzukanaLitera);
        //    }
        //    return znaki.IloscZnakow(SzukanaLitera);
        //}


        public static int SumaTypowOsob(this TypOsoby typ)
        {

            return Enum.GetValues(typeof(TypOsoby)).Cast<TypOsoby>().Sum(x => (int)x);
            
        }
    }
}
