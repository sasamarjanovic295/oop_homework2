﻿using System;

namespace weatherLibrary
{
    public class DailyForecast
    {
        public Weather DayWeather { get; private set; }
        public DateTime Day { get; private set; }
        public DailyForecast(DateTime day, Weather dayWeather)
        {
            this.Day = day;
            this.DayWeather = dayWeather;
        }
        public string GetAsString()
        {
            return Day.ToString("dd/MM/yyyy HH:mm:ss") + " " + DayWeather.GetAsString();
        }
        public static bool operator >(DailyForecast left, DailyForecast right)
        {
            return (left.DayWeather.GetTemperature() > right.DayWeather.GetTemperature());
        }
        public static bool operator <(DailyForecast left, DailyForecast right)
        {
            return (left.DayWeather.GetTemperature() < right.DayWeather.GetTemperature());
        }
    }
}
