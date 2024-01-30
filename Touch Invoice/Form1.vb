Option Explicit On
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.IO


Public Class Form1

    'hot coffee
    Dim h1 As String = My.Settings.h1
    Dim h2 As String = My.Settings.h2
    Dim h3 As String = My.Settings.h3
    Dim h4 As String = My.Settings.h4
    Dim h5 As String = My.Settings.h5
    Dim h6 As String = My.Settings.h6
    Dim h7 As String = My.Settings.h7

    'Cold Coffee
    Dim c1 As String = My.Settings.c1
    Dim c2 As String = My.Settings.c2
    Dim c3 As String = My.Settings.c3
    Dim c4 As String = My.Settings.c4

    'Lassi
    Dim l1 As String = My.Settings.l1
    Dim l2 As String = My.Settings.l2
    Dim l3 As String = My.Settings.l3

    'Mocktail
    Dim k1 As String = My.Settings.k1
    Dim k2 As String = My.Settings.k2
    Dim k3 As String = My.Settings.k3
    Dim k4 As String = My.Settings.k4
    Dim k5 As String = My.Settings.k5
    Dim k6 As String = My.Settings.k6
    Dim k7 As String = My.Settings.k7

    'Milkshake
    Dim m1 As String = My.Settings.m1
    Dim m2 As String = My.Settings.m2
    Dim m3 As String = My.Settings.m3
    Dim m4 As String = My.Settings.m4
    Dim m5 As String = My.Settings.m5
    Dim m6 As String = My.Settings.m6

    'Lemonade
    Dim n1 As String = My.Settings.n1
    Dim n2 As String = My.Settings.n2

    'Crusher
    Dim r1 As String = My.Settings.r1
    Dim r2 As String = My.Settings.r2
    Dim r3 As String = My.Settings.r3
    Dim r4 As String = My.Settings.r4
    Dim r5 As String = My.Settings.r5

    'Premium Chilled
    Dim p1 As String = My.Settings.p1
    Dim p2 As String = My.Settings.p2
    Dim p3 As String = My.Settings.p3
    Dim p4 As String = My.Settings.p4

    'Iced Tea
    Dim t1 As String = My.Settings.t1
    Dim t2 As String = My.Settings.t2
    Dim t3 As String = My.Settings.t3


    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Try
            LiqfinalBindingSource.MoveLast()
            If orderquant.Text = Nothing Then
                LiqfinalBindingSource.RemoveCurrent()
                LiqfinalBindingSource.EndEdit()
                LiqfinalTableAdapter.Update(Liqdbase.liqfinal)
                End

            Else
                End
            End If
        Catch ex As Exception
            End
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Liqdbase.liqfinal' table. You can move, or remove it, as needed.


        Me.LiqfinalTableAdapter.Fill(Me.Liqdbase.liqfinal)


        recpt.Size = Size.Empty
        orderquant.Size = Size.Empty
        dbidtext.Size = Size.Empty
        orderno.Text = My.Settings.ordercountday
        fromdate.Value = Today
        TabControl1.SelectTab(0)
        TabControl1.SelectTab(1)
        TabControl1.SelectTab(2)
        TabControl1.SelectTab(3)
        TabControl1.SelectTab(4)
        TabControl1.SelectTab(5)
        TabControl1.SelectTab(6)
        TabControl1.SelectTab(7)
        TabControl1.SelectTab(8)
        TabControl1.SelectTab(9)
        TabControl1.SelectTab(0)

        counter.Show()
        LiqfinalBindingSource.MoveLast()
        If orderquant.Text <> Nothing Then
            LiqfinalBindingSource.AddNew()
        End If
        orderno.Text = My.Settings.ordercountday

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles hotcofclick.Click
        'Hot Coffee
        TabControl1.SelectTab(0)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles coldcofclick.Click
        'Cold Coffee
        TabControl1.SelectTab(1)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles crusherclick.Click
        'Crushers
        TabControl1.SelectTab(2)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles milkshakeclick.Click
        'Milk Shake
        TabControl1.SelectTab(3)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles lemonclick.Click
        'Lemonade
        TabControl1.SelectTab(4)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles lassiclick.Click
        'Lassi
        TabControl1.SelectTab(5)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles mocktailclick.Click
        'Mocktail
        TabControl1.SelectTab(6)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles premiumchilclick.Click
        'Premium Chilled Coffee
        TabControl1.SelectTab(7)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles juiceclick.Click
        'Juice
        TabControl1.SelectTab(8)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles iceteaclick.Click
        'Iced Tea
        TabControl1.SelectTab(9)
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        If TextBox8.Text.Trim.Length <> Nothing Then
            'TextBox8.Text = TextBox8.Text.Replace(" ", ",")
            counter.TextBox1.Text = TextBox8.Text.Replace(" ", ",")
        Else
            TextBox8.Text = Nothing
        End If

    End Sub

    Private Sub countformtimer_Tick(sender As Object, e As EventArgs) Handles countformtimer.Tick
        If TextBox8.Text = Nothing Then
            counter.Panel1.BackColor = Color.Silver
            counter.PictureBox1.Show()
            counter.Label1.Hide()
            counter.Label2.Hide()
            counter.TextBox1.Hide()
        Else
            counter.Panel1.BackColor = Color.Black
            counter.PictureBox1.Hide()
            counter.Label1.Show()
            counter.Label2.Show()
            counter.TextBox1.Show()
        End If
    End Sub

    Private Sub coldcofadd_Click(sender As Object, e As EventArgs) Handles coldcofadd.Click
        coldcofcount.Text = coldcofcount.Text + 1

        Try
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = c1lab.Text).First)
            Dim add As New ListViewItem(c1lab.Text$)
            add.SubItems.Add(c1)
            add.SubItems.Add(coldcofcount.Text$)
            add.SubItems.Add(c1 * coldcofcount.Text)
            ListView1.Items.Add(add)
        Catch ex As Exception
            Dim add As New ListViewItem(c1lab.Text$)
            add.SubItems.Add(c1)
            add.SubItems.Add(coldcofcount.Text$)
            add.SubItems.Add(c1 * coldcofcount.Text)
            ListView1.Items.Add(add)
        End Try


    End Sub



    Private Sub cuppuadd_Click(sender As Object, e As EventArgs) Handles cuppuadd.Click
        cuppucount.Text = cuppucount.Text + 1

        Try
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = h1lab.Text).First)
            Dim add As New ListViewItem(h1lab.Text$)
            add.SubItems.Add(h1)
            add.SubItems.Add(cuppucount.Text$)
            add.SubItems.Add(h1 * cuppucount.Text)
            ListView1.Items.Add(add)

        Catch ex As Exception
            Dim add As New ListViewItem(h1lab.Text$)
            add.SubItems.Add(h1)
            add.SubItems.Add(cuppucount.Text$)
            add.SubItems.Add(h1 * cuppucount.Text)
            ListView1.Items.Add(add)
        End Try

    End Sub

    Private Sub coldcofrem_Click(sender As Object, e As EventArgs) Handles coldcofrem.Click
        If coldcofcount.Text <= 1 Then
            coldcofcount.Text = 0
            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = c1lab.Text).First)
            Catch ex As Exception
            End Try
        Else
            coldcofcount.Text = coldcofcount.Text - 1
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = c1lab.Text).First)

            Dim add As New ListViewItem(c1lab.Text$)
            add.SubItems.Add(c1)
            add.SubItems.Add(coldcofcount.Text$)
            add.SubItems.Add(coldcofcount.Text * c1)
            ListView1.Items.Add(add)

        End If


    End Sub

    Private Sub cuppurem_Click(sender As Object, e As EventArgs) Handles cuppurem.Click
        If cuppucount.Text <= 1 Then
            cuppucount.Text = 0
            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = h1lab.Text).First)
            Catch ex As Exception
            End Try
        Else
            cuppucount.Text = cuppucount.Text - 1
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = h1lab.Text).First)

            Dim add As New ListViewItem(h1lab.Text$)
            add.SubItems.Add(h1)
            add.SubItems.Add(cuppucount.Text$)
            add.SubItems.Add(cuppucount.Text * h1)
            ListView1.Items.Add(add)

        End If
    End Sub



    Private Sub updateuiinfo_Tick(sender As Object, e As EventArgs) Handles updateuiinfo.Tick
        'UI Live Edits(Discounts, Grand Total etc)


        If cuppucount.Text = Nothing Then
            cuppucount.Text = 0
            If lattecount.Text = Nothing Then
                lattecount.Text = 0
                If mochacount.Text = Nothing Then
                    mochacount.Text = 0
                    If blackcount.Text = Nothing Then
                        blackcount.Text = 0
                        If caramelmaccount.Text = Nothing Then
                            caramelmaccount.Text = 0
                            If vanillalattecount.Text = Nothing Then
                                vanillalattecount.Text = 0
                                If hazelnutlattecount.Text = Nothing Then
                                    hazelnutlattecount.Text = 0
                                    If coldcofcount.Text = Nothing Then
                                        coldcofcount.Text = 0
                                        If chococoldcofcount.Text = Nothing Then
                                            chococoldcofcount.Text = 0
                                            If vanillacoldcofcount.Text = Nothing Then
                                                vanillacoldcofcount.Text = 0
                                                If caramelcoldcofcount.Text = Nothing Then
                                                    caramelcoldcofcount.Text = 0
                                                    If lassicount.Text = Nothing Then
                                                        lassicount.Text = 0
                                                        If espressolassicount.Text = Nothing Then
                                                            espressolassicount.Text = 0
                                                            If mangolassicount.Text = Nothing Then
                                                                mangolassicount.Text = 0
                                                                If virsanfrancount.Text = Nothing Then
                                                                    virsanfrancount.Text = 0
                                                                    If virsangriacount.Text = Nothing Then
                                                                        virsangriacount.Text = 0
                                                                        If virapplecount.Text = Nothing Then
                                                                            virapplecount.Text = 0
                                                                            If grapeinvadecount.Text = Nothing Then
                                                                                grapeinvadecount.Text = 0
                                                                                If bluebersparkcount.Text = Nothing Then
                                                                                    bluebersparkcount.Text = 0
                                                                                    If yellowpunchcount.Text = Nothing Then
                                                                                        yellowpunchcount.Text = 0
                                                                                        If darkcurrantcount.Text = Nothing Then
                                                                                            darkcurrantcount.Text = 0
                                                                                            If vanillamilkcount.Text = Nothing Then
                                                                                                vanillamilkcount.Text = 0
                                                                                                If chocomilkcount.Text = Nothing Then
                                                                                                    chocomilkcount.Text = 0
                                                                                                    If mangomilkcount.Text = Nothing Then
                                                                                                        mangomilkcount.Text = 0
                                                                                                        If strawberrymilkcount.Text = Nothing Then
                                                                                                            strawberrymilkcount.Text = 0
                                                                                                            If bananamilkcount.Text = Nothing Then
                                                                                                                bananamilkcount.Text = 0
                                                                                                                If peanutbuttermilkcount.Text = Nothing Then
                                                                                                                    peanutbuttermilkcount.Text = 0
                                                                                                                    If lemonmojitocount.Text = Nothing Then
                                                                                                                        lemonmojitocount.Text = 0
                                                                                                                        If orangelemoncount.Text = Nothing Then
                                                                                                                            orangelemoncount.Text = 0
                                                                                                                            If oreocount.Text = Nothing Then
                                                                                                                                oreocount.Text = 0
                                                                                                                                If snickerscount.Text = Nothing Then
                                                                                                                                    snickerscount.Text = 0
                                                                                                                                    If kitkatcount.Text = Nothing Then
                                                                                                                                        kitkatcount.Text = 0
                                                                                                                                        If darkchococount.Text = Nothing Then
                                                                                                                                            darkchococount.Text = 0
                                                                                                                                            If ferrerocount.Text = Nothing Then
                                                                                                                                                ferrerocount.Text = 0
                                                                                                                                                If chocochilcofcount.Text = Nothing Then
                                                                                                                                                    chocochilcofcount.Text = 0
                                                                                                                                                    If caramelchilcofcount.Text = Nothing Then
                                                                                                                                                        caramelchilcofcount.Text = 0
                                                                                                                                                        If hazelchilcofcount.Text = Nothing Then
                                                                                                                                                            hazelchilcofcount.Text = 0
                                                                                                                                                            If peanutchilcount.Text = Nothing Then
                                                                                                                                                                peanutchilcount.Text = 0
                                                                                                                                                                If berryicedteacount.Text = Nothing Then
                                                                                                                                                                    berryicedteacount.Text = 0
                                                                                                                                                                    If strawicedteacount.Text = Nothing Then
                                                                                                                                                                        strawicedteacount.Text = 0
                                                                                                                                                                        If raspicedteacount.Text = Nothing Then
                                                                                                                                                                            raspicedteacount.Text = 0
                                                                                                                                                                        End If
                                                                                                                                                                    End If
                                                                                                                                                                End If
                                                                                                                                                            End If
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                End If
                                                                                                                                            End If
                                                                                                                                        End If
                                                                                                                                    End If
                                                                                                                                End If
                                                                                                                            End If
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If



        If duetextbox.Text.Trim.Length <> Nothing Then
            duechecked.Text = "Due"

        Else

            duechecked.Text = Nothing
        End If

        If orderquant.Text = Nothing Then
            todaydate.Text = "Order Now"
        End If


        totordercount.Text = (From row As DataGridViewRow In DbfinalDataGridView.Rows
                              Where row.Cells(51).FormattedValue.ToString() <> String.Empty
                              Select Convert.ToInt32(row.Cells(51).FormattedValue)
                          ).Sum().ToString


        Try
            uitotalprice.Text = cuppucount.Text * h1 + coldcofcount.Text * c1 + mochacount.Text * h3 + blackcount.Text * h4 + caramelmaccount.Text * h5 + vanillalattecount.Text * h6 + hazelnutlattecount.Text * h7 + lattecount.Text * h2 + chococoldcofcount.Text * c2 + vanillacoldcofcount.Text * c3 + caramelcoldcofcount.Text * c4 + oreocount.Text * r1 + snickerscount.Text * r2 + kitkatcount.Text * r3 + darkchococount.Text * r4 + ferrerocount.Text * r5 + vanillamilkcount.Text * m1 + chocomilkcount.Text * m2 + mangomilkcount.Text * m3 + strawberrymilkcount.Text * m4 + bananamilkcount.Text * m5 + peanutbuttermilkcount.Text * m6 + lemonmojitocount.Text * n1 + orangelemoncount.Text * n2 + lassicount.Text * l1 + espressolassicount.Text * l2 + mangolassicount.Text * l3 + virsanfrancount.Text * k1 + virsangriacount.Text * k2 + virapplecount.Text * k3 + grapeinvadecount.Text * k4 + bluebersparkcount.Text * k5 + yellowpunchcount.Text * k6 + darkcurrantcount.Text * k7 + chocochilcofcount.Text * p1 + caramelchilcofcount.Text * p2 + hazelchilcofcount.Text * p3 + peanutchilcount.Text * p4 + berryicedteacount.Text * t1 + strawicedteacount.Text * t2 + raspicedteacount.Text * t3
            If uidiscount.Text = Nothing Then
                uigrandtotal.Text = uitotalprice.Text
            Else
                uigrandtotal.Text = uitotalprice.Text - (uitotalprice.Text * (uidiscount.Text / 100))
            End If

            If uicashrec.Text = Nothing Then
                uicashback.Text = Nothing
            Else
                uicashback.Text = uicashrec.Text - uigrandtotal.Text
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub uicashrec_TextChanged(sender As Object, e As EventArgs) Handles duetextbox.TextChanged
        duechecked.Text = "Due"

    End Sub

    Private Sub latteadd_Click(sender As Object, e As EventArgs) Handles latteadd.Click
        Try
            lattecount.Text = lattecount.Text + 1

            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = h2lab.Text).First)
                Dim add As New ListViewItem(h2lab.Text$)
                add.SubItems.Add(h2)
                add.SubItems.Add(lattecount.Text$)
                add.SubItems.Add(h2 * lattecount.Text)
                ListView1.Items.Add(add)
            Catch ex As Exception
                Dim add As New ListViewItem(h2lab.Text$)
                add.SubItems.Add(h2)
                add.SubItems.Add(lattecount.Text$)
                add.SubItems.Add(h2 * lattecount.Text)
                ListView1.Items.Add(add)
            End Try
        Catch ex As Exception

        End Try
    End Sub



    Private Sub LiqdataBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LiqfinalBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Liqdbase)

    End Sub

    Private Sub latterem_Click(sender As Object, e As EventArgs) Handles latterem.Click
        Try


            If lattecount.Text <= 1 Then
                lattecount.Text = 0
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = h2lab.Text).First)
                Catch ex As Exception
                End Try
            Else
                lattecount.Text = lattecount.Text - 1
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = h2lab.Text).First)

                Dim add As New ListViewItem(h2lab.Text$)
                add.SubItems.Add(h2)
                add.SubItems.Add(lattecount.Text$)
                add.SubItems.Add(lattecount.Text * h2)
                ListView1.Items.Add(add)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub mochaadd_Click(sender As Object, e As EventArgs) Handles mochaadd.Click
        Try
            mochacount.Text = mochacount.Text + 1

            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = h3lab.Text).First)
                Dim add As New ListViewItem(h3lab.Text$)
                add.SubItems.Add(h3)
                add.SubItems.Add(mochacount.Text$)
                add.SubItems.Add(h3 * mochacount.Text)
                ListView1.Items.Add(add)
            Catch ex As Exception
                Dim add As New ListViewItem(h3lab.Text$)
                add.SubItems.Add(h3)
                add.SubItems.Add(mochacount.Text$)
                add.SubItems.Add(h3 * mochacount.Text)
                ListView1.Items.Add(add)
            End Try
        Catch ex As Exception

        End Try
    End Sub

    Private Sub mocharem_Click(sender As Object, e As EventArgs) Handles mocharem.Click
        Try
            If mochacount.Text <= 1 Then
                mochacount.Text = 0
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = h3lab.Text).First)
                Catch ex As Exception
                End Try
            Else
                mochacount.Text = mochacount.Text - 1
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = h3lab.Text).First)

                Dim add As New ListViewItem(h3lab.Text$)
                add.SubItems.Add(h3)
                add.SubItems.Add(mochacount.Text$)
                add.SubItems.Add(mochacount.Text * h3)
                ListView1.Items.Add(add)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub blackadd_Click(sender As Object, e As EventArgs) Handles blackadd.Click
        Try
            blackcount.Text = blackcount.Text + 1

            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = h4lab.Text).First)
                Dim add As New ListViewItem(h4lab.Text$)
                add.SubItems.Add(h4)
                add.SubItems.Add(blackcount.Text$)
                add.SubItems.Add(h4 * blackcount.Text)
                ListView1.Items.Add(add)
            Catch ex As Exception
                Dim add As New ListViewItem(h4lab.Text$)
                add.SubItems.Add(h4)
                add.SubItems.Add(blackcount.Text$)
                add.SubItems.Add(h4 * blackcount.Text)
                ListView1.Items.Add(add)
            End Try
        Catch ex As Exception

        End Try
    End Sub

    Private Sub blackrem_Click(sender As Object, e As EventArgs) Handles blackrem.Click
        Try
            If blackcount.Text <= 1 Then
                blackcount.Text = 0
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = h4lab.Text).First)
                Catch ex As Exception
                End Try
            Else
                blackcount.Text = blackcount.Text - 1
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = h4lab.Text).First)

                Dim add As New ListViewItem(h4lab.Text$)
                add.SubItems.Add(h4)
                add.SubItems.Add(blackcount.Text$)
                add.SubItems.Add(blackcount.Text * h4)
                ListView1.Items.Add(add)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub caramelmacadd_Click(sender As Object, e As EventArgs) Handles caramelmacadd.Click
        Try
            caramelmaccount.Text = caramelmaccount.Text + 1

            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = h5lab.Text).First)
                Dim add As New ListViewItem(h5lab.Text$)
                add.SubItems.Add(h5)
                add.SubItems.Add(caramelmaccount.Text$)
                add.SubItems.Add(h5 * caramelmaccount.Text)
                ListView1.Items.Add(add)
            Catch ex As Exception
                Dim add As New ListViewItem(h5lab.Text$)
                add.SubItems.Add(h5)
                add.SubItems.Add(caramelmaccount.Text$)
                add.SubItems.Add(h5 * caramelmaccount.Text)
                ListView1.Items.Add(add)
            End Try
        Catch ex As Exception

        End Try
    End Sub

    Private Sub caramelmacrem_Click(sender As Object, e As EventArgs) Handles caramelmacrem.Click
        Try
            If caramelmaccount.Text <= 1 Then
                caramelmaccount.Text = 0
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = h5lab.Text).First)
                Catch ex As Exception
                End Try
            Else
                caramelmaccount.Text = caramelmaccount.Text - 1
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = h5lab.Text).First)

                Dim add As New ListViewItem(h5lab.Text$)
                add.SubItems.Add(h5)
                add.SubItems.Add(caramelmaccount.Text$)
                add.SubItems.Add(caramelmaccount.Text * h5)
                ListView1.Items.Add(add)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub vanilalatteadd_Click(sender As Object, e As EventArgs) Handles vanilalatteadd.Click
        Try
            vanillalattecount.Text = vanillalattecount.Text + 1

            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = h6lab.Text).First)
                Dim add As New ListViewItem(h6lab.Text$)
                add.SubItems.Add(h6)
                add.SubItems.Add(vanillalattecount.Text$)
                add.SubItems.Add(h6 * vanillalattecount.Text)
                ListView1.Items.Add(add)
            Catch ex As Exception
                Dim add As New ListViewItem(h6lab.Text$)
                add.SubItems.Add(h6)
                add.SubItems.Add(vanillalattecount.Text$)
                add.SubItems.Add(h6 * vanillalattecount.Text)
                ListView1.Items.Add(add)
            End Try
        Catch ex As Exception

        End Try
    End Sub

    Private Sub vanillalatterem_Click(sender As Object, e As EventArgs) Handles vanillalatterem.Click
        Try
            If vanillalattecount.Text <= 1 Then
                vanillalattecount.Text = 0
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = h6lab.Text).First)
                Catch ex As Exception
                End Try
            Else
                vanillalattecount.Text = vanillalattecount.Text - 1
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = h6lab.Text).First)

                Dim add As New ListViewItem(h6lab.Text$)
                add.SubItems.Add(h6)
                add.SubItems.Add(vanillalattecount.Text$)
                add.SubItems.Add(vanillalattecount.Text * h6)
                ListView1.Items.Add(add)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub hazelnutlatteadd_Click(sender As Object, e As EventArgs) Handles hazelnutlatteadd.Click
        Try
            hazelnutlattecount.Text = hazelnutlattecount.Text + 1

            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = h7lab.Text).First)
                Dim add As New ListViewItem(h7lab.Text$)
                add.SubItems.Add(h7)
                add.SubItems.Add(hazelnutlattecount.Text$)
                add.SubItems.Add(h7 * hazelnutlattecount.Text)
                ListView1.Items.Add(add)
            Catch ex As Exception
                Dim add As New ListViewItem(h7lab.Text$)
                add.SubItems.Add(h7)
                add.SubItems.Add(hazelnutlattecount.Text$)
                add.SubItems.Add(h7 * hazelnutlattecount.Text)
                ListView1.Items.Add(add)
            End Try
        Catch ex As Exception

        End Try
    End Sub

    Private Sub hazelnutlatterem_Click(sender As Object, e As EventArgs) Handles hazelnutlatterem.Click
        Try
            If hazelnutlattecount.Text <= 1 Then
                hazelnutlattecount.Text = 0
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = h7lab.Text).First)
                Catch ex As Exception
                End Try
            Else
                hazelnutlattecount.Text = hazelnutlattecount.Text - 1
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = h7lab.Text).First)

                Dim add As New ListViewItem(h7lab.Text$)
                add.SubItems.Add(h7)
                add.SubItems.Add(hazelnutlattecount.Text$)
                add.SubItems.Add(hazelnutlattecount.Text * h7)
                ListView1.Items.Add(add)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chococoldcofadd_Click(sender As Object, e As EventArgs) Handles chococoldcofadd.Click
        Try
            chococoldcofcount.Text = chococoldcofcount.Text + 1

            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = c2lab.Text).First)
                Dim add As New ListViewItem(c2lab.Text$)
                add.SubItems.Add(c2)
                add.SubItems.Add(chococoldcofcount.Text$)
                add.SubItems.Add(c2 * chococoldcofcount.Text)
                ListView1.Items.Add(add)
            Catch ex As Exception
                Dim add As New ListViewItem(c2lab.Text$)
                add.SubItems.Add(c2)
                add.SubItems.Add(chococoldcofcount.Text$)
                add.SubItems.Add(c2 * chococoldcofcount.Text)
                ListView1.Items.Add(add)
            End Try
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chococoldcofrem_Click(sender As Object, e As EventArgs) Handles chococoldcofrem.Click
        If chococoldcofcount.Text <= 1 Then
            chococoldcofcount.Text = 0
            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = c2lab.Text).First)
            Catch ex As Exception
            End Try
        Else
            chococoldcofcount.Text = chococoldcofcount.Text - 1
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = c2lab.Text).First)

            Dim add As New ListViewItem(c2lab.Text$)
            add.SubItems.Add(c2)
            add.SubItems.Add(chococoldcofcount.Text$)
            add.SubItems.Add(chococoldcofcount.Text * c2)
            ListView1.Items.Add(add)

        End If
    End Sub

    Private Sub vanillacoldcofadd_Click(sender As Object, e As EventArgs) Handles vanillacoldcofadd.Click
        ' Vanilla Cold Coffee Add Button
        vanillacoldcofcount.Text = vanillacoldcofcount.Text + 1

        Try
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = c3lab.Text).First)
            Dim add As New ListViewItem(c3lab.Text$)
            add.SubItems.Add(c3)
            add.SubItems.Add(vanillacoldcofcount.Text$)
            add.SubItems.Add(c3 * vanillacoldcofcount.Text)
            ListView1.Items.Add(add)
        Catch ex As Exception
            Dim add As New ListViewItem(c3lab.Text$)
            add.SubItems.Add(c3)
            add.SubItems.Add(vanillacoldcofcount.Text$)
            add.SubItems.Add(c3 * vanillacoldcofcount.Text)
            ListView1.Items.Add(add)
        End Try

    End Sub

    Private Sub vanillacoldcofrem_Click(sender As Object, e As EventArgs) Handles vanillacoldcofrem.Click
        'Vanilla Cold Coffee Remove Button
        If vanillacoldcofcount.Text <= 1 Then
            vanillacoldcofcount.Text = 0
            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = c3lab.Text).First)
            Catch ex As Exception
            End Try
        Else
            vanillacoldcofcount.Text = vanillacoldcofcount.Text - 1
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = c3lab.Text).First)

            Dim add As New ListViewItem(c3lab.Text$)
            add.SubItems.Add(c3)
            add.SubItems.Add(vanillacoldcofcount.Text$)
            add.SubItems.Add(vanillacoldcofcount.Text * c3)
            ListView1.Items.Add(add)

        End If
    End Sub

    Private Sub caramelcoldcofadd_Click(sender As Object, e As EventArgs) Handles caramelcoldcofadd.Click
        ' Caramel Cold Coffee Add Button
        caramelcoldcofcount.Text = caramelcoldcofcount.Text + 1

        Try
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = c4lab.Text).First)
            Dim add As New ListViewItem(c4lab.Text$)
            add.SubItems.Add(c4)
            add.SubItems.Add(caramelcoldcofcount.Text$)
            add.SubItems.Add(c4 * caramelcoldcofcount.Text)
            ListView1.Items.Add(add)
        Catch ex As Exception
            Dim add As New ListViewItem(c4lab.Text$)
            add.SubItems.Add(c4)
            add.SubItems.Add(caramelcoldcofcount.Text$)
            add.SubItems.Add(c4 * caramelcoldcofcount.Text)
            ListView1.Items.Add(add)
        End Try

    End Sub

    Private Sub caramelcoldcofrem_Click(sender As Object, e As EventArgs) Handles caramelcoldcofrem.Click
        'Caramel Cold Coffee Remove Button

        If caramelcoldcofcount.Text <= 1 Then
            caramelcoldcofcount.Text = 0
            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = c4lab.Text).First)
            Catch ex As Exception
            End Try
        Else
            caramelcoldcofcount.Text = caramelcoldcofcount.Text - 1
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = c4lab.Text).First)

            Dim add As New ListViewItem(c4lab.Text$)
            add.SubItems.Add(c4)
            add.SubItems.Add(caramelcoldcofcount.Text$)
            add.SubItems.Add(caramelcoldcofcount.Text * c4)
            ListView1.Items.Add(add)

        End If
    End Sub

    Private Sub oreoadd_Click(sender As Object, e As EventArgs) Handles oreoadd.Click
        'Oreo Crusher Add Button
        oreocount.Text = oreocount.Text + 1

        Try
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = r1lab.Text).First)
            Dim add As New ListViewItem(r1lab.Text$)
            add.SubItems.Add(r1)
            add.SubItems.Add(oreocount.Text$)
            add.SubItems.Add(r1 * oreocount.Text)
            ListView1.Items.Add(add)
        Catch ex As Exception
            Dim add As New ListViewItem(r1lab.Text$)
            add.SubItems.Add(r1)
            add.SubItems.Add(oreocount.Text$)
            add.SubItems.Add(r1 * oreocount.Text)
            ListView1.Items.Add(add)
        End Try

    End Sub

    Private Sub oreorem_Click(sender As Object, e As EventArgs) Handles oreorem.Click
        ' Oreo Crusher Remove Button
        If oreocount.Text <= 1 Then
            oreocount.Text = 0
            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = r1lab.Text).First)
            Catch ex As Exception
            End Try
        Else
            oreocount.Text = oreocount.Text - 1
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = r1lab.Text).First)

            Dim add As New ListViewItem(r1lab.Text$)
            add.SubItems.Add(r1)
            add.SubItems.Add(oreocount.Text$)
            add.SubItems.Add(oreocount.Text * r1)
            ListView1.Items.Add(add)

        End If
    End Sub

    Private Sub snickersadd_Click(sender As Object, e As EventArgs) Handles snickersadd.Click
        'Snickers Crusher Add Button
        snickerscount.Text = snickerscount.Text + 1

        Try
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = r2lab.Text).First)
            Dim add As New ListViewItem(r2lab.Text$)
            add.SubItems.Add(r2)
            add.SubItems.Add(snickerscount.Text$)
            add.SubItems.Add(r2 * snickerscount.Text)
            ListView1.Items.Add(add)
        Catch ex As Exception
            Dim add As New ListViewItem(r2lab.Text$)
            add.SubItems.Add(r2)
            add.SubItems.Add(snickerscount.Text$)
            add.SubItems.Add(r2 * snickerscount.Text)
            ListView1.Items.Add(add)
        End Try
    End Sub

    Private Sub snickersrem_Click(sender As Object, e As EventArgs) Handles snickersrem.Click
        'Snickers Crusher Remove Button
        If snickerscount.Text <= 1 Then
            snickerscount.Text = 0
            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = r2lab.Text).First)
            Catch ex As Exception
            End Try
        Else
            snickerscount.Text = snickerscount.Text - 1
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = r2lab.Text).First)

            Dim add As New ListViewItem(r2lab.Text$)
            add.SubItems.Add(r2)
            add.SubItems.Add(snickerscount.Text$)
            add.SubItems.Add(snickerscount.Text * r2)
            ListView1.Items.Add(add)

        End If
    End Sub

    Private Sub kitkatadd_Click(sender As Object, e As EventArgs) Handles kitkatadd.Click
        'Kitkat Crusher Add Button
        kitkatcount.Text = kitkatcount.Text + 1

        Try
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = r3lab.Text).First)
            Dim add As New ListViewItem(r3lab.Text$)
            add.SubItems.Add(r3)
            add.SubItems.Add(kitkatcount.Text$)
            add.SubItems.Add(r3 * kitkatcount.Text)
            ListView1.Items.Add(add)
        Catch ex As Exception
            Dim add As New ListViewItem(r3lab.Text$)
            add.SubItems.Add(r3)
            add.SubItems.Add(kitkatcount.Text$)
            add.SubItems.Add(r3 * kitkatcount.Text)
            ListView1.Items.Add(add)
        End Try
    End Sub

    Private Sub kitkatrem_Click(sender As Object, e As EventArgs) Handles kitkatrem.Click
        'Kitkat Crusher Remove Button
        If kitkatcount.Text <= 1 Then
            kitkatcount.Text = 0
            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = r3lab.Text).First)
            Catch ex As Exception
            End Try
        Else
            kitkatcount.Text = kitkatcount.Text - 1
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = r3lab.Text).First)

            Dim add As New ListViewItem(r3lab.Text$)
            add.SubItems.Add(r3)
            add.SubItems.Add(kitkatcount.Text$)
            add.SubItems.Add(kitkatcount.Text * r3)
            ListView1.Items.Add(add)

        End If
    End Sub

    Private Sub darkchocoadd_Click(sender As Object, e As EventArgs) Handles darkchocoadd.Click
        'Dark Chocolate Crusher Add Button
        darkchococount.Text = darkchococount.Text + 1

        Try
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = r4lab.Text).First)
            Dim add As New ListViewItem(r4lab.Text$)
            add.SubItems.Add(r4)
            add.SubItems.Add(darkchococount.Text$)
            add.SubItems.Add(r4 * darkchococount.Text)
            ListView1.Items.Add(add)
        Catch ex As Exception
            Dim add As New ListViewItem(r4lab.Text$)
            add.SubItems.Add(r4)
            add.SubItems.Add(darkchococount.Text$)
            add.SubItems.Add(r4 * darkchococount.Text)
            ListView1.Items.Add(add)
        End Try
    End Sub

    Private Sub darkchocorem_Click(sender As Object, e As EventArgs) Handles darkchocorem.Click
        'Dark Chocolate Crusher Remove Button
        If darkchococount.Text <= 1 Then
            darkchococount.Text = 0
            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = r4lab.Text).First)
            Catch ex As Exception
            End Try
        Else
            darkchococount.Text = darkchococount.Text - 1
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = r4lab.Text).First)

            Dim add As New ListViewItem(r4lab.Text$)
            add.SubItems.Add(r4)
            add.SubItems.Add(darkchococount.Text$)
            add.SubItems.Add(darkchococount.Text * r4)
            ListView1.Items.Add(add)

        End If
    End Sub

    Private Sub ferreroadd_Click(sender As Object, e As EventArgs) Handles ferreroadd.Click
        'Ferrero Rocher Crusher Add Button
        ferrerocount.Text = ferrerocount.Text + 1

        Try
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = r5lab.Text).First)
            Dim add As New ListViewItem(r5lab.Text$)
            add.SubItems.Add(r5)
            add.SubItems.Add(ferrerocount.Text$)
            add.SubItems.Add(r5 * ferrerocount.Text)
            ListView1.Items.Add(add)
        Catch ex As Exception
            Dim add As New ListViewItem(r5lab.Text$)
            add.SubItems.Add(r5)
            add.SubItems.Add(ferrerocount.Text$)
            add.SubItems.Add(r5 * ferrerocount.Text)
            ListView1.Items.Add(add)
        End Try
    End Sub

    Private Sub ferrerorem_Click(sender As Object, e As EventArgs) Handles ferrerorem.Click
        'Ferrero Rocher Crusher Remove Button
        If ferrerocount.Text <= 1 Then
            ferrerocount.Text = 0
            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = r5lab.Text).First)
            Catch ex As Exception
            End Try
        Else
            ferrerocount.Text = ferrerocount.Text - 1
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = r5lab.Text).First)

            Dim add As New ListViewItem(r5lab.Text$)
            add.SubItems.Add(r5)
            add.SubItems.Add(ferrerocount.Text$)
            add.SubItems.Add(ferrerocount.Text * r5)
            ListView1.Items.Add(add)

        End If
    End Sub

    Private Sub vanillamilkadd_Click(sender As Object, e As EventArgs) Handles vanillamilkadd.Click
        'Vanilla Milk Shake Add Button
        vanillamilkcount.Text = vanillamilkcount.Text + 1

        Try
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = m1lab.Text).First)
            Dim add As New ListViewItem(m1lab.Text$)
            add.SubItems.Add(m1)
            add.SubItems.Add(vanillamilkcount.Text$)
            add.SubItems.Add(m1 * vanillamilkcount.Text)
            ListView1.Items.Add(add)
        Catch ex As Exception
            Dim add As New ListViewItem(m1lab.Text$)
            add.SubItems.Add(m1)
            add.SubItems.Add(vanillamilkcount.Text$)
            add.SubItems.Add(m1 * vanillamilkcount.Text)
            ListView1.Items.Add(add)
        End Try
    End Sub

    Private Sub vanillamilkrem_Click(sender As Object, e As EventArgs) Handles vanillamilkrem.Click
        'Vanilla Milk Shake Remove Button
        If vanillamilkcount.Text <= 1 Then
            vanillamilkcount.Text = 0
            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = m1lab.Text).First)
            Catch ex As Exception
            End Try
        Else
            vanillamilkcount.Text = vanillamilkcount.Text - 1
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = m1lab.Text).First)

            Dim add As New ListViewItem(m1lab.Text$)
            add.SubItems.Add(m1)
            add.SubItems.Add(vanillamilkcount.Text$)
            add.SubItems.Add(vanillamilkcount.Text * m1)
            ListView1.Items.Add(add)

        End If
    End Sub

    Private Sub chocomilkadd_Click(sender As Object, e As EventArgs) Handles chocomilkadd.Click
        'Chocolate Milk Shake Add Button
        chocomilkcount.Text = chocomilkcount.Text + 1

        Try
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = m2lab.Text).First)
            Dim add As New ListViewItem(m2lab.Text$)
            add.SubItems.Add(m2)
            add.SubItems.Add(chocomilkcount.Text$)
            add.SubItems.Add(m2 * chocomilkcount.Text)
            ListView1.Items.Add(add)
        Catch ex As Exception
            Dim add As New ListViewItem(m2lab.Text$)
            add.SubItems.Add(m2)
            add.SubItems.Add(chocomilkcount.Text$)
            add.SubItems.Add(m2 * chocomilkcount.Text)
            ListView1.Items.Add(add)
        End Try
    End Sub

    Private Sub chocomilkrem_Click(sender As Object, e As EventArgs) Handles chocomilkrem.Click
        'Chocolate Milk Shake Remove button
        If chocomilkcount.Text <= 1 Then
            chocomilkcount.Text = 0
            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = m2lab.Text).First)
            Catch ex As Exception
            End Try
        Else
            chocomilkcount.Text = chocomilkcount.Text - 1
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = m2lab.Text).First)

            Dim add As New ListViewItem(m2lab.Text$)
            add.SubItems.Add(m2)
            add.SubItems.Add(chocomilkcount.Text$)
            add.SubItems.Add(chocomilkcount.Text * m2)
            ListView1.Items.Add(add)

        End If
    End Sub

    Private Sub mangomilkadd_Click(sender As Object, e As EventArgs) Handles mangomilkadd.Click
        'Mango Milk Shake Add Button
        mangomilkcount.Text = mangomilkcount.Text + 1

        Try
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = m3lab.Text).First)
            Dim add As New ListViewItem(m3lab.Text$)
            add.SubItems.Add(m3)
            add.SubItems.Add(mangomilkcount.Text$)
            add.SubItems.Add(m3 * mangomilkcount.Text)
            ListView1.Items.Add(add)
        Catch ex As Exception
            Dim add As New ListViewItem(m3lab.Text$)
            add.SubItems.Add(m3)
            add.SubItems.Add(mangomilkcount.Text$)
            add.SubItems.Add(m3 * mangomilkcount.Text)
            ListView1.Items.Add(add)
        End Try
    End Sub

    Private Sub mangomilkrem_Click(sender As Object, e As EventArgs) Handles mangomilkrem.Click
        'Mango Milk Shake Remove Button
        If mangomilkcount.Text <= 1 Then
            mangomilkcount.Text = 0
            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = m3lab.Text).First)
            Catch ex As Exception
            End Try
        Else
            mangomilkcount.Text = mangomilkcount.Text - 1
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = m3lab.Text).First)

            Dim add As New ListViewItem(m3lab.Text$)
            add.SubItems.Add(m3)
            add.SubItems.Add(mangomilkcount.Text$)
            add.SubItems.Add(mangomilkcount.Text * m3)
            ListView1.Items.Add(add)

        End If
    End Sub

    Private Sub strawberrymilkadd_Click(sender As Object, e As EventArgs) Handles strawberrymilkadd.Click
        'Strawberry Milk Shake Add Button
        strawberrymilkcount.Text = strawberrymilkcount.Text + 1

        Try
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = m4lab.Text).First)
            Dim add As New ListViewItem(m4lab.Text$)
            add.SubItems.Add(m4)
            add.SubItems.Add(strawberrymilkcount.Text$)
            add.SubItems.Add(m4 * strawberrymilkcount.Text)
            ListView1.Items.Add(add)
        Catch ex As Exception
            Dim add As New ListViewItem(m4lab.Text$)
            add.SubItems.Add(m4)
            add.SubItems.Add(strawberrymilkcount.Text$)
            add.SubItems.Add(m4 * strawberrymilkcount.Text)
            ListView1.Items.Add(add)
        End Try
    End Sub

    Private Sub strawberrymilkrem_Click(sender As Object, e As EventArgs) Handles strawberrymilkrem.Click
        'Strawberry Milkshake Remove Button
        If strawberrymilkcount.Text <= 1 Then
            strawberrymilkcount.Text = 0
            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = m4lab.Text).First)
            Catch ex As Exception
            End Try
        Else
            strawberrymilkcount.Text = strawberrymilkcount.Text - 1
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = m4lab.Text).First)

            Dim add As New ListViewItem(m4lab.Text$)
            add.SubItems.Add(m4)
            add.SubItems.Add(strawberrymilkcount.Text$)
            add.SubItems.Add(strawberrymilkcount.Text * m4)
            ListView1.Items.Add(add)

        End If
    End Sub

    Private Sub bananamilkadd_Click(sender As Object, e As EventArgs) Handles bananamilkadd.Click
        'Banana Milk Shake Add Button
        bananamilkcount.Text = bananamilkcount.Text + 1

        Try
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = m5lab.Text).First)
            Dim add As New ListViewItem(m5lab.Text$)
            add.SubItems.Add(m5)
            add.SubItems.Add(bananamilkcount.Text$)
            add.SubItems.Add(m5 * bananamilkcount.Text)
            ListView1.Items.Add(add)
        Catch ex As Exception
            Dim add As New ListViewItem(m5lab.Text$)
            add.SubItems.Add(m5)
            add.SubItems.Add(bananamilkcount.Text$)
            add.SubItems.Add(m5 * bananamilkcount.Text)
            ListView1.Items.Add(add)
        End Try
    End Sub

    Private Sub bananamilkrem_Click(sender As Object, e As EventArgs) Handles bananamilkrem.Click
        'Banana Milk Shake Remove Button
        If bananamilkcount.Text <= 1 Then
            bananamilkcount.Text = 0
            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = m5lab.Text).First)
            Catch ex As Exception
            End Try
        Else
            bananamilkcount.Text = bananamilkcount.Text - 1
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = m5lab.Text).First)

            Dim add As New ListViewItem(m5lab.Text$)
            add.SubItems.Add(m5)
            add.SubItems.Add(bananamilkcount.Text$)
            add.SubItems.Add(bananamilkcount.Text * m5)
            ListView1.Items.Add(add)

        End If
    End Sub

    Private Sub peanutbuttermilkadd_Click(sender As Object, e As EventArgs) Handles peanutbuttermilkadd.Click
        'Peanutbutter Milkshake add button
        peanutbuttermilkcount.Text = peanutbuttermilkcount.Text + 1

        Try
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = m6lab.Text).First)
            Dim add As New ListViewItem(m6lab.Text$)
            add.SubItems.Add(m6)
            add.SubItems.Add(peanutbuttermilkcount.Text$)
            add.SubItems.Add(m6 * peanutbuttermilkcount.Text)
            ListView1.Items.Add(add)
        Catch ex As Exception
            Dim add As New ListViewItem(m6lab.Text$)
            add.SubItems.Add(m6)
            add.SubItems.Add(peanutbuttermilkcount.Text$)
            add.SubItems.Add(m6 * peanutbuttermilkcount.Text)
            ListView1.Items.Add(add)
        End Try
    End Sub

    Private Sub peanutbuttermilkrem_Click(sender As Object, e As EventArgs) Handles peanutbuttermilkrem.Click
        'Peanutbutter Milkshake remove button
        If peanutbuttermilkcount.Text <= 1 Then
            peanutbuttermilkcount.Text = 0
            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = m6lab.Text).First)
            Catch ex As Exception
            End Try
        Else
            peanutbuttermilkcount.Text = peanutbuttermilkcount.Text - 1
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = m6lab.Text).First)

            Dim add As New ListViewItem(m6lab.Text$)
            add.SubItems.Add(m6)
            add.SubItems.Add(peanutbuttermilkcount.Text$)
            add.SubItems.Add(peanutbuttermilkcount.Text * m6)
            ListView1.Items.Add(add)

        End If
    End Sub

    Private Sub lemonmojitoadd_Click(sender As Object, e As EventArgs) Handles lemonmojitoadd.Click
        'Lemon Mojito Add Button
        lemonmojitocount.Text = lemonmojitocount.Text + 1

        Try
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = n1lab.Text).First)
            Dim add As New ListViewItem(n1lab.Text$)
            add.SubItems.Add(n1)
            add.SubItems.Add(lemonmojitocount.Text$)
            add.SubItems.Add(n1 * lemonmojitocount.Text)
            ListView1.Items.Add(add)
        Catch ex As Exception
            Dim add As New ListViewItem(n1lab.Text$)
            add.SubItems.Add(n1)
            add.SubItems.Add(lemonmojitocount.Text$)
            add.SubItems.Add(n1 * lemonmojitocount.Text)
            ListView1.Items.Add(add)
        End Try
    End Sub

    Private Sub lemonmojitorem_Click(sender As Object, e As EventArgs) Handles lemonmojitorem.Click
        'Lemon Mojito Remove Button
        If lemonmojitocount.Text <= 1 Then
            lemonmojitocount.Text = 0
            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = n1lab.Text).First)
            Catch ex As Exception
            End Try
        Else
            lemonmojitocount.Text = lemonmojitocount.Text - 1
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = n1lab.Text).First)

            Dim add As New ListViewItem(n1lab.Text$)
            add.SubItems.Add(n1)
            add.SubItems.Add(lemonmojitocount.Text$)
            add.SubItems.Add(lemonmojitocount.Text * n1)
            ListView1.Items.Add(add)

        End If
    End Sub

    Private Sub orangelemonadd_Click(sender As Object, e As EventArgs) Handles orangelemonadd.Click
        'Orange Lemonade Add Button
        orangelemoncount.Text = orangelemoncount.Text + 1

        Try
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = n2lab.Text).First)
            Dim add As New ListViewItem(n2lab.Text$)
            add.SubItems.Add(n2)
            add.SubItems.Add(orangelemoncount.Text$)
            add.SubItems.Add(n2 * orangelemoncount.Text)
            ListView1.Items.Add(add)
        Catch ex As Exception
            Dim add As New ListViewItem(n2lab.Text$)
            add.SubItems.Add(n2)
            add.SubItems.Add(orangelemoncount.Text$)
            add.SubItems.Add(n2 * orangelemoncount.Text)
            ListView1.Items.Add(add)
        End Try
    End Sub

    Private Sub orangelemonrem_Click(sender As Object, e As EventArgs) Handles orangelemonrem.Click
        'Orange Lemonade Remove Button
        If orangelemoncount.Text <= 1 Then
            orangelemoncount.Text = 0
            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = n2lab.Text).First)
            Catch ex As Exception
            End Try
        Else
            orangelemoncount.Text = orangelemoncount.Text - 1
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = n2lab.Text).First)

            Dim add As New ListViewItem(n2lab.Text$)
            add.SubItems.Add(n2)
            add.SubItems.Add(orangelemoncount.Text$)
            add.SubItems.Add(orangelemoncount.Text * n2)
            ListView1.Items.Add(add)

        End If
    End Sub

    Private Sub lassiadd_Click(sender As Object, e As EventArgs) Handles lassiadd.Click
        'Lassi Regular Add Button L1
        lassicount.Text = lassicount.Text + 1

        Try
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = l1lab.Text).First)
            Dim add As New ListViewItem(l1lab.Text$)
            add.SubItems.Add(l1)
            add.SubItems.Add(lassicount.Text$)
            add.SubItems.Add(l1 * lassicount.Text)
            ListView1.Items.Add(add)
        Catch ex As Exception
            Dim add As New ListViewItem(l1lab.Text$)
            add.SubItems.Add(l1)
            add.SubItems.Add(lassicount.Text$)
            add.SubItems.Add(l1 * lassicount.Text)
            ListView1.Items.Add(add)
        End Try
    End Sub

    Private Sub lassirem_Click(sender As Object, e As EventArgs) Handles lassirem.Click
        'Lassi Regular Remove Button L1
        If lassicount.Text <= 1 Then
            lassicount.Text = 0
            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = l1lab.Text).First)
            Catch ex As Exception
            End Try
        Else
            lassicount.Text = lassicount.Text - 1
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = l1lab.Text).First)

            Dim add As New ListViewItem(l1lab.Text$)
            add.SubItems.Add(l1)
            add.SubItems.Add(lassicount.Text$)
            add.SubItems.Add(lassicount.Text * l1)
            ListView1.Items.Add(add)

        End If
    End Sub

    Private Sub espressolassiadd_Click(sender As Object, e As EventArgs) Handles espressolassiadd.Click
        'Espresso Lassi Add Button L2
        espressolassicount.Text = espressolassicount.Text + 1

        Try
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = l2lab.Text).First)
            Dim add As New ListViewItem(l2lab.Text$)
            add.SubItems.Add(l2)
            add.SubItems.Add(espressolassicount.Text$)
            add.SubItems.Add(l2 * espressolassicount.Text)
            ListView1.Items.Add(add)
        Catch ex As Exception
            Dim add As New ListViewItem(l2lab.Text$)
            add.SubItems.Add(l2)
            add.SubItems.Add(espressolassicount.Text$)
            add.SubItems.Add(l2 * espressolassicount.Text)
            ListView1.Items.Add(add)
        End Try
    End Sub

    Private Sub espressolassirem_Click(sender As Object, e As EventArgs) Handles espressolassirem.Click
        'Espresso Lassi Remove Button L2
        If espressolassicount.Text <= 1 Then
            espressolassicount.Text = 0
            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = l2lab.Text).First)
            Catch ex As Exception
            End Try
        Else
            espressolassicount.Text = espressolassicount.Text - 1
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = l2lab.Text).First)

            Dim add As New ListViewItem(l2lab.Text$)
            add.SubItems.Add(l2)
            add.SubItems.Add(espressolassicount.Text$)
            add.SubItems.Add(espressolassicount.Text * l2)
            ListView1.Items.Add(add)

        End If
    End Sub

    Private Sub mangolassiadd_Click(sender As Object, e As EventArgs) Handles mangolassiadd.Click
        'Mango Lassi Add Button L3
        mangolassicount.Text = mangolassicount.Text + 1

        Try
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = l3lab.Text).First)
            Dim add As New ListViewItem(l3lab.Text$)
            add.SubItems.Add(l3)
            add.SubItems.Add(mangolassicount.Text$)
            add.SubItems.Add(l3 * mangolassicount.Text)
            ListView1.Items.Add(add)
        Catch ex As Exception
            Dim add As New ListViewItem(l3lab.Text$)
            add.SubItems.Add(l3)
            add.SubItems.Add(mangolassicount.Text$)
            add.SubItems.Add(l3 * mangolassicount.Text)
            ListView1.Items.Add(add)
        End Try
    End Sub

    Private Sub mangolassirem_Click(sender As Object, e As EventArgs) Handles mangolassirem.Click
        'Mango Lassi Remove Button L3
        If mangolassicount.Text <= 1 Then
            mangolassicount.Text = 0
            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = l3lab.Text).First)
            Catch ex As Exception
            End Try
        Else
            mangolassicount.Text = mangolassicount.Text - 1
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = l3lab.Text).First)

            Dim add As New ListViewItem(l3lab.Text$)
            add.SubItems.Add(l3)
            add.SubItems.Add(mangolassicount.Text$)
            add.SubItems.Add(mangolassicount.Text * l3)
            ListView1.Items.Add(add)

        End If
    End Sub

    Private Sub virsanfranadd_Click(sender As Object, e As EventArgs) Handles virsanfranadd.Click
        'Virgin SanFrancisco Add Button K1
        virsanfrancount.Text = virsanfrancount.Text + 1

        Try
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = k1lab.Text).First)
            Dim add As New ListViewItem(k1lab.Text$)
            add.SubItems.Add(k1)
            add.SubItems.Add(virsanfrancount.Text$)
            add.SubItems.Add(k1 * virsanfrancount.Text)
            ListView1.Items.Add(add)
        Catch ex As Exception
            Dim add As New ListViewItem(k1lab.Text$)
            add.SubItems.Add(k1)
            add.SubItems.Add(virsanfrancount.Text$)
            add.SubItems.Add(k1 * virsanfrancount.Text)
            ListView1.Items.Add(add)
        End Try
    End Sub

    Private Sub virsanfranrem_Click(sender As Object, e As EventArgs) Handles virsanfranrem.Click
        'Virgin SanFrancisco Remove Button K1

        If virsanfrancount.Text <= 1 Then
            virsanfrancount.Text = 0
            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = k1lab.Text).First)
            Catch ex As Exception
            End Try
        Else
            virsanfrancount.Text = virsanfrancount.Text - 1
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = k1lab.Text).First)

            Dim add As New ListViewItem(k1lab.Text$)
            add.SubItems.Add(k1)
            add.SubItems.Add(virsanfrancount.Text$)
            add.SubItems.Add(virsanfrancount.Text * k1)
            ListView1.Items.Add(add)

        End If
    End Sub

    Private Sub virsangriaadd_Click(sender As Object, e As EventArgs) Handles virsangriaadd.Click
        'Virgin Sangria Add Button K2
        virsangriacount.Text = virsangriacount.Text + 1

        Try
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = k2lab.Text).First)
            Dim add As New ListViewItem(k2lab.Text$)
            add.SubItems.Add(k2)
            add.SubItems.Add(virsangriacount.Text$)
            add.SubItems.Add(k2 * virsangriacount.Text)
            ListView1.Items.Add(add)
        Catch ex As Exception
            Dim add As New ListViewItem(k2lab.Text$)
            add.SubItems.Add(k2)
            add.SubItems.Add(virsangriacount.Text$)
            add.SubItems.Add(k2 * virsangriacount.Text)
            ListView1.Items.Add(add)
        End Try
    End Sub

    Private Sub virsangriarem_Click(sender As Object, e As EventArgs) Handles virsangriarem.Click
        'Virgin Sangria Remove Button K2
        If virsangriacount.Text <= 1 Then
            virsangriacount.Text = 0
            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = k2lab.Text).First)
            Catch ex As Exception
            End Try
        Else
            virsangriacount.Text = virsangriacount.Text - 1
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = k2lab.Text).First)

            Dim add As New ListViewItem(k2lab.Text$)
            add.SubItems.Add(k2)
            add.SubItems.Add(virsangriacount.Text$)
            add.SubItems.Add(virsangriacount.Text * k2)
            ListView1.Items.Add(add)

        End If
    End Sub

    Private Sub virappleadd_Click(sender As Object, e As EventArgs) Handles virappleadd.Click
        'Virgin Appletini Add Button K3
        virapplecount.Text = virapplecount.Text + 1

        Try
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = k3lab.Text).First)
            Dim add As New ListViewItem(k3lab.Text$)
            add.SubItems.Add(k3)
            add.SubItems.Add(virapplecount.Text$)
            add.SubItems.Add(k3 * virapplecount.Text)
            ListView1.Items.Add(add)
        Catch ex As Exception
            Dim add As New ListViewItem(k3lab.Text$)
            add.SubItems.Add(k3)
            add.SubItems.Add(virapplecount.Text$)
            add.SubItems.Add(k3 * virapplecount.Text)
            ListView1.Items.Add(add)
        End Try
    End Sub

    Private Sub virapplerem_Click(sender As Object, e As EventArgs) Handles virapplerem.Click
        'Virgin Appletini Remove Button K3
        If virapplecount.Text <= 1 Then
            virapplecount.Text = 0
            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = k3lab.Text).First)
            Catch ex As Exception
            End Try
        Else
            virapplecount.Text = virapplecount.Text - 1
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = k3lab.Text).First)

            Dim add As New ListViewItem(k3lab.Text$)
            add.SubItems.Add(k3)
            add.SubItems.Add(virapplecount.Text$)
            add.SubItems.Add(virapplecount.Text * k3)
            ListView1.Items.Add(add)

        End If
    End Sub

    Private Sub grapeinvadeadd_Click(sender As Object, e As EventArgs) Handles grapeinvadeadd.Click
        'Grape Invader Add Button K4
        grapeinvadecount.Text = grapeinvadecount.Text + 1

        Try
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = k4lab.Text).First)
            Dim add As New ListViewItem(k4lab.Text$)
            add.SubItems.Add(k4)
            add.SubItems.Add(grapeinvadecount.Text$)
            add.SubItems.Add(k4 * grapeinvadecount.Text)
            ListView1.Items.Add(add)
        Catch ex As Exception
            Dim add As New ListViewItem(k4lab.Text$)
            add.SubItems.Add(k4)
            add.SubItems.Add(grapeinvadecount.Text$)
            add.SubItems.Add(k4 * grapeinvadecount.Text)
            ListView1.Items.Add(add)
        End Try
    End Sub

    Private Sub grapeinvaderem_Click(sender As Object, e As EventArgs) Handles grapeinvaderem.Click
        'Grape Invader Remove Button K4
        If grapeinvadecount.Text <= 1 Then
            grapeinvadecount.Text = 0
            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = k4lab.Text).First)
            Catch ex As Exception
            End Try
        Else
            grapeinvadecount.Text = grapeinvadecount.Text - 1
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = k4lab.Text).First)

            Dim add As New ListViewItem(k4lab.Text$)
            add.SubItems.Add(k4)
            add.SubItems.Add(grapeinvadecount.Text$)
            add.SubItems.Add(grapeinvadecount.Text * k4)
            ListView1.Items.Add(add)

        End If
    End Sub

    Private Sub bluebersparkadd_Click(sender As Object, e As EventArgs) Handles bluebersparkadd.Click
        'BlueBerry Sparklar Add Button K5
        bluebersparkcount.Text = bluebersparkcount.Text + 1

        Try
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = k5lab.Text).First)
            Dim add As New ListViewItem(k5lab.Text$)
            add.SubItems.Add(k5)
            add.SubItems.Add(bluebersparkcount.Text$)
            add.SubItems.Add(k5 * bluebersparkcount.Text)
            ListView1.Items.Add(add)
        Catch ex As Exception
            Dim add As New ListViewItem(k5lab.Text$)
            add.SubItems.Add(k5)
            add.SubItems.Add(bluebersparkcount.Text$)
            add.SubItems.Add(k5 * bluebersparkcount.Text)
            ListView1.Items.Add(add)
        End Try
    End Sub

    Private Sub bluebersparkrem_Click(sender As Object, e As EventArgs) Handles bluebersparkrem.Click
        'BlueBerry Sparklar Remove Button K5
        If bluebersparkcount.Text <= 1 Then
            bluebersparkcount.Text = 0
            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = k5lab.Text).First)
            Catch ex As Exception
            End Try
        Else
            bluebersparkcount.Text = bluebersparkcount.Text - 1
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = k5lab.Text).First)

            Dim add As New ListViewItem(k5lab.Text$)
            add.SubItems.Add(k5)
            add.SubItems.Add(bluebersparkcount.Text$)
            add.SubItems.Add(bluebersparkcount.Text * k5)
            ListView1.Items.Add(add)

        End If
    End Sub

    Private Sub yellowpunchadd_Click(sender As Object, e As EventArgs) Handles yellowpunchadd.Click
        'Yellow Punch Add Button K6
        yellowpunchcount.Text = yellowpunchcount.Text + 1

        Try
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = k6lab.Text).First)
            Dim add As New ListViewItem(k6lab.Text$)
            add.SubItems.Add(k6)
            add.SubItems.Add(yellowpunchcount.Text$)
            add.SubItems.Add(k6 * yellowpunchcount.Text)
            ListView1.Items.Add(add)
        Catch ex As Exception
            Dim add As New ListViewItem(k6lab.Text$)
            add.SubItems.Add(k6)
            add.SubItems.Add(yellowpunchcount.Text$)
            add.SubItems.Add(k6 * yellowpunchcount.Text)
            ListView1.Items.Add(add)
        End Try
    End Sub

    Private Sub yellowpunchrem_Click(sender As Object, e As EventArgs) Handles yellowpunchrem.Click
        'Yellow Punch Remove Button K6
        If yellowpunchcount.Text <= 1 Then
            yellowpunchcount.Text = 0
            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = k6lab.Text).First)
            Catch ex As Exception
            End Try
        Else
            yellowpunchcount.Text = yellowpunchcount.Text - 1
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = k6lab.Text).First)

            Dim add As New ListViewItem(k6lab.Text$)
            add.SubItems.Add(k6)
            add.SubItems.Add(yellowpunchcount.Text$)
            add.SubItems.Add(yellowpunchcount.Text * k6)
            ListView1.Items.Add(add)

        End If
    End Sub

    Private Sub darkcurrantadd_Click(sender As Object, e As EventArgs) Handles darkcurrantadd.Click
        'Dark Currant Add Button K7
        darkcurrantcount.Text = darkcurrantcount.Text + 1

        Try
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = k7lab.Text).First)
            Dim add As New ListViewItem(k7lab.Text$)
            add.SubItems.Add(k7)
            add.SubItems.Add(darkcurrantcount.Text$)
            add.SubItems.Add(k7 * darkcurrantcount.Text)
            ListView1.Items.Add(add)
        Catch ex As Exception
            Dim add As New ListViewItem(k7lab.Text$)
            add.SubItems.Add(k7)
            add.SubItems.Add(darkcurrantcount.Text$)
            add.SubItems.Add(k7 * darkcurrantcount.Text)
            ListView1.Items.Add(add)
        End Try
    End Sub

    Private Sub darkcurrantrem_Click(sender As Object, e As EventArgs) Handles darkcurrantrem.Click
        'Dark Currant Remove Button K7
        If bluebersparkcount.Text <= 1 Then
            bluebersparkcount.Text = 0
            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = k5lab.Text).First)
            Catch ex As Exception
            End Try
        Else
            bluebersparkcount.Text = bluebersparkcount.Text - 1
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = k5lab.Text).First)

            Dim add As New ListViewItem(k5lab.Text$)
            add.SubItems.Add(k7)
            add.SubItems.Add(bluebersparkcount.Text$)
            add.SubItems.Add(bluebersparkcount.Text * k7)
            ListView1.Items.Add(add)

        End If
    End Sub

    Private Sub chocochilcofadd_Click(sender As Object, e As EventArgs) Handles chocochilcofadd.Click
        'Chocolate Chilled Coffee Add Button P1
        chocochilcofcount.Text = chocochilcofcount.Text + 1

        Try
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = p1lab.Text).First)
            Dim add As New ListViewItem(p1lab.Text$)
            add.SubItems.Add(p1)
            add.SubItems.Add(chocochilcofcount.Text$)
            add.SubItems.Add(p1 * chocochilcofcount.Text)
            ListView1.Items.Add(add)
        Catch ex As Exception
            Dim add As New ListViewItem(p1lab.Text$)
            add.SubItems.Add(p1)
            add.SubItems.Add(chocochilcofcount.Text$)
            add.SubItems.Add(p1 * chocochilcofcount.Text)
            ListView1.Items.Add(add)
        End Try
    End Sub

    Private Sub chocochilcofrem_Click(sender As Object, e As EventArgs) Handles chocochilcofrem.Click
        'Chocolate Chilled Coffee Remove Button P1
        If chocochilcofcount.Text <= 1 Then
            chocochilcofcount.Text = 0
            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = p1lab.Text).First)
            Catch ex As Exception
            End Try
        Else
            chocochilcofcount.Text = chocochilcofcount.Text - 1
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = p1lab.Text).First)

            Dim add As New ListViewItem(p1lab.Text$)
            add.SubItems.Add(p1)
            add.SubItems.Add(chocochilcofcount.Text$)
            add.SubItems.Add(chocochilcofcount.Text * p1)
            ListView1.Items.Add(add)

        End If
    End Sub

    Private Sub caramelchilcofadd_Click(sender As Object, e As EventArgs) Handles caramelchilcofadd.Click
        'Caramel Chilled Coffee Add Button P2
        caramelchilcofcount.Text = caramelchilcofcount.Text + 1

        Try
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = p2lab.Text).First)
            Dim add As New ListViewItem(p2lab.Text$)
            add.SubItems.Add(p2)
            add.SubItems.Add(caramelchilcofcount.Text$)
            add.SubItems.Add(p2 * caramelchilcofcount.Text)
            ListView1.Items.Add(add)
        Catch ex As Exception
            Dim add As New ListViewItem(p2lab.Text$)
            add.SubItems.Add(p2)
            add.SubItems.Add(caramelchilcofcount.Text$)
            add.SubItems.Add(p2 * caramelchilcofcount.Text)
            ListView1.Items.Add(add)
        End Try
    End Sub

    Private Sub caramelchilcofrem_Click(sender As Object, e As EventArgs) Handles caramelchilcofrem.Click
        'Caramel Chilled Coffee Remove Button P2
        If caramelchilcofcount.Text <= 1 Then
            caramelchilcofcount.Text = 0
            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = p2lab.Text).First)
            Catch ex As Exception
            End Try
        Else
            caramelchilcofcount.Text = caramelchilcofcount.Text - 1
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = p2lab.Text).First)

            Dim add As New ListViewItem(p2lab.Text$)
            add.SubItems.Add(p2)
            add.SubItems.Add(caramelchilcofcount.Text$)
            add.SubItems.Add(caramelchilcofcount.Text * p2)
            ListView1.Items.Add(add)

        End If
    End Sub

    Private Sub hazelchilcofadd_Click(sender As Object, e As EventArgs) Handles hazelchilcofadd.Click
        'Hazelnut Chilled Coffee Add Button P3
        hazelchilcofcount.Text = hazelchilcofcount.Text + 1

        Try
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = p3lab.Text).First)
            Dim add As New ListViewItem(p3lab.Text$)
            add.SubItems.Add(p3)
            add.SubItems.Add(hazelchilcofcount.Text$)
            add.SubItems.Add(p3 * hazelchilcofcount.Text)
            ListView1.Items.Add(add)
        Catch ex As Exception
            Dim add As New ListViewItem(p3lab.Text$)
            add.SubItems.Add(p3)
            add.SubItems.Add(hazelchilcofcount.Text$)
            add.SubItems.Add(p3 * hazelchilcofcount.Text)
            ListView1.Items.Add(add)
        End Try
    End Sub

    Private Sub hazelchilcofrem_Click(sender As Object, e As EventArgs) Handles hazelchilcofrem.Click
        'Hazelnut Chilled Coffee Remove Button P3
        If hazelchilcofcount.Text <= 1 Then
            hazelchilcofcount.Text = 0
            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = p3lab.Text).First)
            Catch ex As Exception
            End Try
        Else
            hazelchilcofcount.Text = hazelchilcofcount.Text - 1
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = p3lab.Text).First)

            Dim add As New ListViewItem(p3lab.Text$)
            add.SubItems.Add(p3)
            add.SubItems.Add(hazelchilcofcount.Text$)
            add.SubItems.Add(hazelchilcofcount.Text * p3)
            ListView1.Items.Add(add)

        End If
    End Sub

    Private Sub peanutchilcofadd_Click(sender As Object, e As EventArgs) Handles peanutchilcofadd.Click
        'Peanut-Butter Chilled Coffee Add Button P4
        peanutchilcount.Text = peanutchilcount.Text + 1

        Try
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = p4lab.Text).First)
            Dim add As New ListViewItem(p4lab.Text$)
            add.SubItems.Add(p4)
            add.SubItems.Add(peanutchilcount.Text$)
            add.SubItems.Add(p4 * peanutchilcount.Text)
            ListView1.Items.Add(add)
        Catch ex As Exception
            Dim add As New ListViewItem(p4lab.Text$)
            add.SubItems.Add(p4)
            add.SubItems.Add(peanutchilcount.Text$)
            add.SubItems.Add(p4 * peanutchilcount.Text)
            ListView1.Items.Add(add)
        End Try
    End Sub

    Private Sub peanutchilrem_Click(sender As Object, e As EventArgs) Handles peanutchilrem.Click
        'Peanut-Butter Chilled Coffee Remove Button P4
        If peanutchilcount.Text <= 1 Then
            peanutchilcount.Text = 0
            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = p4lab.Text).First)
            Catch ex As Exception
            End Try
        Else
            peanutchilcount.Text = peanutchilcount.Text - 1
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = p4lab.Text).First)

            Dim add As New ListViewItem(p4lab.Text$)
            add.SubItems.Add(p4)
            add.SubItems.Add(peanutchilcount.Text$)
            add.SubItems.Add(peanutchilcount.Text * p4)
            ListView1.Items.Add(add)

        End If
    End Sub

    Private Sub berryicedteaadd_Click(sender As Object, e As EventArgs) Handles berryicedteaadd.Click
        'Very-Berry Iced Tea Add Button T1
        berryicedteacount.Text = berryicedteacount.Text + 1

        Try
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = t1lab.Text).First)
            Dim add As New ListViewItem(t1lab.Text$)
            add.SubItems.Add(t1)
            add.SubItems.Add(berryicedteacount.Text$)
            add.SubItems.Add(t1 * berryicedteacount.Text)
            ListView1.Items.Add(add)
        Catch ex As Exception
            Dim add As New ListViewItem(t1lab.Text$)
            add.SubItems.Add(t1)
            add.SubItems.Add(berryicedteacount.Text$)
            add.SubItems.Add(t1 * berryicedteacount.Text)
            ListView1.Items.Add(add)
        End Try
    End Sub

    Private Sub berryicedtearem_Click(sender As Object, e As EventArgs) Handles berryicedtearem.Click
        'Very-Berry Iced Tea Remove Button T1
        If berryicedteacount.Text <= 1 Then
            berryicedteacount.Text = 0
            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = t1lab.Text).First)
            Catch ex As Exception
            End Try
        Else
            berryicedteacount.Text = berryicedteacount.Text - 1
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = t1lab.Text).First)

            Dim add As New ListViewItem(t1lab.Text$)
            add.SubItems.Add(t1)
            add.SubItems.Add(berryicedteacount.Text$)
            add.SubItems.Add(berryicedteacount.Text * t1)
            ListView1.Items.Add(add)

        End If
    End Sub

    Private Sub strawicedteaadd_Click(sender As Object, e As EventArgs) Handles strawicedteaadd.Click
        'Strawberry Iced Tea Add Button T2
        strawicedteacount.Text = strawicedteacount.Text + 1

        Try
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = t2lab.Text).First)
            Dim add As New ListViewItem(t2lab.Text$)
            add.SubItems.Add(t2)
            add.SubItems.Add(strawicedteacount.Text$)
            add.SubItems.Add(t2 * strawicedteacount.Text)
            ListView1.Items.Add(add)
        Catch ex As Exception
            Dim add As New ListViewItem(t2lab.Text$)
            add.SubItems.Add(t2)
            add.SubItems.Add(strawicedteacount.Text$)
            add.SubItems.Add(t2 * strawicedteacount.Text)
            ListView1.Items.Add(add)
        End Try
    End Sub

    Private Sub strawicedtearem_Click(sender As Object, e As EventArgs) Handles strawicedtearem.Click
        'Strawberry Iced Tea Remove Button T2
        If strawicedteacount.Text <= 1 Then
            strawicedteacount.Text = 0
            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = t2lab.Text).First)
            Catch ex As Exception
            End Try
        Else
            strawicedteacount.Text = strawicedteacount.Text - 1
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = t2lab.Text).First)

            Dim add As New ListViewItem(t2lab.Text$)
            add.SubItems.Add(t2)
            add.SubItems.Add(strawicedteacount.Text$)
            add.SubItems.Add(strawicedteacount.Text * t2)
            ListView1.Items.Add(add)

        End If
    End Sub

    Private Sub raspicedteaadd_Click(sender As Object, e As EventArgs) Handles raspicedteaadd.Click
        'Raspberry Iced Tea Add Button T3
        raspicedteacount.Text = raspicedteacount.Text + 1

        Try
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = t3lab.Text).First)
            Dim add As New ListViewItem(t3lab.Text$)
            add.SubItems.Add(t3)
            add.SubItems.Add(raspicedteacount.Text$)
            add.SubItems.Add(t3 * raspicedteacount.Text)
            ListView1.Items.Add(add)
        Catch ex As Exception
            Dim add As New ListViewItem(t3lab.Text$)
            add.SubItems.Add(t3)
            add.SubItems.Add(raspicedteacount.Text$)
            add.SubItems.Add(t3 * raspicedteacount.Text)
            ListView1.Items.Add(add)
        End Try
    End Sub

    Private Sub raspicedtearem_Click(sender As Object, e As EventArgs) Handles raspicedtearem.Click
        'Raspberry Iced Tea Remove Button T3
        If raspicedteacount.Text <= 1 Then
            raspicedteacount.Text = 0
            Try
                ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                        Where i.Text = t3lab.Text).First)
            Catch ex As Exception
            End Try
        Else
            raspicedteacount.Text = raspicedteacount.Text - 1
            ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                    Where i.Text = t3lab.Text).First)

            Dim add As New ListViewItem(t3lab.Text$)
            add.SubItems.Add(t3)
            add.SubItems.Add(raspicedteacount.Text$)
            add.SubItems.Add(raspicedteacount.Text * t3)
            ListView1.Items.Add(add)

        End If
    End Sub

    Private Sub neworderbut_Click(sender As Object, e As EventArgs) Handles neworderbut.Click
        If login.Visible = True Then
            login.Close()
        Else
            login.ShowDialog()

            'hot coffee
            h1 = My.Settings.h1
            h2 = My.Settings.h2
            h3 = My.Settings.h3
            h4 = My.Settings.h4
            h5 = My.Settings.h5
            h6 = My.Settings.h6
            h7 = My.Settings.h7

            'Cold Coffee
            c1 = My.Settings.c1
            c2 = My.Settings.c2
            c3 = My.Settings.c3
            c4 = My.Settings.c4

            'Lassi
            l1 = My.Settings.l1
            l2 = My.Settings.l2
            l3 = My.Settings.l3

            'Mocktail
            k1 = My.Settings.k1
            k2 = My.Settings.k2
            k3 = My.Settings.k3
            k4 = My.Settings.k4
            k5 = My.Settings.k5
            k6 = My.Settings.k6
            k7 = My.Settings.k7

            'Milkshake
            m1 = My.Settings.m1
            m2 = My.Settings.m2
            m3 = My.Settings.m3
            m4 = My.Settings.m4
            m5 = My.Settings.m5
            m6 = My.Settings.m6

            'Lemonade
            n1 = My.Settings.n1
            n2 = My.Settings.n2

            'Crusher
            r1 = My.Settings.r1
            r2 = My.Settings.r2
            r3 = My.Settings.r3
            r4 = My.Settings.r4
            r5 = My.Settings.r5

            'Premium Chilled
            p1 = My.Settings.p1
            p2 = My.Settings.p2
            p3 = My.Settings.p3
            p4 = My.Settings.p4

            'Iced Tea
            t1 = My.Settings.t1
            t2 = My.Settings.t2
            t3 = My.Settings.t3

            clearalllist()



        End If


    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If orderquant.Text = Nothing Then


            Try

                If cuppucount.Text & lattecount.Text & mochacount.Text & blackcount.Text & caramelmaccount.Text & vanillalattecount.Text & hazelnutlattecount.Text & coldcofcount.Text & chococoldcofcount.Text & vanillacoldcofcount.Text & caramelcoldcofcount.Text & lassicount.Text & espressolassicount.Text & mangolassicount.Text & virsanfrancount.Text & virsangriacount.Text & virapplecount.Text & grapeinvadecount.Text & bluebersparkcount.Text & yellowpunchcount.Text & darkcurrantcount.Text & vanillamilkcount.Text & chocomilkcount.Text & mangomilkcount.Text & strawberrymilkcount.Text & bananamilkcount.Text & peanutbuttermilkcount.Text & lemonmojitocount.Text & orangelemoncount.Text & oreocount.Text & snickerscount.Text & kitkatcount.Text & darkchococount.Text & ferrerocount.Text & chocochilcofcount.Text & caramelchilcofcount.Text & hazelchilcofcount.Text & peanutchilcount.Text & berryicedteacount.Text & strawicedteacount.Text & raspicedteacount.Text = 0 Then
                    MsgBox("No Item Was Selected!")
                Else
                    If DateTime.Now.ToString("dd-MMM-yyyy") = My.Settings.todaycheck Then

                        'backprint()
                        'frontprint()


                        My.Settings.ordercountday = My.Settings.ordercountday + 1

                        todaydate.Text = My.Settings.todaycheck
                        orderquant.Text = 1
                        My.Settings.ordernow = My.Settings.ordernow + 1
                        LiqfinalBindingSource.EndEdit()
                        LiqfinalTableAdapter.Update(Liqdbase.liqfinal)
                        My.Settings.Save()

                        LiqfinalBindingSource.AddNew()
                        due.Checked = False
                        ListView1.Items.Clear()
                        LiqfinalBindingSource.MoveLast()
                        orderno.Text = My.Settings.ordercountday
                        TabControl1.SelectTab(0)

                    Else
                        LiqfinalBindingSource.MoveLast()
                        My.Settings.todaycheck = DateTime.Now.ToString("dd-MMM-yyyy")
                        My.Settings.ordercountday = 0
                        My.Settings.alltotorder = 0
                        My.Settings.ordernow = 0
                        My.Settings.Save()
                        orderno.Text = My.Settings.ordercountday



                        My.Settings.ordercountday = My.Settings.ordercountday + 1
                        orderno.Text = My.Settings.ordercountday
                        todaydate.Text = My.Settings.todaycheck
                        orderquant.Text = 1
                        My.Settings.ordernow = My.Settings.ordernow + 1
                        LiqfinalBindingSource.EndEdit()
                        LiqfinalTableAdapter.Update(Liqdbase.liqfinal)
                        My.Settings.Save()

                        LiqfinalBindingSource.AddNew()
                        due.Checked = False
                        ListView1.Items.Clear()
                        LiqfinalBindingSource.MoveLast()
                        orderno.Text = My.Settings.ordercountday
                        TabControl1.SelectTab(0)

                    End If
                End If

            Catch ex As Exception

            End Try
        Else
            If cuppucount.Text & lattecount.Text & mochacount.Text & blackcount.Text & caramelmaccount.Text & vanillalattecount.Text & hazelnutlattecount.Text & coldcofcount.Text & chococoldcofcount.Text & vanillacoldcofcount.Text & caramelcoldcofcount.Text & lassicount.Text & espressolassicount.Text & mangolassicount.Text & virsanfrancount.Text & virsangriacount.Text & virapplecount.Text & grapeinvadecount.Text & bluebersparkcount.Text & yellowpunchcount.Text & darkcurrantcount.Text & vanillamilkcount.Text & chocomilkcount.Text & mangomilkcount.Text & strawberrymilkcount.Text & bananamilkcount.Text & peanutbuttermilkcount.Text & lemonmojitocount.Text & orangelemoncount.Text & oreocount.Text & snickerscount.Text & kitkatcount.Text & darkchococount.Text & ferrerocount.Text & chocochilcofcount.Text & caramelchilcofcount.Text & hazelchilcofcount.Text & peanutchilcount.Text & berryicedteacount.Text & strawicedteacount.Text & raspicedteacount.Text = 0 Then
                MsgBox("No Item Was Selected!")
            Else
                Try
                    LiqfinalBindingSource.EndEdit()
                    LiqfinalTableAdapter.Update(Liqdbase.liqfinal)
                    LiqfinalBindingSource.RemoveFilter()
                    LiqfinalBindingSource.MoveLast()
                    If orderquant.Text = Nothing Then
                        orderno.Text = My.Settings.ordercountday
                        My.Settings.Save()
                        due.Checked = False
                    Else
                        LiqfinalBindingSource.AddNew()
                        orderno.Text = My.Settings.ordercountday
                        My.Settings.Save()
                        due.Checked = False
                    End If

                Catch ex As Exception

                End Try
            End If
        End If
    End Sub

    Private Sub frontprint()

        recpt.Text = Nothing
        recpt.Text = "Liquor Lounge" + Environment.NewLine + "============"
        recpt.Text = recpt.Text + Environment.NewLine + "Order No: " + orderno.Text + Environment.NewLine + "============" + Environment.NewLine


        If cuppucount.Text > 0 Then
            recpt.Text = recpt.Text + "H1 X " + cuppucount.Text + Environment.NewLine
        End If

        If lattecount.Text > 0 Then
            recpt.Text = recpt.Text + "H2 X " + lattecount.Text + Environment.NewLine
        End If

        If mochacount.Text > 0 Then
            recpt.Text = recpt.Text + "H3 X " + mochacount.Text + Environment.NewLine
        End If

        If blackcount.Text > 0 Then
            recpt.Text = recpt.Text + "H4 X " + blackcount.Text + Environment.NewLine
        End If

        If caramelmaccount.Text > 0 Then
            recpt.Text = recpt.Text + "H5 X " + caramelmaccount.Text + Environment.NewLine
        End If

        If vanillalattecount.Text > 0 Then
            recpt.Text = recpt.Text + "H6 X " + vanillalattecount.Text + Environment.NewLine
        End If

        If hazelnutlattecount.Text > 0 Then
            recpt.Text = recpt.Text + "H7 X " + hazelnutlattecount.Text + Environment.NewLine
        End If

        If coldcofcount.Text > 0 Then
            recpt.Text = recpt.Text + "C1 X " + coldcofcount.Text + Environment.NewLine
        End If

        If chococoldcofcount.Text > 0 Then
            recpt.Text = recpt.Text + "C2 X " + chococoldcofcount.Text + Environment.NewLine
        End If

        If vanillacoldcofcount.Text > 0 Then
            recpt.Text = recpt.Text + "C3 X " + vanillacoldcofcount.Text + Environment.NewLine
        End If

        If caramelcoldcofcount.Text > 0 Then
            recpt.Text = recpt.Text + "C4 X " + caramelcoldcofcount.Text + Environment.NewLine
        End If

        If lassicount.Text > 0 Then
            recpt.Text = recpt.Text + "L1 X " + lassicount.Text + Environment.NewLine
        End If

        If espressolassicount.Text > 0 Then
            recpt.Text = recpt.Text + "L2 X " + espressolassicount.Text + Environment.NewLine
        End If

        If mangolassicount.Text > 0 Then
            recpt.Text = recpt.Text + "L3 X " + mangolassicount.Text + Environment.NewLine
        End If

        If virsanfrancount.Text > 0 Then
            recpt.Text = recpt.Text + "K1 X " + virsanfrancount.Text + Environment.NewLine
        End If

        If virsangriacount.Text > 0 Then
            recpt.Text = recpt.Text + "K2 X " + virsangriacount.Text + Environment.NewLine
        End If

        If virapplecount.Text > 0 Then
            recpt.Text = recpt.Text + "K3 X " + virapplecount.Text + Environment.NewLine
        End If

        If grapeinvadecount.Text > 0 Then
            recpt.Text = recpt.Text + "K4 X " + grapeinvadecount.Text + Environment.NewLine
        End If

        If bluebersparkcount.Text > 0 Then
            recpt.Text = recpt.Text + "K5 X " + bluebersparkcount.Text + Environment.NewLine
        End If

        If yellowpunchcount.Text > 0 Then
            recpt.Text = recpt.Text + "K6 X " + yellowpunchcount.Text + Environment.NewLine
        End If

        If darkcurrantcount.Text > 0 Then
            recpt.Text = recpt.Text + "K7 X " + darkcurrantcount.Text + Environment.NewLine
        End If

        If vanillamilkcount.Text > 0 Then
            recpt.Text = recpt.Text + "M1 X " + vanillamilkcount.Text + Environment.NewLine
        End If

        If chocomilkcount.Text > 0 Then
            recpt.Text = recpt.Text + "M2 X " + chocomilkcount.Text + Environment.NewLine
        End If

        If mangomilkcount.Text > 0 Then
            recpt.Text = recpt.Text + "M3 X " + mangomilkcount.Text + Environment.NewLine
        End If

        If strawberrymilkcount.Text > 0 Then
            recpt.Text = recpt.Text + "M4 X " + strawberrymilkcount.Text + Environment.NewLine
        End If

        If bananamilkcount.Text > 0 Then
            recpt.Text = recpt.Text + "M5 X " + bananamilkcount.Text + Environment.NewLine
        End If

        If peanutbuttermilkcount.Text > 0 Then
            recpt.Text = recpt.Text + "M6 X " + peanutbuttermilkcount.Text + Environment.NewLine
        End If

        If lemonmojitocount.Text > 0 Then
            recpt.Text = recpt.Text + "N1 X " + lemonmojitocount.Text + Environment.NewLine
        End If

        If orangelemoncount.Text > 0 Then
            recpt.Text = recpt.Text + "N2 X " + orangelemoncount.Text + Environment.NewLine
        End If

        If oreocount.Text > 0 Then
            recpt.Text = recpt.Text + "R1 X " + oreocount.Text + Environment.NewLine
        End If

        If snickerscount.Text > 0 Then
            recpt.Text = recpt.Text + "R2 X " + snickerscount.Text + Environment.NewLine
        End If

        If kitkatcount.Text > 0 Then
            recpt.Text = recpt.Text + "R3 X " + kitkatcount.Text + Environment.NewLine
        End If

        If darkchococount.Text > 0 Then
            recpt.Text = recpt.Text + "R4 X " + darkchococount.Text + Environment.NewLine
        End If

        If ferrerocount.Text > 0 Then
            recpt.Text = recpt.Text + "R5 X " + ferrerocount.Text + Environment.NewLine
        End If

        If chocochilcofcount.Text > 0 Then
            recpt.Text = recpt.Text + "P1 X " + chocochilcofcount.Text + Environment.NewLine
        End If

        If caramelchilcofcount.Text > 0 Then
            recpt.Text = recpt.Text + "P2 X " + caramelchilcofcount.Text + Environment.NewLine
        End If

        If hazelchilcofcount.Text > 0 Then
            recpt.Text = recpt.Text + "P3 X " + hazelchilcofcount.Text + Environment.NewLine
        End If

        If peanutchilcount.Text > 0 Then
            recpt.Text = recpt.Text + "P4 X " + peanutchilcount.Text + Environment.NewLine
        End If

        If berryicedteacount.Text > 0 Then
            recpt.Text = recpt.Text + "T1 X " + berryicedteacount.Text + Environment.NewLine
        End If

        If strawicedteacount.Text > 0 Then
            recpt.Text = recpt.Text + "T2 X " + strawicedteacount.Text + Environment.NewLine
        End If

        If raspicedteacount.Text > 0 Then
            recpt.Text = recpt.Text + "T3 X " + raspicedteacount.Text + Environment.NewLine
        End If



        If duetextbox.Text = Nothing Then

            recpt.Text = recpt.Text + "============" + Environment.NewLine + "Paid: " + uigrandtotal.Text + "/-" + Environment.NewLine + "============" + Environment.NewLine + "Made by LeyLance"
        Else
            recpt.Text = recpt.Text + "============" + Environment.NewLine + "Paid: " + uigrandtotal.Text + "/- [Due]" + Environment.NewLine + "Name: " + duetextbox.Text + Environment.NewLine + "============" + Environment.NewLine + "Made by LeyLance"

        End If
        Dim frontprinter As New myPrinter
        frontprinter.print(recpt.Text)


    End Sub

    Private Sub backprint()


        recpt.Text = Nothing
        recpt.Text = "Liquor Lounge" + Environment.NewLine + "============"
        recpt.Text = recpt.Text + Environment.NewLine + "Order No: " + orderno.Text + Environment.NewLine + "============" + Environment.NewLine


        If cuppucount.Text > 0 Then
            recpt.Text = recpt.Text + "H1 X " + cuppucount.Text + Environment.NewLine
        End If

        If lattecount.Text > 0 Then
            recpt.Text = recpt.Text + "H2 X " + lattecount.Text + Environment.NewLine
        End If

        If mochacount.Text > 0 Then
            recpt.Text = recpt.Text + "H3 X " + mochacount.Text + Environment.NewLine
        End If

        If blackcount.Text > 0 Then
            recpt.Text = recpt.Text + "H4 X " + blackcount.Text + Environment.NewLine
        End If

        If caramelmaccount.Text > 0 Then
            recpt.Text = recpt.Text + "H5 X " + caramelmaccount.Text + Environment.NewLine
        End If

        If vanillalattecount.Text > 0 Then
            recpt.Text = recpt.Text + "H6 X " + vanillalattecount.Text + Environment.NewLine
        End If

        If hazelnutlattecount.Text > 0 Then
            recpt.Text = recpt.Text + "H7 X " + hazelnutlattecount.Text + Environment.NewLine
        End If

        If coldcofcount.Text > 0 Then
            recpt.Text = recpt.Text + "C1 X " + coldcofcount.Text + Environment.NewLine
        End If

        If chococoldcofcount.Text > 0 Then
            recpt.Text = recpt.Text + "C2 X " + chococoldcofcount.Text + Environment.NewLine
        End If

        If vanillacoldcofcount.Text > 0 Then
            recpt.Text = recpt.Text + "C3 X " + vanillacoldcofcount.Text + Environment.NewLine
        End If

        If caramelcoldcofcount.Text > 0 Then
            recpt.Text = recpt.Text + "C4 X " + caramelcoldcofcount.Text + Environment.NewLine
        End If

        If lassicount.Text > 0 Then
            recpt.Text = recpt.Text + "L1 X " + lassicount.Text + Environment.NewLine
        End If

        If espressolassicount.Text > 0 Then
            recpt.Text = recpt.Text + "L2 X " + espressolassicount.Text + Environment.NewLine
        End If

        If mangolassicount.Text > 0 Then
            recpt.Text = recpt.Text + "L3 X " + mangolassicount.Text + Environment.NewLine
        End If

        If virsanfrancount.Text > 0 Then
            recpt.Text = recpt.Text + "K1 X " + virsanfrancount.Text + Environment.NewLine
        End If

        If virsangriacount.Text > 0 Then
            recpt.Text = recpt.Text + "K2 X " + virsangriacount.Text + Environment.NewLine
        End If

        If virapplecount.Text > 0 Then
            recpt.Text = recpt.Text + "K3 X " + virapplecount.Text + Environment.NewLine
        End If

        If grapeinvadecount.Text > 0 Then
            recpt.Text = recpt.Text + "K4 X " + grapeinvadecount.Text + Environment.NewLine
        End If

        If bluebersparkcount.Text > 0 Then
            recpt.Text = recpt.Text + "K5 X " + bluebersparkcount.Text + Environment.NewLine
        End If

        If yellowpunchcount.Text > 0 Then
            recpt.Text = recpt.Text + "K6 X " + yellowpunchcount.Text + Environment.NewLine
        End If

        If darkcurrantcount.Text > 0 Then
            recpt.Text = recpt.Text + "K7 X " + darkcurrantcount.Text + Environment.NewLine
        End If

        If vanillamilkcount.Text > 0 Then
            recpt.Text = recpt.Text + "M1 X " + vanillamilkcount.Text + Environment.NewLine
        End If

        If chocomilkcount.Text > 0 Then
            recpt.Text = recpt.Text + "M2 X " + chocomilkcount.Text + Environment.NewLine
        End If

        If mangomilkcount.Text > 0 Then
            recpt.Text = recpt.Text + "M3 X " + mangomilkcount.Text + Environment.NewLine
        End If

        If strawberrymilkcount.Text > 0 Then
            recpt.Text = recpt.Text + "M4 X " + strawberrymilkcount.Text + Environment.NewLine
        End If

        If bananamilkcount.Text > 0 Then
            recpt.Text = recpt.Text + "M5 X " + bananamilkcount.Text + Environment.NewLine
        End If

        If peanutbuttermilkcount.Text > 0 Then
            recpt.Text = recpt.Text + "M6 X " + peanutbuttermilkcount.Text + Environment.NewLine
        End If

        If lemonmojitocount.Text > 0 Then
            recpt.Text = recpt.Text + "N1 X " + lemonmojitocount.Text + Environment.NewLine
        End If

        If orangelemoncount.Text > 0 Then
            recpt.Text = recpt.Text + "N2 X " + orangelemoncount.Text + Environment.NewLine
        End If

        If oreocount.Text > 0 Then
            recpt.Text = recpt.Text + "R1 X " + oreocount.Text + Environment.NewLine
        End If

        If snickerscount.Text > 0 Then
            recpt.Text = recpt.Text + "R2 X " + snickerscount.Text + Environment.NewLine
        End If

        If kitkatcount.Text > 0 Then
            recpt.Text = recpt.Text + "R3 X " + kitkatcount.Text + Environment.NewLine
        End If

        If darkchococount.Text > 0 Then
            recpt.Text = recpt.Text + "R4 X " + darkchococount.Text + Environment.NewLine
        End If

        If ferrerocount.Text > 0 Then
            recpt.Text = recpt.Text + "R5 X " + ferrerocount.Text + Environment.NewLine
        End If

        If chocochilcofcount.Text > 0 Then
            recpt.Text = recpt.Text + "P1 X " + chocochilcofcount.Text + Environment.NewLine
        End If

        If caramelchilcofcount.Text > 0 Then
            recpt.Text = recpt.Text + "P2 X " + caramelchilcofcount.Text + Environment.NewLine
        End If

        If hazelchilcofcount.Text > 0 Then
            recpt.Text = recpt.Text + "P3 X " + hazelchilcofcount.Text + Environment.NewLine
        End If

        If peanutchilcount.Text > 0 Then
            recpt.Text = recpt.Text + "P4 X " + peanutchilcount.Text + Environment.NewLine
        End If

        If berryicedteacount.Text > 0 Then
            recpt.Text = recpt.Text + "T1 X " + berryicedteacount.Text + Environment.NewLine
        End If

        If strawicedteacount.Text > 0 Then
            recpt.Text = recpt.Text + "T2 X " + strawicedteacount.Text + Environment.NewLine
        End If

        If raspicedteacount.Text > 0 Then
            recpt.Text = recpt.Text + "T3 X " + raspicedteacount.Text + Environment.NewLine
        End If





        recpt.Text = recpt.Text + "============" + Environment.NewLine + "Made by LeyLance"
        Dim backprinter As New myPrinter
        backprinter.print(recpt.Text)



    End Sub

    Private Sub toggledbase_Click(sender As Object, e As EventArgs) Handles toggledbase.Click
        Try
            If DbfinalDataGridView.Visible = True Then
                DbfinalDataGridView.Visible = False
                updatelistview()
                orderno.Location = New Point(100, 61)
                todaydate.Location = New Point(100, 147)

                DbfinalDataGridView.Visible = False
                dbsearchbox.Visible = False
                CheckBox1.Visible = False
                fromdate.Visible = False
                ordrtoday.Visible = False
                totordercount.Visible = False


                'listviewupdate.Stop()

            Else
                DbfinalDataGridView.Visible = True
                orderno.Location = New Point(6, 61)
                todaydate.Location = New Point(6, 147)
                dbsearchbox.Visible = True
                CheckBox1.Visible = True
                fromdate.Visible = True
                totordercount.Visible = True

                ordrtoday.Visible = True
                'listviewupdate.Start()


            End If
        Catch ex As Exception

            If DbfinalDataGridView.Visible = True Then

                DbfinalDataGridView.Visible = False
                updatelistview()
                orderno.Location = New Point(100, 61)
                todaydate.Location = New Point(100, 147)

                DbfinalDataGridView.Visible = False
                dbsearchbox.Visible = False
                CheckBox1.Visible = False
                fromdate.Visible = False
                ordrtoday.Visible = False
                totordercount.Visible = False



                'listviewupdate.Stop()

            Else
                DbfinalDataGridView.Visible = True
                orderno.Location = New Point(6, 61)
                todaydate.Location = New Point(6, 147)
                dbsearchbox.Visible = True
                CheckBox1.Visible = True
                fromdate.Visible = True
                totordercount.Visible = True

                ordrtoday.Visible = True
                'listviewupdate.Start()

            End If
        End Try
    End Sub

    Private Sub updatelistview()

        'Listview Update After Every 5 Seconds
        ListView1.Items.Clear()
        'Cuppuccino H1
        Try
            If cuppucount.Text > 0 Then
                Dim add As New ListViewItem(h1lab.Text$)
                add.SubItems.Add(h1)
                add.SubItems.Add(cuppucount.Text$)
                add.SubItems.Add(h1 * cuppucount.Text)
                ListView1.Items.Add(add)
            ElseIf cuppucount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = h1lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'Latte H2
            If lattecount.Text > 0 Then
                Dim add As New ListViewItem(h2lab.Text$)
                add.SubItems.Add(h2)
                add.SubItems.Add(lattecount.Text$)
                add.SubItems.Add(h2 * lattecount.Text)
                ListView1.Items.Add(add)
            ElseIf lattecount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = h2lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'Cafe Mocha H3
            If mochacount.Text > 0 Then
                Dim add As New ListViewItem(h3lab.Text$)
                add.SubItems.Add(h3)
                add.SubItems.Add(mochacount.Text$)
                add.SubItems.Add(h3 * mochacount.Text)
                ListView1.Items.Add(add)
            ElseIf mochacount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = h3lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'Black Coffee h4
            If blackcount.Text > 0 Then
                Dim add As New ListViewItem(h4lab.Text$)
                add.SubItems.Add(h4)
                add.SubItems.Add(blackcount.Text$)
                add.SubItems.Add(h4 * blackcount.Text)
                ListView1.Items.Add(add)
            ElseIf blackcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = h4lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'Caramel Macchiato h5
            If caramelmaccount.Text > 0 Then
                Dim add As New ListViewItem(h5lab.Text$)
                add.SubItems.Add(h5)
                add.SubItems.Add(caramelmaccount.Text$)
                add.SubItems.Add(h5 * caramelmaccount.Text)
                ListView1.Items.Add(add)
            ElseIf caramelmaccount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = h5lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'Vanilla Latte h6
            If vanillalattecount.Text > 0 Then
                Dim add As New ListViewItem(h6lab.Text$)
                add.SubItems.Add(h6)
                add.SubItems.Add(vanillalattecount.Text$)
                add.SubItems.Add(h6 * vanillalattecount.Text)
                ListView1.Items.Add(add)
            ElseIf vanillalattecount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = h6lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'Hazelnut Latte h7
            If hazelnutlattecount.Text > 0 Then
                Dim add As New ListViewItem(h7lab.Text$)
                add.SubItems.Add(h7)
                add.SubItems.Add(hazelnutlattecount.Text$)
                add.SubItems.Add(h7 * hazelnutlattecount.Text)
                ListView1.Items.Add(add)
            ElseIf hazelnutlattecount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = h7lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'Cold Coffee Regular c1
            If coldcofcount.Text > 0 Then
                Dim add As New ListViewItem(c1lab.Text$)
                add.SubItems.Add(c1)
                add.SubItems.Add(coldcofcount.Text$)
                add.SubItems.Add(c1 * coldcofcount.Text)
                ListView1.Items.Add(add)
            ElseIf coldcofcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = c1lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'Chocolate Cold Coffee c2
            If chococoldcofcount.Text > 0 Then
                Dim add As New ListViewItem(c2lab.Text$)
                add.SubItems.Add(c2)
                add.SubItems.Add(chococoldcofcount.Text$)
                add.SubItems.Add(c2 * chococoldcofcount.Text)
                ListView1.Items.Add(add)
            ElseIf chococoldcofcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = c2lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'Vanilla Cold Coffee c3
            If vanillacoldcofcount.Text > 0 Then
                Dim add As New ListViewItem(c3lab.Text$)
                add.SubItems.Add(c3)
                add.SubItems.Add(vanillacoldcofcount.Text$)
                add.SubItems.Add(c3 * vanillacoldcofcount.Text)
                ListView1.Items.Add(add)
            ElseIf vanillacoldcofcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = c3lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'Caramel Cold Coffee c4
            If caramelcoldcofcount.Text > 0 Then
                Dim add As New ListViewItem(c4lab.Text$)
                add.SubItems.Add(c4)
                add.SubItems.Add(caramelcoldcofcount.Text$)
                add.SubItems.Add(c4 * caramelcoldcofcount.Text)
                ListView1.Items.Add(add)
            ElseIf caramelcoldcofcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = c4lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'Lassi Regular L1
            If lassicount.Text > 0 Then
                Dim add As New ListViewItem(l1lab.Text$)
                add.SubItems.Add(l1)
                add.SubItems.Add(lassicount.Text$)
                add.SubItems.Add(l1 * lassicount.Text)
                ListView1.Items.Add(add)
            ElseIf lassicount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = l1lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'Espresso Lassi L2
            If espressolassicount.Text > 0 Then
                Dim add As New ListViewItem(l2lab.Text$)
                add.SubItems.Add(l2)
                add.SubItems.Add(espressolassicount.Text$)
                add.SubItems.Add(l2 * espressolassicount.Text)
                ListView1.Items.Add(add)
            ElseIf espressolassicount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = l2lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'Mango Lassi L3
            If mangolassicount.Text > 0 Then
                Dim add As New ListViewItem(l3lab.Text$)
                add.SubItems.Add(l3)
                add.SubItems.Add(mangolassicount.Text$)
                add.SubItems.Add(l3 * mangolassicount.Text)
                ListView1.Items.Add(add)
            ElseIf mangolassicount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = l3lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'K1 Virgin Sanfrancisco
            If virsanfrancount.Text > 0 Then
                Dim add As New ListViewItem(k1lab.Text$)
                add.SubItems.Add(k1)
                add.SubItems.Add(virsanfrancount.Text$)
                add.SubItems.Add(k1 * virsanfrancount.Text)
                ListView1.Items.Add(add)
            ElseIf virsanfrancount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = k1lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'K2 Virgin Sangria
            If virsangriacount.Text > 0 Then
                Dim add As New ListViewItem(k2lab.Text$)
                add.SubItems.Add(k2)
                add.SubItems.Add(virsangriacount.Text$)
                add.SubItems.Add(k2 * virsangriacount.Text)
                ListView1.Items.Add(add)
            ElseIf virsangriacount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = k2lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'K3 Virgin Appletini
            If virapplecount.Text > 0 Then
                Dim add As New ListViewItem(k3lab.Text$)
                add.SubItems.Add(k3)
                add.SubItems.Add(virapplecount.Text$)
                add.SubItems.Add(k3 * virapplecount.Text)
                ListView1.Items.Add(add)
            ElseIf virapplecount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = k3lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'K4 Grape Invader
            If grapeinvadecount.Text > 0 Then
                Dim add As New ListViewItem(k4lab.Text$)
                add.SubItems.Add(k4)
                add.SubItems.Add(grapeinvadecount.Text$)
                add.SubItems.Add(k4 * grapeinvadecount.Text)
                ListView1.Items.Add(add)
            ElseIf grapeinvadecount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = k4lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'K5 Blueberry Sparkler
            If bluebersparkcount.Text > 0 Then
                Dim add As New ListViewItem(k5lab.Text$)
                add.SubItems.Add(k5)
                add.SubItems.Add(bluebersparkcount.Text$)
                add.SubItems.Add(k5 * bluebersparkcount.Text)
                ListView1.Items.Add(add)
            ElseIf bluebersparkcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = k5lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'K6 Yellow Punch
            If yellowpunchcount.Text > 0 Then
                Dim add As New ListViewItem(k6lab.Text$)
                add.SubItems.Add(k6)
                add.SubItems.Add(yellowpunchcount.Text$)
                add.SubItems.Add(k6 * yellowpunchcount.Text)
                ListView1.Items.Add(add)
            ElseIf yellowpunchcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = k6lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'K7 Dark Currant
            If darkcurrantcount.Text > 0 Then
                Dim add As New ListViewItem(k7lab.Text$)
                add.SubItems.Add(k7)
                add.SubItems.Add(darkcurrantcount.Text$)
                add.SubItems.Add(k7 * darkcurrantcount.Text)
                ListView1.Items.Add(add)
            ElseIf darkcurrantcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = k7lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'M1 Vanilla Milk Shake
            If vanillamilkcount.Text > 0 Then
                Dim add As New ListViewItem(m1lab.Text$)
                add.SubItems.Add(m1)
                add.SubItems.Add(vanillamilkcount.Text$)
                add.SubItems.Add(m1 * vanillamilkcount.Text)
                ListView1.Items.Add(add)
            ElseIf vanillamilkcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = m1lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'M2 Chocolate Milkshake
            If chocomilkcount.Text > 0 Then
                Dim add As New ListViewItem(m2lab.Text$)
                add.SubItems.Add(m2)
                add.SubItems.Add(chocomilkcount.Text$)
                add.SubItems.Add(m2 * chocomilkcount.Text)
                ListView1.Items.Add(add)
            ElseIf chocomilkcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = m2lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'M3 Mango Milkshake
            If mangomilkcount.Text > 0 Then
                Dim add As New ListViewItem(m3lab.Text$)
                add.SubItems.Add(m3)
                add.SubItems.Add(mangomilkcount.Text$)
                add.SubItems.Add(m3 * mangomilkcount.Text)
                ListView1.Items.Add(add)
            ElseIf mangomilkcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = m3lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'M4 Strawberry Milkshake
            If strawberrymilkcount.Text > 0 Then
                Dim add As New ListViewItem(m4lab.Text$)
                add.SubItems.Add(m4)
                add.SubItems.Add(strawberrymilkcount.Text$)
                add.SubItems.Add(m4 * strawberrymilkcount.Text)
                ListView1.Items.Add(add)
            ElseIf strawberrymilkcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = m4lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'M5 Banana Milkshake 
            If bananamilkcount.Text > 0 Then
                Dim add As New ListViewItem(m5lab.Text$)
                add.SubItems.Add(m5)
                add.SubItems.Add(bananamilkcount.Text$)
                add.SubItems.Add(m5 * bananamilkcount.Text)
                ListView1.Items.Add(add)
            ElseIf bananamilkcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = m5lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'M6 Peanut Butter Milk shake
            If peanutbuttermilkcount.Text > 0 Then
                Dim add As New ListViewItem(m6lab.Text$)
                add.SubItems.Add(m6)
                add.SubItems.Add(peanutbuttermilkcount.Text$)
                add.SubItems.Add(m6 * peanutbuttermilkcount.Text)
                ListView1.Items.Add(add)
            ElseIf peanutbuttermilkcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = m6lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'N1 Lemon Mojito
            If lemonmojitocount.Text > 0 Then
                Dim add As New ListViewItem(n1lab.Text$)
                add.SubItems.Add(n1)
                add.SubItems.Add(lemonmojitocount.Text$)
                add.SubItems.Add(n1 * lemonmojitocount.Text)
                ListView1.Items.Add(add)
            ElseIf lemonmojitocount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = n1lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'N2 Orange Lemonade
            If orangelemoncount.Text > 0 Then
                Dim add As New ListViewItem(n2lab.Text$)
                add.SubItems.Add(n2)
                add.SubItems.Add(orangelemoncount.Text$)
                add.SubItems.Add(n2 * orangelemoncount.Text)
                ListView1.Items.Add(add)
            ElseIf orangelemoncount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = n2lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'R1 Oreo Crusher
            If oreocount.Text > 0 Then
                Dim add As New ListViewItem(r1lab.Text$)
                add.SubItems.Add(r1)
                add.SubItems.Add(oreocount.Text$)
                add.SubItems.Add(r1 * oreocount.Text)
                ListView1.Items.Add(add)
            ElseIf oreocount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = r1lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'R2 Snickers Crusher
            If snickerscount.Text > 0 Then
                Dim add As New ListViewItem(r2lab.Text$)
                add.SubItems.Add(r2)
                add.SubItems.Add(snickerscount.Text$)
                add.SubItems.Add(r2 * snickerscount.Text)
                ListView1.Items.Add(add)
            ElseIf snickerscount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = r2lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'R3 Kitkat Crusher
            If kitkatcount.Text > 0 Then
                Dim add As New ListViewItem(r3lab.Text$)
                add.SubItems.Add(r3)
                add.SubItems.Add(kitkatcount.Text$)
                add.SubItems.Add(r3 * kitkatcount.Text)
                ListView1.Items.Add(add)
            ElseIf kitkatcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = r3lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'R4 Dark Chocolate Crusher
            If darkchococount.Text > 0 Then
                Dim add As New ListViewItem(r4lab.Text$)
                add.SubItems.Add(r4)
                add.SubItems.Add(darkchococount.Text$)
                add.SubItems.Add(r4 * darkchococount.Text)
                ListView1.Items.Add(add)
            ElseIf darkchococount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = r4lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'R5 Ferrero Rocher Crusher
            If ferrerocount.Text > 0 Then
                Dim add As New ListViewItem(r5lab.Text$)
                add.SubItems.Add(r5)
                add.SubItems.Add(ferrerocount.Text$)
                add.SubItems.Add(r5 * ferrerocount.Text)
                ListView1.Items.Add(add)
            ElseIf ferrerocount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = r5lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'P1 Chocolate Chilled Coffee
            If chocochilcofcount.Text > 0 Then
                Dim add As New ListViewItem(p1lab.Text$)
                add.SubItems.Add(p1)
                add.SubItems.Add(chocochilcofcount.Text$)
                add.SubItems.Add(p1 * chocochilcofcount.Text)
                ListView1.Items.Add(add)
            ElseIf chocochilcofcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = p1lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'P2 Caramel Chilled Coffee
            If caramelchilcofcount.Text > 0 Then
                Dim add As New ListViewItem(p2lab.Text$)
                add.SubItems.Add(p2)
                add.SubItems.Add(caramelchilcofcount.Text$)
                add.SubItems.Add(p2 * caramelchilcofcount.Text)
                ListView1.Items.Add(add)
            ElseIf caramelchilcofcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = p2lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'P3 Hazelnut Chilled Coffee
            If hazelchilcofcount.Text > 0 Then
                Dim add As New ListViewItem(p3lab.Text$)
                add.SubItems.Add(p3)
                add.SubItems.Add(hazelchilcofcount.Text$)
                add.SubItems.Add(p3 * hazelchilcofcount.Text)
                ListView1.Items.Add(add)
            ElseIf hazelchilcofcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = p3lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'P4 Peanut Butter Chilled Coffee
            If peanutchilcount.Text > 0 Then
                Dim add As New ListViewItem(p4lab.Text$)
                add.SubItems.Add(p4)
                add.SubItems.Add(peanutchilcount.Text$)
                add.SubItems.Add(p4 * peanutchilcount.Text)
                ListView1.Items.Add(add)
            ElseIf peanutchilcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = p4lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'T1 Very Berry Iced Tea
            If berryicedteacount.Text > 0 Then
                Dim add As New ListViewItem(t1lab.Text$)
                add.SubItems.Add(t1)
                add.SubItems.Add(berryicedteacount.Text$)
                add.SubItems.Add(t1 * berryicedteacount.Text)
                ListView1.Items.Add(add)
            ElseIf berryicedteacount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = t1lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'T2 Strawberry Iced Tea
            If strawicedteacount.Text > 0 Then
                Dim add As New ListViewItem(t2lab.Text$)
                add.SubItems.Add(t2)
                add.SubItems.Add(strawicedteacount.Text$)
                add.SubItems.Add(t2 * strawicedteacount.Text)
                ListView1.Items.Add(add)
            ElseIf strawicedteacount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = t2lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'T3 Raspberry Iced Tea
            If raspicedteacount.Text > 0 Then
                Dim add As New ListViewItem(t3lab.Text$)
                add.SubItems.Add(t3)
                add.SubItems.Add(raspicedteacount.Text$)
                add.SubItems.Add(t3 * raspicedteacount.Text)
                ListView1.Items.Add(add)
            ElseIf raspicedteacount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = t3lab.Text).First)
                Catch ex As Exception
                End Try
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refreshbutton.Click

        LiqfinalBindingSource.RemoveFilter()



        LiqfinalBindingSource.MoveLast()
        If orderquant.Text = Nothing Then
            clearalllist()
            dbsearchbox.Text = Nothing

            CheckBox1.Checked = False
            duetextbox.Text = Nothing

            todaydate.Text = My.Settings.todaycheck


            orderno.Text = My.Settings.ordercountday

            LiqfinalBindingSource.EndEdit()
            LiqfinalTableAdapter.Update(Liqdbase.liqfinal)

            LiqfinalBindingSource.RemoveFilter()

            LiqfinalBindingSource.Filter = String.Format("OrderDate = #{0:dd/MMM/yy}#", fromdate.Value)
            With DbfinalDataGridView
                .DataSource = LiqfinalBindingSource
            End With


        Else
            LiqfinalBindingSource.AddNew()

            todaydate.Text = My.Settings.todaycheck


            orderno.Text = My.Settings.ordercountday

            LiqfinalBindingSource.EndEdit()
            LiqfinalTableAdapter.Update(Liqdbase.liqfinal)

            LiqfinalBindingSource.RemoveFilter()

            LiqfinalBindingSource.Filter = String.Format("OrderDate = #{0:dd/MMM/yy}#", fromdate.Value)
            With DbfinalDataGridView
                .DataSource = LiqfinalBindingSource
            End With

        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Try
            If cuppucount.Text & lattecount.Text & mochacount.Text & blackcount.Text & caramelmaccount.Text & vanillalattecount.Text & hazelnutlattecount.Text & coldcofcount.Text & chococoldcofcount.Text & vanillacoldcofcount.Text & caramelcoldcofcount.Text & lassicount.Text & espressolassicount.Text & mangolassicount.Text & virsanfrancount.Text & virsangriacount.Text & virapplecount.Text & grapeinvadecount.Text & bluebersparkcount.Text & yellowpunchcount.Text & darkcurrantcount.Text & vanillamilkcount.Text & chocomilkcount.Text & mangomilkcount.Text & strawberrymilkcount.Text & bananamilkcount.Text & peanutbuttermilkcount.Text & lemonmojitocount.Text & orangelemoncount.Text & oreocount.Text & snickerscount.Text & kitkatcount.Text & darkchococount.Text & ferrerocount.Text & chocochilcofcount.Text & caramelchilcofcount.Text & hazelchilcofcount.Text & peanutchilcount.Text & berryicedteacount.Text & strawicedteacount.Text & raspicedteacount.Text = 0 Then
                MsgBox("There is no order")
            Else


                'My.Settings.alltotorder = My.Settings.alltotorder - uigrandtotal.Text
                My.Settings.Save()
                LiqfinalBindingSource.RemoveCurrent()
                LiqfinalBindingSource.RemoveFilter()
                CheckBox1.Checked = False
                LiqfinalBindingSource.Filter = String.Format("OrderDate = #{0:dd/MMM/yy}#", fromdate.Value)
                With DbfinalDataGridView
                    .DataSource = LiqfinalBindingSource
                End With
                LiqfinalBindingSource.MoveLast()
                If orderquant.Text = Nothing Then
                    orderno.Text = My.Settings.ordercountday

                    LiqfinalBindingSource.EndEdit()
                    LiqfinalTableAdapter.Update(Liqdbase.liqfinal)

                    If My.Settings.ordercountday = 0 Then
                        MsgBox("No Order Till Now!")

                    End If

                Else
                    orderno.Text = My.Settings.ordercountday
                    LiqfinalBindingSource.AddNew()
                    LiqfinalBindingSource.EndEdit()
                    LiqfinalTableAdapter.Update(Liqdbase.liqfinal)
                End If

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles due.CheckedChanged
        If orderquant.Text = Nothing Then

            If due.Checked = True Then
                duetextbox.ReadOnly = False
                duetextbox.Cursor = Cursors.IBeam
            Else
                duetextbox.ReadOnly = True
                duetextbox.Cursor = Cursors.No
            End If
        Else
            Dim results As Integer = MessageBox.Show("Did this customer paid for his purchase?", "Due Customer", MessageBoxButtons.YesNo)
            If results = DialogResult.Yes Then
                'DbfinalDataGridView.Rows(4).Cells(0).Value = Nothing
                duetextbox.Text = Nothing
                duechecked.Text = Nothing

            ElseIf results = DialogResult.No Then
                If due.Checked = True Then
                    duetextbox.ReadOnly = False
                    duetextbox.Cursor = Cursors.IBeam
                Else
                    duetextbox.ReadOnly = True
                    duetextbox.Cursor = Cursors.No
                End If

            End If
        End If
    End Sub

    Private Sub totalorderbutton_Click(sender As Object, e As EventArgs) Handles totalorderbutton.Click
        message.Show()
    End Sub

    Private Sub LiqdataDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        due.Visible = False
    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bao As SqlConnection
        bao = New SqlConnection

        bao.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbase.mdf;Integrated Security=True"
        bao.Open()
        Dim cmd = bao.CreateCommand()
        cmd.CommandTimeout = 420


        Try

            bao.Open()

            Me.LiqfinalTableAdapter.Fill(Me.Liqdbase.liqfinal)

            My.Settings.Reset()
            My.Settings.Save()
            orderno.Text = My.Settings.ordercountday
        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub prevorderdb_Click(sender As Object, e As EventArgs) Handles prevorderdb.Click
        LiqfinalBindingSource.MovePrevious()
    End Sub



    Private Sub listviewupdate_Tick(sender As Object, e As EventArgs) Handles listviewupdate.Tick
        'Listview Update After Every 5 Seconds
        ListView1.Items.Clear()
        'Cuppuccino H1
        Try
            If cuppucount.Text > 0 Then
                Dim add As New ListViewItem(h1lab.Text$)
                add.SubItems.Add(h1)
                add.SubItems.Add(cuppucount.Text$)
                add.SubItems.Add(h1 * cuppucount.Text)
                ListView1.Items.Add(add)
            ElseIf cuppucount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = h1lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'Latte H2
            If lattecount.Text > 0 Then
                Dim add As New ListViewItem(h2lab.Text$)
                add.SubItems.Add(h2)
                add.SubItems.Add(lattecount.Text$)
                add.SubItems.Add(h2 * lattecount.Text)
                ListView1.Items.Add(add)
            ElseIf lattecount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = h2lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'Cafe Mocha H3
            If mochacount.Text > 0 Then
                Dim add As New ListViewItem(h3lab.Text$)
                add.SubItems.Add(h3)
                add.SubItems.Add(mochacount.Text$)
                add.SubItems.Add(h3 * mochacount.Text)
                ListView1.Items.Add(add)
            ElseIf mochacount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = h3lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'Black Coffee h4
            If blackcount.Text > 0 Then
                Dim add As New ListViewItem(h4lab.Text$)
                add.SubItems.Add(h4)
                add.SubItems.Add(blackcount.Text$)
                add.SubItems.Add(h4 * blackcount.Text)
                ListView1.Items.Add(add)
            ElseIf blackcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = h4lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'Caramel Macchiato h5
            If caramelmaccount.Text > 0 Then
                Dim add As New ListViewItem(h5lab.Text$)
                add.SubItems.Add(h5)
                add.SubItems.Add(caramelmaccount.Text$)
                add.SubItems.Add(h5 * caramelmaccount.Text)
                ListView1.Items.Add(add)
            ElseIf caramelmaccount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = h5lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'Vanilla Latte h6
            If vanillalattecount.Text > 0 Then
                Dim add As New ListViewItem(h6lab.Text$)
                add.SubItems.Add(h6)
                add.SubItems.Add(vanillalattecount.Text$)
                add.SubItems.Add(h6 * vanillalattecount.Text)
                ListView1.Items.Add(add)
            ElseIf vanillalattecount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = h6lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'Hazelnut Latte h7
            If hazelnutlattecount.Text > 0 Then
                Dim add As New ListViewItem(h7lab.Text$)
                add.SubItems.Add(h7)
                add.SubItems.Add(hazelnutlattecount.Text$)
                add.SubItems.Add(h7 * hazelnutlattecount.Text)
                ListView1.Items.Add(add)
            ElseIf hazelnutlattecount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = h7lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'Cold Coffee Regular c1
            If coldcofcount.Text > 0 Then
                Dim add As New ListViewItem(c1lab.Text$)
                add.SubItems.Add(c1)
                add.SubItems.Add(coldcofcount.Text$)
                add.SubItems.Add(c1 * coldcofcount.Text)
                ListView1.Items.Add(add)
            ElseIf coldcofcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = c1lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'Chocolate Cold Coffee c2
            If chococoldcofcount.Text > 0 Then
                Dim add As New ListViewItem(c2lab.Text$)
                add.SubItems.Add(c2)
                add.SubItems.Add(chococoldcofcount.Text$)
                add.SubItems.Add(c2 * chococoldcofcount.Text)
                ListView1.Items.Add(add)
            ElseIf chococoldcofcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = c2lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'Vanilla Cold Coffee c3
            If vanillacoldcofcount.Text > 0 Then
                Dim add As New ListViewItem(c3lab.Text$)
                add.SubItems.Add(c3)
                add.SubItems.Add(vanillacoldcofcount.Text$)
                add.SubItems.Add(c3 * vanillacoldcofcount.Text)
                ListView1.Items.Add(add)
            ElseIf vanillacoldcofcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = c3lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'Caramel Cold Coffee c4
            If caramelcoldcofcount.Text > 0 Then
                Dim add As New ListViewItem(c4lab.Text$)
                add.SubItems.Add(c4)
                add.SubItems.Add(caramelcoldcofcount.Text$)
                add.SubItems.Add(c4 * caramelcoldcofcount.Text)
                ListView1.Items.Add(add)
            ElseIf caramelcoldcofcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = c4lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'Lassi Regular L1
            If lassicount.Text > 0 Then
                Dim add As New ListViewItem(l1lab.Text$)
                add.SubItems.Add(l1)
                add.SubItems.Add(lassicount.Text$)
                add.SubItems.Add(l1 * lassicount.Text)
                ListView1.Items.Add(add)
            ElseIf lassicount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = l1lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'Espresso Lassi L2
            If espressolassicount.Text > 0 Then
                Dim add As New ListViewItem(l2lab.Text$)
                add.SubItems.Add(l2)
                add.SubItems.Add(espressolassicount.Text$)
                add.SubItems.Add(l2 * espressolassicount.Text)
                ListView1.Items.Add(add)
            ElseIf espressolassicount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = l2lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'Mango Lassi L3
            If mangolassicount.Text > 0 Then
                Dim add As New ListViewItem(l3lab.Text$)
                add.SubItems.Add(l3)
                add.SubItems.Add(mangolassicount.Text$)
                add.SubItems.Add(l3 * mangolassicount.Text)
                ListView1.Items.Add(add)
            ElseIf mangolassicount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = l3lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'K1 Virgin Sanfrancisco
            If virsanfrancount.Text > 0 Then
                Dim add As New ListViewItem(k1lab.Text$)
                add.SubItems.Add(k1)
                add.SubItems.Add(virsanfrancount.Text$)
                add.SubItems.Add(k1 * virsanfrancount.Text)
                ListView1.Items.Add(add)
            ElseIf virsanfrancount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = k1lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'K2 Virgin Sangria
            If virsangriacount.Text > 0 Then
                Dim add As New ListViewItem(k2lab.Text$)
                add.SubItems.Add(k2)
                add.SubItems.Add(virsangriacount.Text$)
                add.SubItems.Add(k2 * virsangriacount.Text)
                ListView1.Items.Add(add)
            ElseIf virsangriacount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = k2lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'K3 Virgin Appletini
            If virapplecount.Text > 0 Then
                Dim add As New ListViewItem(k3lab.Text$)
                add.SubItems.Add(k3)
                add.SubItems.Add(virapplecount.Text$)
                add.SubItems.Add(k3 * virapplecount.Text)
                ListView1.Items.Add(add)
            ElseIf virapplecount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = k3lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'K4 Grape Invader
            If grapeinvadecount.Text > 0 Then
                Dim add As New ListViewItem(k4lab.Text$)
                add.SubItems.Add(k4)
                add.SubItems.Add(grapeinvadecount.Text$)
                add.SubItems.Add(k4 * grapeinvadecount.Text)
                ListView1.Items.Add(add)
            ElseIf grapeinvadecount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = k4lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'K5 Blueberry Sparkler
            If bluebersparkcount.Text > 0 Then
                Dim add As New ListViewItem(k5lab.Text$)
                add.SubItems.Add(k5)
                add.SubItems.Add(bluebersparkcount.Text$)
                add.SubItems.Add(k5 * bluebersparkcount.Text)
                ListView1.Items.Add(add)
            ElseIf bluebersparkcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = k5lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'K6 Yellow Punch
            If yellowpunchcount.Text > 0 Then
                Dim add As New ListViewItem(k6lab.Text$)
                add.SubItems.Add(k6)
                add.SubItems.Add(yellowpunchcount.Text$)
                add.SubItems.Add(k6 * yellowpunchcount.Text)
                ListView1.Items.Add(add)
            ElseIf yellowpunchcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = k6lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'K7 Dark Currant
            If darkcurrantcount.Text > 0 Then
                Dim add As New ListViewItem(k7lab.Text$)
                add.SubItems.Add(k7)
                add.SubItems.Add(darkcurrantcount.Text$)
                add.SubItems.Add(k7 * darkcurrantcount.Text)
                ListView1.Items.Add(add)
            ElseIf darkcurrantcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = k7lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'M1 Vanilla Milk Shake
            If vanillamilkcount.Text > 0 Then
                Dim add As New ListViewItem(m1lab.Text$)
                add.SubItems.Add(m1)
                add.SubItems.Add(vanillamilkcount.Text$)
                add.SubItems.Add(m1 * vanillamilkcount.Text)
                ListView1.Items.Add(add)
            ElseIf vanillamilkcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = m1lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'M2 Chocolate Milkshake
            If chocomilkcount.Text > 0 Then
                Dim add As New ListViewItem(m2lab.Text$)
                add.SubItems.Add(m2)
                add.SubItems.Add(chocomilkcount.Text$)
                add.SubItems.Add(m2 * chocomilkcount.Text)
                ListView1.Items.Add(add)
            ElseIf chocomilkcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = m2lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'M3 Mango Milkshake
            If mangomilkcount.Text > 0 Then
                Dim add As New ListViewItem(m3lab.Text$)
                add.SubItems.Add(m3)
                add.SubItems.Add(mangomilkcount.Text$)
                add.SubItems.Add(m3 * mangomilkcount.Text)
                ListView1.Items.Add(add)
            ElseIf mangomilkcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = m3lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'M4 Strawberry Milkshake
            If strawberrymilkcount.Text > 0 Then
                Dim add As New ListViewItem(m4lab.Text$)
                add.SubItems.Add(m4)
                add.SubItems.Add(strawberrymilkcount.Text$)
                add.SubItems.Add(m4 * strawberrymilkcount.Text)
                ListView1.Items.Add(add)
            ElseIf strawberrymilkcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = m4lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'M5 Banana Milkshake 
            If bananamilkcount.Text > 0 Then
                Dim add As New ListViewItem(m5lab.Text$)
                add.SubItems.Add(m5)
                add.SubItems.Add(bananamilkcount.Text$)
                add.SubItems.Add(m5 * bananamilkcount.Text)
                ListView1.Items.Add(add)
            ElseIf bananamilkcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = m5lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'M6 Peanut Butter Milk shake
            If peanutbuttermilkcount.Text > 0 Then
                Dim add As New ListViewItem(m6lab.Text$)
                add.SubItems.Add(m6)
                add.SubItems.Add(peanutbuttermilkcount.Text$)
                add.SubItems.Add(m6 * peanutbuttermilkcount.Text)
                ListView1.Items.Add(add)
            ElseIf peanutbuttermilkcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = m6lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'N1 Lemon Mojito
            If lemonmojitocount.Text > 0 Then
                Dim add As New ListViewItem(n1lab.Text$)
                add.SubItems.Add(n1)
                add.SubItems.Add(lemonmojitocount.Text$)
                add.SubItems.Add(n1 * lemonmojitocount.Text)
                ListView1.Items.Add(add)
            ElseIf lemonmojitocount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = n1lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'N2 Orange Lemonade
            If orangelemoncount.Text > 0 Then
                Dim add As New ListViewItem(n2lab.Text$)
                add.SubItems.Add(n2)
                add.SubItems.Add(orangelemoncount.Text$)
                add.SubItems.Add(n2 * orangelemoncount.Text)
                ListView1.Items.Add(add)
            ElseIf orangelemoncount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = n2lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'R1 Oreo Crusher
            If oreocount.Text > 0 Then
                Dim add As New ListViewItem(r1lab.Text$)
                add.SubItems.Add(r1)
                add.SubItems.Add(oreocount.Text$)
                add.SubItems.Add(r1 * oreocount.Text)
                ListView1.Items.Add(add)
            ElseIf oreocount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = r1lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'R2 Snickers Crusher
            If snickerscount.Text > 0 Then
                Dim add As New ListViewItem(r2lab.Text$)
                add.SubItems.Add(r2)
                add.SubItems.Add(snickerscount.Text$)
                add.SubItems.Add(r2 * snickerscount.Text)
                ListView1.Items.Add(add)
            ElseIf snickerscount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = r2lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'R3 Kitkat Crusher
            If kitkatcount.Text > 0 Then
                Dim add As New ListViewItem(r3lab.Text$)
                add.SubItems.Add(r3)
                add.SubItems.Add(kitkatcount.Text$)
                add.SubItems.Add(r3 * kitkatcount.Text)
                ListView1.Items.Add(add)
            ElseIf kitkatcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = r3lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'R4 Dark Chocolate Crusher
            If darkchococount.Text > 0 Then
                Dim add As New ListViewItem(r4lab.Text$)
                add.SubItems.Add(r4)
                add.SubItems.Add(darkchococount.Text$)
                add.SubItems.Add(r4 * darkchococount.Text)
                ListView1.Items.Add(add)
            ElseIf darkchococount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = r4lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'R5 Ferrero Rocher Crusher
            If ferrerocount.Text > 0 Then
                Dim add As New ListViewItem(r5lab.Text$)
                add.SubItems.Add(r5)
                add.SubItems.Add(ferrerocount.Text$)
                add.SubItems.Add(r5 * ferrerocount.Text)
                ListView1.Items.Add(add)
            ElseIf ferrerocount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = r5lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'P1 Chocolate Chilled Coffee
            If chocochilcofcount.Text > 0 Then
                Dim add As New ListViewItem(p1lab.Text$)
                add.SubItems.Add(p1)
                add.SubItems.Add(chocochilcofcount.Text$)
                add.SubItems.Add(p1 * chocochilcofcount.Text)
                ListView1.Items.Add(add)
            ElseIf chocochilcofcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = p1lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'P2 Caramel Chilled Coffee
            If caramelchilcofcount.Text > 0 Then
                Dim add As New ListViewItem(p2lab.Text$)
                add.SubItems.Add(p2)
                add.SubItems.Add(caramelchilcofcount.Text$)
                add.SubItems.Add(p2 * caramelchilcofcount.Text)
                ListView1.Items.Add(add)
            ElseIf caramelchilcofcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = p2lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'P3 Hazelnut Chilled Coffee
            If hazelchilcofcount.Text > 0 Then
                Dim add As New ListViewItem(p3lab.Text$)
                add.SubItems.Add(p3)
                add.SubItems.Add(hazelchilcofcount.Text$)
                add.SubItems.Add(p3 * hazelchilcofcount.Text)
                ListView1.Items.Add(add)
            ElseIf hazelchilcofcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = p3lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'P4 Peanut Butter Chilled Coffee
            If peanutchilcount.Text > 0 Then
                Dim add As New ListViewItem(p4lab.Text$)
                add.SubItems.Add(p4)
                add.SubItems.Add(peanutchilcount.Text$)
                add.SubItems.Add(p4 * peanutchilcount.Text)
                ListView1.Items.Add(add)
            ElseIf peanutchilcount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = p4lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'T1 Very Berry Iced Tea
            If berryicedteacount.Text > 0 Then
                Dim add As New ListViewItem(t1lab.Text$)
                add.SubItems.Add(t1)
                add.SubItems.Add(berryicedteacount.Text$)
                add.SubItems.Add(t1 * berryicedteacount.Text)
                ListView1.Items.Add(add)
            ElseIf berryicedteacount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = t1lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'T2 Strawberry Iced Tea
            If strawicedteacount.Text > 0 Then
                Dim add As New ListViewItem(t2lab.Text$)
                add.SubItems.Add(t2)
                add.SubItems.Add(strawicedteacount.Text$)
                add.SubItems.Add(t2 * strawicedteacount.Text)
                ListView1.Items.Add(add)
            ElseIf strawicedteacount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = t2lab.Text).First)
                Catch ex As Exception
                End Try
            End If
            'T3 Raspberry Iced Tea
            If raspicedteacount.Text > 0 Then
                Dim add As New ListViewItem(t3lab.Text$)
                add.SubItems.Add(t3)
                add.SubItems.Add(raspicedteacount.Text$)
                add.SubItems.Add(t3 * raspicedteacount.Text)
                ListView1.Items.Add(add)
            ElseIf raspicedteacount.Text < 1 Then
                Try
                    ListView1.Items.Remove((From i In ListView1.Items.OfType(Of ListViewItem)()
                                            Where i.Text = t3lab.Text).First)
                Catch ex As Exception
                End Try
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DbfinalBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LiqfinalBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Liqdbase)

    End Sub



    Private Sub duechecked_TextChanged(sender As Object, e As EventArgs) Handles duechecked.TextChanged
        If duechecked.Text = Nothing Then
            duechecked.BackColor = Color.LightGray
        Else
            duechecked.BackColor = Color.DarkSeaGreen
        End If

    End Sub





    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then

            Try
                LiqfinalBindingSource.Filter = "(Due LIKE 'Due')"

                With DbfinalDataGridView
                    .DataSource = LiqfinalBindingSource
                End With
            Catch ex As Exception

            End Try
        Else

            LiqfinalBindingSource.RemoveFilter()
            LiqfinalBindingSource.Filter = String.Format("OrderDate = #{0:dd/MMM/yy}#", fromdate.Value)
            With DbfinalDataGridView
                .DataSource = LiqfinalBindingSource
            End With
            LiqfinalBindingSource.MoveLast()

        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)

        'LiqfinalBindingSource.Filter = String.Format("OrderDate >= #{0:dd/MMM/yy}# And OrderDate <= #{1:dd/MMM/yy}#", fromdate.Value, todate.Value)
        LiqfinalBindingSource.Filter = String.Format("OrderDate = #{0:dd/MMM/yy}#", fromdate.Value)
        With DbfinalDataGridView
            .DataSource = LiqfinalBindingSource
        End With

    End Sub

    Private Sub dbsearchbox_TextChanged(sender As Object, e As EventArgs) Handles dbsearchbox.TextChanged

        If dbsearchbox.Text = Nothing Then

            LiqfinalBindingSource.RemoveFilter()
            LiqfinalBindingSource.Filter = String.Format("OrderDate = #{0:dd/MMM/yy}#", fromdate.Value)
            With DbfinalDataGridView
                .DataSource = LiqfinalBindingSource
            End With
            CheckBox1.Checked = False
            'LiqfinalBindingSource.MoveLast()
        ElseIf dbsearchbox.Text = "all" Then
            LiqfinalBindingSource.RemoveFilter()

        Else

            Try
                LiqfinalBindingSource.Filter = "(CustomerName LIKE '" & dbsearchbox.Text & "') or (OrderNumber LIKE '" & dbsearchbox.Text & "')"

                With DbfinalDataGridView
                    .DataSource = LiqfinalBindingSource
                End With
            Catch ex As Exception
            End Try



        End If



    End Sub

    Private Sub fromdate_ValueChanged(sender As Object, e As EventArgs) Handles fromdate.ValueChanged
        LiqfinalBindingSource.Filter = String.Format("OrderDate = #{0:dd/MMM/yy}#", fromdate.Value)
        With DbfinalDataGridView
            .DataSource = LiqfinalBindingSource
        End With
    End Sub

    Public Shared Function SearchFile(ByVal strFilePath As String, ByVal strSearchTerm As String) As String
        Dim sr As StreamReader = New StreamReader(strFilePath)
        Dim strLine As String = String.Empty

        Try
            Do While sr.Peek() >= 0
                strLine = String.Empty
                strLine = sr.ReadLine
                If strLine.Contains(strSearchTerm) Then
                    sr.Close()
                    Exit Do
                End If
            Loop

            Return strLine
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function

    Private Sub clearalllist()
        ListView1.Items.Clear()
        cuppucount.Text = 0
        lattecount.Text = 0
        mochacount.Text = 0
        blackcount.Text = 0
        caramelmaccount.Text = 0
        vanillalattecount.Text = 0
        hazelnutlattecount.Text = 0
        'Cold Coffee
        coldcofcount.Text = 0
        chococoldcofcount.Text = 0
        vanillacoldcofcount.Text = 0
        caramelcoldcofcount.Text = 0
        'Lassi
        lassicount.Text = 0
        espressolassicount.Text = 0
        mangolassicount.Text = 0
        'Mocktail
        virsanfrancount.Text = 0
        virsangriacount.Text = 0
        virapplecount.Text = 0
        grapeinvadecount.Text = 0
        bluebersparkcount.Text = 0
        yellowpunchcount.Text = 0
        darkcurrantcount.Text = 0
        'Milk Shake
        vanillamilkcount.Text = 0
        chocomilkcount.Text = 0
        mangomilkcount.Text = 0
        strawberrymilkcount.Text = 0
        bananamilkcount.Text = 0
        peanutbuttermilkcount.Text = 0
        'Lemonade
        lemonmojitocount.Text = 0
        orangelemoncount.Text = 0
        'Crusher
        oreocount.Text = 0
        snickerscount.Text = 0
        kitkatcount.Text = 0
        darkchococount.Text = 0
        ferrerocount.Text = 0
        'Premium Chilled Coffee
        chocochilcofcount.Text = 0
        caramelchilcofcount.Text = 0
        hazelchilcofcount.Text = 0
        peanutchilcount.Text = 0
        'Iced Tea
        berryicedteacount.Text = 0
        strawicedteacount.Text = 0
        raspicedteacount.Text = 0
        uicashback.Text = Nothing
        uicashrec.Text = Nothing
        uidiscount.Text = Nothing
        uigrandtotal.Text = Nothing
        uitotalprice.Text = Nothing
        due.Checked = False
        duetextbox.Text = Nothing
        If DbfinalDataGridView.Visible = True Then
            DbfinalDataGridView.Visible = False
            fromdate.Visible = False
            dbsearchbox.Visible = False
            CheckBox1.Checked = False
            ordrtoday.Visible = False
            totordercount.Visible = False
            orderno.Location = New Point(100, 61)
            todaydate.Location = New Point(100, 147)
        End If
        message.Close()
        analyzeform.Close()
        TabControl1.SelectTab(0)
    End Sub
End Class



