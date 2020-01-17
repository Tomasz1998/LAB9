using System;
using System.Collections.Generic;
using System.Text;

namespace LAB9
{
    [Flags]
    public enum TypOsoby
    {
        Brak=0,
        Niemowle=1,
        Dziecko=2,
        Mlodziez=4,
        Dorosly=8,
        Starszy=16
    }
    
    [Flags]
    public enum Zainteresowania
    {
        Elektronika,
        Motoryzacja,
        Gaming,
        Edukacja

    }
}
