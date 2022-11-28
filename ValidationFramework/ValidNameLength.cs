using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ValidationFramework
{
    [System.AttributeUsage(System.AttributeTargets.Property)]
                   
    sealed public class ValidNameLength:ValidationAttribute
    {
        public ValidNameLength()
        {

        }

        public override bool IsValid(object value)
        {
            bool result = true;
            if (value.ToString().Length<3)
            {
                result = false;
            }
            return result;
        }
    }
}
