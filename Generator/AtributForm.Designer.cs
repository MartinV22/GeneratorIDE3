namespace Generator
{
    partial class AtributForm
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
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vrstaCmbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.referencaTxt = new System.Windows.Forms.TextBox();
            this.nullableChbx = new System.Windows.Forms.CheckBox();
            this.defaultChbx = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.defaultValueTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(120, 43);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(100, 20);
            this.nameTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv atributa:";
            // 
            // vrstaCmbx
            // 
            this.vrstaCmbx.FormattingEnabled = true;
            this.vrstaCmbx.Location = new System.Drawing.Point(121, 69);
            this.vrstaCmbx.Name = "vrstaCmbx";
            this.vrstaCmbx.Size = new System.Drawing.Size(99, 21);
            this.vrstaCmbx.TabIndex = 2;
            this.vrstaCmbx.SelectedIndexChanged += new System.EventHandler(this.vrstaCmbx_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vrsta:";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(37, 214);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Odustani";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(145, 214);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Spremi";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Referenca:";
            // 
            // referencaTxt
            // 
            this.referencaTxt.Location = new System.Drawing.Point(120, 96);
            this.referencaTxt.Name = "referencaTxt";
            this.referencaTxt.Size = new System.Drawing.Size(100, 20);
            this.referencaTxt.TabIndex = 8;
            // 
            // nullableChbx
            // 
            this.nullableChbx.AutoSize = true;
            this.nullableChbx.Location = new System.Drawing.Point(120, 122);
            this.nullableChbx.Name = "nullableChbx";
            this.nullableChbx.Size = new System.Drawing.Size(64, 17);
            this.nullableChbx.TabIndex = 9;
            this.nullableChbx.Text = "Nullable";
            this.nullableChbx.UseVisualStyleBackColor = true;
            // 
            // defaultChbx
            // 
            this.defaultChbx.AutoSize = true;
            this.defaultChbx.Location = new System.Drawing.Point(120, 145);
            this.defaultChbx.Name = "defaultChbx";
            this.defaultChbx.Size = new System.Drawing.Size(108, 17);
            this.defaultChbx.TabIndex = 10;
            this.defaultChbx.Text = "Default vrijednost";
            this.defaultChbx.UseVisualStyleBackColor = true;
            this.defaultChbx.CheckedChanged += new System.EventHandler(this.defaultChbx_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Default vrijednost:";
            // 
            // defaultValueTxt
            // 
            this.defaultValueTxt.Location = new System.Drawing.Point(120, 168);
            this.defaultValueTxt.Name = "defaultValueTxt";
            this.defaultValueTxt.Size = new System.Drawing.Size(100, 20);
            this.defaultValueTxt.TabIndex = 8;
            // 
            // AtributForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 316);
            this.Controls.Add(this.defaultChbx);
            this.Controls.Add(this.nullableChbx);
            this.Controls.Add(this.defaultValueTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.referencaTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vrstaCmbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTxt);
            this.Name = "AtributForm";
            this.Text = "Atribut";
            this.Load += new System.EventHandler(this.AtributForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox vrstaCmbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox referencaTxt;
        private System.Windows.Forms.CheckBox nullableChbx;
        private System.Windows.Forms.CheckBox defaultChbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox defaultValueTxt;
    }
}