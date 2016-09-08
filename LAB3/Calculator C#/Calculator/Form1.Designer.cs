namespace Calculator
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
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.times = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.zero = new System.Windows.Forms.Button();
            this.dec = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.clr = new System.Windows.Forms.Button();
            this.root = new System.Windows.Forms.Button();
            this.power = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.inverse = new System.Windows.Forms.Button();
            this.equation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seven.Location = new System.Drawing.Point(10, 126);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(45, 45);
            this.seven.TabIndex = 0;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.button_click);
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eight.Location = new System.Drawing.Point(61, 126);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(45, 45);
            this.eight.TabIndex = 1;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.button_click);
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nine.Location = new System.Drawing.Point(112, 126);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(45, 45);
            this.nine.TabIndex = 1;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.button_click);
            // 
            // sub
            // 
            this.sub.AccessibleName = "-";
            this.sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sub.Location = new System.Drawing.Point(163, 126);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(45, 45);
            this.sub.TabIndex = 1;
            this.sub.Text = "–";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.operator_click);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.four.Location = new System.Drawing.Point(10, 177);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(45, 45);
            this.four.TabIndex = 0;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.button_click);
            // 
            // add
            // 
            this.add.AccessibleName = "+";
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.Location = new System.Drawing.Point(163, 177);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(45, 45);
            this.add.TabIndex = 1;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.operator_click);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.five.Location = new System.Drawing.Point(61, 177);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(45, 45);
            this.five.TabIndex = 1;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.button_click);
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.one.Location = new System.Drawing.Point(10, 228);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(45, 45);
            this.one.TabIndex = 1;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.button_click);
            // 
            // times
            // 
            this.times.AccessibleName = "*";
            this.times.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.times.Location = new System.Drawing.Point(163, 228);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(45, 45);
            this.times.TabIndex = 1;
            this.times.Text = "×";
            this.times.UseVisualStyleBackColor = true;
            this.times.Click += new System.EventHandler(this.operator_click);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.two.Location = new System.Drawing.Point(61, 228);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(45, 45);
            this.two.TabIndex = 1;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.button_click);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.three.Location = new System.Drawing.Point(112, 228);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(45, 45);
            this.three.TabIndex = 1;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.button_click);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.six.Location = new System.Drawing.Point(112, 177);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(45, 45);
            this.six.TabIndex = 1;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.button_click);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(10, 32);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(250, 30);
            this.result.TabIndex = 2;
            this.result.Text = "0";
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zero.Location = new System.Drawing.Point(10, 279);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(96, 45);
            this.zero.TabIndex = 1;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.button_click);
            // 
            // dec
            // 
            this.dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dec.Location = new System.Drawing.Point(112, 279);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(45, 45);
            this.dec.TabIndex = 1;
            this.dec.Text = ".";
            this.dec.UseVisualStyleBackColor = true;
            this.dec.Click += new System.EventHandler(this.button_click);
            // 
            // div
            // 
            this.div.AccessibleName = "/";
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.div.Location = new System.Drawing.Point(163, 279);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(45, 45);
            this.div.TabIndex = 1;
            this.div.Text = "÷";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.operator_click);
            // 
            // equal
            // 
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equal.Location = new System.Drawing.Point(214, 228);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(45, 96);
            this.equal.TabIndex = 0;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equals_click);
            // 
            // del
            // 
            this.del.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del.Location = new System.Drawing.Point(214, 76);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(45, 45);
            this.del.TabIndex = 0;
            this.del.Text = "CE";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.delete_click);
            // 
            // clr
            // 
            this.clr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clr.Location = new System.Drawing.Point(214, 127);
            this.clr.Name = "clr";
            this.clr.Size = new System.Drawing.Size(45, 95);
            this.clr.TabIndex = 1;
            this.clr.Text = "C";
            this.clr.UseVisualStyleBackColor = true;
            this.clr.Click += new System.EventHandler(this.clear_click);
            // 
            // root
            // 
            this.root.AccessibleName = "root";
            this.root.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.root.Location = new System.Drawing.Point(163, 75);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(45, 45);
            this.root.TabIndex = 1;
            this.root.Text = "√";
            this.root.UseVisualStyleBackColor = true;
            this.root.Click += new System.EventHandler(this.operator_click);
            // 
            // power
            // 
            this.power.AccessibleName = "pow";
            this.power.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.power.Location = new System.Drawing.Point(112, 74);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(45, 45);
            this.power.TabIndex = 1;
            this.power.Text = "^";
            this.power.UseVisualStyleBackColor = true;
            this.power.Click += new System.EventHandler(this.operator_click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.Location = new System.Drawing.Point(10, 74);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(45, 45);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_click);
            // 
            // inverse
            // 
            this.inverse.AccessibleName = "inv";
            this.inverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inverse.Location = new System.Drawing.Point(61, 74);
            this.inverse.Name = "inverse";
            this.inverse.Size = new System.Drawing.Size(45, 45);
            this.inverse.TabIndex = 1;
            this.inverse.Text = "±";
            this.inverse.UseVisualStyleBackColor = true;
            this.inverse.Click += new System.EventHandler(this.operator_click);
            // 
            // equation
            // 
            this.equation.AutoSize = true;
            this.equation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equation.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.equation.Location = new System.Drawing.Point(13, 13);
            this.equation.MinimumSize = new System.Drawing.Size(244, 16);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(244, 16);
            this.equation.TabIndex = 3;
            this.equation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 332);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.result);
            this.Controls.Add(this.six);
            this.Controls.Add(this.three);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.div);
            this.Controls.Add(this.times);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.inverse);
            this.Controls.Add(this.power);
            this.Controls.Add(this.add);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.one);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.dec);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.two);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.root);
            this.Controls.Add(this.clr);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.del);
            this.Controls.Add(this.seven);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button times;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button dec;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button clr;
        private System.Windows.Forms.Button root;
        private System.Windows.Forms.Button power;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button inverse;
        private System.Windows.Forms.Label equation;
    }
}

