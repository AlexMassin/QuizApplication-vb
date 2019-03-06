Public Class DataManagement


    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        Static counter As Integer = 0

        If radD.Checked = True And counter = 0 Then
            counter += 1
            picCharacter.Image = My.Resources.changing
            picInformation.Image = My.Resources.wardrobe
            Me.lblStory.Text = "Once he is done getting refreshed, he heads to his closet to pick out the best clothes for him to wear. For some reason the first day is a casual day so his options are increased drastically. If he picks a shirt and pants at random, what is the probability of him getting a black shirt and red pants?"
            radA.Text = "1/6"
            radB.Text = "1/9"
            radC.Text = "1/3 + 1/3"
            radD.Text = "6C2/6C2"

        ElseIf radC.Checked = True And counter = 1 Then
            counter += 1
            Me.lblStory.Text = "By the time Alex chooses his wardrobe it’s already 8:30!! Alex needs to find out how many ways he can get to school so he can make it on time. The map below shows the ways he can get to school. How many ways can Alex travel to school to reach there by 8:45?"
            Me.picInformation.Image = My.Resources.unansweredMap
            Me.picCharacter.Image = My.Resources.running
            radA.Text = "10"
            radB.Text = "12"
            radC.Text = "35"
            radD.Text = "5"


        ElseIf radC.Checked = True And counter = 2 Then
            counter += 1
            Me.lblStory.Text = "Alex arrives just on time. Since it is the first day of school he needs to get gather his agenda and schedule. What is the probability that his favourite teachers Mr.Kim and Mr.V will be his homeroom teachers? There are 18 teachers that could possibly be his homeroom teachers."
            radA.Text = "1/18"
            radB.Text = "1/390"
            radC.Text = "1/153"
            radD.Text = "2/152"
            Me.picCharacter.Image = My.Resources.teacher
            Me.picInformation.Image = Nothing

        ElseIf radC.Checked = True And counter = 3 Then
            counter += 1
            Me.lblStory.Text = "In Alex's first class, English, he is handed a diagnostic test that consists of 8 multiple choice questions each with 4 options. If Alex guesses every question, what is the probability he gets them all correct?"
            Me.radA.Text = "1/65536"
            Me.radB.Text = "1^8"
            Me.radC.Text = "4096"
            Me.radD.Text = "None of the above"
            Me.picCharacter.Image = My.Resources.test

        ElseIf radA.Checked = True And counter = 4 Then
            counter += 1
            Me.lblStory.Text = "Since Alex is only taking seven courses, he has a second period spare. Alex wants to find out how many people have the same spare as him. In that block there are 30 Chemistry and  10 World Issues. The school's system screwed up and made it show that 3 people are taking both subjects. The total number of students is 46. How many people have the same spare as Alex? Hint: Use the venn diagram below. "
            radA.Text = "6"
            radB.Text = "7"
            radC.Text = "10"
            radD.Text = "None of the above"
            Me.picCharacter.Image = My.Resources.thinking1
            Me.picInformation.Image = My.Resources.vennUnanswered
        ElseIf radD.Checked = True And counter = 5 Then
            counter += 1
            Me.lblStory.Text = "Finally lunch time!! Alex has been starving all day. He brought $4 which is enough for a burger at the cafe in school. There seems to be a variety of toppings he can put on his burger. Below is a list that contains everything he can possibly put on his burger. If Alex wants at most 4 ingredients on his burger, how many different burgers can he order?"
            Me.picCharacter.Image = My.Resources.lunch
            Me.picInformation.Image = My.Resources.lunchIngredients
            radA.Text = "5620"
            radB.Text = "562"
            radC.Text = "98"
            radD.Text = "32942250"
        ElseIf radB.Checked = True And counter = 6 Then
            counter += 1
            Me.lblStory.Text = "Since Alex works at Extended Care, Mrs.Douthwright has made it so he works 8 times this month. If she chose his work days at random, what is the probability of him working on the first day he comes back?"
            radA.Text = "4.237x10^-12"
            radB.Text = "1/6720"
            radC.Text = "1.968x10^-10"
            radD.Text = "None of the above"
            Me.picCharacter.Image = My.Resources.working
            Me.picInformation.Image = Nothing

        ElseIf radC.Checked = True And counter = 7 Then
            counter += 1
            Me.lblStory.Text = "On his last period spare, Alex sees Tony and Michael playing with a dice and a coin. If Tony rolls an even number on the dice and gets heads on the coin he wins. If Michael rolls an odd number on the dice and gets tails on the coin he wins. What is the odds in favour of Tony winning?"
            radA.Text = "1:4"
            radB.Text = "4:1"
            radC.Text = "1:2"
            radD.Text = "2:1"
            Me.picCharacter.Image = My.Resources.thinking2
        ElseIf radA.Checked = True And counter = 8 Then
            counter += 1
            Me.lblStory.Text = "The day is finally coming to an end. Alex is very exhausted and needs to lie down. However, to unwind Alex decides to watch one show on Netflix before he sleeps. He has 10 shows in mind. What is the probability that he will choose his favourite show Supernatural over the other shows?"
            Me.radA.Text = "20%"
            radB.Text = "30%"
            radC.Text = "10%"
            radD.Text = "50%"
            Me.picCharacter.Image = My.Resources.TIRED

        ElseIf radC.Checked = True And counter = 9 Then
            lblFinal.Visible = True
            picFinal.Visible = True
            picCharacter.Visible = False
            picInformation.Visible = False
            radA.Visible = False
            radB.Visible = False
            radC.Visible = False
            radD.Visible = False
            btnCheck.Visible = False
            Button1.Visible = True
        Else
            MsgBox("That is incorrect", MsgBoxStyle.Critical, "Wrong")
        End If

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub
End Class
