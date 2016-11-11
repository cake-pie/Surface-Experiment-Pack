﻿#region license
/*The MIT License (MIT)
IExperimentSection - Interface for SEP experiment handlers

Copyright (c) 2016 DMagic

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/
#endregion

using SEPScience.Unity.Unity;

namespace SEPScience.Unity.Interfaces
{
	public interface IExperimentSection
	{

		string Name { get; }

		string DaysRemaining { get; }

		float Progress { get; }

		float Calibration { get; }

		bool IsRunning { get; }

		bool IsVisible { get; set; }

		bool CanTransmit { get; }

		void ToggleExperiment(bool on);

		void setParent(SEP_ExperimentSection section);

		void Update();
	}
}