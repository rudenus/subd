using ApplicationDB.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDB.Implements
{
    public class LessonStorage
    {
        public List<Lesson> GetFullList()
        {
            using var context = new ApplicationContext();
            return context.Lessons
            .ToList();
        }
        public Lesson GetElement(int id)
        {
            using var context = new ApplicationContext();
            var element = context.Lessons
            .FirstOrDefault(rec => rec.Id == id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            return element;
        }
        public void Insert(Lesson model)
        {
            using var context = new ApplicationContext();
            var element = context.Users.FirstOrDefault(rec => rec.Id == model.User.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            model.User = element;
            var element2 = context.Subjects.FirstOrDefault(rec => rec.Id == model.Subject.Id);
            if (element2 == null)
            {
                throw new Exception("Элемент не найден");
            }
            model.Subject = element2;
            context.Lessons.Add(model);
            context.SaveChanges();
        }
        public void Update(Lesson model)
        {
            using var context = new ApplicationContext();
            var element = context.Lessons.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            var element2 = context.Subjects.FirstOrDefault(rec => rec.Id == model.Subject.Id);
            if (element2 == null)
            {
                throw new Exception("Элемент не найден");
            }
            var element3 = context.Users.FirstOrDefault(rec => rec.Id == model.User.Id);
            if (element3 == null)
            {
                throw new Exception("Элемент не найден");
            }
            model.User = element3;
            model.Subject = element2;

            element.date = model.date;
            element.User = model.User;
            element.Subject = model.Subject;
            element.Estimation = model.Estimation;
            context.SaveChanges();
        }
        public void Delete(Lesson model)
        {
            using var context = new ApplicationContext();
            Lesson element = context.Lessons.FirstOrDefault(rec => rec.Id ==
           model.Id);
            if (element != null)
            {
                context.Lessons.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
    }
}
