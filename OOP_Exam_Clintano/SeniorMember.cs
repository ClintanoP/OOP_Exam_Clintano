using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam_Clintano
{
    class SeniorMember:Member
    {
        //variables
        private decimal seniorFee{ get; set; }
        //constructors
        public SeniorMember() {
        }

        public SeniorMember(string name, decimal pFee, DateTime jDate, PaymentSchedule pType ) {
            Name = name;
            Fee = pFee * 0.75m;
            JoinDate = jDate;
            PaymentType = pType;
            seniorFee = Fee;
        }
        //methods
        public override string ToString()
        {
            return $"Join Date: {JoinDate}\nBasicFee: {Fee:c}\nPayment Schedule: {PaymentType} - {CalculateFees()}\nRenewal Date: {RenewalDate}\nDays to renewal: {DaysToRenewal}\nMembership Type: Senior";
        }
    }
}
