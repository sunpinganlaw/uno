﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uno.UI.DataBinding;

namespace Uno.UI.Tests
{
	// Added manually because for some reason it's not generated
	public class BindableMetadataProvider : IBindableMetadataProvider
	{
		public IBindableType GetBindableTypeByFullName(string fullName)
		{
			throw new NotImplementedException();
		}

		public IBindableType GetBindableTypeByType(Type type)
		{
			throw new NotImplementedException();
		}
	}
}
