Public Class Form1

    ' Função que ordena as arrays
    Public Function sortNumberAndStars(ByVal listNumbers() As Integer) As Integer()
        ' Orderna a array
        Array.Sort(listNumbers)
        ' Devolve a array ordenanda
        Return listNumbers
    End Function

    ' Procedimento que imprime os numeros da chave
    Public Sub printNumbers(ByVal numbers() As Integer)
        ' atribui numeros ordenados
        txtOutputUm.Text = numbers(0)
        txtOutputDois.Text = numbers(1)
        txtOutputTres.Text = numbers(2)
        txtOutputQuatro.Text = numbers(3)
        txtOutputCinco.Text = numbers(4)
    End Sub

    ' Procedimento que imprime os numeros da chave
    Public Sub printStars(ByVal stars() As Integer)
        ' atribui numeros ordenados
        txtOutputStarUm.Text = stars(0)
        txtOutputStarDois.Text = stars(1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Declaracao das arrays de numeros e  das estrelas
        Dim numbers = New Integer() {10, 20, 5, 15, 3}
        Dim stars = New Integer() {10, 1}


        ' Obtem os numeros da Chave
        numbers(0) = txtNumeroUm.Text
        numbers(1) = txtNumeroDois.Text
        numbers(2) = txtNumeroTres.Text
        numbers(3) = txtNumeroQuatro.Text
        numbers(4) = txtNumeroCinco.Text

        ' Obtem as estrelas da chave
        stars(0) = txtEstrelaUm.Text
        stars(1) = txtEstrelaDois.Text

        ' Invoca a funcao para ordenar a Array dos numeros 
        numbers = sortNumberAndStars(numbers)

        txtNumeroUm.Text = numbers(0)
        txtNumeroDois.Text = numbers(1)

        ' Imprime Números da chave nas respetivas caixas de texto
        printNumbers(numbers)

        ' Invoca a funcao para ordenar a Array das estrelas 
        stars = sortNumberAndStars(stars)

        ' Imprime estrelas da chave nas respetivas caixas de texto
        printStars(stars)

    End Sub


End Class
