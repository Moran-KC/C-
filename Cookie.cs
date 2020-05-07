using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson5Task
{
    class Cookie
    {
		
		// contain gluten or not

		private Boolean gluten;
		
		public Boolean Gluten
		{
			get { return gluten; }
			set { gluten = value; }
		}

		//amount of flour in the recepie 

		private float flour;

		public float Flour
		{
			get { return flour; }
			set { flour = value; }
		}

		//amount of sugar in the recepie

		private float sugar;

		public float Sugar
		{
			get { return sugar; }
			set { sugar = value; }
		}

		//amount of eggs in the recepie

		private int eggs;

		public int Eggs
		{
			get { return eggs; }
			set { eggs = value; }
		}



	}
}
