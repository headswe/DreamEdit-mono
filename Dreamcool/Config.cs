using System;

namespace DreamEdit
{
	static public class Config
	{
#if MONO
		static public String path_seperator = "//";
#else
		static public Char path_seperator = "\\";
#endif
	}
}

