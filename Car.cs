using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson5Task
{
    class Car
    {

		private int carspeed;

		public int Carspeed
		{
			get { return carspeed; }
			set { carspeed = value; }
		}

		public Car(int carspeed)
		{
			this.carspeed = carspeed;
		}
		public int SetspeedAccelerate(int num)
		{
			this.carspeed = carspeed + (1*num);
			return carspeed;
				
		}
		public int Setspeedslowdown(int num)
		{
			this.carspeed = carspeed - (1*num);
			return carspeed;

		}
		public void stop ()
		{
			this.carspeed = 0;

		}

		public string Getdetails()
		{
			return $"the car speed is: {carspeed}";
		}

	}
}
