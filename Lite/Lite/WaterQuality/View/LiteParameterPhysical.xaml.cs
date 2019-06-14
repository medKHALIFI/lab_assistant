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
    public partial class LiteParameterPhysical : UserControl
    {
        public LiteParameterPhysical()
        {
            InitializeComponent();
            comboBox_parameter.SelectedIndex = 0;
            label_name_param_view.Visibility = Visibility.Collapsed;
            label_unit_param_view.Visibility = Visibility.Collapsed;
            label_goodvalue_param_view.Visibility = Visibility.Collapsed;
            label_badvalue_param_view.Visibility = Visibility.Collapsed;
            button_edit.Visibility = Visibility.Collapsed;
            button_delete.Visibility = Visibility.Collapsed;
            button_save.Visibility = Visibility.Collapsed;
            /////////////
            textBox_name.Visibility = Visibility.Collapsed;
            textBox_unit.Visibility = Visibility.Collapsed;
            textBox_goodvalue.Visibility = Visibility.Collapsed;
            textBox_badvalue.Visibility = Visibility.Collapsed;

            //
            button_save_param.Visibility = Visibility.Collapsed;
            // combo param 
            // add listener to the combobox
            comboBox_parameter.SelectionChanged += OnSelectionChanged;

            comboBox_parameter.SelectedIndex = 0;   



        }
        // test listener 
        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // somthing();

            // MessageBox.Show(" test");
            // MessageBox.Show(DateTime.Now.ToString("first"+"MM/dd/yyyy HH:mm:ss"));
            // progress bar  



            // MessageBox.Show(DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));





            //Do something with the selected item
            button_save_param.Visibility = Visibility.Collapsed;

            /////////////
            textBox_name.Visibility = Visibility.Collapsed;
            textBox_unit.Visibility = Visibility.Collapsed;
            textBox_goodvalue.Visibility = Visibility.Collapsed;
            textBox_badvalue.Visibility = Visibility.Collapsed;


            // todo add here laboratory from database

            label_name_param_view.Visibility = Visibility.Visible;
            label_unit_param_view.Visibility = Visibility.Visible;
            label_goodvalue_param_view.Visibility = Visibility.Visible;
            label_badvalue_param_view.Visibility = Visibility.Visible;
            button_edit.Visibility = Visibility.Visible;
            button_delete.Visibility = Visibility.Visible;

            if (comboBox_parameter.SelectedItem != null)
            {
                switch (comboBox_parameter.SelectedIndex)
                {
                    case 1 :
                        label_name_param_view.Content = "Temperature";
                        label_unit_param_view.Content = "C°";
                        label_goodvalue_param_view.Content = "30°";
                        label_badvalue_param_view.Content = "50°";
                        break;
                    case 2:
                        label_name_param_view.Content = "turbidity";
                        label_unit_param_view.Content = "NTU"; //Nephelometric Turbidity Units
                        label_goodvalue_param_view.Content = "5 NTU";
                        label_badvalue_param_view.Content = "500 NTU";

                        break;
                    case 3:
                        label_name_param_view.Content = "Color";
                        label_unit_param_view.Content = "--"; 
                        label_goodvalue_param_view.Content = "--";
                        label_badvalue_param_view.Content = "--";

                        break;
                    case 4:
                        label_name_param_view.Content = "Conductivity";
                        label_unit_param_view.Content = "S/m"; // Siemens per meter
                        label_goodvalue_param_view.Content = "0.05 S/m";
                        label_badvalue_param_view.Content = "5 S/m"; 

                        break;


                    default:
                        //Console.WriteLine("Default case");
                        label_name_param_view.Content = comboBox_parameter.SelectedIndex;
                        label_unit_param_view.Content = " "; //Nephelometric Turbidity Units
                        label_goodvalue_param_view.Content = " ";
                        label_badvalue_param_view.Content = "  ";
                        break;

                }
            }



        }

        private void button_edit_Click(object sender, RoutedEventArgs e)
        {

            //
            button_edit.Visibility = Visibility.Collapsed;
            button_delete.Visibility = Visibility.Collapsed;


            /////////////
            textBox_name.Visibility = Visibility.Visible;
            textBox_unit.Visibility = Visibility.Visible;
            textBox_goodvalue.Visibility = Visibility.Visible;
            textBox_badvalue.Visibility = Visibility.Visible;

            label_name_param_view.Visibility = Visibility.Collapsed;
            label_unit_param_view.Visibility = Visibility.Collapsed;
            label_goodvalue_param_view.Visibility = Visibility.Collapsed;
            label_badvalue_param_view.Visibility = Visibility.Collapsed;
            button_save.Visibility = Visibility.Visible;

            //////////

            switch (comboBox_parameter.SelectedIndex)
            {
                case 1:
                    textBox_name.Text = "Temperature";
                    textBox_unit.Text = "C°";
                    textBox_goodvalue.Text = "30°";
                    textBox_badvalue.Text = "50°";
                    break;
                case 2:
                    textBox_name.Text = "turbidity";
                    textBox_unit.Text = "NTU"; //Nephelometric Turbidity Units
                    textBox_goodvalue.Text = "5 NTU";
                    textBox_badvalue.Text = "500 NTU";

                    break;
                case 3:
                    textBox_name.Text = "Color";
                    textBox_unit.Text = "--";
                    textBox_goodvalue.Text = "--";
                    textBox_badvalue.Text = "--";

                    break;
                case 4:
                    textBox_name.Text = "Conductivity";
                    textBox_unit.Text = "S/m"; // Siemens per meter
                    textBox_goodvalue.Text = "0.05 S/m";
                    textBox_badvalue.Text = "5 S/m";

                    break;


                default:
                    //Console.WriteLine("Default case");
                    label_name_param_view.Content = comboBox_parameter.SelectedIndex;
                    label_unit_param_view.Content = " "; //Nephelometric Turbidity Units
                    label_goodvalue_param_view.Content = " ";
                    label_badvalue_param_view.Content = "  ";
                    break;

            }

        }

        private void button_save_Click(object sender, RoutedEventArgs e)
        {

            /////////////
            textBox_name.Visibility = Visibility.Collapsed;
            textBox_unit.Visibility = Visibility.Collapsed;
            textBox_goodvalue.Visibility = Visibility.Collapsed;
            textBox_badvalue.Visibility = Visibility.Collapsed;



            label_name_param_view.Visibility = Visibility.Visible;
            label_unit_param_view.Visibility = Visibility.Visible;
            label_goodvalue_param_view.Visibility = Visibility.Visible;
            label_badvalue_param_view.Visibility = Visibility.Visible;
            button_edit.Visibility = Visibility.Visible;
            button_delete.Visibility = Visibility.Visible;
            button_save.Visibility = Visibility.Collapsed;


            //////////

            switch (comboBox_parameter.SelectedIndex)
            {
                case 1:
                    textBox_name.Text = "Temperature";
                    textBox_unit.Text = "C°";
                    textBox_goodvalue.Text = "30°";
                    textBox_badvalue.Text = "50°";
                    break;
                case 2:
                    textBox_name.Text = "turbidity";
                    textBox_unit.Text = "NTU"; //Nephelometric Turbidity Units
                    textBox_goodvalue.Text = "5 NTU";
                    textBox_badvalue.Text = "500 NTU";

                    break;
                case 3:
                    textBox_name.Text = "Color";
                    textBox_unit.Text = "--";
                    textBox_goodvalue.Text = "--";
                    textBox_badvalue.Text = "--";

                    break;
                case 4:
                    textBox_name.Text = "Conductivity";
                    textBox_unit.Text = "S/m"; // Siemens per meter
                    textBox_goodvalue.Text = "0.05 S/m";
                    textBox_badvalue.Text = "5 S/m";

                    break;


                default:
                    //Console.WriteLine("Default case");
                    label_name_param_view.Content = comboBox_parameter.SelectedIndex;
                    label_unit_param_view.Content = " "; //Nephelometric Turbidity Units
                    label_goodvalue_param_view.Content = " ";
                    label_badvalue_param_view.Content = "  ";
                    break;

            }


        }

        private void button_delete_Click(object sender, RoutedEventArgs e)
        {
            comboBox_parameter.Items.RemoveAt(comboBox_parameter.SelectedIndex);
            comboBox_parameter.SelectedIndex = 0;
            //Console.WriteLine("Default case");
            label_name_param_view.Content = " ";
            label_unit_param_view.Content = " "; //Nephelometric Turbidity Units
            label_goodvalue_param_view.Content = " ";
            label_badvalue_param_view.Content = "  ";

        }

        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            /////////////
            textBox_name.Visibility = Visibility.Visible;
            textBox_unit.Visibility = Visibility.Visible;
            textBox_goodvalue.Visibility = Visibility.Visible;
            textBox_badvalue.Visibility = Visibility.Visible;



            label_name_param_view.Visibility = Visibility.Collapsed;
            label_unit_param_view.Visibility = Visibility.Collapsed;
            label_goodvalue_param_view.Visibility = Visibility.Collapsed;
            label_badvalue_param_view.Visibility = Visibility.Collapsed;
            button_edit.Visibility = Visibility.Collapsed;
            button_delete.Visibility = Visibility.Collapsed;
            button_save.Visibility = Visibility.Collapsed;
            button_save_param.Visibility = Visibility.Visible;

            textBox_name.Text = " ";
            textBox_unit.Text = " "; // Siemens per meter
            textBox_goodvalue.Text = " ";
            textBox_badvalue.Text = " ";



           
        }

        private void button_save_param_Click(object sender, RoutedEventArgs e)
        {
            /////////////
            textBox_name.Visibility = Visibility.Collapsed;
            textBox_unit.Visibility = Visibility.Collapsed;
            textBox_goodvalue.Visibility = Visibility.Collapsed;
            textBox_badvalue.Visibility = Visibility.Collapsed;



            label_name_param_view.Visibility = Visibility.Visible;
            label_unit_param_view.Visibility = Visibility.Visible;
            label_goodvalue_param_view.Visibility = Visibility.Visible;
            label_badvalue_param_view.Visibility = Visibility.Visible;
            button_edit.Visibility = Visibility.Visible;
            button_delete.Visibility = Visibility.Visible;
            button_save_param.Visibility = Visibility.Collapsed;


          /*  textBox_name.Text = " ";
            textBox_unit.Text = " "; // Siemens per meter
            textBox_goodvalue.Text = " ";
            textBox_badvalue.Text = " ";*/

            comboBox_parameter.Items.Insert(5, textBox_name.Text);


        }
    }
}
