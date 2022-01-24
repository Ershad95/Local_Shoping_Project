namespace Presentation
{
    partial class Authentication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentication));
            this.Epr = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnClear = new DevComponents.DotNetBar.ButtonX();
            this.btnChngCode = new DevComponents.DotNetBar.ButtonX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.piCls = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Epr)).BeginInit();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piCls)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Epr
            // 
            this.Epr.BlinkRate = 500;
            this.Epr.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.Epr.ContainerControl = this;
            resources.ApplyResources(this.Epr, "Epr");
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExit.AntiAlias = true;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.Epr.SetError(this.btnExit, resources.GetString("btnExit.Error"));
            this.Epr.SetIconAlignment(this.btnExit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnExit.IconAlignment"))));
            this.Epr.SetIconPadding(this.btnExit, ((int)(resources.GetObject("btnExit.IconPadding"))));
            this.btnExit.Name = "btnExit";
            this.btnExit.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExit.Symbol = "58829";
            this.btnExit.SymbolColor = System.Drawing.Color.Red;
            this.btnExit.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // buttonX2
            // 
            resources.ApplyResources(this.buttonX2, "buttonX2");
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.AntiAlias = true;
            this.buttonX2.BackColor = System.Drawing.Color.Transparent;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.Epr.SetError(this.buttonX2, resources.GetString("buttonX2.Error"));
            this.Epr.SetIconAlignment(this.buttonX2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("buttonX2.IconAlignment"))));
            this.Epr.SetIconPadding(this.buttonX2, ((int)(resources.GetObject("buttonX2.IconPadding"))));
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Symbol = "58826";
            this.buttonX2.SymbolColor = System.Drawing.Color.Lime;
            this.buttonX2.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // buttonX3
            // 
            resources.ApplyResources(this.buttonX3, "buttonX3");
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.AntiAlias = true;
            this.buttonX3.BackColor = System.Drawing.Color.Transparent;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.Epr.SetError(this.buttonX3, resources.GetString("buttonX3.Error"));
            this.Epr.SetIconAlignment(this.buttonX3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("buttonX3.IconAlignment"))));
            this.Epr.SetIconPadding(this.buttonX3, ((int)(resources.GetObject("buttonX3.IconPadding"))));
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.Symbol = "57699";
            this.buttonX3.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonX3.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.buttonX3.TabStop = false;
            // 
            // lblUsername
            // 
            resources.ApplyResources(this.lblUsername, "lblUsername");
            this.Epr.SetError(this.lblUsername, resources.GetString("lblUsername.Error"));
            this.Epr.SetIconAlignment(this.lblUsername, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblUsername.IconAlignment"))));
            this.Epr.SetIconPadding(this.lblUsername, ((int)(resources.GetObject("lblUsername.IconPadding"))));
            this.lblUsername.Name = "lblUsername";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.Epr.SetError(this.label2, resources.GetString("label2.Error"));
            this.Epr.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.Epr.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.label2.Name = "label2";
            // 
            // txtUser
            // 
            resources.ApplyResources(this.txtUser, "txtUser");
            this.txtUser.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("txtUser.AutoCompleteCustomSource"),
            resources.GetString("txtUser.AutoCompleteCustomSource1"),
            resources.GetString("txtUser.AutoCompleteCustomSource2")});
            this.txtUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Epr.SetError(this.txtUser, resources.GetString("txtUser.Error"));
            this.Epr.SetIconAlignment(this.txtUser, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtUser.IconAlignment"))));
            this.Epr.SetIconPadding(this.txtUser, ((int)(resources.GetObject("txtUser.IconPadding"))));
            this.txtUser.Name = "txtUser";
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // txtPass
            // 
            resources.ApplyResources(this.txtPass, "txtPass");
            this.Epr.SetError(this.txtPass, resources.GetString("txtPass.Error"));
            this.Epr.SetIconAlignment(this.txtPass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPass.IconAlignment"))));
            this.Epr.SetIconPadding(this.txtPass, ((int)(resources.GetObject("txtPass.IconPadding"))));
            this.txtPass.Name = "txtPass";
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.Epr.SetError(this.label3, resources.GetString("label3.Error"));
            this.Epr.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment"))));
            this.Epr.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding"))));
            this.label3.Name = "label3";
            // 
            // txtCode
            // 
            resources.ApplyResources(this.txtCode, "txtCode");
            this.Epr.SetError(this.txtCode, resources.GetString("txtCode.Error"));
            this.Epr.SetIconAlignment(this.txtCode, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtCode.IconAlignment"))));
            this.Epr.SetIconPadding(this.txtCode, ((int)(resources.GetObject("txtCode.IconPadding"))));
            this.txtCode.Name = "txtCode";
            this.txtCode.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClear.AntiAlias = true;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.Epr.SetError(this.btnClear, resources.GetString("btnClear.Error"));
            this.Epr.SetIconAlignment(this.btnClear, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnClear.IconAlignment"))));
            this.Epr.SetIconPadding(this.btnClear, ((int)(resources.GetObject("btnClear.IconPadding"))));
            this.btnClear.Name = "btnClear";
            this.btnClear.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClear.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnChngCode
            // 
            resources.ApplyResources(this.btnChngCode, "btnChngCode");
            this.btnChngCode.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChngCode.AntiAlias = true;
            this.btnChngCode.BackColor = System.Drawing.Color.Transparent;
            this.btnChngCode.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.Epr.SetError(this.btnChngCode, resources.GetString("btnChngCode.Error"));
            this.Epr.SetIconAlignment(this.btnChngCode, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnChngCode.IconAlignment"))));
            this.Epr.SetIconPadding(this.btnChngCode, ((int)(resources.GetObject("btnChngCode.IconPadding"))));
            this.btnChngCode.Name = "btnChngCode";
            this.btnChngCode.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnChngCode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnChngCode.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnChngCode.Click += new System.EventHandler(this.btnChngCode_Click_1);
            // 
            // panelEx2
            // 
            resources.ApplyResources(this.panelEx2, "panelEx2");
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.btnChngCode);
            this.panelEx2.Controls.Add(this.btnClear);
            this.panelEx2.Controls.Add(this.txtCode);
            this.panelEx2.Controls.Add(this.label3);
            this.panelEx2.Controls.Add(this.txtPass);
            this.panelEx2.Controls.Add(this.txtUser);
            this.panelEx2.Controls.Add(this.label2);
            this.panelEx2.Controls.Add(this.lblUsername);
            this.panelEx2.Controls.Add(this.buttonX3);
            this.panelEx2.Controls.Add(this.buttonX2);
            this.panelEx2.Controls.Add(this.btnExit);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.Epr.SetError(this.panelEx2, resources.GetString("panelEx2.Error"));
            this.Epr.SetIconAlignment(this.panelEx2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panelEx2.IconAlignment"))));
            this.Epr.SetIconPadding(this.panelEx2, ((int)(resources.GetObject("panelEx2.IconPadding"))));
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.RightToLeftLayout = true;
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.Color = System.Drawing.Color.Chartreuse;
            this.panelEx2.Style.BackColor2.Color = System.Drawing.Color.ForestGreen;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.CornerDiameter = 15;
            this.panelEx2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            // 
            // piCls
            // 
            resources.ApplyResources(this.piCls, "piCls");
            this.Epr.SetError(this.piCls, resources.GetString("piCls.Error"));
            this.Epr.SetIconAlignment(this.piCls, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("piCls.IconAlignment"))));
            this.Epr.SetIconPadding(this.piCls, ((int)(resources.GetObject("piCls.IconPadding"))));
            this.piCls.Image = global::Presentation.Properties.Resources.mac3;
            this.piCls.Name = "piCls";
            this.piCls.TabStop = false;
            this.piCls.Click += new System.EventHandler(this.piCls_Click_1);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.Epr.SetError(this.label1, resources.GetString("label1.Error"));
            this.Epr.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.Epr.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Name = "label1";
            // 
            // panelEx1
            // 
            resources.ApplyResources(this.panelEx1, "panelEx1");
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.label1);
            this.panelEx1.Controls.Add(this.piCls);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.Epr.SetError(this.panelEx1, resources.GetString("panelEx1.Error"));
            this.Epr.SetIconAlignment(this.panelEx1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panelEx1.IconAlignment"))));
            this.Epr.SetIconPadding(this.panelEx1, ((int)(resources.GetObject("panelEx1.IconPadding"))));
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.ForestGreen;
            this.panelEx1.Style.BackColor2.Color = System.Drawing.Color.GreenYellow;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.CornerDiameter = 15;
            this.panelEx1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            // 
            // panelEx3
            // 
            resources.ApplyResources(this.panelEx3, "panelEx3");
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.DisabledBackColor = System.Drawing.Color.Empty;
            this.Epr.SetError(this.panelEx3, resources.GetString("panelEx3.Error"));
            this.Epr.SetIconAlignment(this.panelEx3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panelEx3.IconAlignment"))));
            this.Epr.SetIconPadding(this.panelEx3, ((int)(resources.GetObject("panelEx3.IconPadding"))));
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.Color = System.Drawing.Color.ForestGreen;
            this.panelEx3.Style.BackColor2.Color = System.Drawing.Color.GreenYellow;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.CornerDiameter = 15;
            this.panelEx3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            // 
            // timer
            // 
            this.timer.Interval = 250;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Authentication
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.Controls.Add(this.panelEx3);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.panelEx2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Authentication";
            this.TransparencyKey = System.Drawing.Color.Pink;
            this.Load += new System.EventHandler(this.Authentication_Load);
            this.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.Epr)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piCls)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider Epr;
        private System.Windows.Forms.Timer timer;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox piCls;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.ButtonX btnChngCode;
        private DevComponents.DotNetBar.ButtonX btnClear;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsername;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX btnExit;
    }
}