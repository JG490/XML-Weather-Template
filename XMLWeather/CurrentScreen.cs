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
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            cityOutput.Text = Form1.days[0].location;
            tempLabel.Text = Form1.days[0].currentTemp;
            minOutput.Text = $"{Form1.days[0].tempLow}°C";
            maxOutput.Text = $"{Form1.days[0].tempHigh}°C";
            ConditionOutput.Text = Form1.days[0].condition;
            cloudOutput.Text = Form1.days[0].cloud;

            if (Form1.days[0].condition == "moderate rain")
            {
                mainConditionOutput.BackgroundImage = Properties.Resources.Rain3;
                BackgroundImage = Properties.Resources.overcast;

            }
            if (Form1.days[0].condition == "rain and snow")
            {
                mainConditionOutput.BackgroundImage = Properties.Resources.snowflake;
                BackgroundImage = Properties.Resources.overcast;
            }
            if (Form1.days[0].condition == "sky is clear")
            {
                mainConditionOutput.BackgroundImage = Properties.Resources.sun;
                BackgroundImage = Properties.Resources.weather_app_background;
            }
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void CurrentScreen_Load(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
               Form1.days[0-4].location = cityInput.Text;
            }
            catch
            {
                cityInput.Text = "ERROR";
            }
        }
    }
}
