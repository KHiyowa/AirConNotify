<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AirConNotify
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AirConNotify))
        Me.NotifyTgb = New System.Windows.Forms.CheckBox()
        Me.TimeGBox = New System.Windows.Forms.GroupBox()
        Me.H23Cb = New System.Windows.Forms.CheckBox()
        Me.H22Cb = New System.Windows.Forms.CheckBox()
        Me.H21Cb = New System.Windows.Forms.CheckBox()
        Me.H20Cb = New System.Windows.Forms.CheckBox()
        Me.H19Cb = New System.Windows.Forms.CheckBox()
        Me.H18Cb = New System.Windows.Forms.CheckBox()
        Me.H17Cb = New System.Windows.Forms.CheckBox()
        Me.H16Cb = New System.Windows.Forms.CheckBox()
        Me.H15Cb = New System.Windows.Forms.CheckBox()
        Me.H14Cb = New System.Windows.Forms.CheckBox()
        Me.H13Cb = New System.Windows.Forms.CheckBox()
        Me.H12Cb = New System.Windows.Forms.CheckBox()
        Me.H11Cb = New System.Windows.Forms.CheckBox()
        Me.H10Cb = New System.Windows.Forms.CheckBox()
        Me.H09Cb = New System.Windows.Forms.CheckBox()
        Me.H08Cb = New System.Windows.Forms.CheckBox()
        Me.H07Cb = New System.Windows.Forms.CheckBox()
        Me.H06Cb = New System.Windows.Forms.CheckBox()
        Me.H05Cb = New System.Windows.Forms.CheckBox()
        Me.H04Cb = New System.Windows.Forms.CheckBox()
        Me.H03Cb = New System.Windows.Forms.CheckBox()
        Me.H02Cb = New System.Windows.Forms.CheckBox()
        Me.H01Cb = New System.Windows.Forms.CheckBox()
        Me.H00Cb = New System.Windows.Forms.CheckBox()
        Me.MinimizeBtn = New System.Windows.Forms.Button()
        Me.TimeKeeperTm = New System.Windows.Forms.Timer(Me.components)
        Me.TaskTrayNi = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TaskTrayCms = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VersionTsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ViewTsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopNotifyTsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinuteNud = New System.Windows.Forms.NumericUpDown()
        Me.MinuteLbl = New System.Windows.Forms.Label()
        Me.ResetBtn = New System.Windows.Forms.LinkLabel()
        Me.ExitBtn = New System.Windows.Forms.LinkLabel()
        Me.TestBtn = New System.Windows.Forms.LinkLabel()
        Me.ThanksBtn = New System.Windows.Forms.LinkLabel()
        Me.SoundCb = New System.Windows.Forms.CheckBox()
        Me.UnlockCb = New System.Windows.Forms.CheckBox()
        Me.VersionBtn = New System.Windows.Forms.LinkLabel()
        Me.MainTc = New System.Windows.Forms.TabControl()
        Me.MainTp = New System.Windows.Forms.TabPage()
        Me.SettingTp = New System.Windows.Forms.TabPage()
        Me.DayStartHourLbl = New System.Windows.Forms.Label()
        Me.DayStartHourNud = New System.Windows.Forms.NumericUpDown()
        Me.DayStartLbl = New System.Windows.Forms.Label()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.MinimizeStartCb = New System.Windows.Forms.CheckBox()
        Me.TimeGBox.SuspendLayout()
        Me.TaskTrayCms.SuspendLayout()
        CType(Me.MinuteNud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainTc.SuspendLayout()
        Me.MainTp.SuspendLayout()
        Me.SettingTp.SuspendLayout()
        CType(Me.DayStartHourNud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotifyTgb
        '
        Me.NotifyTgb.Appearance = System.Windows.Forms.Appearance.Button
        Me.NotifyTgb.Checked = True
        Me.NotifyTgb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.NotifyTgb.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.NotifyTgb.Location = New System.Drawing.Point(32, 50)
        Me.NotifyTgb.Name = "NotifyTgb"
        Me.NotifyTgb.Size = New System.Drawing.Size(176, 94)
        Me.NotifyTgb.TabIndex = 1
        Me.NotifyTgb.Text = "通知を一時停止"
        Me.NotifyTgb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.NotifyTgb.UseVisualStyleBackColor = True
        '
        'TimeGBox
        '
        Me.TimeGBox.Controls.Add(Me.H23Cb)
        Me.TimeGBox.Controls.Add(Me.H22Cb)
        Me.TimeGBox.Controls.Add(Me.H21Cb)
        Me.TimeGBox.Controls.Add(Me.H20Cb)
        Me.TimeGBox.Controls.Add(Me.H19Cb)
        Me.TimeGBox.Controls.Add(Me.H18Cb)
        Me.TimeGBox.Controls.Add(Me.H17Cb)
        Me.TimeGBox.Controls.Add(Me.H16Cb)
        Me.TimeGBox.Controls.Add(Me.H15Cb)
        Me.TimeGBox.Controls.Add(Me.H14Cb)
        Me.TimeGBox.Controls.Add(Me.H13Cb)
        Me.TimeGBox.Controls.Add(Me.H12Cb)
        Me.TimeGBox.Controls.Add(Me.H11Cb)
        Me.TimeGBox.Controls.Add(Me.H10Cb)
        Me.TimeGBox.Controls.Add(Me.H09Cb)
        Me.TimeGBox.Controls.Add(Me.H08Cb)
        Me.TimeGBox.Controls.Add(Me.H07Cb)
        Me.TimeGBox.Controls.Add(Me.H06Cb)
        Me.TimeGBox.Controls.Add(Me.H05Cb)
        Me.TimeGBox.Controls.Add(Me.H04Cb)
        Me.TimeGBox.Controls.Add(Me.H03Cb)
        Me.TimeGBox.Controls.Add(Me.H02Cb)
        Me.TimeGBox.Controls.Add(Me.H01Cb)
        Me.TimeGBox.Controls.Add(Me.H00Cb)
        Me.TimeGBox.Location = New System.Drawing.Point(6, 6)
        Me.TimeGBox.Name = "TimeGBox"
        Me.TimeGBox.Size = New System.Drawing.Size(107, 280)
        Me.TimeGBox.TabIndex = 25
        Me.TimeGBox.TabStop = False
        Me.TimeGBox.Text = "時"
        '
        'H23Cb
        '
        Me.H23Cb.AutoSize = True
        Me.H23Cb.Checked = True
        Me.H23Cb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.H23Cb.Location = New System.Drawing.Point(54, 260)
        Me.H23Cb.Name = "H23Cb"
        Me.H23Cb.Size = New System.Drawing.Size(48, 16)
        Me.H23Cb.TabIndex = 23
        Me.H23Cb.Text = "23時"
        Me.H23Cb.UseVisualStyleBackColor = True
        '
        'H22Cb
        '
        Me.H22Cb.AutoSize = True
        Me.H22Cb.Checked = True
        Me.H22Cb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.H22Cb.Location = New System.Drawing.Point(54, 238)
        Me.H22Cb.Name = "H22Cb"
        Me.H22Cb.Size = New System.Drawing.Size(48, 16)
        Me.H22Cb.TabIndex = 22
        Me.H22Cb.Text = "22時"
        Me.H22Cb.UseVisualStyleBackColor = True
        '
        'H21Cb
        '
        Me.H21Cb.AutoSize = True
        Me.H21Cb.Checked = True
        Me.H21Cb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.H21Cb.Location = New System.Drawing.Point(54, 216)
        Me.H21Cb.Name = "H21Cb"
        Me.H21Cb.Size = New System.Drawing.Size(48, 16)
        Me.H21Cb.TabIndex = 21
        Me.H21Cb.Text = "21時"
        Me.H21Cb.UseVisualStyleBackColor = True
        '
        'H20Cb
        '
        Me.H20Cb.AutoSize = True
        Me.H20Cb.Location = New System.Drawing.Point(54, 194)
        Me.H20Cb.Name = "H20Cb"
        Me.H20Cb.Size = New System.Drawing.Size(48, 16)
        Me.H20Cb.TabIndex = 20
        Me.H20Cb.Text = "20時"
        Me.H20Cb.UseVisualStyleBackColor = True
        '
        'H19Cb
        '
        Me.H19Cb.AutoSize = True
        Me.H19Cb.Location = New System.Drawing.Point(54, 172)
        Me.H19Cb.Name = "H19Cb"
        Me.H19Cb.Size = New System.Drawing.Size(48, 16)
        Me.H19Cb.TabIndex = 19
        Me.H19Cb.Text = "19時"
        Me.H19Cb.UseVisualStyleBackColor = True
        '
        'H18Cb
        '
        Me.H18Cb.AutoSize = True
        Me.H18Cb.Location = New System.Drawing.Point(54, 150)
        Me.H18Cb.Name = "H18Cb"
        Me.H18Cb.Size = New System.Drawing.Size(48, 16)
        Me.H18Cb.TabIndex = 18
        Me.H18Cb.Text = "18時"
        Me.H18Cb.UseVisualStyleBackColor = True
        '
        'H17Cb
        '
        Me.H17Cb.AutoSize = True
        Me.H17Cb.Location = New System.Drawing.Point(54, 128)
        Me.H17Cb.Name = "H17Cb"
        Me.H17Cb.Size = New System.Drawing.Size(48, 16)
        Me.H17Cb.TabIndex = 17
        Me.H17Cb.Text = "17時"
        Me.H17Cb.UseVisualStyleBackColor = True
        '
        'H16Cb
        '
        Me.H16Cb.AutoSize = True
        Me.H16Cb.Location = New System.Drawing.Point(54, 106)
        Me.H16Cb.Name = "H16Cb"
        Me.H16Cb.Size = New System.Drawing.Size(48, 16)
        Me.H16Cb.TabIndex = 16
        Me.H16Cb.Text = "16時"
        Me.H16Cb.UseVisualStyleBackColor = True
        '
        'H15Cb
        '
        Me.H15Cb.AutoSize = True
        Me.H15Cb.Location = New System.Drawing.Point(54, 84)
        Me.H15Cb.Name = "H15Cb"
        Me.H15Cb.Size = New System.Drawing.Size(48, 16)
        Me.H15Cb.TabIndex = 15
        Me.H15Cb.Text = "15時"
        Me.H15Cb.UseVisualStyleBackColor = True
        '
        'H14Cb
        '
        Me.H14Cb.AutoSize = True
        Me.H14Cb.Location = New System.Drawing.Point(54, 62)
        Me.H14Cb.Name = "H14Cb"
        Me.H14Cb.Size = New System.Drawing.Size(48, 16)
        Me.H14Cb.TabIndex = 14
        Me.H14Cb.Text = "14時"
        Me.H14Cb.UseVisualStyleBackColor = True
        '
        'H13Cb
        '
        Me.H13Cb.AutoSize = True
        Me.H13Cb.Location = New System.Drawing.Point(54, 40)
        Me.H13Cb.Name = "H13Cb"
        Me.H13Cb.Size = New System.Drawing.Size(48, 16)
        Me.H13Cb.TabIndex = 13
        Me.H13Cb.Text = "13時"
        Me.H13Cb.UseVisualStyleBackColor = True
        '
        'H12Cb
        '
        Me.H12Cb.AutoSize = True
        Me.H12Cb.Location = New System.Drawing.Point(54, 18)
        Me.H12Cb.Name = "H12Cb"
        Me.H12Cb.Size = New System.Drawing.Size(48, 16)
        Me.H12Cb.TabIndex = 12
        Me.H12Cb.Text = "12時"
        Me.H12Cb.UseVisualStyleBackColor = True
        '
        'H11Cb
        '
        Me.H11Cb.AutoSize = True
        Me.H11Cb.Location = New System.Drawing.Point(6, 260)
        Me.H11Cb.Name = "H11Cb"
        Me.H11Cb.Size = New System.Drawing.Size(48, 16)
        Me.H11Cb.TabIndex = 11
        Me.H11Cb.Text = "11時"
        Me.H11Cb.UseVisualStyleBackColor = True
        '
        'H10Cb
        '
        Me.H10Cb.AutoSize = True
        Me.H10Cb.Location = New System.Drawing.Point(6, 238)
        Me.H10Cb.Name = "H10Cb"
        Me.H10Cb.Size = New System.Drawing.Size(48, 16)
        Me.H10Cb.TabIndex = 10
        Me.H10Cb.Text = "10時"
        Me.H10Cb.UseVisualStyleBackColor = True
        '
        'H09Cb
        '
        Me.H09Cb.AutoSize = True
        Me.H09Cb.Location = New System.Drawing.Point(6, 216)
        Me.H09Cb.Name = "H09Cb"
        Me.H09Cb.Size = New System.Drawing.Size(42, 16)
        Me.H09Cb.TabIndex = 9
        Me.H09Cb.Text = "9時"
        Me.H09Cb.UseVisualStyleBackColor = True
        '
        'H08Cb
        '
        Me.H08Cb.AutoSize = True
        Me.H08Cb.Location = New System.Drawing.Point(6, 194)
        Me.H08Cb.Name = "H08Cb"
        Me.H08Cb.Size = New System.Drawing.Size(42, 16)
        Me.H08Cb.TabIndex = 8
        Me.H08Cb.Text = "8時"
        Me.H08Cb.UseVisualStyleBackColor = True
        '
        'H07Cb
        '
        Me.H07Cb.AutoSize = True
        Me.H07Cb.Location = New System.Drawing.Point(6, 172)
        Me.H07Cb.Name = "H07Cb"
        Me.H07Cb.Size = New System.Drawing.Size(42, 16)
        Me.H07Cb.TabIndex = 7
        Me.H07Cb.Text = "7時"
        Me.H07Cb.UseVisualStyleBackColor = True
        '
        'H06Cb
        '
        Me.H06Cb.AutoSize = True
        Me.H06Cb.Checked = True
        Me.H06Cb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.H06Cb.Location = New System.Drawing.Point(6, 150)
        Me.H06Cb.Name = "H06Cb"
        Me.H06Cb.Size = New System.Drawing.Size(42, 16)
        Me.H06Cb.TabIndex = 6
        Me.H06Cb.Text = "6時"
        Me.H06Cb.UseVisualStyleBackColor = True
        '
        'H05Cb
        '
        Me.H05Cb.AutoSize = True
        Me.H05Cb.Location = New System.Drawing.Point(6, 128)
        Me.H05Cb.Name = "H05Cb"
        Me.H05Cb.Size = New System.Drawing.Size(42, 16)
        Me.H05Cb.TabIndex = 5
        Me.H05Cb.Text = "5時"
        Me.H05Cb.UseVisualStyleBackColor = True
        '
        'H04Cb
        '
        Me.H04Cb.AutoSize = True
        Me.H04Cb.Checked = True
        Me.H04Cb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.H04Cb.Location = New System.Drawing.Point(6, 106)
        Me.H04Cb.Name = "H04Cb"
        Me.H04Cb.Size = New System.Drawing.Size(42, 16)
        Me.H04Cb.TabIndex = 4
        Me.H04Cb.Text = "4時"
        Me.H04Cb.UseVisualStyleBackColor = True
        '
        'H03Cb
        '
        Me.H03Cb.AutoSize = True
        Me.H03Cb.Location = New System.Drawing.Point(6, 84)
        Me.H03Cb.Name = "H03Cb"
        Me.H03Cb.Size = New System.Drawing.Size(42, 16)
        Me.H03Cb.TabIndex = 3
        Me.H03Cb.Text = "3時"
        Me.H03Cb.UseVisualStyleBackColor = True
        '
        'H02Cb
        '
        Me.H02Cb.AutoSize = True
        Me.H02Cb.Checked = True
        Me.H02Cb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.H02Cb.Location = New System.Drawing.Point(6, 62)
        Me.H02Cb.Name = "H02Cb"
        Me.H02Cb.Size = New System.Drawing.Size(42, 16)
        Me.H02Cb.TabIndex = 2
        Me.H02Cb.Text = "2時"
        Me.H02Cb.UseVisualStyleBackColor = True
        '
        'H01Cb
        '
        Me.H01Cb.AutoSize = True
        Me.H01Cb.Location = New System.Drawing.Point(6, 40)
        Me.H01Cb.Name = "H01Cb"
        Me.H01Cb.Size = New System.Drawing.Size(42, 16)
        Me.H01Cb.TabIndex = 1
        Me.H01Cb.Text = "1時"
        Me.H01Cb.UseVisualStyleBackColor = True
        '
        'H00Cb
        '
        Me.H00Cb.AutoSize = True
        Me.H00Cb.Checked = True
        Me.H00Cb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.H00Cb.Location = New System.Drawing.Point(6, 18)
        Me.H00Cb.Name = "H00Cb"
        Me.H00Cb.Size = New System.Drawing.Size(42, 16)
        Me.H00Cb.TabIndex = 0
        Me.H00Cb.Text = "0時"
        Me.H00Cb.UseVisualStyleBackColor = True
        '
        'MinimizeBtn
        '
        Me.MinimizeBtn.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.MinimizeBtn.Location = New System.Drawing.Point(32, 182)
        Me.MinimizeBtn.Name = "MinimizeBtn"
        Me.MinimizeBtn.Size = New System.Drawing.Size(176, 94)
        Me.MinimizeBtn.TabIndex = 0
        Me.MinimizeBtn.Text = "最小化"
        Me.MinimizeBtn.UseVisualStyleBackColor = True
        '
        'TimeKeeperTm
        '
        Me.TimeKeeperTm.Enabled = True
        Me.TimeKeeperTm.Interval = 60000
        '
        'TaskTrayNi
        '
        Me.TaskTrayNi.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.TaskTrayNi.BalloonTipText = "通知を無効にするには、このバルーンをクリックしてください。"
        Me.TaskTrayNi.BalloonTipTitle = "まもなくエアコンが止まります"
        Me.TaskTrayNi.ContextMenuStrip = Me.TaskTrayCms
        Me.TaskTrayNi.Icon = CType(resources.GetObject("TaskTrayNi.Icon"), System.Drawing.Icon)
        Me.TaskTrayNi.Text = "AirConNotify"
        Me.TaskTrayNi.Visible = True
        '
        'TaskTrayCms
        '
        Me.TaskTrayCms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VersionTsmi, Me.ToolStripSeparator1, Me.ViewTsmi, Me.StopNotifyTsmi})
        Me.TaskTrayCms.Name = "ContextMenuStrip1"
        Me.TaskTrayCms.Size = New System.Drawing.Size(177, 76)
        '
        'VersionTsmi
        '
        Me.VersionTsmi.Name = "VersionTsmi"
        Me.VersionTsmi.Size = New System.Drawing.Size(176, 22)
        Me.VersionTsmi.Text = "バージョン情報"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(173, 6)
        '
        'ViewTsmi
        '
        Me.ViewTsmi.Enabled = False
        Me.ViewTsmi.Name = "ViewTsmi"
        Me.ViewTsmi.Size = New System.Drawing.Size(176, 22)
        Me.ViewTsmi.Text = "アプリケーションを表示"
        '
        'StopNotifyTsmi
        '
        Me.StopNotifyTsmi.Name = "StopNotifyTsmi"
        Me.StopNotifyTsmi.Size = New System.Drawing.Size(176, 22)
        Me.StopNotifyTsmi.Text = "通知を一時停止"
        '
        'MinuteNud
        '
        Me.MinuteNud.Location = New System.Drawing.Point(12, 292)
        Me.MinuteNud.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.MinuteNud.Name = "MinuteNud"
        Me.MinuteNud.Size = New System.Drawing.Size(35, 19)
        Me.MinuteNud.TabIndex = 30
        '
        'MinuteLbl
        '
        Me.MinuteLbl.AutoSize = True
        Me.MinuteLbl.Location = New System.Drawing.Point(53, 296)
        Me.MinuteLbl.Name = "MinuteLbl"
        Me.MinuteLbl.Size = New System.Drawing.Size(50, 12)
        Me.MinuteLbl.TabIndex = 32
        Me.MinuteLbl.Text = "分に通知"
        '
        'ResetBtn
        '
        Me.ResetBtn.AutoSize = True
        Me.ResetBtn.Location = New System.Drawing.Point(201, 307)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(37, 12)
        Me.ResetBtn.TabIndex = 50
        Me.ResetBtn.TabStop = True
        Me.ResetBtn.Text = "リセット"
        '
        'ExitBtn
        '
        Me.ExitBtn.AutoSize = True
        Me.ExitBtn.Location = New System.Drawing.Point(232, 363)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(29, 12)
        Me.ExitBtn.TabIndex = 103
        Me.ExitBtn.TabStop = True
        Me.ExitBtn.Text = "終了"
        '
        'TestBtn
        '
        Me.TestBtn.AutoSize = True
        Me.TestBtn.Location = New System.Drawing.Point(183, 307)
        Me.TestBtn.Name = "TestBtn"
        Me.TestBtn.Size = New System.Drawing.Size(55, 12)
        Me.TestBtn.TabIndex = 2
        Me.TestBtn.TabStop = True
        Me.TestBtn.Text = "通知テスト"
        '
        'ThanksBtn
        '
        Me.ThanksBtn.AutoSize = True
        Me.ThanksBtn.Location = New System.Drawing.Point(146, 363)
        Me.ThanksBtn.Name = "ThanksBtn"
        Me.ThanksBtn.Size = New System.Drawing.Size(29, 12)
        Me.ThanksBtn.TabIndex = 101
        Me.ThanksBtn.TabStop = True
        Me.ThanksBtn.Text = "謝辞"
        '
        'SoundCb
        '
        Me.SoundCb.AutoSize = True
        Me.SoundCb.Checked = True
        Me.SoundCb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SoundCb.Location = New System.Drawing.Point(118, 215)
        Me.SoundCb.Name = "SoundCb"
        Me.SoundCb.Size = New System.Drawing.Size(61, 16)
        Me.SoundCb.TabIndex = 40
        Me.SoundCb.Text = "サウンド"
        Me.SoundCb.UseVisualStyleBackColor = True
        '
        'UnlockCb
        '
        Me.UnlockCb.AutoSize = True
        Me.UnlockCb.Location = New System.Drawing.Point(118, 237)
        Me.UnlockCb.Name = "UnlockCb"
        Me.UnlockCb.Size = New System.Drawing.Size(117, 16)
        Me.UnlockCb.TabIndex = 41
        Me.UnlockCb.Text = "画面省電力を解除"
        Me.UnlockCb.UseVisualStyleBackColor = True
        '
        'VersionBtn
        '
        Me.VersionBtn.AutoSize = True
        Me.VersionBtn.Location = New System.Drawing.Point(12, 363)
        Me.VersionBtn.Name = "VersionBtn"
        Me.VersionBtn.Size = New System.Drawing.Size(128, 12)
        Me.VersionBtn.TabIndex = 102
        Me.VersionBtn.TabStop = True
        Me.VersionBtn.Text = "バージョン情報/更新確認"
        '
        'MainTc
        '
        Me.MainTc.Controls.Add(Me.MainTp)
        Me.MainTc.Controls.Add(Me.SettingTp)
        Me.MainTc.Location = New System.Drawing.Point(12, 12)
        Me.MainTc.Name = "MainTc"
        Me.MainTc.SelectedIndex = 0
        Me.MainTc.Size = New System.Drawing.Size(249, 348)
        Me.MainTc.TabIndex = 100
        '
        'MainTp
        '
        Me.MainTp.Controls.Add(Me.NotifyTgb)
        Me.MainTp.Controls.Add(Me.MinimizeBtn)
        Me.MainTp.Controls.Add(Me.TestBtn)
        Me.MainTp.Location = New System.Drawing.Point(4, 22)
        Me.MainTp.Name = "MainTp"
        Me.MainTp.Padding = New System.Windows.Forms.Padding(3)
        Me.MainTp.Size = New System.Drawing.Size(241, 322)
        Me.MainTp.TabIndex = 0
        Me.MainTp.Text = "メイン"
        Me.MainTp.UseVisualStyleBackColor = True
        '
        'SettingTp
        '
        Me.SettingTp.Controls.Add(Me.DayStartHourLbl)
        Me.SettingTp.Controls.Add(Me.DayStartHourNud)
        Me.SettingTp.Controls.Add(Me.DayStartLbl)
        Me.SettingTp.Controls.Add(Me.SaveBtn)
        Me.SettingTp.Controls.Add(Me.MinimizeStartCb)
        Me.SettingTp.Controls.Add(Me.TimeGBox)
        Me.SettingTp.Controls.Add(Me.MinuteNud)
        Me.SettingTp.Controls.Add(Me.MinuteLbl)
        Me.SettingTp.Controls.Add(Me.UnlockCb)
        Me.SettingTp.Controls.Add(Me.ResetBtn)
        Me.SettingTp.Controls.Add(Me.SoundCb)
        Me.SettingTp.Location = New System.Drawing.Point(4, 22)
        Me.SettingTp.Name = "SettingTp"
        Me.SettingTp.Padding = New System.Windows.Forms.Padding(3)
        Me.SettingTp.Size = New System.Drawing.Size(241, 322)
        Me.SettingTp.TabIndex = 1
        Me.SettingTp.Text = "設定"
        Me.SettingTp.UseVisualStyleBackColor = True
        '
        'DayStartHourLbl
        '
        Me.DayStartHourLbl.AutoSize = True
        Me.DayStartHourLbl.Location = New System.Drawing.Point(185, 24)
        Me.DayStartHourLbl.Name = "DayStartHourLbl"
        Me.DayStartHourLbl.Size = New System.Drawing.Size(17, 12)
        Me.DayStartHourLbl.TabIndex = 55
        Me.DayStartHourLbl.Text = "時"
        '
        'DayStartHourNud
        '
        Me.DayStartHourNud.Location = New System.Drawing.Point(144, 22)
        Me.DayStartHourNud.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.DayStartHourNud.Name = "DayStartHourNud"
        Me.DayStartHourNud.Size = New System.Drawing.Size(35, 19)
        Me.DayStartHourNud.TabIndex = 54
        Me.DayStartHourNud.Value = New Decimal(New Integer() {7, 0, 0, 0})
        '
        'DayStartLbl
        '
        Me.DayStartLbl.AutoSize = True
        Me.DayStartLbl.Location = New System.Drawing.Point(116, 7)
        Me.DayStartLbl.Name = "DayStartLbl"
        Me.DayStartLbl.Size = New System.Drawing.Size(68, 12)
        Me.DayStartLbl.TabIndex = 53
        Me.DayStartLbl.Text = "一日の始まり"
        '
        'SaveBtn
        '
        Me.SaveBtn.Location = New System.Drawing.Point(118, 281)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(117, 23)
        Me.SaveBtn.TabIndex = 52
        Me.SaveBtn.Text = "設定保存"
        Me.SaveBtn.UseVisualStyleBackColor = True
        Me.SaveBtn.Visible = False
        '
        'MinimizeStartCb
        '
        Me.MinimizeStartCb.AutoSize = True
        Me.MinimizeStartCb.Location = New System.Drawing.Point(118, 259)
        Me.MinimizeStartCb.Name = "MinimizeStartCb"
        Me.MinimizeStartCb.Size = New System.Drawing.Size(102, 16)
        Me.MinimizeStartCb.TabIndex = 51
        Me.MinimizeStartCb.Text = "最小化して起動"
        Me.MinimizeStartCb.UseVisualStyleBackColor = True
        Me.MinimizeStartCb.Visible = False
        '
        'AirConNotify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 380)
        Me.ControlBox = False
        Me.Controls.Add(Me.MainTc)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.VersionBtn)
        Me.Controls.Add(Me.ThanksBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AirConNotify"
        Me.Text = "AirConNotify"
        Me.TimeGBox.ResumeLayout(False)
        Me.TimeGBox.PerformLayout()
        Me.TaskTrayCms.ResumeLayout(False)
        CType(Me.MinuteNud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainTc.ResumeLayout(False)
        Me.MainTp.ResumeLayout(False)
        Me.MainTp.PerformLayout()
        Me.SettingTp.ResumeLayout(False)
        Me.SettingTp.PerformLayout()
        CType(Me.DayStartHourNud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NotifyTgb As CheckBox
    Friend WithEvents TimeGBox As GroupBox
    Friend WithEvents H23Cb As CheckBox
    Friend WithEvents H22Cb As CheckBox
    Friend WithEvents H21Cb As CheckBox
    Friend WithEvents H20Cb As CheckBox
    Friend WithEvents H19Cb As CheckBox
    Friend WithEvents H18Cb As CheckBox
    Friend WithEvents H17Cb As CheckBox
    Friend WithEvents H16Cb As CheckBox
    Friend WithEvents H15Cb As CheckBox
    Friend WithEvents H14Cb As CheckBox
    Friend WithEvents H13Cb As CheckBox
    Friend WithEvents H12Cb As CheckBox
    Friend WithEvents H11Cb As CheckBox
    Friend WithEvents H10Cb As CheckBox
    Friend WithEvents H09Cb As CheckBox
    Friend WithEvents H08Cb As CheckBox
    Friend WithEvents H07Cb As CheckBox
    Friend WithEvents H06Cb As CheckBox
    Friend WithEvents H05Cb As CheckBox
    Friend WithEvents H04Cb As CheckBox
    Friend WithEvents H03Cb As CheckBox
    Friend WithEvents H02Cb As CheckBox
    Friend WithEvents H01Cb As CheckBox
    Friend WithEvents H00Cb As CheckBox
    Friend WithEvents MinimizeBtn As Button
    Friend WithEvents TimeKeeperTm As Timer
    Friend WithEvents TaskTrayNi As NotifyIcon
    Friend WithEvents MinuteNud As NumericUpDown
    Friend WithEvents MinuteLbl As Label
    Friend WithEvents ResetBtn As LinkLabel
    Friend WithEvents ExitBtn As LinkLabel
    Friend WithEvents TestBtn As LinkLabel
    Friend WithEvents ThanksBtn As LinkLabel
    Friend WithEvents SoundCb As CheckBox
    Friend WithEvents UnlockCb As CheckBox
    Friend WithEvents VersionBtn As LinkLabel
    Friend WithEvents TaskTrayCms As ContextMenuStrip
    Friend WithEvents ViewTsmi As ToolStripMenuItem
    Friend WithEvents StopNotifyTsmi As ToolStripMenuItem
    Friend WithEvents VersionTsmi As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents MainTc As TabControl
    Friend WithEvents MainTp As TabPage
    Friend WithEvents SettingTp As TabPage
    Friend WithEvents DayStartHourLbl As Label
    Friend WithEvents DayStartHourNud As NumericUpDown
    Friend WithEvents DayStartLbl As Label
    Friend WithEvents SaveBtn As Button
    Friend WithEvents MinimizeStartCb As CheckBox
End Class
