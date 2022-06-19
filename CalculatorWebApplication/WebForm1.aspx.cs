using CalculatorWebApplication.CalculationsWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorWebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private CalculationsSoapClient client = new CalculationsSoapClient();

        protected void UpdateCalculationsGridView()
        {
            CalculationsGV.DataSource = client.GetAllPreviousCalculations();
            CalculationsGV.DataBind();
            CalculationsGV.HeaderRow.Cells[0].Text = "Recent Calculations";
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            int result = client.AddNumbers(Convert.ToInt32(FirstNumTxt.Text), Convert.ToInt32(SecondNumTxt.Text));
            ResultLbl.Text = result.ToString();
            UpdateCalculationsGridView();
        }

        protected void SubtractBtn_Click(object sender, EventArgs e)
        {
            int result = client.SubtractNumbers(Convert.ToInt32(FirstNumTxt.Text), Convert.ToInt32(SecondNumTxt.Text));
            ResultLbl.Text = result.ToString();
            UpdateCalculationsGridView();
        }

        protected void MultiplyBtn_Click(object sender, EventArgs e)
        {
            int result = client.MultiplyNumbers(Convert.ToInt32(FirstNumTxt.Text), Convert.ToInt32(SecondNumTxt.Text));
            ResultLbl.Text = result.ToString();
            UpdateCalculationsGridView();
        }

        protected void DivideBtn_Click(object sender, EventArgs e)
        {
            int result = client.DivideNumbers(Convert.ToInt32(FirstNumTxt.Text), Convert.ToInt32(SecondNumTxt.Text));
            ResultLbl.Text = result.ToString();
            UpdateCalculationsGridView();
        }
    }
}