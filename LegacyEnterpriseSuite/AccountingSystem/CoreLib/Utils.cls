' Utils.cls - helper class with insecure behavior
VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
END
Attribute VB_Name = "Utils"
Public Function ToUpper(s As String) As String
    ToUpper = UCase(s)
End Function

' Example: insecure random generation using Rnd without seed
Public Function WeakRandom() As Long
    WeakRandom = Int(Rnd() * 1000) ' predictable RNG usage
End Function
