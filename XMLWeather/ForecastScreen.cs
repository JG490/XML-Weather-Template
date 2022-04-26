using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            date1.Text = Form1.days[1].date;
            min1.Text = Form1.days[1].tempLow;
            max1.Text = Form1.days[1].tempHigh;

            date2.Text = Form1.days[2].date;
            min2.Text = Form1.days[2].tempLow;
            max2.Text = Form1.days[2].tempHigh;

            date3.Text = Form1.days[3].date;
            min3.Text = Form1.days[3].tempLow;
            max3.Text = Form1.days[3].tempHigh;

            date4.Text = Form1.days[4].date;
            min4.Text = Form1.days[4].tempLow;
            max4.Text = Form1.days[4].tempHigh;

            if (Form1.days[1].condition == "moderate rain")
            {
                conditionOutput1.BackgroundImage = Properties.Resources.Rain3;
            }
            if (Form1.days[2].condition == "moderate rain")
            {
                conditionOutput2.BackgroundImage = Properties.Resources.Rain3;
            }
            if (Form1.days[3].condition == "moderate rain")
            {
                conditionOutput3.BackgroundImage = Properties.Resources.Rain3;
            }
            if (Form1.days[4].condition == "moderate rain")
            {
                conditionOutput4.BackgroundImage = Properties.Resources.Rain3;
            }
            if (Form1.days[1].condition == "snow" || Form1.days[1].condition == "rain and snow")
            {
                conditionOutput1.BackgroundImage = Properties.Resources.snowflake;
            }
            if (Form1.days[2].condition == "snow" || Form1.days[2].condition == "rain and snow")
            {
                conditionOutput2.BackgroundImage = Properties.Resources.snowflake;
            }
            if (Form1.days[3].condition == "snow" || Form1.days[3].condition == "rain and snow")
            {
                conditionOutput3.BackgroundImage = Properties.Resources.snowflake;
            }
            if (Form1.days[4].condition == "snow" || Form1.days[4].condition == "rain and snow")
            {
                conditionOutput4.BackgroundImage = Properties.Resources.snowflake;
            }
            if (Form1.days[1].condition == "sky is clear")
            {
                conditionOutput1.BackgroundImage = Properties.Resources.sun;
            }
            if (Form1.days[2].condition == "sky is clear")
            {
                conditionOutput2.BackgroundImage = Properties.Resources.sun;
            }

            if (Form1.days[3].condition == "sky is clear")
            {
                conditionOutput3.BackgroundImage = Properties.Resources.sun;
            }
            if (Form1.days[4].condition == "sky is clear")
            {
                conditionOutput4.BackgroundImage = Properties.Resources.sun;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
