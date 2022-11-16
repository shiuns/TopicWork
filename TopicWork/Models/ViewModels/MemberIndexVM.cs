using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopicWork.Models.ViewModels
{
	public class MemberIndexVM
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string IdentityNumber { get; set; }
		public string PhoneNumber { get; set; }
		public DateTime ContractExpired { get; set; }
		public string PhoneBrand { get; set; }
		public string PhoneModel { get; set; }


	}
	public class MemberVM
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string IdentityNumber { get; set; }
		public string PhoneNumber { get; set; }
		public DateTime ContractExpired { get; set; }
		public string PhoneBrand { get; set; }
		public string PhoneModel { get; set; }
	}
}
