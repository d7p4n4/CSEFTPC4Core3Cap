
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
            new Ac4yPersistentChildEFCap().Insert(new Ac4yPersistentChild()
            {
                name = "teszt",
                createdAt = DateTime.Now,
                updatedAt = DateTime.Now
            });
        }
    }
}
