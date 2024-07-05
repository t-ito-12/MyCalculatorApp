using MyCalculatorApp.Keys;
using MyCalculatorApp.ViewModels;

namespace MyCalculatorApp.Views
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
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            mainConsole = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            specialKey_dot = new SpecialKey();
            specialKey_C = new SpecialKey();
            specialKey_CE = new SpecialKey();
            operatorKey_add = new OperatorKey();
            operatorKey_sub = new OperatorKey();
            operatorKey_mul = new OperatorKey();
            operatorKey_div = new OperatorKey();
            numKey_7 = new NumKey();
            numKey_8 = new NumKey();
            numKey_9 = new NumKey();
            numKey_4 = new NumKey();
            numKey_5 = new NumKey();
            numKey_6 = new NumKey();
            numKey_1 = new NumKey();
            numKey_2 = new NumKey();
            numKey_3 = new NumKey();
            operatorKey_eq = new OperatorKey();
            specialKey_bk = new SpecialKey();
            numKey_0 = new NumKey();
            specialKey_pm = new SpecialKey();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(334, 461);
            splitContainer1.SplitterDistance = 111;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.CausesValidation = false;
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(mainConsole);
            splitContainer2.Size = new Size(334, 111);
            splitContainer2.SplitterDistance = 25;
            splitContainer2.TabIndex = 1;
            // 
            // mainConsole
            // 
            mainConsole.Dock = DockStyle.Fill;
            mainConsole.Font = new Font("Yu Gothic UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 128);
            mainConsole.Location = new Point(0, 0);
            mainConsole.Margin = new Padding(3);
            mainConsole.Name = "mainConsole";
            mainConsole.Size = new Size(334, 82);
            mainConsole.TabIndex = 0;
            mainConsole.Text = "0";
            mainConsole.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(specialKey_dot, 2, 4);
            tableLayoutPanel1.Controls.Add(specialKey_C, 2, 0);
            tableLayoutPanel1.Controls.Add(specialKey_CE, 1, 0);
            tableLayoutPanel1.Controls.Add(operatorKey_add, 3, 3);
            tableLayoutPanel1.Controls.Add(operatorKey_sub, 3, 2);
            tableLayoutPanel1.Controls.Add(operatorKey_mul, 3, 1);
            tableLayoutPanel1.Controls.Add(operatorKey_div, 3, 0);
            tableLayoutPanel1.Controls.Add(numKey_7, 0, 1);
            tableLayoutPanel1.Controls.Add(numKey_8, 1, 1);
            tableLayoutPanel1.Controls.Add(numKey_9, 2, 1);
            tableLayoutPanel1.Controls.Add(numKey_4, 0, 2);
            tableLayoutPanel1.Controls.Add(numKey_5, 1, 2);
            tableLayoutPanel1.Controls.Add(numKey_6, 2, 2);
            tableLayoutPanel1.Controls.Add(numKey_1, 0, 3);
            tableLayoutPanel1.Controls.Add(numKey_2, 1, 3);
            tableLayoutPanel1.Controls.Add(numKey_3, 2, 3);
            tableLayoutPanel1.Controls.Add(operatorKey_eq, 3, 4);
            tableLayoutPanel1.Controls.Add(specialKey_bk, 0, 0);
            tableLayoutPanel1.Controls.Add(numKey_0, 1, 4);
            tableLayoutPanel1.Controls.Add(specialKey_pm, 0, 4);
            tableLayoutPanel1.Location = new Point(2, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(332, 342);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // specialKey_dot
            // 
            specialKey_dot.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            specialKey_dot.Location = new Point(167, 273);
            specialKey_dot.Margin = new Padding(1);
            specialKey_dot.Name = "specialKey_dot";
            specialKey_dot.Size = new Size(81, 68);
            specialKey_dot.TabIndex = 24;
            specialKey_dot.Text = ".";
            specialKey_dot.UseVisualStyleBackColor = true;
            // 
            // specialKey_C
            // 
            specialKey_C.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            specialKey_C.Location = new Point(167, 1);
            specialKey_C.Margin = new Padding(1);
            specialKey_C.Name = "specialKey_C";
            specialKey_C.Size = new Size(81, 66);
            specialKey_C.TabIndex = 22;
            specialKey_C.Text = "C";
            specialKey_C.UseVisualStyleBackColor = true;
            // 
            // specialKey_CE
            // 
            specialKey_CE.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            specialKey_CE.Location = new Point(84, 1);
            specialKey_CE.Margin = new Padding(1);
            specialKey_CE.Name = "specialKey_CE";
            specialKey_CE.Size = new Size(81, 66);
            specialKey_CE.TabIndex = 21;
            specialKey_CE.Text = "CE";
            specialKey_CE.UseVisualStyleBackColor = true;
            // 
            // operatorKey_add
            // 
            operatorKey_add.BackColor = SystemColors.Control;
            operatorKey_add.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            operatorKey_add.Location = new Point(250, 205);
            operatorKey_add.Margin = new Padding(1);
            operatorKey_add.Name = "operatorKey_add";
            operatorKey_add.Size = new Size(81, 66);
            operatorKey_add.TabIndex = 19;
            operatorKey_add.Text = "+";
            operatorKey_add.UseVisualStyleBackColor = false;
            // 
            // operatorKey_sub
            // 
            operatorKey_sub.BackColor = SystemColors.Control;
            operatorKey_sub.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            operatorKey_sub.Location = new Point(250, 137);
            operatorKey_sub.Margin = new Padding(1);
            operatorKey_sub.Name = "operatorKey_sub";
            operatorKey_sub.Size = new Size(81, 66);
            operatorKey_sub.TabIndex = 18;
            operatorKey_sub.Text = "-";
            operatorKey_sub.UseVisualStyleBackColor = false;
            // 
            // operatorKey_mul
            // 
            operatorKey_mul.BackColor = SystemColors.Control;
            operatorKey_mul.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            operatorKey_mul.Location = new Point(250, 69);
            operatorKey_mul.Margin = new Padding(1);
            operatorKey_mul.Name = "operatorKey_mul";
            operatorKey_mul.Size = new Size(81, 66);
            operatorKey_mul.TabIndex = 17;
            operatorKey_mul.Text = "×";
            operatorKey_mul.UseVisualStyleBackColor = false;
            // 
            // operatorKey_div
            // 
            operatorKey_div.BackColor = SystemColors.Control;
            operatorKey_div.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            operatorKey_div.Location = new Point(250, 1);
            operatorKey_div.Margin = new Padding(1);
            operatorKey_div.Name = "operatorKey_div";
            operatorKey_div.Size = new Size(81, 66);
            operatorKey_div.TabIndex = 16;
            operatorKey_div.Text = "÷";
            operatorKey_div.UseVisualStyleBackColor = false;
            // 
            // numKey_7
            // 
            numKey_7.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            numKey_7.Location = new Point(1, 69);
            numKey_7.Margin = new Padding(1);
            numKey_7.Name = "numKey_7";
            numKey_7.Size = new Size(81, 66);
            numKey_7.TabIndex = 0;
            numKey_7.Text = "7";
            numKey_7.UseVisualStyleBackColor = true;
            // 
            // numKey_8
            // 
            numKey_8.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            numKey_8.Location = new Point(84, 69);
            numKey_8.Margin = new Padding(1);
            numKey_8.Name = "numKey_8";
            numKey_8.Size = new Size(81, 66);
            numKey_8.TabIndex = 1;
            numKey_8.Text = "8";
            numKey_8.UseVisualStyleBackColor = true;
            // 
            // numKey_9
            // 
            numKey_9.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            numKey_9.Location = new Point(167, 69);
            numKey_9.Margin = new Padding(1);
            numKey_9.Name = "numKey_9";
            numKey_9.Size = new Size(81, 66);
            numKey_9.TabIndex = 2;
            numKey_9.Text = "9";
            numKey_9.UseVisualStyleBackColor = true;
            // 
            // numKey_4
            // 
            numKey_4.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            numKey_4.Location = new Point(1, 137);
            numKey_4.Margin = new Padding(1);
            numKey_4.Name = "numKey_4";
            numKey_4.Size = new Size(81, 66);
            numKey_4.TabIndex = 3;
            numKey_4.Text = "4";
            numKey_4.UseVisualStyleBackColor = true;
            // 
            // numKey_5
            // 
            numKey_5.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            numKey_5.Location = new Point(84, 137);
            numKey_5.Margin = new Padding(1);
            numKey_5.Name = "numKey_5";
            numKey_5.Size = new Size(81, 66);
            numKey_5.TabIndex = 4;
            numKey_5.Text = "5";
            numKey_5.UseVisualStyleBackColor = true;
            // 
            // numKey_6
            // 
            numKey_6.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            numKey_6.Location = new Point(167, 137);
            numKey_6.Margin = new Padding(1);
            numKey_6.Name = "numKey_6";
            numKey_6.Size = new Size(81, 66);
            numKey_6.TabIndex = 5;
            numKey_6.Text = "6";
            numKey_6.UseVisualStyleBackColor = true;
            // 
            // numKey_1
            // 
            numKey_1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            numKey_1.Location = new Point(1, 205);
            numKey_1.Margin = new Padding(1);
            numKey_1.Name = "numKey_1";
            numKey_1.Size = new Size(81, 66);
            numKey_1.TabIndex = 6;
            numKey_1.Text = "1";
            numKey_1.UseVisualStyleBackColor = true;
            // 
            // numKey_2
            // 
            numKey_2.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            numKey_2.Location = new Point(84, 205);
            numKey_2.Margin = new Padding(1);
            numKey_2.Name = "numKey_2";
            numKey_2.Size = new Size(81, 66);
            numKey_2.TabIndex = 7;
            numKey_2.Text = "2";
            numKey_2.UseVisualStyleBackColor = true;
            // 
            // numKey_3
            // 
            numKey_3.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            numKey_3.Location = new Point(167, 205);
            numKey_3.Margin = new Padding(1);
            numKey_3.Name = "numKey_3";
            numKey_3.Size = new Size(81, 66);
            numKey_3.TabIndex = 8;
            numKey_3.Text = "3";
            numKey_3.UseVisualStyleBackColor = true;
            // 
            // operatorKey_eq
            // 
            operatorKey_eq.BackColor = SystemColors.ActiveCaption;
            operatorKey_eq.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            operatorKey_eq.Location = new Point(250, 273);
            operatorKey_eq.Margin = new Padding(1);
            operatorKey_eq.Name = "operatorKey_eq";
            operatorKey_eq.Size = new Size(81, 68);
            operatorKey_eq.TabIndex = 12;
            operatorKey_eq.Text = "=";
            operatorKey_eq.UseVisualStyleBackColor = false;
            // 
            // specialKey_bk
            // 
            specialKey_bk.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            specialKey_bk.Location = new Point(1, 1);
            specialKey_bk.Margin = new Padding(1);
            specialKey_bk.Name = "specialKey_bk";
            specialKey_bk.Size = new Size(81, 66);
            specialKey_bk.TabIndex = 20;
            specialKey_bk.Text = "←";
            specialKey_bk.UseVisualStyleBackColor = true;
            // 
            // numKey_0
            // 
            numKey_0.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            numKey_0.Location = new Point(84, 273);
            numKey_0.Margin = new Padding(1);
            numKey_0.Name = "numKey_0";
            numKey_0.Size = new Size(81, 68);
            numKey_0.TabIndex = 11;
            numKey_0.Text = "0";
            numKey_0.UseVisualStyleBackColor = true;
            // 
            // specialKey_pm
            // 
            specialKey_pm.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            specialKey_pm.Location = new Point(1, 273);
            specialKey_pm.Margin = new Padding(1);
            specialKey_pm.Name = "specialKey_pm";
            specialKey_pm.Size = new Size(81, 68);
            specialKey_pm.TabIndex = 23;
            specialKey_pm.Text = "+/-";
            specialKey_pm.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 461);
            Controls.Add(splitContainer1);
            MaximumSize = new Size(350, 500);
            MinimumSize = new Size(350, 500);
            Name = "Form1";
            Text = "電卓";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private NumKey numKey_7;
        private NumKey numKey_8;
        private NumKey numKey_9;
        private NumKey numKey_4;
        private NumKey numKey_5;
        private NumKey numKey_6;
        private NumKey numKey_1;
        private NumKey numKey_2;
        private NumKey numKey_3;
        private NumKey numKey_0;
        private OperatorKey operatorKey_eq;
        private OperatorKey operatorKey_add;
        private OperatorKey operatorKey_sub;
        private OperatorKey operatorKey_mul;
        private OperatorKey operatorKey_div;
        private Label mainConsole;
        private SplitContainer splitContainer2;
        private SpecialKey specialKey_C;
        private SpecialKey specialKey_CE;
        private SpecialKey specialKey_bk;
        private SpecialKey specialKey_dot;
        private SpecialKey specialKey_pm;
    }
}
