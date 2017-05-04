using IT_Fest_Hackathon.Controllers;
using IT_Fest_Hackathon.Models;
using System.Collections.Generic;
using System.Text.RegularExpressions;
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

namespace IT_Fest_Hackathon.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();

            var studentController = new StudentController();
            var student = new Student();
            student.id = 1;
            student.name = "Dani Mocanu";

            var math = new Class();
            math.name = "Mathematics";
            math.description = "Many weird looking symbols and letters";

            var history = new Class();
            history.name = "History";
            history.description = "Class about faraons and pyramids";

            student.classes = new List<Class>();
            student.classes.Add(history);
            student.classes.Add(math);

           
        }

       
    }
}
