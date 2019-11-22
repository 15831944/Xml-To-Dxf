namespace ParcelsConverter
{
    partial class Win_Prop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Win_Prop));
            this.Switch = new System.Windows.Forms.CheckBox();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.export = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Switch
            // 
            this.Switch.AutoSize = true;
            this.Switch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Switch.Location = new System.Drawing.Point(10, 65);
            this.Switch.Margin = new System.Windows.Forms.Padding(2);
            this.Switch.Name = "Switch";
            this.Switch.Size = new System.Drawing.Size(118, 18);
            this.Switch.TabIndex = 1;
            this.Switch.Text = "Перевернуть X Y";
            this.Switch.UseVisualStyleBackColor = true;
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFrom.Location = new System.Drawing.Point(10, 10);
            this.textBoxFrom.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(234, 20);
            this.textBoxFrom.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(248, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "Открыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Open_Click);
            // 
            // export
            // 
            this.export.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.export.Location = new System.Drawing.Point(248, 65);
            this.export.Margin = new System.Windows.Forms.Padding(2);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(98, 32);
            this.export.TabIndex = 0;
            this.export.Text = "Экспорт";
            this.export.UseVisualStyleBackColor = false;
            this.export.Click += new System.EventHandler(this.button_export);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(248, 38);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 22);
            this.button2.TabIndex = 4;
            this.button2.Text = "Сохранить как";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Saveas_Click);
            // 
            // textBoxTo
            // 
            this.textBoxTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTo.Location = new System.Drawing.Point(10, 38);
            this.textBoxTo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(234, 20);
            this.textBoxTo.TabIndex = 5;
            // 
            // Win_Prop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(354, 111);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.export);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.Switch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Win_Prop";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XML to DXF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Switch;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxTo;
    }
}