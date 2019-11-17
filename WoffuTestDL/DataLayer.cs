using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoffuTestDL
{
  
    public class DataLayer
    {
        public List<JobTitle> lJobTitles = 
            new List<JobTitle>()
            {
                new JobTitle(1, "Account Manager"),
                new JobTitle(2,"Actor"),
                new JobTitle(3,"Analist"),
                new JobTitle(4,"Agente"),
                new JobTitle(5,"Comecial"),
                new JobTitle(6,"CEO")
            };
        public JobTitle GetJobTitle( int id)
        {
            return lJobTitles.Where(x=>x.JobTitleId.Equals(id)).FirstOrDefault();
        }
        public List<JobTitle> GetJobTitles()
        {
            return lJobTitles;
        }
        public bool PostJobTitle(int id,string name)
        {
            bool retorn = false;
            var jobTitle = GetJobTitle(id);
            if (jobTitle != null) {
                jobTitle.Name = name;
                retorn = true;
            }
            return retorn;
        }
        public List <JobTitle> PutJobTitles(int id, string name)
        {
            var jobtitle = new JobTitle(id, name);
            lJobTitles.Add(jobtitle);
            return lJobTitles;
        }
        public List<JobTitle> DeleteJobTitle(int id) {
            lJobTitles.Remove(GetJobTitle(id));
            return lJobTitles;
        }
    }
}
