﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam_Clintano
{
    class JuniorMember:Member
    {
        //variables
        private decimal juniorFee { get; set; }
        //constructors
        public JuniorMember()
        {
        }
        public JuniorMember(string name, decimal pFee, DateTime jDate, PaymentSchedule pType)
        {
            Name = name;
            Fee = pFee * 0.5m;
            JoinDate = jDate;
            PaymentType = pType;
            juniorFee = Fee;
        }
    }
}
