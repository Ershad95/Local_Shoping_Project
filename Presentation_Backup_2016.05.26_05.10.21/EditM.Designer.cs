namespace Presentation
{
    partial class EditM
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
            this.GroupDelete = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnDeleteAll = new DevComponents.DotNetBar.ButtonX();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.GroupUpdate = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new DevComponents.DotNetBar.ButtonX();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piCls)).BeginInit();
            this.panelEx2.SuspendLayout();
            this.GroupDelete.SuspendLayout();
            this.GroupUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx3.Location = new System.Drawing.Point(8, 487);
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
            this.panelEx1.Location = new System.Drawing.Point(1, 9);
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
            this.label1.Location = new System.Drawing.Point(261, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "تغییرات";
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
            this.panelEx2.Controls.Add(this.GroupDelete);
            this.panelEx2.Controls.Add(this.GroupUpdate);
            this.panelEx2.Controls.Add(this.btnExit);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Location = new System.Drawing.Point(31, 32);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelEx2.RightToLeftLayout = true;
            this.panelEx2.Size = new System.Drawing.Size(507, 473);
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
            // GroupDelete
            // 
            this.GroupDelete.CanvasColor = System.Drawing.SystemColors.Control;
            this.GroupDelete.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.GroupDelete.Controls.Add(this.btnDelete);
            this.GroupDelete.Controls.Add(this.btnDeleteAll);
            this.GroupDelete.Controls.Add(this.label9);
            this.GroupDelete.Controls.Add(this.txtDelete);
            this.GroupDelete.DisabledBackColor = System.Drawing.Color.Empty;
            this.GroupDelete.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold);
            this.GroupDelete.Location = new System.Drawing.Point(17, 235);
            this.GroupDelete.Name = "GroupDelete";
            this.GroupDelete.Size = new System.Drawing.Size(476, 143);
            // 
            // 
            // 
            this.GroupDelete.Style.BackColor = System.Drawing.Color.ForestGreen;
            this.GroupDelete.Style.BackColor2 = System.Drawing.Color.GreenYellow;
            this.GroupDelete.Style.BackColorGradientAngle = 90;
            this.GroupDelete.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupDelete.Style.BorderBottomWidth = 1;
            this.GroupDelete.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GroupDelete.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupDelete.Style.BorderLeftWidth = 1;
            this.GroupDelete.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupDelete.Style.BorderRightWidth = 1;
            this.GroupDelete.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupDelete.Style.BorderTopWidth = 1;
            this.GroupDelete.Style.CornerDiameter = 4;
            this.GroupDelete.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.GroupDelete.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GroupDelete.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GroupDelete.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.GroupDelete.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.GroupDelete.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GroupDelete.TabIndex = 47;
            this.GroupDelete.Text = "حذف مشتری";
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnDelete.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDelete.Location = new System.Drawing.Point(281, 42);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 2, 2, 10);
            this.btnDelete.Size = new System.Drawing.Size(159, 52);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.Symbol = "";
            this.btnDelete.SymbolColor = System.Drawing.Color.Red;
            this.btnDelete.TabIndex = 48;
            this.btnDelete.Text = "حذف با شناسه";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeleteAll.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnDeleteAll.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDeleteAll.Location = new System.Drawing.Point(23, 42);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 2, 2, 10);
            this.btnDeleteAll.Size = new System.Drawing.Size(159, 52);
            this.btnDeleteAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDeleteAll.Symbol = "";
            this.btnDeleteAll.SymbolColor = System.Drawing.Color.Red;
            this.btnDeleteAll.TabIndex = 47;
            this.btnDeleteAll.Text = "حذف تمامی اطلاعات";
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(384, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 24);
            this.label9.TabIndex = 46;
            this.label9.Text = "کد مشتری";
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(82, 5);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(296, 31);
            this.txtDelete.TabIndex = 42;
            // 
            // GroupUpdate
            // 
            this.GroupUpdate.CanvasColor = System.Drawing.SystemColors.Control;
            this.GroupUpdate.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.GroupUpdate.Controls.Add(this.btnUpdate);
            this.GroupUpdate.Controls.Add(this.label5);
            this.GroupUpdate.Controls.Add(this.btnClear);
            this.GroupUpdate.Controls.Add(this.label4);
            this.GroupUpdate.Controls.Add(this.label3);
            this.GroupUpdate.Controls.Add(this.label2);
            this.GroupUpdate.Controls.Add(this.txtID);
            this.GroupUpdate.Controls.Add(this.txtTel);
            this.GroupUpdate.Controls.Add(this.txtFamily);
            this.GroupUpdate.Controls.Add(this.txtName);
            this.GroupUpdate.DisabledBackColor = System.Drawing.Color.Empty;
            this.GroupUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupUpdate.Location = new System.Drawing.Point(17, 24);
            this.GroupUpdate.Name = "GroupUpdate";
            this.GroupUpdate.Size = new System.Drawing.Size(476, 205);
            // 
            // 
            // 
            this.GroupUpdate.Style.BackColor = System.Drawing.Color.ForestGreen;
            this.GroupUpdate.Style.BackColor2 = System.Drawing.Color.GreenYellow;
            this.GroupUpdate.Style.BackColorGradientAngle = 90;
            this.GroupUpdate.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupUpdate.Style.BorderBottomWidth = 1;
            this.GroupUpdate.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GroupUpdate.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupUpdate.Style.BorderLeftWidth = 1;
            this.GroupUpdate.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupUpdate.Style.BorderRightWidth = 1;
            this.GroupUpdate.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupUpdate.Style.BorderTopWidth = 1;
            this.GroupUpdate.Style.CornerDiameter = 4;
            this.GroupUpdate.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.GroupUpdate.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GroupUpdate.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemDesignTimeBorder;
            this.GroupUpdate.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.GroupUpdate.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.GroupUpdate.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GroupUpdate.TabIndex = 46;
            this.GroupUpdate.Text = "بروز رسانی";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnUpdate.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUpdate.Location = new System.Drawing.Point(23, 53);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 2, 2, 10);
            this.btnUpdate.Size = new System.Drawing.Size(125, 52);
            this.btnUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUpdate.Symbol = "";
            this.btnUpdate.SymbolColor = System.Drawing.Color.White;
            this.btnUpdate.TabIndex = 50;
            this.btnUpdate.Text = "بروزرسانی";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(364, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 49;
            this.label5.Text = "نام خانوادگی";
            // 
            // btnClear
            // 
            this.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClear.AntiAlias = true;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnClear.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClear.Location = new System.Drawing.Point(45, 111);
            this.btnClear.Name = "btnClear";
            this.btnClear.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnClear.Size = new System.Drawing.Size(69, 59);
            this.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClear.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "پاک کن";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(382, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 24);
            this.label4.TabIndex = 48;
            this.label4.Text = "شناسه";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(382, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 24);
            this.label3.TabIndex = 47;
            this.label3.Text = "تلفن";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(382, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 24);
            this.label2.TabIndex = 46;
            this.label2.Text = "نام";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold);
            this.txtID.Location = new System.Drawing.Point(74, 16);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(302, 31);
            this.txtID.TabIndex = 45;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(219, 123);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(136, 22);
            this.txtTel.TabIndex = 44;
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(219, 95);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(136, 22);
            this.txtFamily.TabIndex = 43;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(219, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(136, 22);
            this.txtName.TabIndex = 42;
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExit.AntiAlias = true;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnExit.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(419, 384);
            this.btnExit.Name = "btnExit";
            this.btnExit.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnExit.Size = new System.Drawing.Size(74, 65);
            this.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExit.Symbol = "";
            this.btnExit.SymbolColor = System.Drawing.Color.Red;
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "خروج";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // EditM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 540);
            this.Controls.Add(this.panelEx3);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.panelEx2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditM";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piCls)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.GroupDelete.ResumeLayout(false);
            this.GroupDelete.PerformLayout();
            this.GroupUpdate.ResumeLayout(false);
            this.GroupUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox piCls;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.ButtonX btnClear;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private DevComponents.DotNetBar.Controls.GroupPanel GroupDelete;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.ButtonX btnDeleteAll;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDelete;
        private DevComponents.DotNetBar.Controls.GroupPanel GroupUpdate;
        private DevComponents.DotNetBar.ButtonX btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.TextBox txtName;
    }
}