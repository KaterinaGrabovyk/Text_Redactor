namespace Lab6_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            менюToolStripMenuItem = new ToolStripMenuItem();
            новийToolStripMenuItem = new ToolStripMenuItem();
            відкритиToolStripMenuItem = new ToolStripMenuItem();
            зберегтиToolStripMenuItem = new ToolStripMenuItem();
            зберегтиЯкToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            друкуватиToolStripMenuItem = new ToolStripMenuItem();
            попереднійПереглядToolStripMenuItem = new ToolStripMenuItem();
            параметриСторінкиToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            вихідToolStripMenuItem = new ToolStripMenuItem();
            параметриToolStripMenuItem = new ToolStripMenuItem();
            панельІнструментівToolStripMenuItem = new ToolStripMenuItem();
            шрифтToolStripMenuItem = new ToolStripMenuItem();
            колірToolStripMenuItem = new ToolStripMenuItem();
            допомогаToolStripMenuItem = new ToolStripMenuItem();
            мояДовідкаToolStripMenuItem = new ToolStripMenuItem();
            проПрограмуToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            создатьToolStripButton = new ToolStripButton();
            открытьToolStripButton = new ToolStripButton();
            сохранитьToolStripButton = new ToolStripButton();
            печатьToolStripButton = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            вырезатьToolStripButton = new ToolStripButton();
            копироватьToolStripButton = new ToolStripButton();
            вставитьToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            справкаToolStripButton = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            textBox1 = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            pageSetupDialog1 = new PageSetupDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDialog1 = new PrintDialog();
            printPreviewDialog1 = new PrintPreviewDialog();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { менюToolStripMenuItem, параметриToolStripMenuItem, допомогаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 3, 0, 3);
            menuStrip1.Size = new Size(943, 37);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { новийToolStripMenuItem, відкритиToolStripMenuItem, зберегтиToolStripMenuItem, зберегтиЯкToolStripMenuItem, toolStripMenuItem2, друкуватиToolStripMenuItem, попереднійПереглядToolStripMenuItem, параметриСторінкиToolStripMenuItem, toolStripMenuItem3, вихідToolStripMenuItem });
            менюToolStripMenuItem.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            менюToolStripMenuItem.Size = new Size(78, 31);
            менюToolStripMenuItem.Text = "Файл";
            // 
            // новийToolStripMenuItem
            // 
            новийToolStripMenuItem.Name = "новийToolStripMenuItem";
            новийToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            новийToolStripMenuItem.Size = new Size(410, 32);
            новийToolStripMenuItem.Text = "Новий";
            новийToolStripMenuItem.Click += новийToolStripMenuItem_Click;
            // 
            // відкритиToolStripMenuItem
            // 
            відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            відкритиToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            відкритиToolStripMenuItem.Size = new Size(410, 32);
            відкритиToolStripMenuItem.Text = "Відкрити...";
            відкритиToolStripMenuItem.Click += відкритиToolStripMenuItem_Click;
            // 
            // зберегтиToolStripMenuItem
            // 
            зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            зберегтиToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            зберегтиToolStripMenuItem.Size = new Size(410, 32);
            зберегтиToolStripMenuItem.Text = "Зберегти";
            зберегтиToolStripMenuItem.Click += зберегтиToolStripMenuItem_Click;
            // 
            // зберегтиЯкToolStripMenuItem
            // 
            зберегтиЯкToolStripMenuItem.Name = "зберегтиЯкToolStripMenuItem";
            зберегтиЯкToolStripMenuItem.Size = new Size(410, 32);
            зберегтиЯкToolStripMenuItem.Text = "Зберегти як...";
            зберегтиЯкToolStripMenuItem.Click += зберегтиЯкToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(410, 32);
            toolStripMenuItem2.Text = "------------------------";
            // 
            // друкуватиToolStripMenuItem
            // 
            друкуватиToolStripMenuItem.Name = "друкуватиToolStripMenuItem";
            друкуватиToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            друкуватиToolStripMenuItem.Size = new Size(410, 32);
            друкуватиToolStripMenuItem.Text = "Друкувати...";
            // 
            // попереднійПереглядToolStripMenuItem
            // 
            попереднійПереглядToolStripMenuItem.Name = "попереднійПереглядToolStripMenuItem";
            попереднійПереглядToolStripMenuItem.Size = new Size(410, 32);
            попереднійПереглядToolStripMenuItem.Text = "Попередній перегляд...";
            // 
            // параметриСторінкиToolStripMenuItem
            // 
            параметриСторінкиToolStripMenuItem.Name = "параметриСторінкиToolStripMenuItem";
            параметриСторінкиToolStripMenuItem.Size = new Size(410, 32);
            параметриСторінкиToolStripMenuItem.Text = "Параметри сторінки";
            параметриСторінкиToolStripMenuItem.Click += параметриСторінкиToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(410, 32);
            toolStripMenuItem3.Text = "------------------------";
            // 
            // вихідToolStripMenuItem
            // 
            вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            вихідToolStripMenuItem.Size = new Size(410, 32);
            вихідToolStripMenuItem.Text = "Вихід";
            вихідToolStripMenuItem.Click += вихідToolStripMenuItem_Click;
            // 
            // параметриToolStripMenuItem
            // 
            параметриToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { панельІнструментівToolStripMenuItem, шрифтToolStripMenuItem, колірToolStripMenuItem });
            параметриToolStripMenuItem.Name = "параметриToolStripMenuItem";
            параметриToolStripMenuItem.Size = new Size(143, 31);
            параметриToolStripMenuItem.Text = "Параметри";
            // 
            // панельІнструментівToolStripMenuItem
            // 
            панельІнструментівToolStripMenuItem.Name = "панельІнструментівToolStripMenuItem";
            панельІнструментівToolStripMenuItem.Size = new Size(345, 32);
            панельІнструментівToolStripMenuItem.Text = "Панель інструментів";
            панельІнструментівToolStripMenuItem.Click += панельІнструментівToolStripMenuItem_Click;
            // 
            // шрифтToolStripMenuItem
            // 
            шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            шрифтToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            шрифтToolStripMenuItem.Size = new Size(345, 32);
            шрифтToolStripMenuItem.Text = "Шрифт";
            шрифтToolStripMenuItem.Click += шрифтToolStripMenuItem_Click;
            // 
            // колірToolStripMenuItem
            // 
            колірToolStripMenuItem.Name = "колірToolStripMenuItem";
            колірToolStripMenuItem.Size = new Size(345, 32);
            колірToolStripMenuItem.Text = "Колір";
            колірToolStripMenuItem.Click += колірToolStripMenuItem_Click;
            // 
            // допомогаToolStripMenuItem
            // 
            допомогаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { мояДовідкаToolStripMenuItem, проПрограмуToolStripMenuItem });
            допомогаToolStripMenuItem.Name = "допомогаToolStripMenuItem";
            допомогаToolStripMenuItem.Size = new Size(130, 31);
            допомогаToolStripMenuItem.Text = "Допомога";
            // 
            // мояДовідкаToolStripMenuItem
            // 
            мояДовідкаToolStripMenuItem.Name = "мояДовідкаToolStripMenuItem";
            мояДовідкаToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            мояДовідкаToolStripMenuItem.Size = new Size(331, 32);
            мояДовідкаToolStripMenuItem.Text = "Моя Довідка";
            мояДовідкаToolStripMenuItem.Click += мояДовідкаToolStripMenuItem_Click;
            // 
            // проПрограмуToolStripMenuItem
            // 
            проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            проПрограмуToolStripMenuItem.Size = new Size(331, 32);
            проПрограмуToolStripMenuItem.Text = "Про програму";
            проПрограмуToolStripMenuItem.Click += проПрограмуToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { создатьToolStripButton, открытьToolStripButton, сохранитьToolStripButton, печатьToolStripButton, toolStripSeparator, вырезатьToolStripButton, копироватьToolStripButton, вставитьToolStripButton, toolStripSeparator1, справкаToolStripButton, toolStripButton1 });
            toolStrip1.Location = new Point(0, 37);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(943, 27);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // создатьToolStripButton
            // 
            создатьToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            создатьToolStripButton.Image = (Image)resources.GetObject("создатьToolStripButton.Image");
            создатьToolStripButton.ImageTransparentColor = Color.Magenta;
            создатьToolStripButton.Name = "создатьToolStripButton";
            создатьToolStripButton.Size = new Size(29, 24);
            создатьToolStripButton.Text = "&Создать";
            создатьToolStripButton.Click += создатьToolStripButton_Click;
            // 
            // открытьToolStripButton
            // 
            открытьToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            открытьToolStripButton.Image = (Image)resources.GetObject("открытьToolStripButton.Image");
            открытьToolStripButton.ImageTransparentColor = Color.Magenta;
            открытьToolStripButton.Name = "открытьToolStripButton";
            открытьToolStripButton.Size = new Size(29, 24);
            открытьToolStripButton.Text = "&Открыть";
            открытьToolStripButton.Click += открытьToolStripButton_Click;
            // 
            // сохранитьToolStripButton
            // 
            сохранитьToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            сохранитьToolStripButton.Image = (Image)resources.GetObject("сохранитьToolStripButton.Image");
            сохранитьToolStripButton.ImageTransparentColor = Color.Magenta;
            сохранитьToolStripButton.Name = "сохранитьToolStripButton";
            сохранитьToolStripButton.Size = new Size(29, 24);
            сохранитьToolStripButton.Text = "&Сохранить";
            сохранитьToolStripButton.Click += сохранитьToolStripButton_Click;
            // 
            // печатьToolStripButton
            // 
            печатьToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            печатьToolStripButton.Image = (Image)resources.GetObject("печатьToolStripButton.Image");
            печатьToolStripButton.ImageTransparentColor = Color.Magenta;
            печатьToolStripButton.Name = "печатьToolStripButton";
            печатьToolStripButton.Size = new Size(29, 24);
            печатьToolStripButton.Text = "&Печать";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 27);
            // 
            // вырезатьToolStripButton
            // 
            вырезатьToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            вырезатьToolStripButton.Image = (Image)resources.GetObject("вырезатьToolStripButton.Image");
            вырезатьToolStripButton.ImageTransparentColor = Color.Magenta;
            вырезатьToolStripButton.Name = "вырезатьToolStripButton";
            вырезатьToolStripButton.Size = new Size(29, 24);
            вырезатьToolStripButton.Text = "Вы&резать";
            // 
            // копироватьToolStripButton
            // 
            копироватьToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            копироватьToolStripButton.Image = (Image)resources.GetObject("копироватьToolStripButton.Image");
            копироватьToolStripButton.ImageTransparentColor = Color.Magenta;
            копироватьToolStripButton.Name = "копироватьToolStripButton";
            копироватьToolStripButton.Size = new Size(29, 24);
            копироватьToolStripButton.Text = "&Копировать";
            // 
            // вставитьToolStripButton
            // 
            вставитьToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            вставитьToolStripButton.Image = (Image)resources.GetObject("вставитьToolStripButton.Image");
            вставитьToolStripButton.ImageTransparentColor = Color.Magenta;
            вставитьToolStripButton.Name = "вставитьToolStripButton";
            вставитьToolStripButton.Size = new Size(29, 24);
            вставитьToolStripButton.Text = "&Вставить";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // справкаToolStripButton
            // 
            справкаToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            справкаToolStripButton.Image = (Image)resources.GetObject("справкаToolStripButton.Image");
            справкаToolStripButton.ImageTransparentColor = Color.Magenta;
            справкаToolStripButton.Name = "справкаToolStripButton";
            справкаToolStripButton.Size = new Size(29, 24);
            справкаToolStripButton.Text = "С&правка";
            справкаToolStripButton.Click += справкаToolStripButton_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.key;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 24);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.ToolTipText = "Про програму";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(0, 64);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(943, 544);
            textBox1.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "(*.txt) | *.txt | All Files(*.*) | *.*";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "(*.txt) | *.txt | All Files(*.*) | *.*";
            // 
            // pageSetupDialog1
            // 
            pageSetupDialog1.Document = printDocument1;
            // 
            // printDocument1
            // 
            // 
            // printDialog1
            // 
            printDialog1.Document = printDocument1;
            printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 608);
            Controls.Add(textBox1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Редактор тексту";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem новийToolStripMenuItem;
        private ToolStripMenuItem відкритиToolStripMenuItem;
        private ToolStripMenuItem зберегтиToolStripMenuItem;
        private ToolStripMenuItem зберегтиЯкToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem друкуватиToolStripMenuItem;
        private ToolStripMenuItem попереднійПереглядToolStripMenuItem;
        private ToolStripMenuItem параметриСторінкиToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem параметриToolStripMenuItem;
        private ToolStripMenuItem допомогаToolStripMenuItem;
        private ToolStripMenuItem вихідToolStripMenuItem;
        private ToolStripMenuItem панельІнструментівToolStripMenuItem;
        private ToolStripMenuItem шрифтToolStripMenuItem;
        private ToolStripMenuItem мояДовідкаToolStripMenuItem;
        private ToolStripMenuItem проПрограмуToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton создатьToolStripButton;
        private ToolStripButton открытьToolStripButton;
        private ToolStripButton сохранитьToolStripButton;
        private ToolStripButton печатьToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton вырезатьToolStripButton;
        private ToolStripButton копироватьToolStripButton;
        private ToolStripButton вставитьToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton справкаToolStripButton;
        private TextBox textBox1;
        private ToolStripButton toolStripButton1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private PageSetupDialog pageSetupDialog1;
        private PrintDialog printDialog1;
        private PrintPreviewDialog printPreviewDialog1;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private ToolStripMenuItem колірToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
