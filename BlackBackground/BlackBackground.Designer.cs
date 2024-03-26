﻿namespace BlackBack
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent(Rectangle inBounds, int inLocation)
		{
			SuspendLayout();
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Black;
			ClientSize = new Size(1904, 1041);
			Name = "BlackBackground";
			StartPosition = FormStartPosition.Manual;
			Text = "Black Background";
			WindowState = FormWindowState.Maximized;
			FormBorderStyle = FormBorderStyle.None;

			Bounds = inBounds;
			var screens = Screen.AllScreens;
			Location = screens[inLocation].WorkingArea.Location;
			
			ResumeLayout(false);
		}

		#endregion
	}
}
