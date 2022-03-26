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
        public void Insert(Lesson model)
        {
            using var context = new ApplicationContext();
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
