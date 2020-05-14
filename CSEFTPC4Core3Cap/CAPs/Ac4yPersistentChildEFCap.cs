using CSARMetaPlan.Class;
using System.Linq;
using Ac4yUtilityContainer;
using CSEFTPC4Core3Objects.Ac4yObjects;
using System.Collections;
using System.Collections.Generic;

namespace CSEFTPC4Core3Cap.CAPs
{

    public class Ac4yPersistentChildEFCap
    {
        public Ac4yPersistentChildEFCap()
        {
            new Context().Database.EnsureCreated();
        }

        public IEnumerable<Ac4yPersistentChild> GetAc4yPersistentChilds()
        {
            return new Context().Ac4yPersistentChilds;
        }

      public void Insert(Ac4yPersistentChild ac4yPersistentChild)
      {

          using (var context = new Context())
          {
                

              context.Ac4yPersistentChilds.Add(ac4yPersistentChild);
              context.SaveChanges();
          }

      } // Insert

      public Ac4yPersistentChild GetById(int id)
      {

          return new Context().Ac4yPersistentChilds.Find(id);

      } // GetById

      public bool IsExistById(int id)
      {
        return GetById(id) != null;
      }

      public Ac4yPersistentChild GetByGuid(string guid)
      {

          return new Context().Ac4yPersistentChilds
                    .Where(entity => entity.guid == guid)
                    .FirstOrDefault<Ac4yPersistentChild>();

      } // GetByGuid

      public bool IsExistByGuid(string guid)
      {

          return GetByGuid(guid) != null;

      } // IsExistByGuid

      public void UpdateById(int id, Ac4yPersistentChild ac4yPersistentChild)
      {

            using (var context = new Context())
            {

                Ac4yPersistentChild actual = context.Ac4yPersistentChilds.Find(id);
                new Ac4yUtility().Object2Object(ac4yPersistentChild, actual);
                context.SaveChanges();

            }

      } // UpdateById

      public void UpdateByGuid(string guid, Ac4yPersistentChild ac4yPersistentChild)
      {

          using (var context = new Context())
          {

              Ac4yPersistentChild actual = context.Ac4yPersistentChilds.Where(entity => entity.guid == guid).FirstOrDefault<Ac4yPersistentChild>();
              int id = actual.Id;
              new Ac4yUtility().Object2Object(ac4yPersistentChild, actual);
              actual.Id = id;
              actual.guid= guid;
              context.SaveChanges();

          }

          
      } // UpdateByGuid

        public void DeleteAc4yPersistentChildById(int id)
        {
            var context = new Context();

            Ac4yPersistentChild ac4yPersistentChild = context.Ac4yPersistentChilds.Find(id);
            context.Ac4yPersistentChilds.Remove(ac4yPersistentChild);
            context.SaveChanges();

        } // DeleteAc4yPersistentChildById

    } // Ac4yPersistentChildEFCap

} // EFCap
