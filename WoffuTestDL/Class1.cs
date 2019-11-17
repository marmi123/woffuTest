using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoffuTestDL
{
    public class JobTitle
    {
        public int JobTitleId { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public JobTitle(int pId, string pName, int pCompanyId = 1)
        {
            JobTitleId = pId;
            Name = pName;
            CompanyId = pCompanyId;
        }

    }
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
        public JobTitle GetJobTitles( int id)
        {
            return lJobTitles.Where(x=>x.JobTitleId.Equals(id)).FirstOrDefault();
        }
        public List<JobTitle> GetJobTitles()
        {
            return lJobTitles;
        }
        public bool PostJobTitles(int id,string name)
        {
            bool retorn = false;
            var jobTitle = GetJobTitles(id);
            if (jobTitle != null) {
                jobTitle.Name = name;
                retorn = true;
            }
            return retorn;
        }
        public List <JobTitle> PutJobTitles(int id, string name)
        {
            var jobtitle=new JobTitle
        }

    }
}
