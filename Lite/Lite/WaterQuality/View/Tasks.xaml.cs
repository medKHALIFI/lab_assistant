using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows;
using System.Windows.Browser;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Lite
{
    
    public partial class Tasks : UserControl
    {
        private Timer _tmr;
        private int _counter;
        public Tasks()
        {
            InitializeComponent();
            // add listener to the combobox
            listBox_task.SelectionChanged += OnSelectionChanged;

            textBox_mission.Visibility = Visibility.Collapsed;
            comboBox_method.Visibility = Visibility.Collapsed;
            comboBox_inspector.Visibility = Visibility.Collapsed;

            button_save.Visibility = Visibility.Collapsed;

            // progress bar  
          //  Indicador.Visibility = Visibility.Collapsed;

        }

        // test listener 
        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // MessageBox.Show(" test");

            //Do something with the selected item

            /////////////
            textBox_mission.Visibility = Visibility.Collapsed;
            comboBox_method.Visibility = Visibility.Collapsed;
            comboBox_inspector.Visibility = Visibility.Collapsed;
            button_save.Visibility = Visibility.Collapsed;

            // todo add here laboratory from database

            label_mission_view.Visibility = Visibility.Visible;
            label_method_view.Visibility = Visibility.Visible;
            label_labassistant_view.Visibility = Visibility.Visible;

            label_mission_view.Content = "mission " + listBox_task.SelectedIndex ;
            label_method_view.Content = "instantly " ;
            label_labassistant_view.Content = "labassistant " + listBox_task.SelectedIndex;
        
    }

        private void button_edit_Click(object sender, RoutedEventArgs e)
        {

            // MessageBox.Show("Do you wish to continue?");
            //listBox_task.RemoveHandler();
            textBox_mission.Visibility = Visibility.Visible;
            comboBox_method.Visibility = Visibility.Visible;
            comboBox_inspector.Visibility = Visibility.Visible;

            label_mission_view.Visibility = Visibility.Collapsed;
            label_method_view.Visibility = Visibility.Collapsed;
            label_labassistant_view.Visibility = Visibility.Collapsed;


            textBox_mission.Text = "mission " + listBox_task.SelectedIndex;
            comboBox_method.SelectedIndex = 0;
            comboBox_inspector.SelectedIndex = listBox_task.SelectedIndex;


            button_save.Visibility = Visibility.Visible;
        }

        private void button_delete_Click(object sender, RoutedEventArgs e)
        {
           
           
            // MessageBox.Show("task deleted sucssefuly");
            // HtmlPage.Window.Alert("Alert from Silverlight screen");
            

            MessageBoxResult isConfirmed = MessageBox.Show("ARE YOU SURE YOU WANT DELETE THIS TASK ?", "delete TASK", MessageBoxButton.OKCancel);

            if (isConfirmed == MessageBoxResult.OK)

            {

                //Perfrom some Action;
               // MessageBox.Show("task deleted sucssefuly");
                listBox_task.Items.Remove(listBox_task.SelectedItem);

                
            }
        }

        private void button_save_Click(object sender, RoutedEventArgs e)
        {

            MessageBoxResult isConfirmed = MessageBox.Show("all the changes will saved ", "save changes", MessageBoxButton.OKCancel);

            if (isConfirmed == MessageBoxResult.OK)

            {

                //Perfrom some Action;
                // MessageBox.Show("task deleted sucssefuly");
                textBox_mission.Visibility = Visibility.Collapsed;
                comboBox_method.Visibility = Visibility.Collapsed;
                comboBox_inspector.Visibility = Visibility.Collapsed;
                button_save.Visibility = Visibility.Collapsed;


                label_mission_view.Visibility = Visibility.Visible;
                label_method_view.Visibility = Visibility.Visible;
                label_labassistant_view.Visibility = Visibility.Visible;

                label_mission_view.Content = "mission " + listBox_task.SelectedIndex;
                label_method_view.Content = "instantly ";
                label_labassistant_view.Content = "labassistant " + listBox_task.SelectedIndex;

            }
            
        }
    }
}
