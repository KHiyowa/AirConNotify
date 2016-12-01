Public Class AirConNotify
    Private player As System.Media.SoundPlayer = Nothing
    Const TEST As Integer = 24
    Const DAYSTART As Integer = 6
#Region "UI関連"

    ' 省電力解除ボタン
    Private Sub UnlockCb_CheckedChanged(sender As Object, e As EventArgs) Handles UnlockCb.CheckedChanged
        If UnlockCb.Checked = True Then
            MinuteNud.Minimum = 1
        Else
            MinuteNud.Minimum = 0
        End If
    End Sub

    ' テストボタン
    Private Sub TestBtn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TestBtn.LinkClicked
        ExeNotify(TEST)
    End Sub

    ' リセットボタン
    Private Sub ResetBtn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ResetBtn.LinkClicked
        Reset()
    End Sub

    ' バージョンボタン
    Private Sub VersionBtn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles VersionBtn.LinkClicked
        MsgBox(Me.ProductVersion)
    End Sub

    ' 謝辞ボタン
    Private Sub ThanksBtn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ThanksBtn.LinkClicked
        MsgBox("プログラムアイコン: http://icon-rainbow.com 様")
    End Sub

    ' 終了ボタン
    Private Sub ExitBtn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ExitBtn.LinkClicked
        Me.Close()
    End Sub

    ' 一時停止ボタン
    Private Sub NotifyTgb_CheckedChanged(sender As Object, e As EventArgs) Handles NotifyTgb.CheckedChanged
        If NotifyTgb.Checked = True Then
            NotifyTgb.Text = "通知を一時停止"
        Else
            Dim Res As MsgBoxResult = MsgBox("次の " + CType(DAYSTART, String) + " 時まで通知を無効にしますか?", vbYesNo)
            If Res = vbNo Then
                NotifyTgb.Checked = True
                Exit Sub
            End If
            NotifyTgb.Text = "通知を有効にする"
        End If
    End Sub

    ' 最小化ボタン
    Private Sub MinimizeBtn_Click(sender As Object, e As EventArgs) Handles MinimizeBtn.Click
        Me.ShowInTaskbar = False
        Me.Visible = False
    End Sub

    ' タスクトレイアイコン関連
    Private Sub TaskTrayNi_DoubleClick(sender As Object, e As EventArgs) Handles TaskTrayNi.DoubleClick
        Me.ShowInTaskbar = True
        Me.Visible = True
    End Sub

#End Region

#Region "プログラム"

    ' 時刻の監視
    Private Sub TimeKeeperTm_Tick(sender As Object, e As EventArgs) Handles TimeKeeperTm.Tick
        Dim dtNow As DateTime = DateTime.Now
        Dim iHour As Integer = dtNow.Hour
        Dim iMinute As Integer = dtNow.Minute

        ' 通知が有効で、画面ロック解除が有効で、設定した時分の1分前だったら画面ロック解除を実行
        If NotifyTgb.Checked And UnlockCb.Checked And
            iMinute = MinuteNud.Value - 1 And CheckState(iHour) Then
            PowerOnMonitor()
        End If

        ' 通知が有効で、設定した時分だったら通知を実行
        If NotifyTgb.Checked And
            iMinute = MinuteNud.Value And CheckState(iHour) Then
            ExeNotify(iHour)
        End If

        ' 通知が無効で、1日の始まりの時刻だったら通知を再有効化
        If NotifyTgb.Checked = False And
                iMinute = MinuteNud.Value And CheckState(DAYSTART) Then
            NotifyTgb.Checked = True
        End If
    End Sub

    ' 画面省電力を解除する(モニタにスピーカーがついている環境向け)
    Private Sub PowerOnMonitor()
        SendKeys.Send("+")
    End Sub

    ' 通知を実行する
    Private Sub ExeNotify(t As Integer)
        ' 通知を表示
        TaskTrayNi.ShowBalloonTip(60)

        ' サウンドを再生
        If SoundCb.Checked = True Then PlaySound(CType(t, String) + ".wav")
    End Sub

    ' サウンド再生
    Private Sub PlaySound(WaveFile As String)
        WaveFile = "wav\" + WaveFile

        '読み込む
        If IO.File.Exists(WaveFile) Then
            player = New System.Media.SoundPlayer(WaveFile)
        ElseIf IO.File.Exists("wav\default.wav") Then
            player = New System.Media.SoundPlayer("wav\default.wav")
        Else
            Exit Sub
        End If

        '非同期再生する
        player.Play()
    End Sub

    ' 指定した時刻にチェックが入っているか調べる
    Private Function CheckState(t As Integer)
        For Each item As Control In TimeGBox.Controls
            If CType(CType(item, CheckBox).Name.Substring(1, 2), Integer) = t Then Return True
        Next
        Return False
    End Function

    ' 初期設定にリセットする
    Private Sub Reset()
        Dim Res As MsgBoxResult = MsgBox("リセットしますか?", vbYesNo)
        If Res = vbNo Then Exit Sub

        For Each item As Control In TimeGBox.Controls
            If item.GetType() = GetType(CheckBox) Then
                CType(item, CheckBox).Checked = False
            End If
        Next

        H00Cb.Checked = True
        H02Cb.Checked = True
        H04Cb.Checked = True
        H06Cb.Checked = True
        H21Cb.Checked = True
        H22Cb.Checked = True
        H23Cb.Checked = True
    End Sub

#End Region
End Class
