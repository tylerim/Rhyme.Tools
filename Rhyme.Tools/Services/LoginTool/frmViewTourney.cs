using System;
using System.Windows.Forms;
using Rhyme.Tools.Behavior;

namespace Rhyme.Tools.Services.LoginTool
{
	public partial class frmViewTourney : Form
	{
		public frmViewTourney()
		{
			InitializeComponent();
		}
	
		private void btnViewTourny_Click(object sender, EventArgs e)
		{
			this.dataGridViewTourney.DataSource = DbBehavior.SelectTourney(this.txtSql.Text);
		}
	}
}
