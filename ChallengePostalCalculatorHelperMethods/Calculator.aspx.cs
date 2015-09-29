using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostalCalculatorHelperMethods
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void groundShipping_CheckedChanged(object sender, EventArgs e)
        {
            calculateGroundShipping();
        }

        protected void airShipping_CheckedChanged(object sender, EventArgs e)
        {
            calculateAirShipping();
        }

        protected void nextDayShipping_CheckedChanged(object sender, EventArgs e)
        {
            calculateNextDayShipping();
        }

        protected void calculateGroundShipping()
        {
            double width = 0;
            double height = 0;
            double length = 0;

            if (widthTextBox.Text.Trim().Length == 0) return;
            if (heightTextBox.Text.Trim().Length == 0) return;
            if (lengthTextBox.Text.Trim().Length == 0) length = 1;

            if (!Double.TryParse(widthTextBox.Text, out width))
                return;
            if (!Double.TryParse(heightTextBox.Text, out height))
                return;
            if (!Double.TryParse(lengthTextBox.Text, out length))
            {
                if (length == 0)
                {
                    length = 1;
                }
            }
            
            double volume = width * height * length;
            double groundTotal = volume * 0.15;

            resultLabel.Text = String.Format("Your parcel will cost {0:C} to ship.", groundTotal);

        }

        protected void calculateAirShipping()
        {
            double width = 0;
            double height = 0;
            double length = 0;
            
            if (widthTextBox.Text.Trim().Length == 0) return;
            if (heightTextBox.Text.Trim().Length == 0) return;
            if (lengthTextBox.Text.Trim().Length == 0) length = 1;

            if (!Double.TryParse(widthTextBox.Text, out width))
                return;
            if (!Double.TryParse(heightTextBox.Text, out height))
                return;
            if (!Double.TryParse(lengthTextBox.Text, out length))
            {
                if (length == 0)
                {
                    length = 1;
                }
            }
                
            double volume = width * height * length;
            double airTotal = volume * 0.25;

            resultLabel.Text = String.Format("Your parcel will cost {0:C} to ship.", airTotal);

        }

        protected void calculateNextDayShipping()
        {
            double width = 0;
            double height = 0;
            double length = 0;
            
            if (widthTextBox.Text.Trim().Length == 0) return;
            if (heightTextBox.Text.Trim().Length == 0) return;
            if (lengthTextBox.Text.Trim().Length == 0) length = 1;

            if (!Double.TryParse(widthTextBox.Text, out width))
                return;
            if (!Double.TryParse(heightTextBox.Text, out height))
                return;
            if (!Double.TryParse(lengthTextBox.Text, out length))
            {
                if (length == 0)
                {
                    length = 1;
                }
            }

            double volume = width * height * length;
            double nextDayTotal = volume * 0.45;

            resultLabel.Text = String.Format("Your parcel will cost {0:C} to ship.", nextDayTotal);
        }
    }
}