﻿
namespace UEH_ChaCorner
{
    partial class FAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAccount));
            this.panelUser = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.userPic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbId = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.mainElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btBack = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.panelOperator = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).BeginInit();
            this.panelOperator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.panelUser.BorderRadius = 100;
            this.panelUser.Controls.Add(this.userPic);
            this.panelUser.Controls.Add(this.lbId);
            this.panelUser.Controls.Add(this.lbRole);
            this.panelUser.Controls.Add(this.lbName);
            this.panelUser.CustomizableEdges.TopLeft = false;
            this.panelUser.CustomizableEdges.TopRight = false;
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.panelUser.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.panelUser.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.panelUser.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.panelUser.Location = new System.Drawing.Point(0, 0);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(320, 360);
            this.panelUser.TabIndex = 2;
            // 
            // userPic
            // 
            this.userPic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userPic.BackColor = System.Drawing.Color.Transparent;
            this.userPic.Image = ((System.Drawing.Image)(resources.GetObject("userPic.Image")));
            this.userPic.ImageRotate = 0F;
            this.userPic.Location = new System.Drawing.Point(81, 19);
            this.userPic.Margin = new System.Windows.Forms.Padding(2);
            this.userPic.Name = "userPic";
            this.userPic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.userPic.Size = new System.Drawing.Size(160, 160);
            this.userPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPic.TabIndex = 0;
            this.userPic.TabStop = false;
            this.userPic.UseTransparentBackground = true;
            // 
            // lbId
            // 
            this.lbId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbId.BackColor = System.Drawing.Color.Transparent;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.lbId.Location = new System.Drawing.Point(41, 189);
            this.lbId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(239, 42);
            this.lbId.TabIndex = 2;
            this.lbId.Text = "EID";
            this.lbId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRole
            // 
            this.lbRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRole.BackColor = System.Drawing.Color.Transparent;
            this.lbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.lbRole.Location = new System.Drawing.Point(41, 299);
            this.lbRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(239, 42);
            this.lbRole.TabIndex = 2;
            this.lbRole.Text = "Role";
            this.lbRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbName
            // 
            this.lbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.lbName.Location = new System.Drawing.Point(2, 244);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(315, 42);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DragControl
            // 
            this.DragControl.ContainerControl = this;
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.TargetControl = this.panelUser;
            this.DragControl.UseTransparentDrag = true;
            // 
            // mainElipse
            // 
            this.mainElipse.BorderRadius = 60;
            this.mainElipse.TargetControl = this;
            // 
            // btBack
            // 
            this.btBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btBack.Animated = true;
            this.btBack.BackColor = System.Drawing.Color.Transparent;
            this.btBack.BorderColor = System.Drawing.Color.Transparent;
            this.btBack.BorderRadius = 20;
            this.btBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btBack.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btBack.ForeColor = System.Drawing.Color.White;
            this.btBack.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btBack.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btBack.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btBack.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.HoverState.ForeColor = System.Drawing.Color.White;
            this.btBack.ImageSize = new System.Drawing.Size(30, 30);
            this.btBack.Location = new System.Drawing.Point(90, 26);
            this.btBack.Name = "btBack";
            this.btBack.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(151)))), ((int)(((byte)(59)))));
            this.btBack.ShadowDecoration.BorderRadius = 20;
            this.btBack.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btBack.ShadowDecoration.Depth = 8;
            this.btBack.ShadowDecoration.Enabled = true;
            this.btBack.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.btBack.Size = new System.Drawing.Size(139, 45);
            this.btBack.TabIndex = 5;
            this.btBack.Text = "Trở về";
            this.btBack.UseTransparentBackground = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // panelOperator
            // 
            this.panelOperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.panelOperator.Controls.Add(this.btBack);
            this.panelOperator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOperator.Location = new System.Drawing.Point(0, 360);
            this.panelOperator.Margin = new System.Windows.Forms.Padding(2);
            this.panelOperator.Name = "panelOperator";
            this.panelOperator.Size = new System.Drawing.Size(320, 96);
            this.panelOperator.TabIndex = 6;
            // 
            // ShadowForm
            // 
            this.ShadowForm.BorderRadius = 30;
            this.ShadowForm.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ShadowForm.TargetForm = this;
            // 
            // FAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(320, 456);
            this.Controls.Add(this.panelOperator);
            this.Controls.Add(this.panelUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAccount";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FAccount_FormClosing);
            this.Load += new System.EventHandler(this.FAccount_Load);
            this.panelUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).EndInit();
            this.panelOperator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelUser;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Label lbName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox userPic;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2Elipse mainElipse;
        private Guna.UI2.WinForms.Guna2GradientTileButton btBack;
        private Guna.UI2.WinForms.Guna2GradientPanel panelOperator;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lbId;
    }
}