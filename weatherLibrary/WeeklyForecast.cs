using System;

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
            string weeklyForecast = "";
            foreach (DailyForecast dailyForecast in dailyForecasts)
            {
                 weeklyForecast += dailyForecast.GetAsString() + "\n";
            }
            return weeklyForecast;
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
