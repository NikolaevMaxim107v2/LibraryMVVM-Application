using LibraryMVVM_Application.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryMVVM_Application.Model
{
    public class Book : PropertyChange
    {
        private int _count;
        private int _age;
        private string _author;
        private string _name;
        private short _arc;
        public Book(string author, string name, short arc, int age, int count)
        {
            Author = author;
            Name = name;
            Arc = arc;
            Age = age;
            Count = count;
        }

        public string Author { get => _author; set { _author = value; OnPropertyChanged(nameof(Author)); } }
        public string Name { get => _name; set { _name = value; OnPropertyChanged(nameof(Name)); } }
        public short Arc { get => _arc; set { _arc = value; OnPropertyChanged(nameof(Arc)); } }
        public int Age { get => _age; set { _age = value; OnPropertyChanged(nameof(Age)); } }
        public int Count { get => _count; set { _count = value;  OnPropertyChanged(nameof(Count)); } }

    }
}
