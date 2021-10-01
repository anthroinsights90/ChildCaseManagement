using ChildCaseMgt.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ChildCaseMgt.ViewModels
{
    class ChildrenLearningData
    {
        public IList<ChildrenLearning> ProvinceList { get; set; }
       public ChildrenLearningData()
        {
            try
            {
                ProvinceList = new ObservableCollection<ChildrenLearning>();
                ProvinceList.Add(new ChildrenLearning { p_id = 1, p_Name = "Punjab" });
                ProvinceList.Add(new ChildrenLearning { p_id = 2, p_Name = "Sindh" });
                ProvinceList.Add(new ChildrenLearning { p_id = 3, p_Name = "Balochistan" });
                ProvinceList.Add(new ChildrenLearning { p_id = 4, p_Name = "KPK" });
                
            }
            catch
            {

            }
        }
    }
}
