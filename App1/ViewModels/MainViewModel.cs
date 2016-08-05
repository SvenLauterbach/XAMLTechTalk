using App1.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace App1.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            InsertPersonCommand = new RelayCommand(InsertPerson);
        }
        
        private string _firstname;        
        public string Firstname
        {
            get { return _firstname; }
            set { Set(ref _firstname, value); }
        }

        private string _lastname;
        public string Lastname
        {
            get { return _lastname; }
            set { Set(ref _lastname, value); }
        }

        private ObservableCollection<Person> _persons = new ObservableCollection<Person>();
        public ObservableCollection<Person> Persons
        {
            get { return _persons; }
        }

        private ICommand _insertPersonCommand;
        public ICommand InsertPersonCommand
        {
            get { return _insertPersonCommand; }
            set { Set(ref _insertPersonCommand, value); }
        }

        public void InsertPerson()
        {
            Persons.Add(new Person
            {
                Firstname = this.Firstname,
                Lastname = this.Lastname
            });
            this.Firstname = "";
            this.Lastname = "";
        }
    }
}
