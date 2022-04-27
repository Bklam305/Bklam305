Public Class Bank
    Public Property nickels As Integer
    Public Property dimes As Integer
    Public Property quarter As Integer
    Public Property reeses As Integer
    Public Property milky As Integer
    Public Property twix As Integer
    Public Property cool As Integer
    Public Property garden As Integer
    Public Property nacho As Integer
    Public Property lays As Integer
    Public Property cheetos As Integer
    Public Property green As Integer
    Dim m_total As Decimal
    Public ReadOnly Property total As Decimal
        Get
            Return m_total
        End Get
    End Property
    Public ReadOnly Property contents As String
        Get
            Return "Reese's: " & reeses & " Milky Ways: " & milky & " Twix: " & twix & " Cool Ranch: " & cool & " Garden Salsa: " & garden & " Nacho Cheese: " & nacho & " Lays: " & lays & " Cheetos: " & cheetos & "Sour Cream & Onion" & green
        End Get
    End Property
    Public Sub restock()
        nickels = 0
        dimes = 0
        quarter = 0
        fi
    End Sub
    Public Function Buy(amount As Decimal, item As Integer) As Boolean
        If item = 1 Then
            If reeses > 0 And m_total >= amount Then
                m_total -= amount
                reeses -= 1
                Return True
            End If
        End If
        If item = 2 Then
            If milky > 0 And m_total >= amount Then
                m_total -= amount
                milky -= 1
                Return True
            End If
        End If
        If item = 3 Then
            If twix > 0 And m_total >= amount Then
                m_total -= amount
                twix -= 1
                Return True
            End If
        End If
        If item = 4 Then
            If cool > 0 And m_total >= amount Then
                m_total -= amount
                cool -= 1
                Return True
            End If
        End If
        If item = 5 Then
            If garden > 0 And m_total >= amount Then
                m_total -= amount
                garden -= 1
                Return True
            End If
        End If
        If item = 6 Then
            If nacho > 0 And m_total >= amount Then '
                m_total -= amount
                nacho -= 1
                Return True
            End If
        End If
        If item = 7 Then
            If lays > 0 And m_total >= amount Then
                m_total -= amount
                lays -= 1
                Return True
            End If
        End If
        If item = 8 Then
            If cheetos > 0 And m_total >= amount Then
                m_total -= amount
                cheetos -= 1
                Return True
            End If
        End If
        If item = 9 Then
            If green > 0 And m_total >= amount Then
                m_total -= amount
                green -= 1
                Return True
            End If
        End If
        Return False
    End Function
    Public Sub addNickel()
        nickels = nickels + 1
        m_total = m_total + 0.05
    End Sub
    Public Sub addDime()
        dimes += 1
        m_total = m_total + 0.1
    End Sub
    Public Sub addQuarter()
        quarter += 1
        m_total = m_total + 0.25
    End Sub
    Public Sub addfifty()
        m_total = m_total + 0.5
    End Sub
    Public Sub addDollar()
        m_total = m_total + 1
    End Sub
    Public Function subtract(inventory As Decimal) As Boolean

    End Function
End Class
End Class
