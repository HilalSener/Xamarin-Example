using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AAMVVM.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AAMVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonPage : ContentPage
    {

        //private readonly  IList<PersonModel> model = new ObservableCollection<PersonModel>();
        public PersonPage()
        {
            InitializeComponent();
            //BindData();
        }

        //Web-Service Call
        //private void BindData()
        //{
        //    model.Add(new PersonModel
        //        {
        //            Id = 1,
        //            Name = "Hilal",
        //            Surname = "Sener"
        //        });
        //    model.Add(new PersonModel
        //    {
        //        Id = 2,
        //        Name = "Aysu",
        //        Surname = "Sener"
        //    });

        //    //LstPerson.ItemsSource = model;
        //    LstPerson.BindingContext = model;
        //}

        //private void onDelete(object sender, EventArgs e)
        //{
        //    MenuItem item = (MenuItem) sender;
        //    PersonModel selectedModel = (PersonModel) item.CommandParameter;
        //    if (selectedModel != null)
        //        model.Remove(selectedModel);
        //}

        //private void onUpdate(object sender, EventArgs e)
        //{
        //    MenuItem item = (MenuItem)sender;
        //    PersonModel selectedModel = (PersonModel)item.CommandParameter;
        //    //Model de değişiklik yapmak
        //    if (selectedModel != null)
        //        selectedModel.Name = selectedModel.Surname.Substring(0,1) + "." + selectedModel.Name;
        //}
    }
}