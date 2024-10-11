using System.IO;

namespace Notes
{
    public partial class Form1 : Form
    {

        string path = "";
        bool needSave = false;

        public Form1()
        {
            InitializeComponent();
            this.Text = string.Format("untitled - {0}", Application.ProductName);
        }

        public Form1(string[] args) : this()
        {
            /*foreach(string s in args)
            {
                txt_note.AppendText(s + Environment.NewLine);
            }*/

            path = args[0];
            FileInfo info = new FileInfo(path);
            this.Text = string.Format("{0} - {1}", info.Name, Application.ProductName);

            using (StreamReader reader = File.OpenText(path))
            {
                txt_note.Text = reader.ReadToEnd();
                needSave = false;
            }

        }

        private void MenuNewFile_Click(object sender, EventArgs e)
        {
            if (needSave)
            {
                DialogResult result = MessageBox.Show("გსურთ ფაილის შენახვა?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    MenuSave.PerformClick();
                else if (result == DialogResult.Cancel)
                    return;
            }

            path = "";
            txt_note.Clear();
            needSave = false;
        }

        private void MenuOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "text files|*.txt|C# files|*.cs|All Files|*.*";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;

                StreamReader reader = File.OpenText(path);
                txt_note.Text = reader.ReadToEnd();
                reader.Close();
                needSave = false;
            }
        }

        private void MenuSave_Click(object sender, EventArgs e)
        {
            if (!needSave)
                return;

            if (string.IsNullOrEmpty(path))
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "txt files|*.txt|C# files|*.cs|All Files|*.*";
                sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    path = sfd.FileName;
                }
                else
                {
                    return;
                }
            }

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.Write(txt_note.Text);
                needSave = false;
            }
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            if (needSave)
            {
                DialogResult result = MessageBox.Show("გსურთ ფაილის შენახვა?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    MenuSave.PerformClick();
                else if (result == DialogResult.Cancel)
                    return;
            }

            Application.Exit();
        }

        private void txt_note_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!needSave)
                return;

            DialogResult result = MessageBox.Show("გსურთ ფაილის შენახვა?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                MenuSave.PerformClick();
            else if (result == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void txt_note_TextChanged(object sender, EventArgs e)
        {
            needSave = true;
        }

        private void MenuSaveAs_Click(object sender, EventArgs e)
        {

        }
    }
}
