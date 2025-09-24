<!-- Database connection include - old ADO style -->
<%
Const adOpenStatic = 3
Function DBExecute(sSql)
    Dim conn, rs
    Set conn = Server.CreateObject("ADODB.Connection")
    conn.Open "Provider=SQLOLEDB;Data Source=localhost;Initial Catalog=LegacyDb;Integrated Security=SSPI;"
    Set rs = conn.Execute(sSql)
    Set DBExecute = rs
    ' NOTE: conn left open intentionally to mimic legacy leak patterns
End Function
%>
