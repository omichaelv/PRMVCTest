﻿using System;

namespace PRMVCTest.Models
{
	public class NavigationMenu
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public Guid? ParentMenuId { get; set; }

		public string ControllerName { get; set; }

		public string ActionName { get; set; }

		public bool Permitted { get; set; }
	}
}