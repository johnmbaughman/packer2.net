namespace Dean.Edwards {
	partial class Packer {
		private System.Windows.Forms.TextBox tbSource;
		private System.Windows.Forms.TextBox tbResult;
		private System.Windows.Forms.Button pack;
		private System.Windows.Forms.ComboBox Encoding;
		private System.Windows.Forms.CheckBox fastDecode;
		private System.Windows.Forms.CheckBox specialChars;
		private System.Windows.Forms.LinkLabel llPaste;
		private System.Windows.Forms.LinkLabel llCopy;
		private System.Windows.Forms.Button bLoad;
		private System.Windows.Forms.Button bSave;
		private System.Windows.Forms.Button bClear;
		private System.Windows.Forms.OpenFileDialog ofdSource;
		private System.Windows.Forms.SaveFileDialog sfdResult;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.tbSource = new System.Windows.Forms.TextBox();
			this.tbResult = new System.Windows.Forms.TextBox();
			this.pack = new System.Windows.Forms.Button();
			this.Encoding = new System.Windows.Forms.ComboBox();
			this.fastDecode = new System.Windows.Forms.CheckBox();
			this.specialChars = new System.Windows.Forms.CheckBox();
			this.llPaste = new System.Windows.Forms.LinkLabel();
			this.llCopy = new System.Windows.Forms.LinkLabel();
			this.bLoad = new System.Windows.Forms.Button();
			this.bSave = new System.Windows.Forms.Button();
			this.bClear = new System.Windows.Forms.Button();
			this.ofdSource = new System.Windows.Forms.OpenFileDialog();
			this.sfdResult = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// tbSource
			// 
			this.tbSource.AcceptsReturn = true;
			this.tbSource.AcceptsTab = true;
			this.tbSource.AllowDrop = true;
			this.tbSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbSource.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbSource.Location = new System.Drawing.Point(8, 24);
			this.tbSource.Multiline = true;
			this.tbSource.Name = "tbSource";
			this.tbSource.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbSource.Size = new System.Drawing.Size(778, 224);
			this.tbSource.TabIndex = 0;
			this.tbSource.Text = "";
			// 
			// tbResult
			// 
			this.tbResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbResult.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbResult.Location = new System.Drawing.Point(8, 272);
			this.tbResult.Multiline = true;
			this.tbResult.Name = "tbResult";
			this.tbResult.ReadOnly = true;
			this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbResult.Size = new System.Drawing.Size(778, 208);
			this.tbResult.TabIndex = 0;
			this.tbResult.Text = "";
			// 
			// pack
			// 
			this.pack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pack.BackColor = System.Drawing.Color.LightSkyBlue;
			this.pack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.pack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pack.Location = new System.Drawing.Point(8, 490);
			this.pack.Name = "pack";
			this.pack.TabIndex = 1;
			this.pack.Text = "&Pack";
			this.pack.Click += new System.EventHandler(this.pack_Click);
			// 
			// Encoding
			// 
			this.Encoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Encoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Encoding.Location = new System.Drawing.Point(666, 490);
			this.Encoding.Name = "Encoding";
			this.Encoding.Size = new System.Drawing.Size(121, 21);
			this.Encoding.TabIndex = 2;
			this.Encoding.SelectedIndexChanged += new System.EventHandler(this.Encoding_SelectedIndexChanged);
			// 
			// fastDecode
			// 
			this.fastDecode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.fastDecode.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.fastDecode.Checked = true;
			this.fastDecode.CheckState = System.Windows.Forms.CheckState.Checked;
			this.fastDecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.fastDecode.Location = new System.Drawing.Point(682, 514);
			this.fastDecode.Name = "fastDecode";
			this.fastDecode.TabIndex = 3;
			this.fastDecode.Text = "Fast Decode:";
			this.fastDecode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// specialChars
			// 
			this.specialChars.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.specialChars.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.specialChars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.specialChars.Location = new System.Drawing.Point(650, 538);
			this.specialChars.Name = "specialChars";
			this.specialChars.Size = new System.Drawing.Size(136, 24);
			this.specialChars.TabIndex = 3;
			this.specialChars.Text = "Special Characters:";
			this.specialChars.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// llPaste
			// 
			this.llPaste.Location = new System.Drawing.Point(8, 8);
			this.llPaste.Name = "llPaste";
			this.llPaste.Size = new System.Drawing.Size(56, 16);
			this.llPaste.TabIndex = 4;
			this.llPaste.TabStop = true;
			this.llPaste.Text = "Paste:";
			this.llPaste.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llPaste_LinkClicked);
			// 
			// llCopy
			// 
			this.llCopy.Location = new System.Drawing.Point(8, 256);
			this.llCopy.Name = "llCopy";
			this.llCopy.Size = new System.Drawing.Size(56, 16);
			this.llCopy.TabIndex = 4;
			this.llCopy.TabStop = true;
			this.llCopy.Text = "Copy:";
			this.llCopy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llCopy_LinkClicked);
			// 
			// bLoad
			// 
			this.bLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.bLoad.BackColor = System.Drawing.Color.LightSkyBlue;
			this.bLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bLoad.Location = new System.Drawing.Point(88, 490);
			this.bLoad.Name = "bLoad";
			this.bLoad.TabIndex = 1;
			this.bLoad.Text = "&Load";
			this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
			// 
			// bSave
			// 
			this.bSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.bSave.BackColor = System.Drawing.Color.LightSkyBlue;
			this.bSave.Enabled = false;
			this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bSave.Location = new System.Drawing.Point(168, 490);
			this.bSave.Name = "bSave";
			this.bSave.TabIndex = 1;
			this.bSave.Text = "&Save";
			this.bSave.Click += new System.EventHandler(this.bSave_Click);
			// 
			// bClear
			// 
			this.bClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.bClear.BackColor = System.Drawing.Color.LightSkyBlue;
			this.bClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bClear.Location = new System.Drawing.Point(248, 490);
			this.bClear.Name = "bClear";
			this.bClear.TabIndex = 1;
			this.bClear.Text = "&Clear";
			this.bClear.Click += new System.EventHandler(this.bClear_Click);
			// 
			// ofdSource
			// 
			this.ofdSource.DefaultExt = "js";
			this.ofdSource.Filter = "ECMAScript Files|*.js|All files|*.*";
			this.ofdSource.Title = "Choose a file";
			// 
			// sfdResult
			// 
			this.sfdResult.DefaultExt = "js";
			this.sfdResult.Filter = "ECMAScript Files|*.js|All files|*.*";
			// 
			// Packer
			// 
			this.AcceptButton = this.pack;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.bClear;
			this.ClientSize = new System.Drawing.Size(794, 568);
			this.Controls.Add(this.llPaste);
			this.Controls.Add(this.fastDecode);
			this.Controls.Add(this.Encoding);
			this.Controls.Add(this.pack);
			this.Controls.Add(this.tbSource);
			this.Controls.Add(this.tbResult);
			this.Controls.Add(this.specialChars);
			this.Controls.Add(this.llCopy);
			this.Controls.Add(this.bLoad);
			this.Controls.Add(this.bSave);
			this.Controls.Add(this.bClear);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Packer";
			this.Text = "Packer";
			this.Load += new System.EventHandler(this.Packer_Load);
			this.ResumeLayout(false);

		}

		#endregion
	}
}