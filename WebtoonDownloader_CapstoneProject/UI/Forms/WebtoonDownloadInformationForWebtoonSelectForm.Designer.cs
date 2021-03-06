﻿namespace WebtoonDownloader_CapstoneProject.UI.Forms
{
	partial class WebtoonDownloadInformationForWebtoonSelectForm
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

		#region 구성 요소 디자이너에서 생성한 코드

		/// <summary> 
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent( )
		{
			this.WEBTOON_LIST_TITLE_LABEL = new System.Windows.Forms.Label();
			this.WEBTOON_LIST_DESC_LABEL = new System.Windows.Forms.Label();
			this.WEBTOON_LIST_AUTHOR_LABEL = new System.Windows.Forms.Label();
			this.THUMBNAIL_IMAGE = new System.Windows.Forms.PictureBox();
			this.WEBTOON_LIST_SHOW_BUTTON = new WebtoonDownloader_CapstoneProject.UI.FlatButton();
			this.WEBTOON_LIST_AUTHOR_IMAGE = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.THUMBNAIL_IMAGE)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WEBTOON_LIST_AUTHOR_IMAGE)).BeginInit();
			this.SuspendLayout();
			// 
			// WEBTOON_LIST_TITLE_LABEL
			// 
			this.WEBTOON_LIST_TITLE_LABEL.AutoEllipsis = true;
			this.WEBTOON_LIST_TITLE_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.WEBTOON_LIST_TITLE_LABEL.Font = new System.Drawing.Font("나눔고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.WEBTOON_LIST_TITLE_LABEL.Location = new System.Drawing.Point(229, 4);
			this.WEBTOON_LIST_TITLE_LABEL.Name = "WEBTOON_LIST_TITLE_LABEL";
			this.WEBTOON_LIST_TITLE_LABEL.Size = new System.Drawing.Size(418, 30);
			this.WEBTOON_LIST_TITLE_LABEL.TabIndex = 9;
			this.WEBTOON_LIST_TITLE_LABEL.Text = "웹툰 이름";
			this.WEBTOON_LIST_TITLE_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// WEBTOON_LIST_DESC_LABEL
			// 
			this.WEBTOON_LIST_DESC_LABEL.AutoEllipsis = true;
			this.WEBTOON_LIST_DESC_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.WEBTOON_LIST_DESC_LABEL.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.WEBTOON_LIST_DESC_LABEL.Location = new System.Drawing.Point(229, 40);
			this.WEBTOON_LIST_DESC_LABEL.Name = "WEBTOON_LIST_DESC_LABEL";
			this.WEBTOON_LIST_DESC_LABEL.Size = new System.Drawing.Size(418, 84);
			this.WEBTOON_LIST_DESC_LABEL.TabIndex = 10;
			this.WEBTOON_LIST_DESC_LABEL.Text = "웹툰 설명";
			// 
			// WEBTOON_LIST_AUTHOR_LABEL
			// 
			this.WEBTOON_LIST_AUTHOR_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.WEBTOON_LIST_AUTHOR_LABEL.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.WEBTOON_LIST_AUTHOR_LABEL.Location = new System.Drawing.Point(265, 176);
			this.WEBTOON_LIST_AUTHOR_LABEL.Name = "WEBTOON_LIST_AUTHOR_LABEL";
			this.WEBTOON_LIST_AUTHOR_LABEL.Size = new System.Drawing.Size(226, 30);
			this.WEBTOON_LIST_AUTHOR_LABEL.TabIndex = 11;
			this.WEBTOON_LIST_AUTHOR_LABEL.Text = "웹툰 작가";
			this.WEBTOON_LIST_AUTHOR_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// THUMBNAIL_IMAGE
			// 
			this.THUMBNAIL_IMAGE.BackColor = System.Drawing.Color.Transparent;
			this.THUMBNAIL_IMAGE.Image = global::WebtoonDownloader_CapstoneProject.Properties.Resources.BLANK_THUMBNAIL_220x202;
			this.THUMBNAIL_IMAGE.Location = new System.Drawing.Point(3, 4);
			this.THUMBNAIL_IMAGE.Name = "THUMBNAIL_IMAGE";
			this.THUMBNAIL_IMAGE.Size = new System.Drawing.Size(220, 202);
			this.THUMBNAIL_IMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.THUMBNAIL_IMAGE.TabIndex = 1;
			this.THUMBNAIL_IMAGE.TabStop = false;
			// 
			// WEBTOON_LIST_SHOW_BUTTON
			// 
			this.WEBTOON_LIST_SHOW_BUTTON.AnimationLerpP = 0.8F;
			this.WEBTOON_LIST_SHOW_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.WEBTOON_LIST_SHOW_BUTTON.ButtonText = "웹툰 페이지 열기";
			this.WEBTOON_LIST_SHOW_BUTTON.ButtonTextColor = System.Drawing.Color.Black;
			this.WEBTOON_LIST_SHOW_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.WEBTOON_LIST_SHOW_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.Gainsboro;
			this.WEBTOON_LIST_SHOW_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.WEBTOON_LIST_SHOW_BUTTON.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.WEBTOON_LIST_SHOW_BUTTON.Location = new System.Drawing.Point(497, 176);
			this.WEBTOON_LIST_SHOW_BUTTON.Name = "WEBTOON_LIST_SHOW_BUTTON";
			this.WEBTOON_LIST_SHOW_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.WEBTOON_LIST_SHOW_BUTTON.Size = new System.Drawing.Size(150, 30);
			this.WEBTOON_LIST_SHOW_BUTTON.TabIndex = 12;
			this.WEBTOON_LIST_SHOW_BUTTON.TabStop = false;
			this.WEBTOON_LIST_SHOW_BUTTON.Text = "웹툰 페이지 열기";
			this.WEBTOON_LIST_SHOW_BUTTON.UseVisualStyleBackColor = false;
			this.WEBTOON_LIST_SHOW_BUTTON.Click += new System.EventHandler(this.WEBTOON_LIST_SHOW_BUTTON_Click);
			// 
			// WEBTOON_LIST_AUTHOR_IMAGE
			// 
			this.WEBTOON_LIST_AUTHOR_IMAGE.BackColor = System.Drawing.Color.Transparent;
			this.WEBTOON_LIST_AUTHOR_IMAGE.Image = global::WebtoonDownloader_CapstoneProject.Properties.Resources.AUTHOR_30x30;
			this.WEBTOON_LIST_AUTHOR_IMAGE.Location = new System.Drawing.Point(229, 176);
			this.WEBTOON_LIST_AUTHOR_IMAGE.Name = "WEBTOON_LIST_AUTHOR_IMAGE";
			this.WEBTOON_LIST_AUTHOR_IMAGE.Size = new System.Drawing.Size(30, 30);
			this.WEBTOON_LIST_AUTHOR_IMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.WEBTOON_LIST_AUTHOR_IMAGE.TabIndex = 16;
			this.WEBTOON_LIST_AUTHOR_IMAGE.TabStop = false;
			// 
			// WebtoonDownloadInformationForWebtoonSelectForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.WEBTOON_LIST_AUTHOR_IMAGE);
			this.Controls.Add(this.WEBTOON_LIST_SHOW_BUTTON);
			this.Controls.Add(this.WEBTOON_LIST_AUTHOR_LABEL);
			this.Controls.Add(this.WEBTOON_LIST_DESC_LABEL);
			this.Controls.Add(this.WEBTOON_LIST_TITLE_LABEL);
			this.Controls.Add(this.THUMBNAIL_IMAGE);
			this.Name = "WebtoonDownloadInformationForWebtoonSelectForm";
			this.Size = new System.Drawing.Size(650, 210);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.WebtoonDownloadInformationForWebtoonSelectForm_Paint);
			((System.ComponentModel.ISupportInitialize)(this.THUMBNAIL_IMAGE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WEBTOON_LIST_AUTHOR_IMAGE)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox THUMBNAIL_IMAGE;
		private System.Windows.Forms.Label WEBTOON_LIST_TITLE_LABEL;
		private System.Windows.Forms.Label WEBTOON_LIST_DESC_LABEL;
		private System.Windows.Forms.Label WEBTOON_LIST_AUTHOR_LABEL;
		private FlatButton WEBTOON_LIST_SHOW_BUTTON;
		private System.Windows.Forms.PictureBox WEBTOON_LIST_AUTHOR_IMAGE;
	}
}
