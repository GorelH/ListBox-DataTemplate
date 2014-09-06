using ListBox_DataTemplate.Class.Employer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ListBox_DataTemplate.ListBox.Template1 {
    public class ListBoxTemplate1
    {

        public List<Employer> GetEmplist()
        {

            List<Employer> EmpList = new List<Employer>();

            EmpList.Add(new Employer() { Name = "Halid", Position = "CTO" });
            EmpList.Add(new Employer() { Name = "Ousou", Position = "LLo" });
            EmpList.Add(new Employer() { Name = "Mali", Position = "CDk" });

            return EmpList;

        }
    }
      
}



    


