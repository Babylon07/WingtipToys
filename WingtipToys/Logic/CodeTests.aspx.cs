using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingtipToys.Models;
using WingtipToys.Logic;
using System.Collections.Specialized;
using System.Collections;
using System.Web.ModelBinding; 

namespace WingtipToys.Logic
{
    public partial class CodeTests : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OrderedDictionary myOD = new OrderedDictionary();

            myOD.Add("01", "First");
            myOD.Add("02", "Second");
            myOD.Add("03", "Third");

            // Loop through collection
            for(int i = 0; i < myOD.Count; i++)
            {
                string valueString = (string)myOD[i] + "<br>";
                Response.Write(valueString);
            }
            
        }
    }
}