namespace View
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonNextFrame = new System.Windows.Forms.Button();
            this.buttonPrevFrame = new System.Windows.Forms.Button();
            this.buttonToggleGIF = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxOffsetView = new System.Windows.Forms.CheckBox();
            this.checkBoxDoubleView = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSeekNav = new System.Windows.Forms.Button();
            this.buttonNextNav = new System.Windows.Forms.Button();
            this.buttonPrevNav = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRenameFile = new System.Windows.Forms.Button();
            this.buttonDeleteFile = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1004, 564);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 33);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(998, 528);
            this.splitContainer1.SplitterDistance = 331;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::View.Properties.Resources.approximations;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(663, 528);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.buttonNextFrame);
            this.panel1.Controls.Add(this.buttonPrevFrame);
            this.panel1.Controls.Add(this.buttonToggleGIF);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.checkBoxOffsetView);
            this.panel1.Controls.Add(this.checkBoxDoubleView);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonSeekNav);
            this.panel1.Controls.Add(this.buttonNextNav);
            this.panel1.Controls.Add(this.buttonPrevNav);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonRenameFile);
            this.panel1.Controls.Add(this.buttonDeleteFile);
            this.panel1.Controls.Add(this.buttonOpenFile);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 24);
            this.panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(763, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 23);
            this.textBox1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(715, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Search";
            // 
            // buttonNextFrame
            // 
            this.buttonNextFrame.Location = new System.Drawing.Point(668, 2);
            this.buttonNextFrame.Name = "buttonNextFrame";
            this.buttonNextFrame.Size = new System.Drawing.Size(41, 23);
            this.buttonNextFrame.TabIndex = 14;
            this.buttonNextFrame.Text = "Next";
            this.buttonNextFrame.UseVisualStyleBackColor = true;
            // 
            // buttonPrevFrame
            // 
            this.buttonPrevFrame.Location = new System.Drawing.Point(623, 2);
            this.buttonPrevFrame.Name = "buttonPrevFrame";
            this.buttonPrevFrame.Size = new System.Drawing.Size(39, 23);
            this.buttonPrevFrame.TabIndex = 13;
            this.buttonPrevFrame.Text = "Prev";
            this.buttonPrevFrame.UseVisualStyleBackColor = true;
            // 
            // buttonToggleGIF
            // 
            this.buttonToggleGIF.Location = new System.Drawing.Point(588, 2);
            this.buttonToggleGIF.Name = "buttonToggleGIF";
            this.buttonToggleGIF.Size = new System.Drawing.Size(29, 23);
            this.buttonToggleGIF.TabIndex = 12;
            this.buttonToggleGIF.Text = "P";
            this.buttonToggleGIF.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(558, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "GIF";
            // 
            // checkBoxOffsetView
            // 
            this.checkBoxOffsetView.AutoSize = true;
            this.checkBoxOffsetView.Location = new System.Drawing.Point(494, 5);
            this.checkBoxOffsetView.Name = "checkBoxOffsetView";
            this.checkBoxOffsetView.Size = new System.Drawing.Size(58, 19);
            this.checkBoxOffsetView.TabIndex = 10;
            this.checkBoxOffsetView.Text = "Offset";
            this.checkBoxOffsetView.UseVisualStyleBackColor = true;
            // 
            // checkBoxDoubleView
            // 
            this.checkBoxDoubleView.AutoSize = true;
            this.checkBoxDoubleView.Location = new System.Drawing.Point(424, 5);
            this.checkBoxDoubleView.Name = "checkBoxDoubleView";
            this.checkBoxDoubleView.Size = new System.Drawing.Size(64, 19);
            this.checkBoxDoubleView.TabIndex = 9;
            this.checkBoxDoubleView.Text = "Double";
            this.checkBoxDoubleView.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "View";
            // 
            // buttonSeekNav
            // 
            this.buttonSeekNav.Location = new System.Drawing.Point(340, 2);
            this.buttonSeekNav.Name = "buttonSeekNav";
            this.buttonSeekNav.Size = new System.Drawing.Size(40, 23);
            this.buttonSeekNav.TabIndex = 7;
            this.buttonSeekNav.Text = "Seek";
            this.buttonSeekNav.UseVisualStyleBackColor = true;
            // 
            // buttonNextNav
            // 
            this.buttonNextNav.Location = new System.Drawing.Point(294, 2);
            this.buttonNextNav.Name = "buttonNextNav";
            this.buttonNextNav.Size = new System.Drawing.Size(40, 23);
            this.buttonNextNav.TabIndex = 6;
            this.buttonNextNav.Text = "Next";
            this.buttonNextNav.UseVisualStyleBackColor = true;
            // 
            // buttonPrevNav
            // 
            this.buttonPrevNav.Location = new System.Drawing.Point(250, 2);
            this.buttonPrevNav.Name = "buttonPrevNav";
            this.buttonPrevNav.Size = new System.Drawing.Size(38, 23);
            this.buttonPrevNav.TabIndex = 5;
            this.buttonPrevNav.Text = "Prev";
            this.buttonPrevNav.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nav";
            // 
            // buttonRenameFile
            // 
            this.buttonRenameFile.Location = new System.Drawing.Point(152, 2);
            this.buttonRenameFile.Name = "buttonRenameFile";
            this.buttonRenameFile.Size = new System.Drawing.Size(58, 23);
            this.buttonRenameFile.TabIndex = 3;
            this.buttonRenameFile.Text = "Rename";
            this.buttonRenameFile.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteFile
            // 
            this.buttonDeleteFile.Location = new System.Drawing.Point(98, 2);
            this.buttonDeleteFile.Name = "buttonDeleteFile";
            this.buttonDeleteFile.Size = new System.Drawing.Size(48, 23);
            this.buttonDeleteFile.TabIndex = 2;
            this.buttonDeleteFile.Text = "Delete";
            this.buttonDeleteFile.UseVisualStyleBackColor = true;
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(49, 2);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(45, 23);
            this.buttonOpenFile.TabIndex = 1;
            this.buttonOpenFile.Text = "Open";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 564);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private SplitContainer splitContainer1;
        private Panel panel1;
        private Label label2;
        private Button buttonRenameFile;
        private Button buttonDeleteFile;
        private Button buttonOpenFile;
        private Label label1;
        private Button buttonSeekNav;
        private Button buttonNextNav;
        private Button buttonPrevNav;
        private TextBox textBox1;
        private Label label5;
        private Button buttonNextFrame;
        private Button buttonPrevFrame;
        private Button buttonToggleGIF;
        private Label label4;
        private CheckBox checkBoxOffsetView;
        private CheckBox checkBoxDoubleView;
        private Label label3;
        private PictureBox pictureBox1;
    }
}