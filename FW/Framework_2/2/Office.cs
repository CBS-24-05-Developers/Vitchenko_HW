﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
	class Office
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public User User { get; set; }

	}
}
