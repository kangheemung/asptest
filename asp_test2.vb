' プログラム・コード内で次のような記述をしてもスクリプトをページに埋め込むことができる。

Response.Write("<script language=JavaScript> alert('クライアント') </script>")

' しかし、Response.Writeメソッドによる出力は、ページの先頭（<html>要素よりもさらに前）に埋め込まれる。これはHTMLとしては正しくないため、予期せぬ誤動作を招くことがあり（スマート・ナビゲーションの使用時など）、この方法は極力使用すべきでない。

'ASP.NET Web Forms	ドラッグ＆ドロップ配置でアプリ開発ができるフレームワーク
'ASP.NET MVC	モデル、ビュー、コントローラのMVCを採用したフレームワーク
'ASP.NET Core	クラウドベースのアプリケーション開発に特化したフレームワーク
'ASP.NET Web API	HTTPサーバーを構築できるフレームワーク
'数多くのフレームワークが次々とリリースされる現代でも、ASP.NETは業務用Webアプリケーションのフレームワークとして柔軟に対応し、開発の現場で活躍しています。この汎用性の高さは、内部に搭載される機能が細分化され一つのフレームワークの中に複数の機能が搭載されているためです。ただし.NETのバージョンによっては、一部の機能が搭載されていないこともあります。またASP.NET（.NET Framework）は開発によってフレームワークを使い分けられるという利点がある反面、熟練したエンジニアでなければすべての機能を使いこなすことが難しいという特徴もあります。
'Creating an ASP View with Buttons and Select Control
'Create a New Web Forms Project:

'Open Visual Studio.
'Select "File" -> "New" -> "Project."
'Choose "ASP.NET Web Forms Application" template and give your project a name.
'Design the ASP View:

'Open the .aspx file (e.g., Default.aspx) from the Solution Explorer.
'Design your view by adding controls inside the <form> tag.
'To add a button:
<asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
'To add a select (dropdown) control:
<asp:DropDownList ID="ddlOptions" runat="server">
    <asp:ListItem Text="Option 1" Value="1"></asp:ListItem>
    <asp:ListItem Text="Option 2" Value="2"></asp:ListItem>
    <!-- Add more ListItem elements as needed -->
</asp:DropDownList>

'Code-Behind in VB.NET:
'Implement event handlers for the button click event and other necessary logic:
Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
    ' Handle button click event
    Dim selectedValue As String = ddlOptions.SelectedValue
    ' Perform actions based on the selected value
End Sub

'Text (テキストボックス):


'テキストボックスを作成するには、次のようにします:
<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
'ID属性はコードビハインドからこのテキストボックスを参照するために使われます。
'TextArea (テキストエリア):
'<asp:TextBox ID="txtComments" runat="server" TextMode="MultiLine" Rows="4"></asp:TextBox>
'TextMode="MultiLine"は、これがテキストエリアであることを示します。
'Rows属性は表示される行数を指定します。
'テーマ (Themes):

'ASP.NET Web Formsには、テーマを使用して一括してスタイルを適用する機能があります。
'テーマを使用すると、複数のコントロールに同じ外観を適用することができます。
'マスターページ (Master Pages):

'マスターページを使用すると、共通のレイアウトやデザインを定義し、複数のコンテンツページで再利用することができます。
'マスターページは全てのページに共通のヘッダーやフッターなどを統一的に適用するのに便利です。
'Web.config ファイル内で、<pages>
<pages theme="MyTheme"></pages>
'コントロールへのテーマの適用:
<asp:Button runat="server" Text="Click Me" Theme="MyTheme" />
'ビルドと確認:

'ビルドしてページを表示し、テーマが正しく適用されているか確認します。
'テーマを取得:

'Visual Basic にはデフォルトでテーマ機能が備わっていないため、外部のライブラリやコントロールを使用する必要があります。例えば、VisualBasicPowerPacks ライブラリを使用して書かれたコードを取得しましょう。

' 必要な名前空間をインポートする
Imports Microsoft.VisualBasic.PowerPacks

Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ' テーマを作成し、フォームに適用する
    Dim theme As New ShapeContainer
    Me.Controls.Add(theme)
    
    Dim rectangle As New RectangleShape
    With rectangle
        .Size = New Size(800, 50) ' サイズを指定
        .Location = New Point(0, 0) ' 位置を指定
        .BorderStyle = DashStyle.Solid ' 枠線スタイルを指定
        .BorderColor = Color.Blue ' 枠線の色を指定
        .FillColor = Color.LightBlue ' 背景色を指定
    End With
    
    theme.Shapes.Add(rectangle)
End Sub
'ビルドと確認:

'プロジェクトをビルドし、フォームが正しくテーマ化されていることを確認します。