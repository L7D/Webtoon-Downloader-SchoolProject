﻿using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebtoonDownloader_CapstoneProject.Core;

namespace WebtoonDownloader_CapstoneProject.UI.Forms
{
	public partial class WebtoonSelectForm : Form
	{
		private Pen lineDrawer = new Pen( GlobalVar.ThemeColor );

		public enum UIMode // 인터페이스 모드
		{
			NotSelected, // 웹툰이 선택되지 않음
			QuestionIsRight, // 선택한 웹툰이 맞는지 물어보는 모드
			Selected, // 웹툰이 선택됨
			LoadingInformation // 정보 가져오는 중
		}
		private UIMode UIModeVar_private;
		private UIMode UIModeVar
		{
			get
			{
				return UIModeVar_private;
			}
			set
			{
				UIModeVar_private = value;

				Action method = new Action( ( ) =>
				{
					switch ( value )
					{
						case UIMode.NotSelected:
							this.SELECT_CANCEL_BUTTON.Visible = false;
							this.SELECTED_WEBTOON_INFORMATION_PANEL_TITLE.Visible = false;
							this.SELECTED_WEBTOON_INFORMATION_PANEL.Visible = false;

							this.DATA_TEXTBOX_TITLE.Visible = true;
							this.DATA_TEXTBOX.Visible = true;
							this.DATA_TEXTBOX.Enabled = true;
							this.DATA_TEXTBOX.Clear( );

							this.SEARCH_BUTTON.Enabled = true;
							this.SEARCH_BUTTON.Text = "검색 & 선택";

							this.Size = new Size( 700, 255 );
							CenterToScreen( );

							this.Invalidate( );
							break;
						case UIMode.LoadingInformation:
							this.DATA_TEXTBOX.Enabled = false;
							this.SEARCH_BUTTON.Enabled = false;
							this.SEARCH_BUTTON.Text = "잠시만 기다리세요 ...";
							break;
						case UIMode.QuestionIsRight:
							this.DATA_TEXTBOX_TITLE.Visible = false;
							this.DATA_TEXTBOX.Visible = false;

							this.SEARCH_BUTTON.Enabled = true;
							this.SEARCH_BUTTON.Text = "맞습니다!";

							this.SELECT_CANCEL_BUTTON.Visible = true;
							this.SELECTED_WEBTOON_INFORMATION_PANEL_TITLE.Visible = true;
							this.SELECTED_WEBTOON_INFORMATION_PANEL.Visible = true;

							this.Size = new Size( 700, 400 );
							CenterToScreen( );

							this.Invalidate( );
							break;
					}
				} );

				if ( this.InvokeRequired )
				{
					this.Invoke( new Action( ( ) =>
					{
						method.Invoke( );
					} ) );
				}
				else
				{
					method.Invoke( );
				}
			}
		}
		private NaverWebtoon.WebtoonListPageInformations? SelectedInformationBuffer; // 선택된 웹툰의 정보 temp

		public WebtoonSelectForm( )
		{
			InitializeComponent( );

			this.SetStyle( ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true );
			this.UpdateStyles( );

			this.Opacity = 0;
			this.UIModeVar = UIMode.NotSelected;

#if ( DEBUG )
			// TEST 용
			this.DATA_TEXTBOX.Text = "http://comic.naver.com/webtoon/list.nhn?titleId=570503&weekday=thu";
#endif
		}

		private void WebtoonSelectForm_Load( object sender, EventArgs e )
		{
			Animation.UI.FadeIn( this );
		}

		private void SEARCH_BUTTON_Click( object sender, EventArgs e )
		{
			if ( UIModeVar == UIMode.QuestionIsRight )
			{
				this.Opacity = 0;

				WebtoonDownloadOptionForm form = new WebtoonDownloadOptionForm( this.SelectedInformationBuffer.Value.url );
				form.ShowDialog( );

				this.Opacity = 1;

				if ( form.ForceClosed )
				{
					this.Close( );
					return;
				}

				GlobalVar.GlobalListPageInformations = this.SelectedInformationBuffer;
				this.Close( );
			}
			else
			{
				string searchString = this.DATA_TEXTBOX.Text;

				if ( searchString.Length <= 0 )
				{
					NotifyBox.Show( this, "오류", "Error", "다운로드 할 웹툰의 주소나 이름을 입력하세요.", NotifyBox.NotifyBoxType.OK, NotifyBox.NotifyBoxIcon.Error );
					return;
				}

				// ** 버그 리스트 **
				// 현재 url 끝에 # 이 붙어있으면 프로그램이 잠시 멈추는 문제가 있음

				// 입력한 정보가 URL 인지 웹툰 제목인지 확인한 후 작업 실시
				if ( Regex.IsMatch( searchString, @"^http(s)?://([\w-]+.)+[\w-]+(/[\w- ./?%&=])?$" ) )
				{
					if ( NaverWebtoon.IsValidWebtoonListURL( ref searchString ) )
					{
						this.UIModeVar = UIMode.LoadingInformation;

						Thread thread = new Thread( ( ) =>
						{
							NaverWebtoon.WebtoonListPageInformations? informations = NaverWebtoon.GetWebtoonListPageInformations( searchString );

							if ( informations.HasValue )
							{
								this.SelectedInformationBuffer = informations.Value;

								this.UIModeVar = UIMode.QuestionIsRight;
								this.SELECTED_WEBTOON_INFORMATION_PANEL.SetData( this.SelectedInformationBuffer.Value );
							}
							else
							{
								this.UIModeVar = UIMode.NotSelected;
								NotifyBox.Show( this, "오류", "Error", "죄송합니다, 해당 웹툰의 정보를 가져올 수 없었습니다.", NotifyBox.NotifyBoxType.OK, NotifyBox.NotifyBoxIcon.Error );
							}
						} )
						{
							IsBackground = true
						};

						thread.Start( );
					}
					else
					{
						NotifyBox.Show( this, "오류", "Error", "올바른 웹툰의 주소를 입력하세요.\n\nhttp://comic.naver.com/webtoon/list.nhn?titleId=679519 의 형식으로 입력하십시오.", NotifyBox.NotifyBoxType.OK, NotifyBox.NotifyBoxIcon.Error );
					}
				}
				else
				{
					WebtoonSearchForm form = new WebtoonSearchForm( searchString );
					form.ShowDialog( );

					if ( !string.IsNullOrEmpty( form.urlSelected ) )
					{
						Task.Factory.StartNew( ( ) =>
						{
							NaverWebtoon.WebtoonListPageInformations? informations = NaverWebtoon.GetWebtoonListPageInformations( form.urlSelected );

							if ( informations.HasValue )
							{
								this.SelectedInformationBuffer = informations.Value;

								this.UIModeVar = UIMode.QuestionIsRight;
								this.SELECTED_WEBTOON_INFORMATION_PANEL.SetData( this.SelectedInformationBuffer.Value );
							}
							else
							{
								this.UIModeVar = UIMode.NotSelected;
								NotifyBox.Show( this, "오류", "Error", "죄송합니다, 해당 웹툰의 정보를 가져올 수 없었습니다.", NotifyBox.NotifyBoxType.OK, NotifyBox.NotifyBoxIcon.Error );
							}
						} );
					}
				}
			}
		}

		private void WebtoonSelectForm_Paint( object sender, PaintEventArgs e )
		{
			int w = this.Width, h = this.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // 위
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // 왼쪽
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // 오른쪽
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // 아래
		}

		private void SELECT_CANCEL_BUTTON_Click( object sender, EventArgs e )
		{
			if ( this.UIModeVar == UIMode.QuestionIsRight )
			{
				GlobalVar.GlobalListPageInformations = null;
				this.SelectedInformationBuffer = null;
				UIModeVar = UIMode.NotSelected;
			}
		}

		private bool APP_TITLE_BAR_BeginClose( )
		{
			return NotifyBox.Show( this, "다운로드 취소", "Cancel", "정말로 다운로드를 취소하시겠습니까?", NotifyBox.NotifyBoxType.YesNo, NotifyBox.NotifyBoxIcon.Warning ) == NotifyBox.NotifyBoxResult.Yes;
		}

		private void DATA_TEXTBOX_KeyPress( object sender, KeyPressEventArgs e )
		{
			if ( e.KeyChar == ( char ) Keys.Enter )
			{
				this.SEARCH_BUTTON_Click( null, EventArgs.Empty );
				e.Handled = true; // 엔터 칠때 띵 소리가 나지 않게 함
			}
		}
	}
}
