using System;
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

namespace OOP_Exam_Clintano
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Member> members = new List<Member>(); // list for all members
        List<Member> FilteredMembers = new List<Member>(); // list for all filtered members
        public MainWindow()
        {
            InitializeComponent();
        }

        public void CreateMembers() {
            //both creating and adding the members to the list with the dummy information

            members.Add(new JuniorMember() { Name = "Jack Murphy", Fee = 1000, JoinDate = new DateTime(2020, 5, 7), PaymentType = PaymentSchedule.Annual });
            members.Add(new JuniorMember() { Name = "Emily Kelly", Fee = 1000, JoinDate = new DateTime(2021, 1, 10), PaymentType = PaymentSchedule.Biannual });
            members.Add(new JuniorMember() { Name = "Daniel Ryan", Fee = 1000, JoinDate = new DateTime(2020, 11, 30), PaymentType = PaymentSchedule.Monthly });

            members.Add(new Member() { Name = "Ella Doyle", Fee = 1000, JoinDate = new DateTime(2019, 3, 20), PaymentType = PaymentSchedule.Annual });
            members.Add(new Member() { Name = "Fionn Kennedy", Fee = 1000, JoinDate = new DateTime(2018, 8, 15), PaymentType = PaymentSchedule.Biannual });
            members.Add(new Member() { Name = "Louise Moore", Fee = 1000, JoinDate = new DateTime(2017, 2, 10), PaymentType = PaymentSchedule.Monthly });

            members.Add(new SeniorMember() { Name = "Cian Daly", Fee = 1000, JoinDate = new DateTime(2015, 4, 24), PaymentType = PaymentSchedule.Annual });
            members.Add(new SeniorMember() { Name = "Bobby Quinn", Fee = 1000, JoinDate = new DateTime(2014, 12, 1), PaymentType = PaymentSchedule.Biannual });
            members.Add(new SeniorMember() { Name = "Eve Gallagher", Fee = 1000, JoinDate = new DateTime(2013, 6, 1), PaymentType = PaymentSchedule.Monthly });

            //displaying the list in the listbox
            lbxMemberList.ItemsSource = null;
            lbxMemberList.ItemsSource = members;
        }

        private void lbxMemberList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedIndex = lbxMemberList.SelectedIndex;
            tblkMemInfo.Text = members[selectedIndex].ToString();
        }

        public void Filter() {
            if (rbtnRegular.IsChecked == true) { 
                
            }
        }
    }
}
