namespace Palladio
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRooms = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSplitAll = new System.Windows.Forms.Button();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(604, 323);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Draw villa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 552);
            this.panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(672, 446);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 22);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(600, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Split Size";
            // 
            // textBoxRooms
            // 
            this.textBoxRooms.Location = new System.Drawing.Point(699, 480);
            this.textBoxRooms.Name = "textBoxRooms";
            this.textBoxRooms.Size = new System.Drawing.Size(55, 22);
            this.textBoxRooms.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(600, 485);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Rooms in villa";
            // 
            // buttonSplitAll
            // 
            this.buttonSplitAll.Location = new System.Drawing.Point(603, 359);
            this.buttonSplitAll.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSplitAll.Name = "buttonSplitAll";
            this.buttonSplitAll.Size = new System.Drawing.Size(150, 28);
            this.buttonSplitAll.TabIndex = 18;
            this.buttonSplitAll.Text = "Make new rooms";
            this.buttonSplitAll.UseVisualStyleBackColor = true;
            this.buttonSplitAll.Click += new System.EventHandler(this.buttonSplitAll_Click);
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(603, 513);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(151, 22);
            this.textBoxX1.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(604, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 26);
            this.button2.TabIndex = 20;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 569);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.buttonSplitAll);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxRooms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRooms;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonSplitAll;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.Button button2;
    }
}

