using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam_Clintano
{
    enum PaymentSchedule { 
        Annual,
        Biannual,
        Monthly
    }
    class Member
    {
        #region Properties
        public string Name { get; set; }
        public DateTime JoinDate { get; set; }
        public decimal Fee { get; set; }
        public PaymentSchedule PaymentType { get; set; }

        public DateTime RenewalDate
        {
            get
            {
                return JoinDate.AddYears(1);
            }
        }
        public int DaysToRenewal{
            get { return (RenewalDate - DateTime.Today).Days; }
        }
        #endregion

        #region Constructors
        #endregion

        #region Methods
        public decimal CalculateFees() {
            if (PaymentType == PaymentSchedule.Monthly)
            {
                return Fee / 12; //fee per month, 12 months.
            }
            else if (PaymentType == PaymentSchedule.Biannual)
            {
                return Fee / 2; //I presume it is divided by 2, unless it is unchanged like the annual? - just taking as it is in the example
            }
            else {
                return Fee; //annual doesn't change.
            }
        }

        //tostring override for format as requested
        public override string ToString()
        {
            return $"{Name}";
        }

        public string MemberDetails() {
            return $"Join Date: {JoinDate}\nBasicFee: {Fee:c}\nPayment Schedule: {PaymentType} - {CalculateFees():c2}\nRenewal Date: {RenewalDate}\nDays to renewal: {DaysToRenewal}\nMembership Type: ";
        }
        #endregion



    }
}
