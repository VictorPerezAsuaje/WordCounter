<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ContadorDePalabras.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Word Counter</title>

    <link href="Style.css" rel="stylesheet" />

    <script type="text/javascript">
        

    </script>
</head>
<body>
    <header id="mainHeader">
        <div class="container">
            <h1>Word counter online</h1>
        </div>
        <nav id="mainNav">
            <div class="container">
                <ul>
                    <li><a href="index.aspx">Contador palabras</a></li>
                    <li><a href="https://www.victorperezasuaje.com/portfolio" target="_blank">Portfolio</a></li>
                    <li><a href="about.aspx">About</a></li>
                </ul>
            </div>
        </nav>
    </header>
    <main>
        <form id="form1" runat="server">
        <div>
            <br />
        </div>
        <div class="container">
            <asp:TextBox ID="TxtBox" runat="server" CssClass ="text-box" TextMode="MultiLine" EnableTheming="False"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="SubmitBtn" runat="server" OnClick="SubmitBtn_Click" Text="Submit"/>
            <br />
            <br />
            <asp:Label ID="WordsLbl" runat="server" Text="Word number: "></asp:Label>
            <br />
            <br />
            <asp:Label ID="CharLbl" runat="server" Text="Char number: "></asp:Label>
            <br />
            <br />
            <asp:Label ID="CharLblWS" runat="server" Text="Char number without spaces: "></asp:Label>
            <br />
            <br />
            <hr />
            <p><i>This website has been developed by Victor Pérez Asuaje to help you count the number of words, characters and
                characters without spaces in your text </i></p>
            </div>
           
        </form>
    </main>    
    <footer id="mainFooter">
        <p> Copyright &copy 2020. Victor Pérez Asuaje</p>
    </footer>
</body>
</html>
