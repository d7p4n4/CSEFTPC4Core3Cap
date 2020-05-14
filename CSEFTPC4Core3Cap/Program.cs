
using CSEFTPC4Core3Cap.CAPs;
using System;

namespace CSEFTPC4Core3Cap
{
    class Program
    {
        static void Main(string[] args)
        {
            new Ac4yPersistentChildEFCap().UpdateById(1, new CSEFTPC4Core3Objects.Ac4yObjects.Ac4yPersistentChild()
            {
                Id = 1,
                name = "updated",
                updatedAt = "1525"
            });
        }
    }
}
