using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMDProfiler
{

	public delegate void SetupDelegate(string[] bits);

	public class __processSeries
	{
		private string seriesProcess;
		private string[] seriesNames;
		private System.Drawing.Color[] seriesColours;
		private double maxX, maxY;
		private SetupDelegate initFunc;
		private SetupDelegate processFunc;
		
		public __processSeries(string processName, string[] names, System.Drawing.Color[] colours, double maxx, double maxy, SetupDelegate ifunc, SetupDelegate pfunc)
		{
			this.seriesProcess = processName;
			this.seriesNames = names;
			this.seriesColours = colours;
			this.maxX = maxx;
			this.maxY = maxy;
			this.initFunc = ifunc;
			this.processFunc = pfunc;
		}

		public __processSeries(SetupDelegate ifunc)
		{
			this.seriesNames = null;
			this.seriesColours = null;
			this.initFunc = ifunc;
		}

		//------------------------------------------------------------------------------------------------------------------------------

		public string SeriesProcess
		{
			get { return seriesProcess; }
		}

		//------------------------------------------------------------------------------------------------------------------------------

		public string[] SeriesNames
		{
			get { return seriesNames; }
		}

		//------------------------------------------------------------------------------------------------------------------------------

		public System.Drawing.Color[] SeriesColours
		{
			get { return seriesColours; }
		}

		//------------------------------------------------------------------------------------------------------------------------------

		public double MaxX
		{
			get { return maxX; }
		}

		//------------------------------------------------------------------------------------------------------------------------------

		public double MaxY
		{
			get { return maxY; }
		}

		//------------------------------------------------------------------------------------------------------------------------------

		public SetupDelegate InitFunc
		{
			get { return initFunc; }
		}

		//------------------------------------------------------------------------------------------------------------------------------

		public SetupDelegate ProcessFunc
		{
			get { return processFunc; }
		}

	};

}
