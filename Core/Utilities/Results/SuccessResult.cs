using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        //:base =>Result a implement eder
        public SuccessResult(string message) : base(true, message)
        {

        }

        public SuccessResult():base(true)
        {

        }
    }
}
