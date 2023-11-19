﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LibraryMVVM_Application.ViewModel
{
    public abstract class ErrorBox
    {
        public static void UserSelectError()
        {
            MessageBox.Show("Вы забыли выбрать пользователя из списка!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        public static void BookSelectError()
        {
            MessageBox.Show("Вы забыли выбрать книгу из списка!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        public static void UserBookSelectError()
        {
            MessageBox.Show("Вы забыли выбрать пользовательскую книгу из списка!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        public static void BookCountError()
        {
            MessageBox.Show("Экземпляры данной книги закончились, выберете другую!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        public static void DataTypeError()
        {
            MessageBox.Show("Введён неверный тип входных данных!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
