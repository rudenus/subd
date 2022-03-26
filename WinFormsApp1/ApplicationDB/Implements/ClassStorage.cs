using ApplicationDB.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDB.Implements
{
    public class ClassStorage
    {
        public List<Class> GetFullList()
        {
            using var context = new ApplicationContext();
            return context.Classes
            .ToList();
        }
        public void Insert(Class model)
        {
            using var context = new ApplicationContext();
            context.Classes.Add(model);
            context.SaveChanges();
        }
        public void Update(Class model)
        {
            using var context = new ApplicationContext();
            var element = context.Classes.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.Number = model.Number;  
            element.Letter = model.Letter;
            element.Users = model.Users;
            context.SaveChanges();
        }
        public void Delete(Class model)
        {
            using var context = new ApplicationContext();
            Class element = context.Classes.FirstOrDefault(rec => rec.Id ==
           model.Id);
            if (element != null)
            {
                context.Classes.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
    }
}
