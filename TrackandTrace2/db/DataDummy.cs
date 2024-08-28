using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TrackandTrace2.db
{
    public class MonthlyData
    {
        public int Year { get; set; }
        public string Month { get; set; }
        public int Value { get; set; }
    }

    public static class DataDummy
    {
        public static List<MonthlyData> GetDummyData()
        {
            return new List<MonthlyData>
            {
                new MonthlyData { Year = 2023, Month = "January", Value = 10 },
                new MonthlyData { Year = 2023, Month = "February", Value = 20 },
                new MonthlyData { Year = 2023, Month = "March", Value = 30 },
                new MonthlyData { Year = 2023, Month = "April", Value = 40 },
                new MonthlyData { Year = 2023, Month = "May", Value = 50 },
                new MonthlyData { Year = 2023, Month = "June", Value = 60 },
                new MonthlyData { Year = 2023, Month = "July", Value = 125 },
                new MonthlyData { Year = 2023, Month = "August", Value = 80 },
                new MonthlyData { Year = 2023, Month = "September", Value = 90 },
                new MonthlyData { Year = 2023, Month = "October", Value = 45 },
                new MonthlyData { Year = 2023, Month = "November", Value = 110 },
                new MonthlyData { Year = 2023, Month = "December", Value = 120 },
                new MonthlyData { Year = 2024, Month = "January", Value = 15 },
                new MonthlyData { Year = 2024, Month = "February", Value = 25 },
                new MonthlyData { Year = 2024, Month = "March", Value = 125 },
                new MonthlyData { Year = 2024, Month = "April", Value = 45 },
                new MonthlyData { Year = 2024, Month = "May", Value = 55 },
                new MonthlyData { Year = 2024, Month = "June", Value = 65 },
                new MonthlyData { Year = 2024, Month = "July", Value = 75 },
                new MonthlyData { Year = 2024, Month = "August", Value = 85 },
                new MonthlyData { Year = 2024, Month = "September", Value = 95 },
                new MonthlyData { Year = 2024, Month = "October", Value = 105 },
                new MonthlyData { Year = 2024, Month = "November", Value = 55 },
                new MonthlyData { Year = 2024, Month = "December", Value = 125 }
            };
        }

        public static string GetDummyDataAsJson()
        {
            var data = GetDummyData();
            return JsonConvert.SerializeObject(data, Formatting.Indented);
        }

        public static int GetMonthNumber(string monthName)
        {
            return DateTime.ParseExact(monthName, "MMMM", null).Month;
        }
    }
}
