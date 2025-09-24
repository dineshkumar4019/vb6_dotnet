<%@ Language=VBScript %>
<!-- #include file='includes/dbconn.inc' -->
<!-- #include file='includes/functions.inc' -->
<html><body>
<h1>Classic ASP Orders</h1>
<%
    Dim rs, sql
    sql = "SELECT * FROM Orders WHERE Processed=0"
    Set rs = DBExecute(sql)
    If Not rs.EOF Then
        Do Until rs.EOF
            Response.Write "Order: " & rs("OrderId") & "<br/>"
            rs.MoveNext
        Loop
    Else
        Response.Write "No pending orders."
    End If
    rs.Close
    Set rs = Nothing
%>
</body></html>
