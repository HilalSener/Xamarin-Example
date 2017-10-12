using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AAMVVM.Models;
using Xamarin.Forms;
using AAMVVM.Annotations;
using System.Runtime.CompilerServices;

namespace AAMVVM.ViewModels
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        public PersonViewModel()
        {
            BindData();
            deleteCommand = new Command(onDelete);
            updateCommand = new Command(onUpdate);
            refreshCommand = new Command(onRefresh);
        }

        private ICommand deleteCommand, updateCommand, refreshCommand;

        private ObservableCollection<PersonModel> _person;

        public ObservableCollection<PersonModel> Person
        {
            get
            {
                if(_person == null)
                    _person = new ObservableCollection<PersonModel>();

                return _person;
            }

            set { _person = value; }
        }

        private bool _isRefreshing;

        public bool IsRefreshing
        {
            get { return _isRefreshing; }
            set
            {
                _isRefreshing = value;
                OnPropertyChanged();
            }
        }

        private void BindData()
        {
            this.IsRefreshing = true;
            Person.Clear();
            Person.Add(new PersonModel
            {
                Id = 1,
                Name = "Hilal",
                Surname = "Sener"
            });
            Person.Add(new PersonModel
            {
                Id = 2,
                Name = "Aysu",
                Surname = "Sener"
            });
            this.IsRefreshing = false;
        }

        public ICommand DeleteCommand
        {
            get { return deleteCommand; }
            set
            {
                if(deleteCommand == null)
                    return;
                deleteCommand = value;
            }
        }

        public ICommand UpdateCommand
        {
            get { return updateCommand; }
            set
            {
                if (updateCommand == null)
                    return;
                updateCommand = value;
            }
        }

        public ICommand RefreshCommand
        {
            get { return refreshCommand; }
            set
            {
                if (refreshCommand == null)
                    return;
                refreshCommand = value;
            }
        }

        private void onDelete(object param)
        {
            PersonModel selectedModel = (PersonModel) param;
            if (selectedModel != null)
                Person.Remove(selectedModel);
        }

        private void onUpdate(object param)
        {
            PersonModel selectedModel = (PersonModel) param;
            if(selectedModel != null)
                selectedModel.Name = selectedModel.Surname.Substring(0, 1) + "." + selectedModel.Name;
        }

        private void onRefresh()
        {
            BindData();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}