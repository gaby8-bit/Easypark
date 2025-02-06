namespace Timpark_
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nume = new System.Windows.Forms.TextBox();
            this.parola = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Button();
            this.conditie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(26, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Introduceti numele de utilizator:";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(26, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Introduceti parola dorita:";
            // 
            // nume
            // 
            this.nume.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.nume.Location = new System.Drawing.Point(318, 65);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(100, 22);
            this.nume.TabIndex = 4;
            // 
            // parola
            // 
            this.parola.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.parola.Location = new System.Drawing.Point(318, 135);
            this.parola.Name = "parola";
            this.parola.PasswordChar = '*';
            this.parola.Size = new System.Drawing.Size(100, 22);
            this.parola.TabIndex = 5;
            this.parola.TextChanged += new System.EventHandler(this.parola_TextChanged);
            // 
            // confirm
            // 
            this.confirm.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.confirm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.confirm.Location = new System.Drawing.Point(184, 219);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(207, 57);
            this.confirm.TabIndex = 6;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // conditie
            // 
            this.conditie.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.conditie.AutoSize = true;
            this.conditie.Location = new System.Drawing.Point(391, 144);
            this.conditie.Name = "conditie";
            this.conditie.Size = new System.Drawing.Size(0, 16);
            this.conditie.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(845, 442);
            this.Controls.Add(this.conditie);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.parola);
            this.Controls.Add(this.nume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nume;
        private System.Windows.Forms.TextBox parola;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label conditie;
    }
}