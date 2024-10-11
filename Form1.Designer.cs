namespace Notes
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
        private void InitializeComponent()
        {
            txt_note = new RichTextBox();
            menuStrip1 = new MenuStrip();
            MenuFile = new ToolStripMenuItem();
            MenuNewFile = new ToolStripMenuItem();
            MenuOpenFile = new ToolStripMenuItem();
            MenuSave = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            MenuExit = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblLineNumber = new ToolStripStatusLabel();
            lblColumnNumber = new ToolStripStatusLabel();
            MenuSaveAs = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txt_note
            // 
            txt_note.Dock = DockStyle.Fill;
            txt_note.Location = new Point(0, 28);
            txt_note.Name = "txt_note";
            txt_note.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            txt_note.Size = new Size(826, 387);
            txt_note.TabIndex = 2;
            txt_note.Text = "";
            txt_note.TextChanged += txt_note_TextChanged;
            txt_note.KeyUp += txt_note_KeyUp;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuFile });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(826, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            MenuFile.DropDownItems.AddRange(new ToolStripItem[] { MenuNewFile, MenuOpenFile, MenuSave, MenuSaveAs, toolStripSeparator1, MenuExit });
            MenuFile.Name = "MenuFile";
            MenuFile.Size = new Size(46, 24);
            MenuFile.Text = "File";
            // 
            // MenuNewFile
            // 
            MenuNewFile.Name = "MenuNewFile";
            MenuNewFile.ShortcutKeyDisplayString = "";
            MenuNewFile.ShortcutKeys = Keys.Control | Keys.N;
            MenuNewFile.Size = new Size(233, 26);
            MenuNewFile.Text = "New File";
            MenuNewFile.Click += MenuNewFile_Click;
            // 
            // MenuOpenFile
            // 
            MenuOpenFile.Name = "MenuOpenFile";
            MenuOpenFile.ShortcutKeys = Keys.Control | Keys.O;
            MenuOpenFile.Size = new Size(233, 26);
            MenuOpenFile.Text = "Open File";
            MenuOpenFile.Click += MenuOpenFile_Click;
            // 
            // MenuSave
            // 
            MenuSave.Name = "MenuSave";
            MenuSave.ShortcutKeys = Keys.Control | Keys.S;
            MenuSave.Size = new Size(233, 26);
            MenuSave.Text = "Save";
            MenuSave.Click += MenuSave_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(230, 6);
            // 
            // MenuExit
            // 
            MenuExit.Name = "MenuExit";
            MenuExit.Size = new Size(233, 26);
            MenuExit.Text = "Exit";
            MenuExit.Click += MenuExit_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblLineNumber, lblColumnNumber });
            statusStrip1.Location = new Point(0, 415);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(826, 26);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblLineNumber
            // 
            lblLineNumber.Name = "lblLineNumber";
            lblLineNumber.Size = new Size(39, 20);
            lblLineNumber.Text = "Line:";
            // 
            // lblColumnNumber
            // 
            lblColumnNumber.Name = "lblColumnNumber";
            lblColumnNumber.Size = new Size(34, 20);
            lblColumnNumber.Text = "Col:";
            // 
            // MenuSaveAs
            // 
            MenuSaveAs.Name = "MenuSaveAs";
            MenuSaveAs.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            MenuSaveAs.Size = new Size(233, 26);
            MenuSaveAs.Text = "Save As";
            MenuSaveAs.Click += MenuSaveAs_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 441);
            Controls.Add(txt_note);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Notes";
            FormClosing += Form1_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox txt_note;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuFile;
        private ToolStripMenuItem MenuNewFile;
        private ToolStripMenuItem MenuOpenFile;
        private ToolStripMenuItem MenuSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem MenuExit;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblLineNumber;
        private ToolStripStatusLabel lblColumnNumber;
        private ToolStripMenuItem MenuSaveAs;
    }
}
