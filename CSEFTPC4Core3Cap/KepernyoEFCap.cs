using CSARMetaPlan.Class;
using System.Linq;
using Ac4yUtilityContainer;
using System.Collections.Generic;
using CSEFTPC4Core3Cap;

namespace  CSEFTPC4Core3CAP.CAPs
{

    public class KepernyoEFCap
    {
      public IEnumerable<Kepernyo> GetList()
      {
          
          return new Context().Kepernyos;

      } // GetList   
   
      public Kepernyo Insert(Kepernyo kepernyo)
      {

          using (var context = new Context())
          {

              context.Kepernyos.Add(kepernyo);
              context.SaveChanges();
          }

          return kepernyo;

      } // Insert

      public Kepernyo GetById(int id)
      {

          return new Context().Kepernyos.Find(id);

      } // GetById

      public bool IsExistById(int id)
      {
        return GetById(id) != null;
      }

      public Kepernyo GetByGuid(string guid)
      {

          return new Context().Kepernyos
                    .Where(entity => entity.GUID == guid)
                    .FirstOrDefault<Kepernyo>();

      } // GetByGuid

      public bool IsExistByGuid(string guid)
      {

          return GetByGuid(guid) != null;

      } // IsExistByGuid

      public void UpdateById(int id, Kepernyo kepernyo)
      {

            using (var context = new Context())
            {

                Kepernyo actual = context.Kepernyos.Find(id);
                new Ac4yUtility().Object2Object(kepernyo, actual);
                context.SaveChanges();

            }

      } // UpdateById

      public void UpdateByGuid(string guid, Kepernyo kepernyo)
      {

          using (var context = new Context())
          {

              Kepernyo actual = context.Kepernyos.Where(entity => entity.GUID == guid).FirstOrDefault<Kepernyo>();
              int id = actual.Id;
              new Ac4yUtility().Object2Object(kepernyo, actual);
              actual.Id = id;
              actual.GUID= guid;
              context.SaveChanges();

          }

      } // UpdateByGuid
      
    public List<Kepernyo> GetListOfKepernyo()
    {

        using(var context = new Context())
        {
            return context.Kepernyos.ToList();
        }

    } // GetListOfKepernyo

    public void DeleteKepernyo(Kepernyo kepernyo)
    {

        var context = new Context();

        context.Kepernyos.Remove(kepernyo);
        context.SaveChanges();

    } // DeleteKepernyo

    public void DeleteById(int id)
    {
        
        var context = new Context();

        Kepernyo actual = context.Kepernyos.Find(id);
        context.Kepernyos.Remove(actual);
        context.SaveChanges();

    } // DeleteById

    } // KepernyoEFCap

} // EFCap
