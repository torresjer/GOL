
namespace GOLStartUpTemplate_Lecture_examples
{
    partial class ModalDialogBox
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
            this.AcceptButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.WidthofGrid = new System.Windows.Forms.NumericUpDown();
            this.HeightofGrid = new System.Windows.Forms.NumericUpDown();
            this.GenerationCountMS = new System.Windows.Forms.NumericUpDown();
            this.WidthofULable = new System.Windows.Forms.Label();
            this.HeightofULable = new System.Windows.Forms.Label();
            this.GenerationsCountMsLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WidthofGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightofGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerationCountMS)).BeginInit();
            this.SuspendLayout();
            // 
            // AcceptButton
            // 
            this.AcceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AcceptButton.Location = new System.Drawing.Point(252, 152);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptButton.TabIndex = 0;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(328, 152);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // WidthofGrid
            // 
            this.WidthofGrid.Location = new System.Drawing.Point(195, 37);
            this.WidthofGrid.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WidthofGrid.Name = "WidthofGrid";
            this.WidthofGrid.Size = new System.Drawing.Size(120, 20);
            this.WidthofGrid.TabIndex = 2;
            this.WidthofGrid.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // HeightofGrid
            // 
            this.HeightofGrid.Location = new System.Drawing.Point(195, 63);
            this.HeightofGrid.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HeightofGrid.Name = "HeightofGrid";
            this.HeightofGrid.Size = new System.Drawing.Size(120, 20);
            this.HeightofGrid.TabIndex = 3;
            this.HeightofGrid.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GenerationCountMS
            // 
            this.GenerationCountMS.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.GenerationCountMS.Location = new System.Drawing.Point(195, 89);
            this.GenerationCountMS.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.GenerationCountMS.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.GenerationCountMS.Name = "GenerationCountMS";
            this.GenerationCountMS.Size = new System.Drawing.Size(120, 20);
            this.GenerationCountMS.TabIndex = 4;
            this.GenerationCountMS.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // WidthofULable
            // 
            this.WidthofULable.AutoSize = true;
            this.WidthofULable.Location = new System.Drawing.Point(97, 39);
            this.WidthofULable.Name = "WidthofULable";
            this.WidthofULable.Size = new System.Drawing.Size(92, 13);
            this.WidthofULable.TabIndex = 5;
            this.WidthofULable.Text = "Width of Universe";
            this.WidthofULable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeightofULable
            // 
            this.HeightofULable.AutoSize = true;
            this.HeightofULable.Location = new System.Drawing.Point(94, 65);
            this.HeightofULable.Name = "HeightofULable";
            this.HeightofULable.Size = new System.Drawing.Size(95, 13);
            this.HeightofULable.TabIndex = 6;
            this.HeightofULable.Text = "Height of Universe";
            this.HeightofULable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GenerationsCountMsLable
            // 
            this.GenerationsCountMsLable.AutoSize = true;
            this.GenerationsCountMsLable.Location = new System.Drawing.Point(30, 92);
            this.GenerationsCountMsLable.Name = "GenerationsCountMsLable";
            this.GenerationsCountMsLable.Size = new System.Drawing.Size(159, 13);
            this.GenerationsCountMsLable.TabIndex = 7;
            this.GenerationsCountMsLable.Text = "Generation count in milliseconds";
            this.GenerationsCountMsLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModalDialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 187);
            this.Controls.Add(this.GenerationsCountMsLable);
            this.Controls.Add(this.HeightofULable);
            this.Controls.Add(this.WidthofULable);
            this.Controls.Add(this.GenerationCountMS);
            this.Controls.Add(this.HeightofGrid);
            this.Controls.Add(this.WidthofGrid);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AcceptButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModalDialogBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ModalDialogBox";
            ((System.ComponentModel.ISupportInitialize)(this.WidthofGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightofGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerationCountMS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.NumericUpDown WidthofGrid;
        private System.Windows.Forms.NumericUpDown HeightofGrid;
        private System.Windows.Forms.NumericUpDown GenerationCountMS;
        private System.Windows.Forms.Label WidthofULable;
        private System.Windows.Forms.Label HeightofULable;
        private System.Windows.Forms.Label GenerationsCountMsLable;
    }
}