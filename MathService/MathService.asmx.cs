﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MathService
{
    /// <summary>
    /// Summary description for MathService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MathService : System.Web.Services.WebService
    {

        [WebMethod]
        public int Add(int firstNum, int secNum )
        {
            return firstNum + secNum;
        }
        [WebMethod]
        public int Subtract(int bigNum, int smallNum)
        {
            return bigNum - smallNum;
        }
        [WebMethod]
        public int Multiply(int firstNum, int secNum)
        {
            return firstNum * secNum;
        }
        [WebMethod]
        public int Divide(int Numerator, int Denominator)
        {
            return Numerator / Denominator;
        }
    }
}
