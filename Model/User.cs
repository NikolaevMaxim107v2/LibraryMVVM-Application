using LibraryMVVM_Application.Model.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVVM_Application.Model
{
    public class User : PropertyChange
    {
        private int _id;
        private string _name;
        private string _surname;
        private ObservableCollection<Book> _bookList;

        public User(int id, string name, string surname, ObservableCollection<Book> BookList)
        {
            Id = id;
            Name = name;
            Surname = surname;
            this.BookList = BookList;
        }

        public int Id { get => _id; set { _id = value; OnPropertyChanged(nameof(Id)); } }
        public string Name { get => _name; set { _name = value; OnPropertyChanged(nameof(Name)); } }
        public string Surname { get => _surname; set { _surname = value; OnPropertyChanged(nameof(Surname)); } }
        public ObservableCollection<Book> BookList { get => _bookList; set { _bookList = value; OnPropertyChanged(nameof(BookList)); } }

    }
}
