using LibraryMVVM_Application.Model;
using LibraryMVVM_Application.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryMVVM_Application.ViewModel;
using System.Collections.ObjectModel;

namespace LibraryMVVM_Application.ViewModel
{
    class MainVM : PropertyChange
    {
        private User selectedUser;
        private Book selectedBook;

        public ObservableCollection<User> AllUsers { get; set; }
        public ObservableCollection<Book> AllBooks { get; set; }

        public User SelectedUser
        {
            get { return selectedUser; }
            set
            {
                selectedUser = value;
                OnPropertyChanged("SelectedUser");
            }
        }

        public Book SelectedBook
        {
            get { return selectedBook; }
            set
            {
                selectedBook = value;
                OnPropertyChanged("SelectedBook");
            }
        }

        public MainVM()
        {
            AllBooks = new ObservableCollection<Book>
            {
                new Book("Дэниел Киз", "Таинственная история Билли Миллигана", 1, 1981, 1),
                new Book("Михаил Шолохов", "Судьба человека. Рассказы", 2, 1956, 2),
                new Book("Рик Риордан", "Перси Джексон и последнее пророчество", 3, 2009, 5),
                new Book("Эрих Ремарк", "Возлюби ближнего своего", 4, 1941, 6),
                new Book("Артур Хейли", "Аэропорт", 5, 1968, 8),
                new Book("Айн Рэнд", "Источник", 6, 1957, 9),
                new Book("Тихон Архимандрит", "Несвятые святые", 7, 2020, 11),
                new Book("Решад Гюнтекин", "Королек-птичка певчая", 8, 1922, 12),
                new Book("Кир Булычев", "Посёлок", 9, 1984, 14),
                new Book("Федор Достоевский", "Идиот", 10, 1869, 15),
                new Book("Ирвин Шоу", "Богач, бедняк", 11, 1969, 17),
                new Book("Арчибальд Кронин", "Цитадель", 12, 1939, 18),
                new Book("Генрик Сенкевич", "Камо грядеши", 13, 1896, 20),
                new Book("Джон Стейнбек", "К востоку от Эдема",  14, 1952, 21),
                new Book("Стивен Кинг", "Мизери",  15, 1987, 22)
            };

            AllUsers = new ObservableCollection<User>
            {
                new User(0, "Евгений", "Катышков", new ObservableCollection<Book>()
                {
                    new Book("Эрих Ремарк", "Возлюби ближнего своего", 4, 1941, 1),
                    new Book("Артур Хейли", "Аэропорт", 5, 1968, 1),
                    new Book("Айн Рэнд", "Источник", 6, 1957, 1),
                    new Book("Тихон Архимандрит", "Несвятые святые", 7, 2020, 1),
                    new Book("Решад Гюнтекин", "Королек-птичка певчая", 8, 1922, 1),
                }),

                new User(1, "Андрей", "Филатов", new ObservableCollection<Book>()
                {
                    new Book("Стивен Кинг", "Мизери",  15, 1987, 1)
                }),

                new User(2, "Артемий", "Исаев", new ObservableCollection<Book>()),

                new User(3, "Ярослав", "Шилов", new ObservableCollection<Book>()),

                new User(4, "Ева", "Фомичева", new ObservableCollection<Book>()
                {
                    new Book("Ирвин Шоу", "Богач, бедняк", 11, 1969, 1),
                    new Book("Арчибальд Кронин", "Цитадель", 12, 1939, 1),
                    new Book("Генрик Сенкевич", "Камо грядеши", 13, 1896, 1),
                }),

                new User(5, "Кирилл", "Егоров", new ObservableCollection<Book>()),

                new User(6, "Агата", "Беляева", new ObservableCollection<Book>()
                {
                    new Book("Решад Гюнтекин", "Королек-птичка певчая", 8, 1922, 1),
                    new Book("Кир Булычев", "Посёлок", 9, 1984, 1),
                    new Book("Федор Достоевский", "Идиот", 10, 1869, 1),
                }),

                new User(7, "Максим", "Николаев", new ObservableCollection<Book>()
                {
                    new Book("Кир Булычев", "Посёлок", 9, 1984, 1),
                    new Book("Федор Достоевский", "Идиот", 10, 1869, 1),
                    new Book("Ирвин Шоу", "Богач, бедняк", 11, 1969, 1),
                }),

                new User(8, "Дарья", "Жарова", new ObservableCollection<Book>()),

                new User(9, "Евгения", "Макарова", new ObservableCollection<Book>()
                {
                    new Book("Генрик Сенкевич", "Камо грядеши", 13, 1896, 1),
                    new Book("Джон Стейнбек", "К востоку от Эдема",  14, 1952, 1),
                    new Book("Стивен Кинг", "Мизери",  15, 1987, 1)
                }),

                new User(10, "Виталий", "Петров", new ObservableCollection<Book>()),
            };
        }
    }
}
