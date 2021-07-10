using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestRepo.Data
{
    public class Car
    {

        public Car()
        {
            this.Issues = new HashSet<Issue>();
        }

        public int Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

       public ICollection<Issue> Issues { get; set; }
    }
}
