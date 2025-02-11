﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Newspaper : LoanItem
    {
        public Newspaper(string title) : base(title) { }

        public override string checkIn()
        {
            if (!this.isOnLoan())
            {
                return "newspapers are not available for loan";
            }

            this.onLoan = false;

            return "newspapers has been checked in";
        }

        public override string checkOut()
        {
            if (this.isOnLoan())
            {
                return "newspapers are currently on loan";
            }

            this.onLoan = true;

            return "newspapers are not available for loan";
        }
    }
}