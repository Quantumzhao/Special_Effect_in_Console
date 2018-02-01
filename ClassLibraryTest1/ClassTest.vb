Public Class WordAppearOneByOne

    Private PrintedSentence As String = ""

    Public Sub DrawSentence(Sentence As String)

        Dim SentenceArray(Len(Sentence)) As Char

        For i = 0 To Len(Sentence) - 1

            If i <> 0 Then
                PrintedSentence = PrintedSentence & SentenceArray(i - 1)
            End If

            SentenceArray(i) = Mid(Sentence, i + 1, 1)

            DrawCharacter(SentenceArray(i))

        Next

    End Sub

    Private Sub DrawCharacter(Letter As Char)

        Dim Ascii As Integer = Asc(Letter)

        For i As Integer = Asc("0") To Asc("z")

            Console.Clear()
            Console.Write(PrintedSentence & Chr(i))
            Console.ReadKey()

            If i = Ascii Then

                Exit For

            End If

        Next

    End Sub

End Class

Public Class LetterAppearTogether

    Public Sub DrawSentence(Sentence As String, Times As Integer)

        Dim OutputString As String = ""
        Dim SentenceArray(Len(Sentence) - 1) As String

        For index = 1 To Times

            For i = 0 To Len(Sentence) - 1

                SentenceArray(i) = Mid(Sentence, i + 1, 1)

            Next

            For i = 0 To Len(Sentence) - 1

                OutputString = OutputString & SentenceArray(SelectRandomNumber(Len(Sentence)))

            Next

            If index = Times Then

                OutputString = Sentence

            End If

            Console.Clear()
            Console.WriteLine(OutputString)
            OutputString = ""
            Console.ReadKey()

        Next index

    End Sub

    Private Function SelectRandomNumber(Number As Integer) As Integer

        VBMath.Randomize()

        Dim RandomNumber As Double = VBMath.Rnd()
        Dim DivisionArray(Number) As Double

        For i = Number To 1 Step -1

            DivisionArray(i - 1) = i / Number

        Next

        DivisionArray(Number) = 1

        For i = 0 To Number - 1

            If RandomNumber > DivisionArray(i) And RandomNumber < DivisionArray(i + 1) Then

                SelectRandomNumber = i + 1
                Exit For

            End If

        Next

    End Function

End Class

