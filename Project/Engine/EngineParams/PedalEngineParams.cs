using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedalCarAccountingInformationSystem;

public class PedalEngineParams
{
    public int PedalSize { get; set; }

    public PedalEngineParams(int pedalSize) 
    {
        PedalSize = pedalSize;
    }
}
