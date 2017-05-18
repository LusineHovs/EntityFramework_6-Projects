namespace CodeFirst
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Model : DbContext
    {
       
        public Model()
            : base("name=Model")
        {
        }

         public virtual DbSet<StudentInfo> StudentInfos { get; set; }
    }

    
}