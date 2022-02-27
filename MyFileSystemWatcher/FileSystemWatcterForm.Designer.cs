namespace MyFileSystemWatcher
{
    partial class FileSystemWatcterForm
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
            this.PathSubmit_btn = new System.Windows.Forms.Button();
            this.start_btn = new System.Windows.Forms.Button();
            this.Stop_btn = new System.Windows.Forms.Button();
            this.FolderPath_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ext_ComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ext_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.File_Watcher_View = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file_MenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.start_MenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.stop_MenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.close_MenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_MenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.query_MenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.help_MenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.about_MenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.FSW = new System.IO.FileSystemWatcher();
            this.label4 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.monitor_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.File_Watcher_View)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FSW)).BeginInit();
            this.SuspendLayout();
            // 
            // PathSubmit_btn
            // 
            this.PathSubmit_btn.Location = new System.Drawing.Point(747, 75);
            this.PathSubmit_btn.Name = "PathSubmit_btn";
            this.PathSubmit_btn.Size = new System.Drawing.Size(99, 28);
            this.PathSubmit_btn.TabIndex = 0;
            this.PathSubmit_btn.Text = "Submit";
            this.PathSubmit_btn.UseVisualStyleBackColor = true;
            this.PathSubmit_btn.Click += new System.EventHandler(this.PathSubmit_btn_Click);
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(40, 109);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(75, 23);
            this.start_btn.TabIndex = 1;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // Stop_btn
            // 
            this.Stop_btn.Location = new System.Drawing.Point(40, 138);
            this.Stop_btn.Name = "Stop_btn";
            this.Stop_btn.Size = new System.Drawing.Size(75, 23);
            this.Stop_btn.TabIndex = 1;
            this.Stop_btn.Text = "Stop";
            this.Stop_btn.UseVisualStyleBackColor = true;
            this.Stop_btn.Click += new System.EventHandler(this.Stop_btn_Click);
            // 
            // FolderPath_box
            // 
            this.FolderPath_box.Location = new System.Drawing.Point(40, 83);
            this.FolderPath_box.Name = "FolderPath_box";
            this.FolderPath_box.Size = new System.Drawing.Size(399, 20);
            this.FolderPath_box.TabIndex = 2;
            this.FolderPath_box.Text = "C:\\";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type Folder Path";
            // 
            // ext_ComboBox
            // 
            this.ext_ComboBox.FormattingEnabled = true;
            this.ext_ComboBox.Location = new System.Drawing.Point(494, 82);
            this.ext_ComboBox.Name = "ext_ComboBox";
            this.ext_ComboBox.Size = new System.Drawing.Size(80, 21);
            this.ext_ComboBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Extension (Empty= All Extensions)";
            // 
            // ext_box
            // 
            this.ext_box.Location = new System.Drawing.Point(494, 167);
            this.ext_box.Name = "ext_box";
            this.ext_box.Size = new System.Drawing.Size(97, 20);
            this.ext_box.TabIndex = 6;
            this.ext_box.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "File Watcher View";
            // 
            // File_Watcher_View
            // 
            this.File_Watcher_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.File_Watcher_View.Location = new System.Drawing.Point(12, 258);
            this.File_Watcher_View.Name = "File_Watcher_View";
            this.File_Watcher_View.Size = new System.Drawing.Size(845, 275);
            this.File_Watcher_View.TabIndex = 500;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_MenuStrip,
            this.edit_MenuStrip,
            this.help_MenuStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(869, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // file_MenuStrip
            // 
            this.file_MenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.start_MenuStrip,
            this.stop_MenuStrip,
            this.close_MenuStrip});
            this.file_MenuStrip.Name = "file_MenuStrip";
            this.file_MenuStrip.Size = new System.Drawing.Size(37, 20);
            this.file_MenuStrip.Text = "File";
            // 
            // start_MenuStrip
            // 
            this.start_MenuStrip.Name = "start_MenuStrip";
            this.start_MenuStrip.Size = new System.Drawing.Size(152, 22);
            this.start_MenuStrip.Text = "Start";
            this.start_MenuStrip.Click += new System.EventHandler(this.start_MenuStrip_Click);
            // 
            // stop_MenuStrip
            // 
            this.stop_MenuStrip.Name = "stop_MenuStrip";
            this.stop_MenuStrip.Size = new System.Drawing.Size(152, 22);
            this.stop_MenuStrip.Text = "Stop";
            this.stop_MenuStrip.Click += new System.EventHandler(this.stop_MenuStrip_Click);
            // 
            // close_MenuStrip
            // 
            this.close_MenuStrip.Name = "close_MenuStrip";
            this.close_MenuStrip.Size = new System.Drawing.Size(152, 22);
            this.close_MenuStrip.Text = "Close";
            this.close_MenuStrip.Click += new System.EventHandler(this.close_MenuStrip_Click);
            // 
            // edit_MenuStrip
            // 
            this.edit_MenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.query_MenuStrip});
            this.edit_MenuStrip.Name = "edit_MenuStrip";
            this.edit_MenuStrip.Size = new System.Drawing.Size(39, 20);
            this.edit_MenuStrip.Text = "Edit";
            // 
            // query_MenuStrip
            // 
            this.query_MenuStrip.Name = "query_MenuStrip";
            this.query_MenuStrip.Size = new System.Drawing.Size(157, 22);
            this.query_MenuStrip.Text = "Query Database";
            this.query_MenuStrip.Click += new System.EventHandler(this.query_MenuStrip_Click);
            // 
            // help_MenuStrip
            // 
            this.help_MenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about_MenuStrip});
            this.help_MenuStrip.Name = "help_MenuStrip";
            this.help_MenuStrip.Size = new System.Drawing.Size(44, 20);
            this.help_MenuStrip.Text = "Help";
            // 
            // about_MenuStrip
            // 
            this.about_MenuStrip.Name = "about_MenuStrip";
            this.about_MenuStrip.Size = new System.Drawing.Size(107, 22);
            this.about_MenuStrip.Text = "About";
            this.about_MenuStrip.Click += new System.EventHandler(this.about_MenuStrip_Click);
            // 
            // FSW
            // 
            this.FSW.EnableRaisingEvents = true;
            this.FSW.SynchronizingObject = this;
            this.FSW.Changed += new System.IO.FileSystemEventHandler(this.FSW_Changed);
            this.FSW.Created += new System.IO.FileSystemEventHandler(this.FSW_Created);
            this.FSW.Deleted += new System.IO.FileSystemEventHandler(this.FSW_Deleted);
            this.FSW.Renamed += new System.IO.RenamedEventHandler(this.FSW_Renamed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 13);
            this.label4.TabIndex = 501;
            this.label4.Text = "Add New Extension (eg docx, xlsx)";
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(611, 164);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 502;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // monitor_label
            // 
            this.monitor_label.AutoSize = true;
            this.monitor_label.Location = new System.Drawing.Point(37, 174);
            this.monitor_label.Name = "monitor_label";
            this.monitor_label.Size = new System.Drawing.Size(115, 13);
            this.monitor_label.TabIndex = 503;
            this.monitor_label.Text = "Monitoring Status: OFF";
            // 
            // FileSystemWatcterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 545);
            this.Controls.Add(this.monitor_label);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.File_Watcher_View);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ext_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ext_ComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FolderPath_box);
            this.Controls.Add(this.Stop_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.PathSubmit_btn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FileSystemWatcterForm";
            this.Text = "File System Watcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FileSystemWatcterForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.File_Watcher_View)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FSW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PathSubmit_btn;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button Stop_btn;
        private System.Windows.Forms.TextBox FolderPath_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ext_ComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ext_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView File_Watcher_View;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem start_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem stop_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem close_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem edit_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem query_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem help_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem about_MenuStrip;
        private System.IO.FileSystemWatcher FSW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label monitor_label;
    }
}

