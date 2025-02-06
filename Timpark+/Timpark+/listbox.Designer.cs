namespace Timpark_
{
    partial class listbox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listbox));
            this.ParcareBox = new System.Windows.Forms.ListBox();
            this.cmbTimp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ocupate = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRezerva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ParcareBox
            // 
            this.ParcareBox.FormattingEnabled = true;
            this.ParcareBox.ItemHeight = 16;
            this.ParcareBox.Location = new System.Drawing.Point(12, 52);
            this.ParcareBox.Name = "ParcareBox";
            this.ParcareBox.Size = new System.Drawing.Size(424, 164);
            this.ParcareBox.TabIndex = 0;
            // 
            // cmbTimp
            // 
            this.cmbTimp.FormattingEnabled = true;
            this.cmbTimp.Items.AddRange(new object[] {
            "8-10",
            "10-12",
            "12-14",
            "14-16",
            "16-18",
            "8-18"});
            this.cmbTimp.Location = new System.Drawing.Point(12, 315);
            this.cmbTimp.Name = "cmbTimp";
            this.cmbTimp.Size = new System.Drawing.Size(121, 24);
            this.cmbTimp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = " Alegeti intervalul in care doriti sa rezervati locul:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Locuri libere:";
            // 
            // ocupate
            // 
            this.ocupate.FormattingEnabled = true;
            this.ocupate.ItemHeight = 16;
            this.ocupate.Location = new System.Drawing.Point(648, 52);
            this.ocupate.Name = "ocupate";
            this.ocupate.Size = new System.Drawing.Size(424, 164);
            this.ocupate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(645, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Locuri ocupate:";
            // 
            // btnRezerva
            // 
            this.btnRezerva.Location = new System.Drawing.Point(15, 363);
            this.btnRezerva.Name = "btnRezerva";
            this.btnRezerva.Size = new System.Drawing.Size(144, 39);
            this.btnRezerva.TabIndex = 6;
            this.btnRezerva.Text = "Rezerva";
            this.btnRezerva.UseVisualStyleBackColor = true;
            this.btnRezerva.Click += new System.EventHandler(this.btnRezerva_Click);
            // 
            // listbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1179, 458);
            this.Controls.Add(this.btnRezerva);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ocupate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTimp);
            this.Controls.Add(this.ParcareBox);
            this.Name = "listbox";
            this.Text = "listbox";
            this.Load += new System.EventHandler(this.listbox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ParcareBox;
        private System.Windows.Forms.ComboBox cmbTimp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ocupate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRezerva;
    }
}