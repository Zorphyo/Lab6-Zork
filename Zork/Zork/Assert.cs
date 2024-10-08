using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;

namespace Zork
{
    public static class Assert
    {
        [Conditional("Debug")]

        public static void IsTrue(bool expression, string message = null)
        {
            if (expression == false)
            {
                throw new Exception(message);
            }
        }
    }
}
