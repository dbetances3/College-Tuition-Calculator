' Program:      College Tuition Calculator App
' Developer:    Diana Betances
' Date:         December 17, 2016
' Purpose:      This Windows Store app displays a splash screen briefly. An app page opens in which
'               the user enters a number of credit hours and whether he is a state resident. The tuition
'               for the semester is displayed.

Option Strict On

' The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

''' <summary>
''' A basic page that provides characteristics common to most applications.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Common.LayoutAwarePage

        ''' <summary>
        ''' Populates the page with content passed during navigation.  Any saved state is also
        ''' provided when recreating a page from a prior session.
        ''' </summary>
        ''' <param name="navigationParameter">The parameter value passed to
        ''' <see cref="Frame.Navigate"/> when this page was initially requested.
        ''' </param>
        ''' <param name="pageState">A dictionary of state preserved by this page during an earlier
        ''' session.  This will be null the first time a page is visited.</param>
        Protected Overrides Sub LoadState(navigationParameter As Object, pageState As Dictionary(Of String, Object))

        End Sub

        ''' <summary>
        ''' Preserves state associated with this page in case the application is suspended or the
        ''' page is discarded from the navigation cache.  Values must conform to the serialization
        ''' requirements of <see cref="Common.SuspensionManager.SessionState"/>.
        ''' </summary>
        ''' <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        Protected Overrides Sub SaveState(pageState As Dictionary(Of String, Object))

        End Sub

    Private Sub btnCompute_Click(sender As Object, e As RoutedEventArgs) Handles btnCompute.Click
        ' Declaration of app variables
        Dim intCreditHours As Integer
        Dim intStateSelection As Integer
        Dim decTuitionPerCreditHour As Decimal
        Dim decTuitionTotal As Decimal

        ' Assign the user's input to the variables
        intCreditHours = Convert.ToInt32(txtCredits.Text)
        intStateSelection = cboState.SelectedIndex

        ' Assign thestate

        Select Case intStateSelection
            Case 0                                      ' In-State students Cost is cheaper
                decTuitionPerCreditHour = 168.33D
            Case 1                                      ' Out-of-State student cost is more expensive
                decTuitionPerCreditHour = 304.77D
        End Select

        ' Compute and display the cost of tuition
        decTuitionTotal = intCreditHours * decTuitionPerCreditHour
        lblResult.Text = "Semester Tuition: " & decTuitionTotal.ToString("C2")

    End Sub
End Class
