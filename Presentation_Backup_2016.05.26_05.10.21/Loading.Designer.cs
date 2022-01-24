namespace Presentation
{
    partial class Loading
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
            this.Loading_progress = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.timer_load = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Loading_progress
            // 
            this.Loading_progress.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.Loading_progress.BackgroundStyle.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Center;
            this.Loading_progress.BackgroundStyle.BorderBottomColor = System.Drawing.Color.Transparent;
            this.Loading_progress.BackgroundStyle.BorderColor = System.Drawing.Color.Transparent;
            this.Loading_progress.BackgroundStyle.BorderColor2 = System.Drawing.Color.Transparent;
            this.Loading_progress.BackgroundStyle.BorderColorLight = System.Drawing.Color.Transparent;
            this.Loading_progress.BackgroundStyle.BorderColorLight2 = System.Drawing.Color.Transparent;
            this.Loading_progress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal;
            this.Loading_progress.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Far;
            this.Loading_progress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Loading_progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loading_progress.Location = new System.Drawing.Point(0, 0);
            this.Loading_progress.Name = "Loading_progress";
            this.Loading_progress.PieBorderDark = System.Drawing.Color.Transparent;
            this.Loading_progress.PieBorderLight = System.Drawing.Color.Transparent;
            this.Loading_progress.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot;
            this.Loading_progress.ProgressColor = System.Drawing.Color.Red;
            this.Loading_progress.ProgressTextColor = System.Drawing.Color.Red;
            this.Loading_progress.ProgressTextVisible = true;
            this.Loading_progress.Size = new System.Drawing.Size(267, 199);
            this.Loading_progress.SpokeBorderDark = System.Drawing.Color.Transparent;
            this.Loading_progress.SpokeBorderLight = System.Drawing.Color.Transparent;
            this.Loading_progress.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.Loading_progress.TabIndex = 0;
            this.Loading_progress.ValueChanged += new System.EventHandler(this.circularProgress1_ValueChanged);
            // 
            // timer_load
            // 
            this.timer_load.Interval = 500;
            this.timer_load.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(267, 199);
            this.Controls.Add(this.Loading_progress);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Loading";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Loading_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.CircularProgress Loading_progress;
        private System.Windows.Forms.Timer timer_load;
    }
}