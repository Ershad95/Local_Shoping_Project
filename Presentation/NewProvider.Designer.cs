namespace Presentation
{
    partial class NewProvider
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
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.label1 = new System.Windows.Forms.Label();
            this.piCls = new System.Windows.Forms.PictureBox();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnClear = new DevComponents.DotNetBar.ButtonX();
            this.btnComit = new DevComponents.DotNetBar.ButtonX();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piCls)).BeginInit();
            this.panelEx2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx3.Location = new System.Drawing.Point(12, 391);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(572, 41);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.Color = System.Drawing.Color.ForestGreen;
            this.panelEx3.Style.BackColor2.Color = System.Drawing.Color.GreenYellow;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.CornerDiameter = 15;
            this.panelEx3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 58;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.label1);
            this.panelEx1.Controls.Add(this.piCls);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(12, 24);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(572, 41);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.ForestGreen;
            this.panelEx1.Style.BackColor2.Color = System.Drawing.Color.GreenYellow;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.CornerDiameter = 15;
            this.panelEx1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(238, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "فراهم کننده";
            // 
            // piCls
            // 
            this.piCls.Image = global::Presentation.Properties.Resources.mac3;
            this.piCls.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.piCls.Location = new System.Drawing.Point(530, 4);
            this.piCls.Name = "piCls";
            this.piCls.Size = new System.Drawing.Size(34, 28);
            this.piCls.TabIndex = 3;
            this.piCls.TabStop = false;
            this.piCls.Click += new System.EventHandler(this.piCls_Click);
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.txtId);
            this.panelEx2.Controls.Add(this.txtType);
            this.panelEx2.Controls.Add(this.lblType);
            this.panelEx2.Controls.Add(this.lblPrice);
            this.panelEx2.Controls.Add(this.lblCount);
            this.panelEx2.Controls.Add(this.lblName);
            this.panelEx2.Controls.Add(this.txtTel);
            this.panelEx2.Controls.Add(this.txtAddr);
            this.panelEx2.Controls.Add(this.txtName);
            this.panelEx2.Controls.Add(this.lblId);
            this.panelEx2.Controls.Add(this.btnClear);
            this.panelEx2.Controls.Add(this.btnComit);
            this.panelEx2.Controls.Add(this.btnExit);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Location = new System.Drawing.Point(42, 47);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelEx2.RightToLeftLayout = true;
            this.panelEx2.Size = new System.Drawing.Size(507, 365);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.Color = System.Drawing.Color.Chartreuse;
            this.panelEx2.Style.BackColor2.Color = System.Drawing.Color.ForestGreen;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.CornerDiameter = 15;
            this.panelEx2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 60;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(110, 57);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(132, 22);
            this.txtId.TabIndex = 47;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtType
            // 
            this.txtType.FormattingEnabled = true;
            this.txtType.Items.AddRange(new object[] {
            "تلویزیون",
            "جاروبرقی",
            "یخچال"});
            this.txtType.Location = new System.Drawing.Point(355, 106);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(132, 24);
            this.txtType.TabIndex = 46;
            this.txtType.Text = "نوع محصول شرکت";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblType.Location = new System.Drawing.Point(295, 104);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 27);
            this.lblType.TabIndex = 43;
            this.lblType.Text = "نوع :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblPrice.Location = new System.Drawing.Point(260, 52);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(89, 27);
            this.lblPrice.TabIndex = 42;
            this.lblPrice.Text = "شماره شرکت";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblCount.Location = new System.Drawing.Point(99, 185);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(89, 27);
            this.lblCount.TabIndex = 41;
            this.lblCount.Text = "آدرس شرکت";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(27, 106);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 27);
            this.lblName.TabIndex = 40;
            this.lblName.Text = "اسم شرکت";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(355, 54);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(132, 22);
            this.txtTel.TabIndex = 38;
            this.txtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddr
            // 
            this.txtAddr.AutoCompleteCustomSource.AddRange(new string[] {
            "تهران",
            "کرج",
            "قزوین",
            "رشت",
            "چالوس",
            "همدان",
            "اصفحان",
            "اردبیل",
            "اورومیه",
            "کاشان",
            "شیراز",
            "قم",
            "هشگرد",
            "مشهد",
            "خراسان"});
            this.txtAddr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAddr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAddr.Location = new System.Drawing.Point(194, 185);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(175, 22);
            this.txtAddr.TabIndex = 37;
            this.txtAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(110, 109);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 22);
            this.txtName.TabIndex = 36;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblId.Location = new System.Drawing.Point(37, 54);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(58, 27);
            this.lblId.TabIndex = 34;
            this.lblId.Text = "شناسه :";
            // 
            // btnClear
            // 
            this.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClear.AntiAlias = true;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnClear.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(209, 251);
            this.btnClear.Name = "btnClear";
            this.btnClear.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnClear.Size = new System.Drawing.Size(97, 65);
            this.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClear.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "پاک کن";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnComit
            // 
            this.btnComit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnComit.AntiAlias = true;
            this.btnComit.BackColor = System.Drawing.Color.Transparent;
            this.btnComit.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnComit.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnComit.Location = new System.Drawing.Point(76, 251);
            this.btnComit.Name = "btnComit";
            this.btnComit.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnComit.Size = new System.Drawing.Size(97, 65);
            this.btnComit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnComit.Symbol = "58826";
            this.btnComit.SymbolColor = System.Drawing.Color.Lime;
            this.btnComit.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnComit.TabIndex = 3;
            this.btnComit.Text = "ثبت";
            this.btnComit.Click += new System.EventHandler(this.btnComit_Click);
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExit.AntiAlias = true;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnExit.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(332, 251);
            this.btnExit.Name = "btnExit";
            this.btnExit.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnExit.Size = new System.Drawing.Size(97, 65);
            this.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExit.Symbol = "58829";
            this.btnExit.SymbolColor = System.Drawing.Color.Red;
            this.btnExit.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "خروج";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // NewProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(612, 461);
            this.Controls.Add(this.panelEx3);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.panelEx2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewProvider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewProvider";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piCls)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox piCls;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private System.Windows.Forms.ComboBox txtType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblId;
        private DevComponents.DotNetBar.ButtonX btnClear;
        private DevComponents.DotNetBar.ButtonX btnComit;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private System.Windows.Forms.TextBox txtId;
    }
}