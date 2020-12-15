
namespace Test_Assignment_Internship
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
            this.Fill_out_survey = new System.Windows.Forms.Button();
            this.View_survey_results = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Fill_out_survey
            // 
            this.Fill_out_survey.Location = new System.Drawing.Point(345, 236);
            this.Fill_out_survey.Name = "Fill_out_survey";
            this.Fill_out_survey.Size = new System.Drawing.Size(83, 49);
            this.Fill_out_survey.TabIndex = 0;
            this.Fill_out_survey.Text = "Fill out survey";
            this.Fill_out_survey.UseVisualStyleBackColor = true;
            this.Fill_out_survey.Click += new System.EventHandler(this.Fill_out_survey_Click);
            // 
            // View_survey_results
            // 
            this.View_survey_results.Location = new System.Drawing.Point(439, 236);
            this.View_survey_results.Name = "View_survey_results";
            this.View_survey_results.Size = new System.Drawing.Size(83, 49);
            this.View_survey_results.TabIndex = 1;
            this.View_survey_results.Text = "View survey results";
            this.View_survey_results.UseVisualStyleBackColor = true;
            this.View_survey_results.Click += new System.EventHandler(this.View_survey_results_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(897, 749);
            this.Controls.Add(this.View_survey_results);
            this.Controls.Add(this.Fill_out_survey);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Fill_out_survey;
        private System.Windows.Forms.Button View_survey_results;
    }
}

