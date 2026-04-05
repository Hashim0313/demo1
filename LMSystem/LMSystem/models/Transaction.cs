using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSystem.models
{
    public abstract class Transaction
    {
        public int transactionId;
        public string memberName;
        public DateOnly transactionDate;


        public Transaction(int TransactionID, string MemberName, DateOnly TransactionDate)
        {
            transactionId = TransactionID;
            memberName = MemberName;
            transactionDate = TransactionDate;
        }

        public abstract void CalculateFine();

    }

        public class BorrowTransaction : Transaction
        {
            public int days;
            public decimal fine;


            public BorrowTransaction(int transactionId, string memberName, DateOnly transactionDate, int Days) : base(transactionId, memberName, transactionDate)
            {
                days = Days;
            }

            public override void CalculateFine()
            {
                fine = days * 2;
            }
        }

}
