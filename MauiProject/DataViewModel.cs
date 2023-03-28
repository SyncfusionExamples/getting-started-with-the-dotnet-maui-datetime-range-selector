using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiProject
{
    public class DataViewModel
    {
        public List<ChartModel> Data { get; set; }
        public DataViewModel() {
            Data = new List<ChartModel>()
            {
                new ChartModel{ X = new DateTime(2022, 01, 01), Y = 350 },
                new ChartModel{ X = new DateTime(2022, 02, 01), Y = 375 },
                new ChartModel{ X = new DateTime(2022, 03, 01), Y = 500 },
                new ChartModel{ X = new DateTime(2022, 04, 01), Y = 390 },
                new ChartModel{ X = new DateTime(2022, 05, 01), Y = 400 },
                new ChartModel{ X = new DateTime(2022, 06, 01), Y = 440 },
                new ChartModel{ X = new DateTime(2022, 07, 01), Y = 350 },
                new ChartModel{ X = new DateTime(2022, 08, 01), Y = 400 },
                new ChartModel{ X = new DateTime(2022, 09, 01), Y = 365 },
                new ChartModel{ X = new DateTime(2022, 10, 01), Y = 490 },
                new ChartModel{ X = new DateTime(2022, 11, 01), Y = 400 },
                new ChartModel{ X = new DateTime(2022, 12, 01), Y = 520 },
                new ChartModel{ X = new DateTime(2023, 01, 01), Y = 375 },
                new ChartModel{ X = new DateTime(2023, 02, 01), Y = 350 },
                new ChartModel{ X = new DateTime(2023, 03, 01), Y = 398 },  
            };
        }
    }
}
