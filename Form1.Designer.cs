namespace VideoRenamer
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this._ButtonLoadFiles = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this._ListBoxResult = new System.Windows.Forms.ListBox();
			this._ButtonRenameFiles = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// _ButtonLoadFiles
			// 
			resources.ApplyResources(this._ButtonLoadFiles, "_ButtonLoadFiles");
			this._ButtonLoadFiles.Name = "_ButtonLoadFiles";
			this._ButtonLoadFiles.UseVisualStyleBackColor = true;
			this._ButtonLoadFiles.Click += new System.EventHandler(this.button1_Click);
			// 
			// _ListBoxResult
			// 
			resources.ApplyResources(this._ListBoxResult, "_ListBoxResult");
			this._ListBoxResult.FormattingEnabled = true;
			this._ListBoxResult.Name = "_ListBoxResult";
			// 
			// _ButtonRenameFiles
			// 
			resources.ApplyResources(this._ButtonRenameFiles, "_ButtonRenameFiles");
			this._ButtonRenameFiles.Name = "_ButtonRenameFiles";
			this._ButtonRenameFiles.UseVisualStyleBackColor = true;
			this._ButtonRenameFiles.Click += new System.EventHandler(this._ButtonRenameFiles_Click);
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// Form1
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._ButtonRenameFiles);
			this.Controls.Add(this._ListBoxResult);
			this.Controls.Add(this._ButtonLoadFiles);
			this.Name = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button _ButtonLoadFiles;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ListBox _ListBoxResult;
		private System.Windows.Forms.Button _ButtonRenameFiles;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

