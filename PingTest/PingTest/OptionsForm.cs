﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PingTracer
{
	public partial class OptionsForm : Form
	{
		private MainForm mainForm;

		public OptionsForm()
		{
			InitializeComponent();
		}

		public OptionsForm(MainForm mainForm)
		{
			this.mainForm = mainForm;
			InitializeComponent();
			cbLogToFile.Checked = mainForm.settings.logTextOutputToFile;
		}

		private void cbLogToFile_CheckedChanged(object sender, EventArgs e)
		{
			mainForm.settings.logTextOutputToFile = cbLogToFile.Checked;
			mainForm.settings.Save();
		}
	}
}