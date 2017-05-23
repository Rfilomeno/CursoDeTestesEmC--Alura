﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.Leilao.outrasclassesdiferentes
{
    public class AnoBissexto
    {
        public bool EhBissexto(int ano)
        {
            if(ano % 4 == 0)
            {
                if(ano >= 100 && ano % 100 == 0)
                {
                    if(ano >= 400 && ano % 400 == 0)
                    {
                        return true;
                    }
                    return false;
                }
                return true;
            }
            
            return false;
        }
    }
}
