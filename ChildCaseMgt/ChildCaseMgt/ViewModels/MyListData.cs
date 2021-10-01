using ChildCaseMgt.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ChildCaseMgt.ViewModels
{
    class MyListData
    {
        public ObservableCollection <MyListModel> Chapters { get; set; }

        public MyListData()
        {
            Chapters = new ObservableCollection<MyListModel>();
            Chapters.Add(new MyListModel {
                id=1,
                Name="All Children Strive and Thrive",
                Images= "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRzrRCsCYJWUSESyQVP62LCluYZMX2yG4RlAQ&usqp=CAU",
                Details= "Healthy, well-nourished children are the key to Pakistan’s future prosperity." });
            Chapters.Add(new MyListModel {
                id=2,
                Name="All Children Learning", 
                Images= "https://www.unicefusa.org/sites/default/files/field-images/landing-feature-image/2020/UNI317535_0.jpg",
                Details= "Education is a fundamental right, enshrined in Article 25A of Pakistan’s Constitution" });
            Chapters.Add(new MyListModel
            {
                id=3,
                Name = "All Children Protected from Violence and Exploitation",
                Images = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcReuOFcOhHAcDhtRJJ8UHpxeIy_aeprKIYSfsEk2kDBJhuadrVbPKoTrjJZHccqXsSAEH0&usqp=CAU",
                Details = "The right to protection from violence, exploitation is a basic right of all the world’s children reaffirmed across the SDGs."
            });
            Chapters.Add(new MyListModel
            {
                id=4,
                Name = "Children Live in Safe and Clean Environment",
                Images = "https://www.unicef.org/pakistan/sites/unicef.org.pakistan/files/styles/hero_mobile/public/WASH%20Brochure%20Pic.jpg?itok=jfwsW6RG",
                Details = "Access to safe drinking water and improved sanitation services is essential for child rights and well being"
            });
            Chapters.Add(new MyListModel
            {
                id=5,
                Name = "Cross Cutting Priorities for children",
                Images = "https://www.unicef.org/sop/sites/unicef.org.sop/files/styles/hero_mobile/public/Gaza019.jpg?itok=qgO69srp",
                Details = "Gender, poverty and geographic location are three key factors that determine disparities in child well being and child rights in Pakistan."
            });
        }
    }
}
