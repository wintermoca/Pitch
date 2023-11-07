using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace View
{
    public partial class PitchRaising : System.Web.UI.Page
    {
        protected string[] PitchArray = { "도", "레", "미", "파", "솔", "라", "시" };
        protected int Note;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) Note = (int)ViewState["Note"];
            else Note = 5;
        }
        protected void Page_PrreRender(object sender, EventArgs e)
        {
            ViewState["Note"] = Note;
        }
        protected void btnPitchDown_Click(object sender, EventArgs e)
        {
            Note = (int)ViewState["Note"] - 1;
            if (Note < 0) Note = 6;
            ShowPitch();
        }
        protected void btnPitchUp_Click(object sender, EventArgs e)
        {
            Note = ((int)ViewState["Note"] + 1)%7;
            
            ShowPitch();
        }
        protected void ShowPitch()
        {
            lblPitch.Text = PitchArray[Note];
        }

       
    }
}