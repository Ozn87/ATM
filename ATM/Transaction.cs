using System;
using System.Collections.Generic;

namespace ATM
{
    public class Transaction
    {
        public int _transactionID { get; set; }
        public char _movementType { get; set; }
        public DateTime _transactionDate { get; set; }
        public double _amount { get; set; }
        public double _oldValance { get; set; }
        public double _newValance { get; set; }
        

        public Transaction(int transId, char moveType, DateTime transDate,double amountTrans, double oldVal, double newVal)
        {
            this._transactionID = transId;
            this._movementType = moveType;
            this._transactionDate = transDate;
            this._amount = amountTrans;
            this._oldValance = oldVal;
            this._newValance = newVal;

        }

    }
}
