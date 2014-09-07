using ListBox_DataTemplate.Class.Employer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ListBox_DataTemplate.ListBox.Template1 {
    class ListBoxTemplate1
    {

        public static List<Employer> GetEmplist()
        {

            List<Employer> EmpList = new List<Employer>();

            EmpList.Add (new Employer () { Name = "Halid", Position = "CEO", Img = GetImageFromFile("Images/ico1.png") });
            EmpList.Add (new Employer () { Name = "Ousou", Position = "CMO", Img = GetImageFromFile ("Images/ico2.png") });
            EmpList.Add (new Employer () { Name = "Amad", Position = "CTO", Img = GetImageFromFile ("Images/ico3.png") });
            EmpList.Add (new Employer () { Name = "Keita", Position = "TCM", Img = GetImageFromFile ("Images/ico4.png") });
            EmpList.Add (new Employer () { Name = "Bayogo", Position = "NMO", Img = GetImageFromFile ("Images/ico5.png") });
            EmpList.Add (new Employer () { Name = "Maiga", Position = "YHN", Img = GetImageFromFile ("Images/ico6.png") });
            EmpList.Add (new Employer () { Name = "Toure", Position = "RTE", Img = GetImageFromFile ("Images/ico7.png") });
            EmpList.Add (new Employer () { Name = "Diallo", Position = "VCI", Img = GetImageFromFile ("Images/ico8.png") });
            EmpList.Add (new Employer () { Name = "Barry", Position = "OKM", Img = GetImageFromFile ("Images/ico9.png") });
            EmpList.Add (new Employer () { Name = "Cisse", Position = "LLK", Img = GetImageFromFile ("Images/ico10.png") });

            return EmpList;

        }


        public static System.Windows.Media.Imaging.BitmapImage GetImageFromFile ( string path )
        {
            System.Windows.Media.Imaging.BitmapImage img = new System.Windows.Media.Imaging.BitmapImage ();
            img.BeginInit ();
            img.UriSource = new System.Uri (path, System.UriKind.RelativeOrAbsolute);
            img.EndInit ();

            return img;
        }



    }
      
}



    


