using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Poe_2
{//start of namespace 
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //creating an instance for the class Array
        ArrayList reply = new ArrayList();
        ArrayList ignore = new ArrayList();
        user_name check_name = new user_name();

        // variables
        string username = string.Empty;
        string pre_question = string.Empty;
        int counting = 0;

        public MainWindow()
        {  
            InitializeComponent();

            new responses(reply, ignore) { };

            //creating an instance for the class voice_greeting 
            //with an object name greet
            voice_greeting greet = new voice_greeting();

            //call the voice method
            greet.greet();  
        }


    }//end of class
}//end of namespace 
