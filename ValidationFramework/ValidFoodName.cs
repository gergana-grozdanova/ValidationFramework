using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ValidationFramework
{
   sealed public class ValidFoodName:ValidationAttribute
    {
        public override bool IsValid(object value)
        {
          
            string type=  value.GetType().ToString();
            if (type!= "System.String")
            {
                return false;
            }
            if (value.ToString().Contains("."))
            {
                return  false;
            }
            return true;
        }
    }
}
