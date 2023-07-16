using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows;
using _1st_page_individual.Model;

namespace _1st_page_individual
{
    public partial class MainWindowVM : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<User> users;
        [ObservableProperty]
        public User selectedUser = null;

        
        public void CloseMainWindow()
        {
            Application.Current.MainWindow.Close();
        }


        [RelayCommand]
        public void messeag()
        {

            MessageBox.Show($"{selectedUser.FirstName} GPA value must be between 0 and 4.", "Error");
        }

        [RelayCommand]
        public void AddStudent()
        {
            var vm = new AddUserVM();
            vm.title = "ADD";
            AddUser window = new AddUser(vm);
            window.ShowDialog();

            if (vm.Student.FirstName != null)
            {
                users.Add(vm.Student);
                MessageBox.Show("Sccessfully added a new student.");
            }
           
        }

        [RelayCommand]
        public void Delete()
        {
            if (selectedUser != null)
            {
                string name = selectedUser.FirstName;
                users.Remove(selectedUser);
                MessageBox.Show($"{name} is Deleted successfuly.", "DELETED \a ");

            }
            else
            {
                MessageBox.Show("Plese Select Student before Delete.", "Error");

            }
        }
        [RelayCommand]
        public void ExecuteEditStudentCommand()
        {
            if (selectedUser != null)
            {
                var vm = new AddUserVM(selectedUser);
                vm.title = "EDIT";
                var window = new AddUser(vm);

                window.ShowDialog();


                int index = users.IndexOf(selectedUser);
                users.RemoveAt(index);
                users.Insert(index, vm.Student);

            }
            else
            {
                MessageBox.Show("Please Select the student", "Warning!");
            }
        }

        public MainWindowVM()
        {
            users = new ObservableCollection<User>();
            BitmapImage image4 = new BitmapImage(new Uri("/Model/Images/4.png", UriKind.Relative));
            users.Add(new User(23, "Umali", "Ratnayaka", "7/4/2000", image4, 2 ));
            BitmapImage image7 = new BitmapImage(new Uri("/Model/Images/2.png", UriKind.Relative));
            users.Add(new User(24, "Kasuni", "Ekanayaka", "12/11/1999", image7,2));
            BitmapImage image1 = new BitmapImage(new Uri("/Model/Images/1.png", UriKind.Relative));
            users.Add(new User(25, "Madura", "Bandara", "15/3/1998", image1, 3));
            BitmapImage image2 = new BitmapImage(new Uri("/Model/Images/2.png", UriKind.Relative));
            users.Add(new User(24, "Suluka", "Punsara", "10/7/1999", image2, 4));

        }
    }
}


