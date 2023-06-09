﻿using System;
using System.Collections.Generic;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallows.view
{
	internal interface IRender
	{
		public string? VerticalSymbol { get; set; }
		public string? HorizontalSymbol { get; set; }
		public bool IsOver { get; set; }
		public void Draw(int count);
	}
}
