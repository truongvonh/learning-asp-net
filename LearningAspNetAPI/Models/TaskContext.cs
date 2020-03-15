using Microsoft.EntityFrameworkCore;

namespace LearningAspNetAPI.Models {
    public class TaskContext: DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) 
        : base(options)
        {

        }

        public DbSet<Task> TaskItems { get; set; }

    }
}

