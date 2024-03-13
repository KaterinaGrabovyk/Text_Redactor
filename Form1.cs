using System.Drawing.Printing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Lab6_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Clear();
            toolStrip1.Visible = true;
            панельІнструментівToolStripMenuItem.Checked = true;
            toolStrip1.Visible = true;
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "(*.txt)|*.txt|All Files(*.*)|*.* ";
            openFileDialog1.Title = "Відкрити документ";
            openFileDialog1.Multiselect = false;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "(*.txt)|*.txt|All Files(*.*)|*.* ";
            saveFileDialog1.Title = "Зберегти документ";
            saveFileDialog1.FileName = "doc1.txt";
        }
        private string fn = string.Empty;
        private bool docChanged = false;
        //Справка--------------------------------------------------------------
        private void About()
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }
        private void справкаToolStripButton_Click(object sender, EventArgs e)
        {
            About();
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About();
        }
        //----------------------------------------------------------------------
        //Моя довідка-----------------------------------------------------------
        private void MyHelp()
        {
            MyHelp myHelp = new MyHelp();
            myHelp.ShowDialog();
        }
        private void мояДовідкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyHelp();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MyHelp();
        }
        //----------------------------------------------------------------------
        //Новий файл------------------------------------------------------------
        private void New()
        {
            textBox1.Clear();
            fn = string.Empty;
            saveFileDialog1.FileName = "doc1.txt";
        }
        private void новийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New();
        }
        private void создатьToolStripButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Name = "doc1";
        }
        //----------------------------------------------------------------------
        //Відкрити файл---------------------------------------------------------
        private void Open()
        {
            openFileDialog1.FileName = string.Empty;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fn = openFileDialog1.FileName;
                this.Text = fn;
                try
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(fn);
                    textBox1.Text = sr.ReadToEnd();
                    textBox1.SelectionStart = textBox1.TextLength;
                    sr.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Помилка читання файла.\n" + exc.ToString(), "NkEdit",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

        }
        private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }
        private void открытьToolStripButton_Click(object sender, EventArgs e)
        {
            Open();
        }
        //----------------------------------------------------------------------
        //Зберегти файл---------------------------------------------------------
        private int Save()
        {
            int result = 0;
            if (fn == string.Empty)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fn = saveFileDialog1.FileName;
                    this.Text = fn;
                }
                else result = -1;

            }
            if (fn != string.Empty)
            {
                try
                {
                    System.IO.FileInfo fi = new System.IO.FileInfo(fn);
                    System.IO.StreamWriter sw = fi.CreateText();
                    sw.Write(textBox1.Text);
                    sw.Close();
                    result = 0;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString(), "NkEdit",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                }
            }
            return result;

        }
        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            Save();
        }
        //----------------------------------------------------------------------
        //Панель інструментів---------------------------------------------------
        private void панельІнструментівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = !toolStrip1.Visible;
            панельІнструментівToolStripMenuItem.Checked = !панельІнструментівToolStripMenuItem.Checked;
        }
        //----------------------------------------------------------------------
        //Зберегти файл як------------------------------------------------------
        private int SaveAs()
        {
            int result = 0;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fn = saveFileDialog1.FileName;
                this.Text = fn;
            }
            try
            {
                System.IO.FileInfo fi = new System.IO.FileInfo(fn);
                System.IO.StreamWriter sw = fi.CreateText();
                sw.Write(textBox1.Text);
                sw.Close();
                result = 0;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "NkEdit",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            return result;

        }
        private void зберегтиЯкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }
        //----------------------------------------------------------------------
        //Шрифт/колір-----------------------------------------------------------
        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = textBox1.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }

        }
        private void колірToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                textBox1.ForeColor = colorDialog1.Color;

        }

        //----------------------------------------------------------------------
        //Друкування файла------------------------------------------------------
        private StringReader m_myReader;
        private int m_PrintPageNumber;
        private void MenuFilePrint()
        {
            m_PrintPageNumber = 1;

            string strText = this.textBox1.Text;
            m_myReader = new StringReader(strText);

            Margins margins = new Margins(100, 50, 50, 50);
            printDocument1.DefaultPageSettings.Margins = margins;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
            m_myReader.Close();
        }
        private void друкуватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        //----------------------------------------------------------------------

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (docChanged)
            {
                DialogResult dr;
                dr = MessageBox.Show("Зберегти зміни?", "NkEdit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                switch (dr)
                {
                    case DialogResult.Yes:
                        Save();
                        this.Close();
                        break;
                    case DialogResult.No:
                        this.Close();
                        break;
                    case DialogResult.Cancel:
                        break;
                };
            }
            this.Close();

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (docChanged)
            {
                DialogResult dr;
                dr = MessageBox.Show("Зберегти зміни?", "NkEdit",
                                      MessageBoxButtons.YesNoCancel,
                                      MessageBoxIcon.Warning);
                switch (dr)
                {
                    case DialogResult.Yes:
                        if (Save() != 0)
                            e.Cancel = true;
                        break;
                    case DialogResult.No:
                        ;
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                };
            }
        }


        private void параметриСторінкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void печатьToolStripButton_Click(object sender, EventArgs e)
        {
            друкуватиToolStripMenuItem_Click(this, e);
        }
    }
}
