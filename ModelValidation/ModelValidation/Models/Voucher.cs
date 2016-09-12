using ModelValidation.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ModelValidation.Models
{
	public class Voucher
	{
        [Required]
        [Remote("ValidateName", "Home")]
		public string Name { get; set; }
        [PrefixLogic(6)]
		public string Prefix { get; set; }
		public string Postfix { get; set; }
        [DisplayName("Min Amount")]
		public decimal? MinimalAmount { get; set; }
		public decimal? Percentage { get; set; }
        [DataType(DataType.Date)]
		public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
		public DateTime EndDate { get; set; }
		public bool SingleUse { get; set; }
		public string Title
		{
			get
			{
				return string.Format("Voucher {0}", 
					string.Format("{0} {1} {2}", Prefix, Name, Postfix)
					.Trim().Replace(' ','_'));
			}
		}
	}
}