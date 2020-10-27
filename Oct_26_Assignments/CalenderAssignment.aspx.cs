using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalenderWebFormASP
{
    public partial class calenderAssignment : System.Web.UI.Page
    {
        Hashtable HolidayList;
        protected void Page_Load(object sender, EventArgs e)
        {
            HolidayList = GetHoliday();
            Calendar1.Caption = "Calender-Author:Aishwarya Jadhav";
            Calendar1.FirstDayOfWeek = FirstDayOfWeek.Sunday;
            Calendar1.NextPrevFormat = NextPrevFormat.ShortMonth;
            Calendar1.TitleFormat = TitleFormat.Month;
            Calendar1.ShowGridLines = true;
            Calendar1.DayStyle.Height = new Unit(50);
            Calendar1.DayStyle.Width = new Unit(150);
            Calendar1.DayStyle.HorizontalAlign = HorizontalAlign.Center;
            Calendar1.DayStyle.VerticalAlign = VerticalAlign.Middle;
            Calendar1.OtherMonthDayStyle.BackColor = System.Drawing.Color.AliceBlue;
        }

        private Hashtable GetHoliday()
        {
            Hashtable holiday = new Hashtable();
            holiday["1/1/2020"] = "New Year";
            holiday["1/5/2020"] = "Guru Govind Singh Jayanti";
            holiday["1/8/2020"] = "Mahuram";
            holiday["1/26/2020"] = "Republic Day";
            holiday["2/23/2020"] = "Mahashivratri";
            holiday["3/21/2020"] = "Holi";
            holiday["4/3/2020"] = "Ram Navami";
            holiday["4/7/2020"] = "Mahavir Jayanti";
            holiday["4/10/2020"] = "Good Friday";
            holiday["4/14/2020"] = "Ambedkr Jayanti";
            holiday["5/9/2020"] = "Budha Jayanti";
            holiday["8/14/2020"] = "Janmashtmi";
            holiday["8/15/2020"] = "Independence Day";
            holiday["8/19/2020"] = "Parsi New Year";
            holiday["8/23/2020"] = "Vinayak Chturthi";
            holiday["9/5/2020"] = "Teachers day";
            holiday["9/21/2020"] = "Ramazan";
            holiday["9/28/2020"] = "Vijaya Dashmi";
            holiday["10/2/2020"] = "Gandhi Jayanti";
            holiday["14/11/2020"] = "Diwali";
            holiday["12/25/2020"] = "christmas";

            return holiday;
        }

        

        protected void Calendar1_DayRender1(object sender, DayRenderEventArgs e)
        {
            if (HolidayList[e.Day.Date.ToShortDateString()] != null)
            {
                Literal literal = new Literal();
                literal.Text = "<br />";
                e.Cell.Controls.Add(literal);
                Label label = new Label();
                label.Text = (string)HolidayList[e.Day.Date.ToShortDateString()];
                label.Font.Size = new FontUnit(FontSize.Small);
                e.Cell.Controls.Add(label);
            }

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            LabelAction.Text = "Date Changed to:" + Calendar1.SelectedDate.ToShortDateString();


        }

        protected void Calendar1_VisibleMonthChanged(object sender, MonthChangedEventArgs e)
        {
            LabelAction.Text = "Month Changed to:" + e.NewDate.ToShortDateString();


        }
    }
}