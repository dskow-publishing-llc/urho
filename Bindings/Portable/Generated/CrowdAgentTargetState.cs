// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// CrowdAgentTargetState.cs
// 
// Copyright 2015 Xamarin Inc. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Urho.Urho2D;
using Urho.Gui;
using Urho.Resources;
using Urho.IO;
using Urho.Navigation;
using Urho.Network;

namespace Urho.Navigation
{
	public enum CrowdAgentTargetState
	{
		None = 0,
		Failed,
		Valid,
		Requesting,
		WaitingForQueue,
		WaitingForPath,
		Velocity
	}
}
