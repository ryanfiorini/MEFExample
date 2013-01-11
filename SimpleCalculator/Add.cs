﻿using PublicInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    [Export(typeof(IOperation))]
    [ExportMetadata("Symbol", '+')]
    public class Add: IOperation
    {
        public int Operate(int left, int right)
        {
            return left + right;
        }
    }
}
