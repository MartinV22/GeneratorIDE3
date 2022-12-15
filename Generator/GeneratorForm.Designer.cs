namespace Generator
{
    partial class GeneratorForm
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
            this.generateBtn = new System.Windows.Forms.Button();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.entityGridView = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteAtributeBtn = new System.Windows.Forms.Button();
            this.clearAllBtn = new System.Windows.Forms.Button();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nullable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atributBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.entityGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atributBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // generateBtn
            // 
            this.generateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.generateBtn.Location = new System.Drawing.Point(258, 632);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(236, 49);
            this.generateBtn.TabIndex = 0;
            this.generateBtn.Text = "Generiraj";
            this.generateBtn.UseVisualStyleBackColor = false;
            this.generateBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(87, 43);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(195, 20);
            this.nameTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv entiteta:";
            // 
            // entityGridView
            // 
            this.entityGridView.AutoGenerateColumns = false;
            this.entityGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.entityGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.Reference,
            this.Nullable});
            this.entityGridView.DataSource = this.atributBindingSource;
            this.entityGridView.Location = new System.Drawing.Point(51, 80);
            this.entityGridView.Name = "entityGridView";
            this.entityGridView.Size = new System.Drawing.Size(443, 528);
            this.entityGridView.TabIndex = 3;
            this.entityGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.entityGridView_MouseDoubleClick);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addBtn.Location = new System.Drawing.Point(511, 80);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(141, 85);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Dodaj atribut";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteAtributeBtn
            // 
            this.deleteAtributeBtn.BackColor = System.Drawing.Color.Red;
            this.deleteAtributeBtn.Location = new System.Drawing.Point(542, 232);
            this.deleteAtributeBtn.Name = "deleteAtributeBtn";
            this.deleteAtributeBtn.Size = new System.Drawing.Size(78, 33);
            this.deleteAtributeBtn.TabIndex = 5;
            this.deleteAtributeBtn.Text = "Izbriši atribut";
            this.deleteAtributeBtn.UseVisualStyleBackColor = false;
            this.deleteAtributeBtn.Click += new System.EventHandler(this.deleteAtributeBtn_Click);
            // 
            // clearAllBtn
            // 
            this.clearAllBtn.BackColor = System.Drawing.Color.Red;
            this.clearAllBtn.Location = new System.Drawing.Point(51, 632);
            this.clearAllBtn.Name = "clearAllBtn";
            this.clearAllBtn.Size = new System.Drawing.Size(84, 32);
            this.clearAllBtn.TabIndex = 6;
            this.clearAllBtn.Text = "Očisti sve";
            this.clearAllBtn.UseVisualStyleBackColor = false;
            this.clearAllBtn.Click += new System.EventHandler(this.clearAllBtn_Click);
            // 
            // Reference
            // 
            this.Reference.DataPropertyName = "Reference";
            this.Reference.HeaderText = "Reference";
            this.Reference.Name = "Reference";
            this.Reference.ReadOnly = true;
            // 
            // Nullable
            // 
            this.Nullable.DataPropertyName = "Nullable";
            this.Nullable.HeaderText = "Nullable";
            this.Nullable.Name = "Nullable";
            this.Nullable.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // atributBindingSource
            // 
            this.atributBindingSource.DataSource = typeof(Generator.Atribut);
            // 
            // GeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 722);
            this.Controls.Add(this.clearAllBtn);
            this.Controls.Add(this.deleteAtributeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.entityGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.generateBtn);
            this.Name = "GeneratorForm";
            this.Text = "Generator";
            this.Load += new System.EventHandler(this.GeneratorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.entityGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atributBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView entityGridView;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteAtributeBtn;
        private System.Windows.Forms.Button clearAllBtn;
        private System.Windows.Forms.BindingSource atributBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Nullable;
    }
}

