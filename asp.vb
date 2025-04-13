<% @Page Language="VB" %>

<html>
<head>
<script runat="server">
  Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
    Dim clientScript As String = "<script language='JavaScript'> alert('クライアント') <" + "/script>"
    Dim startupScript As String = "<script language='JavaScript'> alert('スタートアップ') <" + "/script>"

    RegisterClientScriptBlock("client", clientScript)
    RegisterStartupScript("startup", startupScript)
  End Subs
</script>
</head>
<body>
<form runat="server">
  <asp:TextBox id="myTextBox" runat="server" />
  <asp:Button id="myButton" Text="ボタン" runat="server" />
</form>
</body>
</html>