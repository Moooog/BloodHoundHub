namespace BloodHoundHub
{
    partial class BloodHoundLaunchScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BloodHoundLaunchScreen));
            this.FormRounder = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ButtonRounder = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelLaunch = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.LaunchButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LaunchLogoIcon = new System.Windows.Forms.PictureBox();
            this.FormDrag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.FormPanelUI = new System.Windows.Forms.Panel();
            this.LabelText = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ButtonDrag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PanelDrag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.LogoDrag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.FormFadeLoad = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.MoreDrags = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PanelLaunch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LaunchLogoIcon)).BeginInit();
            this.FormPanelUI.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormRounder
            // 
            this.FormRounder.ElipseRadius = 15;
            this.FormRounder.TargetControl = this;
            // 
            // ButtonRounder
            // 
            this.ButtonRounder.ElipseRadius = 15;
            this.ButtonRounder.TargetControl = this;
            // 
            // PanelLaunch
            // 
            this.PanelLaunch.BackColor = System.Drawing.Color.Transparent;
            this.PanelLaunch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelLaunch.BackgroundImage")));
            this.PanelLaunch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelLaunch.Controls.Add(this.LaunchButton);
            this.PanelLaunch.GradientBottomLeft = System.Drawing.Color.Fuchsia;
            this.PanelLaunch.GradientBottomRight = System.Drawing.Color.DarkMagenta;
            this.PanelLaunch.GradientTopLeft = System.Drawing.Color.DimGray;
            this.PanelLaunch.GradientTopRight = System.Drawing.Color.Silver;
            this.PanelLaunch.Location = new System.Drawing.Point(0, 350);
            this.PanelLaunch.Name = "PanelLaunch";
            this.PanelLaunch.Quality = 10;
            this.PanelLaunch.Size = new System.Drawing.Size(325, 25);
            this.PanelLaunch.TabIndex = 13;
            // 
            // LaunchButton
            // 
            this.LaunchButton.Activecolor = System.Drawing.Color.Transparent;
            this.LaunchButton.BackColor = System.Drawing.Color.Transparent;
            this.LaunchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LaunchButton.BorderRadius = 0;
            this.LaunchButton.ButtonText = "L  A  U  N  C  H";
            this.LaunchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LaunchButton.DisabledColor = System.Drawing.Color.Gray;
            this.LaunchButton.Iconcolor = System.Drawing.Color.Transparent;
            this.LaunchButton.Iconimage = null;
            this.LaunchButton.Iconimage_right = null;
            this.LaunchButton.Iconimage_right_Selected = null;
            this.LaunchButton.Iconimage_Selected = null;
            this.LaunchButton.IconMarginLeft = 0;
            this.LaunchButton.IconMarginRight = 0;
            this.LaunchButton.IconRightVisible = true;
            this.LaunchButton.IconRightZoom = 0D;
            this.LaunchButton.IconVisible = true;
            this.LaunchButton.IconZoom = 90D;
            this.LaunchButton.IsTab = false;
            this.LaunchButton.Location = new System.Drawing.Point(0, 0);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Normalcolor = System.Drawing.Color.Transparent;
            this.LaunchButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.LaunchButton.OnHoverTextColor = System.Drawing.Color.DarkGray;
            this.LaunchButton.selected = false;
            this.LaunchButton.Size = new System.Drawing.Size(325, 25);
            this.LaunchButton.TabIndex = 0;
            this.LaunchButton.Text = "L  A  U  N  C  H";
            this.LaunchButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LaunchButton.Textcolor = System.Drawing.Color.White;
            this.LaunchButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // LaunchLogoIcon
            // 
            this.LaunchLogoIcon.BackColor = System.Drawing.Color.Transparent;
            this.LaunchLogoIcon.ErrorImage = global::BloodHoundHub.Properties.Resources.BloodHound_Logo;
            this.LaunchLogoIcon.Image = global::BloodHoundHub.Properties.Resources.BloodHound_Logo;
            this.LaunchLogoIcon.InitialImage = global::BloodHoundHub.Properties.Resources.BloodHound_Logo;
            this.LaunchLogoIcon.Location = new System.Drawing.Point(125, 15);
            this.LaunchLogoIcon.Name = "LaunchLogoIcon";
            this.LaunchLogoIcon.Size = new System.Drawing.Size(100, 100);
            this.LaunchLogoIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LaunchLogoIcon.TabIndex = 14;
            this.LaunchLogoIcon.TabStop = false;
            // 
            // FormDrag
            // 
            this.FormDrag.Fixed = true;
            this.FormDrag.Horizontal = true;
            this.FormDrag.TargetControl = this.FormPanelUI;
            this.FormDrag.Vertical = true;
            // 
            // FormPanelUI
            // 
            this.FormPanelUI.BackColor = System.Drawing.Color.Transparent;
            this.FormPanelUI.BackgroundImage = global::BloodHoundHub.Properties.Resources.LaunchWallpaper2;
            this.FormPanelUI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FormPanelUI.Controls.Add(this.LabelText);
            this.FormPanelUI.Controls.Add(this.PanelLaunch);
            this.FormPanelUI.Controls.Add(this.LaunchLogoIcon);
            this.FormPanelUI.Location = new System.Drawing.Point(0, 0);
            this.FormPanelUI.Name = "FormPanelUI";
            this.FormPanelUI.Size = new System.Drawing.Size(325, 375);
            this.FormPanelUI.TabIndex = 15;
            this.FormPanelUI.Paint += new System.Windows.Forms.PaintEventHandler(this.FormPanelUI_Paint);
            // 
            // LabelText
            // 
            this.LabelText.AutoSize = true;
            this.LabelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelText.ForeColor = System.Drawing.Color.DarkViolet;
            this.LabelText.Location = new System.Drawing.Point(100, 135);
            this.LabelText.Name = "LabelText";
            this.LabelText.Size = new System.Drawing.Size(150, 37);
            this.LabelText.TabIndex = 15;
            this.LabelText.Text = "Loading..";
            this.LabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelText.Click += new System.EventHandler(this.LabelText_Click);
            // 
            // ButtonDrag
            // 
            this.ButtonDrag.Fixed = true;
            this.ButtonDrag.Horizontal = true;
            this.ButtonDrag.TargetControl = this.LaunchButton;
            this.ButtonDrag.Vertical = true;
            // 
            // PanelDrag
            // 
            this.PanelDrag.Fixed = true;
            this.PanelDrag.Horizontal = true;
            this.PanelDrag.TargetControl = this.PanelLaunch;
            this.PanelDrag.Vertical = true;
            // 
            // LogoDrag
            // 
            this.LogoDrag.Fixed = true;
            this.LogoDrag.Horizontal = true;
            this.LogoDrag.TargetControl = this.LaunchLogoIcon;
            this.LogoDrag.Vertical = true;
            // 
            // FormFadeLoad
            // 
            this.FormFadeLoad.Delay = 1;
            // 
            // MoreDrags
            // 
            this.MoreDrags.Fixed = true;
            this.MoreDrags.Horizontal = true;
            this.MoreDrags.TargetControl = this.LabelText;
            this.MoreDrags.Vertical = true;
            // 
            // BloodHoundLaunchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BloodHoundHub.Properties.Resources.LaunchWallpaper2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(325, 377);
            this.Controls.Add(this.FormPanelUI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BloodHoundLaunchScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BloodHound - Launch Screen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosingUI);
            this.Load += new System.EventHandler(this.BloodHoundLaunchScreen_Load);
            this.PanelLaunch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LaunchLogoIcon)).EndInit();
            this.FormPanelUI.ResumeLayout(false);
            this.FormPanelUI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse FormRounder;
        private Bunifu.Framework.UI.BunifuElipse ButtonRounder;
        private Bunifu.Framework.UI.BunifuGradientPanel PanelLaunch;
        private Bunifu.Framework.UI.BunifuFlatButton LaunchButton;
        private System.Windows.Forms.PictureBox LaunchLogoIcon;
        private Bunifu.Framework.UI.BunifuDragControl FormDrag;
        private Bunifu.Framework.UI.BunifuDragControl ButtonDrag;
        private Bunifu.Framework.UI.BunifuDragControl PanelDrag;
        private Bunifu.Framework.UI.BunifuDragControl LogoDrag;
        private Bunifu.Framework.UI.BunifuFormFadeTransition FormFadeLoad;
        private System.Windows.Forms.Panel FormPanelUI;
        private Bunifu.Framework.UI.BunifuCustomLabel LabelText;
        private Bunifu.Framework.UI.BunifuDragControl MoreDrags;
    }
}