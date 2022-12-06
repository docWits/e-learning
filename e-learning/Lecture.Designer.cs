
namespace e_learning
{
    partial class Lecture
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
            this.lectureText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lectureText
            // 
            this.lectureText.AcceptsReturn = true;
            this.lectureText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lectureText.Location = new System.Drawing.Point(-1, 12);
            this.lectureText.Multiline = true;
            this.lectureText.Name = "lectureText";
            this.lectureText.ReadOnly = true;
            this.lectureText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lectureText.Size = new System.Drawing.Size(904, 438);
            this.lectureText.TabIndex = 0;
            this.lectureText.TextChanged += new System.EventHandler(this.lectureText_TextChanged);
            // 
            // Lecture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 462);
            this.Controls.Add(this.lectureText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Lecture";
            this.Text = "Учебные материалы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox lectureText;
    }
}