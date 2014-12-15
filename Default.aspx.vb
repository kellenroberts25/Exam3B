Imports System.Threading
Imports System.Globalization
Partial Class _Default
    Inherits System.Web.UI.Page
    Protected Overrides Sub InitializeCulture()

        Dim SelectedLanguage As String = Request.Form("LangDropdown")

        If Request.Form("LangDropdown") IsNot Nothing Or SelectedLanguage <> "" Then

            UICulture = Request.Form("LangDropdown")
            Culture = Request.Form("LangDropdown")

            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(SelectedLanguage)
            Thread.CurrentThread.CurrentUICulture = New CultureInfo(SelectedLanguage)

        End If

        Dim ChangedLanguage As String = Request.Form("ChangeLangDropdown")

        If Request.Form("ChangeLangDropdown") IsNot Nothing Or ChangedLanguage <> "" Then

            UICulture = Request.Form("ChangeLangDropdown")
            Culture = Request.Form("ChangeLangDropdown")

            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(ChangedLanguage)
            Thread.CurrentThread.CurrentUICulture = New CultureInfo(ChangedLanguage)

        End If

    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        NameTbx.Focus()

        'Hide results elements
        HelloLbl.Visible = False
        SexLbl.Visible = False
        NameResultsLbl.Visible = False
        GraduationResultLbl.Visible = False
        HopeLbl.Visible = False
        EarningsResultLbl.Visible = False
        currencyLbl.Visible = False
        GradDateLbl.Visible = False
        ChangeLangDropdown.Visible = False
        EarningsEndingLbl.Visible = False
        VisitLbl.Visible = False
        GitHubHperlink.Visible = False

    End Sub

    Protected Sub Submitbtn_Click(sender As Object, e As EventArgs) Handles Submitbtn.Click

        'Unhide elements and hide other elements
        HelloLbl.Visible = True
        SexLbl.Visible = True
        NameResultsLbl.Visible = True
        GradDateLbl.Visible = True
        GraduationResultLbl.Visible = True
        HopeLbl.Visible = True
        currencyLbl.Visible = True
        EarningsResultLbl.Visible = True
        EarningsEndingLbl.Visible = True
        ChangeLangDropdown.Visible = True
        VisitLbl.Visible = True
        GitHubHperlink.Visible = True

        Namelbl.Visible = False
        NameTbx.Visible = False
        Genderlbl.Visible = False
        MaleFemaleRb.Visible = False
        Graduationlbl.Visible = False
        Calendar.Visible = False
        Earningslbl.Visible = False
        Earningstbx.Visible = False
        LangDropdown.Visible = False
        Submitbtn.Visible = False

        'Male/Female Button selections
        Dim choice As String = ""

        If MaleFemaleRb.SelectedIndex = 0 Then
            choice = "Ms."
        ElseIf MaleFemaleRb.SelectedIndex = 1 Then
            choice = "Mr."

        End If

        SexLbl.Text = choice

        'Populate Name Label with name
        Dim name As String = NameTbx.Text
        NameResultsLbl.Text = name

        'Sending date data from calendar to label
        Dim dateSelected As Date = Calendar.SelectedDate
        GradDateLbl.Text = dateSelected.ToString("MMMM dd, yyyy")

        'Convert the earnings textbox to currency format
        Dim earnings As Decimal = Earningstbx.Text
        EarningsResultLbl.Text = String.Format("{0:n}", earnings)

    End Sub

    Protected Sub ChangeLangDropdown_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ChangeLangDropdown.SelectedIndexChanged
        'Unhide elements and hide other elements
        HelloLbl.Visible = True
        SexLbl.Visible = True
        NameResultsLbl.Visible = True
        GradDateLbl.Visible = True
        GraduationResultLbl.Visible = True
        HopeLbl.Visible = True
        currencyLbl.Visible = True
        EarningsResultLbl.Visible = True
        EarningsEndingLbl.Visible = True
        ChangeLangDropdown.Visible = True
        VisitLbl.Visible = True
        GitHubHperlink.Visible = True

        Namelbl.Visible = False
        NameTbx.Visible = False
        Genderlbl.Visible = False
        MaleFemaleRb.Visible = False
        Graduationlbl.Visible = False
        Calendar.Visible = False
        Earningslbl.Visible = False
        Earningstbx.Visible = False
        LangDropdown.Visible = False
        Submitbtn.Visible = False

        'Male/Femail Button selections
        Dim choice As String = ""

        If MaleFemaleRb.SelectedIndex = 0 Then
            choice = "Ms."
        ElseIf MaleFemaleRb.SelectedIndex = 1 Then
            choice = "Mr."

        End If

        SexLbl.Text = choice

        'Populate Name Label with name
        Dim name As String = NameTbx.Text
        NameResultsLbl.Text = name

        'Sending date data from calendar to label
        Dim dateSelected As Date = Calendar.SelectedDate
        GradDateLbl.Text = dateSelected.ToString("MMMM dd, yyyy")

        'Convert the earnings textbox to currency format
        Dim earnings As Decimal = Earningstbx.Text
        EarningsResultLbl.Text = String.Format("{0:n}", earnings)
    End Sub
End Class
