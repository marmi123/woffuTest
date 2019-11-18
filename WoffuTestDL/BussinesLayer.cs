using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoffuBL
{
  
    public class BussinessLayer
    {
        public List<JobTitle> lJobTitles;
        string path;
        public  BussinessLayer(string path)
        {
            this.path = path;
            lJobTitles = ReadValuesOfFile();
        }
        

        private List<JobTitle> ReadValuesOfFile()
        {
            var retorn = new List<JobTitle>();
            string[] readValues;
            //This code is only for the unit test
            //Simulate a BBDD with a text file
            //The folders structure depends of the project type
            if (Directory.Exists(path + "/bin/"))
            {
                readValues = File.ReadAllLines(path + "/bin/WoffuValues.txt");
            }
            else
            {
                readValues = File.ReadAllLines(path + "/WoffuValues.txt");
            }
            foreach (var jobtitle in readValues)
            {
                var ArrayRecord= jobtitle.Split(',');
                if (ArrayRecord.Count() > 1)
                {
                    retorn.Add(new JobTitle(Convert.ToInt16(ArrayRecord[0]), ArrayRecord[1], Convert.ToInt16(ArrayRecord[2])));
                }
            }
            return retorn;            
        }
        private bool WriteValuesToFile()
        {
            List<string> valuesOfList = new List<string>();
            foreach (var linia in lJobTitles)
            {
                valuesOfList.Add(linia.JobTitleId.ToString() + "," + linia.Name + "," + linia.CompanyId.ToString());
            }
            //This code is only for the unit test
            //Simulate a BBDD with a text file
            //The folders structure depends of the project type
            if (Directory.Exists(path + "/bin/"))
                File.WriteAllLines(path + "/bin/WoffuValues.txt", valuesOfList);
            else
                File.WriteAllLines(path + "/WoffuValues.txt", valuesOfList);
            return true;
        }
        public JobTitle GetJobTitle( int id)
        {
            return lJobTitles.Where(x=>x.JobTitleId.Equals(id)).FirstOrDefault();
        }
        public List<JobTitle> GetJobTitles()
        {
            return lJobTitles;
        }
        public List<JobTitle> PutJobTitle(int id,string name)
        {
            //bool retorn = false;
            var jobTitle = GetJobTitle(id);
            if (jobTitle != null) {
                jobTitle.Name = name;
                //retorn = true;
            }
            WriteValuesToFile();
            return lJobTitles;
        }
        public int PostJobTitle( string name)
        {
            var id = GetId();
            var jobtitle = new JobTitle(id, name);
            lJobTitles.Add(jobtitle);
            WriteValuesToFile();
            return id;
        }

        private int GetId()
        {
            int retorn = 1;
            if (lJobTitles == null)
                lJobTitles = new List<JobTitle>();            
            var lastElement = lJobTitles.OrderByDescending(x => x.JobTitleId).FirstOrDefault();
            if (lastElement != null)
               retorn=lastElement.JobTitleId+1;
            return retorn;
        }

        public bool DeleteJobTitle(int id) {
           var retorn= lJobTitles.Remove(GetJobTitle(id));
            if (retorn)
                WriteValuesToFile();
            return retorn;        }
    }
}
