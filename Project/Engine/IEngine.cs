using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedalCarAccountingInformationSystem;

public interface IEngine
{
    public bool IsСompatibility(Customer customer);

    public string ToString();

}

