Public Class Class_coding

    Sub switchpanel(ByVal panelfirst As Panel, ByVal panelsecende As Form, xtt As Form)
        panelfirst.Controls.Clear()

        panelsecende.TopLevel = False
        panelfirst.Controls.Add(panelsecende)
        panelsecende.Show()
        xtt.Text = panelsecende.Text
        panelfirst.Size = panelsecende.Size

    End Sub





End Class
