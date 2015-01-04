﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityShaderCompiler
{
	public enum ErrorLevel
	{
		Info = 0,
		Warning = 1,
		Error = 2
	}

	public enum Platform
	{
		OpenGL = 0,
		D3D9 = 1,
		Xbox360 = 2,
		PS3 = 3,
		D3D11 = 4,
		GLES = 5,
		GLESDesktop = 6,
		Flash = 7,
		D3D11_9x = 8,
		GLES3 = 9,
		PSP2 = 10,
		PS4 = 11,
	}

	public enum Function
	{
		Vertex = 0,
		Fragment = 1,
	}
}
