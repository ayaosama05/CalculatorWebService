using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CalculatorWebService
{
    /// <summary>
    /// Summary description for Calculations
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Calculations : System.Web.Services.WebService
    {
        public List<string> ListOfCalculations = new List<string>();

        [WebMethod(EnableSession = true, CacheDuration = 20)]
        public void AddToListOfCalculations(string valueToAdd){
            if (Session["Calculations"] != null)
            {
                ListOfCalculations = (List<string>)Session["Calculations"];
            }
            ListOfCalculations.Add(valueToAdd);
            Session["Calculations"] = ListOfCalculations;
        }

        [WebMethod(EnableSession = true,CacheDuration = 20)]
        public int AddNumbers(int FirstNum, int SecondNum)
        {
            int Result = FirstNum + SecondNum;
            string operation = FirstNum.ToString() + " + " + SecondNum.ToString() + " = " + Result.ToString();
            AddToListOfCalculations(operation);
            return Result;
        }
        [WebMethod(EnableSession = true, CacheDuration = 20)]
        public int SubtractNumbers(int FirstNum, int SecondNum)
        {
            int Result = FirstNum - SecondNum;
            string operation = FirstNum.ToString() + " - " + SecondNum.ToString() + " = " + Result.ToString();
            AddToListOfCalculations(operation);
            return Result;
        }
        [WebMethod(EnableSession = true, CacheDuration = 20)]
        public int MultiplyNumbers(int FirstNum, int SecondNum)
        {
            int Result = FirstNum * SecondNum;
            string operation = FirstNum.ToString() + " * " + SecondNum.ToString() + " = " + Result.ToString();
            AddToListOfCalculations(operation);
            return Result;
        }
        [WebMethod(EnableSession = true, CacheDuration = 20)]
        public int DivideNumbers(int FirstNum, int SecondNum)
        {
            int Result = 0;
            if (SecondNum != 0)
            {
                Result = FirstNum / SecondNum;
                string operation = FirstNum.ToString() + " / " + SecondNum.ToString() + " = " + Result.ToString();
                AddToListOfCalculations(operation);
            }
            return Result;
        }
        [WebMethod(EnableSession =true,Description ="This method gets all previous calculation you've did")]
        public List<string> GetAllPreviousCalculations()
        {
            if(Session["Calculations"] == null)
            {
                ListOfCalculations.Add("You didn't perform any calculations yet");
                return ListOfCalculations;
            }

            return (List<string>)Session["Calculations"];
        }
    }
}
