using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcharts;
using SkiaSharp;
using Xamarin.Forms;
using MicroEntry = Microcharts.Entry; // MicroEntry

namespace ChartsApp
{
	public partial class MainPage : ContentPage
	{

	    List<MicroEntry> entries = new List<MicroEntry>
	    {
	        new MicroEntry(400)
	        {
	            Color = SKColor.Parse("#FF1493"),
	            Label = "Investments",
	            ValueLabel = "400",
	            TextColor = SKColor.Parse("#FF1493")

	        },

	        new MicroEntry(600)
	        {

	            Color = SKColors.BlueViolet,
	            Label = "Shares",
	            ValueLabel = "600",
	            TextColor = SKColors.BlueViolet,


	        },
	        new MicroEntry(600)
	        {

	            Color = SKColors.SkyBlue,
	            Label = "Sales",
	            ValueLabel = "900",
	            TextColor = SKColors.SkyBlue,


	        },

	        new MicroEntry(600)
	        {

	            Color = SKColors.DarkSeaGreen,
	            Label = "Purchases",
	            ValueLabel = "700",
	            TextColor = SKColors.DarkSeaGreen,


	        },
	    };




        public MainPage()
		{
			InitializeComponent();


		    Chart1.Chart = new PieChart()
		    {

		        Entries = entries,

		        LabelTextSize = 35,

		        AnimationDuration = new TimeSpan(0, 0, 0, 5),

		    };

		    Chart2.Chart = new BarChart
		    {

		        Entries = entries,

		        LabelTextSize = 35,
		        PointMode = PointMode.Circle,
                PointSize = 15,
                
		        AnimationDuration = new TimeSpan(0, 0, 0, 5),
                
		    };


            Chart3.Chart = new LineChart
		    {

		        Entries = entries,

		        LabelTextSize = 35,
		        LineSize = 15,
		        LineMode = LineMode.Spline,
		        AnimationDuration = new TimeSpan(0, 0, 0, 5),

		    };

		    Chart4.Chart = new PointChart
		    {

		        Entries = entries,

		        LabelTextSize = 35,

		        AnimationDuration = new TimeSpan(0, 0, 0, 5),
		        PointMode = PointMode.Circle,
		        PointSize = 15,


		    };
        }
	}
}
