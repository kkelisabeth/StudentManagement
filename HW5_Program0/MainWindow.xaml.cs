/*
* Creator:      Kozlova Elizabeth Paula
*
* Title:        Student Management
*
* Description:
*               Student Management program, where you can add a new student 
*               (with their first and last names, dob, class standing, address), 
*               and export and import a list of students. 
*/

using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HW5_Program0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        //Event Handler for clicking on the Add Student button 
        private void AddStudentButton_Click(object sender, RoutedEventArgs e)
        {
            //Creates new checkbox and enters the data (first name, last name and class standing) of the student 
            CheckBox newCheckBox = new CheckBox();  
            newCheckBox.Content = FirstNameText.Text + " " + LastNameText.Text + "(" + ClassStandingComboBox.Text + ")";
            StudentsStackPanel.Children.Add(newCheckBox);
        }

        //Event Handler for clicking on the Import button 
        private void ImportStudentsButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                string filename = openFileDialog.FileName;
                string studentDet = File.ReadAllText(filename);
                List<StudentDetails> students = JsonConvert.DeserializeObject<List<StudentDetails>>(studentDet);

                foreach (var entry in students)
                {
                    CheckBox newCheckBox = new();
                    newCheckBox.Content = $"{entry.FirstName + " " + entry.LastName + " (" + entry.ClassSt + ")"}";
                    newCheckBox.Tag = entry;

                    StudentsStackPanel.Children.Add(newCheckBox);
                }

            }
        }

        //Event Handler for clicking on the Export button 
        private void ExportStudentsButton_Click(object sender, RoutedEventArgs e)
        {
            string studentDet = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                string fileName = saveFileDialog.FileName;

                for (int i = 0; i < StudentsStackPanel.Children.Count; i++)
                {
                    CheckBox studentCheckBox = StudentsStackPanel.Children[i] as CheckBox;

                    if (studentCheckBox.IsChecked == true)
                    {
                        studentDet += studentCheckBox.Content + "\n";

                    }
                }
                File.WriteAllText(fileName, studentDet);
            }
      
        }
       
       
    }
}
