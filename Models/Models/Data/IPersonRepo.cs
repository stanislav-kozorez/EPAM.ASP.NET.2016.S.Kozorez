﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Models;

namespace Models.Data
{
	public interface IPersonRepo
	{
		Person[] GetAll();
	}
}
