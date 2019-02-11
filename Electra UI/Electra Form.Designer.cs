namespace Electra_UI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ScriptBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.LuaScriptList = new System.Windows.Forms.ListBox();
            this.RunScript = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.Button();
            this.Inject = new System.Windows.Forms.Button();
            this.ColorSelect = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Settings = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.OpacityBar = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 41);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Minimize
            // 
            this.Minimize.AutoSize = true;
            this.Minimize.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.DimGray;
            this.Minimize.Location = new System.Drawing.Point(619, -1);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(18, 18);
            this.Minimize.TabIndex = 2;
            this.Minimize.Text = "_";
            this.Minimize.Click += new System.EventHandler(this.label4_Click);
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.Red;
            this.Close.Location = new System.Drawing.Point(639, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(19, 18);
            this.Close.TabIndex = 1;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "_";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Electra";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ScriptBox
            // 
            this.ScriptBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.ScriptBox.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.ScriptBox.BackBrush = null;
            this.ScriptBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ScriptBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScriptBox.CharHeight = 14;
            this.ScriptBox.CharWidth = 8;
            this.ScriptBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ScriptBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ScriptBox.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.ScriptBox.ForeColor = System.Drawing.Color.White;
            this.ScriptBox.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ScriptBox.IsReplaceMode = false;
            this.ScriptBox.LineNumberColor = System.Drawing.Color.White;
            this.ScriptBox.Location = new System.Drawing.Point(8, 3);
            this.ScriptBox.Name = "ScriptBox";
            this.ScriptBox.Paddings = new System.Windows.Forms.Padding(0);
            this.ScriptBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ScriptBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("ScriptBox.ServiceColors")));
            this.ScriptBox.Size = new System.Drawing.Size(527, 226);
            this.ScriptBox.TabIndex = 1;
            this.ScriptBox.Zoom = 100;
            // 
            // LuaScriptList
            // 
            this.LuaScriptList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LuaScriptList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LuaScriptList.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LuaScriptList.ForeColor = System.Drawing.Color.White;
            this.LuaScriptList.FormattingEnabled = true;
            this.LuaScriptList.ItemHeight = 16;
            this.LuaScriptList.Location = new System.Drawing.Point(541, 3);
            this.LuaScriptList.Name = "LuaScriptList";
            this.LuaScriptList.Size = new System.Drawing.Size(106, 226);
            this.LuaScriptList.TabIndex = 2;
            this.LuaScriptList.SelectedIndexChanged += new System.EventHandler(this.LuaScriptList_SelectedIndexChanged);
            // 
            // RunScript
            // 
            this.RunScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RunScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RunScript.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunScript.Location = new System.Drawing.Point(8, 235);
            this.RunScript.Name = "RunScript";
            this.RunScript.Size = new System.Drawing.Size(106, 30);
            this.RunScript.TabIndex = 3;
            this.RunScript.Text = "Run Script";
            this.RunScript.UseVisualStyleBackColor = false;
            this.RunScript.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(120, 235);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(89, 30);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.button2_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.OpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFile.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFile.Location = new System.Drawing.Point(215, 235);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(91, 30);
            this.OpenFile.TabIndex = 5;
            this.OpenFile.Text = "Open File";
            this.OpenFile.UseVisualStyleBackColor = false;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // Inject
            // 
            this.Inject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Inject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inject.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inject.Location = new System.Drawing.Point(560, 235);
            this.Inject.Name = "Inject";
            this.Inject.Size = new System.Drawing.Size(85, 30);
            this.Inject.TabIndex = 6;
            this.Inject.Text = "Attatch";
            this.Inject.UseVisualStyleBackColor = false;
            this.Inject.Click += new System.EventHandler(this.button4_Click);
            // 
            // ColorSelect
            // 
            this.ColorSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ColorSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorSelect.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorSelect.Location = new System.Drawing.Point(461, 235);
            this.ColorSelect.Name = "ColorSelect";
            this.ColorSelect.Size = new System.Drawing.Size(93, 30);
            this.ColorSelect.TabIndex = 7;
            this.ColorSelect.Text = "Color Select";
            this.ColorSelect.UseVisualStyleBackColor = false;
            this.ColorSelect.Click += new System.EventHandler(this.ColorSelect_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-4, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(666, 297);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabPage1.Controls.Add(this.Settings);
            this.tabPage1.Controls.Add(this.ScriptBox);
            this.tabPage1.Controls.Add(this.LuaScriptList);
            this.tabPage1.Controls.Add(this.ColorSelect);
            this.tabPage1.Controls.Add(this.RunScript);
            this.tabPage1.Controls.Add(this.Inject);
            this.tabPage1.Controls.Add(this.Clear);
            this.tabPage1.Controls.Add(this.OpenFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(658, 271);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.Location = new System.Drawing.Point(362, 235);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(93, 30);
            this.Settings.TabIndex = 8;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.OpacityBar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(658, 271);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(12, 196);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(633, 34);
            this.button5.TabIndex = 45;
            this.button5.Text = "Back To Executor";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(14, 51);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(79, 21);
            this.checkBox1.TabIndex = 44;
            this.checkBox1.Text = "TopMost";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 156);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(633, 34);
            this.button4.TabIndex = 43;
            this.button4.Text = "Reinstall Roblox";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 116);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(633, 34);
            this.button3.TabIndex = 42;
            this.button3.Text = "Kill Roblox";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(633, 34);
            this.button2.TabIndex = 41;
            this.button2.Text = "Credits";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 27);
            this.label3.TabIndex = 40;
            this.label3.Text = "OpacityBar";
            // 
            // OpacityBar
            // 
            this.OpacityBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.OpacityBar.LargeChange = 1;
            this.OpacityBar.Location = new System.Drawing.Point(134, 12);
            this.OpacityBar.Maximum = 100;
            this.OpacityBar.Minimum = 1;
            this.OpacityBar.Name = "OpacityBar";
            this.OpacityBar.Size = new System.Drawing.Size(511, 45);
            this.OpacityBar.TabIndex = 39;
            this.OpacityBar.TickFrequency = 100;
            this.OpacityBar.Value = 100;
            this.OpacityBar.Scroll += new System.EventHandler(this.OpacityBar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(657, 311);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "v";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FastColoredTextBoxNS.FastColoredTextBox ScriptBox;
        private System.Windows.Forms.ListBox LuaScriptList;
        private System.Windows.Forms.Button RunScript;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button Inject;
        private System.Windows.Forms.Button ColorSelect;
        private System.Windows.Forms.Label Minimize;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar OpacityBar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button5;
    }
}

