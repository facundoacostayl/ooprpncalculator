using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {

        #region description
        /*LEAPYEARS

        Prior to 1582, the Julian Calendar was in wide use and defined leap years as every year divisible by 4.

        However, it was found in the late 16th century that the calendar year had drifted from the solar year by

        approximately 10 days. The Gregorian Calendar was defined in order to thin out the number of leap years

        and to more closely align the calendar year with the solar year.

        It was adopted in Papal countries on October 15, 1582, skipping 10 days from the Julian Calendar date.

        Protestant countries adopted the Gregorian Calendar after some time.

 

        User Story 1:

 

       As a user, I want to know if a year is a leap year. So that I can plan for an extra day on February 29th

        during those years.

 

        Acceptance Criteria:

 

        -Any year prior 1582 could be considered as NOT leap year.

        -All years divisible by 400 ARE leap years (so, for example, 2000 was indeed a leap year),

        -All years divisible by 100 but not by 400 are NOT leap years (for example, 1700, 1800, and 1900 were NOT leap years, NOR   will 2100 be a leap year),

        -All years divisible by 4 but not by 100 ARE leap years (e.g., 2008, 2012, 2016),

        -All years not divisible by 4 are NOT leap years (e.g. 2017, 2018, 2019).

         

        Example:

        Input: 2000 - Output: Leap

        Input: 1997 - Output: Not Leap

 

        Note: Consider valid input


        --------------------------------------


       Part 2

       User Story 2:

 

        As a user, I want to know the existing leap years given a year's range (from,to). 

        In range, From must be <= than To, if not return Error

      

        Example

        Input: 1999,2018 - Output: 5 (2000, 2004, 2008, 2012, 2016)

        Input: 1997,1998 - Output: 0

              
        Input: 1998,1998 - Output: 0

        Input: 2000,1990 - Output: Error

        Input: 2000 - Output: Error

 

        Note: Consider invalid input

 
        */

        #endregion

        [TestMethod]
        public void rpnCalculator()
        {
            
        }
    }
}
