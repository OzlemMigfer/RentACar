using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        public SuccessResult(string message) : base(true,message)//sonuç+mesaj
        {

        }

        public SuccessResult() : base(true)//sadece sonuç
        {

        }
    }
}
