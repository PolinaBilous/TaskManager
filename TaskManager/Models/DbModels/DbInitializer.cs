using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.DbModels
{
    public class DbInitializer
    {
        public static void Initialize(TaskManagerContext context)
        {
            context.Database.EnsureCreated();

            if (context.Statuses.Any())
            {
                return;
            }

            List<Status> statuses = new List<Status>()
            {
                new Status() { Name = "completed" },
                new Status() { Name = "doing" },
                new Status() { Name = "recorded" },
            };
            foreach(Status s in statuses)
            {
                context.Statuses.Add(s);
            }
            context.SaveChanges();
        }
    }
}
