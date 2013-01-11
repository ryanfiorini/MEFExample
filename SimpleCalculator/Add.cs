/*
 * This example was taken from Microsofts msdn site.
 * http://msdn.microsoft.com/en-us/library/dd460648.aspx?cs-save-lang=1&cs-lang=csharp#code-snippet-9
 * 
 */

using PublicInterfaces;
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
