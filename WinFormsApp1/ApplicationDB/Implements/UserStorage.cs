using ApplicationDB.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDB.Implements
{
    public class UserStorage
    {
        public List<User> GetFullList()
        {
            using var context = new ApplicationContext();
            return context.Users
            .ToList();
        }
        public User GetElement(int id)
        {
            using var context = new ApplicationContext();
            var element = context.Users
            .FirstOrDefault(rec => rec.Id == id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            return element;
        }
        public void Insert(User model)
        {
            using var context = new ApplicationContext();
            var element = context.Classes.FirstOrDefault(rec => rec.Id == model.Class.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            model.Class = element;
            var element2 = context.Roles.FirstOrDefault(rec => rec.Id == model.Role.Id);
            if (element2 == null)
            {
                throw new Exception("Элемент не найден");
            }
            model.Role = element2;
            context.Users.Add(model);
            context.SaveChanges();
        }
        public void Update(User model)
        {
            using var context = new ApplicationContext();
            var element = context.Users.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            var element3 = context.Classes.FirstOrDefault(rec => rec.Id == model.Class.Id);
            if (element3 == null)
            {
                throw new Exception("Элемент не найден");
            }
            model.Class = element3;
            var element2 = context.Roles.FirstOrDefault(rec => rec.Id == model.Role.Id);
            if (element2 == null)
            {
                throw new Exception("Элемент не найден");
            }
            model.Role = element2;
            element.Lessons = model.Lessons;
            element.Login = model.Login;
            element.Password = model.Password;
            element.Role = model.Role;
            element.Class = model.Class;
            element.Lessons = model.Lessons;
            element.Name = model.Name;
            context.SaveChanges();
        }
        public void Delete(User model)
        {
            using var context = new ApplicationContext();
            User element = context.Users.FirstOrDefault(rec => rec.Id ==
           model.Id);
            if (element != null)
            {
                context.Users.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
    }
}
