namespace THECalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.doitagain = new System.Windows.Forms.Button();
            this.pop = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.preview = new System.Windows.Forms.Label();
            this.zero = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.toDo = new System.Windows.Forms.Label();
            this.alerts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 36);
            this.label1.TabIndex = 49;
            this.label1.Text = "=";
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.Control;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.ForeColor = System.Drawing.Color.Black;
            this.result.Location = new System.Drawing.Point(445, 54);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(425, 45);
            this.result.TabIndex = 48;
            this.result.Text = "Result box";
            // 
            // doitagain
            // 
            this.doitagain.BackColor = System.Drawing.SystemColors.ControlLight;
            this.doitagain.Enabled = false;
            this.doitagain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doitagain.Location = new System.Drawing.Point(350, 137);
            this.doitagain.Name = "doitagain";
            this.doitagain.Size = new System.Drawing.Size(47, 47);
            this.doitagain.TabIndex = 47;
            this.doitagain.Text = "↺";
            this.doitagain.UseVisualStyleBackColor = false;
            this.doitagain.Click += new System.EventHandler(this.doitagain_Click);
            // 
            // pop
            // 
            this.pop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pop.Enabled = false;
            this.pop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pop.Location = new System.Drawing.Point(202, 137);
            this.pop.Name = "pop";
            this.pop.Size = new System.Drawing.Size(47, 47);
            this.pop.TabIndex = 46;
            this.pop.Text = "←";
            this.pop.UseVisualStyleBackColor = false;
            this.pop.Click += new System.EventHandler(this.pop_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(149, 137);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(47, 47);
            this.clear.TabIndex = 45;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.SystemColors.ControlLight;
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division.Location = new System.Drawing.Point(255, 137);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(47, 47);
            this.division.TabIndex = 44;
            this.division.Text = "÷";
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.onNumClick);
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.SystemColors.ControlLight;
            this.equals.Enabled = false;
            this.equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.Location = new System.Drawing.Point(202, 349);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(100, 47);
            this.equals.TabIndex = 43;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // multi
            // 
            this.multi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multi.Location = new System.Drawing.Point(255, 296);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(47, 47);
            this.multi.TabIndex = 42;
            this.multi.Text = "x";
            this.multi.UseVisualStyleBackColor = false;
            this.multi.Click += new System.EventHandler(this.onNumClick);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(255, 243);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(47, 47);
            this.minus.TabIndex = 41;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.onNumClick);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(255, 190);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(47, 47);
            this.plus.TabIndex = 40;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.onNumClick);
            // 
            // dot
            // 
            this.dot.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot.Location = new System.Drawing.Point(149, 349);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(47, 47);
            this.dot.TabIndex = 39;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = false;
            this.dot.Click += new System.EventHandler(this.onNumClick);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(149, 190);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(47, 47);
            this.eight.TabIndex = 38;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.onNumClick);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(202, 190);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(47, 47);
            this.nine.TabIndex = 37;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.onNumClick);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.ControlLight;
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(96, 190);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(47, 47);
            this.seven.TabIndex = 36;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.onNumClick);
            // 
            // preview
            // 
            this.preview.BackColor = System.Drawing.SystemColors.Info;
            this.preview.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preview.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.preview.Location = new System.Drawing.Point(447, 108);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(231, 26);
            this.preview.TabIndex = 34;
            this.preview.Text = "Preview box";
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.ControlLight;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(96, 349);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(47, 47);
            this.zero.TabIndex = 33;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.onNumClick);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.ControlLight;
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(202, 296);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(47, 47);
            this.three.TabIndex = 32;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.onNumClick);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.ControlLight;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(149, 296);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(47, 47);
            this.two.TabIndex = 31;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.onNumClick);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.ControlLight;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(96, 296);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(47, 47);
            this.one.TabIndex = 30;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.onNumClick);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.ControlLight;
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(149, 243);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(47, 47);
            this.five.TabIndex = 29;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.onNumClick);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.SystemColors.ControlLight;
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(202, 243);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(47, 47);
            this.six.TabIndex = 28;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.onNumClick);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.SystemColors.ControlLight;
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(96, 243);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(47, 47);
            this.four.TabIndex = 27;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.onNumClick);
            // 
            // toDo
            // 
            this.toDo.BackColor = System.Drawing.SystemColors.Control;
            this.toDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toDo.Location = new System.Drawing.Point(91, 37);
            this.toDo.Name = "toDo";
            this.toDo.Size = new System.Drawing.Size(306, 75);
            this.toDo.TabIndex = 52;
            // 
            // alerts
            // 
            this.alerts.BackColor = System.Drawing.SystemColors.Info;
            this.alerts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alerts.Location = new System.Drawing.Point(444, 221);
            this.alerts.Name = "alerts";
            this.alerts.Size = new System.Drawing.Size(426, 175);
            this.alerts.TabIndex = 53;
            this.alerts.Text = "Alerts";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.alerts);
            this.Controls.Add(this.toDo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.doitagain);
            this.Controls.Add(this.pop);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.division);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.preview);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.five);
            this.Controls.Add(this.six);
            this.Controls.Add(this.four);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button doitagain;
        private System.Windows.Forms.Button pop;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Label preview;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Label toDo;
        private System.Windows.Forms.Label alerts;
    }
}

