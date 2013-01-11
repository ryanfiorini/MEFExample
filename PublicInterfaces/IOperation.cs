/*
 * This example was taken from Microsofts msdn site.
 * http://msdn.microsoft.com/en-us/library/dd460648.aspx?cs-save-lang=1&cs-lang=csharp#code-snippet-9
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicInterfaces
{
    public interface IOperation
    {
        int Operate(int left, int right);
    }
}
