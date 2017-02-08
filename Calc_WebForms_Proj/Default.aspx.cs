using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;




public partial class _Default : System.Web.UI.Page
{
    var elem = new Foundation.Reveal(element, options);

    public List<string> Operations = new List<string>
    {
        "+",
        "-",
        "/",
        "*"
    };
    public string operand1 = "";
    public string operand2 = "";
    public string sign = "";
    public string resultString;
    double op1D;
    double op2D;
    public double result = 0;
    public bool doingMath;
    public string prevOp;


    public void add()
    {
        result = op1D + op2D;
    }

    public void sub()
    {
        result = op1D - op2D;
    }
    public void mult()
    {
        result = op1D * op2D;
    }
    public void div()
    {
        result = op1D / op2D;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            operand1 = Request.Form["Op1"];
            operand2 = Request.Form["Op2"];
            sign = Request.Form["sign"];
        }
        bool op1DTry = double.TryParse(operand1, out op1D);
        bool op2DTry = double.TryParse(operand2, out op2D);



        if (op1DTry == true && op2DTry == true)
        {
            doingMath = true;
        }
        else
        {
            doingMath = false;
        }

        
            var choice = sign;
            switch (choice)
            {
                case "+":
                    add();
                    break;
                case "-":
                    sub();
                    break;
                case "*":
                    mult();
                    break;
                case "/":
                    div();
                    break;
                default:
                    break;
            }
        
    }
}