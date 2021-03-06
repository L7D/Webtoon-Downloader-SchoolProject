﻿namespace WebtoonDownloader_CapstoneProject
{
	partial class MainForm
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose( );
			}
			base.Dispose( disposing );
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent( )
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.COPYRIGHT_LABEL = new System.Windows.Forms.Label();
			this.WEBTOON_DESELECT_BUTTON = new WebtoonDownloader_CapstoneProject.UI.FlatButton();
			this.WEBTOON_CURRENT_DOWNLOAD_PAGE_INFORMATION_PANEL = new WebtoonDownloader_CapstoneProject.UI.Forms.WebtoonDownloadInformationForMainForm();
			this.WEBTOON_SELECT_BUTTON = new WebtoonDownloader_CapstoneProject.UI.FlatButton();
			this.APP_TITLE_BAR = new WebtoonDownloader_CapstoneProject.UI.APP_TITLE_BAR();
			this.DOWNLOAD_INFORMATION_PANEL_TITLE = new System.Windows.Forms.Label();
			this.WEBTOON_DOWN_READY_INFORMATION_PANEL = new WebtoonDownloader_CapstoneProject.UI.Forms.WebtoonDownloadInformationForWebtoonSelectForm();
			this.LOADING_GIFIMAGE = new System.Windows.Forms.WebBrowser();
			this.DOWNLOAD_READY_IMAGE = new System.Windows.Forms.PictureBox();
			this.SYSTEM_SHUTDOWN_CHECKBOX = new WebtoonDownloader_CapstoneProject.UI.FlatCheckBox();
			this.SYSTEM_SHUTDOWN_LABEL = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.DOWNLOAD_READY_IMAGE)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SYSTEM_SHUTDOWN_CHECKBOX)).BeginInit();
			this.SuspendLayout();
			// 
			// COPYRIGHT_LABEL
			// 
			this.COPYRIGHT_LABEL.AutoSize = true;
			this.COPYRIGHT_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.COPYRIGHT_LABEL.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.COPYRIGHT_LABEL.Location = new System.Drawing.Point(12, 373);
			this.COPYRIGHT_LABEL.Name = "COPYRIGHT_LABEL";
			this.COPYRIGHT_LABEL.Size = new System.Drawing.Size(137, 14);
			this.COPYRIGHT_LABEL.TabIndex = 2;
			this.COPYRIGHT_LABEL.Text = "© 2017 - \'4조 Inventive\'";
			this.COPYRIGHT_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// WEBTOON_DESELECT_BUTTON
			// 
			this.WEBTOON_DESELECT_BUTTON.AnimationLerpP = 0.8F;
			this.WEBTOON_DESELECT_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.WEBTOON_DESELECT_BUTTON.ButtonText = "선택 취소";
			this.WEBTOON_DESELECT_BUTTON.ButtonTextColor = System.Drawing.Color.White;
			this.WEBTOON_DESELECT_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.WEBTOON_DESELECT_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.Red;
			this.WEBTOON_DESELECT_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.WEBTOON_DESELECT_BUTTON.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.WEBTOON_DESELECT_BUTTON.Location = new System.Drawing.Point(382, 363);
			this.WEBTOON_DESELECT_BUTTON.Name = "WEBTOON_DESELECT_BUTTON";
			this.WEBTOON_DESELECT_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.Crimson;
			this.WEBTOON_DESELECT_BUTTON.Size = new System.Drawing.Size(150, 25);
			this.WEBTOON_DESELECT_BUTTON.TabIndex = 7;
			this.WEBTOON_DESELECT_BUTTON.Text = "선택 취소";
			this.WEBTOON_DESELECT_BUTTON.UseVisualStyleBackColor = false;
			this.WEBTOON_DESELECT_BUTTON.Visible = false;
			this.WEBTOON_DESELECT_BUTTON.Click += new System.EventHandler(this.WEBTOON_DESELECT_BUTTON_Click);
			// 
			// WEBTOON_CURRENT_DOWNLOAD_PAGE_INFORMATION_PANEL
			// 
			this.WEBTOON_CURRENT_DOWNLOAD_PAGE_INFORMATION_PANEL.BackColor = System.Drawing.Color.White;
			this.WEBTOON_CURRENT_DOWNLOAD_PAGE_INFORMATION_PANEL.Location = new System.Drawing.Point(50, 125);
			this.WEBTOON_CURRENT_DOWNLOAD_PAGE_INFORMATION_PANEL.Name = "WEBTOON_CURRENT_DOWNLOAD_PAGE_INFORMATION_PANEL";
			this.WEBTOON_CURRENT_DOWNLOAD_PAGE_INFORMATION_PANEL.Size = new System.Drawing.Size(650, 125);
			this.WEBTOON_CURRENT_DOWNLOAD_PAGE_INFORMATION_PANEL.TabIndex = 6;
			this.WEBTOON_CURRENT_DOWNLOAD_PAGE_INFORMATION_PANEL.Visible = false;
			// 
			// WEBTOON_SELECT_BUTTON
			// 
			this.WEBTOON_SELECT_BUTTON.AnimationLerpP = 0.8F;
			this.WEBTOON_SELECT_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.WEBTOON_SELECT_BUTTON.ButtonText = "다운로드 할 웹툰 선택";
			this.WEBTOON_SELECT_BUTTON.ButtonTextColor = System.Drawing.Color.Black;
			this.WEBTOON_SELECT_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.WEBTOON_SELECT_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.Gainsboro;
			this.WEBTOON_SELECT_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.WEBTOON_SELECT_BUTTON.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.WEBTOON_SELECT_BUTTON.Location = new System.Drawing.Point(538, 338);
			this.WEBTOON_SELECT_BUTTON.Name = "WEBTOON_SELECT_BUTTON";
			this.WEBTOON_SELECT_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.WEBTOON_SELECT_BUTTON.Size = new System.Drawing.Size(200, 50);
			this.WEBTOON_SELECT_BUTTON.TabIndex = 1;
			this.WEBTOON_SELECT_BUTTON.Text = "다운로드 할 웹툰 선택";
			this.WEBTOON_SELECT_BUTTON.UseVisualStyleBackColor = false;
			this.WEBTOON_SELECT_BUTTON.Click += new System.EventHandler(this.WEBTOON_SELECT_BUTTON_Click);
			// 
			// APP_TITLE_BAR
			// 
			this.APP_TITLE_BAR.BackColor = System.Drawing.Color.Transparent;
			this.APP_TITLE_BAR.EnglishText = "Webtoon Downloader";
			this.APP_TITLE_BAR.KoreanText = "웹툰 다운로더";
			this.APP_TITLE_BAR.Location = new System.Drawing.Point(0, 0);
			this.APP_TITLE_BAR.Name = "APP_TITLE_BAR";
			this.APP_TITLE_BAR.ShowClose = true;
			this.APP_TITLE_BAR.ShowHelp = true;
			this.APP_TITLE_BAR.ShowMinimize = true;
			this.APP_TITLE_BAR.Size = new System.Drawing.Size(750, 70);
			this.APP_TITLE_BAR.TabIndex = 0;
			this.APP_TITLE_BAR.TextColor = System.Drawing.Color.Black;
			this.APP_TITLE_BAR.BeginClose += new System.Func<bool>(this.APP_TITLE_BAR_BeginClose);
			this.APP_TITLE_BAR.HelpButtonClicked += new System.Action(this.APP_TITLE_BAR_HelpButtonClicked);
			// 
			// DOWNLOAD_INFORMATION_PANEL_TITLE
			// 
			this.DOWNLOAD_INFORMATION_PANEL_TITLE.AutoSize = true;
			this.DOWNLOAD_INFORMATION_PANEL_TITLE.BackColor = System.Drawing.Color.Transparent;
			this.DOWNLOAD_INFORMATION_PANEL_TITLE.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.DOWNLOAD_INFORMATION_PANEL_TITLE.Location = new System.Drawing.Point(98, 81);
			this.DOWNLOAD_INFORMATION_PANEL_TITLE.Name = "DOWNLOAD_INFORMATION_PANEL_TITLE";
			this.DOWNLOAD_INFORMATION_PANEL_TITLE.Size = new System.Drawing.Size(137, 19);
			this.DOWNLOAD_INFORMATION_PANEL_TITLE.TabIndex = 10;
			this.DOWNLOAD_INFORMATION_PANEL_TITLE.Text = "다운로드 준비 완료";
			this.DOWNLOAD_INFORMATION_PANEL_TITLE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// WEBTOON_DOWN_READY_INFORMATION_PANEL
			// 
			this.WEBTOON_DOWN_READY_INFORMATION_PANEL.BackColor = System.Drawing.Color.White;
			this.WEBTOON_DOWN_READY_INFORMATION_PANEL.Location = new System.Drawing.Point(50, 120);
			this.WEBTOON_DOWN_READY_INFORMATION_PANEL.Name = "WEBTOON_DOWN_READY_INFORMATION_PANEL";
			this.WEBTOON_DOWN_READY_INFORMATION_PANEL.Size = new System.Drawing.Size(650, 210);
			this.WEBTOON_DOWN_READY_INFORMATION_PANEL.TabIndex = 12;
			this.WEBTOON_DOWN_READY_INFORMATION_PANEL.Visible = false;
			// 
			// LOADING_GIFIMAGE
			// 
			this.LOADING_GIFIMAGE.AllowNavigation = false;
			this.LOADING_GIFIMAGE.AllowWebBrowserDrop = false;
			this.LOADING_GIFIMAGE.IsWebBrowserContextMenuEnabled = false;
			this.LOADING_GIFIMAGE.Location = new System.Drawing.Point(50, 70);
			this.LOADING_GIFIMAGE.MinimumSize = new System.Drawing.Size(20, 20);
			this.LOADING_GIFIMAGE.Name = "LOADING_GIFIMAGE";
			this.LOADING_GIFIMAGE.ScriptErrorsSuppressed = true;
			this.LOADING_GIFIMAGE.ScrollBarsEnabled = false;
			this.LOADING_GIFIMAGE.Size = new System.Drawing.Size(40, 40);
			this.LOADING_GIFIMAGE.TabIndex = 13;
			this.LOADING_GIFIMAGE.Visible = false;
			this.LOADING_GIFIMAGE.WebBrowserShortcutsEnabled = false;
			// 
			// DOWNLOAD_READY_IMAGE
			// 
			this.DOWNLOAD_READY_IMAGE.BackColor = System.Drawing.Color.Transparent;
			this.DOWNLOAD_READY_IMAGE.Image = global::WebtoonDownloader_CapstoneProject.Properties.Resources.star;
			this.DOWNLOAD_READY_IMAGE.Location = new System.Drawing.Point(50, 70);
			this.DOWNLOAD_READY_IMAGE.Name = "DOWNLOAD_READY_IMAGE";
			this.DOWNLOAD_READY_IMAGE.Size = new System.Drawing.Size(40, 40);
			this.DOWNLOAD_READY_IMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.DOWNLOAD_READY_IMAGE.TabIndex = 14;
			this.DOWNLOAD_READY_IMAGE.TabStop = false;
			// 
			// SYSTEM_SHUTDOWN_CHECKBOX
			// 
			this.SYSTEM_SHUTDOWN_CHECKBOX.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.SYSTEM_SHUTDOWN_CHECKBOX.BackColor = System.Drawing.Color.Transparent;
			this.SYSTEM_SHUTDOWN_CHECKBOX.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SYSTEM_SHUTDOWN_CHECKBOX.Image = ((System.Drawing.Image)(resources.GetObject("SYSTEM_SHUTDOWN_CHECKBOX.Image")));
			this.SYSTEM_SHUTDOWN_CHECKBOX.Location = new System.Drawing.Point(221, 360);
			this.SYSTEM_SHUTDOWN_CHECKBOX.Name = "SYSTEM_SHUTDOWN_CHECKBOX";
			this.SYSTEM_SHUTDOWN_CHECKBOX.Size = new System.Drawing.Size(30, 30);
			this.SYSTEM_SHUTDOWN_CHECKBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.SYSTEM_SHUTDOWN_CHECKBOX.Status = false;
			this.SYSTEM_SHUTDOWN_CHECKBOX.TabIndex = 21;
			this.SYSTEM_SHUTDOWN_CHECKBOX.TabStop = false;
			// 
			// SYSTEM_SHUTDOWN_LABEL
			// 
			this.SYSTEM_SHUTDOWN_LABEL.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.SYSTEM_SHUTDOWN_LABEL.AutoSize = true;
			this.SYSTEM_SHUTDOWN_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.SYSTEM_SHUTDOWN_LABEL.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.SYSTEM_SHUTDOWN_LABEL.Location = new System.Drawing.Point(259, 368);
			this.SYSTEM_SHUTDOWN_LABEL.Name = "SYSTEM_SHUTDOWN_LABEL";
			this.SYSTEM_SHUTDOWN_LABEL.Size = new System.Drawing.Size(115, 15);
			this.SYSTEM_SHUTDOWN_LABEL.TabIndex = 20;
			this.SYSTEM_SHUTDOWN_LABEL.Text = "완료 후 시스템 종료";
			this.SYSTEM_SHUTDOWN_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(750, 400);
			this.Controls.Add(this.SYSTEM_SHUTDOWN_CHECKBOX);
			this.Controls.Add(this.SYSTEM_SHUTDOWN_LABEL);
			this.Controls.Add(this.LOADING_GIFIMAGE);
			this.Controls.Add(this.DOWNLOAD_INFORMATION_PANEL_TITLE);
			this.Controls.Add(this.WEBTOON_DESELECT_BUTTON);
			this.Controls.Add(this.COPYRIGHT_LABEL);
			this.Controls.Add(this.WEBTOON_SELECT_BUTTON);
			this.Controls.Add(this.APP_TITLE_BAR);
			this.Controls.Add(this.WEBTOON_CURRENT_DOWNLOAD_PAGE_INFORMATION_PANEL);
			this.Controls.Add(this.DOWNLOAD_READY_IMAGE);
			this.Controls.Add(this.WEBTOON_DOWN_READY_INFORMATION_PANEL);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "웹툰 다운로더";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
			((System.ComponentModel.ISupportInitialize)(this.DOWNLOAD_READY_IMAGE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SYSTEM_SHUTDOWN_CHECKBOX)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private UI.APP_TITLE_BAR APP_TITLE_BAR;
		private UI.FlatButton WEBTOON_SELECT_BUTTON;
		private System.Windows.Forms.Label COPYRIGHT_LABEL;
		private UI.Forms.WebtoonDownloadInformationForMainForm WEBTOON_CURRENT_DOWNLOAD_PAGE_INFORMATION_PANEL;
		private UI.FlatButton WEBTOON_DESELECT_BUTTON;
		private System.Windows.Forms.Label DOWNLOAD_INFORMATION_PANEL_TITLE;
		private UI.Forms.WebtoonDownloadInformationForWebtoonSelectForm WEBTOON_DOWN_READY_INFORMATION_PANEL;
		private System.Windows.Forms.WebBrowser LOADING_GIFIMAGE;
		private System.Windows.Forms.PictureBox DOWNLOAD_READY_IMAGE;
		private UI.FlatCheckBox SYSTEM_SHUTDOWN_CHECKBOX;
		private System.Windows.Forms.Label SYSTEM_SHUTDOWN_LABEL;
	}
}