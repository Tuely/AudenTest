using System;
using System.Collections.Generic;
using System.Text;

namespace AudenTest.ExtensionMethods
{
  public static  class NumericExtensions
    {
        public static int ToMilliseconds(this int i)
        {
            return i * 1000;
        }
    }
}
