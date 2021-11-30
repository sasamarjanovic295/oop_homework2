using System;
using System.Text;

namespace weatherLibrary
{
    public class WeeklyForecast
    {
        private DailyForecast[] dailyForecasts;
        public WeeklyForecast(DailyForecast[] dailyForecasts)
        {
            this.dailyForecasts = dailyForecasts;
        }
        public string GetAsString()
        {
            StringBuilder builder  = new StringBuilder();
            foreach (DailyForecast dailyForecast in dailyForecasts)
            {
                builder.Append(dailyForecast.GetAsString()+"\n");
            }
            return builder.ToString();
        }
        public double GetMaxTemperature()
        {
            DailyForecast dailyForcastWithMaxTemperature = dailyForecasts[0];
            foreach (DailyForecast dailyForecast in dailyForecasts)
            {
                if (dailyForcastWithMaxTemperature < dailyForecast)
                {
                    dailyForcastWithMaxTemperature= dailyForecast;
                }
            }
            return dailyForcastWithMaxTemperature.DayWeather.GetTemperature();
        }
        public DailyForecast this[int i]
        {
            get
            {
                return dailyForecasts[i];
            }
        }
       
    }
}
