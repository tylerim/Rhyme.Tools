using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Rhyme.Tools.Behavior
{
	public class WindowBehavior
	{
		private static readonly Lazy<WindowBehavior> _instnace = new Lazy<WindowBehavior>(() => new WindowBehavior());
		public static WindowBehavior Instance { get { return _instnace.Value; } }

		private WindowBehavior()
		{
			SetWindowPositions();
		}

		//public const string JumpGameTableTitlePattern = @"\[(?<NickName>.*)\]\[(?<TableId>.*)\]\[(?<JumpEntryId>.*)\]";

		#region WindowSize

		public static int GAMETABLE_WIDTH = 500;
		public static int GAMETABLE_HEIGHT = 375;

		#endregion

		#region WindowPositions

		private const int WIDTH = 800;
		private const int HEIGHT = 600;
		private const int X_ADJUST = 180;
		public Dictionary<int, Rectangle> WindowPositions = new Dictionary<int, Rectangle>();

		public void SetWindowPositions()
		{
			this.WindowPositions.Add(0, new Rectangle((WIDTH - X_ADJUST) * 0, HEIGHT * 0, WIDTH, HEIGHT));
			this.WindowPositions.Add(1, new Rectangle((WIDTH - X_ADJUST) * 1, HEIGHT * 0, WIDTH, HEIGHT));
			this.WindowPositions.Add(2, new Rectangle((WIDTH - X_ADJUST) * 2, HEIGHT * 0, WIDTH, HEIGHT));
			this.WindowPositions.Add(3, new Rectangle((WIDTH - X_ADJUST) * 0, HEIGHT * 1, WIDTH, HEIGHT));
			this.WindowPositions.Add(4, new Rectangle((WIDTH - X_ADJUST) * 1, HEIGHT * 1, WIDTH, HEIGHT));
			this.WindowPositions.Add(5, new Rectangle((WIDTH - X_ADJUST) * 2, HEIGHT * 1, WIDTH, HEIGHT));

			if (Screen.AllScreens.Count() > 1)
			{
				Rectangle Bounds = Screen.AllScreens[1].Bounds;

				this.WindowPositions.Add(6, new Rectangle((WIDTH - X_ADJUST) * 0 + Bounds.X, HEIGHT * 0, WIDTH, HEIGHT));
				this.WindowPositions.Add(7, new Rectangle((WIDTH - X_ADJUST) * 1 + Bounds.X, HEIGHT * 0, WIDTH, HEIGHT));
				this.WindowPositions.Add(8, new Rectangle((WIDTH - X_ADJUST) * 2 + Bounds.X, HEIGHT * 0, WIDTH, HEIGHT));
				this.WindowPositions.Add(9, new Rectangle((WIDTH - X_ADJUST) * 0 + Bounds.X, HEIGHT * 1, WIDTH, HEIGHT));
				this.WindowPositions.Add(10, new Rectangle((WIDTH - X_ADJUST) * 1 + Bounds.X, HEIGHT * 1, WIDTH, HEIGHT));
				this.WindowPositions.Add(11, new Rectangle((WIDTH - X_ADJUST) * 2 + Bounds.X, HEIGHT * 1, WIDTH, HEIGHT));
			}
		}

		public static Rectangle GetRectangle(int xDelimiter, int yDelimiter)
		{
			return new Rectangle(
				GAMETABLE_WIDTH * xDelimiter,
				GAMETABLE_HEIGHT * yDelimiter,
				GAMETABLE_WIDTH,
				GAMETABLE_HEIGHT);
		}

		#endregion
	}
}
