using ApplicationDB.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDB.Implements
{
    public class SubjectStorage
    {
        public List<Subject> GetFullList()
        {
            using var context = new ApplicationContext();
            return context.Subjects
            .ToList();
        }
        public Subject GetElement(int id)
        {
            using var context = new ApplicationContext();
            var element = context.Subjects
            .FirstOrDefault(rec => rec.Id == id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            return element;
        }
        public void Insert(Subject model)
        {
            using var context = new ApplicationContext();
            var element = context.Users.FirstOrDefault(rec => rec.Id == model.User.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            model.User = element;
            context.Subjects.Add(model);
            context.SaveChanges();
        }
        public void Update(Subject model)
        {
            using var context = new ApplicationContext();
            var element = context.Subjects.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            var element2 = context.Users.FirstOrDefault(rec => rec.Id == model.User.Id);
            if (element2 == null)
            {
                throw new Exception("Элемент не найден");
            }
            model.User = element2;
            element.Lessons = model.Lessons;
            element.User = model.User;
            element.Name = model.Name;
            context.SaveChanges();
        }
        public void Delete(Subject model)
        {
            using var context = new ApplicationContext();
            Subject element = context.Subjects.FirstOrDefault(rec => rec.Id ==
           model.Id);
            if (element != null)
            {
                context.Subjects.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
    }
}
