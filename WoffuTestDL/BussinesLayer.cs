﻿using System;
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
        public  BussinessLayer()
        {
            lJobTitles = ReadValuesOfFile();
        }
        

        private List<JobTitle> ReadValuesOfFile()
        {
            var retorn = new List<JobTitle>();
            var readValues= File.ReadAllLines("WoffuValues.txt");
            foreach (var jobtitle in readValues)
            {
                var ArrayRecord= jobtitle.Split(',');
                if (ArrayRecord.Count() > 1)
                {
                    retorn.Add(new JobTitle(Convert.ToInt16(ArrayRecord[0]), ArrayRecord[1], Convert.ToInt16(ArrayRecord[2])));
                }
            }
            return null;            
        }
        private bool WriteValuesToFile()
        {
            List<string> valuesOfList = new List<string>();
            foreach (var linia in lJobTitles)
            {
                valuesOfList.Add(linia.JobTitleId.ToString() + "," + linia.Name + "," + linia.CompanyId.ToString());
            }
            File.WriteAllLines("WoffuValues.txt",valuesOfList);
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
        public List <JobTitle> PostJobTitle( string name)
        {
            var jobtitle = new JobTitle(GetId(), name);
            lJobTitles.Add(jobtitle);
            WriteValuesToFile();
            return lJobTitles;
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
