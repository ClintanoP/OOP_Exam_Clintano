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
    }
}
