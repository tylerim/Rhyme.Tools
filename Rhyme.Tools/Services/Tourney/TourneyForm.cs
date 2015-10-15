using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Rhyme.Common;
using Rhyme.Common.Utilities;
using Rhyme.Tools.Behavior;
using Rhyme.Tools.Services.LoginTool;

namespace Rhyme.Tools.Services.Tourney
{
	public partial class TourneyForm : Form
	{
		private const int MaxLogCount = 1000;
		private static int _ticketIdSeq = 1000;

		public TourneyForm()
		{
			InitializeComponent();
		}

		private void AddLog(params string[] logs)
		{
			if (InvokeRequired)
			{
				Invoke(new Action(() => AddLog(logs)));
				return;
			}

			foreach (var log in logs)
			{
				lbLog.Items.Add(log);
				if(lbLog.Items.Count > MaxLogCount)
					lbLog.Items.RemoveAt(0);
			}

			lbLog.SetSelected(lbLog.Items.Count - 1, true);
		}


		private void btnDbExecute_Click_1(object sender, EventArgs e)
		{
			try
			{
				DbBehavior.DbConnectionString = txtDbConnectionString.Text;

				var tourneyTemplateId = int.Parse(this.txtTourneyTemplateId.Text);
				var bufferTime = int.Parse(this.txtBufferTime.Text);

				var result = DbBehavior.CreateTourney(tourneyTemplateId, bufferTime);

				AddLog("Result code : ", result.ToString());
			}
			catch (Exception ex)
			{
				AddLog("Exception : ", ex.ToString());
			}
		}

		private void btnViewTourney_Click_1(object sender, EventArgs e)
		{
			try
			{
				DbBehavior.DbConnectionString = txtDbConnectionString.Text;

				var form = new frmViewTourney();
				form.Show();
			}
			catch (Exception ex)
			{
				AddLog("Exception : ", ex.ToString());
			}
		}

		private void btnConnect_Click_1(object sender, EventArgs e)
		{
			try
			{
				DbBehavior.DbConnectionString = txtDbConnectionString.Text;

				var dateTime = DbBehavior.ExecuteSql("Select Getdate() as MSSQLServerDate").Rows[0][0];

				AddLog("Now db server datetime : ", dateTime.ToString());
			}
			catch (Exception ex)
			{
				AddLog("Exception : ", ex.ToString());
			}
		}

		private void btnAutoMake_Click_1(object sender, EventArgs e)
		{
			switch (btnAutoMake.Text)
			{
				case Constants.TournamentAutoMakeButtonTextEnable:
					timerTourneyAutoMake.Interval = int.Parse(txtAutoMakeInterrval.Text) * 1000;
					timerTourneyAutoMake.Start();

					// toggle
					btnAutoMake.Text = Constants.TournamentAutoMakeButtonTextDisable;

					AddLog(string.Format("Start, auto make tournament with {0} seconds internal.", txtAutoMakeInterrval.Text));

					// first time, manual execute
					timerTourneyAutoMake_Tick(this, EventArgs.Empty);

					break;
				case Constants.TournamentAutoMakeButtonTextDisable:
					timerTourneyAutoMake.Stop();

					// toggle
					btnAutoMake.Text = Constants.TournamentAutoMakeButtonTextEnable;

					AddLog("Stop, auto make tournament.");
					break;
			}
		}

		private void timerTourneyAutoMake_Tick(object sender, EventArgs e)
		{
			if (this.InvokeRequired)
			{
				this.Invoke(new Action(() => timerTourneyAutoMake_Tick(this, EventArgs.Empty)));
				return;
			}

			DbBehavior.DbConnectionString = this.txtDbConnectionString.Text;

			var tourneyTemplateId = int.Parse(this.txtTourneyTemplateId.Text);

			// auto increase event number ...
			DbBehavior.ExecuteOnlySql(string.Format(
				"update [rb_crm_dev].[dbo].[TourneyTemplates] " +
				"set  " +
				"		[Name] = y.NewName " +
				"		, [EventNumber] = y.NewEventNumber " +
				"from	[rb_crm_dev].[dbo].[TourneyTemplates] x " +
				"		, ( " +
				"			select	[TourneyTemplateId] " +
				"					, [BrandName] + ' #' + Cast([NewEventNumber] as varchar) + ' ' + Cast(GamePlayerCount as varchar) + 'Max $0 Freeroll' as [NewName] " +
				"					, [NewEventNumber] " +
				"			from	( " +
				"						select [TourneyTemplateId], [BrandName], [GamePlayerCount], [EventNumber] + 1 as [NewEventNumber] " +
				"						from [rb_crm_dev].[dbo].[TourneyTemplates] " +
				"						where [TourneyTemplateId] = {0} " +
				"					) inner_y " +
				"		) y " +
				"where x.[TourneyTemplateId] = y.[TourneyTemplateId] " +
				" "
				, tourneyTemplateId));

			btnDbExecute_Click_1(this, EventArgs.Empty);

			AddLog("Tournament make by automatic timer.");
		}

		private void btnLogClear_Click(object sender, EventArgs e)
		{
			lbLog.Items.Clear();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var accountId = 0;
			if (int.TryParse(textBox1.Text, out accountId) == false)
			{
				AddLog("invalid accountId");
				return;
			}

			var ticketTemplateId = 0;
			if (int.TryParse(textBox2.Text, out ticketTemplateId) == false)
			{
				AddLog("invalid ticketTemplateId");
				return;
			}

			try
			{
				DbBehavior.DbConnectionString = txtDbConnectionString.Text;

				var ticketGuid = GuidHelper.GenerateGuid(GuidHelper.GuidType.TicketId, (int)DateTime.UtcNow.Ticks, ticketTemplateId, Interlocked.Increment(ref _ticketIdSeq));
				var response = DbBehavior.CrmCreateTicket(ticketGuid, ticketTemplateId, accountId);

				if (response.Result == 0)
				{
					AddLog(string.Format("ticketId : {0}, ticketName : {1}, ticketValue : {2}", ticketGuid, response.TicketName, response.TicketValue));
				}
				else
				{
					AddLog(string.Format("create ticket failed : {0}", response.ErrorCode));
				}
			}
			catch (Exception ex)
			{
				AddLog("Exception : ", ex.ToString());
			}
		}

		private void btnViewPlayers_Click(object sender, EventArgs e)
		{
			try
			{
				DbBehavior.DbConnectionString = txtDbConnectionString.Text;

				var form = new frmViewPlayers();
				form.Show();
			}
			catch (Exception ex)
			{
				AddLog("Exception : ", ex.ToString());
			}
		}
	}
}
