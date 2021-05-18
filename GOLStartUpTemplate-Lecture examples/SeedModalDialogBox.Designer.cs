
namespace GOLStartUpTemplate_Lecture_examples
{
    partial class SeedModalDialogBox
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
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.RandomUniverseSeed = new System.Windows.Forms.NumericUpDown();
            this.SeedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RandomUniverseSeed)).BeginInit();
            this.SuspendLayout();
            // 
            // acceptButton
            // 
            this.acceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptButton.Location = new System.Drawing.Point(379, 257);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(112, 35);
            this.acceptButton.TabIndex = 1;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(499, 257);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 35);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // RandomUniverseSeed
            // 
            this.RandomUniverseSeed.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.RandomUniverseSeed.Location = new System.Drawing.Point(254, 129);
            this.RandomUniverseSeed.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.RandomUniverseSeed.Minimum = new decimal(new int[] {
            200000000,
            0,
            0,
            -2147483648});
            this.RandomUniverseSeed.Name = "RandomUniverseSeed";
            this.RandomUniverseSeed.Size = new System.Drawing.Size(214, 26);
            this.RandomUniverseSeed.TabIndex = 3;
            // 
            // SeedLabel
            // 
            this.SeedLabel.AutoSize = true;
            this.SeedLabel.Location = new System.Drawing.Point(129, 131);
            this.SeedLabel.Name = "SeedLabel";
            this.SeedLabel.Size = new System.Drawing.Size(120, 20);
            this.SeedLabel.TabIndex = 4;
            this.SeedLabel.Text = "Random Seed :";
            this.SeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SeedModalDialogBox
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(624, 306);
            this.Controls.Add(this.SeedLabel);
            this.Controls.Add(this.RandomUniverseSeed);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeedModalDialogBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Randomization By Seed";
            ((System.ComponentModel.ISupportInitialize)(this.RandomUniverseSeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.NumericUpDown RandomUniverseSeed;
        private System.Windows.Forms.Label SeedLabel;
    }
}