﻿using System;
using System.ComponentModel.DataAnnotations;
namespace Tasks.Models
{
	public class Category
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		public int DisplayOrder { get; set; }

		public DateTime CreateDateTime { get; set; } = DateTime.Now;

	}
}

