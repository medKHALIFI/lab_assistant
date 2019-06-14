using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Lite
{
    public partial class LiteCreateTask : UserControl
    {
        public LiteCreateTask()
        {
            InitializeComponent();

           // label_laboratory.Visibility = Visibility.Collapsed ;
            label_laboratory_view.Visibility = Visibility.Collapsed;

          //  label_labassistant.Visibility = Visibility.Collapsed;
            label_labassistant_view.Visibility = Visibility.Collapsed;

          //  label_param_type.Visibility = Visibility.Collapsed;
            label_param_type_view.Visibility = Visibility.Collapsed;

            // add listener to the combobox
            comboBox_mission.SelectionChanged += OnSelectionChanged;


            // button degetalisation
            

        }

        // test listener 
        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox_mission.SelectedItem != null)
            {

               // index for the selected item comboBox_mission.SelectedIndex;

                //Do something with the selected item
                label_laboratory.Visibility = Visibility.Visible;

                label_laboratory_view.Visibility = Visibility.Visible;
                // todo add here laboratory from database
                label_laboratory_view.Content = "laboratory "+ comboBox_mission.SelectedIndex ;

                label_labassistant.Visibility = Visibility.Visible;
              
                label_labassistant_view.Visibility = Visibility.Visible;
                // todo add here laboratory from database
                label_labassistant_view.Content = "lab assitant " + comboBox_mission.SelectedIndex;

                label_param_type.Visibility = Visibility.Visible;

                label_param_type_view.Visibility = Visibility.Visible;
                // todo add here laboratory from database
                if (comboBox_mission.SelectedIndex == 0 ) { 
                    label_param_type_view.Content = "chimical";
                }else if (comboBox_mission.SelectedIndex == 1)
                {
                    label_param_type_view.Content = "biological";
                }
                else{
                    label_param_type_view.Content = "physical";
                }

                // Instantiate random number generator using system-supplied value as seed.
                Random rand = new Random();
                // Generate and display 5 random byte (integer) values.
                byte[] bytes = new byte[5];
                rand.NextBytes(bytes);



                label_id_task_view.Visibility = Visibility.Visible;
                // todo add here laboratory from database
                label_id_task_view.Content =rand.Next()  ;


            }
        }




        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" mission created successfully");

            // label_laboratory.Visibility = Visibility.Collapsed ;
            label_laboratory_view.Content = "...";

            //  label_labassistant.Visibility = Visibility.Collapsed;
            label_labassistant_view.Content = "...";

            //  label_param_type.Visibility = Visibility.Collapsed;
            label_param_type_view.Content = "...";


            // change combobox
            comboBox_mission.SelectedItem = null;
            comboBox_inspector.SelectedItem = null;
            comboBox_method.SelectedItem = null;
            textBox_note.Text = " ";
        }
    }
}
