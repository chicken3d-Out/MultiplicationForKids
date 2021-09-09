
namespace Computer_Assisted_Instruction
{
    partial class random_Num1
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
            this.btn_new_RandomNum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.randomNum1 = new System.Windows.Forms.TextBox();
            this.randomNum2 = new System.Windows.Forms.TextBox();
            this.answer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_new_RandomNum
            // 
            this.btn_new_RandomNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_new_RandomNum.Location = new System.Drawing.Point(284, 37);
            this.btn_new_RandomNum.Name = "btn_new_RandomNum";
            this.btn_new_RandomNum.Size = new System.Drawing.Size(229, 56);
            this.btn_new_RandomNum.TabIndex = 0;
            this.btn_new_RandomNum.Text = "New Question";
            this.btn_new_RandomNum.UseVisualStyleBackColor = true;
            this.btn_new_RandomNum.Click += new System.EventHandler(this.btn_new_RandomNum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(214, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "What";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(297, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "is";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(432, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(544, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "?";
            // 
            // randomNum1
            // 
            this.randomNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.randomNum1.Location = new System.Drawing.Point(360, 154);
            this.randomNum1.Name = "randomNum1";
            this.randomNum1.Size = new System.Drawing.Size(66, 35);
            this.randomNum1.TabIndex = 5;
            this.randomNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // randomNum2
            // 
            this.randomNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.randomNum2.Location = new System.Drawing.Point(465, 154);
            this.randomNum2.Name = "randomNum2";
            this.randomNum2.Size = new System.Drawing.Size(66, 35);
            this.randomNum2.TabIndex = 6;
            this.randomNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // answer
            // 
            this.answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.answer.Location = new System.Drawing.Point(432, 242);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(66, 35);
            this.answer.TabIndex = 7;
            this.answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.Location = new System.Drawing.Point(313, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Answer:";
            // 
            // check
            // 
            this.check.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.check.Location = new System.Drawing.Point(360, 306);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(114, 47);
            this.check.TabIndex = 9;
            this.check.Text = "Check";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // random_Num1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 395);
            this.Controls.Add(this.check);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.randomNum2);
            this.Controls.Add(this.randomNum1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_new_RandomNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "random_Num1";
            this.Text = "Computer Assisted Instruction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_new_RandomNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox randomNum1;
        private System.Windows.Forms.TextBox randomNum2;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button check;
    }
}

