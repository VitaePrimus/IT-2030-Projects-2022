namespace ClassSchedule.Models
{
    public interface IClassScheduleUnitOfWork
    {
        //public Repository<Day> Days { get; }
        //public Repository<Teacher> Teachers { get; }
        //public Repository<Class> Classes { get; }

        public IRepository<Day> Days { get; }
        public IRepository<Teacher> Teachers { get; }
        public IRepository<Class> Classes { get; }

        public void Save();
    }
}
