
using CSEFTPC4Core3Cap.CAPs;
using CSEFTPC4Core3Objects.Ac4yObjects;
using System;
using System.Collections.Generic;

namespace CSEFTPC4Core3Cap
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Ac4yPersistentChild> list = new Ac4yPersistentChildEFCap().GetList();
        }
    }
}
