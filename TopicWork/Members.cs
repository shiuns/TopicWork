using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TopicWork.Models.ViewModels;

namespace TopicWork
{
	public partial class Members : Form
	{
		private MemberIndexVM[] Member;
		public Members()
		{
			InitializeComponent();
			DisplayProducts();
		}

		private MemberIndexVM ParseToIndexVM(DataRow row)
		{
			return new MemberIndexVM()
			{
				Id = row.Field<int>("mId"),
				Name = row.Field<string>("Name"),
				IdentityNumber = row.Field<string>("IdentityNumber"),
				PhoneNumber = row.Field<string>("PhoneNumber"),
				ContractExpired = row.Field<DateTime>("ContractExpired"),
				PhoneBrand = row.Field<string>("PhoneBrand"),
				PhoneModel = row.Field<string>("PhoneModel"),
			};
		}

		private void DisplayProducts()
		{
			string sql = @"SELECT * 
						FROM Contract C
						JOIN Member M ON C.member_id = M.mid
						Join Phone P ON C.phone_id =  P.pid
						";

			var dbHelper = new SqlDbHelper("default");
			// 存放在field裡, 稍後在 grid CellClick事件會需要再度用到它
			Member = dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ParseToIndexVM(row))
				.ToArray();
			#region 冗長的版本
			//DataTable data = dbHelper.Select(sql, null);
			//List<ProductIndexVM> vmItems = new List<ProductIndexVM>();
			//foreach (DataRow row in data.Rows)
			//{
			//	ProductIndexVM vm = ParseToIndexVM(row);
			//	vmItems.Add(vm);
			//}
			//this.products = vmItems.ToArray();
			#endregion
			BindData(Member);
		}

		private void BindData(MemberIndexVM[] data)
		{
			dataGridView1.DataSource = data;
		}

		private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
		{

		}
	}
	}
