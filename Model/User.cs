using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVVM_Application.Model
{
    public class User
    {
        public User(int id, string name, string surname, ObservableCollection<Book> BookList)
        {
            Id = id;
            Name = name;
            Surname = surname;
            this.BookList = BookList;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public ObservableCollection<Book> BookList { get; set; }
    }
}
