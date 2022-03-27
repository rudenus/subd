using ApplicationDB.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDB.Implements
{
    public class RoleStorage
    {
        public List<Role> GetFullList()
        {
            using var context = new ApplicationContext();
            return context.Roles
            .ToList();
        }
        public List<Role> GetFiltredList(string str)
        {
            using var context = new ApplicationContext();
            return context.Roles.Where(r => r.Name.Contains(str))
            .ToList();
        }
        public void Insert(Role model)
        {
            using var context = new ApplicationContext();
            context.Roles.Add(model);
            context.SaveChanges();
        }
        public Role GetElement(int id)
        {
            using var context = new ApplicationContext();
            var element = context.Roles
            .FirstOrDefault(rec => rec.Id == id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            return element;
        }
        public void Update(Role model)
        {
            using var context = new ApplicationContext();
            var element = context.Roles.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.Users = model.Users;
            element.Name = model.Name;
            context.SaveChanges();
        }
        public void Delete(Role model)
        {
            using var context = new ApplicationContext();
            Role element = context.Roles.FirstOrDefault(rec => rec.Id ==
           model.Id);
            if (element != null)
            {
                context.Roles.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
    }
}
