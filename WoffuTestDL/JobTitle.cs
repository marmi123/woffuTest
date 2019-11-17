using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoffuBL
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
}
