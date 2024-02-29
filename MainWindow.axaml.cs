using Avalonia.Controls;
using Avalonia.Interactivity;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Xml.Linq;

namespace BundingPageDiana
{
    public partial class MainWindow : Window
    {
        Person person = new Person();
        //List<Person> people = new List<Person>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowInfo(object sender, RoutedEventArgs e)
        {
            person.info = firstname.Text + " " + lastname.Text;
            if (!EnteredNames.Items.Contains(person.info) && !string.IsNullOrWhiteSpace(firstname.Text) && !string.IsNullOrWhiteSpace(lastname.Text))
            {
                person.info = firstname.Text + " " + lastname.Text;

                EnteredNames.Items.Add(person.info);

                firstname.Clear();
                lastname.Clear();
            }
            else
            {
                firstname.Clear();
                lastname.Clear();
            }
        }

        private void ClearTextBoxes(object sender, RoutedEventArgs e)
        {
            firstname.Clear();
            lastname.Clear();
        }
    }
}