﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml;
using Gir;
using NUnit.Framework;

namespace Gir.Tests
{
	[TestFixture]
	public class ParserTests : GenerationTestBase
	{
		[Test]
		public void CanLoadGirFiles()
		{
			foreach (var stream in GetAllGIRFiles ()) {
				var serializer = new System.Xml.Serialization.XmlSerializer(typeof(Repository));
				var obj = (Repository)serializer.Deserialize(stream);
			}
		}
	}
}
