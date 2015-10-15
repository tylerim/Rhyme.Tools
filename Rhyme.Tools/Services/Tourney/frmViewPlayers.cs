using System;
using System.Windows.Forms;

using Rhyme.Tools.Behavior;

namespace Rhyme.Tools.Services.Tourney
{
	public partial class frmViewPlayers : Form
	{
		public frmViewPlayers()
		{
			InitializeComponent();
		}
	
		private void btnView_Click(object sender, EventArgs e)
		{
			this.dataGridView.DataSource = DbBehavior.ExecuteSql(this.txtSql.Text);
		}
	}
}
